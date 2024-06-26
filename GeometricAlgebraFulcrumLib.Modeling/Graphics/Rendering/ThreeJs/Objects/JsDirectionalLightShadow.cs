using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsDirectionalLightShadowConstructor :
    JsTypeConstructor
{
        


    internal JsDirectionalLightShadowConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.DirectionalLightShadow()";
    }
}
    
public partial class JsDirectionalLightShadow :
    JsLightShadow
{
    public static implicit operator JsDirectionalLightShadow(string jsTextCode)
    {
        return new JsDirectionalLightShadow(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsDirectionalLightShadow value)
    {
        return value.GetJsCode();
    }


    private readonly JsDirectionalLightShadow _jsVariableValue;
    public JsDirectionalLightShadow JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsDirectionalLightShadow(JsTypeConstructor jsCodeSource, JsDirectionalLightShadow jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsDirectionalLightShadow()
        : base(new JsDirectionalLightShadowConstructor())
    {
    }

        
}