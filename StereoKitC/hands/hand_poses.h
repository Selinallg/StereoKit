#pragma once

#include "../stereokit.h"

namespace sk {

const float hand_joint_size[25] = {0.020f, 0.020f, 0.012f, 0.010f, 0.009f, 0.021f, 0.010f, 0.009f, 0.008f, 0.007f, 0.021f, 0.011f, 0.008f, 0.008f, 0.007f, 0.019f, 0.010f, 0.008f, 0.007f, 0.006f, 0.018f, 0.009f, 0.007f, 0.006f, 0.005f};

pose_t input_pose_fist   [25] = { {{-0.018f,-0.049f,-0.016f},{-0.671f,0.228f,-0.496f,-0.502f}},{{-0.018f,-0.049f,-0.016f},{-0.468f,0.226f,-0.554f,-0.651f}},{{-0.029f,-0.006f,-0.039f},{-0.260f,0.421f,-0.430f,-0.755f}},{{-0.015f,0.019f,-0.056f},{-0.016f,0.575f,-0.254f,-0.778f}},{{0.000f,0.025f,-0.062f},{-0.016f,0.575f,-0.254f,-0.778f}},{{-0.012f,-0.039f,0.006f},{-0.652f,-0.055f,-0.064f,-0.754f}},{{-0.024f,0.035f,-0.005f},{0.057f,0.044f,-0.050f,-0.996f}},{{-0.020f,0.031f,-0.047f},{0.737f,-0.014f,-0.000f,-0.675f}},{{-0.021f,0.007f,-0.045f},{-0.904f,0.036f,-0.021f,0.425f}},{{-0.022f,-0.003f,-0.037f},{-0.904f,0.036f,-0.021f,0.425f}},{{0.001f,-0.036f,0.005f},{-0.651f,-0.060f,0.046f,-0.755f}},{{-0.001f,0.036f,-0.005f},{0.064f,-0.055f,0.009f,-0.996f}},{{-0.006f,0.030f,-0.052f},{0.739f,-0.099f,-0.028f,-0.666f}},{{-0.009f,0.002f,-0.049f},{0.903f,-0.102f,-0.039f,-0.416f}},{{-0.009f,-0.009f,-0.040f},{0.903f,-0.102f,-0.039f,-0.416f}},{{0.013f,-0.035f,0.003f},{-0.653f,-0.027f,0.123f,-0.747f}},{{0.021f,0.029f,-0.007f},{0.065f,-0.068f,0.101f,-0.990f}},{{0.015f,0.024f,-0.050f},{0.706f,-0.192f,0.033f,-0.681f}},{{0.006f,-0.002f,-0.048f},{0.873f,-0.215f,-0.001f,-0.438f}},{{0.004f,-0.013f,-0.039f},{0.873f,-0.215f,-0.001f,-0.438f}},{{0.026f,-0.037f,-0.004f},{-0.669f,-0.028f,0.224f,-0.708f}},{{0.042f,0.021f,-0.010f},{0.031f,-0.141f,0.173f,-0.974f}},{{0.032f,0.020f,-0.044f},{0.655f,-0.294f,0.039f,-0.695f}},{{0.023f,0.003f,-0.043f},{0.826f,-0.315f,-0.026f,-0.466f}},{{0.019f,-0.007f,-0.036f},{0.826f,-0.315f,-0.026f,-0.466f}} };
pose_t input_pose_neutral[25] = { {{-0.019f,-0.046f,-0.018f},{-0.669f,0.228f,-0.497f,-0.503f}},{{-0.019f,-0.046f,-0.018f},{-0.577f,0.103f,-0.629f,-0.511f}},{{-0.049f,-0.012f,-0.033f},{-0.523f,0.148f,-0.627f,-0.558f}},{{-0.066f,0.014f,-0.046f},{-0.470f,0.188f,-0.620f,-0.599f}},{{-0.072f,0.028f,-0.055f},{-0.470f,0.188f,-0.620f,-0.599f}},{{-0.011f,-0.038f,0.004f},{-0.650f,-0.055f,-0.064f,-0.755f}},{{-0.023f,0.034f,-0.007f},{-0.637f,-0.029f,-0.044f,-0.769f}},{{-0.028f,0.074f,-0.015f},{-0.423f,-0.013f,-0.047f,-0.905f}},{{-0.029f,0.092f,-0.030f},{-0.193f,0.004f,-0.046f,-0.980f}},{{-0.029f,0.097f,-0.041f},{-0.193f,0.004f,-0.046f,-0.980f}},{{0.001f,-0.035f,0.005f},{-0.650f,-0.059f,0.046f,-0.756f}},{{-0.001f,0.035f,-0.005f},{-0.633f,-0.048f,0.054f,-0.771f}},{{-0.001f,0.080f,-0.014f},{-0.523f,-0.041f,0.058f,-0.849f}},{{-0.002f,0.104f,-0.026f},{-0.271f,-0.023f,0.065f,-0.960f}},{{-0.002f,0.111f,-0.038f},{-0.271f,-0.023f,0.065f,-0.960f}},{{0.013f,-0.033f,0.003f},{-0.652f,-0.026f,0.122f,-0.748f}},{{0.021f,0.029f,-0.007f},{-0.660f,-0.008f,0.136f,-0.738f}},{{0.028f,0.072f,-0.012f},{-0.500f,-0.028f,0.138f,-0.854f}},{{0.031f,0.095f,-0.026f},{-0.339f,-0.044f,0.136f,-0.930f}},{{0.031f,0.103f,-0.036f},{-0.339f,-0.044f,0.136f,-0.930f}},{{0.025f,-0.036f,-0.005f},{-0.668f,-0.027f,0.223f,-0.709f}},{{0.040f,0.021f,-0.012f},{-0.657f,0.012f,0.259f,-0.708f}},{{0.052f,0.052f,-0.016f},{-0.491f,-0.033f,0.265f,-0.829f}},{{0.056f,0.068f,-0.026f},{-0.321f,-0.073f,0.259f,-0.908f}},{{0.057f,0.076f,-0.036f},{-0.321f,-0.073f,0.259f,-0.908f}} };
pose_t input_pose_point  [25] = { {{-0.019f,-0.042f,-0.017f},{-0.669f,0.227f,-0.497f,-0.503f}},{{-0.019f,-0.042f,-0.017f},{-0.637f,0.103f,-0.608f,-0.463f}},{{-0.050f,-0.010f,-0.024f},{-0.654f,0.076f,-0.614f,-0.436f}},{{-0.073f,0.011f,-0.029f},{-0.674f,0.043f,-0.619f,-0.402f}},{{-0.086f,0.021f,-0.030f},{-0.674f,0.043f,-0.619f,-0.402f}},{{-0.010f,-0.037f,0.004f},{-0.650f,-0.055f,-0.064f,-0.756f}},{{-0.022f,0.033f,-0.007f},{-0.638f,0.021f,-0.001f,-0.770f}},{{-0.021f,0.071f,-0.014f},{-0.632f,0.020f,-0.002f,-0.774f}},{{-0.021f,0.093f,-0.019f},{-0.607f,0.009f,-0.010f,-0.795f}},{{-0.020f,0.104f,-0.022f},{-0.607f,0.009f,-0.010f,-0.795f}},{{0.001f,-0.034f,0.005f},{-0.649f,-0.059f,0.045f,-0.757f}},{{-0.001f,0.034f,-0.005f},{-0.017f,-0.081f,-0.008f,-0.997f}},{{-0.008f,0.035f,-0.048f},{0.630f,-0.055f,-0.058f,-0.772f}},{{-0.008f,0.010f,-0.053f},{0.857f,-0.031f,-0.074f,-0.509f}},{{-0.007f,-0.001f,-0.047f},{0.857f,-0.031f,-0.074f,-0.509f}},{{0.013f,-0.032f,0.003f},{-0.651f,-0.026f,0.122f,-0.748f}},{{0.020f,0.028f,-0.006f},{-0.004f,-0.101f,0.074f,-0.992f}},{{0.012f,0.029f,-0.046f},{0.609f,-0.132f,-0.004f,-0.782f}},{{0.007f,0.005f,-0.051f},{0.852f,-0.125f,-0.049f,-0.505f}},{{0.006f,-0.006f,-0.045f},{0.852f,-0.125f,-0.049f,-0.505f}},{{0.024f,-0.034f,-0.005f},{-0.667f,-0.027f,0.223f,-0.710f}},{{0.039f,0.020f,-0.011f},{-0.042f,-0.162f,0.155f,-0.974f}},{{0.029f,0.024f,-0.041f},{0.563f,-0.226f,0.023f,-0.795f}},{{0.022f,0.009f,-0.046f},{0.808f,-0.222f,-0.057f,-0.542f}},{{0.020f,-0.002f,-0.041f},{0.808f,-0.222f,-0.057f,-0.542f}} };
pose_t input_pose_pinch  [25] = { {{-0.019f,-0.043f,-0.018f},{-0.669f,0.228f,-0.497f,-0.503f}},{{-0.019f,-0.043f,-0.018f},{-0.434f,0.206f,-0.576f,-0.662f}},{{-0.030f,-0.006f,-0.042f},{-0.378f,0.257f,-0.554f,-0.695f}},{{-0.031f,0.019f,-0.061f},{-0.269f,0.347f,-0.504f,-0.744f}},{{-0.027f,0.032f,-0.071f},{-0.269f,0.347f,-0.504f,-0.744f}},{{-0.011f,-0.038f,0.003f},{-0.650f,-0.055f,-0.064f,-0.755f}},{{-0.023f,0.032f,-0.008f},{-0.297f,-0.043f,-0.096f,-0.949f}},{{-0.028f,0.054f,-0.040f},{0.199f,0.036f,-0.096f,-0.975f}},{{-0.026f,0.046f,-0.060f},{0.427f,0.073f,-0.087f,-0.897f}},{{-0.023f,0.037f,-0.067f},{0.427f,0.073f,-0.087f,-0.897f}},{{0.001f,-0.034f,0.005f},{-0.650f,-0.059f,0.046f,-0.756f}},{{-0.001f,0.034f,-0.005f},{-0.537f,-0.102f,0.005f,-0.837f}},{{-0.008f,0.073f,-0.023f},{-0.309f,-0.092f,-0.016f,-0.946f}},{{-0.013f,0.088f,-0.043f},{-0.148f,-0.083f,-0.029f,-0.985f}},{{-0.015f,0.092f,-0.055f},{-0.148f,-0.083f,-0.029f,-0.985f}},{{0.013f,-0.032f,0.002f},{-0.652f,-0.026f,0.123f,-0.748f}},{{0.020f,0.028f,-0.007f},{-0.618f,-0.072f,0.086f,-0.778f}},{{0.020f,0.068f,-0.016f},{-0.477f,-0.089f,0.070f,-0.871f}},{{0.018f,0.089f,-0.030f},{-0.361f,-0.101f,0.056f,-0.925f}},{{0.016f,0.098f,-0.039f},{-0.361f,-0.101f,0.056f,-0.925f}},{{0.024f,-0.034f,-0.006f},{-0.668f,-0.028f,0.223f,-0.709f}},{{0.039f,0.020f,-0.012f},{-0.641f,-0.055f,0.205f,-0.738f}},{{0.044f,0.051f,-0.017f},{-0.527f,-0.098f,0.184f,-0.824f}},{{0.045f,0.068f,-0.025f},{-0.431f,-0.129f,0.165f,-0.878f}},{{0.044f,0.078f,-0.032f},{-0.431f,-0.129f,0.165f,-0.878f}} };

} // namespace sk