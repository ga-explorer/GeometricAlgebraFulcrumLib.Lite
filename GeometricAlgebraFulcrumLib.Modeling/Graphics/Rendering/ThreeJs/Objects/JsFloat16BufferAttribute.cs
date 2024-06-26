using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsFloat16BufferAttributeConstructor :
    JsTypeConstructor
{
    public JsType Array { get; }
        
    public JsType ItemSize { get; }
        
    public JsType Normalized { get; }
        
        


    internal JsFloat16BufferAttributeConstructor(JsType argArray, JsType argItemSize, JsType argNormalized)
    {
        Array = argArray ?? new JsObject();
        ItemSize = argItemSize ?? new JsObject();
        Normalized = argNormalized ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Float16BufferAttribute({Array.GetJsCode()}, {ItemSize.GetJsCode()}, {Normalized.GetJsCode()})";
    }
}
    
public partial class JsFloat16BufferAttribute :
    JsBufferAttribute
{
    public static implicit operator JsFloat16BufferAttribute(string jsTextCode)
    {
        return new JsFloat16BufferAttribute(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsFloat16BufferAttribute value)
    {
        return value.GetJsCode();
    }


    private readonly JsFloat16BufferAttribute _jsVariableValue;
    public JsFloat16BufferAttribute JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsFloat16BufferAttribute(JsTypeConstructor jsCodeSource, JsFloat16BufferAttribute jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsFloat16BufferAttribute(JsType argArray = null, JsType argItemSize = null, JsType argNormalized = null)
        : base(new JsFloat16BufferAttributeConstructor(argArray, argItemSize, argNormalized))
    {
    }

        
}