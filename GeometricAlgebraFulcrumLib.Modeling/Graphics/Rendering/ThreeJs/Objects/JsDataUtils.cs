using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsDataUtilsConstructor :
    JsTypeConstructor
{
        


    internal JsDataUtilsConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.DataUtils()";
    }
}
    
public partial class JsDataUtils :
    JsObjectType
{
    public static implicit operator JsDataUtils(string jsTextCode)
    {
        return new JsDataUtils(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsDataUtils value)
    {
        return value.GetJsCode();
    }


    private readonly JsDataUtils _jsVariableValue;
    public JsDataUtils JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsDataUtils(JsTypeConstructor jsCodeSource, JsDataUtils jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsDataUtils()
        : base(new JsDataUtilsConstructor())
    {
    }

        
}