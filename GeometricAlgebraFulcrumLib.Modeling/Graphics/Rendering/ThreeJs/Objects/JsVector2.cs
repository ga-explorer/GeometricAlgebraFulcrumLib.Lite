using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsVector2Constructor :
    JsTypeConstructor
{
    public JsNumber X { get; }
        
    public JsNumber Y { get; }
        
        


    internal JsVector2Constructor(JsNumber argX, JsNumber argY)
    {
        X = argX ?? (0).AsJsNumber();
        Y = argY ?? (0).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Vector2({X.GetJsCode()}, {Y.GetJsCode()})";
    }
}
    
public partial class JsVector2 :
    JsObjectType
{
    public static implicit operator JsVector2(string jsTextCode)
    {
        return new JsVector2(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsVector2 value)
    {
        return value.GetJsCode();
    }


    private readonly JsVector2 _jsVariableValue;
    public JsVector2 JsValue 
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
        
    private readonly JsType _width;
    public JsType Width
    {
        get => _width ?? throw new InvalidOperationException();
        set
        {
            if (_width is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.width = {valueCode};");
        }
    }
        
    private readonly JsType _height;
    public JsType Height
    {
        get => _height ?? throw new InvalidOperationException();
        set
        {
            if (_height is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.height = {valueCode};");
        }
    }

    internal JsVector2(JsTypeConstructor jsCodeSource, JsVector2 jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _x = $"{variableName}.x".AsJsNumberVariable();
        _y = $"{variableName}.y".AsJsNumberVariable();
        _width = $"{variableName}.width".AsJsTypeVariable();
        _height = $"{variableName}.height".AsJsTypeVariable();
    }

    public JsVector2(JsNumber argX = null, JsNumber argY = null)
        : base(new JsVector2Constructor(argX, argY))
    {
    }

    public JsVector2 Set(JsType argX = null, JsType argY = null)
    {
        CallMethodVoid("set", argX ?? new JsObject(), argY ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 SetScalar(JsType argScalar = null)
    {
        CallMethodVoid("setScalar", argScalar ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 SetX(JsType argX = null)
    {
        CallMethodVoid("setX", argX ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 SetY(JsType argY = null)
    {
        CallMethodVoid("setY", argY ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 SetComponent(JsType argIndex = null, JsType argValue = null)
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
        
    public JsVector2 Copy(JsType argV = null)
    {
        CallMethodVoid("copy", argV ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 Add(JsType argV = null, JsType argW = null)
    {
        CallMethodVoid("add", argV ?? new JsObject(), argW ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 AddScalar(JsType argS = null)
    {
        CallMethodVoid("addScalar", argS ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 AddVectors(JsType argA = null, JsType argB = null)
    {
        CallMethodVoid("addVectors", argA ?? new JsObject(), argB ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 AddScaledVector(JsType argV = null, JsType argS = null)
    {
        CallMethodVoid("addScaledVector", argV ?? new JsObject(), argS ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 Sub(JsType argV = null, JsType argW = null)
    {
        CallMethodVoid("sub", argV ?? new JsObject(), argW ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 SubScalar(JsType argS = null)
    {
        CallMethodVoid("subScalar", argS ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 SubVectors(JsType argA = null, JsType argB = null)
    {
        CallMethodVoid("subVectors", argA ?? new JsObject(), argB ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 Multiply(JsType argV = null)
    {
        CallMethodVoid("multiply", argV ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 MultiplyScalar(JsType argScalar = null)
    {
        CallMethodVoid("multiplyScalar", argScalar ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 Divide(JsType argV = null)
    {
        CallMethodVoid("divide", argV ?? new JsObject());
            
        return this;
    }
        
    public JsType DivideScalar(JsType argScalar = null)
    {
        return CallMethod("divideScalar", argScalar ?? new JsObject());
    }
        
    public JsVector2 ApplyMatrix3(JsType argM = null)
    {
        CallMethodVoid("applyMatrix3", argM ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 Min(JsType argV = null)
    {
        CallMethodVoid("min", argV ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 Max(JsType argV = null)
    {
        CallMethodVoid("max", argV ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 Clamp(JsType argMin = null, JsType argMax = null)
    {
        CallMethodVoid("clamp", argMin ?? new JsObject(), argMax ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 ClampScalar(JsType argMinVal = null, JsType argMaxVal = null)
    {
        CallMethodVoid("clampScalar", argMinVal ?? new JsObject(), argMaxVal ?? new JsObject());
            
        return this;
    }
        
    public JsType ClampLength(JsType argMin = null, JsType argMax = null)
    {
        return CallMethod("clampLength", argMin ?? new JsObject(), argMax ?? new JsObject());
    }
        
    public JsVector2 Floor()
    {
        CallMethodVoid("floor");
            
        return this;
    }
        
    public JsVector2 Ceil()
    {
        CallMethodVoid("ceil");
            
        return this;
    }
        
    public JsVector2 Round()
    {
        CallMethodVoid("round");
            
        return this;
    }
        
    public JsVector2 RoundToZero()
    {
        CallMethodVoid("roundToZero");
            
        return this;
    }
        
    public JsVector2 Negate()
    {
        CallMethodVoid("negate");
            
        return this;
    }
        
    public JsType Dot(JsType argV = null)
    {
        return CallMethod("dot", argV ?? new JsObject());
    }
        
    public JsType Cross(JsType argV = null)
    {
        return CallMethod("cross", argV ?? new JsObject());
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
        
    public JsType Angle()
    {
        return CallMethod("angle");
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
        
    public JsType SetLength(JsType argLength = null)
    {
        return CallMethod("setLength", argLength ?? new JsObject());
    }
        
    public JsVector2 Lerp(JsType argV = null, JsType argAlpha = null)
    {
        CallMethodVoid("lerp", argV ?? new JsObject(), argAlpha ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 LerpVectors(JsType argV1 = null, JsType argV2 = null, JsType argAlpha = null)
    {
        CallMethodVoid("lerpVectors", argV1 ?? new JsObject(), argV2 ?? new JsObject(), argAlpha ?? new JsObject());
            
        return this;
    }
        
    public JsType Equals(JsType argV = null)
    {
        return CallMethod("equals", argV ?? new JsObject());
    }
        
    public JsVector2 FromArray(JsType argArray = null, JsNumber argOffset = null)
    {
        CallMethodVoid("fromArray", argArray ?? new JsObject(), argOffset ?? (0).AsJsNumber());
            
        return this;
    }
        
    public JsArray ToArray(JsArray argArray = null, JsNumber argOffset = null)
    {
        return CallMethod("toArray", argArray ?? new JsArray(), argOffset ?? (0).AsJsNumber());
    }
        
    public JsVector2 FromBufferAttribute(JsType argAttribute = null, JsType argIndex = null, JsType argOffset = null)
    {
        CallMethodVoid("fromBufferAttribute", argAttribute ?? new JsObject(), argIndex ?? new JsObject(), argOffset ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 RotateAround(JsType argCenter = null, JsType argAngle = null)
    {
        CallMethodVoid("rotateAround", argCenter ?? new JsObject(), argAngle ?? new JsObject());
            
        return this;
    }
        
    public JsVector2 Random()
    {
        CallMethodVoid("random");
            
        return this;
    }
        
        
}