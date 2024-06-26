using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsCubicBezierCurveConstructor :
    JsTypeConstructor
{
    public JsVector2 V0 { get; }
        
    public JsVector2 V1 { get; }
        
    public JsVector2 V2 { get; }
        
    public JsVector2 V3 { get; }
        
        


    internal JsCubicBezierCurveConstructor(JsVector2 argV0, JsVector2 argV1, JsVector2 argV2, JsVector2 argV3)
    {
        V0 = argV0 ?? new JsVector2();
        V1 = argV1 ?? new JsVector2();
        V2 = argV2 ?? new JsVector2();
        V3 = argV3 ?? new JsVector2();
    }

    public override string GetJsCode()
    {
        return $"new THREE.CubicBezierCurve({V0.GetJsCode()}, {V1.GetJsCode()}, {V2.GetJsCode()}, {V3.GetJsCode()})";
    }
}
    
public partial class JsCubicBezierCurve :
    JsCurve
{
    public static implicit operator JsCubicBezierCurve(string jsTextCode)
    {
        return new JsCubicBezierCurve(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsCubicBezierCurve value)
    {
        return value.GetJsCode();
    }


    private readonly JsCubicBezierCurve _jsVariableValue;
    public JsCubicBezierCurve JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"CubicBezierCurve\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsVector2 _v0;
    public JsVector2 V0
    {
        get => _v0 ?? throw new InvalidOperationException();
        set
        {
            if (_v0 is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.v0 = {valueCode};");
        }
    }
        
    private readonly JsVector2 _v1;
    public JsVector2 V1
    {
        get => _v1 ?? throw new InvalidOperationException();
        set
        {
            if (_v1 is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.v1 = {valueCode};");
        }
    }
        
    private readonly JsVector2 _v2;
    public JsVector2 V2
    {
        get => _v2 ?? throw new InvalidOperationException();
        set
        {
            if (_v2 is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.v2 = {valueCode};");
        }
    }
        
    private readonly JsVector2 _v3;
    public JsVector2 V3
    {
        get => _v3 ?? throw new InvalidOperationException();
        set
        {
            if (_v3 is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.v3 = {valueCode};");
        }
    }

    internal JsCubicBezierCurve(JsTypeConstructor jsCodeSource, JsCubicBezierCurve jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _v0 = $"{variableName}.v0".AsJsVector2Variable();
        _v1 = $"{variableName}.v1".AsJsVector2Variable();
        _v2 = $"{variableName}.v2".AsJsVector2Variable();
        _v3 = $"{variableName}.v3".AsJsVector2Variable();
    }

    public JsCubicBezierCurve(JsVector2 argV0 = null, JsVector2 argV1 = null, JsVector2 argV2 = null, JsVector2 argV3 = null)
        : base(new JsCubicBezierCurveConstructor(argV0, argV1, argV2, argV3))
    {
    }

    public JsType GetPoint(JsType argT = null, JsVector2 argOptionalTarget = null)
    {
        return CallMethod("getPoint", argT ?? new JsObject(), argOptionalTarget ?? new JsVector2());
    }
        
    public JsCubicBezierCurve Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
    public JsCubicBezierCurve FromJSON(JsType argJson = null)
    {
        CallMethodVoid("fromJSON", argJson ?? new JsObject());
            
        return this;
    }
        
        
}