using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsTextureConstructor :
    JsTypeConstructor
{
    public JsType Image { get; }
        
    public JsType Mapping { get; }
        
    public JsNumber WrapS { get; }
        
    public JsNumber WrapT { get; }
        
    public JsNumber MagFilter { get; }
        
    public JsNumber MinFilter { get; }
        
    public JsNumber Format { get; }
        
    public JsNumber Type { get; }
        
    public JsNumber Anisotropy { get; }
        
    public JsNumber Encoding { get; }
        
        


    internal JsTextureConstructor(JsType argImage, JsType argMapping, JsNumber argWrapS, JsNumber argWrapT, JsNumber argMagFilter, JsNumber argMinFilter, JsNumber argFormat, JsNumber argType, JsNumber argAnisotropy, JsNumber argEncoding)
    {
        Image = argImage ?? new JsObject();
        Mapping = argMapping ?? new JsObject();
        WrapS = argWrapS ?? ThreeJsConstants.ClampToEdgeWrapping;
        WrapT = argWrapT ?? ThreeJsConstants.ClampToEdgeWrapping;
        MagFilter = argMagFilter ?? ThreeJsConstants.LinearFilter;
        MinFilter = argMinFilter ?? ThreeJsConstants.LinearMipmapLinearFilter;
        Format = argFormat ?? ThreeJsConstants.RGBAFormat;
        Type = argType ?? ThreeJsConstants.UnsignedByteType;
        Anisotropy = argAnisotropy ?? (1).AsJsNumber();
        Encoding = argEncoding ?? ThreeJsConstants.LinearEncoding;
    }

    public override string GetJsCode()
    {
        return $"new THREE.Texture({Image.GetJsCode()}, {Mapping.GetJsCode()}, {WrapS.GetJsCode()}, {WrapT.GetJsCode()}, {MagFilter.GetJsCode()}, {MinFilter.GetJsCode()}, {Format.GetJsCode()}, {Type.GetJsCode()}, {Anisotropy.GetJsCode()}, {Encoding.GetJsCode()})";
    }
}
    
public partial class JsTexture :
    JsEventDispatcher
{
    public static implicit operator JsTexture(string jsTextCode)
    {
        return new JsTexture(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsTexture value)
    {
        return value.GetJsCode();
    }


    private readonly JsTexture _jsVariableValue;
    public JsTexture JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _uuid;
    public JsType Uuid
    {
        get => _uuid ?? throw new InvalidOperationException();
        set
        {
            if (_uuid is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.uuid = {valueCode};");
        }
    }
        
    private readonly JsString _name;
    public JsString Name
    {
        get => _name ?? throw new InvalidOperationException();
        set
        {
            if (_name is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.name = {valueCode};");
        }
    }
        
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
        
    private readonly JsType _mapping;
    public JsType Mapping
    {
        get => _mapping ?? throw new InvalidOperationException();
        set
        {
            if (_mapping is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.mapping = {valueCode};");
        }
    }
        
    private readonly JsNumber _wrapS;
    public JsNumber WrapS
    {
        get => _wrapS ?? throw new InvalidOperationException();
        set
        {
            if (_wrapS is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? ThreeJsConstants.ClampToEdgeWrapping;
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.wrapS = {valueCode};");
        }
    }
        
    private readonly JsNumber _wrapT;
    public JsNumber WrapT
    {
        get => _wrapT ?? throw new InvalidOperationException();
        set
        {
            if (_wrapT is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? ThreeJsConstants.ClampToEdgeWrapping;
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.wrapT = {valueCode};");
        }
    }
        
    private readonly JsNumber _magFilter;
    public JsNumber MagFilter
    {
        get => _magFilter ?? throw new InvalidOperationException();
        set
        {
            if (_magFilter is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? ThreeJsConstants.LinearFilter;
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.magFilter = {valueCode};");
        }
    }
        
    private readonly JsNumber _minFilter;
    public JsNumber MinFilter
    {
        get => _minFilter ?? throw new InvalidOperationException();
        set
        {
            if (_minFilter is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? ThreeJsConstants.LinearMipmapLinearFilter;
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.minFilter = {valueCode};");
        }
    }
        
    private readonly JsNumber _anisotropy;
    public JsNumber Anisotropy
    {
        get => _anisotropy ?? throw new InvalidOperationException();
        set
        {
            if (_anisotropy is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.anisotropy = {valueCode};");
        }
    }
        
    private readonly JsNumber _format;
    public JsNumber Format
    {
        get => _format ?? throw new InvalidOperationException();
        set
        {
            if (_format is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? ThreeJsConstants.RGBAFormat;
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.format = {valueCode};");
        }
    }
        
    private readonly JsType _internalFormat;
    public JsType InternalFormat
    {
        get => _internalFormat ?? throw new InvalidOperationException();
        set
        {
            if (_internalFormat is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.internalFormat = {valueCode};");
        }
    }
        
    private readonly JsNumber _type;
    public JsNumber Type
    {
        get => _type ?? throw new InvalidOperationException();
        set
        {
            if (_type is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? ThreeJsConstants.UnsignedByteType;
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _offset;
    public JsType Offset
    {
        get => _offset ?? throw new InvalidOperationException();
        set
        {
            if (_offset is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.offset = {valueCode};");
        }
    }
        
    private readonly JsType _repeat;
    public JsType Repeat
    {
        get => _repeat ?? throw new InvalidOperationException();
        set
        {
            if (_repeat is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.repeat = {valueCode};");
        }
    }
        
    private readonly JsType _center;
    public JsType Center
    {
        get => _center ?? throw new InvalidOperationException();
        set
        {
            if (_center is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.center = {valueCode};");
        }
    }
        
    private readonly JsNumber _rotation;
    public JsNumber Rotation
    {
        get => _rotation ?? throw new InvalidOperationException();
        set
        {
            if (_rotation is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.rotation = {valueCode};");
        }
    }
        
    private readonly JsBoolean _matrixAutoUpdate;
    public JsBoolean MatrixAutoUpdate
    {
        get => _matrixAutoUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_matrixAutoUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matrixAutoUpdate = {valueCode};");
        }
    }
        
    private readonly JsType _matrix;
    public JsType Matrix
    {
        get => _matrix ?? throw new InvalidOperationException();
        set
        {
            if (_matrix is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matrix = {valueCode};");
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
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.generateMipmaps = {valueCode};");
        }
    }
        
    private readonly JsBoolean _premultiplyAlpha;
    public JsBoolean PremultiplyAlpha
    {
        get => _premultiplyAlpha ?? throw new InvalidOperationException();
        set
        {
            if (_premultiplyAlpha is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.premultiplyAlpha = {valueCode};");
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
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.flipY = {valueCode};");
        }
    }
        
    private readonly JsNumber _unpackAlignment;
    public JsNumber UnpackAlignment
    {
        get => _unpackAlignment ?? throw new InvalidOperationException();
        set
        {
            if (_unpackAlignment is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "4";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.unpackAlignment = {valueCode};");
        }
    }
        
    private readonly JsNumber _encoding;
    public JsNumber Encoding
    {
        get => _encoding ?? throw new InvalidOperationException();
        set
        {
            if (_encoding is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? ThreeJsConstants.LinearEncoding;
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.encoding = {valueCode};");
        }
    }
        
    private readonly JsNumber _version;
    public JsNumber Version
    {
        get => _version ?? throw new InvalidOperationException();
        set
        {
            if (_version is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.version = {valueCode};");
        }
    }
        
    private readonly JsObject _onUpdate;
    public JsObject OnUpdate
    {
        get => _onUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_onUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.onUpdate = {valueCode};");
        }
    }
        
    private readonly JsBoolean _isRenderTargetTexture;
    public JsBoolean IsRenderTargetTexture
    {
        get => _isRenderTargetTexture ?? throw new InvalidOperationException();
        set
        {
            if (_isRenderTargetTexture is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.isRenderTargetTexture = {valueCode};");
        }
    }

    internal JsTexture(JsTypeConstructor jsCodeSource, JsTexture jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _uuid = $"{variableName}.uuid".AsJsTypeVariable();
        _name = $"{variableName}.name".AsJsStringVariable();
        _image = $"{variableName}.image".AsJsTypeVariable();
        _mipmaps = $"{variableName}.mipmaps".AsJsTypeVariable();
        _mapping = $"{variableName}.mapping".AsJsTypeVariable();
        _wrapS = $"{variableName}.wrapS".AsJsNumberVariable();
        _wrapT = $"{variableName}.wrapT".AsJsNumberVariable();
        _magFilter = $"{variableName}.magFilter".AsJsNumberVariable();
        _minFilter = $"{variableName}.minFilter".AsJsNumberVariable();
        _anisotropy = $"{variableName}.anisotropy".AsJsNumberVariable();
        _format = $"{variableName}.format".AsJsNumberVariable();
        _internalFormat = $"{variableName}.internalFormat".AsJsTypeVariable();
        _type = $"{variableName}.type".AsJsNumberVariable();
        _offset = $"{variableName}.offset".AsJsTypeVariable();
        _repeat = $"{variableName}.repeat".AsJsTypeVariable();
        _center = $"{variableName}.center".AsJsTypeVariable();
        _rotation = $"{variableName}.rotation".AsJsNumberVariable();
        _matrixAutoUpdate = $"{variableName}.matrixAutoUpdate".AsJsBooleanVariable();
        _matrix = $"{variableName}.matrix".AsJsTypeVariable();
        _generateMipmaps = $"{variableName}.generateMipmaps".AsJsBooleanVariable();
        _premultiplyAlpha = $"{variableName}.premultiplyAlpha".AsJsBooleanVariable();
        _flipY = $"{variableName}.flipY".AsJsBooleanVariable();
        _unpackAlignment = $"{variableName}.unpackAlignment".AsJsNumberVariable();
        _encoding = $"{variableName}.encoding".AsJsNumberVariable();
        _version = $"{variableName}.version".AsJsNumberVariable();
        _onUpdate = $"{variableName}.onUpdate".AsJsObjectVariable();
        _isRenderTargetTexture = $"{variableName}.isRenderTargetTexture".AsJsBooleanVariable();
    }

    public JsTexture(JsType argImage = null, JsType argMapping = null, JsNumber argWrapS = null, JsNumber argWrapT = null, JsNumber argMagFilter = null, JsNumber argMinFilter = null, JsNumber argFormat = null, JsNumber argType = null, JsNumber argAnisotropy = null, JsNumber argEncoding = null)
        : base(new JsTextureConstructor(argImage, argMapping, argWrapS, argWrapT, argMagFilter, argMinFilter, argFormat, argType, argAnisotropy, argEncoding))
    {
    }

    public JsType UpdateMatrix()
    {
        return CallMethod("updateMatrix");
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsTexture Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsObject ToJSON(JsType argMeta = null)
    {
        return CallMethod("toJSON", argMeta ?? new JsObject());
    }
        
    public JsType Dispose()
    {
        return CallMethod("dispose");
    }
        
    public JsType TransformUv(JsType argUv = null)
    {
        return CallMethod("transformUv", argUv ?? new JsObject());
    }
        
        
}