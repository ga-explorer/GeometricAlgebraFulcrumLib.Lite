using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsCurveConstructor :
    JsTypeConstructor
{
        


    internal JsCurveConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.Curve()";
    }
}
    
public partial class JsCurve :
    JsObjectType
{
    public static implicit operator JsCurve(string jsTextCode)
    {
        return new JsCurve(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsCurve value)
    {
        return value.GetJsCode();
    }


    private readonly JsCurve _jsVariableValue;
    public JsCurve JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"Curve\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsNumber _arcLengthDivisions;
    public JsNumber ArcLengthDivisions
    {
        get => _arcLengthDivisions ?? throw new InvalidOperationException();
        set
        {
            if (_arcLengthDivisions is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "200";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.arcLengthDivisions = {valueCode};");
        }
    }
        
    private readonly JsBoolean _needsUpdate;
    public JsBoolean NeedsUpdate
    {
        get => _needsUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_needsUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.needsUpdate = {valueCode};");
        }
    }
        
    private readonly JsArray _cacheArcLengths;
    public JsArray CacheArcLengths
    {
        get => _cacheArcLengths ?? throw new InvalidOperationException();
        set
        {
            if (_cacheArcLengths is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.cacheArcLengths = {valueCode};");
        }
    }

    internal JsCurve(JsTypeConstructor jsCodeSource, JsCurve jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _arcLengthDivisions = $"{variableName}.arcLengthDivisions".AsJsNumberVariable();
        _needsUpdate = $"{variableName}.needsUpdate".AsJsBooleanVariable();
        _cacheArcLengths = $"{variableName}.cacheArcLengths".AsJsArrayVariable();
    }

    public JsCurve()
        : base(new JsCurveConstructor())
    {
    }

    public JsType GetPoint()
    {
        return CallMethod("getPoint");
    }
        
    public JsType GetPointAt(JsType argU = null, JsType argOptionalTarget = null)
    {
        return CallMethod("getPointAt", argU ?? new JsObject(), argOptionalTarget ?? new JsObject());
    }
        
    public JsArray GetPoints(JsNumber argDivisions = null)
    {
        return CallMethod("getPoints", argDivisions ?? (5).AsJsNumber());
    }
        
    public JsArray GetSpacedPoints(JsNumber argDivisions = null)
    {
        return CallMethod("getSpacedPoints", argDivisions ?? (5).AsJsNumber());
    }
        
    public JsType GetLength()
    {
        return CallMethod("getLength");
    }
        
    public JsArray GetLengths(JsType argDivisions = null)
    {
        return CallMethod("getLengths", argDivisions ?? new JsObject());
    }
        
    public JsType UpdateArcLengths()
    {
        return CallMethod("updateArcLengths");
    }
        
    public JsType GetUtoTmapping(JsType argU = null, JsType argDistance = null)
    {
        return CallMethod("getUtoTmapping", argU ?? new JsObject(), argDistance ?? new JsObject());
    }
        
    public JsType GetTangent(JsType argT = null, JsType argOptionalTarget = null)
    {
        return CallMethod("getTangent", argT ?? new JsObject(), argOptionalTarget ?? new JsObject());
    }
        
    public JsType GetTangentAt(JsType argU = null, JsType argOptionalTarget = null)
    {
        return CallMethod("getTangentAt", argU ?? new JsObject(), argOptionalTarget ?? new JsObject());
    }
        
    public JsType ComputeFrenetFrames(JsType argSegments = null, JsType argClosed = null)
    {
        return CallMethod("computeFrenetFrames", argSegments ?? new JsObject(), argClosed ?? new JsObject());
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsCurve Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsObject ToJSON()
    {
        return CallMethod("toJSON");
    }
        
    public JsCurve FromJSON(JsType argJson = null)
    {
        CallMethodVoid("fromJSON", argJson ?? new JsObject());
            
        return this;
    }
        
        
}