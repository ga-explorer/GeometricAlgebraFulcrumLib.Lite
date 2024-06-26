using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsRingGeometryConstructor :
    JsTypeConstructor
{
    public JsNumber InnerRadius { get; }
        
    public JsNumber OuterRadius { get; }
        
    public JsNumber ThetaSegments { get; }
        
    public JsNumber PhiSegments { get; }
        
    public JsNumber ThetaStart { get; }
        
    public JsType ThetaLength { get; }
        
        


    internal JsRingGeometryConstructor(JsNumber argInnerRadius, JsNumber argOuterRadius, JsNumber argThetaSegments, JsNumber argPhiSegments, JsNumber argThetaStart, JsType argThetaLength)
    {
        InnerRadius = argInnerRadius ?? (0.5).AsJsNumber();
        OuterRadius = argOuterRadius ?? (1).AsJsNumber();
        ThetaSegments = argThetaSegments ?? (8).AsJsNumber();
        PhiSegments = argPhiSegments ?? (1).AsJsNumber();
        ThetaStart = argThetaStart ?? (0).AsJsNumber();
        ThetaLength = argThetaLength ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.RingGeometry({InnerRadius.GetJsCode()}, {OuterRadius.GetJsCode()}, {ThetaSegments.GetJsCode()}, {PhiSegments.GetJsCode()}, {ThetaStart.GetJsCode()}, {ThetaLength.GetJsCode()})";
    }
}
    
public partial class JsRingGeometry :
    JsBufferGeometry
{
    public static implicit operator JsRingGeometry(string jsTextCode)
    {
        return new JsRingGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsRingGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsRingGeometry _jsVariableValue;
    public JsRingGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"RingGeometry\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _parameters;
    public JsType Parameters
    {
        get => _parameters ?? throw new InvalidOperationException();
        set
        {
            if (_parameters is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.parameters = {valueCode};");
        }
    }

    internal JsRingGeometry(JsTypeConstructor jsCodeSource, JsRingGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsRingGeometry(JsNumber argInnerRadius = null, JsNumber argOuterRadius = null, JsNumber argThetaSegments = null, JsNumber argPhiSegments = null, JsNumber argThetaStart = null, JsType argThetaLength = null)
        : base(new JsRingGeometryConstructor(argInnerRadius, argOuterRadius, argThetaSegments, argPhiSegments, argThetaStart, argThetaLength))
    {
    }

        
}