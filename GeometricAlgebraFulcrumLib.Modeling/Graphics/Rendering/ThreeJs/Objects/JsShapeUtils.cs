using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsShapeUtilsConstructor :
    JsTypeConstructor
{
        


    internal JsShapeUtilsConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.ShapeUtils()";
    }
}
    
public partial class JsShapeUtils :
    JsObjectType
{
    public static implicit operator JsShapeUtils(string jsTextCode)
    {
        return new JsShapeUtils(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsShapeUtils value)
    {
        return value.GetJsCode();
    }


    private readonly JsShapeUtils _jsVariableValue;
    public JsShapeUtils JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsShapeUtils(JsTypeConstructor jsCodeSource, JsShapeUtils jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsShapeUtils()
        : base(new JsShapeUtilsConstructor())
    {
    }

        
}