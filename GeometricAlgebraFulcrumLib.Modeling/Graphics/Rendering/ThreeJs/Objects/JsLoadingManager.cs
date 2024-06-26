using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsLoadingManagerConstructor :
    JsTypeConstructor
{
    public JsType OnLoad { get; }
        
    public JsType OnProgress { get; }
        
    public JsType OnError { get; }
        
        


    internal JsLoadingManagerConstructor(JsType argOnLoad, JsType argOnProgress, JsType argOnError)
    {
        OnLoad = argOnLoad ?? new JsObject();
        OnProgress = argOnProgress ?? new JsObject();
        OnError = argOnError ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.LoadingManager({OnLoad.GetJsCode()}, {OnProgress.GetJsCode()}, {OnError.GetJsCode()})";
    }
}
    
public partial class JsLoadingManager :
    JsObjectType
{
    public static implicit operator JsLoadingManager(string jsTextCode)
    {
        return new JsLoadingManager(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsLoadingManager value)
    {
        return value.GetJsCode();
    }


    private readonly JsLoadingManager _jsVariableValue;
    public JsLoadingManager JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _onLoad;
    public JsType OnLoad
    {
        get => _onLoad ?? throw new InvalidOperationException();
        set
        {
            if (_onLoad is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.onLoad = {valueCode};");
        }
    }
        
    private readonly JsType _onProgress;
    public JsType OnProgress
    {
        get => _onProgress ?? throw new InvalidOperationException();
        set
        {
            if (_onProgress is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.onProgress = {valueCode};");
        }
    }
        
    private readonly JsType _onError;
    public JsType OnError
    {
        get => _onError ?? throw new InvalidOperationException();
        set
        {
            if (_onError is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.onError = {valueCode};");
        }
    }
        
    private readonly JsType _itemStart;
    public JsType ItemStart
    {
        get => _itemStart ?? throw new InvalidOperationException();
        set
        {
            if (_itemStart is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.itemStart = {valueCode};");
        }
    }
        
    private readonly JsType _itemEnd;
    public JsType ItemEnd
    {
        get => _itemEnd ?? throw new InvalidOperationException();
        set
        {
            if (_itemEnd is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.itemEnd = {valueCode};");
        }
    }
        
    private readonly JsType _itemError;
    public JsType ItemError
    {
        get => _itemError ?? throw new InvalidOperationException();
        set
        {
            if (_itemError is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.itemError = {valueCode};");
        }
    }
        
    private readonly JsType _resolveURL;
    public JsType ResolveURL
    {
        get => _resolveURL ?? throw new InvalidOperationException();
        set
        {
            if (_resolveURL is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.resolveURL = {valueCode};");
        }
    }
        
    private readonly JsType _setURLModifier;
    public JsType SetURLModifier
    {
        get => _setURLModifier ?? throw new InvalidOperationException();
        set
        {
            if (_setURLModifier is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.setURLModifier = {valueCode};");
        }
    }
        
    private readonly JsType _addHandler;
    public JsType AddHandler
    {
        get => _addHandler ?? throw new InvalidOperationException();
        set
        {
            if (_addHandler is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.addHandler = {valueCode};");
        }
    }
        
    private readonly JsType _removeHandler;
    public JsType RemoveHandler
    {
        get => _removeHandler ?? throw new InvalidOperationException();
        set
        {
            if (_removeHandler is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.removeHandler = {valueCode};");
        }
    }
        
    private readonly JsType _getHandler;
    public JsType GetHandler
    {
        get => _getHandler ?? throw new InvalidOperationException();
        set
        {
            if (_getHandler is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.getHandler = {valueCode};");
        }
    }

    internal JsLoadingManager(JsTypeConstructor jsCodeSource, JsLoadingManager jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _onLoad = $"{variableName}.onLoad".AsJsTypeVariable();
        _onProgress = $"{variableName}.onProgress".AsJsTypeVariable();
        _onError = $"{variableName}.onError".AsJsTypeVariable();
        _itemStart = $"{variableName}.itemStart".AsJsTypeVariable();
        _itemEnd = $"{variableName}.itemEnd".AsJsTypeVariable();
        _itemError = $"{variableName}.itemError".AsJsTypeVariable();
        _resolveURL = $"{variableName}.resolveURL".AsJsTypeVariable();
        _setURLModifier = $"{variableName}.setURLModifier".AsJsTypeVariable();
        _addHandler = $"{variableName}.addHandler".AsJsTypeVariable();
        _removeHandler = $"{variableName}.removeHandler".AsJsTypeVariable();
        _getHandler = $"{variableName}.getHandler".AsJsTypeVariable();
    }

    public JsLoadingManager(JsType argOnLoad = null, JsType argOnProgress = null, JsType argOnError = null)
        : base(new JsLoadingManagerConstructor(argOnLoad, argOnProgress, argOnError))
    {
    }

        
}