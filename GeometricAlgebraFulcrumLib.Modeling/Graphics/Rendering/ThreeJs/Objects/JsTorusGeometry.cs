using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsTorusGeometryConstructor :
    JsTypeConstructor
{
    public JsNumber Radius { get; }
        
    public JsNumber Tube { get; }
        
    public JsNumber RadialSegments { get; }
        
    public JsNumber TubularSegments { get; }
        
    public JsType Arc { get; }
        
        


    internal JsTorusGeometryConstructor(JsNumber argRadius, JsNumber argTube, JsNumber argRadialSegments, JsNumber argTubularSegments, JsType argArc)
    {
        Radius = argRadius ?? (1).AsJsNumber();
        Tube = argTube ?? (0.4).AsJsNumber();
        RadialSegments = argRadialSegments ?? (8).AsJsNumber();
        TubularSegments = argTubularSegments ?? (6).AsJsNumber();
        Arc = argArc ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.TorusGeometry({Radius.GetJsCode()}, {Tube.GetJsCode()}, {RadialSegments.GetJsCode()}, {TubularSegments.GetJsCode()}, {Arc.GetJsCode()})";
    }
}
    
public partial class JsTorusGeometry :
    JsBufferGeometry
{
    public static implicit operator JsTorusGeometry(string jsTextCode)
    {
        return new JsTorusGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsTorusGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsTorusGeometry _jsVariableValue;
    public JsTorusGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"TorusGeometry\"";
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

    internal JsTorusGeometry(JsTypeConstructor jsCodeSource, JsTorusGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsTorusGeometry(JsNumber argRadius = null, JsNumber argTube = null, JsNumber argRadialSegments = null, JsNumber argTubularSegments = null, JsType argArc = null)
        : base(new JsTorusGeometryConstructor(argRadius, argTube, argRadialSegments, argTubularSegments, argArc))
    {
    }

        
}