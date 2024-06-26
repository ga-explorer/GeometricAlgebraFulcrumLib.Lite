using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsStereoCameraConstructor :
    JsTypeConstructor
{
        


    internal JsStereoCameraConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.StereoCamera()";
    }
}
    
public partial class JsStereoCamera :
    JsObjectType
{
    public static implicit operator JsStereoCamera(string jsTextCode)
    {
        return new JsStereoCamera(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsStereoCamera value)
    {
        return value.GetJsCode();
    }


    private readonly JsStereoCamera _jsVariableValue;
    public JsStereoCamera JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"StereoCamera\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsNumber _aspect;
    public JsNumber Aspect
    {
        get => _aspect ?? throw new InvalidOperationException();
        set
        {
            if (_aspect is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.aspect = {valueCode};");
        }
    }
        
    private readonly JsNumber _eyeSep;
    public JsNumber EyeSep
    {
        get => _eyeSep ?? throw new InvalidOperationException();
        set
        {
            if (_eyeSep is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0.064";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.eyeSep = {valueCode};");
        }
    }
        
    private readonly JsType _cameraL;
    public JsType CameraL
    {
        get => _cameraL ?? throw new InvalidOperationException();
        set
        {
            if (_cameraL is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.cameraL = {valueCode};");
        }
    }
        
    private readonly JsType _cameraR;
    public JsType CameraR
    {
        get => _cameraR ?? throw new InvalidOperationException();
        set
        {
            if (_cameraR is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.cameraR = {valueCode};");
        }
    }

    internal JsStereoCamera(JsTypeConstructor jsCodeSource, JsStereoCamera jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _aspect = $"{variableName}.aspect".AsJsNumberVariable();
        _eyeSep = $"{variableName}.eyeSep".AsJsNumberVariable();
        _cameraL = $"{variableName}.cameraL".AsJsTypeVariable();
        _cameraR = $"{variableName}.cameraR".AsJsTypeVariable();
    }

    public JsStereoCamera()
        : base(new JsStereoCameraConstructor())
    {
    }

    public JsType Update(JsType argCamera = null)
    {
        return CallMethod("update", argCamera ?? new JsObject());
    }
        
        
}