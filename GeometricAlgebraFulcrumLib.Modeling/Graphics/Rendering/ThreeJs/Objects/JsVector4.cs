using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsVector4Constructor :
    JsTypeConstructor
{
    public JsNumber X { get; }
        
    public JsNumber Y { get; }
        
    public JsNumber Z { get; }
        
    public JsNumber W { get; }
        
        


    internal JsVector4Constructor(JsNumber argX, JsNumber argY, JsNumber argZ, JsNumber argW)
    {
        X = argX ?? (0).AsJsNumber();
        Y = argY ?? (0).AsJsNumber();
        Z = argZ ?? (0).AsJsNumber();
        W = argW ?? (1).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Vector4({X.GetJsCode()}, {Y.GetJsCode()}, {Z.GetJsCode()}, {W.GetJsCode()})";
    }
}
    
public partial class JsVector4 :
    JsObjectType
{
    public static implicit operator JsVector4(string jsTextCode)
    {
        return new JsVector4(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsVector4 value)
    {
        return value.GetJsCode();
    }


    private readonly JsVector4 _jsVariableValue;
    public JsVector4 JsValue 
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
        
    private readonly JsNumber _w;
    public JsNumber W
    {
        get => _w ?? throw new InvalidOperationException();
        set
        {
            if (_w is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.w = {valueCode};");
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

    internal JsVector4(JsTypeConstructor jsCodeSource, JsVector4 jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _x = $"{variableName}.x".AsJsNumberVariable();
        _y = $"{variableName}.y".AsJsNumberVariable();
        _z = $"{variableName}.z".AsJsNumberVariable();
        _w = $"{variableName}.w".AsJsNumberVariable();
        _width = $"{variableName}.width".AsJsTypeVariable();
        _height = $"{variableName}.height".AsJsTypeVariable();
    }

    public JsVector4(JsNumber argX = null, JsNumber argY = null, JsNumber argZ = null, JsNumber argW = null)
        : base(new JsVector4Constructor(argX, argY, argZ, argW))
    {
    }

    public JsVector4 Set(JsType argX = null, JsType argY = null, JsType argZ = null, JsType argW = null)
    {
        CallMethodVoid("set", argX ?? new JsObject(), argY ?? new JsObject(), argZ ?? new JsObject(), argW ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 SetScalar(JsType argScalar = null)
    {
        CallMethodVoid("setScalar", argScalar ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 SetX(JsType argX = null)
    {
        CallMethodVoid("setX", argX ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 SetY(JsType argY = null)
    {
        CallMethodVoid("setY", argY ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 SetZ(JsType argZ = null)
    {
        CallMethodVoid("setZ", argZ ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 SetW(JsType argW = null)
    {
        CallMethodVoid("setW", argW ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 SetComponent(JsType argIndex = null, JsType argValue = null)
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
        
    public JsVector4 Copy(JsType argV = null)
    {
        CallMethodVoid("copy", argV ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 Add(JsType argV = null, JsType argW = null)
    {
        CallMethodVoid("add", argV ?? new JsObject(), argW ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 AddScalar(JsType argS = null)
    {
        CallMethodVoid("addScalar", argS ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 AddVectors(JsType argA = null, JsType argB = null)
    {
        CallMethodVoid("addVectors", argA ?? new JsObject(), argB ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 AddScaledVector(JsType argV = null, JsType argS = null)
    {
        CallMethodVoid("addScaledVector", argV ?? new JsObject(), argS ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 Sub(JsType argV = null, JsType argW = null)
    {
        CallMethodVoid("sub", argV ?? new JsObject(), argW ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 SubScalar(JsType argS = null)
    {
        CallMethodVoid("subScalar", argS ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 SubVectors(JsType argA = null, JsType argB = null)
    {
        CallMethodVoid("subVectors", argA ?? new JsObject(), argB ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 Multiply(JsType argV = null)
    {
        CallMethodVoid("multiply", argV ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 MultiplyScalar(JsType argScalar = null)
    {
        CallMethodVoid("multiplyScalar", argScalar ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 ApplyMatrix4(JsType argM = null)
    {
        CallMethodVoid("applyMatrix4", argM ?? new JsObject());
            
        return this;
    }
        
    public JsType DivideScalar(JsType argScalar = null)
    {
        return CallMethod("divideScalar", argScalar ?? new JsObject());
    }
        
    public JsVector4 SetAxisAngleFromQuaternion(JsType argQ = null)
    {
        CallMethodVoid("setAxisAngleFromQuaternion", argQ ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 SetAxisAngleFromRotationMatrix(JsType argM = null)
    {
        CallMethodVoid("setAxisAngleFromRotationMatrix", argM ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 Min(JsType argV = null)
    {
        CallMethodVoid("min", argV ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 Max(JsType argV = null)
    {
        CallMethodVoid("max", argV ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 Clamp(JsType argMin = null, JsType argMax = null)
    {
        CallMethodVoid("clamp", argMin ?? new JsObject(), argMax ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 ClampScalar(JsType argMinVal = null, JsType argMaxVal = null)
    {
        CallMethodVoid("clampScalar", argMinVal ?? new JsObject(), argMaxVal ?? new JsObject());
            
        return this;
    }
        
    public JsType ClampLength(JsType argMin = null, JsType argMax = null)
    {
        return CallMethod("clampLength", argMin ?? new JsObject(), argMax ?? new JsObject());
    }
        
    public JsVector4 Floor()
    {
        CallMethodVoid("floor");
            
        return this;
    }
        
    public JsVector4 Ceil()
    {
        CallMethodVoid("ceil");
            
        return this;
    }
        
    public JsVector4 Round()
    {
        CallMethodVoid("round");
            
        return this;
    }
        
    public JsVector4 RoundToZero()
    {
        CallMethodVoid("roundToZero");
            
        return this;
    }
        
    public JsVector4 Negate()
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
        
    public JsVector4 Lerp(JsType argV = null, JsType argAlpha = null)
    {
        CallMethodVoid("lerp", argV ?? new JsObject(), argAlpha ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 LerpVectors(JsType argV1 = null, JsType argV2 = null, JsType argAlpha = null)
    {
        CallMethodVoid("lerpVectors", argV1 ?? new JsObject(), argV2 ?? new JsObject(), argAlpha ?? new JsObject());
            
        return this;
    }
        
    public JsType Equals(JsType argV = null)
    {
        return CallMethod("equals", argV ?? new JsObject());
    }
        
    public JsVector4 FromArray(JsType argArray = null, JsNumber argOffset = null)
    {
        CallMethodVoid("fromArray", argArray ?? new JsObject(), argOffset ?? (0).AsJsNumber());
            
        return this;
    }
        
    public JsArray ToArray(JsArray argArray = null, JsNumber argOffset = null)
    {
        return CallMethod("toArray", argArray ?? new JsArray(), argOffset ?? (0).AsJsNumber());
    }
        
    public JsVector4 FromBufferAttribute(JsType argAttribute = null, JsType argIndex = null, JsType argOffset = null)
    {
        CallMethodVoid("fromBufferAttribute", argAttribute ?? new JsObject(), argIndex ?? new JsObject(), argOffset ?? new JsObject());
            
        return this;
    }
        
    public JsVector4 Random()
    {
        CallMethodVoid("random");
            
        return this;
    }
        
        
}