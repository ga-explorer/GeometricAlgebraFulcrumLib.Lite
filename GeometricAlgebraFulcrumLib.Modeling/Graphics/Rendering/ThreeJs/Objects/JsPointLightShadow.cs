using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsPointLightShadowConstructor :
    JsTypeConstructor
{
        


    internal JsPointLightShadowConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.PointLightShadow()";
    }
}
    
public partial class JsPointLightShadow :
    JsLightShadow
{
    public static implicit operator JsPointLightShadow(string jsTextCode)
    {
        return new JsPointLightShadow(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsPointLightShadow value)
    {
        return value.GetJsCode();
    }


    private readonly JsPointLightShadow _jsVariableValue;
    public JsPointLightShadow JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsPointLightShadow(JsTypeConstructor jsCodeSource, JsPointLightShadow jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsPointLightShadow()
        : base(new JsPointLightShadowConstructor())
    {
    }

    public JsType UpdateMatrices(JsType argLight = null, JsNumber argViewportIndex = null)
    {
        return CallMethod("updateMatrices", argLight ?? new JsObject(), argViewportIndex ?? (0).AsJsNumber());
    }
        
        
}