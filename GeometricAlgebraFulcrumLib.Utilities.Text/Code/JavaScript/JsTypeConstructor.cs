namespace GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

public abstract class JsTypeConstructor
{
    public bool IsVariable 
        => this is JsVariableConstructor;

    public bool IsTextCode
        => this is JsTextCodeConstructor;

    public abstract string GetJsCode();
        
    public override string ToString()
    {
        return GetJsCode();
    }
}