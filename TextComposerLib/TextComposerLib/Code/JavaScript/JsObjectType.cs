namespace TextComposerLib.Code.JavaScript;

public abstract class JsObjectType :
    JsType
{
    protected JsObjectType(JsTypeConstructor jsCodeSource) 
        : base(jsCodeSource)
    {
    }
}