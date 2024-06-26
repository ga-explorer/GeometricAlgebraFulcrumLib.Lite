using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsLineCurve3Constructor :
    JsTypeConstructor
{
    public JsVector3 V1 { get; }
        
    public JsVector3 V2 { get; }
        
        


    internal JsLineCurve3Constructor(JsVector3 argV1, JsVector3 argV2)
    {
        V1 = argV1 ?? new JsVector3();
        V2 = argV2 ?? new JsVector3();
    }

    public override string GetJsCode()
    {
        return $"new THREE.LineCurve3({V1.GetJsCode()}, {V2.GetJsCode()})";
    }
}
    
public partial class JsLineCurve3 :
    JsCurve
{
    public static implicit operator JsLineCurve3(string jsTextCode)
    {
        return new JsLineCurve3(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsLineCurve3 value)
    {
        return value.GetJsCode();
    }


    private readonly JsLineCurve3 _jsVariableValue;
    public JsLineCurve3 JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"LineCurve3\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsBoolean _isLineCurve3;
    public JsBoolean IsLineCurve3
    {
        get => _isLineCurve3 ?? throw new InvalidOperationException();
        set
        {
            if (_isLineCurve3 is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.isLineCurve3 = {valueCode};");
        }
    }
        
    private readonly JsVector3 _v1;
    public JsVector3 V1
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
        
    private readonly JsVector3 _v2;
    public JsVector3 V2
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

    internal JsLineCurve3(JsTypeConstructor jsCodeSource, JsLineCurve3 jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _isLineCurve3 = $"{variableName}.isLineCurve3".AsJsBooleanVariable();
        _v1 = $"{variableName}.v1".AsJsVector3Variable();
        _v2 = $"{variableName}.v2".AsJsVector3Variable();
    }

    public JsLineCurve3(JsVector3 argV1 = null, JsVector3 argV2 = null)
        : base(new JsLineCurve3Constructor(argV1, argV2))
    {
    }

    public JsType GetPoint(JsType argT = null, JsVector3 argOptionalTarget = null)
    {
        return CallMethod("getPoint", argT ?? new JsObject(), argOptionalTarget ?? new JsVector3());
    }
        
    public JsType GetPointAt(JsType argU = null, JsType argOptionalTarget = null)
    {
        return CallMethod("getPointAt", argU ?? new JsObject(), argOptionalTarget ?? new JsObject());
    }
        
    public JsLineCurve3 Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
    public JsLineCurve3 FromJSON(JsType argJson = null)
    {
        CallMethodVoid("fromJSON", argJson ?? new JsObject());
            
        return this;
    }
        
        
}