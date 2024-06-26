using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsPathConstructor :
    JsTypeConstructor
{
    public JsType Points { get; }
        
        


    internal JsPathConstructor(JsType argPoints)
    {
        Points = argPoints ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Path({Points.GetJsCode()})";
    }
}
    
public partial class JsPath :
    JsCurvePath
{
    public static implicit operator JsPath(string jsTextCode)
    {
        return new JsPath(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsPath value)
    {
        return value.GetJsCode();
    }


    private readonly JsPath _jsVariableValue;
    public JsPath JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"Path\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _currentPoint;
    public JsType CurrentPoint
    {
        get => _currentPoint ?? throw new InvalidOperationException();
        set
        {
            if (_currentPoint is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.currentPoint = {valueCode};");
        }
    }

    internal JsPath(JsTypeConstructor jsCodeSource, JsPath jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _currentPoint = $"{variableName}.currentPoint".AsJsTypeVariable();
    }

    public JsPath(JsType argPoints = null)
        : base(new JsPathConstructor(argPoints))
    {
    }

    public JsPath SetFromPoints(JsType argPoints = null)
    {
        CallMethodVoid("setFromPoints", argPoints ?? new JsObject());
            
        return this;
    }
        
    public JsPath MoveTo(JsType argX = null, JsType argY = null)
    {
        CallMethodVoid("moveTo", argX ?? new JsObject(), argY ?? new JsObject());
            
        return this;
    }
        
    public JsPath LineTo(JsType argX = null, JsType argY = null)
    {
        CallMethodVoid("lineTo", argX ?? new JsObject(), argY ?? new JsObject());
            
        return this;
    }
        
    public JsPath QuadraticCurveTo(JsType argACPx = null, JsType argACPy = null, JsType argAX = null, JsType argAY = null)
    {
        CallMethodVoid("quadraticCurveTo", argACPx ?? new JsObject(), argACPy ?? new JsObject(), argAX ?? new JsObject(), argAY ?? new JsObject());
            
        return this;
    }
        
    public JsPath BezierCurveTo(JsType argACP1x = null, JsType argACP1y = null, JsType argACP2x = null, JsType argACP2y = null, JsType argAX = null, JsType argAY = null)
    {
        CallMethodVoid("bezierCurveTo", argACP1x ?? new JsObject(), argACP1y ?? new JsObject(), argACP2x ?? new JsObject(), argACP2y ?? new JsObject(), argAX ?? new JsObject(), argAY ?? new JsObject());
            
        return this;
    }
        
    public JsPath SplineThru(JsType argPts = null)
    {
        CallMethodVoid("splineThru", argPts ?? new JsObject());
            
        return this;
    }
        
    public JsPath Arc(JsType argAX = null, JsType argAY = null, JsType argARadius = null, JsType argAStartAngle = null, JsType argAEndAngle = null, JsType argAClockwise = null)
    {
        CallMethodVoid("arc", argAX ?? new JsObject(), argAY ?? new JsObject(), argARadius ?? new JsObject(), argAStartAngle ?? new JsObject(), argAEndAngle ?? new JsObject(), argAClockwise ?? new JsObject());
            
        return this;
    }
        
    public JsPath Absarc(JsType argAX = null, JsType argAY = null, JsType argARadius = null, JsType argAStartAngle = null, JsType argAEndAngle = null, JsType argAClockwise = null)
    {
        CallMethodVoid("absarc", argAX ?? new JsObject(), argAY ?? new JsObject(), argARadius ?? new JsObject(), argAStartAngle ?? new JsObject(), argAEndAngle ?? new JsObject(), argAClockwise ?? new JsObject());
            
        return this;
    }
        
    public JsPath Ellipse(JsType argAX = null, JsType argAY = null, JsType argXRadius = null, JsType argYRadius = null, JsType argAStartAngle = null, JsType argAEndAngle = null, JsType argAClockwise = null, JsType argARotation = null)
    {
        CallMethodVoid("ellipse", argAX ?? new JsObject(), argAY ?? new JsObject(), argXRadius ?? new JsObject(), argYRadius ?? new JsObject(), argAStartAngle ?? new JsObject(), argAEndAngle ?? new JsObject(), argAClockwise ?? new JsObject(), argARotation ?? new JsObject());
            
        return this;
    }
        
    public JsPath Absellipse(JsType argAX = null, JsType argAY = null, JsType argXRadius = null, JsType argYRadius = null, JsType argAStartAngle = null, JsType argAEndAngle = null, JsType argAClockwise = null, JsType argARotation = null)
    {
        CallMethodVoid("absellipse", argAX ?? new JsObject(), argAY ?? new JsObject(), argXRadius ?? new JsObject(), argYRadius ?? new JsObject(), argAStartAngle ?? new JsObject(), argAEndAngle ?? new JsObject(), argAClockwise ?? new JsObject(), argARotation ?? new JsObject());
            
        return this;
    }
        
    public JsPath Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
    public JsPath FromJSON(JsType argJson = null)
    {
        CallMethodVoid("fromJSON", argJson ?? new JsObject());
            
        return this;
    }
        
        
}