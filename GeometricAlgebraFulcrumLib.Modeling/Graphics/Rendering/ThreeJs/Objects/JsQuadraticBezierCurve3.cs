using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsQuadraticBezierCurve3Constructor :
    JsTypeConstructor
{
    public JsVector3 V0 { get; }
        
    public JsVector3 V1 { get; }
        
    public JsVector3 V2 { get; }
        
        


    internal JsQuadraticBezierCurve3Constructor(JsVector3 argV0, JsVector3 argV1, JsVector3 argV2)
    {
        V0 = argV0 ?? new JsVector3();
        V1 = argV1 ?? new JsVector3();
        V2 = argV2 ?? new JsVector3();
    }

    public override string GetJsCode()
    {
        return $"new THREE.QuadraticBezierCurve3({V0.GetJsCode()}, {V1.GetJsCode()}, {V2.GetJsCode()})";
    }
}
    
public partial class JsQuadraticBezierCurve3 :
    JsCurve
{
    public static implicit operator JsQuadraticBezierCurve3(string jsTextCode)
    {
        return new JsQuadraticBezierCurve3(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsQuadraticBezierCurve3 value)
    {
        return value.GetJsCode();
    }


    private readonly JsQuadraticBezierCurve3 _jsVariableValue;
    public JsQuadraticBezierCurve3 JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"QuadraticBezierCurve3\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsVector3 _v0;
    public JsVector3 V0
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

    internal JsQuadraticBezierCurve3(JsTypeConstructor jsCodeSource, JsQuadraticBezierCurve3 jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _v0 = $"{variableName}.v0".AsJsVector3Variable();
        _v1 = $"{variableName}.v1".AsJsVector3Variable();
        _v2 = $"{variableName}.v2".AsJsVector3Variable();
    }

    public JsQuadraticBezierCurve3(JsVector3 argV0 = null, JsVector3 argV1 = null, JsVector3 argV2 = null)
        : base(new JsQuadraticBezierCurve3Constructor(argV0, argV1, argV2))
    {
    }

    public JsType GetPoint(JsType argT = null, JsVector3 argOptionalTarget = null)
    {
        return CallMethod("getPoint", argT ?? new JsObject(), argOptionalTarget ?? new JsVector3());
    }
        
    public JsQuadraticBezierCurve3 Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
    public JsQuadraticBezierCurve3 FromJSON(JsType argJson = null)
    {
        CallMethodVoid("fromJSON", argJson ?? new JsObject());
            
        return this;
    }
        
        
}