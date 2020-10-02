# Changelog

### [1.1.19](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.18...v1.1.19) (2020-10-02)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.input.combinedactions.unity ([302be0a](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/302be0aa6aeed402e91ec7722b2121fa75d78638))
  > Bumps [io.extendreality.tilia.input.combinedactions.unity](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity) from 1.8.5 to 1.8.6. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.8.5...v1.8.6)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.18](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.17...v1.1.18) (2020-10-02)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.24.0 to 1.25.0 ([7c60fd9](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/7c60fd9c8d098de1c8179ee88c15650d606adae6))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.24.0 to 1.25.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.24.0...v1.25.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.17](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.16...v1.1.17) (2020-08-30)

#### Bug Fixes

* **Prefabs:** ensure smooth rotate uses delta time for time multiplier ([a48522f](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/a48522fc96263fcbc2b0d99ed50845e5ceaae213))
  > There was an issue where smooth rotate would increase in speed with every rotation due to the Time Multiplier being set to `Time` so it was increasing from the original time frame.
  > 
  > The Rotation Mutator used within the Smooth Rotate operation is now using the `Time Step Type Delta Time` Time Multiplier so it should not increase in speed with every rotation.

#### Code Refactoring

* **Prefabs:** update internal name to match prefab name ([14a6b89](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/14a6b891a9f65d1451b38b7058146bea3be61239))
  > The prefab GameObject name was changed so the internal `m_Name` has been updated to match.

### [1.1.16](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.15...v1.1.16) (2020-08-29)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.input.combinedactions.unity ([0429ba3](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/0429ba38db3892a28806345e30f22ad76703df29))
  > Bumps [io.extendreality.tilia.input.combinedactions.unity](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity) from 1.8.4 to 1.8.5. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.8.4...v1.8.5)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.15](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.14...v1.1.15) (2020-08-29)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.23.0 to 1.24.0 ([9185a65](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/9185a65d62bbfdd1fbe0f1be16ab8a345e5e54eb))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.23.0 to 1.24.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.23.0...v1.24.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.14](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.13...v1.1.14) (2020-08-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.input.combinedactions.unity ([0b78266](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/0b78266f8d6b2475550911d81bcc0bf11788e9b8))
  > Bumps [io.extendreality.tilia.input.combinedactions.unity](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity) from 1.8.3 to 1.8.4. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.8.3...v1.8.4)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.13](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.12...v1.1.13) (2020-08-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.22.0 to 1.23.0 ([59e6343](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/59e6343482f2ca591d75bc3caa09a5463fdc15ba))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.22.0 to 1.23.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.22.0...v1.23.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.12](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.11...v1.1.12) (2020-08-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.input.combinedactions.unity ([f82c822](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/f82c8220c7224c9cd84b003d293372a383ad157e))
  > Bumps [io.extendreality.tilia.input.combinedactions.unity](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity) from 1.8.2 to 1.8.3. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.8.2...v1.8.3)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.11](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.10...v1.1.11) (2020-08-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.21.0 to 1.22.0 ([734930b](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/734930b93cb8dc4440054f97eaf3deccda6f5a68))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.21.0 to 1.22.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.21.0...v1.22.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.10](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.9...v1.1.10) (2020-07-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.input.combinedactions.unity ([da5e63e](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/da5e63ef78205debc9aca051cd82631cb8996048))
  > Bumps [io.extendreality.tilia.input.combinedactions.unity](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity) from 1.8.1 to 1.8.2. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.8.1...v1.8.2)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.9](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.8...v1.1.9) (2020-07-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.20.0 to 1.21.0 ([b95dc14](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/b95dc14ff8012966a8550b417253035d0fda93fe))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.20.0 to 1.21.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.20.0...v1.21.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.8](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.7...v1.1.8) (2020-07-11)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.input.combinedactions.unity ([dbedd50](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/dbedd509496f05a1c84b93d374afb47ed285f972))
  > Bumps [io.extendreality.tilia.input.combinedactions.unity](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity) from 1.8.0 to 1.8.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.8.0...v1.8.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.7](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.6...v1.1.7) (2020-07-11)

#### Bug Fixes

* **Prefab:** use combined deadzone to prevent double diagonal speed ([2442c5a](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/2442c5a88038dfa27ba893ec7bf9525c678944cb))
  > The CombinedActions AxesToVector3Action now provides a mechanism of combining the axis values to determine a zonal deadzone and using this fixes the issue where pushing in a diagonal direction would cause a doubling of speed.

### [1.1.6](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.5...v1.1.6) (2020-07-11)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.input.combinedactions.unity ([df87e19](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/df87e19ae6a0dcceacc7f13396285a45962c0660))
  > Bumps [io.extendreality.tilia.input.combinedactions.unity](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity) from 1.7.0 to 1.7.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.7.0...v1.7.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.5](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.4...v1.1.5) (2020-07-11)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.19.0 to 1.20.0 ([a3a2bf7](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/a3a2bf74e2f611833cc83b0c481b370ef401742a))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.19.0 to 1.20.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.19.0...v1.20.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.4](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.3...v1.1.4) (2020-07-07)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.input.combinedactions.unity ([4551079](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/4551079f6270528b635660c19113de8efd79a2da))
  > Bumps [io.extendreality.tilia.input.combinedactions.unity](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity) from 1.6.1 to 1.7.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.6.1...v1.7.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.3](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.2...v1.1.3) (2020-07-04)

#### Bug Fixes

* **Prefabs:** set Time Multiplier property on MovementMutator ([bd9f4c7](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/bd9f4c78ff401e179a86e41949cb8bb2c7a9fa73))
  > The CombinedActions package has now been updated so the AxesToVector3 prefab exposes the Time Component Extractor multiplier on the Facade so instead of manually overriding the Time Component at the lower level, it can now be changed on the facade.
  > 
  > This brings in that change, plus renames the prefabs to something more meaningful.

### [1.1.2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.1...v1.1.2) (2020-07-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.input.combinedactions.unity ([a3c9ff8](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/a3c9ff812c03f09002acb6f6a5d824abe69aebff))
  > Bumps [io.extendreality.tilia.input.combinedactions.unity](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity) from 1.5.0 to 1.5.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.5.0...v1.5.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.1](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/compare/v1.1.0...v1.1.1) (2020-07-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.input.combinedactions.unity ([10fe0dc](https://github.com/ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity/commit/10fe0dcac16a29e6bd301efa910f688a899bed17))
  > Bumps [io.extendreality.tilia.input.combinedactions.unity](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity) from 1.4.3 to 1.5.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Input.CombinedActions.Unity/compare/v1.4.3...v1.5.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

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
