using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsMatrix3Constructor :
    JsTypeConstructor
{
        


    internal JsMatrix3Constructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.Matrix3()";
    }
}
    
public partial class JsMatrix3 :
    JsObjectType
{
    public static implicit operator JsMatrix3(string jsTextCode)
    {
        return new JsMatrix3(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsMatrix3 value)
    {
        return value.GetJsCode();
    }


    private readonly JsMatrix3 _jsVariableValue;
    public JsMatrix3 JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _elements;
    public JsType Elements
    {
        get => _elements ?? throw new InvalidOperationException();
        set
        {
            if (_elements is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.elements = {valueCode};");
        }
    }

    internal JsMatrix3(JsTypeConstructor jsCodeSource, JsMatrix3 jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _elements = $"{variableName}.elements".AsJsTypeVariable();
    }

    public JsMatrix3()
        : base(new JsMatrix3Constructor())
    {
    }

    public JsMatrix3 Set(JsType argN11 = null, JsType argN12 = null, JsType argN13 = null, JsType argN21 = null, JsType argN22 = null, JsType argN23 = null, JsType argN31 = null, JsType argN32 = null, JsType argN33 = null)
    {
        CallMethodVoid("set", argN11 ?? new JsObject(), argN12 ?? new JsObject(), argN13 ?? new JsObject(), argN21 ?? new JsObject(), argN22 ?? new JsObject(), argN23 ?? new JsObject(), argN31 ?? new JsObject(), argN32 ?? new JsObject(), argN33 ?? new JsObject());
            
        return this;
    }
        
    public JsMatrix3 Identity()
    {
        CallMethodVoid("identity");
            
        return this;
    }
        
    public JsMatrix3 Copy(JsType argM = null)
    {
        CallMethodVoid("copy", argM ?? new JsObject());
            
        return this;
    }
        
    public JsMatrix3 ExtractBasis(JsType argXAxis = null, JsType argYAxis = null, JsType argZAxis = null)
    {
        CallMethodVoid("extractBasis", argXAxis ?? new JsObject(), argYAxis ?? new JsObject(), argZAxis ?? new JsObject());
            
        return this;
    }
        
    public JsMatrix3 SetFromMatrix4(JsType argM = null)
    {
        CallMethodVoid("setFromMatrix4", argM ?? new JsObject());
            
        return this;
    }
        
    public JsType Multiply(JsType argM = null)
    {
        return CallMethod("multiply", argM ?? new JsObject());
    }
        
    public JsType Premultiply(JsType argM = null)
    {
        return CallMethod("premultiply", argM ?? new JsObject());
    }
        
    public JsMatrix3 MultiplyMatrices(JsType argA = null, JsType argB = null)
    {
        CallMethodVoid("multiplyMatrices", argA ?? new JsObject(), argB ?? new JsObject());
            
        return this;
    }
        
    public JsMatrix3 MultiplyScalar(JsType argS = null)
    {
        CallMethodVoid("multiplyScalar", argS ?? new JsObject());
            
        return this;
    }
        
    public JsType Determinant()
    {
        return CallMethod("determinant");
    }
        
    public JsMatrix3 Invert()
    {
        CallMethodVoid("invert");
            
        return this;
    }
        
    public JsMatrix3 Transpose()
    {
        CallMethodVoid("transpose");
            
        return this;
    }
        
    public JsType GetNormalMatrix(JsType argMatrix4 = null)
    {
        return CallMethod("getNormalMatrix", argMatrix4 ?? new JsObject());
    }
        
    public JsMatrix3 TransposeIntoArray(JsType argR = null)
    {
        CallMethodVoid("transposeIntoArray", argR ?? new JsObject());
            
        return this;
    }
        
    public JsMatrix3 SetUvTransform(JsType argTx = null, JsType argTy = null, JsType argSx = null, JsType argSy = null, JsType argRotation = null, JsType argCx = null, JsType argCy = null)
    {
        CallMethodVoid("setUvTransform", argTx ?? new JsObject(), argTy ?? new JsObject(), argSx ?? new JsObject(), argSy ?? new JsObject(), argRotation ?? new JsObject(), argCx ?? new JsObject(), argCy ?? new JsObject());
            
        return this;
    }
        
    public JsMatrix3 Scale(JsType argSx = null, JsType argSy = null)
    {
        CallMethodVoid("scale", argSx ?? new JsObject(), argSy ?? new JsObject());
            
        return this;
    }
        
    public JsMatrix3 Rotate(JsType argTheta = null)
    {
        CallMethodVoid("rotate", argTheta ?? new JsObject());
            
        return this;
    }
        
    public JsMatrix3 Translate(JsType argTx = null, JsType argTy = null)
    {
        CallMethodVoid("translate", argTx ?? new JsObject(), argTy ?? new JsObject());
            
        return this;
    }
        
    public JsType Equals(JsType argMatrix = null)
    {
        return CallMethod("equals", argMatrix ?? new JsObject());
    }
        
    public JsMatrix3 FromArray(JsType argArray = null, JsNumber argOffset = null)
    {
        CallMethodVoid("fromArray", argArray ?? new JsObject(), argOffset ?? (0).AsJsNumber());
            
        return this;
    }
        
    public JsArray ToArray(JsArray argArray = null, JsNumber argOffset = null)
    {
        return CallMethod("toArray", argArray ?? new JsArray(), argOffset ?? (0).AsJsNumber());
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
        
}