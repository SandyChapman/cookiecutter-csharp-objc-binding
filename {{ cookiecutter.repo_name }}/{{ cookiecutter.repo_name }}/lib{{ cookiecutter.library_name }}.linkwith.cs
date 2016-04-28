using System;
using ObjCRuntime;

[assembly: LinkWith ("lib{{ cookiecutter.library_name }}.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64, SmartLink = true, ForceLoad = true, LinkerFlags = "-ObjC")]
