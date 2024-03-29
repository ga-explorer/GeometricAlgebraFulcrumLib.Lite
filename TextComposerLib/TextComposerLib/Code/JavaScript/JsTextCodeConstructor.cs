using System.Diagnostics.CodeAnalysis;

namespace TextComposerLib.Code.JavaScript;

public sealed class JsTextCodeConstructor :
    JsTypeConstructor
{
    public string JsTextCode { get; }


    public JsTextCodeConstructor([NotNull] string jsTextCode)
    {
        JsTextCode = jsTextCode;
    }


    public override string GetJsCode()
    {
        return JsTextCode;
    }
}