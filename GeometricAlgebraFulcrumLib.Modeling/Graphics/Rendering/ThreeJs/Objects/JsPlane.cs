using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsPlaneConstructor :
    JsTypeConstructor
{
    public JsVector3 Normal { get; }
        
    public JsNumber Constant { get; }
        
        


    internal JsPlaneConstructor(JsVector3 argNormal, JsNumber argConstant)
    {
        Normal = argNormal ?? new JsVector3((1).AsJsNumber(), (0).AsJsNumber(), (0).AsJsNumber());
        Constant = argConstant ?? (0).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Plane({Normal.GetJsCode()}, {Constant.GetJsCode()})";
    }
}
    
public partial class JsPlane :
    JsObjectType
{
    public static implicit operator JsPlane(string jsTextCode)
    {
        return new JsPlane(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsPlane value)
    {
        return value.GetJsCode();
    }


    private readonly JsPlane _jsVariableValue;
    public JsPlane JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsVector3 _normal;
    public JsVector3 Normal
    {
        get => _normal ?? throw new InvalidOperationException();
        set
        {
            if (_normal is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.normal = {valueCode};");
        }
    }
        
    private readonly JsNumber _constant;
    public JsNumber Constant
    {
        get => _constant ?? throw new InvalidOperationException();
        set
        {
            if (_constant is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.constant = {valueCode};");
        }
    }

    internal JsPlane(JsTypeConstructor jsCodeSource, JsPlane jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _normal = $"{variableName}.normal".AsJsVector3Variable();
        _constant = $"{variableName}.constant".AsJsNumberVariable();
    }

    public JsPlane(JsVector3 argNormal = null, JsNumber argConstant = null)
        : base(new JsPlaneConstructor(argNormal, argConstant))
    {
    }

    public JsPlane Set(JsType argNormal = null, JsType argConstant = null)
    {
        CallMethodVoid("set", argNormal ?? new JsObject(), argConstant ?? new JsObject());
            
        return this;
    }
        
    public JsPlane SetComponents(JsType argX = null, JsType argY = null, JsType argZ = null, JsType argW = null)
    {
        CallMethodVoid("setComponents", argX ?? new JsObject(), argY ?? new JsObject(), argZ ?? new JsObject(), argW ?? new JsObject());
            
        return this;
    }
        
    public JsPlane SetFromNormalAndCoplanarPoint(JsType argNormal = null, JsType argPoint = null)
    {
        CallMethodVoid("setFromNormalAndCoplanarPoint", argNormal ?? new JsObject(), argPoint ?? new JsObject());
            
        return this;
    }
        
    public JsPlane SetFromCoplanarPoints(JsType argA = null, JsType argB = null, JsType argC = null)
    {
        CallMethodVoid("setFromCoplanarPoints", argA ?? new JsObject(), argB ?? new JsObject(), argC ?? new JsObject());
            
        return this;
    }
        
    public JsPlane Copy(JsType argPlane = null)
    {
        CallMethodVoid("copy", argPlane ?? new JsObject());
            
        return this;
    }
        
    public JsPlane Normalize()
    {
        CallMethodVoid("normalize");
            
        return this;
    }
        
    public JsPlane Negate()
    {
        CallMethodVoid("negate");
            
        return this;
    }
        
    public JsType DistanceToPoint(JsType argPoint = null)
    {
        return CallMethod("distanceToPoint", argPoint ?? new JsObject());
    }
        
    public JsType DistanceToSphere(JsType argSphere = null)
    {
        return CallMethod("distanceToSphere", argSphere ?? new JsObject());
    }
        
    public JsType ProjectPoint(JsType argPoint = null, JsType argTarget = null)
    {
        return CallMethod("projectPoint", argPoint ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsType IntersectLine(JsType argLine = null, JsType argTarget = null)
    {
        return CallMethod("intersectLine", argLine ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsType IntersectsLine(JsType argLine = null)
    {
        return CallMethod("intersectsLine", argLine ?? new JsObject());
    }
        
    public JsType IntersectsBox(JsType argBox = null)
    {
        return CallMethod("intersectsBox", argBox ?? new JsObject());
    }
        
    public JsType IntersectsSphere(JsType argSphere = null)
    {
        return CallMethod("intersectsSphere", argSphere ?? new JsObject());
    }
        
    public JsType CoplanarPoint(JsType argTarget = null)
    {
        return CallMethod("coplanarPoint", argTarget ?? new JsObject());
    }
        
    public JsPlane ApplyMatrix4(JsType argMatrix = null, JsType argOptionalNormalMatrix = null)
    {
        CallMethodVoid("applyMatrix4", argMatrix ?? new JsObject(), argOptionalNormalMatrix ?? new JsObject());
            
        return this;
    }
        
    public JsPlane Translate(JsType argOffset = null)
    {
        CallMethodVoid("translate", argOffset ?? new JsObject());
            
        return this;
    }
        
    public JsType Equals(JsType argPlane = null)
    {
        return CallMethod("equals", argPlane ?? new JsObject());
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
        
}