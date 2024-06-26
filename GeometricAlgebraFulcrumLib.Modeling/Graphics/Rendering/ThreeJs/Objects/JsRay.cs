using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsRayConstructor :
    JsTypeConstructor
{
    public JsVector3 Origin { get; }
        
    public JsVector3 Direction { get; }
        
        


    internal JsRayConstructor(JsVector3 argOrigin, JsVector3 argDirection)
    {
        Origin = argOrigin ?? new JsVector3();
        Direction = argDirection ?? new JsVector3((0).AsJsNumber(), (0).AsJsNumber(), (-1).AsJsNumber());
    }

    public override string GetJsCode()
    {
        return $"new THREE.Ray({Origin.GetJsCode()}, {Direction.GetJsCode()})";
    }
}
    
public partial class JsRay :
    JsObjectType
{
    public static implicit operator JsRay(string jsTextCode)
    {
        return new JsRay(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsRay value)
    {
        return value.GetJsCode();
    }


    private readonly JsRay _jsVariableValue;
    public JsRay JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsVector3 _origin;
    public JsVector3 Origin
    {
        get => _origin ?? throw new InvalidOperationException();
        set
        {
            if (_origin is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.origin = {valueCode};");
        }
    }
        
    private readonly JsVector3 _direction;
    public JsVector3 Direction
    {
        get => _direction ?? throw new InvalidOperationException();
        set
        {
            if (_direction is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.direction = {valueCode};");
        }
    }

    internal JsRay(JsTypeConstructor jsCodeSource, JsRay jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _origin = $"{variableName}.origin".AsJsVector3Variable();
        _direction = $"{variableName}.direction".AsJsVector3Variable();
    }

    public JsRay(JsVector3 argOrigin = null, JsVector3 argDirection = null)
        : base(new JsRayConstructor(argOrigin, argDirection))
    {
    }

    public JsRay Set(JsType argOrigin = null, JsType argDirection = null)
    {
        CallMethodVoid("set", argOrigin ?? new JsObject(), argDirection ?? new JsObject());
            
        return this;
    }
        
    public JsRay Copy(JsType argRay = null)
    {
        CallMethodVoid("copy", argRay ?? new JsObject());
            
        return this;
    }
        
    public JsType At(JsType argT = null, JsType argTarget = null)
    {
        return CallMethod("at", argT ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsRay LookAt(JsType argV = null)
    {
        CallMethodVoid("lookAt", argV ?? new JsObject());
            
        return this;
    }
        
    public JsRay Recast(JsType argT = null)
    {
        CallMethodVoid("recast", argT ?? new JsObject());
            
        return this;
    }
        
    public JsType ClosestPointToPoint(JsType argPoint = null, JsType argTarget = null)
    {
        return CallMethod("closestPointToPoint", argPoint ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsType DistanceToPoint(JsType argPoint = null)
    {
        return CallMethod("distanceToPoint", argPoint ?? new JsObject());
    }
        
    public JsType DistanceSqToPoint(JsType argPoint = null)
    {
        return CallMethod("distanceSqToPoint", argPoint ?? new JsObject());
    }
        
    public JsType DistanceSqToSegment(JsType argV0 = null, JsType argV1 = null, JsType argOptionalPointOnRay = null, JsType argOptionalPointOnSegment = null)
    {
        return CallMethod("distanceSqToSegment", argV0 ?? new JsObject(), argV1 ?? new JsObject(), argOptionalPointOnRay ?? new JsObject(), argOptionalPointOnSegment ?? new JsObject());
    }
        
    public JsType IntersectSphere(JsType argSphere = null, JsType argTarget = null)
    {
        return CallMethod("intersectSphere", argSphere ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsType IntersectsSphere(JsType argSphere = null)
    {
        return CallMethod("intersectsSphere", argSphere ?? new JsObject());
    }
        
    public JsType DistanceToPlane(JsType argPlane = null)
    {
        return CallMethod("distanceToPlane", argPlane ?? new JsObject());
    }
        
    public JsType IntersectPlane(JsType argPlane = null, JsType argTarget = null)
    {
        return CallMethod("intersectPlane", argPlane ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsType IntersectsPlane(JsType argPlane = null)
    {
        return CallMethod("intersectsPlane", argPlane ?? new JsObject());
    }
        
    public JsType IntersectBox(JsType argBox = null, JsType argTarget = null)
    {
        return CallMethod("intersectBox", argBox ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsType IntersectsBox(JsType argBox = null)
    {
        return CallMethod("intersectsBox", argBox ?? new JsObject());
    }
        
    public JsType IntersectTriangle(JsType argA = null, JsType argB = null, JsType argC = null, JsType argBackfaceCulling = null, JsType argTarget = null)
    {
        return CallMethod("intersectTriangle", argA ?? new JsObject(), argB ?? new JsObject(), argC ?? new JsObject(), argBackfaceCulling ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsRay ApplyMatrix4(JsType argMatrix4 = null)
    {
        CallMethodVoid("applyMatrix4", argMatrix4 ?? new JsObject());
            
        return this;
    }
        
    public JsType Equals(JsType argRay = null)
    {
        return CallMethod("equals", argRay ?? new JsObject());
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
        
}