using System.Diagnostics.CodeAnalysis;
using GeometricAlgebraFulcrumLib.Utilities.Text.Text;

namespace GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

public abstract class JsType
{
    public static implicit operator JsType(bool literalValue)
    {
        return new JsBoolean(literalValue);
    }

    public static implicit operator JsType(byte literalValue)
    {
        return new JsNumber(literalValue);
    }

    public static implicit operator JsType(short literalValue)
    {
        return new JsNumber(literalValue);
    }

    public static implicit operator JsType(ushort literalValue)
    {
        return new JsNumber(literalValue);
    }

    public static implicit operator JsType(int literalValue)
    {
        return new JsNumber(literalValue);
    }

    public static implicit operator JsType(uint literalValue)
    {
        return new JsNumber(literalValue);
    }

    public static implicit operator JsType(long literalValue)
    {
        return new JsNumber(literalValue);
    }

    public static implicit operator JsType(ulong literalValue)
    {
        return new JsNumber(literalValue);
    }

    public static implicit operator JsType(float literalValue)
    {
        return new JsNumber(literalValue);
    }

    public static implicit operator JsType(double literalValue)
    {
        return new JsNumber(literalValue);
    }

    public static implicit operator JsType(string jsTextCode)
    {
        return new JsTextCode(jsTextCode);
    }

    public static implicit operator string(JsType jsType)
    {
        return jsType.GetJsCode();
    }

    public static implicit operator JsType(Dictionary<string, JsType> propertiesDictionary)
    {
        return new JsObject(
            new JsObject.JsObjectConstructor(propertiesDictionary)
        );
    }


    protected JsTypeConstructor TypeConstructor { get; }

    public string VariableName 
        => TypeConstructor.IsVariable 
            ? TypeConstructor.GetJsCode() : string.Empty;

    public bool IsVariable 
        => TypeConstructor.IsVariable;

    public abstract bool IsVariableWithValue { get; }

    public abstract bool IsVariableWithNoValue { get; }

    public bool IsTextCode
        => TypeConstructor.IsTextCode;

    public bool IsVariableOrTextCode 
        => TypeConstructor.IsVariable || TypeConstructor.IsTextCode;

    public bool IsConstructor 
        => !(TypeConstructor.IsVariable || TypeConstructor.IsTextCode);


    protected JsType([NotNull] JsTypeConstructor typeConstructor)
    {
        TypeConstructor = typeConstructor;
    }


    protected void CallMethodVoid(string methodName, params JsType[] argumentsList)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine(
            CallMethod(methodName, argumentsList)
        );
    }

    protected JsNumber CallMethodNumber(string methodName, params JsType[] argumentsList)
    {
        return CallMethod(methodName, argumentsList);
    }

    protected string CallMethod(string methodName, params JsType[] argumentsList)
    {
        var argumentsText =
            argumentsList
                .Select(a => a.GetJsCode())
                .Concatenate(",");

        return $"{GetJsCode()}.{methodName}({argumentsText});";
    }


    public string GetJsCode()
    {
        return TypeConstructor.GetJsCode();
    }

    public override string ToString()
    {
        return TypeConstructor.GetJsCode();
    }
}