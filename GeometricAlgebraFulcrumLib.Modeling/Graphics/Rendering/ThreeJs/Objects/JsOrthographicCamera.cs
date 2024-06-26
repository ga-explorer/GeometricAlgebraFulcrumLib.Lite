using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsOrthographicCameraConstructor :
    JsTypeConstructor
{
    public JsNumber Left { get; }
        
    public JsNumber Right { get; }
        
    public JsNumber Top { get; }
        
    public JsNumber Bottom { get; }
        
    public JsNumber Near { get; }
        
    public JsNumber Far { get; }
        
        


    internal JsOrthographicCameraConstructor(JsNumber argLeft, JsNumber argRight, JsNumber argTop, JsNumber argBottom, JsNumber argNear, JsNumber argFar)
    {
        Left = argLeft ?? (-1).AsJsNumber();
        Right = argRight ?? (1).AsJsNumber();
        Top = argTop ?? (1).AsJsNumber();
        Bottom = argBottom ?? (-1).AsJsNumber();
        Near = argNear ?? (0.1).AsJsNumber();
        Far = argFar ?? (2000).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.OrthographicCamera({Left.GetJsCode()}, {Right.GetJsCode()}, {Top.GetJsCode()}, {Bottom.GetJsCode()}, {Near.GetJsCode()}, {Far.GetJsCode()})";
    }
}
    
public partial class JsOrthographicCamera :
    JsCamera
{
    public static implicit operator JsOrthographicCamera(string jsTextCode)
    {
        return new JsOrthographicCamera(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsOrthographicCamera value)
    {
        return value.GetJsCode();
    }


    private readonly JsOrthographicCamera _jsVariableValue;
    public JsOrthographicCamera JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"OrthographicCamera\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
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
        
    private readonly JsNumber _left;
    public JsNumber Left
    {
        get => _left ?? throw new InvalidOperationException();
        set
        {
            if (_left is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "-1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.left = {valueCode};");
        }
    }
        
    private readonly JsNumber _right;
    public JsNumber Right
    {
        get => _right ?? throw new InvalidOperationException();
        set
        {
            if (_right is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.right = {valueCode};");
        }
    }
        
    private readonly JsNumber _top;
    public JsNumber Top
    {
        get => _top ?? throw new InvalidOperationException();
        set
        {
            if (_top is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.top = {valueCode};");
        }
    }
        
    private readonly JsNumber _bottom;
    public JsNumber Bottom
    {
        get => _bottom ?? throw new InvalidOperationException();
        set
        {
            if (_bottom is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "-1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.bottom = {valueCode};");
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

    internal JsOrthographicCamera(JsTypeConstructor jsCodeSource, JsOrthographicCamera jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _zoom = $"{variableName}.zoom".AsJsNumberVariable();
        _view = $"{variableName}.view".AsJsTypeVariable();
        _left = $"{variableName}.left".AsJsNumberVariable();
        _right = $"{variableName}.right".AsJsNumberVariable();
        _top = $"{variableName}.top".AsJsNumberVariable();
        _bottom = $"{variableName}.bottom".AsJsNumberVariable();
        _near = $"{variableName}.near".AsJsNumberVariable();
        _far = $"{variableName}.far".AsJsNumberVariable();
    }

    public JsOrthographicCamera(JsNumber argLeft = null, JsNumber argRight = null, JsNumber argTop = null, JsNumber argBottom = null, JsNumber argNear = null, JsNumber argFar = null)
        : base(new JsOrthographicCameraConstructor(argLeft, argRight, argTop, argBottom, argNear, argFar))
    {
    }

    public JsOrthographicCamera Copy(JsType argSource = null, JsType argRecursive = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject(), argRecursive ?? new JsObject());
            
        return this;
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