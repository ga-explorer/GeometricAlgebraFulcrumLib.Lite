using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsUint8ClampedBufferAttributeConstructor :
    JsTypeConstructor
{
    public JsType Array { get; }
        
    public JsType ItemSize { get; }
        
    public JsType Normalized { get; }
        
        


    internal JsUint8ClampedBufferAttributeConstructor(JsType argArray, JsType argItemSize, JsType argNormalized)
    {
        Array = argArray ?? new JsObject();
        ItemSize = argItemSize ?? new JsObject();
        Normalized = argNormalized ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Uint8ClampedBufferAttribute({Array.GetJsCode()}, {ItemSize.GetJsCode()}, {Normalized.GetJsCode()})";
    }
}
    
public partial class JsUint8ClampedBufferAttribute :
    JsBufferAttribute
{
    public static implicit operator JsUint8ClampedBufferAttribute(string jsTextCode)
    {
        return new JsUint8ClampedBufferAttribute(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsUint8ClampedBufferAttribute value)
    {
        return value.GetJsCode();
    }


    private readonly JsUint8ClampedBufferAttribute _jsVariableValue;
    public JsUint8ClampedBufferAttribute JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsUint8ClampedBufferAttribute(JsTypeConstructor jsCodeSource, JsUint8ClampedBufferAttribute jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsUint8ClampedBufferAttribute(JsType argArray = null, JsType argItemSize = null, JsType argNormalized = null)
        : base(new JsUint8ClampedBufferAttributeConstructor(argArray, argItemSize, argNormalized))
    {
    }

        
}