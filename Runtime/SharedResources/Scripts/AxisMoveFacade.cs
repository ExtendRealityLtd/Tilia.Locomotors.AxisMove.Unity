namespace Tilia.Locomotors.AxisMove
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using System;
    using UnityEngine;
    using UnityEngine.Events;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
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
        /// <summary>
        /// The horizontal axis to control the left/right motion.
        /// </summary>
        [Serialized, Cleared]
        [field: Header("Axis Settings"), DocumentedByXml]
        public FloatAction HorizontalAxis { get; set; }
        /// <summary>
        /// The vertical axis to control the forward/backward motion.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public FloatAction VerticalAxis { get; set; }
        #endregion

        #region Target Settings
        /// <summary>
        /// The target to apply the motion to.
        /// </summary>
        [Serialized, Cleared]
        [field: Header("Target Settings"), DocumentedByXml]
        public GameObject Target { get; set; }
        /// <summary>
        /// An optional forward offset to be used when moving the <see cref="Target"/>.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public GameObject ForwardOffset { get; set; }
        /// <summary>
        /// An optional pivot point to rotate the <see cref="Target"/> around.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public GameObject RotationPivot { get; set; }
        /// <summary>
        /// An optional pivot <see cref="RuleContainer"/> of the scene cameras.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public RuleContainer SceneCameras { get; set; }
        #endregion

        #region Movement Events
        /// <summary>
        /// Emitted when the <see cref="Target"/> position changes.
        /// </summary>
        [Header("Movement Events"), DocumentedByXml]
        public UnityEvent PositionChanged = new UnityEvent();
        /// <summary>
        /// Emitted when the <see cref="Target"/> rotation changes.
        /// </summary>
        [DocumentedByXml]
        public UnityEvent RotationChanged = new UnityEvent();
        #endregion

        #region Reference Settings
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public AxisMoveConfigurator Configuration { get; protected set; }
        #endregion

        /// <summary>
        /// Called after <see cref="HorizontalAxis"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(HorizontalAxis))]
        protected virtual void OnAfterHorizontalAxisChange()
        {
            Configuration.ConfigureHorizontalAxis();
        }

        /// <summary>
        /// Called after <see cref="VerticalAxis"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(VerticalAxis))]
        protected virtual void OnAfterVerticalAxisChange()
        {
            Configuration.ConfigureVerticalAxis();
        }

        /// <summary>
        /// Called after <see cref="Target"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(Target))]
        protected virtual void OnAfterTargetChange()
        {
            Configuration.ConfigureTarget();
        }

        /// <summary>
        /// Called after <see cref="ForwardOffset"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(ForwardOffset))]
        protected virtual void OnAfterForwardOffsetChange()
        {
            Configuration.ConfigureForwardOffset();
        }

        /// <summary>
        /// Called after <see cref="RotationPivot"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(RotationPivot))]
        protected virtual void OnAfterRotationPivotChange()
        {
            Configuration.ConfigureRotationPivot();
        }

        /// <summary>
        /// Called after <see cref="SceneCameras"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(SceneCameras))]
        protected virtual void OnAfterSceneCamerasChange()
        {
            Configuration.ConfigureSceneCameras();
        }
    }
}