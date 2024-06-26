using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsWebGLCubeRenderTargetConstructor :
    JsTypeConstructor
{
    public JsType Size { get; }
        
    public JsType Options { get; }
        
    public JsType Dummy { get; }
        
        


    internal JsWebGLCubeRenderTargetConstructor(JsType argSize, JsType argOptions, JsType argDummy)
    {
        Size = argSize ?? new JsObject();
        Options = argOptions ?? new JsObject();
        Dummy = argDummy ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.WebGLCubeRenderTarget({Size.GetJsCode()}, {Options.GetJsCode()}, {Dummy.GetJsCode()})";
    }
}
    
public partial class JsWebGLCubeRenderTarget :
    JsWebGLRenderTarget
{
    public static implicit operator JsWebGLCubeRenderTarget(string jsTextCode)
    {
        return new JsWebGLCubeRenderTarget(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsWebGLCubeRenderTarget value)
    {
        return value.GetJsCode();
    }


    private readonly JsWebGLCubeRenderTarget _jsVariableValue;
    public JsWebGLCubeRenderTarget JsValue 
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

    internal JsWebGLCubeRenderTarget(JsTypeConstructor jsCodeSource, JsWebGLCubeRenderTarget jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _texture = $"{variableName}.texture".AsJsTypeVariable();
    }

    public JsWebGLCubeRenderTarget(JsType argSize = null, JsType argOptions = null, JsType argDummy = null)
        : base(new JsWebGLCubeRenderTargetConstructor(argSize, argOptions, argDummy))
    {
    }

    public JsWebGLCubeRenderTarget FromEquirectangularTexture(JsType argRenderer = null, JsType argTexture = null)
    {
        CallMethodVoid("fromEquirectangularTexture", argRenderer ?? new JsObject(), argTexture ?? new JsObject());
            
        return this;
    }
        
    public JsType Clear(JsType argRenderer = null, JsType argColor = null, JsType argDepth = null, JsType argStencil = null)
    {
        return CallMethod("clear", argRenderer ?? new JsObject(), argColor ?? new JsObject(), argDepth ?? new JsObject(), argStencil ?? new JsObject());
    }
        
        
}