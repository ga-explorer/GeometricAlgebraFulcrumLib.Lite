using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsWebGLMultisampleRenderTargetConstructor :
    JsTypeConstructor
{
    public JsType Width { get; }
        
    public JsType Height { get; }
        
    public JsType Options { get; }
        
        


    internal JsWebGLMultisampleRenderTargetConstructor(JsType argWidth, JsType argHeight, JsType argOptions)
    {
        Width = argWidth ?? new JsObject();
        Height = argHeight ?? new JsObject();
        Options = argOptions ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.WebGLMultisampleRenderTarget({Width.GetJsCode()}, {Height.GetJsCode()}, {Options.GetJsCode()})";
    }
}
    
public partial class JsWebGLMultisampleRenderTarget :
    JsWebGLRenderTarget
{
    public static implicit operator JsWebGLMultisampleRenderTarget(string jsTextCode)
    {
        return new JsWebGLMultisampleRenderTarget(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsWebGLMultisampleRenderTarget value)
    {
        return value.GetJsCode();
    }


    private readonly JsWebGLMultisampleRenderTarget _jsVariableValue;
    public JsWebGLMultisampleRenderTarget JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsNumber _samples;
    public JsNumber Samples
    {
        get => _samples ?? throw new InvalidOperationException();
        set
        {
            if (_samples is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "4";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.samples = {valueCode};");
        }
    }

    internal JsWebGLMultisampleRenderTarget(JsTypeConstructor jsCodeSource, JsWebGLMultisampleRenderTarget jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _samples = $"{variableName}.samples".AsJsNumberVariable();
    }

    public JsWebGLMultisampleRenderTarget(JsType argWidth = null, JsType argHeight = null, JsType argOptions = null)
        : base(new JsWebGLMultisampleRenderTargetConstructor(argWidth, argHeight, argOptions))
    {
    }

    public JsWebGLMultisampleRenderTarget Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}