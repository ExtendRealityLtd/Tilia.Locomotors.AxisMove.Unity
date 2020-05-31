namespace Tilia.Locomotors.AxisMove
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using Tilia.Input.CombinedActions;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Operation.Extraction;
    using Zinnia.Data.Operation.Mutation;
    using Zinnia.Visual;

    /// <summary>
    /// Sets up the Axis Move prefabs based on the provided user settings.
    /// </summary>
    public class AxisMoveConfigurator : MonoBehaviour
    {
        #region Facade Settings
        /// <summary>
        /// The public facade.
        /// </summary>
        [Serialized]
        [field: Header("Facade Settings"), DocumentedByXml, Restricted]
        public AxisMoveFacade Facade { get; protected set; }
        #endregion

        #region Reference Settings
        /// <summary>
        /// The mapping for the <see cref="Facade.HorizontalAxis"/> to the <see cref="AxesToVector3Action.LateralAxis"/>.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public AxesToVector3Action HorizontalToLateral { get; protected set; }
        /// <summary>
        /// The mapping for the <see cref="Facade.HorizontalAxis"/> to the <see cref="AxesToVector3Action.VerticalAxis"/>.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public AxesToVector3Action HorizontalToVertical { get; protected set; }
        /// <summary>
        /// The mapping for the <see cref="Facade.HorizontalAxis"/> to the <see cref="AxesToVector3Action.LongitudinalAxis"/>.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public AxesToVector3Action HorizontalToLongitudinal { get; protected set; }
        /// <summary>
        /// The mapping for the <see cref="Facade.VerticalAxis"/> to the <see cref="AxesToVector3Action.LateralAxis"/>.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public AxesToVector3Action VerticalToLateral { get; protected set; }
        /// <summary>
        /// The mapping for the <see cref="Facade.VerticalAxis"/> to the <see cref="AxesToVector3Action.VerticalAxis"/>.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public AxesToVector3Action VerticalToVertical { get; protected set; }
        /// <summary>
        /// The mapping for the <see cref="Facade.VerticalAxis"/> to the <see cref="AxesToVector3Action.LongitudinalAxis"/>.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public AxesToVector3Action VerticalToLongitudinal { get; protected set; }
        /// <summary>
        /// The <see cref="TransformPositionMutator"/> that will move the <see cref="Facade.Target"/>.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public TransformPositionMutator PositionMutator { get; protected set; }
        /// <summary>
        /// The <see cref="TransformPositionExtractor"/> that will check the <see cref="Facade.Target"/> current position change.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public TransformPositionExtractor PositionExtractor { get; protected set; }
        /// <summary>
        /// The <see cref="TransformEulerRotationMutator"/> that will rotate the <see cref="Facade.Target"/>.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public TransformEulerRotationMutator RotationMutator { get; protected set; }
        /// <summary>
        /// The <see cref="TransformEulerRotationExtractor"/> that will check the <see cref="Facade.Target"/> current rotation change.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public TransformEulerRotationExtractor RotationExtractor { get; protected set; }
        /// <summary>
        /// The <see cref="CameraColorOverlay"/> that will fade the cameras to blink.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public CameraColorOverlay CameraBlink { get; protected set; }
        #endregion

        /// <summary>
        /// The <see cref="AxesToVector3Action"/> linked to the <see cref="Facade.HorizontalAxis"/>
        /// </summary>
        public AxesToVector3Action HorizontalAction { get; protected set; }
        /// <summary>
        /// The <see cref="AxesToVector3Action"/> linked to the <see cref="Facade.VerticalAxis"/>
        /// </summary>
        public AxesToVector3Action VerticalAction { get; protected set; }

        /// <summary>
        /// Emits the Position Changed event.
        /// </summary>
        /// <param name="value">The new position.</param>
        public virtual void NotifyPositionChanged(Vector3 value)
        {
            Facade.PositionChanged?.Invoke(value);
        }

        /// <summary>
        /// Emits the Rotation Changed event.
        /// </summary>
        /// <param name="value">The new rotation.</param>
        public virtual void NotifyRotationChanged(Vector3 value)
        {
            Facade.RotationChanged?.Invoke(value);
        }

        /// <summary>
        /// Configures the horizontal axis based on the facade settings.
        /// </summary>
        public virtual void ConfigureHorizontalAxis()
        {
            if (HorizontalToLateral != null)
            {
                HorizontalToLateral.LateralAxis = Facade.HorizontalAxis;
                HorizontalAction = HorizontalToLateral;
            }
            else if (HorizontalToVertical != null)
            {
                HorizontalToVertical.VerticalAxis = Facade.HorizontalAxis;
                HorizontalAction = HorizontalToVertical;
            }
            else if (HorizontalToLongitudinal != null)
            {
                HorizontalToLongitudinal.LongitudinalAxis = Facade.HorizontalAxis;
                HorizontalAction = HorizontalToLongitudinal;
            }
        }

        /// <summary>
        /// Configures the vertical axis based on the facade settings.
        /// </summary>
        public virtual void ConfigureVerticalAxis()
        {
            if (VerticalToLateral != null)
            {
                VerticalToLateral.LateralAxis = Facade.VerticalAxis;
                VerticalAction = VerticalToLateral;
            }
            else if (VerticalToVertical != null)
            {
                VerticalToVertical.VerticalAxis = Facade.VerticalAxis;
                VerticalAction = VerticalToVertical;
            }
            else if (VerticalToLongitudinal != null)
            {
                VerticalToLongitudinal.LongitudinalAxis = Facade.VerticalAxis;
                VerticalAction = VerticalToLongitudinal;
            }
        }

        /// <summary>
        /// Configures the target based on the facade settings.
        /// </summary>
        public virtual void ConfigureTarget()
        {
            if (PositionMutator != null)
            {
                PositionMutator.Target = Facade.Target;
            }

            if (PositionExtractor != null)
            {
                PositionExtractor.Source = Facade.Target;
            }

            if (RotationMutator != null)
            {
                RotationMutator.Target = Facade.Target;
            }

            if (RotationExtractor != null)
            {
                RotationExtractor.Source = Facade.Target;
            }
        }

        /// <summary>
        /// Configures the forward offset based on the facade settings.
        /// </summary>
        public virtual void ConfigureForwardOffset()
        {
            if (PositionMutator == null)
            {
                return;
            }

            PositionMutator.FacingDirection = Facade.ForwardOffset;
        }

        /// <summary>
        /// Configures the rotation pivot based on the facade settings.
        /// </summary>
        public virtual void ConfigureRotationPivot()
        {
            if (RotationMutator == null)
            {
                return;
            }

            RotationMutator.Origin = Facade.RotationPivot;
        }

        /// <summary>
        /// Configures the scene cameras based on the facade settings.
        /// </summary>
        public virtual void ConfigureSceneCameras()
        {
            if (CameraBlink == null)
            {
                return;
            }

            CameraBlink.CameraValidity = Facade.SceneCameras;
            CameraBlink.gameObject.SetActive(Facade.SceneCameras.Interface != null);
        }

        protected virtual void OnEnable()
        {
            ConfigureHorizontalAxis();
            ConfigureVerticalAxis();
            ConfigureTarget();
            ConfigureForwardOffset();
            ConfigureRotationPivot();
            ConfigureSceneCameras();
        }
    }
}