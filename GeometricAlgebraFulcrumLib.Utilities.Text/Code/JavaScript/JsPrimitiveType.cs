namespace GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

public abstract class JsPrimitiveType :
    JsType
{
    protected JsPrimitiveType(JsTypeConstructor jsCodeSource) 
        : base(jsCodeSource)
    {
    }


    public abstract string GetCsCode();
}