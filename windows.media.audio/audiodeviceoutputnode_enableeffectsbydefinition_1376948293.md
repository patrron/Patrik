---
-api-id: M:Windows.Media.Audio.AudioDeviceOutputNode.EnableEffectsByDefinition(Windows.Media.Effects.IAudioEffectDefinition)
-api-type: winrt method
---

<!-- Method syntax
public void EnableEffectsByDefinition(Windows.Media.Effects.IAudioEffectDefinition definition)
-->

# Windows.Media.Audio.AudioDeviceOutputNode.EnableEffectsByDefinition

## -description
Enables all effects in the [EffectDefinitions](audiodeviceoutputnode_effectdefinitions.md) list with the specified effect definition.

## -parameters
### -param definition
The effect definition of the effects to enable.

## -remarks
Apply an audio effect to a node by adding an object that implements [IAudioEffectDefinition](../windows.media.effects/iaudioeffectdefinition.md) to the [EffectDefinitions](audiodeviceoutputnode_effectdefinitions.md) collection. Disable effects by calling [DisableEffectsByDefinition](audiodeviceoutputnode_disableeffectsbydefinition_730128310.md).

## -examples

## -see-also
