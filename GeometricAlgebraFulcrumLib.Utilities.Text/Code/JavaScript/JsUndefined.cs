namespace GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

public sealed class JsUndefined :
    JsType
{
    public static JsUndefined Value { get; }
        = new JsUndefined();


    public override bool IsVariableWithValue 
        => false;

    public override bool IsVariableWithNoValue 
        => false;


    private JsUndefined() 
        : base(new JsTextCodeConstructor("undefined"))
    {
    }
}