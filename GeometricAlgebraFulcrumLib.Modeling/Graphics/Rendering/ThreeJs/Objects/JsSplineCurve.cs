using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsSplineCurveConstructor :
    JsTypeConstructor
{
    public JsArray Points { get; }
        
        


    internal JsSplineCurveConstructor(JsArray argPoints)
    {
        Points = argPoints ?? new JsArray();
    }

    public override string GetJsCode()
    {
        return $"new THREE.SplineCurve({Points.GetJsCode()})";
    }
}
    
public partial class JsSplineCurve :
    JsCurve
{
    public static implicit operator JsSplineCurve(string jsTextCode)
    {
        return new JsSplineCurve(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsSplineCurve value)
    {
        return value.GetJsCode();
    }


    private readonly JsSplineCurve _jsVariableValue;
    public JsSplineCurve JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"SplineCurve\"";
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

    internal JsSplineCurve(JsTypeConstructor jsCodeSource, JsSplineCurve jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _points = $"{variableName}.points".AsJsArrayVariable();
    }

    public JsSplineCurve(JsArray argPoints = null)
        : base(new JsSplineCurveConstructor(argPoints))
    {
    }

    public JsType GetPoint(JsType argT = null, JsVector2 argOptionalTarget = null)
    {
        return CallMethod("getPoint", argT ?? new JsObject(), argOptionalTarget ?? new JsVector2());
    }
        
    public JsSplineCurve Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
    public JsSplineCurve FromJSON(JsType argJson = null)
    {
        CallMethodVoid("fromJSON", argJson ?? new JsObject());
            
        return this;
    }
        
        
}