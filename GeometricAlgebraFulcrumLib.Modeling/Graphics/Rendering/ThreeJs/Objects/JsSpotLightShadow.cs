using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsSpotLightShadowConstructor :
    JsTypeConstructor
{
        


    internal JsSpotLightShadowConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.SpotLightShadow()";
    }
}
    
public partial class JsSpotLightShadow :
    JsLightShadow
{
    public static implicit operator JsSpotLightShadow(string jsTextCode)
    {
        return new JsSpotLightShadow(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsSpotLightShadow value)
    {
        return value.GetJsCode();
    }


    private readonly JsSpotLightShadow _jsVariableValue;
    public JsSpotLightShadow JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsNumber _focus;
    public JsNumber Focus
    {
        get => _focus ?? throw new InvalidOperationException();
        set
        {
            if (_focus is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.focus = {valueCode};");
        }
    }

    internal JsSpotLightShadow(JsTypeConstructor jsCodeSource, JsSpotLightShadow jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _focus = $"{variableName}.focus".AsJsNumberVariable();
    }

    public JsSpotLightShadow()
        : base(new JsSpotLightShadowConstructor())
    {
    }

    public JsType UpdateMatrices(JsType argLight = null)
    {
        return CallMethod("updateMatrices", argLight ?? new JsObject());
    }
        
    public JsSpotLightShadow Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}