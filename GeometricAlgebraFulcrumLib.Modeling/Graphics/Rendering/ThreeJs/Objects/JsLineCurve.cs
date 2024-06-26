using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsLineCurveConstructor :
    JsTypeConstructor
{
    public JsVector2 V1 { get; }
        
    public JsVector2 V2 { get; }
        
        


    internal JsLineCurveConstructor(JsVector2 argV1, JsVector2 argV2)
    {
        V1 = argV1 ?? new JsVector2();
        V2 = argV2 ?? new JsVector2();
    }

    public override string GetJsCode()
    {
        return $"new THREE.LineCurve({V1.GetJsCode()}, {V2.GetJsCode()})";
    }
}
    
public partial class JsLineCurve :
    JsCurve
{
    public static implicit operator JsLineCurve(string jsTextCode)
    {
        return new JsLineCurve(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsLineCurve value)
    {
        return value.GetJsCode();
    }


    private readonly JsLineCurve _jsVariableValue;
    public JsLineCurve JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"LineCurve\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
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

    internal JsLineCurve(JsTypeConstructor jsCodeSource, JsLineCurve jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _v1 = $"{variableName}.v1".AsJsVector2Variable();
        _v2 = $"{variableName}.v2".AsJsVector2Variable();
    }

    public JsLineCurve(JsVector2 argV1 = null, JsVector2 argV2 = null)
        : base(new JsLineCurveConstructor(argV1, argV2))
    {
    }

    public JsType GetPoint(JsType argT = null, JsVector2 argOptionalTarget = null)
    {
        return CallMethod("getPoint", argT ?? new JsObject(), argOptionalTarget ?? new JsVector2());
    }
        
    public JsType GetPointAt(JsType argU = null, JsType argOptionalTarget = null)
    {
        return CallMethod("getPointAt", argU ?? new JsObject(), argOptionalTarget ?? new JsObject());
    }
        
    public JsType GetTangent(JsType argT = null, JsType argOptionalTarget = null)
    {
        return CallMethod("getTangent", argT ?? new JsObject(), argOptionalTarget ?? new JsObject());
    }
        
    public JsLineCurve Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
    public JsLineCurve FromJSON(JsType argJson = null)
    {
        CallMethodVoid("fromJSON", argJson ?? new JsObject());
            
        return this;
    }
        
        
}