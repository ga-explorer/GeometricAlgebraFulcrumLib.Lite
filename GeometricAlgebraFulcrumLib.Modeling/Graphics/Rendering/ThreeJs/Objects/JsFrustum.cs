using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsFrustumConstructor :
    JsTypeConstructor
{
    public JsPlane P0 { get; }
        
    public JsPlane P1 { get; }
        
    public JsPlane P2 { get; }
        
    public JsPlane P3 { get; }
        
    public JsPlane P4 { get; }
        
    public JsPlane P5 { get; }
        
        


    internal JsFrustumConstructor(JsPlane argP0, JsPlane argP1, JsPlane argP2, JsPlane argP3, JsPlane argP4, JsPlane argP5)
    {
        P0 = argP0 ?? new JsPlane();
        P1 = argP1 ?? new JsPlane();
        P2 = argP2 ?? new JsPlane();
        P3 = argP3 ?? new JsPlane();
        P4 = argP4 ?? new JsPlane();
        P5 = argP5 ?? new JsPlane();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Frustum({P0.GetJsCode()}, {P1.GetJsCode()}, {P2.GetJsCode()}, {P3.GetJsCode()}, {P4.GetJsCode()}, {P5.GetJsCode()})";
    }
}
    
public partial class JsFrustum :
    JsObjectType
{
    public static implicit operator JsFrustum(string jsTextCode)
    {
        return new JsFrustum(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsFrustum value)
    {
        return value.GetJsCode();
    }


    private readonly JsFrustum _jsVariableValue;
    public JsFrustum JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _planes;
    public JsType Planes
    {
        get => _planes ?? throw new InvalidOperationException();
        set
        {
            if (_planes is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.planes = {valueCode};");
        }
    }

    internal JsFrustum(JsTypeConstructor jsCodeSource, JsFrustum jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _planes = $"{variableName}.planes".AsJsTypeVariable();
    }

    public JsFrustum(JsPlane argP0 = null, JsPlane argP1 = null, JsPlane argP2 = null, JsPlane argP3 = null, JsPlane argP4 = null, JsPlane argP5 = null)
        : base(new JsFrustumConstructor(argP0, argP1, argP2, argP3, argP4, argP5))
    {
    }

    public JsFrustum Set(JsType argP0 = null, JsType argP1 = null, JsType argP2 = null, JsType argP3 = null, JsType argP4 = null, JsType argP5 = null)
    {
        CallMethodVoid("set", argP0 ?? new JsObject(), argP1 ?? new JsObject(), argP2 ?? new JsObject(), argP3 ?? new JsObject(), argP4 ?? new JsObject(), argP5 ?? new JsObject());
            
        return this;
    }
        
    public JsFrustum Copy(JsType argFrustum = null)
    {
        CallMethodVoid("copy", argFrustum ?? new JsObject());
            
        return this;
    }
        
    public JsFrustum SetFromProjectionMatrix(JsType argM = null)
    {
        CallMethodVoid("setFromProjectionMatrix", argM ?? new JsObject());
            
        return this;
    }
        
    public JsType IntersectsObject(JsType argObject = null)
    {
        return CallMethod("intersectsObject", argObject ?? new JsObject());
    }
        
    public JsType IntersectsSprite(JsType argSprite = null)
    {
        return CallMethod("intersectsSprite", argSprite ?? new JsObject());
    }
        
    public JsType IntersectsSphere(JsType argSphere = null)
    {
        return CallMethod("intersectsSphere", argSphere ?? new JsObject());
    }
        
    public JsType IntersectsBox(JsType argBox = null)
    {
        return CallMethod("intersectsBox", argBox ?? new JsObject());
    }
        
    public JsType ContainsPoint(JsType argPoint = null)
    {
        return CallMethod("containsPoint", argPoint ?? new JsObject());
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
        
}