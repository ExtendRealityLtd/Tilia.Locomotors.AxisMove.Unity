# Class AxisMoveFacade

The public interface into the Axis Move Prefabs.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [PositionChanged]
  * [RotationChanged]
* [Properties]
  * [Configuration]
  * [ForwardOffset]
  * [HorizontalAxis]
  * [HorizontalAxisMultiplier]
  * [RotationPivot]
  * [SceneCameras]
  * [Target]
  * [VerticalAxis]
  * [VerticalAxisMultiplier]
* [Methods]
  * [ClearForwardOffset()]
  * [ClearHorizontalAxis()]
  * [ClearRotationPivot()]
  * [ClearSceneCameras()]
  * [ClearTarget()]
  * [ClearVerticalAxis()]
  * [OnAfterForwardOffsetChange()]
  * [OnAfterHorizontalAxisChange()]
  * [OnAfterHorizontalAxisMultiplierChange()]
  * [OnAfterRotationPivotChange()]
  * [OnAfterSceneCamerasChange()]
  * [OnAfterTargetChange()]
  * [OnAfterVerticalAxisChange()]
  * [OnAfterVerticalAxisMultiplierChange()]

## Details

##### Inheritance

* System.Object
* AxisMoveFacade

##### Namespace

* [Tilia.Locomotors.AxisMove]

##### Syntax

```
public class AxisMoveFacade : MonoBehaviour
```

### Fields

#### PositionChanged

Emitted when the [Target] position changes.

##### Declaration

```
public AxisMoveFacade.UnityEvent PositionChanged
```

#### RotationChanged

Emitted when the [Target] rotation changes.

##### Declaration

```
public AxisMoveFacade.UnityEvent RotationChanged
```

### Properties

#### Configuration

The linked Internal Setup.

##### Declaration

```
public AxisMoveConfigurator Configuration { get; protected set; }
```

#### ForwardOffset

An optional forward offset to be used when moving the [Target].

##### Declaration

```
public GameObject ForwardOffset { get; set; }
```

#### HorizontalAxis

The horizontal axis to control the left/right motion.

##### Declaration

```
public FloatAction HorizontalAxis { get; set; }
```

#### HorizontalAxisMultiplier

Multiply the incoming horizontal axis value to increase/decrease speed of movement.

##### Declaration

```
public float HorizontalAxisMultiplier { get; set; }
```

#### RotationPivot

An optional pivot point to rotate the [Target] around.

##### Declaration

```
public GameObject RotationPivot { get; set; }
```

#### SceneCameras

An optional pivot RuleContainer of the scene cameras.

##### Declaration

```
public RuleContainer SceneCameras { get; set; }
```

#### Target

The target to apply the motion to.

##### Declaration

```
public GameObject Target { get; set; }
```

#### VerticalAxis

The vertical axis to control the forward/backward motion.

##### Declaration

```
public FloatAction VerticalAxis { get; set; }
```

#### VerticalAxisMultiplier

Multiply the incoming vertical axis value to increase/decrease speed of movement.

##### Declaration

```
public float VerticalAxisMultiplier { get; set; }
```

### Methods

#### ClearForwardOffset()

Clears [ForwardOffset].

##### Declaration

```
public virtual void ClearForwardOffset()
```

#### ClearHorizontalAxis()

Clears [HorizontalAxis].

##### Declaration

```
public virtual void ClearHorizontalAxis()
```

#### ClearRotationPivot()

Clears [RotationPivot].

##### Declaration

```
public virtual void ClearRotationPivot()
```

#### ClearSceneCameras()

Clears [SceneCameras].

##### Declaration

```
public virtual void ClearSceneCameras()
```

#### ClearTarget()

Clears [Target].

##### Declaration

```
public virtual void ClearTarget()
```

#### ClearVerticalAxis()

Clears [VerticalAxis].

##### Declaration

```
public virtual void ClearVerticalAxis()
```

#### OnAfterForwardOffsetChange()

Called after [ForwardOffset] has been changed.

##### Declaration

```
protected virtual void OnAfterForwardOffsetChange()
```

#### OnAfterHorizontalAxisChange()

Called after [HorizontalAxis] has been changed.

##### Declaration

```
protected virtual void OnAfterHorizontalAxisChange()
```

#### OnAfterHorizontalAxisMultiplierChange()

Called after [HorizontalAxisMultiplier] has been changed.

##### Declaration

```
protected virtual void OnAfterHorizontalAxisMultiplierChange()
```

#### OnAfterRotationPivotChange()

Called after [RotationPivot] has been changed.

##### Declaration

```
protected virtual void OnAfterRotationPivotChange()
```

#### OnAfterSceneCamerasChange()

Called after [SceneCameras] has been changed.

##### Declaration

```
protected virtual void OnAfterSceneCamerasChange()
```

#### OnAfterTargetChange()

Called after [Target] has been changed.

##### Declaration

```
protected virtual void OnAfterTargetChange()
```

#### OnAfterVerticalAxisChange()

Called after [VerticalAxis] has been changed.

##### Declaration

```
protected virtual void OnAfterVerticalAxisChange()
```

#### OnAfterVerticalAxisMultiplierChange()

Called after [VerticalAxisMultiplier] has been changed.

##### Declaration

```
protected virtual void OnAfterVerticalAxisMultiplierChange()
```

[Tilia.Locomotors.AxisMove]: README.md
[Target]: AxisMoveFacade.md#Target
[Target]: AxisMoveFacade.md#Target
[AxisMoveFacade.UnityEvent]: AxisMoveFacade.UnityEvent.md
[AxisMoveConfigurator]: AxisMoveConfigurator.md
[Target]: AxisMoveFacade.md#Target
[Target]: AxisMoveFacade.md#Target
[ForwardOffset]: AxisMoveFacade.md#ForwardOffset
[HorizontalAxis]: AxisMoveFacade.md#HorizontalAxis
[RotationPivot]: AxisMoveFacade.md#RotationPivot
[SceneCameras]: AxisMoveFacade.md#SceneCameras
[Target]: AxisMoveFacade.md#Target
[VerticalAxis]: AxisMoveFacade.md#VerticalAxis
[ForwardOffset]: AxisMoveFacade.md#ForwardOffset
[HorizontalAxis]: AxisMoveFacade.md#HorizontalAxis
[HorizontalAxisMultiplier]: AxisMoveFacade.md#HorizontalAxisMultiplier
[RotationPivot]: AxisMoveFacade.md#RotationPivot
[SceneCameras]: AxisMoveFacade.md#SceneCameras
[Target]: AxisMoveFacade.md#Target
[VerticalAxis]: AxisMoveFacade.md#VerticalAxis
[VerticalAxisMultiplier]: AxisMoveFacade.md#VerticalAxisMultiplier
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[PositionChanged]: #PositionChanged
[RotationChanged]: #RotationChanged
[Properties]: #Properties
[Configuration]: #Configuration
[ForwardOffset]: #ForwardOffset
[HorizontalAxis]: #HorizontalAxis
[HorizontalAxisMultiplier]: #HorizontalAxisMultiplier
[RotationPivot]: #RotationPivot
[SceneCameras]: #SceneCameras
[Target]: #Target
[VerticalAxis]: #VerticalAxis
[VerticalAxisMultiplier]: #VerticalAxisMultiplier
[Methods]: #Methods
[ClearForwardOffset()]: #ClearForwardOffset
[ClearHorizontalAxis()]: #ClearHorizontalAxis
[ClearRotationPivot()]: #ClearRotationPivot
[ClearSceneCameras()]: #ClearSceneCameras
[ClearTarget()]: #ClearTarget
[ClearVerticalAxis()]: #ClearVerticalAxis
[OnAfterForwardOffsetChange()]: #OnAfterForwardOffsetChange
[OnAfterHorizontalAxisChange()]: #OnAfterHorizontalAxisChange
[OnAfterHorizontalAxisMultiplierChange()]: #OnAfterHorizontalAxisMultiplierChange
[OnAfterRotationPivotChange()]: #OnAfterRotationPivotChange
[OnAfterSceneCamerasChange()]: #OnAfterSceneCamerasChange
[OnAfterTargetChange()]: #OnAfterTargetChange
[OnAfterVerticalAxisChange()]: #OnAfterVerticalAxisChange
[OnAfterVerticalAxisMultiplierChange()]: #OnAfterVerticalAxisMultiplierChange
