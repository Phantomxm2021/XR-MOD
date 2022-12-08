# 2.0.0-preview.3
## Added 
- Add `SendMessageToSDK` 

# 1.0.0-alpha.6
## Change
- Remove `ARMODAPI.cs`
# 1.0.0-alpha.2
## Fix
- Fix `GetGameObjectByTag` the wrong object was found (the objects in the resource may be obtained)

# 1.0.0-alpha.1
## Change
- Remove useless methods

# 0.0.5-alpha.1
## Change
- Remove useless commit
- Change `TryAcquireAppInfo` method `return value` to `void`
- Deprecated `LoadGameObject`,`LoadTexture2D`,`LoadSpriteAtlas`,`LoadAudioClip`,`LoadVideoClip`,`LoadTextAsset`,`LoadFont`,`LoadAnimationClip`.Use `LoadAsset<T>` or `LoadAssetAsync<T>` instead.

# 0.0.4-alpha.1
## Change
Update version number to 0.0.4-alpha.1


# 0.0.3-preview.1
## Change
- Obsolete `API.InstanceGameObject` api. Use `Object.Instantiate` instead
- To instantiate the API, you need to pass in the project name
- Remove all parameters that need to be passed in the project name method
-  Change`TryAcquireCurrentFrame` API to `TryAcquireCurrentFrame(TryAcquireCurrentFrameNotificationData _data)`

## Fix
- Fix the performance of `CheckFeatureAvailability`
- Fix the performance of `TryAcquireAROcclusionFrame` and add paramater `AROcclusionNotificationData`
- Remove `LoadAssetAsync` Obsolete

## Add
- Load `ComputeShader` Supported
- New API of `ResizeARWorldScale`
- Add new method `TryAcquireAROcclusionFrame()` for developer get AROcclusion images 
- Add `LoadAssetsAsync()`
- Add `LoadAsset<T>()`
- Add `LoadMaterial()`
- Add CHANGELOG.md file