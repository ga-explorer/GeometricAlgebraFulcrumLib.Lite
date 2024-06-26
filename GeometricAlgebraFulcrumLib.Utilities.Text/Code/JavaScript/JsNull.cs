namespace GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

public sealed class JsNull :
    JsType
{
    public static JsNull Value { get; }
        = new JsNull();


    public override bool IsVariableWithValue 
        => false;

    public override bool IsVariableWithNoValue 
        => false;


    private JsNull() 
        : base(new JsTextCodeConstructor("null"))
    {
    }
}