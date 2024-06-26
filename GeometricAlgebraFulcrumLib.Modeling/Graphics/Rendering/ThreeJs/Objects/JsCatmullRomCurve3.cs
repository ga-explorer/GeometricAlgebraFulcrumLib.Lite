using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsCatmullRomCurve3Constructor :
    JsTypeConstructor
{
    public JsArray Points { get; }
        
    public JsBoolean Closed { get; }
        
    public JsString CurveType { get; }
        
    public JsNumber Tension { get; }
        
        


    internal JsCatmullRomCurve3Constructor(JsArray argPoints, JsBoolean argClosed, JsString argCurveType, JsNumber argTension)
    {
        Points = argPoints ?? new JsArray();
        Closed = argClosed ?? (false).AsJsBoolean();
        CurveType = argCurveType ?? ("centripetal").AsJsString();
        Tension = argTension ?? (0.5).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.CatmullRomCurve3({Points.GetJsCode()}, {Closed.GetJsCode()}, {CurveType.GetJsCode()}, {Tension.GetJsCode()})";
    }
}
    
public partial class JsCatmullRomCurve3 :
    JsCurve
{
    public static implicit operator JsCatmullRomCurve3(string jsTextCode)
    {
        return new JsCatmullRomCurve3(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsCatmullRomCurve3 value)
    {
        return value.GetJsCode();
    }


    private readonly JsCatmullRomCurve3 _jsVariableValue;
    public JsCatmullRomCurve3 JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"CatmullRomCurve3\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsArray _points;
    public JsArray Points
    {
        get => _points ?? throw new InvalidOperationException();
        set
        {
            if (_points is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.points = {valueCode};");
        }
    }
        
    private readonly JsBoolean _closed;
    public JsBoolean Closed
    {
        get => _closed ?? throw new InvalidOperationException();
        set
        {
            if (_closed is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.closed = {valueCode};");
        }
    }
        
    private readonly JsString _curveType;
    public JsString CurveType
    {
        get => _curveType ?? throw new InvalidOperationException();
        set
        {
            if (_curveType is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"centripetal\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.curveType = {valueCode};");
        }
    }
        
    private readonly JsNumber _tension;
    public JsNumber Tension
    {
        get => _tension ?? throw new InvalidOperationException();
        set
        {
            if (_tension is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0.5";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.tension = {valueCode};");
        }
    }

    internal JsCatmullRomCurve3(JsTypeConstructor jsCodeSource, JsCatmullRomCurve3 jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _points = $"{variableName}.points".AsJsArrayVariable();
        _closed = $"{variableName}.closed".AsJsBooleanVariable();
        _curveType = $"{variableName}.curveType".AsJsStringVariable();
        _tension = $"{variableName}.tension".AsJsNumberVariable();
    }

    public JsCatmullRomCurve3(JsArray argPoints = null, JsBoolean argClosed = null, JsString argCurveType = null, JsNumber argTension = null)
        : base(new JsCatmullRomCurve3Constructor(argPoints, argClosed, argCurveType, argTension))
    {
    }

    public JsType GetPoint(JsType argT = null, JsVector3 argOptionalTarget = null)
    {
        return CallMethod("getPoint", argT ?? new JsObject(), argOptionalTarget ?? new JsVector3());
    }
        
    public JsCatmullRomCurve3 Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
    public JsCatmullRomCurve3 FromJSON(JsType argJson = null)
    {
        CallMethodVoid("fromJSON", argJson ?? new JsObject());
            
        return this;
    }
        
        
}