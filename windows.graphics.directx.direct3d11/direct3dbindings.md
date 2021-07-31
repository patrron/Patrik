---
-api-id: T:Windows.Graphics.DirectX.Direct3D11.Direct3DBindings
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax
public enum Windows.Graphics.DirectX.Direct3D11.Direct3DBindings : uint
-->

# Direct3DBindings

## -description
This is a Windows Runtime equivalent of the Desktop [D3D11_BIND_FLAG](/windows/desktop/api/d3d11/ne-d3d11-d3d11_bind_flag) enumeration. Identifies the ways in which a resource may be bound to the graphics pipeline.

## -enum-fields
### -field VertexBuffer:1
Bind a buffer as a vertex buffer to the input-assembler stage.

### -field IndexBuffer:2
Bind a buffer as an index buffer to the input-assembler stage.

### -field ConstantBuffer:4
Bind a buffer as a constant buffer to a shader stage.

### -field ShaderResource:8
Bind a buffer or texture to a shader stage.

### -field StreamOutput:16
Bind an output buffer for the stream-output stage.

### -field RenderTarget:32
Bind a texture as a render target for the output-merger stage.

### -field DepthStencil:64
Bind a texture as a depth-stencil target for the output-merger stage.

### -field UnorderedAccess:128
Bind an unordered access resource.

### -field Decoder:512
Set this flag to indicate that a 2D texture is used to receive output from the decoder API.

### -field VideoEncoder:1024
Set this flag to indicate that a 2D texture is used to receive input from the video encoder API.

## -remarks

## -examples

## -see-also
