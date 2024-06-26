using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsCompressedTextureConstructor :
    JsTypeConstructor
{
    public JsType Mipmaps { get; }
        
    public JsType Width { get; }
        
    public JsType Height { get; }
        
    public JsType Format { get; }
        
    public JsType Type { get; }
        
    public JsType Mapping { get; }
        
    public JsType WrapS { get; }
        
    public JsType WrapT { get; }
        
    public JsType MagFilter { get; }
        
    public JsType MinFilter { get; }
        
    public JsType Anisotropy { get; }
        
    public JsType Encoding { get; }
        
        


    internal JsCompressedTextureConstructor(JsType argMipmaps, JsType argWidth, JsType argHeight, JsType argFormat, JsType argType, JsType argMapping, JsType argWrapS, JsType argWrapT, JsType argMagFilter, JsType argMinFilter, JsType argAnisotropy, JsType argEncoding)
    {
        Mipmaps = argMipmaps ?? new JsObject();
        Width = argWidth ?? new JsObject();
        Height = argHeight ?? new JsObject();
        Format = argFormat ?? new JsObject();
        Type = argType ?? new JsObject();
        Mapping = argMapping ?? new JsObject();
        WrapS = argWrapS ?? new JsObject();
        WrapT = argWrapT ?? new JsObject();
        MagFilter = argMagFilter ?? new JsObject();
        MinFilter = argMinFilter ?? new JsObject();
        Anisotropy = argAnisotropy ?? new JsObject();
        Encoding = argEncoding ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.CompressedTexture({Mipmaps.GetJsCode()}, {Width.GetJsCode()}, {Height.GetJsCode()}, {Format.GetJsCode()}, {Type.GetJsCode()}, {Mapping.GetJsCode()}, {WrapS.GetJsCode()}, {WrapT.GetJsCode()}, {MagFilter.GetJsCode()}, {MinFilter.GetJsCode()}, {Anisotropy.GetJsCode()}, {Encoding.GetJsCode()})";
    }
}
    
public partial class JsCompressedTexture :
    JsTexture
{
    public static implicit operator JsCompressedTexture(string jsTextCode)
    {
        return new JsCompressedTexture(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsCompressedTexture value)
    {
        return value.GetJsCode();
    }


    private readonly JsCompressedTexture _jsVariableValue;
    public JsCompressedTexture JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _image;
    public JsType Image
    {
        get => _image ?? throw new InvalidOperationException();
        set
        {
            if (_image is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.image = {valueCode};");
        }
    }
        
    private readonly JsType _mipmaps;
    public JsType Mipmaps
    {
        get => _mipmaps ?? throw new InvalidOperationException();
        set
        {
            if (_mipmaps is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.mipmaps = {valueCode};");
        }
    }
        
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
        
    private readonly JsBoolean _generateMipmaps;
    public JsBoolean GenerateMipmaps
    {
        get => _generateMipmaps ?? throw new InvalidOperationException();
        set
        {
            if (_generateMipmaps is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.generateMipmaps = {valueCode};");
        }
    }

    internal JsCompressedTexture(JsTypeConstructor jsCodeSource, JsCompressedTexture jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _image = $"{variableName}.image".AsJsTypeVariable();
        _mipmaps = $"{variableName}.mipmaps".AsJsTypeVariable();
        _flipY = $"{variableName}.flipY".AsJsBooleanVariable();
        _generateMipmaps = $"{variableName}.generateMipmaps".AsJsBooleanVariable();
    }

    public JsCompressedTexture(JsType argMipmaps = null, JsType argWidth = null, JsType argHeight = null, JsType argFormat = null, JsType argType = null, JsType argMapping = null, JsType argWrapS = null, JsType argWrapT = null, JsType argMagFilter = null, JsType argMinFilter = null, JsType argAnisotropy = null, JsType argEncoding = null)
        : base(new JsCompressedTextureConstructor(argMipmaps, argWidth, argHeight, argFormat, argType, argMapping, argWrapS, argWrapT, argMagFilter, argMinFilter, argAnisotropy, argEncoding))
    {
    }

        
}