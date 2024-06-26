using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsLoaderUtilsConstructor :
    JsTypeConstructor
{
        


    internal JsLoaderUtilsConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.LoaderUtils()";
    }
}
    
public partial class JsLoaderUtils :
    JsObjectType
{
    public static implicit operator JsLoaderUtils(string jsTextCode)
    {
        return new JsLoaderUtils(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsLoaderUtils value)
    {
        return value.GetJsCode();
    }


    private readonly JsLoaderUtils _jsVariableValue;
    public JsLoaderUtils JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsLoaderUtils(JsTypeConstructor jsCodeSource, JsLoaderUtils jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsLoaderUtils()
        : base(new JsLoaderUtilsConstructor())
    {
    }

        
}