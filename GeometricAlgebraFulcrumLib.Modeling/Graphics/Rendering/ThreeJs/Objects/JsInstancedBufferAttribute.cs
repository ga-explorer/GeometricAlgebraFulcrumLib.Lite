using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsInstancedBufferAttributeConstructor :
    JsTypeConstructor
{
    public JsType Array { get; }
        
    public JsType ItemSize { get; }
        
    public JsType Normalized { get; }
        
    public JsNumber MeshPerAttribute { get; }
        
        


    internal JsInstancedBufferAttributeConstructor(JsType argArray, JsType argItemSize, JsType argNormalized, JsNumber argMeshPerAttribute)
    {
        Array = argArray ?? new JsObject();
        ItemSize = argItemSize ?? new JsObject();
        Normalized = argNormalized ?? new JsObject();
        MeshPerAttribute = argMeshPerAttribute ?? (1).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.InstancedBufferAttribute({Array.GetJsCode()}, {ItemSize.GetJsCode()}, {Normalized.GetJsCode()}, {MeshPerAttribute.GetJsCode()})";
    }
}
    
public partial class JsInstancedBufferAttribute :
    JsBufferAttribute
{
    public static implicit operator JsInstancedBufferAttribute(string jsTextCode)
    {
        return new JsInstancedBufferAttribute(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsInstancedBufferAttribute value)
    {
        return value.GetJsCode();
    }


    private readonly JsInstancedBufferAttribute _jsVariableValue;
    public JsInstancedBufferAttribute JsValue 
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

    internal JsInstancedBufferAttribute(JsTypeConstructor jsCodeSource, JsInstancedBufferAttribute jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _meshPerAttribute = $"{variableName}.meshPerAttribute".AsJsNumberVariable();
    }

    public JsInstancedBufferAttribute(JsType argArray = null, JsType argItemSize = null, JsType argNormalized = null, JsNumber argMeshPerAttribute = null)
        : base(new JsInstancedBufferAttributeConstructor(argArray, argItemSize, argNormalized, argMeshPerAttribute))
    {
    }

    public JsInstancedBufferAttribute Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
        
}