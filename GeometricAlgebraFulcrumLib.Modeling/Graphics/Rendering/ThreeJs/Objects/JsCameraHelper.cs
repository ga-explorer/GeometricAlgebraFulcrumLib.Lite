using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsCameraHelperConstructor :
    JsTypeConstructor
{
    public JsType Camera { get; }
        
        


    internal JsCameraHelperConstructor(JsType argCamera)
    {
        Camera = argCamera ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.CameraHelper({Camera.GetJsCode()})";
    }
}
    
public partial class JsCameraHelper :
    JsLineSegments
{
    public static implicit operator JsCameraHelper(string jsTextCode)
    {
        return new JsCameraHelper(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsCameraHelper value)
    {
        return value.GetJsCode();
    }


    private readonly JsCameraHelper _jsVariableValue;
    public JsCameraHelper JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"CameraHelper\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _camera;
    public JsType Camera
    {
        get => _camera ?? throw new InvalidOperationException();
        set
        {
            if (_camera is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.camera = {valueCode};");
        }
    }
        
    private readonly JsType _matrix;
    public JsType Matrix
    {
        get => _matrix ?? throw new InvalidOperationException();
        set
        {
            if (_matrix is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matrix = {valueCode};");
        }
    }
        
    private readonly JsBoolean _matrixAutoUpdate;
    public JsBoolean MatrixAutoUpdate
    {
        get => _matrixAutoUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_matrixAutoUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matrixAutoUpdate = {valueCode};");
        }
    }
        
    private readonly JsObject _pointMap;
    public JsObject PointMap
    {
        get => _pointMap ?? throw new InvalidOperationException();
        set
        {
            if (_pointMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.pointMap = {valueCode};");
        }
    }

    internal JsCameraHelper(JsTypeConstructor jsCodeSource, JsCameraHelper jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _camera = $"{variableName}.camera".AsJsTypeVariable();
        _matrix = $"{variableName}.matrix".AsJsTypeVariable();
        _matrixAutoUpdate = $"{variableName}.matrixAutoUpdate".AsJsBooleanVariable();
        _pointMap = $"{variableName}.pointMap".AsJsObjectVariable();
    }

    public JsCameraHelper(JsType argCamera = null)
        : base(new JsCameraHelperConstructor(argCamera))
    {
    }

    public JsType Update()
    {
        return CallMethod("update");
    }
        
    public JsType Dispose()
    {
        return CallMethod("dispose");
    }
        
        
}