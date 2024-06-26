using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsPolarGridHelperConstructor :
    JsTypeConstructor
{
    public JsNumber Radius { get; }
        
    public JsNumber Radials { get; }
        
    public JsNumber Circles { get; }
        
    public JsNumber Divisions { get; }
        
    public JsNumber Color1 { get; }
        
    public JsNumber Color2 { get; }
        
        


    internal JsPolarGridHelperConstructor(JsNumber argRadius, JsNumber argRadials, JsNumber argCircles, JsNumber argDivisions, JsNumber argColor1, JsNumber argColor2)
    {
        Radius = argRadius ?? (10).AsJsNumber();
        Radials = argRadials ?? (16).AsJsNumber();
        Circles = argCircles ?? (8).AsJsNumber();
        Divisions = argDivisions ?? (64).AsJsNumber();
        Color1 = argColor1 ?? (4473924).AsJsNumber();
        Color2 = argColor2 ?? (8947848).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.PolarGridHelper({Radius.GetJsCode()}, {Radials.GetJsCode()}, {Circles.GetJsCode()}, {Divisions.GetJsCode()}, {Color1.GetJsCode()}, {Color2.GetJsCode()})";
    }
}
    
public partial class JsPolarGridHelper :
    JsLineSegments
{
    public static implicit operator JsPolarGridHelper(string jsTextCode)
    {
        return new JsPolarGridHelper(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsPolarGridHelper value)
    {
        return value.GetJsCode();
    }


    private readonly JsPolarGridHelper _jsVariableValue;
    public JsPolarGridHelper JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsString _type;
    public JsString Type
    {
        get => _type ?? throw new InvalidOperationException();
        set
        {
            if (_type is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"PolarGridHelper\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }

    internal JsPolarGridHelper(JsTypeConstructor jsCodeSource, JsPolarGridHelper jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
    }

    public JsPolarGridHelper(JsNumber argRadius = null, JsNumber argRadials = null, JsNumber argCircles = null, JsNumber argDivisions = null, JsNumber argColor1 = null, JsNumber argColor2 = null)
        : base(new JsPolarGridHelperConstructor(argRadius, argRadials, argCircles, argDivisions, argColor1, argColor2))
    {
    }

        
}