using System;
using Plugin.Media.Abstractions;
using UIKit;

internal static class CameraFlashModeExtensions
{
    internal static CameraFlashMode ConvertToShared(this UIImagePickerControllerCameraFlashMode mode) =>
        mode switch
        {
            UIImagePickerControllerCameraFlashMode.Off => CameraFlashMode.Off,
            UIImagePickerControllerCameraFlashMode.Auto => CameraFlashMode.Auto,
            UIImagePickerControllerCameraFlashMode.On => CameraFlashMode.On,
            _ => CameraFlashMode.Auto
        };

    internal static UIImagePickerControllerCameraFlashMode ConvertToNative(this CameraFlashMode mode) =>
        mode switch
        {
            CameraFlashMode.Off => UIImagePickerControllerCameraFlashMode.Off,
            CameraFlashMode.Auto => UIImagePickerControllerCameraFlashMode.Auto,
            CameraFlashMode.On => UIImagePickerControllerCameraFlashMode.On,
            _ => UIImagePickerControllerCameraFlashMode.Auto
        };
}