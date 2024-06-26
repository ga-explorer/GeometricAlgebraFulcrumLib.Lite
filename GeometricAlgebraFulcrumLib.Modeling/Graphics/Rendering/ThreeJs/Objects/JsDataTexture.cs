using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsDataTextureConstructor :
    JsTypeConstructor
{
    public JsObject Data { get; }
        
    public JsNumber Width { get; }
        
    public JsNumber Height { get; }
        
    public JsType Format { get; }
        
    public JsType Type { get; }
        
    public JsType Mapping { get; }
        
    public JsType WrapS { get; }
        
    public JsType WrapT { get; }
        
    public JsNumber MagFilter { get; }
        
    public JsNumber MinFilter { get; }
        
    public JsType Anisotropy { get; }
        
    public JsType Encoding { get; }
        
        


    internal JsDataTextureConstructor(JsObject argData, JsNumber argWidth, JsNumber argHeight, JsType argFormat, JsType argType, JsType argMapping, JsType argWrapS, JsType argWrapT, JsNumber argMagFilter, JsNumber argMinFilter, JsType argAnisotropy, JsType argEncoding)
    {
        Data = argData ?? new JsObject();
        Width = argWidth ?? (1).AsJsNumber();
        Height = argHeight ?? (1).AsJsNumber();
        Format = argFormat ?? new JsObject();
        Type = argType ?? new JsObject();
        Mapping = argMapping ?? new JsObject();
        WrapS = argWrapS ?? new JsObject();
        WrapT = argWrapT ?? new JsObject();
        MagFilter = argMagFilter ?? ThreeJsConstants.NearestFilter;
        MinFilter = argMinFilter ?? ThreeJsConstants.NearestFilter;
        Anisotropy = argAnisotropy ?? new JsObject();
        Encoding = argEncoding ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.DataTexture({Data.GetJsCode()}, {Width.GetJsCode()}, {Height.GetJsCode()}, {Format.GetJsCode()}, {Type.GetJsCode()}, {Mapping.GetJsCode()}, {WrapS.GetJsCode()}, {WrapT.GetJsCode()}, {MagFilter.GetJsCode()}, {MinFilter.GetJsCode()}, {Anisotropy.GetJsCode()}, {Encoding.GetJsCode()})";
    }
}
    
public partial class JsDataTexture :
    JsTexture
{
    public static implicit operator JsDataTexture(string jsTextCode)
    {
        return new JsDataTexture(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsDataTexture value)
    {
        return value.GetJsCode();
    }


    private readonly JsDataTexture _jsVariableValue;
    public JsDataTexture JsValue 
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
        
    private readonly JsNumber _magFilter;
    public JsNumber MagFilter
    {
        get => _magFilter ?? throw new InvalidOperationException();
        set
        {
            if (_magFilter is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? ThreeJsConstants.NearestFilter;
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
        
            var valueCode = value?.GetJsCode() ?? ThreeJsConstants.NearestFilter;
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.minFilter = {valueCode};");
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
        
    private readonly JsNumber _unpackAlignment;
    public JsNumber UnpackAlignment
    {
        get => _unpackAlignment ?? throw new InvalidOperationException();
        set
        {
            if (_unpackAlignment is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.unpackAlignment = {valueCode};");
        }
    }
        
    private readonly JsBoolean _needsUpdate;
    public JsBoolean NeedsUpdate
    {
        get => _needsUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_needsUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.needsUpdate = {valueCode};");
        }
    }

    internal JsDataTexture(JsTypeConstructor jsCodeSource, JsDataTexture jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _image = $"{variableName}.image".AsJsTypeVariable();
        _magFilter = $"{variableName}.magFilter".AsJsNumberVariable();
        _minFilter = $"{variableName}.minFilter".AsJsNumberVariable();
        _generateMipmaps = $"{variableName}.generateMipmaps".AsJsBooleanVariable();
        _flipY = $"{variableName}.flipY".AsJsBooleanVariable();
        _unpackAlignment = $"{variableName}.unpackAlignment".AsJsNumberVariable();
        _needsUpdate = $"{variableName}.needsUpdate".AsJsBooleanVariable();
    }

    public JsDataTexture(JsObject argData = null, JsNumber argWidth = null, JsNumber argHeight = null, JsType argFormat = null, JsType argType = null, JsType argMapping = null, JsType argWrapS = null, JsType argWrapT = null, JsNumber argMagFilter = null, JsNumber argMinFilter = null, JsType argAnisotropy = null, JsType argEncoding = null)
        : base(new JsDataTextureConstructor(argData, argWidth, argHeight, argFormat, argType, argMapping, argWrapS, argWrapT, argMagFilter, argMinFilter, argAnisotropy, argEncoding))
    {
    }

        
}