using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsEulerConstructor :
    JsTypeConstructor
{
    public JsNumber X { get; }
        
    public JsNumber Y { get; }
        
    public JsNumber Z { get; }
        
    public JsType Order { get; }
        
        


    internal JsEulerConstructor(JsNumber argX, JsNumber argY, JsNumber argZ, JsType argOrder)
    {
        X = argX ?? (0).AsJsNumber();
        Y = argY ?? (0).AsJsNumber();
        Z = argZ ?? (0).AsJsNumber();
        Order = argOrder ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Euler({X.GetJsCode()}, {Y.GetJsCode()}, {Z.GetJsCode()}, {Order.GetJsCode()})";
    }
}
    
public partial class JsEuler :
    JsObjectType
{
    public static implicit operator JsEuler(string jsTextCode)
    {
        return new JsEuler(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsEuler value)
    {
        return value.GetJsCode();
    }


    private readonly JsEuler _jsVariableValue;
    public JsEuler JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _x;
    public JsType X
    {
        get => _x ?? throw new InvalidOperationException();
        set
        {
            if (_x is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.x = {valueCode};");
        }
    }
        
    private readonly JsType _y;
    public JsType Y
    {
        get => _y ?? throw new InvalidOperationException();
        set
        {
            if (_y is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.y = {valueCode};");
        }
    }
        
    private readonly JsType _z;
    public JsType Z
    {
        get => _z ?? throw new InvalidOperationException();
        set
        {
            if (_z is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.z = {valueCode};");
        }
    }
        
    private readonly JsType _order;
    public JsType Order
    {
        get => _order ?? throw new InvalidOperationException();
        set
        {
            if (_order is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.order = {valueCode};");
        }
    }

    internal JsEuler(JsTypeConstructor jsCodeSource, JsEuler jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _x = $"{variableName}.x".AsJsTypeVariable();
        _y = $"{variableName}.y".AsJsTypeVariable();
        _z = $"{variableName}.z".AsJsTypeVariable();
        _order = $"{variableName}.order".AsJsTypeVariable();
    }

    public JsEuler(JsNumber argX = null, JsNumber argY = null, JsNumber argZ = null, JsType argOrder = null)
        : base(new JsEulerConstructor(argX, argY, argZ, argOrder))
    {
    }

    public JsEuler Set(JsType argX = null, JsType argY = null, JsType argZ = null, JsType argOrder = null)
    {
        CallMethodVoid("set", argX ?? new JsObject(), argY ?? new JsObject(), argZ ?? new JsObject(), argOrder ?? new JsObject());
            
        return this;
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsEuler Copy(JsType argEuler = null)
    {
        CallMethodVoid("copy", argEuler ?? new JsObject());
            
        return this;
    }
        
    public JsEuler SetFromRotationMatrix(JsType argM = null, JsType argOrder = null, JsBoolean argUpdate = null)
    {
        CallMethodVoid("setFromRotationMatrix", argM ?? new JsObject(), argOrder ?? new JsObject(), argUpdate ?? (true).AsJsBoolean());
            
        return this;
    }
        
    public JsType SetFromQuaternion(JsType argQ = null, JsType argOrder = null, JsType argUpdate = null)
    {
        return CallMethod("setFromQuaternion", argQ ?? new JsObject(), argOrder ?? new JsObject(), argUpdate ?? new JsObject());
    }
        
    public JsType SetFromVector3(JsType argV = null, JsType argOrder = null)
    {
        return CallMethod("setFromVector3", argV ?? new JsObject(), argOrder ?? new JsObject());
    }
        
    public JsType Reorder(JsType argNewOrder = null)
    {
        return CallMethod("reorder", argNewOrder ?? new JsObject());
    }
        
    public JsType Equals(JsType argEuler = null)
    {
        return CallMethod("equals", argEuler ?? new JsObject());
    }
        
    public JsEuler FromArray(JsType argArray = null)
    {
        CallMethodVoid("fromArray", argArray ?? new JsObject());
            
        return this;
    }
        
    public JsArray ToArray(JsArray argArray = null, JsNumber argOffset = null)
    {
        return CallMethod("toArray", argArray ?? new JsArray(), argOffset ?? (0).AsJsNumber());
    }
        
    public JsType ToVector3(JsType argOptionalResult = null)
    {
        return CallMethod("toVector3", argOptionalResult ?? new JsObject());
    }
        
    public JsEuler _onChange(JsType argCallback = null)
    {
        CallMethodVoid("_onChange", argCallback ?? new JsObject());
            
        return this;
    }
        
    public JsType _onChangeCallback()
    {
        return CallMethod("_onChangeCallback");
    }
        
        
}