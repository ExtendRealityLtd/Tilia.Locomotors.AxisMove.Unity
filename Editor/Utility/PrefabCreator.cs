namespace Tilia.Locomotion.AxisMove.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "Locomotors/AxisMove/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.locomotors.axismove.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabAxisMoveVerticalSlideHorizontalSlide = "Locomotors.AxisMove.Vertical-Slide.Horizontal-Slide";
        private const string prefabAxisMoveVerticalSlideHorizontalSmoothRotate = "Locomotors.AxisMove.Vertical-Slide.Horizontal-SmoothRotate";
        private const string prefabAxisMoveVerticalSlideHorizontalSnapRotate = "Locomotors.AxisMove.Vertical-Slide.Horizontal-SnapRotate";
        private const string prefabAxisMoveVerticalWarpHorizontalSnapRotate = "Locomotors.AxisMove.Vertical-Warp.Horizontal-SnapRotate";

        [MenuItem(menuItemRoot + prefabAxisMoveVerticalSlideHorizontalSlide, false, priority)]
        private static void AddAxisMoveVerticalSlideHorizontalSlide()
        {
            string prefab = prefabAxisMoveVerticalSlideHorizontalSlide + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + prefabAxisMoveVerticalSlideHorizontalSmoothRotate, false, priority)]
        private static void AddAxisMoveVerticalSlideHorizontalSmoothRotate()
        {
            string prefab = prefabAxisMoveVerticalSlideHorizontalSmoothRotate + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + prefabAxisMoveVerticalSlideHorizontalSnapRotate, false, priority)]
        private static void AddAxisMoveVerticalSlideHorizontalSnapRotate()
        {
            string prefab = prefabAxisMoveVerticalSlideHorizontalSnapRotate + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + prefabAxisMoveVerticalWarpHorizontalSnapRotate, false, priority)]
        private static void AddAxisMoveVerticalWarpHorizontalSnapRotate()
        {
            string prefab = prefabAxisMoveVerticalWarpHorizontalSnapRotate + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}