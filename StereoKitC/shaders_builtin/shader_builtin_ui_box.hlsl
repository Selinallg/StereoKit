#include "stereokit.hlsli"

//--name = sk/default_ui_box
//--color:color = .6, .6, .6, 1
//--border_size_min = 0.005
//--border_size_max = 0.03
//--border_affect_radius = 0.2
float4       color;
float        border_size_min;
float        border_size_max;
float        border_affect_radius;

struct vsIn {
	float4 pos  : SV_Position;
	float3 norm : NORMAL0;
	float2 uv   : TEXCOORD0;
	float4 col  : COLOR0;
};
struct psIn {
	float4 pos   : SV_POSITION;
	float3 normal: NORMAL0;
	float2 uv    : TEXCOORD0;
	float4 color : COLOR0;
	float4 world : TEXCOORD1;
	uint view_id : SV_RenderTargetArrayIndex;
};

psIn vs(vsIn input, uint id : SV_InstanceID) {
	psIn o;
	o.view_id = id % sk_view_count;
	id        = id / sk_view_count;

	// Extract scale from the matrix
	float4x4 world_mat = sk_inst[id].world;
	float3   scale     = float3(
		length(world_mat._11_12_13),
		length(world_mat._21_22_23),
		length(world_mat._31_32_33));

	o.world  = mul(input .pos, sk_inst    [id].world);
	o.pos    = mul(o.world,    sk_viewproj[o.view_id]);
	o.normal = normalize(mul(input.norm, (float3x3)sk_inst[id].world));

	o.uv    = input.uv;
	o.color = color * input.col * sk_inst[id].color;
	return o;
}
float4 ps(psIn input) : SV_TARGET{
	float2 glow = FingerGlowEx(input.world.xyz, input.normal);
	glow.y = (1-min(1,glow.x / 0.12)) * glow.y;
	glow.x = min(1,glow.x / border_affect_radius);
	
	float  border_size= lerp(border_size_max, border_size_min, glow.x);
	float2 border_pos = abs(input.uv - 0.5f);
	float  corner     = saturate((max(border_pos.x, border_pos.y)+border_size-0.5)*100);
	
	if (max(glow.y,corner) < 0.1) discard;

	float4 col  = float4(lerp(input.color.rgb, float3(1,1,1), glow.y), input.color.a);

	return col;
}