using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsInterleavedBufferAttributeConstructor :
    JsTypeConstructor
{
    public JsType InterleavedBuffer { get; }
        
    public JsType ItemSize { get; }
        
    public JsType Offset { get; }
        
    public JsBoolean Normalized { get; }
        
        


    internal JsInterleavedBufferAttributeConstructor(JsType argInterleavedBuffer, JsType argItemSize, JsType argOffset, JsBoolean argNormalized)
    {
        InterleavedBuffer = argInterleavedBuffer ?? new JsObject();
        ItemSize = argItemSize ?? new JsObject();
        Offset = argOffset ?? new JsObject();
        Normalized = argNormalized ?? (false).AsJsBoolean();
    }

    public override string GetJsCode()
    {
        return $"new THREE.InterleavedBufferAttribute({InterleavedBuffer.GetJsCode()}, {ItemSize.GetJsCode()}, {Offset.GetJsCode()}, {Normalized.GetJsCode()})";
    }
}
    
public partial class JsInterleavedBufferAttribute :
    JsObjectType
{
    public static implicit operator JsInterleavedBufferAttribute(string jsTextCode)
    {
        return new JsInterleavedBufferAttribute(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsInterleavedBufferAttribute value)
    {
        return value.GetJsCode();
    }


    private readonly JsInterleavedBufferAttribute _jsVariableValue;
    public JsInterleavedBufferAttribute JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

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
        
    private readonly JsType _data;
    public JsType Data
    {
        get => _data ?? throw new InvalidOperationException();
        set
        {
            if (_data is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.data = {valueCode};");
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
        
    private readonly JsType _normalized;
    public JsType Normalized
    {
        get => _normalized ?? throw new InvalidOperationException();
        set
        {
            if (_normalized is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.normalized = {valueCode};");
        }
    }
        
    private readonly JsType _count;
    public JsType Count => _count ?? throw new InvalidOperationException();

    private readonly JsType _array;
    public JsType Array => _array ?? throw new InvalidOperationException();

    internal JsInterleavedBufferAttribute(JsTypeConstructor jsCodeSource, JsInterleavedBufferAttribute jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _name = $"{variableName}.name".AsJsStringVariable();
        _data = $"{variableName}.data".AsJsTypeVariable();
        _itemSize = $"{variableName}.itemSize".AsJsTypeVariable();
        _offset = $"{variableName}.offset".AsJsTypeVariable();
        _normalized = $"{variableName}.normalized".AsJsTypeVariable();
        _count = $"{variableName}.count".AsJsTypeVariable();
        _array = $"{variableName}.array".AsJsTypeVariable();
    }

    public JsInterleavedBufferAttribute(JsType argInterleavedBuffer = null, JsType argItemSize = null, JsType argOffset = null, JsBoolean argNormalized = null)
        : base(new JsInterleavedBufferAttributeConstructor(argInterleavedBuffer, argItemSize, argOffset, argNormalized))
    {
    }

    public JsInterleavedBufferAttribute ApplyMatrix4(JsType argM = null)
    {
        CallMethodVoid("applyMatrix4", argM ?? new JsObject());
            
        return this;
    }
        
    public JsInterleavedBufferAttribute ApplyNormalMatrix(JsType argM = null)
    {
        CallMethodVoid("applyNormalMatrix", argM ?? new JsObject());
            
        return this;
    }
        
    public JsInterleavedBufferAttribute TransformDirection(JsType argM = null)
    {
        CallMethodVoid("transformDirection", argM ?? new JsObject());
            
        return this;
    }
        
    public JsInterleavedBufferAttribute SetX(JsType argIndex = null, JsType argX = null)
    {
        CallMethodVoid("setX", argIndex ?? new JsObject(), argX ?? new JsObject());
            
        return this;
    }
        
    public JsInterleavedBufferAttribute SetY(JsType argIndex = null, JsType argY = null)
    {
        CallMethodVoid("setY", argIndex ?? new JsObject(), argY ?? new JsObject());
            
        return this;
    }
        
    public JsInterleavedBufferAttribute SetZ(JsType argIndex = null, JsType argZ = null)
    {
        CallMethodVoid("setZ", argIndex ?? new JsObject(), argZ ?? new JsObject());
            
        return this;
    }
        
    public JsInterleavedBufferAttribute SetW(JsType argIndex = null, JsType argW = null)
    {
        CallMethodVoid("setW", argIndex ?? new JsObject(), argW ?? new JsObject());
            
        return this;
    }
        
    public JsType GetX(JsType argIndex = null)
    {
        return CallMethod("getX", argIndex ?? new JsObject());
    }
        
    public JsType GetY(JsType argIndex = null)
    {
        return CallMethod("getY", argIndex ?? new JsObject());
    }
        
    public JsType GetZ(JsType argIndex = null)
    {
        return CallMethod("getZ", argIndex ?? new JsObject());
    }
        
    public JsType GetW(JsType argIndex = null)
    {
        return CallMethod("getW", argIndex ?? new JsObject());
    }
        
    public JsInterleavedBufferAttribute SetXY(JsType argIndex = null, JsType argX = null, JsType argY = null)
    {
        CallMethodVoid("setXY", argIndex ?? new JsObject(), argX ?? new JsObject(), argY ?? new JsObject());
            
        return this;
    }
        
    public JsInterleavedBufferAttribute SetXYZ(JsType argIndex = null, JsType argX = null, JsType argY = null, JsType argZ = null)
    {
        CallMethodVoid("setXYZ", argIndex ?? new JsObject(), argX ?? new JsObject(), argY ?? new JsObject(), argZ ?? new JsObject());
            
        return this;
    }
        
    public JsInterleavedBufferAttribute SetXYZW(JsType argIndex = null, JsType argX = null, JsType argY = null, JsType argZ = null, JsType argW = null)
    {
        CallMethodVoid("setXYZW", argIndex ?? new JsObject(), argX ?? new JsObject(), argY ?? new JsObject(), argZ ?? new JsObject(), argW ?? new JsObject());
            
        return this;
    }
        
    public JsType Clone(JsType argData = null)
    {
        return CallMethod("clone", argData ?? new JsObject());
    }
        
    public JsType ToJSON(JsType argData = null)
    {
        return CallMethod("toJSON", argData ?? new JsObject());
    }
        
        
}