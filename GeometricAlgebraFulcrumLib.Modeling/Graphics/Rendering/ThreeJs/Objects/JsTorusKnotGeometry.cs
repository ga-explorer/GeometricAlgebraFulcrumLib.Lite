using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsTorusKnotGeometryConstructor :
    JsTypeConstructor
{
    public JsNumber Radius { get; }
        
    public JsNumber Tube { get; }
        
    public JsNumber TubularSegments { get; }
        
    public JsNumber RadialSegments { get; }
        
    public JsNumber P { get; }
        
    public JsNumber Q { get; }
        
        


    internal JsTorusKnotGeometryConstructor(JsNumber argRadius, JsNumber argTube, JsNumber argTubularSegments, JsNumber argRadialSegments, JsNumber argP, JsNumber argQ)
    {
        Radius = argRadius ?? (1).AsJsNumber();
        Tube = argTube ?? (0.4).AsJsNumber();
        TubularSegments = argTubularSegments ?? (64).AsJsNumber();
        RadialSegments = argRadialSegments ?? (8).AsJsNumber();
        P = argP ?? (2).AsJsNumber();
        Q = argQ ?? (3).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.TorusKnotGeometry({Radius.GetJsCode()}, {Tube.GetJsCode()}, {TubularSegments.GetJsCode()}, {RadialSegments.GetJsCode()}, {P.GetJsCode()}, {Q.GetJsCode()})";
    }
}
    
public partial class JsTorusKnotGeometry :
    JsBufferGeometry
{
    public static implicit operator JsTorusKnotGeometry(string jsTextCode)
    {
        return new JsTorusKnotGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsTorusKnotGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsTorusKnotGeometry _jsVariableValue;
    public JsTorusKnotGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"TorusKnotGeometry\"";
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

    internal JsTorusKnotGeometry(JsTypeConstructor jsCodeSource, JsTorusKnotGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsTorusKnotGeometry(JsNumber argRadius = null, JsNumber argTube = null, JsNumber argTubularSegments = null, JsNumber argRadialSegments = null, JsNumber argP = null, JsNumber argQ = null)
        : base(new JsTorusKnotGeometryConstructor(argRadius, argTube, argTubularSegments, argRadialSegments, argP, argQ))
    {
    }

        
}