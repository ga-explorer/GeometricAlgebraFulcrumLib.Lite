using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsSphericalHarmonics3Constructor :
    JsTypeConstructor
{
        


    internal JsSphericalHarmonics3Constructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.SphericalHarmonics3()";
    }
}
    
public partial class JsSphericalHarmonics3 :
    JsObjectType
{
    public static implicit operator JsSphericalHarmonics3(string jsTextCode)
    {
        return new JsSphericalHarmonics3(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsSphericalHarmonics3 value)
    {
        return value.GetJsCode();
    }


    private readonly JsSphericalHarmonics3 _jsVariableValue;
    public JsSphericalHarmonics3 JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _coefficients;
    public JsType Coefficients
    {
        get => _coefficients ?? throw new InvalidOperationException();
        set
        {
            if (_coefficients is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.coefficients = {valueCode};");
        }
    }

    internal JsSphericalHarmonics3(JsTypeConstructor jsCodeSource, JsSphericalHarmonics3 jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _coefficients = $"{variableName}.coefficients".AsJsTypeVariable();
    }

    public JsSphericalHarmonics3()
        : base(new JsSphericalHarmonics3Constructor())
    {
    }

    public JsSphericalHarmonics3 Set(JsType argCoefficients = null)
    {
        CallMethodVoid("set", argCoefficients ?? new JsObject());
            
        return this;
    }
        
    public JsSphericalHarmonics3 Zero()
    {
        CallMethodVoid("zero");
            
        return this;
    }
        
    public JsType GetAt(JsType argNormal = null, JsType argTarget = null)
    {
        return CallMethod("getAt", argNormal ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsType GetIrradianceAt(JsType argNormal = null, JsType argTarget = null)
    {
        return CallMethod("getIrradianceAt", argNormal ?? new JsObject(), argTarget ?? new JsObject());
    }
        
    public JsSphericalHarmonics3 Add(JsType argSh = null)
    {
        CallMethodVoid("add", argSh ?? new JsObject());
            
        return this;
    }
        
    public JsSphericalHarmonics3 AddScaledSH(JsType argSh = null, JsType argS = null)
    {
        CallMethodVoid("addScaledSH", argSh ?? new JsObject(), argS ?? new JsObject());
            
        return this;
    }
        
    public JsSphericalHarmonics3 Scale(JsType argS = null)
    {
        CallMethodVoid("scale", argS ?? new JsObject());
            
        return this;
    }
        
    public JsSphericalHarmonics3 Lerp(JsType argSh = null, JsType argAlpha = null)
    {
        CallMethodVoid("lerp", argSh ?? new JsObject(), argAlpha ?? new JsObject());
            
        return this;
    }
        
    public JsType Equals(JsType argSh = null)
    {
        return CallMethod("equals", argSh ?? new JsObject());
    }
        
    public JsType Copy(JsType argSh = null)
    {
        return CallMethod("copy", argSh ?? new JsObject());
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsSphericalHarmonics3 FromArray(JsType argArray = null, JsNumber argOffset = null)
    {
        CallMethodVoid("fromArray", argArray ?? new JsObject(), argOffset ?? (0).AsJsNumber());
            
        return this;
    }
        
    public JsArray ToArray(JsArray argArray = null, JsNumber argOffset = null)
    {
        return CallMethod("toArray", argArray ?? new JsArray(), argOffset ?? (0).AsJsNumber());
    }
        
        
}