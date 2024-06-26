using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsPropertyBindingConstructor :
    JsTypeConstructor
{
    public JsType RootNode { get; }
        
    public JsType Path { get; }
        
    public JsType ParsedPath { get; }
        
        


    internal JsPropertyBindingConstructor(JsType argRootNode, JsType argPath, JsType argParsedPath)
    {
        RootNode = argRootNode ?? new JsObject();
        Path = argPath ?? new JsObject();
        ParsedPath = argParsedPath ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.PropertyBinding({RootNode.GetJsCode()}, {Path.GetJsCode()}, {ParsedPath.GetJsCode()})";
    }
}
    
public partial class JsPropertyBinding :
    JsObjectType
{
    public static implicit operator JsPropertyBinding(string jsTextCode)
    {
        return new JsPropertyBinding(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsPropertyBinding value)
    {
        return value.GetJsCode();
    }


    private readonly JsPropertyBinding _jsVariableValue;
    public JsPropertyBinding JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _path;
    public JsType Path
    {
        get => _path ?? throw new InvalidOperationException();
        set
        {
            if (_path is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.path = {valueCode};");
        }
    }
        
    private readonly JsType _parsedPath;
    public JsType ParsedPath
    {
        get => _parsedPath ?? throw new InvalidOperationException();
        set
        {
            if (_parsedPath is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.parsedPath = {valueCode};");
        }
    }
        
    private readonly JsType _node;
    public JsType Node
    {
        get => _node ?? throw new InvalidOperationException();
        set
        {
            if (_node is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.node = {valueCode};");
        }
    }
        
    private readonly JsType _rootNode;
    public JsType RootNode
    {
        get => _rootNode ?? throw new InvalidOperationException();
        set
        {
            if (_rootNode is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.rootNode = {valueCode};");
        }
    }
        
    private readonly JsType _getValue;
    public JsType GetValue
    {
        get => _getValue ?? throw new InvalidOperationException();
        set
        {
            if (_getValue is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.getValue = {valueCode};");
        }
    }
        
    private readonly JsType _setValue;
    public JsType SetValue
    {
        get => _setValue ?? throw new InvalidOperationException();
        set
        {
            if (_setValue is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.setValue = {valueCode};");
        }
    }
        
    private readonly JsType _resolvedProperty;
    public JsType ResolvedProperty
    {
        get => _resolvedProperty ?? throw new InvalidOperationException();
        set
        {
            if (_resolvedProperty is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.resolvedProperty = {valueCode};");
        }
    }
        
    private readonly JsType _propertyName;
    public JsType PropertyName
    {
        get => _propertyName ?? throw new InvalidOperationException();
        set
        {
            if (_propertyName is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.propertyName = {valueCode};");
        }
    }

    internal JsPropertyBinding(JsTypeConstructor jsCodeSource, JsPropertyBinding jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _path = $"{variableName}.path".AsJsTypeVariable();
        _parsedPath = $"{variableName}.parsedPath".AsJsTypeVariable();
        _node = $"{variableName}.node".AsJsTypeVariable();
        _rootNode = $"{variableName}.rootNode".AsJsTypeVariable();
        _getValue = $"{variableName}.getValue".AsJsTypeVariable();
        _setValue = $"{variableName}.setValue".AsJsTypeVariable();
        _resolvedProperty = $"{variableName}.resolvedProperty".AsJsTypeVariable();
        _propertyName = $"{variableName}.propertyName".AsJsTypeVariable();
    }

    public JsPropertyBinding(JsType argRootNode = null, JsType argPath = null, JsType argParsedPath = null)
        : base(new JsPropertyBindingConstructor(argRootNode, argPath, argParsedPath))
    {
    }

    public JsType _getValueUnavailable()
    {
        return CallMethod("_getValue_unavailable");
    }
        
    public JsType _setValueUnavailable()
    {
        return CallMethod("_setValue_unavailable");
    }
        
    public JsType _getValueDirect(JsType argBuffer = null, JsType argOffset = null)
    {
        return CallMethod("_getValue_direct", argBuffer ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _getValueArray(JsType argBuffer = null, JsType argOffset = null)
    {
        return CallMethod("_getValue_array", argBuffer ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _getValueArrayElement(JsType argBuffer = null, JsType argOffset = null)
    {
        return CallMethod("_getValue_arrayElement", argBuffer ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _getValueToArray(JsType argBuffer = null, JsType argOffset = null)
    {
        return CallMethod("_getValue_toArray", argBuffer ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _setValueDirect(JsType argBuffer = null, JsType argOffset = null)
    {
        return CallMethod("_setValue_direct", argBuffer ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _setValueDirectSetNeedsUpdate(JsType argBuffer = null, JsType argOffset = null)
    {
        return CallMethod("_setValue_direct_setNeedsUpdate", argBuffer ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _setValueDirectSetMatrixWorldNeedsUpdate(JsType argBuffer = null, JsType argOffset = null)
    {
        return CallMethod("_setValue_direct_setMatrixWorldNeedsUpdate", argBuffer ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _setValueArray(JsType argBuffer = null, JsType argOffset = null)
    {
        return CallMethod("_setValue_array", argBuffer ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _setValueArraySetNeedsUpdate(JsType argBuffer = null, JsType argOffset = null)
    {
        return CallMethod("_setValue_array_setNeedsUpdate", argBuffer ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _setValueArraySetMatrixWorldNeedsUpdate(JsType argBuffer = null, JsType argOffset = null)
    {
        return CallMethod("_setValue_array_setMatrixWorldNeedsUpdate", argBuffer ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _setValueArrayElement(JsType argBuffer = null, JsType argOffset = null)
    {
        return CallMethod("_setValue_arrayElement", argBuffer ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _setValueArrayElementSetNeedsUpdate(JsType argBuffer = null, JsType argOffset = null)
    {
        return CallMethod("_setValue_arrayElement_setNeedsUpdate", argBuffer ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _setValueArrayElementSetMatrixWorldNeedsUpdate(JsType argBuffer = null, JsType argOffset = null)
    {
        return CallMethod("_setValue_arrayElement_setMatrixWorldNeedsUpdate", argBuffer ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _setValueFromArray(JsType argBuffer = null, JsType argOffset = null)
    {
        return CallMethod("_setValue_fromArray", argBuffer ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _setValueFromArraySetNeedsUpdate(JsType argBuffer = null, JsType argOffset = null)
    {
        return CallMethod("_setValue_fromArray_setNeedsUpdate", argBuffer ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _setValueFromArraySetMatrixWorldNeedsUpdate(JsType argBuffer = null, JsType argOffset = null)
    {
        return CallMethod("_setValue_fromArray_setMatrixWorldNeedsUpdate", argBuffer ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _getValueUnbound(JsType argTargetArray = null, JsType argOffset = null)
    {
        return CallMethod("_getValue_unbound", argTargetArray ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType _setValueUnbound(JsType argSourceArray = null, JsType argOffset = null)
    {
        return CallMethod("_setValue_unbound", argSourceArray ?? new JsObject(), argOffset ?? new JsObject());
    }
        
    public JsType Bind()
    {
        return CallMethod("bind");
    }
        
    public JsType Unbind()
    {
        return CallMethod("unbind");
    }
        
        
}