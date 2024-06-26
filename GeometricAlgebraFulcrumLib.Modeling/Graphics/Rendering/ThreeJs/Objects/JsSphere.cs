using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsSphereConstructor :
    JsTypeConstructor
{
    public JsVector3 Center { get; }
        
    public JsNumber Radius { get; }
        
        


    internal JsSphereConstructor(JsVector3 argCenter, JsNumber argRadius)
    {
        Center = argCenter ?? new JsVector3();
        Radius = argRadius ?? (-1).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Sphere({Center.GetJsCode()}, {Radius.GetJsCode()})";
    }
}
    
public partial class JsSphere :
    JsObjectType
{
    public static implicit operator JsSphere(string jsTextCode)
    {
        return new JsSphere(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsSphere value)
    {
        return value.GetJsCode();
    }


    private readonly JsSphere _jsVariableValue;
    public JsSphere JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsVector3 _center;
    public JsVector3 Center
    {
        get => _center ?? throw new InvalidOperationException();
        set
        {
            if (_center is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.center = {valueCode};");
        }
    }
        
    private readonly JsNumber _radius;
    public JsNumber Radius
    {
        get => _radius ?? throw new InvalidOperationException();
        set
        {
            if (_radius is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "-1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.radius = {valueCode};");
        }
    }

    internal JsSphere(JsTypeConstructor jsCodeSource, JsSphere jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _center = $"{variableName}.center".AsJsVector3Variable();
        _radius = $"{variableName}.radius".AsJsNumberVariable();
    }

    public JsSphere(JsVector3 argCenter = null, JsNumber argRadius = null)
        : base(new JsSphereConstructor(argCenter, argRadius))
    {
    }

    public JsSphere Set(JsType argCenter = null, JsType argRadius = null)
    {
        CallMethodVoid("set", argCenter ?? new JsObject(), argRadius ?? new JsObject());
            
        return this;
    }
        
    public JsSphere SetFromPoints(JsType argPoints = null, JsType argOptionalCenter = null)
    {
        CallMethodVoid("setFromPoints", argPoints ?? new JsObject(), argOptionalCenter ?? new JsObject());
            
        return this;
    }
        
    public JsSphere Copy(JsType argSphere = null)
    {
        CallMethodVoid("copy", argSphere ?? new JsObject());
            
        return this;
    }
        
    public JsType IsEmpty()
    {
        return CallMethod("isEmpty");
    }
        
    public JsSphere MakeEmpty()
    {
        CallMethodVoid("makeEmpty");
            
        return this;
    }
        
    public JsType ContainsPoint(JsType argPoint = null)
    {
        return CallMethod("containsPoint", argPoint ?? new JsObject());
    }
        
    public JsType DistanceToPoint(JsType argPoint = null)
    {
        return CallMethod("distanceToPoint", argPoint ?? new JsObject());
    }
        
    public JsType IntersectsSphere(JsType argSphere = null)
    {
        return CallMethod("intersectsSphere", argSphere ?? new JsObject());
    }
        
    public JsType IntersectsBox(JsType argBox = null)
    {
        return CallMethod("intersectsBox", argBox ?? new JsObject());
    }
        
    public JsType IntersectsPlane(JsType argPlane = null)
    {
        return CallMethod("intersectsPlane", argPlane ?? new JsObject());
    }
        
    public JsType ClampPoint(JsType argPoint = null, JsType argTarget = null)
    {
        return CallMethod("clampPoint", argPoint ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsType GetBoundingBox(JsType argTarget = null)
    {
        return CallMethod("getBoundingBox", argTarget ?? new JsObject());
    }
        
    public JsSphere ApplyMatrix4(JsType argMatrix = null)
    {
        CallMethodVoid("applyMatrix4", argMatrix ?? new JsObject());
            
        return this;
    }
        
    public JsSphere Translate(JsType argOffset = null)
    {
        CallMethodVoid("translate", argOffset ?? new JsObject());
            
        return this;
    }
        
    public JsSphere ExpandByPoint(JsType argPoint = null)
    {
        CallMethodVoid("expandByPoint", argPoint ?? new JsObject());
            
        return this;
    }
        
    public JsSphere Union(JsType argSphere = null)
    {
        CallMethodVoid("union", argSphere ?? new JsObject());
            
        return this;
    }
        
    public JsType Equals(JsType argSphere = null)
    {
        return CallMethod("equals", argSphere ?? new JsObject());
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
        
}