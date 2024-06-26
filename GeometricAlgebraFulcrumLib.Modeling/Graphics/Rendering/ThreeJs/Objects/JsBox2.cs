using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsBox2Constructor :
    JsTypeConstructor
{
    public JsVector2 Min { get; }
        
    public JsVector2 Max { get; }
        
        


    internal JsBox2Constructor(JsVector2 argMin, JsVector2 argMax)
    {
        Min = argMin ?? new JsVector2((double.PositiveInfinity).AsJsNumber(), (double.PositiveInfinity).AsJsNumber());
        Max = argMax ?? new JsVector2((double.NegativeInfinity).AsJsNumber(), (double.NegativeInfinity).AsJsNumber());
    }

    public override string GetJsCode()
    {
        return $"new THREE.Box2({Min.GetJsCode()}, {Max.GetJsCode()})";
    }
}
    
public partial class JsBox2 :
    JsObjectType
{
    public static implicit operator JsBox2(string jsTextCode)
    {
        return new JsBox2(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsBox2 value)
    {
        return value.GetJsCode();
    }


    private readonly JsBox2 _jsVariableValue;
    public JsBox2 JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsVector2 _min;
    public JsVector2 Min
    {
        get => _min ?? throw new InvalidOperationException();
        set
        {
            if (_min is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.min = {valueCode};");
        }
    }
        
    private readonly JsVector2 _max;
    public JsVector2 Max
    {
        get => _max ?? throw new InvalidOperationException();
        set
        {
            if (_max is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.max = {valueCode};");
        }
    }

    internal JsBox2(JsTypeConstructor jsCodeSource, JsBox2 jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _min = $"{variableName}.min".AsJsVector2Variable();
        _max = $"{variableName}.max".AsJsVector2Variable();
    }

    public JsBox2(JsVector2 argMin = null, JsVector2 argMax = null)
        : base(new JsBox2Constructor(argMin, argMax))
    {
    }

    public JsBox2 Set(JsType argMin = null, JsType argMax = null)
    {
        CallMethodVoid("set", argMin ?? new JsObject(), argMax ?? new JsObject());
            
        return this;
    }
        
    public JsBox2 SetFromPoints(JsType argPoints = null)
    {
        CallMethodVoid("setFromPoints", argPoints ?? new JsObject());
            
        return this;
    }
        
    public JsBox2 SetFromCenterAndSize(JsType argCenter = null, JsType argSize = null)
    {
        CallMethodVoid("setFromCenterAndSize", argCenter ?? new JsObject(), argSize ?? new JsObject());
            
        return this;
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsBox2 Copy(JsType argBox = null)
    {
        CallMethodVoid("copy", argBox ?? new JsObject());
            
        return this;
    }
        
    public JsBox2 MakeEmpty()
    {
        CallMethodVoid("makeEmpty");
            
        return this;
    }
        
    public JsType IsEmpty()
    {
        return CallMethod("isEmpty");
    }
        
    public JsType GetCenter(JsType argTarget = null)
    {
        return CallMethod("getCenter", argTarget ?? new JsObject());
    }
        
    public JsType GetSize(JsType argTarget = null)
    {
        return CallMethod("getSize", argTarget ?? new JsObject());
    }
        
    public JsBox2 ExpandByPoint(JsType argPoint = null)
    {
        CallMethodVoid("expandByPoint", argPoint ?? new JsObject());
            
        return this;
    }
        
    public JsBox2 ExpandByVector(JsType argVector = null)
    {
        CallMethodVoid("expandByVector", argVector ?? new JsObject());
            
        return this;
    }
        
    public JsBox2 ExpandByScalar(JsType argScalar = null)
    {
        CallMethodVoid("expandByScalar", argScalar ?? new JsObject());
            
        return this;
    }
        
    public JsType ContainsPoint(JsType argPoint = null)
    {
        return CallMethod("containsPoint", argPoint ?? new JsObject());
    }
        
    public JsType ContainsBox(JsType argBox = null)
    {
        return CallMethod("containsBox", argBox ?? new JsObject());
    }
        
    public JsType GetParameter(JsType argPoint = null, JsType argTarget = null)
    {
        return CallMethod("getParameter", argPoint ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsType IntersectsBox(JsType argBox = null)
    {
        return CallMethod("intersectsBox", argBox ?? new JsObject());
    }
        
    public JsType ClampPoint(JsType argPoint = null, JsType argTarget = null)
    {
        return CallMethod("clampPoint", argPoint ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsType DistanceToPoint(JsType argPoint = null)
    {
        return CallMethod("distanceToPoint", argPoint ?? new JsObject());
    }
        
    public JsBox2 Intersect(JsType argBox = null)
    {
        CallMethodVoid("intersect", argBox ?? new JsObject());
            
        return this;
    }
        
    public JsBox2 Union(JsType argBox = null)
    {
        CallMethodVoid("union", argBox ?? new JsObject());
            
        return this;
    }
        
    public JsBox2 Translate(JsType argOffset = null)
    {
        CallMethodVoid("translate", argOffset ?? new JsObject());
            
        return this;
    }
        
    public JsType Equals(JsType argBox = null)
    {
        return CallMethod("equals", argBox ?? new JsObject());
    }
        
        
}