using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsPerspectiveCameraConstructor :
    JsTypeConstructor
{
    public JsNumber Fov { get; }
        
    public JsNumber Aspect { get; }
        
    public JsNumber Near { get; }
        
    public JsNumber Far { get; }
        
        


    internal JsPerspectiveCameraConstructor(JsNumber argFov, JsNumber argAspect, JsNumber argNear, JsNumber argFar)
    {
        Fov = argFov ?? (50).AsJsNumber();
        Aspect = argAspect ?? (1).AsJsNumber();
        Near = argNear ?? (0.1).AsJsNumber();
        Far = argFar ?? (2000).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.PerspectiveCamera({Fov.GetJsCode()}, {Aspect.GetJsCode()}, {Near.GetJsCode()}, {Far.GetJsCode()})";
    }
}
    
public partial class JsPerspectiveCamera :
    JsCamera
{
    public static implicit operator JsPerspectiveCamera(string jsTextCode)
    {
        return new JsPerspectiveCamera(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsPerspectiveCamera value)
    {
        return value.GetJsCode();
    }


    private readonly JsPerspectiveCamera _jsVariableValue;
    public JsPerspectiveCamera JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"PerspectiveCamera\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsNumber _fov;
    public JsNumber Fov
    {
        get => _fov ?? throw new InvalidOperationException();
        set
        {
            if (_fov is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "50";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.fov = {valueCode};");
        }
    }
        
    private readonly JsNumber _zoom;
    public JsNumber Zoom
    {
        get => _zoom ?? throw new InvalidOperationException();
        set
        {
            if (_zoom is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.zoom = {valueCode};");
        }
    }
        
    private readonly JsNumber _near;
    public JsNumber Near
    {
        get => _near ?? throw new InvalidOperationException();
        set
        {
            if (_near is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0.1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.near = {valueCode};");
        }
    }
        
    private readonly JsNumber _far;
    public JsNumber Far
    {
        get => _far ?? throw new InvalidOperationException();
        set
        {
            if (_far is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "2000";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.far = {valueCode};");
        }
    }
        
    private readonly JsNumber _focus;
    public JsNumber Focus
    {
        get => _focus ?? throw new InvalidOperationException();
        set
        {
            if (_focus is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "10";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.focus = {valueCode};");
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
        
    private readonly JsType _view;
    public JsType View
    {
        get => _view ?? throw new InvalidOperationException();
        set
        {
            if (_view is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.view = {valueCode};");
        }
    }
        
    private readonly JsNumber _filmGauge;
    public JsNumber FilmGauge
    {
        get => _filmGauge ?? throw new InvalidOperationException();
        set
        {
            if (_filmGauge is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "35";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.filmGauge = {valueCode};");
        }
    }
        
    private readonly JsNumber _filmOffset;
    public JsNumber FilmOffset
    {
        get => _filmOffset ?? throw new InvalidOperationException();
        set
        {
            if (_filmOffset is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.filmOffset = {valueCode};");
        }
    }

    internal JsPerspectiveCamera(JsTypeConstructor jsCodeSource, JsPerspectiveCamera jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _fov = $"{variableName}.fov".AsJsNumberVariable();
        _zoom = $"{variableName}.zoom".AsJsNumberVariable();
        _near = $"{variableName}.near".AsJsNumberVariable();
        _far = $"{variableName}.far".AsJsNumberVariable();
        _focus = $"{variableName}.focus".AsJsNumberVariable();
        _aspect = $"{variableName}.aspect".AsJsNumberVariable();
        _view = $"{variableName}.view".AsJsTypeVariable();
        _filmGauge = $"{variableName}.filmGauge".AsJsNumberVariable();
        _filmOffset = $"{variableName}.filmOffset".AsJsNumberVariable();
    }

    public JsPerspectiveCamera(JsNumber argFov = null, JsNumber argAspect = null, JsNumber argNear = null, JsNumber argFar = null)
        : base(new JsPerspectiveCameraConstructor(argFov, argAspect, argNear, argFar))
    {
    }

    public JsPerspectiveCamera Copy(JsType argSource = null, JsType argRecursive = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject(), argRecursive ?? new JsObject());
            
        return this;
    }
        
    public JsType SetFocalLength(JsType argFocalLength = null)
    {
        return CallMethod("setFocalLength", argFocalLength ?? new JsObject());
    }
        
    public JsType GetFocalLength()
    {
        return CallMethod("getFocalLength");
    }
        
    public JsType GetEffectiveFOV()
    {
        return CallMethod("getEffectiveFOV");
    }
        
    public JsType GetFilmWidth()
    {
        return CallMethod("getFilmWidth");
    }
        
    public JsType GetFilmHeight()
    {
        return CallMethod("getFilmHeight");
    }
        
    public JsType SetViewOffset(JsType argFullWidth = null, JsType argFullHeight = null, JsType argX = null, JsType argY = null, JsType argWidth = null, JsType argHeight = null)
    {
        return CallMethod("setViewOffset", argFullWidth ?? new JsObject(), argFullHeight ?? new JsObject(), argX ?? new JsObject(), argY ?? new JsObject(), argWidth ?? new JsObject(), argHeight ?? new JsObject());
    }
        
    public JsType ClearViewOffset()
    {
        return CallMethod("clearViewOffset");
    }
        
    public JsType UpdateProjectionMatrix()
    {
        return CallMethod("updateProjectionMatrix");
    }
        
    public JsType ToJSON(JsType argMeta = null)
    {
        return CallMethod("toJSON", argMeta ?? new JsObject());
    }
        
        
}