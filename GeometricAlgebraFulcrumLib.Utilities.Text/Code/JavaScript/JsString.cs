namespace GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

public class JsString :
    JsPrimitiveType
{
    public sealed class JsTypeCodeSourceString :
        JsTypeConstructor
    {
        public string LiteralValue { get; }


        internal JsTypeCodeSourceString(string literalValue)
        {
            LiteralValue = literalValue;
        }


        public override string GetJsCode()
        {
            return LiteralValue.ValueToQuotedLiteral().Replace(@"\?", @"?");
        }

        public override string ToString()
        {
            return GetJsCode();
        }
    }


    public static implicit operator string(JsString value)
    {
        return value.GetJsCode();
    }

    public static implicit operator JsString(string value)
    {
        return new JsString(value);
    }


    private readonly JsString _jsVariableValue;
    public JsString JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public string CsValue
        => TypeConstructor is JsTypeCodeSourceString stringSource
            ? stringSource.LiteralValue : null;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;


    internal JsString(JsTypeConstructor jsTypeConstructor, JsString jsVariableValue = null)
        : base(jsTypeConstructor)
    {
        if (!(jsTypeConstructor.IsVariable || jsTypeConstructor.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
    }

    public JsString(string value)
        : base(new JsTypeCodeSourceString(value))
    {
    }


    public override string GetCsCode()
    {
        if (TypeConstructor is not JsTypeCodeSourceString stringSource) 
            return TypeConstructor.GetJsCode().ValueToQuotedLiteral();
            
        return stringSource.LiteralValue.ValueToQuotedLiteral().Replace(@"\?", @"?");
    }
}