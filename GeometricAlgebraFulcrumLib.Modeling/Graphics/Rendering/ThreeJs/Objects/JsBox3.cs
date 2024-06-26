using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsBox3Constructor :
    JsTypeConstructor
{
    public JsVector3 Min { get; }
        
    public JsVector3 Max { get; }
        
        


    internal JsBox3Constructor(JsVector3 argMin, JsVector3 argMax)
    {
        Min = argMin ?? new JsVector3((double.PositiveInfinity).AsJsNumber(), (double.PositiveInfinity).AsJsNumber(), (double.PositiveInfinity).AsJsNumber());
        Max = argMax ?? new JsVector3((double.NegativeInfinity).AsJsNumber(), (double.NegativeInfinity).AsJsNumber(), (double.NegativeInfinity).AsJsNumber());
    }

    public override string GetJsCode()
    {
        return $"new THREE.Box3({Min.GetJsCode()}, {Max.GetJsCode()})";
    }
}
    
public partial class JsBox3 :
    JsObjectType
{
    public static implicit operator JsBox3(string jsTextCode)
    {
        return new JsBox3(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsBox3 value)
    {
        return value.GetJsCode();
    }


    private readonly JsBox3 _jsVariableValue;
    public JsBox3 JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsVector3 _min;
    public JsVector3 Min
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
        
    private readonly JsVector3 _max;
    public JsVector3 Max
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

    internal JsBox3(JsTypeConstructor jsCodeSource, JsBox3 jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _min = $"{variableName}.min".AsJsVector3Variable();
        _max = $"{variableName}.max".AsJsVector3Variable();
    }

    public JsBox3(JsVector3 argMin = null, JsVector3 argMax = null)
        : base(new JsBox3Constructor(argMin, argMax))
    {
    }

    public JsBox3 Set(JsType argMin = null, JsType argMax = null)
    {
        CallMethodVoid("set", argMin ?? new JsObject(), argMax ?? new JsObject());
            
        return this;
    }
        
    public JsBox3 SetFromArray(JsType argArray = null)
    {
        CallMethodVoid("setFromArray", argArray ?? new JsObject());
            
        return this;
    }
        
    public JsBox3 SetFromBufferAttribute(JsType argAttribute = null)
    {
        CallMethodVoid("setFromBufferAttribute", argAttribute ?? new JsObject());
            
        return this;
    }
        
    public JsBox3 SetFromPoints(JsType argPoints = null)
    {
        CallMethodVoid("setFromPoints", argPoints ?? new JsObject());
            
        return this;
    }
        
    public JsBox3 SetFromCenterAndSize(JsType argCenter = null, JsType argSize = null)
    {
        CallMethodVoid("setFromCenterAndSize", argCenter ?? new JsObject(), argSize ?? new JsObject());
            
        return this;
    }
        
    public JsType SetFromObject(JsType argObject = null)
    {
        return CallMethod("setFromObject", argObject ?? new JsObject());
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsBox3 Copy(JsType argBox = null)
    {
        CallMethodVoid("copy", argBox ?? new JsObject());
            
        return this;
    }
        
    public JsBox3 MakeEmpty()
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
        
    public JsBox3 ExpandByPoint(JsType argPoint = null)
    {
        CallMethodVoid("expandByPoint", argPoint ?? new JsObject());
            
        return this;
    }
        
    public JsBox3 ExpandByVector(JsType argVector = null)
    {
        CallMethodVoid("expandByVector", argVector ?? new JsObject());
            
        return this;
    }
        
    public JsBox3 ExpandByScalar(JsType argScalar = null)
    {
        CallMethodVoid("expandByScalar", argScalar ?? new JsObject());
            
        return this;
    }
        
    public JsBox3 ExpandByObject(JsType argObject = null)
    {
        CallMethodVoid("expandByObject", argObject ?? new JsObject());
            
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
        
    public JsType IntersectsSphere(JsType argSphere = null)
    {
        return CallMethod("intersectsSphere", argSphere ?? new JsObject());
    }
        
    public JsType IntersectsPlane(JsType argPlane = null)
    {
        return CallMethod("intersectsPlane", argPlane ?? new JsObject());
    }
        
    public JsType IntersectsTriangle(JsType argTriangle = null)
    {
        return CallMethod("intersectsTriangle", argTriangle ?? new JsObject());
    }
        
    public JsType ClampPoint(JsType argPoint = null, JsType argTarget = null)
    {
        return CallMethod("clampPoint", argPoint ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsType DistanceToPoint(JsType argPoint = null)
    {
        return CallMethod("distanceToPoint", argPoint ?? new JsObject());
    }
        
    public JsType GetBoundingSphere(JsType argTarget = null)
    {
        return CallMethod("getBoundingSphere", argTarget ?? new JsObject());
    }
        
    public JsBox3 Intersect(JsType argBox = null)
    {
        CallMethodVoid("intersect", argBox ?? new JsObject());
            
        return this;
    }
        
    public JsBox3 Union(JsType argBox = null)
    {
        CallMethodVoid("union", argBox ?? new JsObject());
            
        return this;
    }
        
    public JsBox3 ApplyMatrix4(JsType argMatrix = null)
    {
        CallMethodVoid("applyMatrix4", argMatrix ?? new JsObject());
            
        return this;
    }
        
    public JsBox3 Translate(JsType argOffset = null)
    {
        CallMethodVoid("translate", argOffset ?? new JsObject());
            
        return this;
    }
        
    public JsType Equals(JsType argBox = null)
    {
        return CallMethod("equals", argBox ?? new JsObject());
    }
        
        
}