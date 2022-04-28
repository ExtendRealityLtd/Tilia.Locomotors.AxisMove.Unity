namespace Tilia.Locomotors.AxisMove
{
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
        [Header("Facade Settings")]
        [Tooltip("The public facade.")]
        [SerializeField]
        [Restricted]
        private AxisMoveFacade facade;
        /// <summary>
        /// The public facade.
        /// </summary>
        public AxisMoveFacade Facade
        {
            get
            {
                return facade;
            }
            protected set
            {
                facade = value;
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The mapping for the Facade.HorizontalAxis to the AxesToVector3Action.LateralAxis.")]
        [SerializeField]
        [Restricted]
        private AxesToVector3Action horizontalToLateral;
        /// <summary>
        /// The mapping for the <see cref="Facade.HorizontalAxis"/> to the <see cref="AxesToVector3Action.LateralAxis"/>.
        /// </summary>
        public AxesToVector3Action HorizontalToLateral
        {
            get
            {
                return horizontalToLateral;
            }
            protected set
            {
                horizontalToLateral = value;
            }
        }
        [Tooltip("The mapping for the Facade.HorizontalAxis to the AxesToVector3Action.VerticalAxis.")]
        [SerializeField]
        [Restricted]
        private AxesToVector3Action horizontalToVertical;
        /// <summary>
        /// The mapping for the <see cref="Facade.HorizontalAxis"/> to the <see cref="AxesToVector3Action.VerticalAxis"/>.
        /// </summary>
        public AxesToVector3Action HorizontalToVertical
        {
            get
            {
                return horizontalToVertical;
            }
            protected set
            {
                horizontalToVertical = value;
            }
        }
        [Tooltip("The mapping for the Facade.HorizontalAxis to the AxesToVector3Action.LongitudinalAxis.")]
        [SerializeField]
        [Restricted]
        private AxesToVector3Action horizontalToLongitudinal;
        /// <summary>
        /// The mapping for the <see cref="Facade.HorizontalAxis"/> to the <see cref="AxesToVector3Action.LongitudinalAxis"/>.
        /// </summary>
        public AxesToVector3Action HorizontalToLongitudinal
        {
            get
            {
                return horizontalToLongitudinal;
            }
            protected set
            {
                horizontalToLongitudinal = value;
            }
        }
        [Tooltip("The mapping for the Facade.VerticalAxis to the AxesToVector3Action.LateralAxis.")]
        [SerializeField]
        [Restricted]
        private AxesToVector3Action verticalToLateral;
        /// <summary>
        /// The mapping for the <see cref="Facade.VerticalAxis"/> to the <see cref="AxesToVector3Action.LateralAxis"/>.
        /// </summary>
        public AxesToVector3Action VerticalToLateral
        {
            get
            {
                return verticalToLateral;
            }
            protected set
            {
                verticalToLateral = value;
            }
        }
        [Tooltip("The mapping for the Facade.VerticalAxis to the AxesToVector3Action.VerticalAxis.")]
        [SerializeField]
        [Restricted]
        private AxesToVector3Action verticalToVertical;
        /// <summary>
        /// The mapping for the <see cref="Facade.VerticalAxis"/> to the <see cref="AxesToVector3Action.VerticalAxis"/>.
        /// </summary>
        public AxesToVector3Action VerticalToVertical
        {
            get
            {
                return verticalToVertical;
            }
            protected set
            {
                verticalToVertical = value;
            }
        }
        [Tooltip("The mapping for the Facade.VerticalAxis to the AxesToVector3Action.LongitudinalAxis.")]
        [SerializeField]
        [Restricted]
        private AxesToVector3Action verticalToLongitudinal;
        /// <summary>
        /// The mapping for the <see cref="Facade.VerticalAxis"/> to the <see cref="AxesToVector3Action.LongitudinalAxis"/>.
        /// </summary>
        public AxesToVector3Action VerticalToLongitudinal
        {
            get
            {
                return verticalToLongitudinal;
            }
            protected set
            {
                verticalToLongitudinal = value;
            }
        }
        [Tooltip("The TransformPositionMutator that will move the Facade.Target.")]
        [SerializeField]
        [Restricted]
        private TransformPositionMutator positionMutator;
        /// <summary>
        /// The <see cref="TransformPositionMutator"/> that will move the <see cref="Facade.Target"/>.
        /// </summary>
        public TransformPositionMutator PositionMutator
        {
            get
            {
                return positionMutator;
            }
            protected set
            {
                positionMutator = value;
            }
        }
        [Tooltip("The TransformPositionExtractor that will check the Facade.Target current position change.")]
        [SerializeField]
        [Restricted]
        private TransformPositionExtractor positionExtractor;
        /// <summary>
        /// The <see cref="TransformPositionExtractor"/> that will check the <see cref="Facade.Target"/> current position change.
        /// </summary>
        public TransformPositionExtractor PositionExtractor
        {
            get
            {
                return positionExtractor;
            }
            protected set
            {
                positionExtractor = value;
            }
        }
        [Tooltip("The TransformEulerRotationMutator that will rotate the Facade.Target.")]
        [SerializeField]
        [Restricted]
        private TransformEulerRotationMutator rotationMutator;
        /// <summary>
        /// The <see cref="TransformEulerRotationMutator"/> that will rotate the <see cref="Facade.Target"/>.
        /// </summary>
        public TransformEulerRotationMutator RotationMutator
        {
            get
            {
                return rotationMutator;
            }
            protected set
            {
                rotationMutator = value;
            }
        }
        [Tooltip("The TransformEulerRotationExtractor that will check the Facade.Target current rotation change.")]
        [SerializeField]
        [Restricted]
        private TransformEulerRotationExtractor rotationExtractor;
        /// <summary>
        /// The <see cref="TransformEulerRotationExtractor"/> that will check the <see cref="Facade.Target"/> current rotation change.
        /// </summary>
        public TransformEulerRotationExtractor RotationExtractor
        {
            get
            {
                return rotationExtractor;
            }
            protected set
            {
                rotationExtractor = value;
            }
        }
        [Tooltip("The CameraColorOverlay that will fade the cameras to blink.")]
        [SerializeField]
        [Restricted]
        private CameraColorOverlay cameraBlink;
        /// <summary>
        /// The <see cref="CameraColorOverlay"/> that will fade the cameras to blink.
        /// </summary>
        public CameraColorOverlay CameraBlink
        {
            get
            {
                return cameraBlink;
            }
            protected set
            {
                cameraBlink = value;
            }
        }
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