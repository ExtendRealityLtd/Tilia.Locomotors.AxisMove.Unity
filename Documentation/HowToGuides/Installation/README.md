# Installing the package

> * Level: Beginner
>
> * Reading Time: 2 minutes
>
> * Checked with: Unity 2018.3.14f1

## Introduction

These prefabs provide the ability to take axis input and convert it into positional and rotational movement of a GameObejct within the [Unity] scene. These prefabs can be included in a Unity software project via the [Unity Package Manager].

There are four Axis Move prefabs:

* `Locomotors.AxisMove.SlideAndStrafe` - Moves the GameObject with a smooth movement forward/backwards and strafes left/right with a smooth movement.
* `Locomotors.AxisMove.SlideAndSmoothRotate` - Moves the GameObject with a smooth movement forward/backwards and smoothly rotates the GameObejct around the Y axis with the left/right axis input.
* `Locomotors.AxisMove.SlideAndSnapRotate` - Moves the GameObject with a smooth movement forward/backwards and snap rotates the GameObejct 45 degrees each rotation around the Y axis with the left/right axis input. The camera fades between each rotation.
* `Locomotors.AxisMove.WarpAndSnapRotate` - Warps the GameObject instantly forward/backwards with a camera fade between each momvent and snap rotates the GameObejct 45 degrees each rotation around the Y axis with the left/right axis input. The camera fades between each rotation.

## Let's Start

### Step 1: Creating a Unity project

> You may skip this step if you already have a Unity project to import the package into.

* Create a new project in the Unity software version `2018.3.10f1` (or above) using `3D Template` or open an existing project.

### Step 2: Configuring the Unity project

* Ensure the project `Scripting Runtime Version` is set to `.NET 4.x Equivalent`:
  * In the Unity software select `Main Menu -> Edit -> Project Settings` to open the `Project Settings` inspector.
  * Select `Player` from the left hand menu in the `Project Settings` window.
  * In the `Player` settings panel expand `Other Settings`.
  * Ensure the `Scripting Runtime Version` is set to `.NET 4.x Equivalent`.

### Step 3: Adding the package to the Unity project manifest

* Navigate to the `Packages` directory of your project.
* Adjust the [project manifest file][Project-Manifest] `manifest.json` in a text editor.
  * Ensure `https://registry.npmjs.org/` is part of `scopedRegistries`.
    * Ensure `io.extendreality` is part of `scopes`.
  * Add `io.extendreality.tilia.locomotors.axismove.unity` to `dependencies`, stating the latest version.

  A minimal example ends up looking like this. Please note that the version `X.Y.Z` stated here is to be replaced with [the latest released version][Latest-Release] which is currently [![Release][Version-Release]][Releases].
  ```json
  {
    "scopedRegistries": [
      {
        "name": "npmjs",
        "url": "https://registry.npmjs.org/",
        "scopes": [
          "io.extendreality"
        ]
      }
    ],
    "dependencies": {
      "io.extendreality.tilia.locomotors.axismove.unity": "X.Y.Z",
      ...
    }
  }
  ```
* Switch back to the Unity software and wait for it to finish importing the added package.

### Done

The `Tilia Locomotors AxisMove Unity` package will now be available in your Unity project `Packages` directory ready for use in your project.

The package will now also show up in the Unity Package Manager UI. From then on the package can be updated by selecting the package in the Unity Package Manager and clicking on the `Update` button or using the version selection UI.

[Unity]: https://unity3d.com/
[Unity Package Manager]: https://docs.unity3d.com/Manual/upm-ui.html
[Project-Manifest]: https://docs.unity3d.com/Manual/upm-manifestPrj.html
[Version-Release]: https://img.shields.io/github/release/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity.svg
[Releases]: ../../../../../releases
[Latest-Release]: ../../../../../releases/latest