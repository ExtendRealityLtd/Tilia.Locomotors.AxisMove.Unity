# Adding A Camera SnapRotator

> * Level: Beginner
>
> * Reading Time: 10 minutes
>
> * Checked with: Unity 2019.4.0f1

## Introduction

The Camera SnapRotator warps the main camera instantly left/right with a camera fade between each movement and snap rotates by 45 degrees each rotation around the Y axis when triggering an action, like moving the thumbstick left/right. The camera fades between each rotation.

This is useful if you want to give a player the possibility to turn quickly around.

The outcome of this How-To Guide is to learn how to add the SnapRotator prefab to the scene and utilize the custom actions to provide the input for the rotation. For better testing in the Editor, this How-To guide connects `BooleanAction` with a `Input.CombinedActions.BooleanTo1DAxisAction`.

## Prerequisites

* [Add the Tilia.CameraRigs.SpatialSimulator.Unity](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.SpatialSimulator.Unity/blob/master/Documentation/HowToGuides/AddingASpatialSimulatorCameraRig/README.md) prefab to the scene Hierarchy.
* [Add the Tilia.CameraRigs.UnityXR](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.UnityXR/blob/master/Documentation/HowToGuides/AddingAUnityXRCameraRig/README.md) prefab to the scene Hierarchy.
* [Add the Tilia.CameraRigs.TrackedAlias.Unity](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/blob/master/Documentation/HowToGuides/AddingATrackedAlias/README.md) prefab to the scene Hierarchy.
* [Install the Tilia.Input.UnityInputManager.Unity](https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputManager/tree/master/Documentation/HowToGuides/Installation) Package dependency in to your Unity project.
* [Install the Tilia.Input.CombinedActions.Unity](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/tree/adddocs/Documentation/HowToGuides/Installation) package dependency in to your Unity project.
* [Read the HowTo-Guide for using Combined Actions](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/blob/master/Documentation/HowToGuides/UsingCombinedActions/README.md) before, to understand how to use Boolean input such as keyboard keys to mimic an analogue axis such as a thumbstick.
* [Set up a TrackedAlias](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/tree/master/Documentation/HowToGuides/AddingATrackedAlias) to get a working VR camera rig in the Editor.
* [Install the Tilia.Locomotors.AxisMove.Unity](https://github.com/FireDragonGameStudio/Tilia.Locomotors.AxisMove.Unity/blob/master/Documentation/HowToGuides/Installation/README.md) package dependency in to your Unity project.

## Let's Start

### Step 1

Expand the `Tilia Locomotors AxisMove Unity` Package directory in the Unity Project window and select then `Packages -> Tilia Locomotors AxisMove Unity -> Runtime -> Prefabs` directory then drag and drop the `Locomotors.AxisMove.WarpAndSnapRotate` prefab into the Hierarchy window.

![Adding Prefab To Scene](assets/images/AddSnapRotate.PNG)

### Step 2

Expand the `Tilia Input UnityInputManager Unity` package directory in the Unity Project window and select the `Packages -> Tilia Input UnityInputManager Unity -> Runtime -> Prefabs -> Actions` directory then drag and drop the `Input.CombinedActions.BooleanTo1DAxisAction` prefab into the Unity hierarchy window.

![Create BooleanTo1DAxisAction gameobject](assets/images/AddingBooleanTo1DAxisAction.PNG)

### Step 3

Locate `CameraRigs.SpatialSimulator -> Input -> ControlObjectsInput -> LeftControllerInput -> Buttons -> ButtonOne` and `CameraRigs.SpatialSimulator -> Input -> ControlObjectsInput -> LeftControllerInput -> Buttons -> ButtonTwo` inputs in the hierarchy. These represent the left and right mouse button in the Unity Editor.

![Left and Right mouse button inputs](assets/images/MouseButtons.PNG)

### Step 4

Select the `Input.CombinedActions.BooleanTo1DAxisAction` gameobject and drag `ButtonOne` on the `Negative Input` and `ButtonTwo` on the `Positive Input` fields.

![BooleanTo1DAxisAction negative and positive input](assets/images/1DAxisInput.PNG)

### Step 5

Select `Locomotors.AxisMove.WarpAndSnapRotate` gameobject and add the references:

* `Horizontal Axis` -> `Input.CombinedActions.BooleanTo1DAxisAction`
* `Target`-> `CameraRigs.TrackedAlias-> Aliases -> PlayAreaAlias`
* `Scene Cameras` -> `CameraRigs.TrackedAlias-> Aliases -> SceneCameras`

![References for Locomotors.AxisMove.WarpAndSnapRotate](assets/images/AddTargetAndCameraAndInput.PNG)

### Done

Now you have a SnapRotator attached. When dealing with controllers you can use any other inputs, e.g. the horizontal Thumbstick Axis from Oculus Touch controllers. In this case you can skip Steps 2, 3, 4 and reference the `FloatAction` for ThumbstickMovement directly at `Horizontal Axis` on the `Locomotors.AxisMove.WarpAndSnapRotate` gameobject.

Everytime you click the left mouse button your camera will rotate left by 45°.

![Left mouse button -> rotating left](assets/images/GifConverter_Left.gif)

When pressing the right mouse button the camera will rotate right by 45°.

![Right mouse button -> rotating right](assets/images/GifConverter_Right.gif)