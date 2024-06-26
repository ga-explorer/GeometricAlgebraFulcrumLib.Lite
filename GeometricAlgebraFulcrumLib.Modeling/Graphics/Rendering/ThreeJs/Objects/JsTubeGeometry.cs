using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsTubeGeometryConstructor :
    JsTypeConstructor
{
    public JsQuadraticBezierCurve3 Path { get; }
        
    public JsNumber TubularSegments { get; }
        
    public JsNumber Radius { get; }
        
    public JsNumber RadialSegments { get; }
        
    public JsBoolean Closed { get; }
        
        


    internal JsTubeGeometryConstructor(JsQuadraticBezierCurve3 argPath, JsNumber argTubularSegments, JsNumber argRadius, JsNumber argRadialSegments, JsBoolean argClosed)
    {
        Path = argPath ?? new JsQuadraticBezierCurve3(new JsVector3((-1).AsJsNumber(), (-1).AsJsNumber(), (0).AsJsNumber()), new JsVector3((-1).AsJsNumber(), (1).AsJsNumber(), (0).AsJsNumber()), new JsVector3((1).AsJsNumber(), (1).AsJsNumber(), (0).AsJsNumber()));
        TubularSegments = argTubularSegments ?? (64).AsJsNumber();
        Radius = argRadius ?? (1).AsJsNumber();
        RadialSegments = argRadialSegments ?? (8).AsJsNumber();
        Closed = argClosed ?? (false).AsJsBoolean();
    }

    public override string GetJsCode()
    {
        return $"new THREE.TubeGeometry({Path.GetJsCode()}, {TubularSegments.GetJsCode()}, {Radius.GetJsCode()}, {RadialSegments.GetJsCode()}, {Closed.GetJsCode()})";
    }
}
    
public partial class JsTubeGeometry :
    JsBufferGeometry
{
    public static implicit operator JsTubeGeometry(string jsTextCode)
    {
        return new JsTubeGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsTubeGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsTubeGeometry _jsVariableValue;
    public JsTubeGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"TubeGeometry\"";
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
        
    private readonly JsType _tangents;
    public JsType Tangents
    {
        get => _tangents ?? throw new InvalidOperationException();
        set
        {
            if (_tangents is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.tangents = {valueCode};");
        }
    }
        
    private readonly JsType _normals;
    public JsType Normals
    {
        get => _normals ?? throw new InvalidOperationException();
        set
        {
            if (_normals is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.normals = {valueCode};");
        }
    }
        
    private readonly JsType _binormals;
    public JsType Binormals
    {
        get => _binormals ?? throw new InvalidOperationException();
        set
        {
            if (_binormals is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.binormals = {valueCode};");
        }
    }

    internal JsTubeGeometry(JsTypeConstructor jsCodeSource, JsTubeGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
        _tangents = $"{variableName}.tangents".AsJsTypeVariable();
        _normals = $"{variableName}.normals".AsJsTypeVariable();
        _binormals = $"{variableName}.binormals".AsJsTypeVariable();
    }

    public JsTubeGeometry(JsQuadraticBezierCurve3 argPath = null, JsNumber argTubularSegments = null, JsNumber argRadius = null, JsNumber argRadialSegments = null, JsBoolean argClosed = null)
        : base(new JsTubeGeometryConstructor(argPath, argTubularSegments, argRadius, argRadialSegments, argClosed))
    {
    }

    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
        
}