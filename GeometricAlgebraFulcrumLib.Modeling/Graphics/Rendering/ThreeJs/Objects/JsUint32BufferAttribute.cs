using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsUint32BufferAttributeConstructor :
    JsTypeConstructor
{
    public JsType Array { get; }
        
    public JsType ItemSize { get; }
        
    public JsType Normalized { get; }
        
        


    internal JsUint32BufferAttributeConstructor(JsType argArray, JsType argItemSize, JsType argNormalized)
    {
        Array = argArray ?? new JsObject();
        ItemSize = argItemSize ?? new JsObject();
        Normalized = argNormalized ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Uint32BufferAttribute({Array.GetJsCode()}, {ItemSize.GetJsCode()}, {Normalized.GetJsCode()})";
    }
}
    
public partial class JsUint32BufferAttribute :
    JsBufferAttribute
{
    public static implicit operator JsUint32BufferAttribute(string jsTextCode)
    {
        return new JsUint32BufferAttribute(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsUint32BufferAttribute value)
    {
        return value.GetJsCode();
    }


    private readonly JsUint32BufferAttribute _jsVariableValue;
    public JsUint32BufferAttribute JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsUint32BufferAttribute(JsTypeConstructor jsCodeSource, JsUint32BufferAttribute jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsUint32BufferAttribute(JsType argArray = null, JsType argItemSize = null, JsType argNormalized = null)
        : base(new JsUint32BufferAttributeConstructor(argArray, argItemSize, argNormalized))
    {
    }

        
}