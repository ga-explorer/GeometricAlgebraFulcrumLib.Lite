using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsWebGLRenderTargetConstructor :
    JsTypeConstructor
{
    public JsType Width { get; }
        
    public JsType Height { get; }
        
    public JsObject Options { get; }
        
        


    internal JsWebGLRenderTargetConstructor(JsType argWidth, JsType argHeight, JsObject argOptions)
    {
        Width = argWidth ?? new JsObject();
        Height = argHeight ?? new JsObject();
        Options = argOptions ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.WebGLRenderTarget({Width.GetJsCode()}, {Height.GetJsCode()}, {Options.GetJsCode()})";
    }
}
    
public partial class JsWebGLRenderTarget :
    JsEventDispatcher
{
    public static implicit operator JsWebGLRenderTarget(string jsTextCode)
    {
        return new JsWebGLRenderTarget(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsWebGLRenderTarget value)
    {
        return value.GetJsCode();
    }


    private readonly JsWebGLRenderTarget _jsVariableValue;
    public JsWebGLRenderTarget JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

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
        
    private readonly JsType _scissor;
    public JsType Scissor
    {
        get => _scissor ?? throw new InvalidOperationException();
        set
        {
            if (_scissor is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.scissor = {valueCode};");
        }
    }
        
    private readonly JsBoolean _scissorTest;
    public JsBoolean ScissorTest
    {
        get => _scissorTest ?? throw new InvalidOperationException();
        set
        {
            if (_scissorTest is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.scissorTest = {valueCode};");
        }
    }
        
    private readonly JsType _viewport;
    public JsType Viewport
    {
        get => _viewport ?? throw new InvalidOperationException();
        set
        {
            if (_viewport is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.viewport = {valueCode};");
        }
    }
        
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

    internal JsWebGLRenderTarget(JsTypeConstructor jsCodeSource, JsWebGLRenderTarget jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _width = $"{variableName}.width".AsJsTypeVariable();
        _height = $"{variableName}.height".AsJsTypeVariable();
        _depth = $"{variableName}.depth".AsJsNumberVariable();
        _scissor = $"{variableName}.scissor".AsJsTypeVariable();
        _scissorTest = $"{variableName}.scissorTest".AsJsBooleanVariable();
        _viewport = $"{variableName}.viewport".AsJsTypeVariable();
        _texture = $"{variableName}.texture".AsJsTypeVariable();
        _depthBuffer = $"{variableName}.depthBuffer".AsJsTypeVariable();
        _stencilBuffer = $"{variableName}.stencilBuffer".AsJsTypeVariable();
        _depthTexture = $"{variableName}.depthTexture".AsJsTypeVariable();
    }

    public JsWebGLRenderTarget(JsType argWidth = null, JsType argHeight = null, JsObject argOptions = null)
        : base(new JsWebGLRenderTargetConstructor(argWidth, argHeight, argOptions))
    {
    }

    public JsType SetTexture(JsType argTexture = null)
    {
        return CallMethod("setTexture", argTexture ?? new JsObject());
    }
        
    public JsType SetSize(JsType argWidth = null, JsType argHeight = null, JsNumber argDepth = null)
    {
        return CallMethod("setSize", argWidth ?? new JsObject(), argHeight ?? new JsObject(), argDepth ?? (1).AsJsNumber());
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsWebGLRenderTarget Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType Dispose()
    {
        return CallMethod("dispose");
    }
        
        
}