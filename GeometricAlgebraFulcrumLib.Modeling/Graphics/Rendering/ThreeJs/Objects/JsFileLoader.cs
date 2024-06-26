using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsFileLoaderConstructor :
    JsTypeConstructor
{
    public JsType Manager { get; }
        
        


    internal JsFileLoaderConstructor(JsType argManager)
    {
        Manager = argManager ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.FileLoader({Manager.GetJsCode()})";
    }
}
    
public partial class JsFileLoader :
    JsLoader
{
    public static implicit operator JsFileLoader(string jsTextCode)
    {
        return new JsFileLoader(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsFileLoader value)
    {
        return value.GetJsCode();
    }


    private readonly JsFileLoader _jsVariableValue;
    public JsFileLoader JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _responseType;
    public JsType ResponseType
    {
        get => _responseType ?? throw new InvalidOperationException();
        set
        {
            if (_responseType is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.responseType = {valueCode};");
        }
    }
        
    private readonly JsType _mimeType;
    public JsType MimeType
    {
        get => _mimeType ?? throw new InvalidOperationException();
        set
        {
            if (_mimeType is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.mimeType = {valueCode};");
        }
    }

    internal JsFileLoader(JsTypeConstructor jsCodeSource, JsFileLoader jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _responseType = $"{variableName}.responseType".AsJsTypeVariable();
        _mimeType = $"{variableName}.mimeType".AsJsTypeVariable();
    }

    public JsFileLoader(JsType argManager = null)
        : base(new JsFileLoaderConstructor(argManager))
    {
    }

    public JsType Load(JsType argUrl = null, JsType argOnLoad = null, JsType argOnProgress = null, JsType argOnError = null)
    {
        return CallMethod("load", argUrl ?? new JsObject(), argOnLoad ?? new JsObject(), argOnProgress ?? new JsObject(), argOnError ?? new JsObject());
    }
        
    public JsFileLoader SetResponseType(JsType argValue = null)
    {
        CallMethodVoid("setResponseType", argValue ?? new JsObject());
            
        return this;
    }
        
    public JsFileLoader SetMimeType(JsType argValue = null)
    {
        CallMethodVoid("setMimeType", argValue ?? new JsObject());
            
        return this;
    }
        
        
}