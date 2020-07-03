# Changelog

## [1.1.0](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.0.3...v1.1.0) (2020-07-03)

#### Features

* **API:** add auto-generated API documentation ([2f20c94](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/2f20c946d9fac678fcd414953a269eda854f1340))
  > The API documentation is auto generated with docfx and converted to markdown via turndown in a custom nodejs script.

#### Bug Fixes

* **package.json:** add docfx.json file ([a37ed6e](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/a37ed6e3fc7adce0a444fb9ec955783eeeef13eb))
  > The docfx.json file was missing from the package.json causing the build process to fail. It has now been added.

### [1.0.3](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.0.2...v1.0.3) (2020-06-08)

#### Bug Fixes

* **prefab:** only use y rotation on movement facing direction ([34da9bc](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/34da9bc1fa608da0538bdfe398283eb80644ab7c))
  > The facing direction offset on the movement was previously using all axes for the rotation facing direction, which meant if the facing direction object (e.g. headset) was pointing at the ground then the facing direction would be straight down and this would mean the target would not move.
  > 
  > A new feature in Zinnia means the facing direction can determine which axes want to be used for the rotational offset so this is now used and only the y rotation is used so it works over a simple 2 plane.

### [1.0.2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.0.1...v1.0.2) (2020-06-08)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.input.combinedactions.unity ([c6b9cd7](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/c6b9cd78a475eeba36f442316f1ccf86a82bd367))
  > Bumps [io.extendreality.tilia.input.combinedactions.unity](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity) from 1.4.2 to 1.4.3. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.4.2...v1.4.3)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.1](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.0.0...v1.0.1) (2020-06-08)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.18.0 to 1.19.0 ([eb689be](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/eb689be05c2c72f80f609051a9268239989cc132))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.18.0 to 1.19.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.18.0...v1.19.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## 1.0.0 (2020-05-31)

#### Features

* **structure:** create initial prefab and user guides ([9463f7f](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/9463f7f14ca2513da206192cfcd21bb01f9e00d0))
  > The structure of the repository has been created with all the required files for the package, the prefab and the installation guide.
