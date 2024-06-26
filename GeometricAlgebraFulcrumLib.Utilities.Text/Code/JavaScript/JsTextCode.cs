namespace GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

public sealed class JsTextCode :
    JsType
{
    public static implicit operator JsTextCode(string jsTextCode)
    {
        return new JsTextCode(jsTextCode);
    }

    public static implicit operator string(JsTextCode value)
    {
        return value.GetJsCode();
    }

        
    private readonly JsTextCode _jsVariableValue;
    public JsTextCode JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public string CsValue
        => TypeConstructor.GetJsCode().ValueToQuotedLiteral();

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        
    internal JsTextCode(JsTypeConstructor jsCodeSource, JsTextCode jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            throw new InvalidOperationException();

        _jsVariableValue = jsVariableValue;
    }

    public JsTextCode(string jsTextCode) 
        : base(new JsTextCodeConstructor(jsTextCode))
    {
    }
}