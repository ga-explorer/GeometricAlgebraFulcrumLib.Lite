using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsInstancedInterleavedBufferConstructor :
    JsTypeConstructor
{
    public JsType Array { get; }
        
    public JsType Stride { get; }
        
    public JsNumber MeshPerAttribute { get; }
        
        


    internal JsInstancedInterleavedBufferConstructor(JsType argArray, JsType argStride, JsNumber argMeshPerAttribute)
    {
        Array = argArray ?? new JsObject();
        Stride = argStride ?? new JsObject();
        MeshPerAttribute = argMeshPerAttribute ?? (1).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.InstancedInterleavedBuffer({Array.GetJsCode()}, {Stride.GetJsCode()}, {MeshPerAttribute.GetJsCode()})";
    }
}
    
public partial class JsInstancedInterleavedBuffer :
    JsInterleavedBuffer
{
    public static implicit operator JsInstancedInterleavedBuffer(string jsTextCode)
    {
        return new JsInstancedInterleavedBuffer(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsInstancedInterleavedBuffer value)
    {
        return value.GetJsCode();
    }


    private readonly JsInstancedInterleavedBuffer _jsVariableValue;
    public JsInstancedInterleavedBuffer JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsNumber _meshPerAttribute;
    public JsNumber MeshPerAttribute
    {
        get => _meshPerAttribute ?? throw new InvalidOperationException();
        set
        {
            if (_meshPerAttribute is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.meshPerAttribute = {valueCode};");
        }
    }

    internal JsInstancedInterleavedBuffer(JsTypeConstructor jsCodeSource, JsInstancedInterleavedBuffer jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _meshPerAttribute = $"{variableName}.meshPerAttribute".AsJsNumberVariable();
    }

    public JsInstancedInterleavedBuffer(JsType argArray = null, JsType argStride = null, JsNumber argMeshPerAttribute = null)
        : base(new JsInstancedInterleavedBufferConstructor(argArray, argStride, argMeshPerAttribute))
    {
    }

    public JsInstancedInterleavedBuffer Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType Clone(JsType argData = null)
    {
        return CallMethod("clone", argData ?? new JsObject());
    }
        
    public JsType ToJSON(JsType argData = null)
    {
        return CallMethod("toJSON", argData ?? new JsObject());
    }
        
        
}