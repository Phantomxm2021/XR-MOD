# 2.0.0-pre.3
## Add
- Add new action type `SendMessageToSDK`,`LoadARWordMap`,`SaveARWordMap`,


# 2.0.0-pre.2
## Add
- Add two new algorithms to `ARAlgorithmNotificationData`. Now developer can control the `ARBackground` and `Basic` AR module status

# 1.0.0-alpha.2
## Change
- Fix InvalidOperationException: Collection was modified; enumeration operation may not execute.
# 1.0.0-alpha.1
## Change
- Add new commit
- Adapter to C# 8

# 0.0.4-alpha.1
## Change
Update version number to 0.0.4-alpha.1

# 0.0.3-preview.1
## Fix
- Call error again after releasing the ActionNotificationCenter
- Fix the invoke error when add observer. remove `Foreach` loop. `For` instead.

## Add
- Add `Release` method to free singleton
- Add new class `TryAcquireCurrentFrameNotificationData`. Let developer custom acquire the specify texture format.
- Add `ResizeARWorldScale` notification data
- Add new enum parameter `ResizeARWorldScale`

## Change
- `ActionNotificationCenter` no longer inherits `MonoBehaviour`
- Remove `ANN` Editor menu
