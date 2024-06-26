// This is generated by /tools/Build-SampleGuide.ps1

/// :CodeDoc: Guides 15 Sample Code
/// # StereoKit Sample Code
///
/// Here are a list of small demos that illustrate how
/// certain parts of StereoKit works!
///
/// ## [Asset Enumeration](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoAssets.cs)
/// 
/// If you need to take a peek at what's currently loaded, StereoKit has a couple tools in the Assets class!
/// 
/// This demo is just a quick illustration of how to enumerate through your Assets.
///
/// ![Asset Enumeration]({{site.screen_url}}/Demos/AssetEnumeration.jpg)
///
/// ## [Controllers](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoControllers.cs)
/// 
/// While StereoKit prioritizes hand input, sometimes a controller has more precision! StereoKit provides access to any controllers via the Input.Controller function. This is a debug visualization of the controller data provided there.
/// 
/// StereoKit will simulate hands if only controllers are present, but it will not simulate controllers if only hands are present.
///
/// ![Controllers]({{site.screen_url}}/Demos/Controllers.jpg)
///
/// ## [Device](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoDevice.cs)
/// 
/// The Device class contains a number of interesting bits of data about the device it's running on! Most of this is just information, but there's a few properties that can also be modified.
///
/// ![Device]({{site.screen_url}}/Demos/Device.jpg)
///
/// ## [Eye Tracking](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoEyes.cs)
/// 
/// If the hardware supports it, and permissions are granted, eye tracking is as simple as grabbing Input.Eyes!
/// 
/// This scene is raycasting your eye ray at the indicated plane, and the dot's red/green color indicates eye tracking availability! On flatscreen you can simulate eye tracking with Alt+Mouse.
///
/// ![Eye Tracking]({{site.screen_url}}/Demos/EyeTracking.jpg)
///
/// ## [FB Passthrough Extension](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoFBPassthrough.cs)
/// 
/// Passthrough AR!
///
/// ![FB Passthrough Extension]({{site.screen_url}}/Demos/FBPassthroughExtension.jpg)
///
/// ## [Mesh Generation](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoGeo.cs)
/// 
/// Generating a Mesh or Model via code can be an important task, and StereoKit provides a number of tools to make this pretty easy! In addition to the Default meshes, you can also generate a number of shapes, seen here. (See the Mesh.Gen functions)
/// 
/// If the provided shapes aren't enough, it's also pretty easy to procedurally assemble a mesh of your own from vertices and indices! That's the wavy surface all the way to the right.
///
/// ![Mesh Generation]({{site.screen_url}}/Demos/MeshGeneration.jpg)
///
/// ## [Hand Sim Poses](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoHandPoses.cs)
/// 
/// StereoKit simulates hand joints for controllers and mice, but sometimes you really just need to test a funky gesture!
/// 
/// The Input.HandSimPose functions allow you to customize how StereoKit simulates these hand poses, and this scene is a small tool to help you with capturing poses for these functions!
///
/// ![Hand Sim Poses]({{site.screen_url}}/Demos/HandSimPoses.jpg)
///
/// ## [Hand Input](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoHands.cs)
/// 
/// StereoKit uses a hands first approach to user input! Even when hand-sensors aren't available, hand data is simulated instead using existing devices. Check out Input.Hand for all the cool data you get!
/// 
/// This demo is the source for the 'Using Hands' guide, and is a collection of different options and examples of how to get, use, and visualize Hand data.
///
/// ![Hand Input]({{site.screen_url}}/Demos/HandInput.jpg)
///
/// ## [Line Render](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoLineRender.cs)
/// 
/// 
///
/// ![Line Render]({{site.screen_url}}/Demos/LineRender.jpg)
///
/// ## [Lines](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoLines.cs)
/// 
/// 
///
/// ![Lines]({{site.screen_url}}/Demos/Lines.jpg)
///
/// ## [Many Objects](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoManyObjects.cs)
/// 
/// ......
///
/// ![Many Objects]({{site.screen_url}}/Demos/ManyObjects.jpg)
///
/// ## [Materials](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoMaterial.cs)
/// 
/// 
///
/// ![Materials]({{site.screen_url}}/Demos/Materials.jpg)
///
/// ## [Material Chain](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoMaterialChain.cs)
/// 
/// Materials can be chained together to create a multi-pass material! What you're seeing in this sample is an 'Inverted Shell' outline, a two-pass effect where a second render pass is scaled along the normals and flipped inside-out.
///
/// ![Material Chain]({{site.screen_url}}/Demos/MaterialChain.jpg)
///
/// ## [Math](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoMath.cs)
/// 
/// StereoKit has a SIMD optimized math library that provides a wide array of high-level math functions, shapes, and intersection formulas!
/// 
/// In C#, math types are backed by System.Numerics for easy interop with code from the rest of the C# ecosystem.
///
/// ![Math]({{site.screen_url}}/Demos/Math.jpg)
///
/// ## [Microphone](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoMicrophone.cs)
/// 
/// Sometimes you need direct access to the microphone data! Maybe for a special effect, or maybe you just need to stream it to someone else. Well, there's an easy API for that!
/// 
/// This demo shows how to grab input from the microphone, and use it to drive an indicator that tells users that you're listening!
///
/// ![Microphone]({{site.screen_url}}/Demos/Microphone.jpg)
///
/// ## [Model Nodes](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoNodes.cs)
/// 
/// ModelNode API lets...
///
/// ![Model Nodes]({{site.screen_url}}/Demos/ModelNodes.jpg)
///
/// ## [PBR Shaders](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoPBR.cs)
/// 
/// Shaders!
///
/// ![PBR Shaders]({{site.screen_url}}/Demos/PBRShaders.jpg)
///
/// ## [File Picker](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoPicker.cs)
/// 
/// Applications need to save and load files at runtime! StereoKit has a cross-platform, MR compatible file picker built in, Platform.FilePicker.
/// 
/// On systems/conditions where a native file picker is available, that's what you'll get! Otherwise, StereoKit will fall back to a custom picker built with StereoKit's UI.
///
/// ![File Picker]({{site.screen_url}}/Demos/FilePicker.jpg)
///
/// ## [Point Clouds](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoPointCloud.cs)
/// 
/// Point clouds are not a built-in feature of StereoKit, but it's not hard to do this yourself! Check out the code for this demo for a class that'll help you do this directly from data, or from a Model.
///
/// ![Point Clouds]({{site.screen_url}}/Demos/PointClouds.jpg)
///
/// ## [Ray to Mesh](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoRayMesh.cs)
/// 
/// 
///
/// ![Ray to Mesh]({{site.screen_url}}/Demos/RaytoMesh.jpg)
///
/// ## [Record Mic](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoRecordMic.cs)
/// 
/// A common use case for the microphone would be to record a snippet of audio! This demo shows reading data from the Microphone, and using that to create a sound for playback.
///
/// ![Record Mic]({{site.screen_url}}/Demos/RecordMic.jpg)
///
/// ## [Render Scaling](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoRenderScaling.cs)
/// 
/// Sometimes you need to boost the number of pixels your app renders, to reduce jaggies! Renderer.Scaling and Renderer.Multisample let you increase the size of the draw surface, and multisample each pixel.
/// 
/// This is powerful stuff, so use it sparingly!
///
/// ![Render Scaling]({{site.screen_url}}/Demos/RenderScaling.jpg)
///
/// ## [Skeleton Estimation](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoSkeleton.cs)
/// 
/// With knowledge about where the head and hands are, you can make a decent guess about where some other parts of the body are! The StereoKit repository contains an AvatarSkeleton IStepper to show a basic example of how something like this can be done.
///
/// ![Skeleton Estimation]({{site.screen_url}}/Demos/SkeletonEstimation.jpg)
///
/// ## [Sky Editor](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoSky.cs)
/// 
/// 
///
/// ![Sky Editor]({{site.screen_url}}/Demos/SkyEditor.jpg)
///
/// ## [Sound](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoSound.cs)
/// 
/// 
///
/// ![Sound]({{site.screen_url}}/Demos/Sound.jpg)
///
/// ## [Text](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoText.cs)
/// 
/// 
///
/// ![Text]({{site.screen_url}}/Demos/Text.jpg)
///
/// ## [Text Input](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoTextInput.cs)
/// 
/// 
///
/// ![Text Input]({{site.screen_url}}/Demos/TextInput.jpg)
///
/// ## [Procedural Textures](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoTextures.cs)
/// 
/// Here's a quick sample of procedurally assembling a texture!
///
/// ![Procedural Textures]({{site.screen_url}}/Demos/ProceduralTextures.jpg)
///
/// ## [UI](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoUI.cs)
/// 
/// ...
///
/// ![UI]({{site.screen_url}}/Demos/UI.jpg)
///
/// ## [UI Grab Bar](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoUIGrabBar.cs)
/// 
/// This is an example of using external handles to manipulate a Window's pose! Since _you_ own the Pose data, you can do whatever you want with it!
/// The grab bar below the window is a common sight to see in recent XR UI, so here's one way to replicate that with SK's API.
///
/// ![UI Grab Bar]({{site.screen_url}}/Demos/UIGrabBar.jpg)
///
/// ## [UI Settings](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoUISettings.cs)
/// 
/// 
///
/// ![UI Settings]({{site.screen_url}}/Demos/UISettings.jpg)
///
/// ## [UI Tearsheet](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoUITearsheet.cs)
/// 
/// An enumeration of all the different types of UI elements!
///
/// ![UI Tearsheet]({{site.screen_url}}/Demos/UITearsheet.jpg)
///
/// ## [Unicode Text](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoUnicode.cs)
/// 
/// 
///
/// ![Unicode Text]({{site.screen_url}}/Demos/UnicodeText.jpg)
///
/// ## [World Anchor](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoWorldAnchor.cs)
/// 
/// This demo uses UWP's Spatial APIs to add, remove, and load World Anchors that are locked to local physical locations. These can be used for persisting locations across sessions, or increasing the stability of your experiences!
///
/// ## [World Mesh](https://github.com/StereoKit/StereoKit/blob/master/Examples/StereoKitTest/Demos/DemoWorldMesh.cs)
/// 
/// 
///
/// ![World Mesh]({{site.screen_url}}/Demos/WorldMesh.jpg)
///
/// :End:
