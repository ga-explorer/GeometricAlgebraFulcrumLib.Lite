using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsDataTexture2DArrayConstructor :
    JsTypeConstructor
{
    public JsObject Data { get; }
        
    public JsNumber Width { get; }
        
    public JsNumber Height { get; }
        
    public JsNumber Depth { get; }
        
        


    internal JsDataTexture2DArrayConstructor(JsObject argData, JsNumber argWidth, JsNumber argHeight, JsNumber argDepth)
    {
        Data = argData ?? new JsObject();
        Width = argWidth ?? (1).AsJsNumber();
        Height = argHeight ?? (1).AsJsNumber();
        Depth = argDepth ?? (1).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.DataTexture2DArray({Data.GetJsCode()}, {Width.GetJsCode()}, {Height.GetJsCode()}, {Depth.GetJsCode()})";
    }
}
    
public partial class JsDataTexture2DArray :
    JsTexture
{
    public static implicit operator JsDataTexture2DArray(string jsTextCode)
    {
        return new JsDataTexture2DArray(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsDataTexture2DArray value)
    {
        return value.GetJsCode();
    }


    private readonly JsDataTexture2DArray _jsVariableValue;
    public JsDataTexture2DArray JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "1003";
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
        
            var valueCode = value?.GetJsCode() ?? "1003";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.minFilter = {valueCode};");
        }
    }
        
    private readonly JsNumber _wrapR;
    public JsNumber WrapR
    {
        get => _wrapR ?? throw new InvalidOperationException();
        set
        {
            if (_wrapR is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1001";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.wrapR = {valueCode};");
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

    internal JsDataTexture2DArray(JsTypeConstructor jsCodeSource, JsDataTexture2DArray jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _image = $"{variableName}.image".AsJsTypeVariable();
        _magFilter = $"{variableName}.magFilter".AsJsNumberVariable();
        _minFilter = $"{variableName}.minFilter".AsJsNumberVariable();
        _wrapR = $"{variableName}.wrapR".AsJsNumberVariable();
        _generateMipmaps = $"{variableName}.generateMipmaps".AsJsBooleanVariable();
        _flipY = $"{variableName}.flipY".AsJsBooleanVariable();
        _unpackAlignment = $"{variableName}.unpackAlignment".AsJsNumberVariable();
        _needsUpdate = $"{variableName}.needsUpdate".AsJsBooleanVariable();
    }

    public JsDataTexture2DArray(JsObject argData = null, JsNumber argWidth = null, JsNumber argHeight = null, JsNumber argDepth = null)
        : base(new JsDataTexture2DArrayConstructor(argData, argWidth, argHeight, argDepth))
    {
    }

        
}