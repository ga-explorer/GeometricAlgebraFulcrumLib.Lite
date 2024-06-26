namespace GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

public sealed class JsNumber :
    JsPrimitiveType
{
    public sealed class JsTypeCodeSourceNumber :
        JsTypeConstructor
    {
        public double LiteralValue { get; }


        internal JsTypeCodeSourceNumber(double literalValue)
        {
            LiteralValue = literalValue;
        }


        public override string GetJsCode()
        {
            if (double.IsNaN(LiteralValue))
                return "NaN";

            if (double.IsPositiveInfinity(LiteralValue))
                return "Infinity";

            if (double.IsNegativeInfinity(LiteralValue))
                return "- Infinity";

            return LiteralValue.ToString("G");
        }
    }


    public static implicit operator JsNumber(string jsTextCode)
    {
        if (jsTextCode == "Infinity")
            return new JsNumber(double.PositiveInfinity);

        if (jsTextCode == "- Infinity")
            return new JsNumber(double.NegativeInfinity);

        if (jsTextCode == "-Infinity")
            return new JsNumber(double.NegativeInfinity);

        if (jsTextCode == "NaN")
            return new JsNumber(double.NaN);

        return double.TryParse(jsTextCode, out var number) 
            ? new JsNumber(number)
            : new JsNumber(new JsTextCodeConstructor(jsTextCode));
    }

    public static implicit operator string(JsNumber value)
    {
        return value.GetJsCode();
    }

    public static implicit operator JsNumber(double value)
    {
        return new JsNumber(value);
    }


    private readonly JsNumber _jsVariableValue;
    public JsNumber JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public double? CsValue
        => TypeConstructor is JsTypeCodeSourceNumber booleanSource
            ? booleanSource.LiteralValue : null;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;


    internal JsNumber(JsTypeConstructor jsCodeSource, JsNumber jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
    }

    public JsNumber(double value)
        : base(new JsTypeCodeSourceNumber(value))
    {
    }


    public override string GetCsCode()
    {
        if (TypeConstructor is not JsTypeCodeSourceNumber numberSource) 
            return TypeConstructor.GetJsCode().ValueToQuotedLiteral();
            
        var literalValue = numberSource.LiteralValue;

        if (double.IsNaN(literalValue))
            return "double.NaN";

        if (double.IsPositiveInfinity(literalValue))
            return "double.PositiveInfinity";

        if (double.IsNegativeInfinity(literalValue))
            return "double.NegativeInfinity";

        return literalValue.ToString("G");
    }
}