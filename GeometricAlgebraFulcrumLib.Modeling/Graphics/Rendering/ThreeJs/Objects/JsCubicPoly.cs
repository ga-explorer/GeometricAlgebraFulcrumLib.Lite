using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsCubicPolyConstructor :
    JsTypeConstructor
{
        


    internal JsCubicPolyConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.CubicPoly()";
    }
}
    
public partial class JsCubicPoly :
    JsObject
{
    public static implicit operator JsCubicPoly(string jsTextCode)
    {
        return new JsCubicPoly(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsCubicPoly value)
    {
        return value.GetJsCode();
    }


    private readonly JsCubicPoly _jsVariableValue;
    public JsCubicPoly JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsCubicPoly(JsTypeConstructor jsCodeSource, JsCubicPoly jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsCubicPoly()
        : base(new JsCubicPolyConstructor())
    {
    }

        
}