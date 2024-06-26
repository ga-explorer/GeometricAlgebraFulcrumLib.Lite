using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsCompressedTextureLoaderConstructor :
    JsTypeConstructor
{
    public JsType Manager { get; }
        
        


    internal JsCompressedTextureLoaderConstructor(JsType argManager)
    {
        Manager = argManager ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.CompressedTextureLoader({Manager.GetJsCode()})";
    }
}
    
public partial class JsCompressedTextureLoader :
    JsLoader
{
    public static implicit operator JsCompressedTextureLoader(string jsTextCode)
    {
        return new JsCompressedTextureLoader(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsCompressedTextureLoader value)
    {
        return value.GetJsCode();
    }


    private readonly JsCompressedTextureLoader _jsVariableValue;
    public JsCompressedTextureLoader JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsCompressedTextureLoader(JsTypeConstructor jsCodeSource, JsCompressedTextureLoader jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsCompressedTextureLoader(JsType argManager = null)
        : base(new JsCompressedTextureLoaderConstructor(argManager))
    {
    }

    public JsCompressedTexture Load(JsType argUrl = null, JsType argOnLoad = null, JsType argOnProgress = null, JsType argOnError = null)
    {
        return CallMethod("load", argUrl ?? new JsObject(), argOnLoad ?? new JsObject(), argOnProgress ?? new JsObject(), argOnError ?? new JsObject());
    }
        
        
}