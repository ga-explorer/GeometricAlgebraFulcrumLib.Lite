using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsPropertyMixerConstructor :
    JsTypeConstructor
{
    public JsType Binding { get; }
        
    public JsType TypeName { get; }
        
    public JsType ValueSize { get; }
        
        


    internal JsPropertyMixerConstructor(JsType argBinding, JsType argTypeName, JsType argValueSize)
    {
        Binding = argBinding ?? new JsObject();
        TypeName = argTypeName ?? new JsObject();
        ValueSize = argValueSize ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.PropertyMixer({Binding.GetJsCode()}, {TypeName.GetJsCode()}, {ValueSize.GetJsCode()})";
    }
}
    
public partial class JsPropertyMixer :
    JsObjectType
{
    public static implicit operator JsPropertyMixer(string jsTextCode)
    {
        return new JsPropertyMixer(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsPropertyMixer value)
    {
        return value.GetJsCode();
    }


    private readonly JsPropertyMixer _jsVariableValue;
    public JsPropertyMixer JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _binding;
    public JsType Binding
    {
        get => _binding ?? throw new InvalidOperationException();
        set
        {
            if (_binding is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.binding = {valueCode};");
        }
    }
        
    private readonly JsType _valueSize;
    public JsType ValueSize
    {
        get => _valueSize ?? throw new InvalidOperationException();
        set
        {
            if (_valueSize is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.valueSize = {valueCode};");
        }
    }
        
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
        
    private readonly JsNumber _cumulativeWeight;
    public JsNumber CumulativeWeight
    {
        get => _cumulativeWeight ?? throw new InvalidOperationException();
        set
        {
            if (_cumulativeWeight is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.cumulativeWeight = {valueCode};");
        }
    }
        
    private readonly JsNumber _cumulativeWeightAdditive;
    public JsNumber CumulativeWeightAdditive
    {
        get => _cumulativeWeightAdditive ?? throw new InvalidOperationException();
        set
        {
            if (_cumulativeWeightAdditive is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.cumulativeWeightAdditive = {valueCode};");
        }
    }
        
    private readonly JsNumber _useCount;
    public JsNumber UseCount
    {
        get => _useCount ?? throw new InvalidOperationException();
        set
        {
            if (_useCount is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.useCount = {valueCode};");
        }
    }
        
    private readonly JsNumber _referenceCount;
    public JsNumber ReferenceCount
    {
        get => _referenceCount ?? throw new InvalidOperationException();
        set
        {
            if (_referenceCount is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.referenceCount = {valueCode};");
        }
    }

    internal JsPropertyMixer(JsTypeConstructor jsCodeSource, JsPropertyMixer jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _binding = $"{variableName}.binding".AsJsTypeVariable();
        _valueSize = $"{variableName}.valueSize".AsJsTypeVariable();
        _buffer = $"{variableName}.buffer".AsJsTypeVariable();
        _cumulativeWeight = $"{variableName}.cumulativeWeight".AsJsNumberVariable();
        _cumulativeWeightAdditive = $"{variableName}.cumulativeWeightAdditive".AsJsNumberVariable();
        _useCount = $"{variableName}.useCount".AsJsNumberVariable();
        _referenceCount = $"{variableName}.referenceCount".AsJsNumberVariable();
    }

    public JsPropertyMixer(JsType argBinding = null, JsType argTypeName = null, JsType argValueSize = null)
        : base(new JsPropertyMixerConstructor(argBinding, argTypeName, argValueSize))
    {
    }

    public JsType Accumulate(JsType argAccuIndex = null, JsType argWeight = null)
    {
        return CallMethod("accumulate", argAccuIndex ?? new JsObject(), argWeight ?? new JsObject());
    }
        
    public JsType AccumulateAdditive(JsType argWeight = null)
    {
        return CallMethod("accumulateAdditive", argWeight ?? new JsObject());
    }
        
    public JsType Apply(JsType argAccuIndex = null)
    {
        return CallMethod("apply", argAccuIndex ?? new JsObject());
    }
        
    public JsType SaveOriginalState()
    {
        return CallMethod("saveOriginalState");
    }
        
    public JsType RestoreOriginalState()
    {
        return CallMethod("restoreOriginalState");
    }
        
    public JsType _setAdditiveIdentityNumeric()
    {
        return CallMethod("_setAdditiveIdentityNumeric");
    }
        
    public JsType _setAdditiveIdentityQuaternion()
    {
        return CallMethod("_setAdditiveIdentityQuaternion");
    }
        
    public JsType _setAdditiveIdentityOther()
    {
        return CallMethod("_setAdditiveIdentityOther");
    }
        
    public JsType _select(JsType argBuffer = null, JsType argDstOffset = null, JsType argSrcOffset = null, JsType argT = null, JsType argStride = null)
    {
        return CallMethod("_select", argBuffer ?? new JsObject(), argDstOffset ?? new JsObject(), argSrcOffset ?? new JsObject(), argT ?? new JsObject(), argStride ?? new JsObject());
    }
        
    public JsType _slerp(JsType argBuffer = null, JsType argDstOffset = null, JsType argSrcOffset = null, JsType argT = null)
    {
        return CallMethod("_slerp", argBuffer ?? new JsObject(), argDstOffset ?? new JsObject(), argSrcOffset ?? new JsObject(), argT ?? new JsObject());
    }
        
    public JsType _slerpAdditive(JsType argBuffer = null, JsType argDstOffset = null, JsType argSrcOffset = null, JsType argT = null, JsType argStride = null)
    {
        return CallMethod("_slerpAdditive", argBuffer ?? new JsObject(), argDstOffset ?? new JsObject(), argSrcOffset ?? new JsObject(), argT ?? new JsObject(), argStride ?? new JsObject());
    }
        
    public JsType _lerp(JsType argBuffer = null, JsType argDstOffset = null, JsType argSrcOffset = null, JsType argT = null, JsType argStride = null)
    {
        return CallMethod("_lerp", argBuffer ?? new JsObject(), argDstOffset ?? new JsObject(), argSrcOffset ?? new JsObject(), argT ?? new JsObject(), argStride ?? new JsObject());
    }
        
    public JsType _lerpAdditive(JsType argBuffer = null, JsType argDstOffset = null, JsType argSrcOffset = null, JsType argT = null, JsType argStride = null)
    {
        return CallMethod("_lerpAdditive", argBuffer ?? new JsObject(), argDstOffset ?? new JsObject(), argSrcOffset ?? new JsObject(), argT ?? new JsObject(), argStride ?? new JsObject());
    }
        
        
}