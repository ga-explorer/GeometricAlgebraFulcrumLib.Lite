using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsInt16BufferAttributeConstructor :
    JsTypeConstructor
{
    public JsType Array { get; }
        
    public JsType ItemSize { get; }
        
    public JsType Normalized { get; }
        
        


    internal JsInt16BufferAttributeConstructor(JsType argArray, JsType argItemSize, JsType argNormalized)
    {
        Array = argArray ?? new JsObject();
        ItemSize = argItemSize ?? new JsObject();
        Normalized = argNormalized ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Int16BufferAttribute({Array.GetJsCode()}, {ItemSize.GetJsCode()}, {Normalized.GetJsCode()})";
    }
}
    
public partial class JsInt16BufferAttribute :
    JsBufferAttribute
{
    public static implicit operator JsInt16BufferAttribute(string jsTextCode)
    {
        return new JsInt16BufferAttribute(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsInt16BufferAttribute value)
    {
        return value.GetJsCode();
    }


    private readonly JsInt16BufferAttribute _jsVariableValue;
    public JsInt16BufferAttribute JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsInt16BufferAttribute(JsTypeConstructor jsCodeSource, JsInt16BufferAttribute jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsInt16BufferAttribute(JsType argArray = null, JsType argItemSize = null, JsType argNormalized = null)
        : base(new JsInt16BufferAttributeConstructor(argArray, argItemSize, argNormalized))
    {
    }

        
}