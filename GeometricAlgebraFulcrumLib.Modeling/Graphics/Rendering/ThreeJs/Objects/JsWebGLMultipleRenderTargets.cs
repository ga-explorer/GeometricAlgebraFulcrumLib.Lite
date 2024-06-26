using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsWebGLMultipleRenderTargetsConstructor :
    JsTypeConstructor
{
    public JsType Width { get; }
        
    public JsType Height { get; }
        
    public JsType Count { get; }
        
        


    internal JsWebGLMultipleRenderTargetsConstructor(JsType argWidth, JsType argHeight, JsType argCount)
    {
        Width = argWidth ?? new JsObject();
        Height = argHeight ?? new JsObject();
        Count = argCount ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.WebGLMultipleRenderTargets({Width.GetJsCode()}, {Height.GetJsCode()}, {Count.GetJsCode()})";
    }
}
    
public partial class JsWebGLMultipleRenderTargets :
    JsWebGLRenderTarget
{
    public static implicit operator JsWebGLMultipleRenderTargets(string jsTextCode)
    {
        return new JsWebGLMultipleRenderTargets(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsWebGLMultipleRenderTargets value)
    {
        return value.GetJsCode();
    }


    private readonly JsWebGLMultipleRenderTargets _jsVariableValue;
    public JsWebGLMultipleRenderTargets JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _texture;
    public JsType Texture
    {
        get => _texture ?? throw new InvalidOperationException();
        set
        {
            if (_texture is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.texture = {valueCode};");
        }
    }
        
    private readonly JsType _width;
    public JsType Width
    {
        get => _width ?? throw new InvalidOperationException();
        set
        {
            if (_width is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.width = {valueCode};");
        }
    }
        
    private readonly JsType _height;
    public JsType Height
    {
        get => _height ?? throw new InvalidOperationException();
        set
        {
            if (_height is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.height = {valueCode};");
        }
    }
        
    private readonly JsNumber _depth;
    public JsNumber Depth
    {
        get => _depth ?? throw new InvalidOperationException();
        set
        {
            if (_depth is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.depth = {valueCode};");
        }
    }
        
    private readonly JsType _depthBuffer;
    public JsType DepthBuffer
    {
        get => _depthBuffer ?? throw new InvalidOperationException();
        set
        {
            if (_depthBuffer is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.depthBuffer = {valueCode};");
        }
    }
        
    private readonly JsType _stencilBuffer;
    public JsType StencilBuffer
    {
        get => _stencilBuffer ?? throw new InvalidOperationException();
        set
        {
            if (_stencilBuffer is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.stencilBuffer = {valueCode};");
        }
    }
        
    private readonly JsType _depthTexture;
    public JsType DepthTexture
    {
        get => _depthTexture ?? throw new InvalidOperationException();
        set
        {
            if (_depthTexture is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.depthTexture = {valueCode};");
        }
    }

    internal JsWebGLMultipleRenderTargets(JsTypeConstructor jsCodeSource, JsWebGLMultipleRenderTargets jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _texture = $"{variableName}.texture".AsJsTypeVariable();
        _width = $"{variableName}.width".AsJsTypeVariable();
        _height = $"{variableName}.height".AsJsTypeVariable();
        _depth = $"{variableName}.depth".AsJsNumberVariable();
        _depthBuffer = $"{variableName}.depthBuffer".AsJsTypeVariable();
        _stencilBuffer = $"{variableName}.stencilBuffer".AsJsTypeVariable();
        _depthTexture = $"{variableName}.depthTexture".AsJsTypeVariable();
    }

    public JsWebGLMultipleRenderTargets(JsType argWidth = null, JsType argHeight = null, JsType argCount = null)
        : base(new JsWebGLMultipleRenderTargetsConstructor(argWidth, argHeight, argCount))
    {
    }

    public JsWebGLMultipleRenderTargets SetSize(JsType argWidth = null, JsType argHeight = null, JsNumber argDepth = null)
    {
        CallMethodVoid("setSize", argWidth ?? new JsObject(), argHeight ?? new JsObject(), argDepth ?? (1).AsJsNumber());
            
        return this;
    }
        
    public JsWebGLMultipleRenderTargets Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}