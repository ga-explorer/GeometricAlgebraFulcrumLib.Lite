using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsVector3Constructor :
    JsTypeConstructor
{
    public JsNumber X { get; }
        
    public JsNumber Y { get; }
        
    public JsNumber Z { get; }
        
        


    internal JsVector3Constructor(JsNumber argX, JsNumber argY, JsNumber argZ)
    {
        X = argX ?? (0).AsJsNumber();
        Y = argY ?? (0).AsJsNumber();
        Z = argZ ?? (0).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Vector3({X.GetJsCode()}, {Y.GetJsCode()}, {Z.GetJsCode()})";
    }
}
    
public partial class JsVector3 :
    JsObjectType
{
    public static implicit operator JsVector3(string jsTextCode)
    {
        return new JsVector3(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsVector3 value)
    {
        return value.GetJsCode();
    }


    private readonly JsVector3 _jsVariableValue;
    public JsVector3 JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsNumber _x;
    public JsNumber X
    {
        get => _x ?? throw new InvalidOperationException();
        set
        {
            if (_x is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.x = {valueCode};");
        }
    }
        
    private readonly JsNumber _y;
    public JsNumber Y
    {
        get => _y ?? throw new InvalidOperationException();
        set
        {
            if (_y is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.y = {valueCode};");
        }
    }
        
    private readonly JsNumber _z;
    public JsNumber Z
    {
        get => _z ?? throw new InvalidOperationException();
        set
        {
            if (_z is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.z = {valueCode};");
        }
    }

    internal JsVector3(JsTypeConstructor jsCodeSource, JsVector3 jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _x = $"{variableName}.x".AsJsNumberVariable();
        _y = $"{variableName}.y".AsJsNumberVariable();
        _z = $"{variableName}.z".AsJsNumberVariable();
    }

    public JsVector3(JsNumber argX = null, JsNumber argY = null, JsNumber argZ = null)
        : base(new JsVector3Constructor(argX, argY, argZ))
    {
    }

    public JsVector3 Set(JsType argX = null, JsType argY = null, JsType argZ = null)
    {
        CallMethodVoid("set", argX ?? new JsObject(), argY ?? new JsObject(), argZ ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 SetScalar(JsType argScalar = null)
    {
        CallMethodVoid("setScalar", argScalar ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 SetX(JsType argX = null)
    {
        CallMethodVoid("setX", argX ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 SetY(JsType argY = null)
    {
        CallMethodVoid("setY", argY ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 SetZ(JsType argZ = null)
    {
        CallMethodVoid("setZ", argZ ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 SetComponent(JsType argIndex = null, JsType argValue = null)
    {
        CallMethodVoid("setComponent", argIndex ?? new JsObject(), argValue ?? new JsObject());
            
        return this;
    }
        
    public JsType GetComponent(JsType argIndex = null)
    {
        return CallMethod("getComponent", argIndex ?? new JsObject());
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsVector3 Copy(JsType argV = null)
    {
        CallMethodVoid("copy", argV ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 Add(JsType argV = null, JsType argW = null)
    {
        CallMethodVoid("add", argV ?? new JsObject(), argW ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 AddScalar(JsType argS = null)
    {
        CallMethodVoid("addScalar", argS ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 AddVectors(JsType argA = null, JsType argB = null)
    {
        CallMethodVoid("addVectors", argA ?? new JsObject(), argB ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 AddScaledVector(JsType argV = null, JsType argS = null)
    {
        CallMethodVoid("addScaledVector", argV ?? new JsObject(), argS ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 Sub(JsType argV = null, JsType argW = null)
    {
        CallMethodVoid("sub", argV ?? new JsObject(), argW ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 SubScalar(JsType argS = null)
    {
        CallMethodVoid("subScalar", argS ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 SubVectors(JsType argA = null, JsType argB = null)
    {
        CallMethodVoid("subVectors", argA ?? new JsObject(), argB ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 Multiply(JsType argV = null, JsType argW = null)
    {
        CallMethodVoid("multiply", argV ?? new JsObject(), argW ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 MultiplyScalar(JsType argScalar = null)
    {
        CallMethodVoid("multiplyScalar", argScalar ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 MultiplyVectors(JsType argA = null, JsType argB = null)
    {
        CallMethodVoid("multiplyVectors", argA ?? new JsObject(), argB ?? new JsObject());
            
        return this;
    }
        
    public JsType ApplyEuler(JsType argEuler = null)
    {
        return CallMethod("applyEuler", argEuler ?? new JsObject());
    }
        
    public JsType ApplyAxisAngle(JsType argAxis = null, JsType argAngle = null)
    {
        return CallMethod("applyAxisAngle", argAxis ?? new JsObject(), argAngle ?? new JsObject());
    }
        
    public JsVector3 ApplyMatrix3(JsType argM = null)
    {
        CallMethodVoid("applyMatrix3", argM ?? new JsObject());
            
        return this;
    }
        
    public JsType ApplyNormalMatrix(JsType argM = null)
    {
        return CallMethod("applyNormalMatrix", argM ?? new JsObject());
    }
        
    public JsVector3 ApplyMatrix4(JsType argM = null)
    {
        CallMethodVoid("applyMatrix4", argM ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 ApplyQuaternion(JsType argQ = null)
    {
        CallMethodVoid("applyQuaternion", argQ ?? new JsObject());
            
        return this;
    }
        
    public JsType Project(JsType argCamera = null)
    {
        return CallMethod("project", argCamera ?? new JsObject());
    }
        
    public JsType Unproject(JsType argCamera = null)
    {
        return CallMethod("unproject", argCamera ?? new JsObject());
    }
        
    public JsType TransformDirection(JsType argM = null)
    {
        return CallMethod("transformDirection", argM ?? new JsObject());
    }
        
    public JsVector3 Divide(JsType argV = null)
    {
        CallMethodVoid("divide", argV ?? new JsObject());
            
        return this;
    }
        
    public JsType DivideScalar(JsType argScalar = null)
    {
        return CallMethod("divideScalar", argScalar ?? new JsObject());
    }
        
    public JsVector3 Min(JsType argV = null)
    {
        CallMethodVoid("min", argV ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 Max(JsType argV = null)
    {
        CallMethodVoid("max", argV ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 Clamp(JsType argMin = null, JsType argMax = null)
    {
        CallMethodVoid("clamp", argMin ?? new JsObject(), argMax ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 ClampScalar(JsType argMinVal = null, JsType argMaxVal = null)
    {
        CallMethodVoid("clampScalar", argMinVal ?? new JsObject(), argMaxVal ?? new JsObject());
            
        return this;
    }
        
    public JsType ClampLength(JsType argMin = null, JsType argMax = null)
    {
        return CallMethod("clampLength", argMin ?? new JsObject(), argMax ?? new JsObject());
    }
        
    public JsVector3 Floor()
    {
        CallMethodVoid("floor");
            
        return this;
    }
        
    public JsVector3 Ceil()
    {
        CallMethodVoid("ceil");
            
        return this;
    }
        
    public JsVector3 Round()
    {
        CallMethodVoid("round");
            
        return this;
    }
        
    public JsVector3 RoundToZero()
    {
        CallMethodVoid("roundToZero");
            
        return this;
    }
        
    public JsVector3 Negate()
    {
        CallMethodVoid("negate");
            
        return this;
    }
        
    public JsType Dot(JsType argV = null)
    {
        return CallMethod("dot", argV ?? new JsObject());
    }
        
    public JsType LengthSq()
    {
        return CallMethod("lengthSq");
    }
        
    public JsType Length()
    {
        return CallMethod("length");
    }
        
    public JsType ManhattanLength()
    {
        return CallMethod("manhattanLength");
    }
        
    public JsType Normalize()
    {
        return CallMethod("normalize");
    }
        
    public JsType SetLength(JsType argLength = null)
    {
        return CallMethod("setLength", argLength ?? new JsObject());
    }
        
    public JsVector3 Lerp(JsType argV = null, JsType argAlpha = null)
    {
        CallMethodVoid("lerp", argV ?? new JsObject(), argAlpha ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 LerpVectors(JsType argV1 = null, JsType argV2 = null, JsType argAlpha = null)
    {
        CallMethodVoid("lerpVectors", argV1 ?? new JsObject(), argV2 ?? new JsObject(), argAlpha ?? new JsObject());
            
        return this;
    }
        
    public JsType Cross(JsType argV = null, JsType argW = null)
    {
        return CallMethod("cross", argV ?? new JsObject(), argW ?? new JsObject());
    }
        
    public JsVector3 CrossVectors(JsType argA = null, JsType argB = null)
    {
        CallMethodVoid("crossVectors", argA ?? new JsObject(), argB ?? new JsObject());
            
        return this;
    }
        
    public JsType ProjectOnVector(JsType argV = null)
    {
        return CallMethod("projectOnVector", argV ?? new JsObject());
    }
        
    public JsType ProjectOnPlane(JsType argPlaneNormal = null)
    {
        return CallMethod("projectOnPlane", argPlaneNormal ?? new JsObject());
    }
        
    public JsType Reflect(JsType argNormal = null)
    {
        return CallMethod("reflect", argNormal ?? new JsObject());
    }
        
    public JsType AngleTo(JsType argV = null)
    {
        return CallMethod("angleTo", argV ?? new JsObject());
    }
        
    public JsType DistanceTo(JsType argV = null)
    {
        return CallMethod("distanceTo", argV ?? new JsObject());
    }
        
    public JsType DistanceToSquared(JsType argV = null)
    {
        return CallMethod("distanceToSquared", argV ?? new JsObject());
    }
        
    public JsType ManhattanDistanceTo(JsType argV = null)
    {
        return CallMethod("manhattanDistanceTo", argV ?? new JsObject());
    }
        
    public JsType SetFromSpherical(JsType argS = null)
    {
        return CallMethod("setFromSpherical", argS ?? new JsObject());
    }
        
    public JsVector3 SetFromSphericalCoords(JsType argRadius = null, JsType argPhi = null, JsType argTheta = null)
    {
        CallMethodVoid("setFromSphericalCoords", argRadius ?? new JsObject(), argPhi ?? new JsObject(), argTheta ?? new JsObject());
            
        return this;
    }
        
    public JsType SetFromCylindrical(JsType argC = null)
    {
        return CallMethod("setFromCylindrical", argC ?? new JsObject());
    }
        
    public JsVector3 SetFromCylindricalCoords(JsType argRadius = null, JsType argTheta = null, JsType argY = null)
    {
        CallMethodVoid("setFromCylindricalCoords", argRadius ?? new JsObject(), argTheta ?? new JsObject(), argY ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 SetFromMatrixPosition(JsType argM = null)
    {
        CallMethodVoid("setFromMatrixPosition", argM ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 SetFromMatrixScale(JsType argM = null)
    {
        CallMethodVoid("setFromMatrixScale", argM ?? new JsObject());
            
        return this;
    }
        
    public JsType SetFromMatrixColumn(JsType argM = null, JsType argIndex = null)
    {
        return CallMethod("setFromMatrixColumn", argM ?? new JsObject(), argIndex ?? new JsObject());
    }
        
    public JsType SetFromMatrix3Column(JsType argM = null, JsType argIndex = null)
    {
        return CallMethod("setFromMatrix3Column", argM ?? new JsObject(), argIndex ?? new JsObject());
    }
        
    public JsType Equals(JsType argV = null)
    {
        return CallMethod("equals", argV ?? new JsObject());
    }
        
    public JsVector3 FromArray(JsType argArray = null, JsNumber argOffset = null)
    {
        CallMethodVoid("fromArray", argArray ?? new JsObject(), argOffset ?? (0).AsJsNumber());
            
        return this;
    }
        
    public JsArray ToArray(JsArray argArray = null, JsNumber argOffset = null)
    {
        return CallMethod("toArray", argArray ?? new JsArray(), argOffset ?? (0).AsJsNumber());
    }
        
    public JsVector3 FromBufferAttribute(JsType argAttribute = null, JsType argIndex = null, JsType argOffset = null)
    {
        CallMethodVoid("fromBufferAttribute", argAttribute ?? new JsObject(), argIndex ?? new JsObject(), argOffset ?? new JsObject());
            
        return this;
    }
        
    public JsVector3 Random()
    {
        CallMethodVoid("random");
            
        return this;
    }
        
    public JsVector3 RandomDirection()
    {
        CallMethodVoid("randomDirection");
            
        return this;
    }
        
        
}