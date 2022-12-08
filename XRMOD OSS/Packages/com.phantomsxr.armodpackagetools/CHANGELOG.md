# 1.2.0
## Change 
- Remove legacy web request codes
- Add new dependency `Uni-Task`

# 1.1.5
## Change
- Remove Debug.LogError

# 1.1.4
## Fix
- Fix incorrect namespace of templates
- Fix `Build Settings` is not stored

# 1.1.3
## Change
- ignore free other assetbundle, just only arexperience assetbundle 

# 1.1.2
## Added
- add new block of programable for the xrmod project's properties

# 1.1.1
## Improved
- Auto Refresh XRMOD project app domain files

# 1.0.1
## Fix 
- Not return value error 

# 1.0.0-alpha.2
## Fix
- Fix load from local when there are same name of game object problem
- 
# 1.0.0-alpha.1
## Change
- Reduce the useless codes
## Fix
- Fix the bugs
- Fix create project from template not working after multi-time
- Fix new UIElement uss
## Add
- New create project interface
- Load asset from local when project is already in the local(Not a bundle)

# 0.0.5-alpha.3
## Change
- Deprecated Automatically rename existing objects with the same name. The existing object will not stored.

# 0.0.5-alpha.2
## Fix
- Fix Immersal block Localization Interval time to second,Set the minimum and maximum interval.

# 0.0.5-alpha.1
## Add
- Add new settings for immersal sdk
- Add new Action notification key to change template Mono Binder project name field
- Loading Asset from Editor support. Now, you can load asset directly using `API.LoadAssetAsync<T>`. It can help us develop or testing more quickly.

## Changed
- Move Cache file to Default Editor Resources
- Change the `Localization Interval` field in Immersal Block to a Slider
## Fix
- Fix error when script compiling
- Fix open or edit project Action key not exist
- Remove the dependence on Mono binder


# 0.0.4-alpha.1
## Change
Update version number to 0.0.4-alpha.1

# 0.0.3-alpha.1
Reset version to 0.0.3-alpha.1

# 0.0.7-preview.5
## Change
-  Mixed with UI Element

# 0.0.7-preview.4
## Change
- Obsolete `InstantiateUtility.Instantiate` api. Use `Object.Instantiate` instead
- New script template

# 0.0.7-preview.3
## Add
- Add new block `ARWorldScaleBlock`
- Add new field `ARWorldScale` to Configure

## Fix
- Fix default quality to medium
- Change `Alogirhtm block` and `Programmable block` warring HelpBox show condition
- Fix `ShowNotify` when window is not showed
- Move `Coach overlay block` to iOS menu


# 0.0.7-preview.2
## Add

- Add document url for block
- Add CHANGELOG.md file

## Fix
- Remove github info
