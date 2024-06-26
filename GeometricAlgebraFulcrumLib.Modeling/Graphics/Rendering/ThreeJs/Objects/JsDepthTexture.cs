using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsDepthTextureConstructor :
    JsTypeConstructor
{
    public JsType Width { get; }
        
    public JsType Height { get; }
        
    public JsType Type { get; }
        
    public JsType Mapping { get; }
        
    public JsType WrapS { get; }
        
    public JsType WrapT { get; }
        
    public JsType MagFilter { get; }
        
    public JsType MinFilter { get; }
        
    public JsType Anisotropy { get; }
        
    public JsType Format { get; }
        
        


    internal JsDepthTextureConstructor(JsType argWidth, JsType argHeight, JsType argType, JsType argMapping, JsType argWrapS, JsType argWrapT, JsType argMagFilter, JsType argMinFilter, JsType argAnisotropy, JsType argFormat)
    {
        Width = argWidth ?? new JsObject();
        Height = argHeight ?? new JsObject();
        Type = argType ?? new JsObject();
        Mapping = argMapping ?? new JsObject();
        WrapS = argWrapS ?? new JsObject();
        WrapT = argWrapT ?? new JsObject();
        MagFilter = argMagFilter ?? new JsObject();
        MinFilter = argMinFilter ?? new JsObject();
        Anisotropy = argAnisotropy ?? new JsObject();
        Format = argFormat ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.DepthTexture({Width.GetJsCode()}, {Height.GetJsCode()}, {Type.GetJsCode()}, {Mapping.GetJsCode()}, {WrapS.GetJsCode()}, {WrapT.GetJsCode()}, {MagFilter.GetJsCode()}, {MinFilter.GetJsCode()}, {Anisotropy.GetJsCode()}, {Format.GetJsCode()})";
    }
}
    
public partial class JsDepthTexture :
    JsTexture
{
    public static implicit operator JsDepthTexture(string jsTextCode)
    {
        return new JsDepthTexture(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsDepthTexture value)
    {
        return value.GetJsCode();
    }


    private readonly JsDepthTexture _jsVariableValue;
    public JsDepthTexture JsValue 
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
        
    private readonly JsType _magFilter;
    public JsType MagFilter
    {
        get => _magFilter ?? throw new InvalidOperationException();
        set
        {
            if (_magFilter is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.magFilter = {valueCode};");
        }
    }
        
    private readonly JsType _minFilter;
    public JsType MinFilter
    {
        get => _minFilter ?? throw new InvalidOperationException();
        set
        {
            if (_minFilter is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.minFilter = {valueCode};");
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

    internal JsDepthTexture(JsTypeConstructor jsCodeSource, JsDepthTexture jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _image = $"{variableName}.image".AsJsTypeVariable();
        _magFilter = $"{variableName}.magFilter".AsJsTypeVariable();
        _minFilter = $"{variableName}.minFilter".AsJsTypeVariable();
        _flipY = $"{variableName}.flipY".AsJsBooleanVariable();
        _generateMipmaps = $"{variableName}.generateMipmaps".AsJsBooleanVariable();
    }

    public JsDepthTexture(JsType argWidth = null, JsType argHeight = null, JsType argType = null, JsType argMapping = null, JsType argWrapS = null, JsType argWrapT = null, JsType argMagFilter = null, JsType argMinFilter = null, JsType argAnisotropy = null, JsType argFormat = null)
        : base(new JsDepthTextureConstructor(argWidth, argHeight, argType, argMapping, argWrapS, argWrapT, argMagFilter, argMinFilter, argAnisotropy, argFormat))
    {
    }

        
}