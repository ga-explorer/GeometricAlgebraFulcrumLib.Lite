using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsTriangleConstructor :
    JsTypeConstructor
{
    public JsVector3 A { get; }
        
    public JsVector3 B { get; }
        
    public JsVector3 C { get; }
        
        


    internal JsTriangleConstructor(JsVector3 argA, JsVector3 argB, JsVector3 argC)
    {
        A = argA ?? new JsVector3();
        B = argB ?? new JsVector3();
        C = argC ?? new JsVector3();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Triangle({A.GetJsCode()}, {B.GetJsCode()}, {C.GetJsCode()})";
    }
}
    
public partial class JsTriangle :
    JsObjectType
{
    public static implicit operator JsTriangle(string jsTextCode)
    {
        return new JsTriangle(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsTriangle value)
    {
        return value.GetJsCode();
    }


    private readonly JsTriangle _jsVariableValue;
    public JsTriangle JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsVector3 _a;
    public JsVector3 A
    {
        get => _a ?? throw new InvalidOperationException();
        set
        {
            if (_a is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.a = {valueCode};");
        }
    }
        
    private readonly JsVector3 _b;
    public JsVector3 B
    {
        get => _b ?? throw new InvalidOperationException();
        set
        {
            if (_b is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.b = {valueCode};");
        }
    }
        
    private readonly JsVector3 _c;
    public JsVector3 C
    {
        get => _c ?? throw new InvalidOperationException();
        set
        {
            if (_c is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.c = {valueCode};");
        }
    }

    internal JsTriangle(JsTypeConstructor jsCodeSource, JsTriangle jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _a = $"{variableName}.a".AsJsVector3Variable();
        _b = $"{variableName}.b".AsJsVector3Variable();
        _c = $"{variableName}.c".AsJsVector3Variable();
    }

    public JsTriangle(JsVector3 argA = null, JsVector3 argB = null, JsVector3 argC = null)
        : base(new JsTriangleConstructor(argA, argB, argC))
    {
    }

    public JsTriangle Set(JsType argA = null, JsType argB = null, JsType argC = null)
    {
        CallMethodVoid("set", argA ?? new JsObject(), argB ?? new JsObject(), argC ?? new JsObject());
            
        return this;
    }
        
    public JsTriangle SetFromPointsAndIndices(JsType argPoints = null, JsType argI0 = null, JsType argI1 = null, JsType argI2 = null)
    {
        CallMethodVoid("setFromPointsAndIndices", argPoints ?? new JsObject(), argI0 ?? new JsObject(), argI1 ?? new JsObject(), argI2 ?? new JsObject());
            
        return this;
    }
        
    public JsTriangle SetFromAttributeAndIndices(JsType argAttribute = null, JsType argI0 = null, JsType argI1 = null, JsType argI2 = null)
    {
        CallMethodVoid("setFromAttributeAndIndices", argAttribute ?? new JsObject(), argI0 ?? new JsObject(), argI1 ?? new JsObject(), argI2 ?? new JsObject());
            
        return this;
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsTriangle Copy(JsType argTriangle = null)
    {
        CallMethodVoid("copy", argTriangle ?? new JsObject());
            
        return this;
    }
        
    public JsType GetArea()
    {
        return CallMethod("getArea");
    }
        
    public JsType GetMidpoint(JsType argTarget = null)
    {
        return CallMethod("getMidpoint", argTarget ?? new JsObject());
    }
        
    public JsType GetNormal(JsType argTarget = null)
    {
        return CallMethod("getNormal", argTarget ?? new JsObject());
    }
        
    public JsType GetPlane(JsType argTarget = null)
    {
        return CallMethod("getPlane", argTarget ?? new JsObject());
    }
        
    public JsType GetBarycoord(JsType argPoint = null, JsType argTarget = null)
    {
        return CallMethod("getBarycoord", argPoint ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsType GetUV(JsType argPoint = null, JsType argUv1 = null, JsType argUv2 = null, JsType argUv3 = null, JsType argTarget = null)
    {
        return CallMethod("getUV", argPoint ?? new JsObject(), argUv1 ?? new JsObject(), argUv2 ?? new JsObject(), argUv3 ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsType ContainsPoint(JsType argPoint = null)
    {
        return CallMethod("containsPoint", argPoint ?? new JsObject());
    }
        
    public JsType IsFrontFacing(JsType argDirection = null)
    {
        return CallMethod("isFrontFacing", argDirection ?? new JsObject());
    }
        
    public JsType IntersectsBox(JsType argBox = null)
    {
        return CallMethod("intersectsBox", argBox ?? new JsObject());
    }
        
    public JsType ClosestPointToPoint(JsType argP = null, JsType argTarget = null)
    {
        return CallMethod("closestPointToPoint", argP ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsType Equals(JsType argTriangle = null)
    {
        return CallMethod("equals", argTriangle ?? new JsObject());
    }
        
        
}