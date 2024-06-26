using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsLoaderConstructor :
    JsTypeConstructor
{
    public JsType Manager { get; }
        
        


    internal JsLoaderConstructor(JsType argManager)
    {
        Manager = argManager ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Loader({Manager.GetJsCode()})";
    }
}
    
public partial class JsLoader :
    JsObjectType
{
    public static implicit operator JsLoader(string jsTextCode)
    {
        return new JsLoader(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsLoader value)
    {
        return value.GetJsCode();
    }


    private readonly JsLoader _jsVariableValue;
    public JsLoader JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _manager;
    public JsType Manager
    {
        get => _manager ?? throw new InvalidOperationException();
        set
        {
            if (_manager is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.manager = {valueCode};");
        }
    }
        
    private readonly JsString _crossOrigin;
    public JsString CrossOrigin
    {
        get => _crossOrigin ?? throw new InvalidOperationException();
        set
        {
            if (_crossOrigin is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"anonymous\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.crossOrigin = {valueCode};");
        }
    }
        
    private readonly JsBoolean _withCredentials;
    public JsBoolean WithCredentials
    {
        get => _withCredentials ?? throw new InvalidOperationException();
        set
        {
            if (_withCredentials is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.withCredentials = {valueCode};");
        }
    }
        
    private readonly JsString _path;
    public JsString Path
    {
        get => _path ?? throw new InvalidOperationException();
        set
        {
            if (_path is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.path = {valueCode};");
        }
    }
        
    private readonly JsString _resourcePath;
    public JsString ResourcePath
    {
        get => _resourcePath ?? throw new InvalidOperationException();
        set
        {
            if (_resourcePath is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.resourcePath = {valueCode};");
        }
    }
        
    private readonly JsType _requestHeader;
    public JsType RequestHeader
    {
        get => _requestHeader ?? throw new InvalidOperationException();
        set
        {
            if (_requestHeader is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.requestHeader = {valueCode};");
        }
    }

    internal JsLoader(JsTypeConstructor jsCodeSource, JsLoader jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _manager = $"{variableName}.manager".AsJsTypeVariable();
        _crossOrigin = $"{variableName}.crossOrigin".AsJsStringVariable();
        _withCredentials = $"{variableName}.withCredentials".AsJsBooleanVariable();
        _path = $"{variableName}.path".AsJsStringVariable();
        _resourcePath = $"{variableName}.resourcePath".AsJsStringVariable();
        _requestHeader = $"{variableName}.requestHeader".AsJsTypeVariable();
    }

    public JsLoader(JsType argManager = null)
        : base(new JsLoaderConstructor(argManager))
    {
    }

    public JsType Load()
    {
        return CallMethod("load");
    }
        
    public JsType LoadAsync(JsType argUrl = null, JsType argOnProgress = null)
    {
        return CallMethod("loadAsync", argUrl ?? new JsObject(), argOnProgress ?? new JsObject());
    }
        
    public JsType Parse()
    {
        return CallMethod("parse");
    }
        
    public JsLoader SetCrossOrigin(JsType argCrossOrigin = null)
    {
        CallMethodVoid("setCrossOrigin", argCrossOrigin ?? new JsObject());
            
        return this;
    }
        
    public JsLoader SetWithCredentials(JsType argValue = null)
    {
        CallMethodVoid("setWithCredentials", argValue ?? new JsObject());
            
        return this;
    }
        
    public JsLoader SetPath(JsType argPath = null)
    {
        CallMethodVoid("setPath", argPath ?? new JsObject());
            
        return this;
    }
        
    public JsLoader SetResourcePath(JsType argResourcePath = null)
    {
        CallMethodVoid("setResourcePath", argResourcePath ?? new JsObject());
            
        return this;
    }
        
    public JsLoader SetRequestHeader(JsType argRequestHeader = null)
    {
        CallMethodVoid("setRequestHeader", argRequestHeader ?? new JsObject());
            
        return this;
    }
        
        
}