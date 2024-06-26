using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsArcCurveConstructor :
    JsTypeConstructor
{
    public JsType AX { get; }
        
    public JsType AY { get; }
        
    public JsType ARadius { get; }
        
    public JsType AStartAngle { get; }
        
    public JsType AEndAngle { get; }
        
    public JsType AClockwise { get; }
        
        


    internal JsArcCurveConstructor(JsType argAX, JsType argAY, JsType argARadius, JsType argAStartAngle, JsType argAEndAngle, JsType argAClockwise)
    {
        AX = argAX ?? new JsObject();
        AY = argAY ?? new JsObject();
        ARadius = argARadius ?? new JsObject();
        AStartAngle = argAStartAngle ?? new JsObject();
        AEndAngle = argAEndAngle ?? new JsObject();
        AClockwise = argAClockwise ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.ArcCurve({AX.GetJsCode()}, {AY.GetJsCode()}, {ARadius.GetJsCode()}, {AStartAngle.GetJsCode()}, {AEndAngle.GetJsCode()}, {AClockwise.GetJsCode()})";
    }
}
    
public partial class JsArcCurve :
    JsEllipseCurve
{
    public static implicit operator JsArcCurve(string jsTextCode)
    {
        return new JsArcCurve(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsArcCurve value)
    {
        return value.GetJsCode();
    }


    private readonly JsArcCurve _jsVariableValue;
    public JsArcCurve JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"ArcCurve\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }

    internal JsArcCurve(JsTypeConstructor jsCodeSource, JsArcCurve jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
    }

    public JsArcCurve(JsType argAX = null, JsType argAY = null, JsType argARadius = null, JsType argAStartAngle = null, JsType argAEndAngle = null, JsType argAClockwise = null)
        : base(new JsArcCurveConstructor(argAX, argAY, argARadius, argAStartAngle, argAEndAngle, argAClockwise))
    {
    }

        
}