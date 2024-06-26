using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsCubeTextureConstructor :
    JsTypeConstructor
{
    public JsType Images { get; }
        
    public JsType Mapping { get; }
        
    public JsType WrapS { get; }
        
    public JsType WrapT { get; }
        
    public JsType MagFilter { get; }
        
    public JsType MinFilter { get; }
        
    public JsType Format { get; }
        
    public JsType Type { get; }
        
    public JsType Anisotropy { get; }
        
    public JsType Encoding { get; }
        
        


    internal JsCubeTextureConstructor(JsType argImages, JsType argMapping, JsType argWrapS, JsType argWrapT, JsType argMagFilter, JsType argMinFilter, JsType argFormat, JsType argType, JsType argAnisotropy, JsType argEncoding)
    {
        Images = argImages ?? new JsObject();
        Mapping = argMapping ?? new JsObject();
        WrapS = argWrapS ?? new JsObject();
        WrapT = argWrapT ?? new JsObject();
        MagFilter = argMagFilter ?? new JsObject();
        MinFilter = argMinFilter ?? new JsObject();
        Format = argFormat ?? new JsObject();
        Type = argType ?? new JsObject();
        Anisotropy = argAnisotropy ?? new JsObject();
        Encoding = argEncoding ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.CubeTexture({Images.GetJsCode()}, {Mapping.GetJsCode()}, {WrapS.GetJsCode()}, {WrapT.GetJsCode()}, {MagFilter.GetJsCode()}, {MinFilter.GetJsCode()}, {Format.GetJsCode()}, {Type.GetJsCode()}, {Anisotropy.GetJsCode()}, {Encoding.GetJsCode()})";
    }
}
    
public partial class JsCubeTexture :
    JsTexture
{
    public static implicit operator JsCubeTexture(string jsTextCode)
    {
        return new JsCubeTexture(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsCubeTexture value)
    {
        return value.GetJsCode();
    }


    private readonly JsCubeTexture _jsVariableValue;
    public JsCubeTexture JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsBoolean _flipY;
    public JsBoolean FlipY
    {
        get => _flipY ?? throw new InvalidOperationException();
        set
        {
            if (_flipY is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.flipY = {valueCode};");
        }
    }
        
    private readonly JsType _images;
    public JsType Images
    {
        get => _images ?? throw new InvalidOperationException();
        set
        {
            if (_images is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.images = {valueCode};");
        }
    }

    internal JsCubeTexture(JsTypeConstructor jsCodeSource, JsCubeTexture jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _flipY = $"{variableName}.flipY".AsJsBooleanVariable();
        _images = $"{variableName}.images".AsJsTypeVariable();
    }

    public JsCubeTexture(JsType argImages = null, JsType argMapping = null, JsType argWrapS = null, JsType argWrapT = null, JsType argMagFilter = null, JsType argMinFilter = null, JsType argFormat = null, JsType argType = null, JsType argAnisotropy = null, JsType argEncoding = null)
        : base(new JsCubeTextureConstructor(argImages, argMapping, argWrapS, argWrapT, argMagFilter, argMinFilter, argFormat, argType, argAnisotropy, argEncoding))
    {
    }

        
}