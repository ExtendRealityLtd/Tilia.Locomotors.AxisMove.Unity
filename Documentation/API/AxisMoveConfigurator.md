# Class AxisMoveConfigurator

Sets up the Axis Move prefabs based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [CameraBlink]
  * [Facade]
  * [HorizontalAction]
  * [HorizontalToLateral]
  * [HorizontalToLongitudinal]
  * [HorizontalToVertical]
  * [PositionExtractor]
  * [PositionMutator]
  * [RotationExtractor]
  * [RotationMutator]
  * [VerticalAction]
  * [VerticalToLateral]
  * [VerticalToLongitudinal]
  * [VerticalToVertical]
* [Methods]
  * [ConfigureForwardOffset()]
  * [ConfigureHorizontalAxis()]
  * [ConfigureRotationPivot()]
  * [ConfigureSceneCameras()]
  * [ConfigureTarget()]
  * [ConfigureVerticalAxis()]
  * [NotifyPositionChanged(Vector3)]
  * [NotifyRotationChanged(Vector3)]
  * [OnEnable()]

## Details

##### Inheritance

* System.Object
* AxisMoveConfigurator

##### Namespace

* [Tilia.Locomotors.AxisMove]

##### Syntax

```
public class AxisMoveConfigurator : MonoBehaviour
```

### Properties

#### CameraBlink

The CameraColorOverlay that will fade the cameras to blink.

##### Declaration

```
public CameraColorOverlay CameraBlink { get; protected set; }
```

#### Facade

The public facade.

##### Declaration

```
public AxisMoveFacade Facade { get; protected set; }
```

#### HorizontalAction

The AxesToVector3Action linked to the Facade.HorizontalAxis

##### Declaration

```
public AxesToVector3Action HorizontalAction { get; protected set; }
```

#### HorizontalToLateral

The mapping for the Facade.HorizontalAxis to the AxesToVector3Action.LateralAxis.

##### Declaration

```
public AxesToVector3Action HorizontalToLateral { get; protected set; }
```

#### HorizontalToLongitudinal

The mapping for the Facade.HorizontalAxis to the AxesToVector3Action.LongitudinalAxis.

##### Declaration

```
public AxesToVector3Action HorizontalToLongitudinal { get; protected set; }
```

#### HorizontalToVertical

The mapping for the Facade.HorizontalAxis to the AxesToVector3Action.VerticalAxis.

##### Declaration

```
public AxesToVector3Action HorizontalToVertical { get; protected set; }
```

#### PositionExtractor

The TransformPositionExtractor that will check the Facade.Target current position change.

##### Declaration

```
public TransformPositionExtractor PositionExtractor { get; protected set; }
```

#### PositionMutator

The TransformPositionMutator that will move the Facade.Target.

##### Declaration

```
public TransformPositionMutator PositionMutator { get; protected set; }
```

#### RotationExtractor

The TransformEulerRotationExtractor that will check the Facade.Target current rotation change.

##### Declaration

```
public TransformEulerRotationExtractor RotationExtractor { get; protected set; }
```

#### RotationMutator

The TransformEulerRotationMutator that will rotate the Facade.Target.

##### Declaration

```
public TransformEulerRotationMutator RotationMutator { get; protected set; }
```

#### VerticalAction

The AxesToVector3Action linked to the Facade.VerticalAxis

##### Declaration

```
public AxesToVector3Action VerticalAction { get; protected set; }
```

#### VerticalToLateral

The mapping for the Facade.VerticalAxis to the AxesToVector3Action.LateralAxis.

##### Declaration

```
public AxesToVector3Action VerticalToLateral { get; protected set; }
```

#### VerticalToLongitudinal

The mapping for the Facade.VerticalAxis to the AxesToVector3Action.LongitudinalAxis.

##### Declaration

```
public AxesToVector3Action VerticalToLongitudinal { get; protected set; }
```

#### VerticalToVertical

The mapping for the Facade.VerticalAxis to the AxesToVector3Action.VerticalAxis.

##### Declaration

```
public AxesToVector3Action VerticalToVertical { get; protected set; }
```

### Methods

#### ConfigureForwardOffset()

Configures the forward offset based on the facade settings.

##### Declaration

```
public virtual void ConfigureForwardOffset()
```

#### ConfigureHorizontalAxis()

Configures the horizontal axis based on the facade settings.

##### Declaration

```
public virtual void ConfigureHorizontalAxis()
```

#### ConfigureRotationPivot()

Configures the rotation pivot based on the facade settings.

##### Declaration

```
public virtual void ConfigureRotationPivot()
```

#### ConfigureSceneCameras()

Configures the scene cameras based on the facade settings.

##### Declaration

```
public virtual void ConfigureSceneCameras()
```

#### ConfigureTarget()

Configures the target based on the facade settings.

##### Declaration

```
public virtual void ConfigureTarget()
```

#### ConfigureVerticalAxis()

Configures the vertical axis based on the facade settings.

##### Declaration

```
public virtual void ConfigureVerticalAxis()
```

#### NotifyPositionChanged(Vector3)

Emits the Position Changed event.

##### Declaration

```
public virtual void NotifyPositionChanged(Vector3 value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Vector3 | value | The new position. |

#### NotifyRotationChanged(Vector3)

Emits the Rotation Changed event.

##### Declaration

```
public virtual void NotifyRotationChanged(Vector3 value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Vector3 | value | The new rotation. |

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

[Tilia.Locomotors.AxisMove]: README.md
[AxisMoveFacade]: AxisMoveFacade.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[CameraBlink]: #CameraBlink
[Facade]: #Facade
[HorizontalAction]: #HorizontalAction
[HorizontalToLateral]: #HorizontalToLateral
[HorizontalToLongitudinal]: #HorizontalToLongitudinal
[HorizontalToVertical]: #HorizontalToVertical
[PositionExtractor]: #PositionExtractor
[PositionMutator]: #PositionMutator
[RotationExtractor]: #RotationExtractor
[RotationMutator]: #RotationMutator
[VerticalAction]: #VerticalAction
[VerticalToLateral]: #VerticalToLateral
[VerticalToLongitudinal]: #VerticalToLongitudinal
[VerticalToVertical]: #VerticalToVertical
[Methods]: #Methods
[ConfigureForwardOffset()]: #ConfigureForwardOffset
[ConfigureHorizontalAxis()]: #ConfigureHorizontalAxis
[ConfigureRotationPivot()]: #ConfigureRotationPivot
[ConfigureSceneCameras()]: #ConfigureSceneCameras
[ConfigureTarget()]: #ConfigureTarget
[ConfigureVerticalAxis()]: #ConfigureVerticalAxis
[NotifyPositionChanged(Vector3)]: #NotifyPositionChangedVector3
[NotifyRotationChanged(Vector3)]: #NotifyRotationChangedVector3
[OnEnable()]: #OnEnable
