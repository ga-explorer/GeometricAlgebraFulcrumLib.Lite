using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsImageUtilsConstructor :
    JsTypeConstructor
{
        


    internal JsImageUtilsConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.ImageUtils()";
    }
}
    
public partial class JsImageUtils :
    JsObjectType
{
    public static implicit operator JsImageUtils(string jsTextCode)
    {
        return new JsImageUtils(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsImageUtils value)
    {
        return value.GetJsCode();
    }


    private readonly JsImageUtils _jsVariableValue;
    public JsImageUtils JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsImageUtils(JsTypeConstructor jsCodeSource, JsImageUtils jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsImageUtils()
        : base(new JsImageUtilsConstructor())
    {
    }

        
}