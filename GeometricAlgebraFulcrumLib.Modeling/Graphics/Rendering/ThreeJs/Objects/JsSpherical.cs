using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsSphericalConstructor :
    JsTypeConstructor
{
    public JsNumber Radius { get; }
        
    public JsNumber Phi { get; }
        
    public JsNumber Theta { get; }
        
        


    internal JsSphericalConstructor(JsNumber argRadius, JsNumber argPhi, JsNumber argTheta)
    {
        Radius = argRadius ?? (1).AsJsNumber();
        Phi = argPhi ?? (0).AsJsNumber();
        Theta = argTheta ?? (0).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Spherical({Radius.GetJsCode()}, {Phi.GetJsCode()}, {Theta.GetJsCode()})";
    }
}
    
public partial class JsSpherical :
    JsObjectType
{
    public static implicit operator JsSpherical(string jsTextCode)
    {
        return new JsSpherical(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsSpherical value)
    {
        return value.GetJsCode();
    }


    private readonly JsSpherical _jsVariableValue;
    public JsSpherical JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsNumber _radius;
    public JsNumber Radius
    {
        get => _radius ?? throw new InvalidOperationException();
        set
        {
            if (_radius is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.radius = {valueCode};");
        }
    }
        
    private readonly JsNumber _phi;
    public JsNumber Phi
    {
        get => _phi ?? throw new InvalidOperationException();
        set
        {
            if (_phi is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.phi = {valueCode};");
        }
    }
        
    private readonly JsNumber _theta;
    public JsNumber Theta
    {
        get => _theta ?? throw new InvalidOperationException();
        set
        {
            if (_theta is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.theta = {valueCode};");
        }
    }

    internal JsSpherical(JsTypeConstructor jsCodeSource, JsSpherical jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _radius = $"{variableName}.radius".AsJsNumberVariable();
        _phi = $"{variableName}.phi".AsJsNumberVariable();
        _theta = $"{variableName}.theta".AsJsNumberVariable();
    }

    public JsSpherical(JsNumber argRadius = null, JsNumber argPhi = null, JsNumber argTheta = null)
        : base(new JsSphericalConstructor(argRadius, argPhi, argTheta))
    {
    }

    public JsSpherical Set(JsType argRadius = null, JsType argPhi = null, JsType argTheta = null)
    {
        CallMethodVoid("set", argRadius ?? new JsObject(), argPhi ?? new JsObject(), argTheta ?? new JsObject());
            
        return this;
    }
        
    public JsSpherical Copy(JsType argOther = null)
    {
        CallMethodVoid("copy", argOther ?? new JsObject());
            
        return this;
    }
        
    public JsSpherical MakeSafe()
    {
        CallMethodVoid("makeSafe");
            
        return this;
    }
        
    public JsType SetFromVector3(JsType argV = null)
    {
        return CallMethod("setFromVector3", argV ?? new JsObject());
    }
        
    public JsSpherical SetFromCartesianCoords(JsType argX = null, JsType argY = null, JsType argZ = null)
    {
        CallMethodVoid("setFromCartesianCoords", argX ?? new JsObject(), argY ?? new JsObject(), argZ ?? new JsObject());
            
        return this;
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
        
}