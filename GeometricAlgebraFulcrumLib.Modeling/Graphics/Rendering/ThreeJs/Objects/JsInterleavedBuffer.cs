using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsInterleavedBufferConstructor :
    JsTypeConstructor
{
    public JsType Array { get; }
        
    public JsType Stride { get; }
        
        


    internal JsInterleavedBufferConstructor(JsType argArray, JsType argStride)
    {
        Array = argArray ?? new JsObject();
        Stride = argStride ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.InterleavedBuffer({Array.GetJsCode()}, {Stride.GetJsCode()})";
    }
}
    
public partial class JsInterleavedBuffer :
    JsObjectType
{
    public static implicit operator JsInterleavedBuffer(string jsTextCode)
    {
        return new JsInterleavedBuffer(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsInterleavedBuffer value)
    {
        return value.GetJsCode();
    }


    private readonly JsInterleavedBuffer _jsVariableValue;
    public JsInterleavedBuffer JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _array;
    public JsType Array
    {
        get => _array ?? throw new InvalidOperationException();
        set
        {
            if (_array is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.array = {valueCode};");
        }
    }
        
    private readonly JsType _stride;
    public JsType Stride
    {
        get => _stride ?? throw new InvalidOperationException();
        set
        {
            if (_stride is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.stride = {valueCode};");
        }
    }
        
    private readonly JsType _count;
    public JsType Count
    {
        get => _count ?? throw new InvalidOperationException();
        set
        {
            if (_count is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.count = {valueCode};");
        }
    }
        
    private readonly JsNumber _usage;
    public JsNumber Usage
    {
        get => _usage ?? throw new InvalidOperationException();
        set
        {
            if (_usage is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "35044";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.usage = {valueCode};");
        }
    }
        
    private readonly JsType _updateRange;
    public JsType UpdateRange
    {
        get => _updateRange ?? throw new InvalidOperationException();
        set
        {
            if (_updateRange is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.updateRange = {valueCode};");
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
        
    private readonly JsType _onUploadCallback;
    public JsType OnUploadCallback
    {
        get => _onUploadCallback ?? throw new InvalidOperationException();
        set
        {
            if (_onUploadCallback is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.onUploadCallback = {valueCode};");
        }
    }

    internal JsInterleavedBuffer(JsTypeConstructor jsCodeSource, JsInterleavedBuffer jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _array = $"{variableName}.array".AsJsTypeVariable();
        _stride = $"{variableName}.stride".AsJsTypeVariable();
        _count = $"{variableName}.count".AsJsTypeVariable();
        _usage = $"{variableName}.usage".AsJsNumberVariable();
        _updateRange = $"{variableName}.updateRange".AsJsTypeVariable();
        _version = $"{variableName}.version".AsJsNumberVariable();
        _uuid = $"{variableName}.uuid".AsJsTypeVariable();
        _onUploadCallback = $"{variableName}.onUploadCallback".AsJsTypeVariable();
    }

    public JsInterleavedBuffer(JsType argArray = null, JsType argStride = null)
        : base(new JsInterleavedBufferConstructor(argArray, argStride))
    {
    }

    public JsType CallOnUploadCallback()
    {
        return CallMethod("onUploadCallback");
    }
        
    public JsInterleavedBuffer SetUsage(JsType argValue = null)
    {
        CallMethodVoid("setUsage", argValue ?? new JsObject());
            
        return this;
    }
        
    public JsInterleavedBuffer Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsInterleavedBuffer CopyAt(JsType argIndex1 = null, JsType argAttribute = null, JsType argIndex2 = null)
    {
        CallMethodVoid("copyAt", argIndex1 ?? new JsObject(), argAttribute ?? new JsObject(), argIndex2 ?? new JsObject());
            
        return this;
    }
        
    public JsInterleavedBuffer Set(JsType argValue = null, JsNumber argOffset = null)
    {
        CallMethodVoid("set", argValue ?? new JsObject(), argOffset ?? (0).AsJsNumber());
            
        return this;
    }
        
    public JsType Clone(JsType argData = null)
    {
        return CallMethod("clone", argData ?? new JsObject());
    }
        
    public JsInterleavedBuffer OnUpload(JsType argCallback = null)
    {
        CallMethodVoid("onUpload", argCallback ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON(JsType argData = null)
    {
        return CallMethod("toJSON", argData ?? new JsObject());
    }
        
        
}