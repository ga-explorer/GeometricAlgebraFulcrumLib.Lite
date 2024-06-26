using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsCurvePathConstructor :
    JsTypeConstructor
{
        


    internal JsCurvePathConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.CurvePath()";
    }
}
    
public partial class JsCurvePath :
    JsCurve
{
    public static implicit operator JsCurvePath(string jsTextCode)
    {
        return new JsCurvePath(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsCurvePath value)
    {
        return value.GetJsCode();
    }


    private readonly JsCurvePath _jsVariableValue;
    public JsCurvePath JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"CurvePath\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _curves;
    public JsType Curves
    {
        get => _curves ?? throw new InvalidOperationException();
        set
        {
            if (_curves is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.curves = {valueCode};");
        }
    }
        
    private readonly JsBoolean _autoClose;
    public JsBoolean AutoClose
    {
        get => _autoClose ?? throw new InvalidOperationException();
        set
        {
            if (_autoClose is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.autoClose = {valueCode};");
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
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.needsUpdate = {valueCode};");
        }
    }
        
    private readonly JsArray _cacheLengths;
    public JsArray CacheLengths
    {
        get => _cacheLengths ?? throw new InvalidOperationException();
        set
        {
            if (_cacheLengths is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.cacheLengths = {valueCode};");
        }
    }

    internal JsCurvePath(JsTypeConstructor jsCodeSource, JsCurvePath jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _curves = $"{variableName}.curves".AsJsTypeVariable();
        _autoClose = $"{variableName}.autoClose".AsJsBooleanVariable();
        _needsUpdate = $"{variableName}.needsUpdate".AsJsBooleanVariable();
        _cacheLengths = $"{variableName}.cacheLengths".AsJsArrayVariable();
    }

    public JsCurvePath()
        : base(new JsCurvePathConstructor())
    {
    }

    public JsType Add(JsType argCurve = null)
    {
        return CallMethod("add", argCurve ?? new JsObject());
    }
        
    public JsType ClosePath()
    {
        return CallMethod("closePath");
    }
        
    public JsType GetPoint(JsType argT = null, JsType argOptionalTarget = null)
    {
        return CallMethod("getPoint", argT ?? new JsObject(), argOptionalTarget ?? new JsObject());
    }
        
    public JsType GetLength()
    {
        return CallMethod("getLength");
    }
        
    public JsType UpdateArcLengths()
    {
        return CallMethod("updateArcLengths");
    }
        
    public JsArray GetCurveLengths()
    {
        return CallMethod("getCurveLengths");
    }
        
    public JsArray GetSpacedPoints(JsNumber argDivisions = null)
    {
        return CallMethod("getSpacedPoints", argDivisions ?? (40).AsJsNumber());
    }
        
    public JsArray GetPoints(JsNumber argDivisions = null)
    {
        return CallMethod("getPoints", argDivisions ?? (12).AsJsNumber());
    }
        
    public JsCurvePath Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
    public JsCurvePath FromJSON(JsType argJson = null)
    {
        CallMethodVoid("fromJSON", argJson ?? new JsObject());
            
        return this;
    }
        
        
}