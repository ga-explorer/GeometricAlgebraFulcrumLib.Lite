namespace GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

public class JsBoolean :
    JsPrimitiveType
{
    public sealed class JsBooleanConstructor :
        JsTypeConstructor
    {
        public bool LiteralValue { get; }


        internal JsBooleanConstructor(bool literalValue)
        {
            LiteralValue = literalValue;
        }


        public override string GetJsCode()
        {
            return LiteralValue ? "true" : "false";
        }

        public override string ToString()
        {
            return LiteralValue ? "true" : "false";
        }
    }


    public static implicit operator JsBoolean(string jsTextCode)
    {
        return jsTextCode.ToLower() switch
        {
            "true" => new JsBoolean(true),
            "false" => new JsBoolean(false),
            _ => new JsBoolean(new JsTextCodeConstructor(jsTextCode))
        };
    }

    public static implicit operator string(JsBoolean value)
    {
        return value.GetJsCode();
    }

    public static implicit operator JsBoolean(bool value)
    {
        return new JsBoolean(value);
    }


    private readonly JsBoolean _jsVariableValue;
    public JsBoolean JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public bool? CsValue
        => TypeConstructor is JsBooleanConstructor booleanSource
            ? booleanSource.LiteralValue : null;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;


    internal JsBoolean(JsTypeConstructor jsCodeSource, JsBoolean jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
    }

    public JsBoolean(bool value)
        : base(new JsBooleanConstructor(value))
    {
    }


    public override string GetCsCode()
    {
        if (TypeConstructor is not JsBooleanConstructor booleanSource) 
            return TypeConstructor.GetJsCode().ValueToQuotedLiteral();
            
        return booleanSource.LiteralValue ? "true" : "false";
    }
}