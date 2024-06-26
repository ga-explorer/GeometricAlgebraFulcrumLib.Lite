using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsVideoTextureConstructor :
    JsTypeConstructor
{
    public JsType Video { get; }
        
    public JsType Mapping { get; }
        
    public JsType WrapS { get; }
        
    public JsType WrapT { get; }
        
    public JsType MagFilter { get; }
        
    public JsType MinFilter { get; }
        
    public JsType Format { get; }
        
    public JsType Type { get; }
        
    public JsType Anisotropy { get; }
        
        


    internal JsVideoTextureConstructor(JsType argVideo, JsType argMapping, JsType argWrapS, JsType argWrapT, JsType argMagFilter, JsType argMinFilter, JsType argFormat, JsType argType, JsType argAnisotropy)
    {
        Video = argVideo ?? new JsObject();
        Mapping = argMapping ?? new JsObject();
        WrapS = argWrapS ?? new JsObject();
        WrapT = argWrapT ?? new JsObject();
        MagFilter = argMagFilter ?? new JsObject();
        MinFilter = argMinFilter ?? new JsObject();
        Format = argFormat ?? new JsObject();
        Type = argType ?? new JsObject();
        Anisotropy = argAnisotropy ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.VideoTexture({Video.GetJsCode()}, {Mapping.GetJsCode()}, {WrapS.GetJsCode()}, {WrapT.GetJsCode()}, {MagFilter.GetJsCode()}, {MinFilter.GetJsCode()}, {Format.GetJsCode()}, {Type.GetJsCode()}, {Anisotropy.GetJsCode()})";
    }
}
    
public partial class JsVideoTexture :
    JsTexture
{
    public static implicit operator JsVideoTexture(string jsTextCode)
    {
        return new JsVideoTexture(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsVideoTexture value)
    {
        return value.GetJsCode();
    }


    private readonly JsVideoTexture _jsVariableValue;
    public JsVideoTexture JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _format;
    public JsType Format
    {
        get => _format ?? throw new InvalidOperationException();
        set
        {
            if (_format is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.format = {valueCode};");
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

    internal JsVideoTexture(JsTypeConstructor jsCodeSource, JsVideoTexture jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _format = $"{variableName}.format".AsJsTypeVariable();
        _minFilter = $"{variableName}.minFilter".AsJsTypeVariable();
        _magFilter = $"{variableName}.magFilter".AsJsTypeVariable();
        _generateMipmaps = $"{variableName}.generateMipmaps".AsJsBooleanVariable();
        _needsUpdate = $"{variableName}.needsUpdate".AsJsBooleanVariable();
    }

    public JsVideoTexture(JsType argVideo = null, JsType argMapping = null, JsType argWrapS = null, JsType argWrapT = null, JsType argMagFilter = null, JsType argMinFilter = null, JsType argFormat = null, JsType argType = null, JsType argAnisotropy = null)
        : base(new JsVideoTextureConstructor(argVideo, argMapping, argWrapS, argWrapT, argMagFilter, argMinFilter, argFormat, argType, argAnisotropy))
    {
    }

    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsType Update()
    {
        return CallMethod("update");
    }
        
        
}