namespace Tilia.Locomotors.AxisMove
{
    using System;
    using UnityEngine;
    using UnityEngine.Events;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;
    using Zinnia.Rule;

    /// <summary>
    /// The public interface into the Axis Move Prefabs.
    /// </summary>
    public class AxisMoveFacade : MonoBehaviour
    {
        /// <summary>
        /// Defines the event with the <see cref="Vector3"/>.
        /// </summary>
        [Serializable]
        public class UnityEvent : UnityEvent<Vector3> { }

        #region Axis Settings
        [Header("Axis Settings")]
        [Tooltip("The horizontal axis to control the left/right motion.")]
        [SerializeField]
        private FloatAction horizontalAxis;
        /// <summary>
        /// The horizontal axis to control the left/right motion.
        /// </summary>
        public FloatAction HorizontalAxis
        {
            get
            {
                return horizontalAxis;
            }
            set
            {
                horizontalAxis = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterHorizontalAxisChange();
                }
            }
        }
        [Tooltip("The vertical axis to control the forward/backward motion.")]
        [SerializeField]
        private FloatAction verticalAxis;
        /// <summary>
        /// The vertical axis to control the forward/backward motion.
        /// </summary>
        public FloatAction VerticalAxis
        {
            get
            {
                return verticalAxis;
            }
            set
            {
                verticalAxis = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterVerticalAxisChange();
                }
            }
        }
        #endregion

        #region Target Settings
        [Header("Target Settings")]
        [Tooltip("The target to apply the motion to.")]
        [SerializeField]
        private GameObject target;
        /// <summary>
        /// The target to apply the motion to.
        /// </summary>
        public GameObject Target
        {
            get
            {
                return target;
            }
            set
            {
                target = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterTargetChange();
                }
            }
        }
        [Tooltip("An optional forward offset to be used when moving the Target.")]
        [SerializeField]
        private GameObject forwardOffset;
        /// <summary>
        /// An optional forward offset to be used when moving the <see cref="Target"/>.
        /// </summary>
        public GameObject ForwardOffset
        {
            get
            {
                return forwardOffset;
            }
            set
            {
                forwardOffset = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterForwardOffsetChange();
                }
            }
        }
        [Tooltip("An optional pivot point to rotate the Target around.")]
        [SerializeField]
        private GameObject rotationPivot;
        /// <summary>
        /// An optional pivot point to rotate the <see cref="Target"/> around.
        /// </summary>
        public GameObject RotationPivot
        {
            get
            {
                return rotationPivot;
            }
            set
            {
                rotationPivot = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterRotationPivotChange();
                }
            }
        }
        [Tooltip("An optional pivot RuleContainer of the scene cameras.")]
        [SerializeField]
        private RuleContainer sceneCameras;
        /// <summary>
        /// An optional pivot <see cref="RuleContainer"/> of the scene cameras.
        /// </summary>
        public RuleContainer SceneCameras
        {
            get
            {
                return sceneCameras;
            }
            set
            {
                sceneCameras = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterSceneCamerasChange();
                }
            }
        }
        #endregion

        #region Movement Events
        /// <summary>
        /// Emitted when the <see cref="Target"/> position changes.
        /// </summary>
        [Header("Movement Events")]
        public UnityEvent PositionChanged = new UnityEvent();
        /// <summary>
        /// Emitted when the <see cref="Target"/> rotation changes.
        /// </summary>
        public UnityEvent RotationChanged = new UnityEvent();
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("An optional pivot RuleContainer of the scene cameras.")]
        [SerializeField]
        [Restricted]
        private AxisMoveConfigurator configuration;
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        public AxisMoveConfigurator Configuration
        {
            get
            {
                return configuration;
            }
            protected set
            {
                configuration = value;
            }
        }
        #endregion

        /// <summary>
        /// Clears <see cref="HorizontalAxis"/>.
        /// </summary>
        public virtual void ClearHorizontalAxis()
        {
            if (!this.IsValidState())
            {
                return;
            }

            HorizontalAxis = default;
        }

        /// <summary>
        /// Clears <see cref="VerticalAxis"/>.
        /// </summary>
        public virtual void ClearVerticalAxis()
        {
            if (!this.IsValidState())
            {
                return;
            }

            VerticalAxis = default;
        }

        /// <summary>
        /// Clears <see cref="Target"/>.
        /// </summary>
        public virtual void ClearTarget()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Target = default;
        }

        /// <summary>
        /// Clears <see cref="ForwardOffset"/>.
        /// </summary>
        public virtual void ClearForwardOffset()
        {
            if (!this.IsValidState())
            {
                return;
            }

            ForwardOffset = default;
        }

        /// <summary>
        /// Clears <see cref="RotationPivot"/>.
        /// </summary>
        public virtual void ClearRotationPivot()
        {
            if (!this.IsValidState())
            {
                return;
            }

            RotationPivot = default;
        }

        /// <summary>
        /// Clears <see cref="SceneCameras"/>.
        /// </summary>
        public virtual void ClearSceneCameras()
        {
            if (!this.IsValidState())
            {
                return;
            }

            SceneCameras = default;
        }

        /// <summary>
        /// Called after <see cref="HorizontalAxis"/> has been changed.
        /// </summary>
        protected virtual void OnAfterHorizontalAxisChange()
        {
            Configuration.ConfigureHorizontalAxis();
        }

        /// <summary>
        /// Called after <see cref="VerticalAxis"/> has been changed.
        /// </summary>
        protected virtual void OnAfterVerticalAxisChange()
        {
            Configuration.ConfigureVerticalAxis();
        }

        /// <summary>
        /// Called after <see cref="Target"/> has been changed.
        /// </summary>
        protected virtual void OnAfterTargetChange()
        {
            Configuration.ConfigureTarget();
        }

        /// <summary>
        /// Called after <see cref="ForwardOffset"/> has been changed.
        /// </summary>
        protected virtual void OnAfterForwardOffsetChange()
        {
            Configuration.ConfigureForwardOffset();
        }

        /// <summary>
        /// Called after <see cref="RotationPivot"/> has been changed.
        /// </summary>
        protected virtual void OnAfterRotationPivotChange()
        {
            Configuration.ConfigureRotationPivot();
        }

        /// <summary>
        /// Called after <see cref="SceneCameras"/> has been changed.
        /// </summary>
        protected virtual void OnAfterSceneCamerasChange()
        {
            Configuration.ConfigureSceneCameras();
        }
    }
}