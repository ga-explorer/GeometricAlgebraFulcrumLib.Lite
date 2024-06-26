using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsColorConstructor :
    JsTypeConstructor
{
    public JsType R { get; }
        
    public JsType G { get; }
        
    public JsType B { get; }
        
        


    internal JsColorConstructor(JsType argR, JsType argG, JsType argB)
    {
        R = argR ?? new JsObject();
        G = argG ?? new JsObject();
        B = argB ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Color({R.GetJsCode()}, {G.GetJsCode()}, {B.GetJsCode()})";
    }
}
    
public partial class JsColor :
    JsObjectType
{
    public static implicit operator JsColor(string jsTextCode)
    {
        return new JsColor(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsColor value)
    {
        return value.GetJsCode();
    }


    private readonly JsColor _jsVariableValue;
    public JsColor JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _r;
    public JsType R
    {
        get => _r ?? throw new InvalidOperationException();
        set
        {
            if (_r is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.r = {valueCode};");
        }
    }
        
    private readonly JsType _g;
    public JsType G
    {
        get => _g ?? throw new InvalidOperationException();
        set
        {
            if (_g is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.g = {valueCode};");
        }
    }
        
    private readonly JsType _b;
    public JsType B
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

    internal JsColor(JsTypeConstructor jsCodeSource, JsColor jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _r = $"{variableName}.r".AsJsTypeVariable();
        _g = $"{variableName}.g".AsJsTypeVariable();
        _b = $"{variableName}.b".AsJsTypeVariable();
    }

    public JsColor(JsType argR = null, JsType argG = null, JsType argB = null)
        : base(new JsColorConstructor(argR, argG, argB))
    {
    }

    public JsColor Set(JsType argValue = null)
    {
        CallMethodVoid("set", argValue ?? new JsObject());
            
        return this;
    }
        
    public JsColor SetScalar(JsType argScalar = null)
    {
        CallMethodVoid("setScalar", argScalar ?? new JsObject());
            
        return this;
    }
        
    public JsColor SetHex(JsType argHex = null)
    {
        CallMethodVoid("setHex", argHex ?? new JsObject());
            
        return this;
    }
        
    public JsColor SetRGB(JsType argR = null, JsType argG = null, JsType argB = null)
    {
        CallMethodVoid("setRGB", argR ?? new JsObject(), argG ?? new JsObject(), argB ?? new JsObject());
            
        return this;
    }
        
    public JsColor SetHSL(JsType argH = null, JsType argS = null, JsType argL = null)
    {
        CallMethodVoid("setHSL", argH ?? new JsObject(), argS ?? new JsObject(), argL ?? new JsObject());
            
        return this;
    }
        
    public JsColor SetStyle(JsType argStyle = null)
    {
        CallMethodVoid("setStyle", argStyle ?? new JsObject());
            
        return this;
    }
        
    public JsColor SetColorName(JsType argStyle = null)
    {
        CallMethodVoid("setColorName", argStyle ?? new JsObject());
            
        return this;
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
    public JsColor Copy(JsType argColor = null)
    {
        CallMethodVoid("copy", argColor ?? new JsObject());
            
        return this;
    }
        
    public JsColor CopyGammaToLinear(JsType argColor = null, JsNumber argGammaFactor = null)
    {
        CallMethodVoid("copyGammaToLinear", argColor ?? new JsObject(), argGammaFactor ?? (2).AsJsNumber());
            
        return this;
    }
        
    public JsColor CopyLinearToGamma(JsType argColor = null, JsNumber argGammaFactor = null)
    {
        CallMethodVoid("copyLinearToGamma", argColor ?? new JsObject(), argGammaFactor ?? (2).AsJsNumber());
            
        return this;
    }
        
    public JsColor ConvertGammaToLinear(JsType argGammaFactor = null)
    {
        CallMethodVoid("convertGammaToLinear", argGammaFactor ?? new JsObject());
            
        return this;
    }
        
    public JsColor ConvertLinearToGamma(JsType argGammaFactor = null)
    {
        CallMethodVoid("convertLinearToGamma", argGammaFactor ?? new JsObject());
            
        return this;
    }
        
    public JsColor CopySRGBToLinear(JsType argColor = null)
    {
        CallMethodVoid("copySRGBToLinear", argColor ?? new JsObject());
            
        return this;
    }
        
    public JsColor CopyLinearToSRGB(JsType argColor = null)
    {
        CallMethodVoid("copyLinearToSRGB", argColor ?? new JsObject());
            
        return this;
    }
        
    public JsColor ConvertSRGBToLinear()
    {
        CallMethodVoid("convertSRGBToLinear");
            
        return this;
    }
        
    public JsColor ConvertLinearToSRGB()
    {
        CallMethodVoid("convertLinearToSRGB");
            
        return this;
    }
        
    public JsType GetHex()
    {
        return CallMethod("getHex");
    }
        
    public JsType GetHexString()
    {
        return CallMethod("getHexString");
    }
        
    public JsType GetHSL(JsType argTarget = null)
    {
        return CallMethod("getHSL", argTarget ?? new JsObject());
    }
        
    public JsType GetStyle()
    {
        return CallMethod("getStyle");
    }
        
    public JsColor OffsetHSL(JsType argH = null, JsType argS = null, JsType argL = null)
    {
        CallMethodVoid("offsetHSL", argH ?? new JsObject(), argS ?? new JsObject(), argL ?? new JsObject());
            
        return this;
    }
        
    public JsColor Add(JsType argColor = null)
    {
        CallMethodVoid("add", argColor ?? new JsObject());
            
        return this;
    }
        
    public JsColor AddColors(JsType argColor1 = null, JsType argColor2 = null)
    {
        CallMethodVoid("addColors", argColor1 ?? new JsObject(), argColor2 ?? new JsObject());
            
        return this;
    }
        
    public JsColor AddScalar(JsType argS = null)
    {
        CallMethodVoid("addScalar", argS ?? new JsObject());
            
        return this;
    }
        
    public JsColor Sub(JsType argColor = null)
    {
        CallMethodVoid("sub", argColor ?? new JsObject());
            
        return this;
    }
        
    public JsColor Multiply(JsType argColor = null)
    {
        CallMethodVoid("multiply", argColor ?? new JsObject());
            
        return this;
    }
        
    public JsColor MultiplyScalar(JsType argS = null)
    {
        CallMethodVoid("multiplyScalar", argS ?? new JsObject());
            
        return this;
    }
        
    public JsColor Lerp(JsType argColor = null, JsType argAlpha = null)
    {
        CallMethodVoid("lerp", argColor ?? new JsObject(), argAlpha ?? new JsObject());
            
        return this;
    }
        
    public JsColor LerpColors(JsType argColor1 = null, JsType argColor2 = null, JsType argAlpha = null)
    {
        CallMethodVoid("lerpColors", argColor1 ?? new JsObject(), argColor2 ?? new JsObject(), argAlpha ?? new JsObject());
            
        return this;
    }
        
    public JsColor LerpHSL(JsType argColor = null, JsType argAlpha = null)
    {
        CallMethodVoid("lerpHSL", argColor ?? new JsObject(), argAlpha ?? new JsObject());
            
        return this;
    }
        
    public JsType Equals(JsType argC = null)
    {
        return CallMethod("equals", argC ?? new JsObject());
    }
        
    public JsColor FromArray(JsType argArray = null, JsNumber argOffset = null)
    {
        CallMethodVoid("fromArray", argArray ?? new JsObject(), argOffset ?? (0).AsJsNumber());
            
        return this;
    }
        
    public JsArray ToArray(JsArray argArray = null, JsNumber argOffset = null)
    {
        return CallMethod("toArray", argArray ?? new JsArray(), argOffset ?? (0).AsJsNumber());
    }
        
    public JsColor FromBufferAttribute(JsType argAttribute = null, JsType argIndex = null)
    {
        CallMethodVoid("fromBufferAttribute", argAttribute ?? new JsObject(), argIndex ?? new JsObject());
            
        return this;
    }
        
    public JsType ToJSON()
    {
        return CallMethod("toJSON");
    }
        
        
}