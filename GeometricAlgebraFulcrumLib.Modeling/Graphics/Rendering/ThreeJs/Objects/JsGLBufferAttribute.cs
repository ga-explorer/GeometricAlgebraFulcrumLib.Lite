using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsGLBufferAttributeConstructor :
    JsTypeConstructor
{
    public JsType Buffer { get; }
        
    public JsType Type { get; }
        
    public JsType ItemSize { get; }
        
    public JsType ElementSize { get; }
        
    public JsType Count { get; }
        
        


    internal JsGLBufferAttributeConstructor(JsType argBuffer, JsType argType, JsType argItemSize, JsType argElementSize, JsType argCount)
    {
        Buffer = argBuffer ?? new JsObject();
        Type = argType ?? new JsObject();
        ItemSize = argItemSize ?? new JsObject();
        ElementSize = argElementSize ?? new JsObject();
        Count = argCount ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.GLBufferAttribute({Buffer.GetJsCode()}, {Type.GetJsCode()}, {ItemSize.GetJsCode()}, {ElementSize.GetJsCode()}, {Count.GetJsCode()})";
    }
}
    
public partial class JsGLBufferAttribute :
    JsObjectType
{
    public static implicit operator JsGLBufferAttribute(string jsTextCode)
    {
        return new JsGLBufferAttribute(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsGLBufferAttribute value)
    {
        return value.GetJsCode();
    }


    private readonly JsGLBufferAttribute _jsVariableValue;
    public JsGLBufferAttribute JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _buffer;
    public JsType Buffer
    {
        get => _buffer ?? throw new InvalidOperationException();
        set
        {
            if (_buffer is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.buffer = {valueCode};");
        }
    }
        
    private readonly JsType _type;
    public JsType Type
    {
        get => _type ?? throw new InvalidOperationException();
        set
        {
            if (_type is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _itemSize;
    public JsType ItemSize
    {
        get => _itemSize ?? throw new InvalidOperationException();
        set
        {
            if (_itemSize is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.itemSize = {valueCode};");
        }
    }
        
    private readonly JsType _elementSize;
    public JsType ElementSize
    {
        get => _elementSize ?? throw new InvalidOperationException();
        set
        {
            if (_elementSize is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.elementSize = {valueCode};");
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

    internal JsGLBufferAttribute(JsTypeConstructor jsCodeSource, JsGLBufferAttribute jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _buffer = $"{variableName}.buffer".AsJsTypeVariable();
        _type = $"{variableName}.type".AsJsTypeVariable();
        _itemSize = $"{variableName}.itemSize".AsJsTypeVariable();
        _elementSize = $"{variableName}.elementSize".AsJsTypeVariable();
        _count = $"{variableName}.count".AsJsTypeVariable();
        _version = $"{variableName}.version".AsJsNumberVariable();
    }

    public JsGLBufferAttribute(JsType argBuffer = null, JsType argType = null, JsType argItemSize = null, JsType argElementSize = null, JsType argCount = null)
        : base(new JsGLBufferAttributeConstructor(argBuffer, argType, argItemSize, argElementSize, argCount))
    {
    }

    public JsGLBufferAttribute SetBuffer(JsType argBuffer = null)
    {
        CallMethodVoid("setBuffer", argBuffer ?? new JsObject());
            
        return this;
    }
        
    public JsGLBufferAttribute SetType(JsType argType = null, JsType argElementSize = null)
    {
        CallMethodVoid("setType", argType ?? new JsObject(), argElementSize ?? new JsObject());
            
        return this;
    }
        
    public JsGLBufferAttribute SetItemSize(JsType argItemSize = null)
    {
        CallMethodVoid("setItemSize", argItemSize ?? new JsObject());
            
        return this;
    }
        
    public JsGLBufferAttribute SetCount(JsType argCount = null)
    {
        CallMethodVoid("setCount", argCount ?? new JsObject());
            
        return this;
    }
        
        
}