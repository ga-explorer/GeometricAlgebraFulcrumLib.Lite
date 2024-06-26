using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsEllipseCurveConstructor :
    JsTypeConstructor
{
    public JsNumber AX { get; }
        
    public JsNumber AY { get; }
        
    public JsNumber XRadius { get; }
        
    public JsNumber YRadius { get; }
        
    public JsNumber AStartAngle { get; }
        
    public JsType AEndAngle { get; }
        
    public JsBoolean AClockwise { get; }
        
    public JsNumber ARotation { get; }
        
        


    internal JsEllipseCurveConstructor(JsNumber argAX, JsNumber argAY, JsNumber argXRadius, JsNumber argYRadius, JsNumber argAStartAngle, JsType argAEndAngle, JsBoolean argAClockwise, JsNumber argARotation)
    {
        AX = argAX ?? (0).AsJsNumber();
        AY = argAY ?? (0).AsJsNumber();
        XRadius = argXRadius ?? (1).AsJsNumber();
        YRadius = argYRadius ?? (1).AsJsNumber();
        AStartAngle = argAStartAngle ?? (0).AsJsNumber();
        AEndAngle = argAEndAngle ?? new JsObject();
        AClockwise = argAClockwise ?? (false).AsJsBoolean();
        ARotation = argARotation ?? (0).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.EllipseCurve({AX.GetJsCode()}, {AY.GetJsCode()}, {XRadius.GetJsCode()}, {YRadius.GetJsCode()}, {AStartAngle.GetJsCode()}, {AEndAngle.GetJsCode()}, {AClockwise.GetJsCode()}, {ARotation.GetJsCode()})";
    }
}
    
public partial class JsEllipseCurve :
    JsCurve
{
    public static implicit operator JsEllipseCurve(string jsTextCode)
    {
        return new JsEllipseCurve(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsEllipseCurve value)
    {
        return value.GetJsCode();
    }


    private readonly JsEllipseCurve _jsVariableValue;
    public JsEllipseCurve JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"EllipseCurve\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsNumber _aX;
    public JsNumber AX
    {
        get => _aX ?? throw new InvalidOperationException();
        set
        {
            if (_aX is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.aX = {valueCode};");
        }
    }
        
    private readonly JsNumber _aY;
    public JsNumber AY
    {
        get => _aY ?? throw new InvalidOperationException();
        set
        {
            if (_aY is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.aY = {valueCode};");
        }
    }
        
    private readonly JsNumber _xRadius;
    public JsNumber XRadius
    {
        get => _xRadius ?? throw new InvalidOperationException();
        set
        {
            if (_xRadius is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.xRadius = {valueCode};");
        }
    }
        
    private readonly JsNumber _yRadius;
    public JsNumber YRadius
    {
        get => _yRadius ?? throw new InvalidOperationException();
        set
        {
            if (_yRadius is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.yRadius = {valueCode};");
        }
    }
        
    private readonly JsNumber _aStartAngle;
    public JsNumber AStartAngle
    {
        get => _aStartAngle ?? throw new InvalidOperationException();
        set
        {
            if (_aStartAngle is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.aStartAngle = {valueCode};");
        }
    }
        
    private readonly JsType _aEndAngle;
    public JsType AEndAngle
    {
        get => _aEndAngle ?? throw new InvalidOperationException();
        set
        {
            if (_aEndAngle is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.aEndAngle = {valueCode};");
        }
    }
        
    private readonly JsBoolean _aClockwise;
    public JsBoolean AClockwise
    {
        get => _aClockwise ?? throw new InvalidOperationException();
        set
        {
            if (_aClockwise is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.aClockwise = {valueCode};");
        }
    }
        
    private readonly JsNumber _aRotation;
    public JsNumber ARotation
    {
        get => _aRotation ?? throw new InvalidOperationException();
        set
        {
            if (_aRotation is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.aRotation = {valueCode};");
        }
    }

    internal JsEllipseCurve(JsTypeConstructor jsCodeSource, JsEllipseCurve jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _aX = $"{variableName}.aX".AsJsNumberVariable();
        _aY = $"{variableName}.aY".AsJsNumberVariable();
        _xRadius = $"{variableName}.xRadius".AsJsNumberVariable();
        _yRadius = $"{variableName}.yRadius".AsJsNumberVariable();
        _aStartAngle = $"{variableName}.aStartAngle".AsJsNumberVariable();
        _aEndAngle = $"{variableName}.aEndAngle".AsJsTypeVariable();
        _aClockwise = $"{variableName}.aClockwise".AsJsBooleanVariable();
        _aRotation = $"{variableName}.aRotation".AsJsNumberVariable();
    }

    public JsEllipseCurve(JsNumber argAX = null, JsNumber argAY = null, JsNumber argXRadius = null, JsNumber argYRadius = null, JsNumber argAStartAngle = null, JsType argAEndAngle = null, JsBoolean argAClockwise = null, JsNumber argARotation = null)
        : base(new JsEllipseCurveConstructor(argAX, argAY, argXRadius, argYRadius, argAStartAngle, argAEndAngle, argAClockwise, argARotation))
    {
    }

    public JsType GetPoint(JsType argT = null, JsType argOptionalTarget = null)
    {
        return CallMethod("getPoint", argT ?? new JsObject(), argOptionalTarget ?? new JsObject());
    }
        
    public JsEllipseCurve Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
    public JsEllipseCurve FromJSON(JsType argJson = null)
    {
        CallMethodVoid("fromJSON", argJson ?? new JsObject());
            
        return this;
    }
        
        
}