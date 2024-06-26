using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsFloat64BufferAttributeConstructor :
    JsTypeConstructor
{
    public JsType Array { get; }
        
    public JsType ItemSize { get; }
        
    public JsType Normalized { get; }
        
        


    internal JsFloat64BufferAttributeConstructor(JsType argArray, JsType argItemSize, JsType argNormalized)
    {
        Array = argArray ?? new JsObject();
        ItemSize = argItemSize ?? new JsObject();
        Normalized = argNormalized ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Float64BufferAttribute({Array.GetJsCode()}, {ItemSize.GetJsCode()}, {Normalized.GetJsCode()})";
    }
}
    
public partial class JsFloat64BufferAttribute :
    JsBufferAttribute
{
    public static implicit operator JsFloat64BufferAttribute(string jsTextCode)
    {
        return new JsFloat64BufferAttribute(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsFloat64BufferAttribute value)
    {
        return value.GetJsCode();
    }


    private readonly JsFloat64BufferAttribute _jsVariableValue;
    public JsFloat64BufferAttribute JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsFloat64BufferAttribute(JsTypeConstructor jsCodeSource, JsFloat64BufferAttribute jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsFloat64BufferAttribute(JsType argArray = null, JsType argItemSize = null, JsType argNormalized = null)
        : base(new JsFloat64BufferAttributeConstructor(argArray, argItemSize, argNormalized))
    {
    }

        
}