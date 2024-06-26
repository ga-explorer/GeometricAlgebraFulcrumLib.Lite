using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;
using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs;

public static class ThreeJsObjectFactory
{
    public static JsCubicPoly JsSet(this string jsVariableName, JsCubicPoly jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicPoly(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicPoly JsSet(this JsCubicPoly jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicPoly(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicPoly JsLet(this string jsVariableName, JsCubicPoly jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicPoly(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicPoly JsLet(this JsCubicPoly jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicPoly(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicPoly JsConst(this string jsVariableName, JsCubicPoly jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicPoly(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicPoly JsConst(this JsCubicPoly jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicPoly(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicPoly AsJsCubicPolyVariable(this string jsVariableName, JsCubicPoly jsVariableValue = null)
    {
        return new JsCubicPoly(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicPoly AsJsCubicPolyVariable(this JsCubicPoly jsVariableValue, string jsVariableName)
    {
        return new JsCubicPoly(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicPoly AsJsCubicPoly(this JsType value)
    {
        return value is JsCubicPoly typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsWebGLRenderer JsSet(this string jsVariableName, JsWebGLRenderer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLRenderer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLRenderer JsSet(this JsWebGLRenderer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLRenderer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLRenderer JsLet(this string jsVariableName, JsWebGLRenderer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLRenderer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLRenderer JsLet(this JsWebGLRenderer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLRenderer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLRenderer JsConst(this string jsVariableName, JsWebGLRenderer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLRenderer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLRenderer JsConst(this JsWebGLRenderer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLRenderer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLRenderer AsJsWebGLRendererVariable(this string jsVariableName, JsWebGLRenderer jsVariableValue = null)
    {
        return new JsWebGLRenderer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLRenderer AsJsWebGLRendererVariable(this JsWebGLRenderer jsVariableValue, string jsVariableName)
    {
        return new JsWebGLRenderer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLRenderer AsJsWebGLRenderer(this JsType value)
    {
        return value is JsWebGLRenderer typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsEventDispatcher JsSet(this string jsVariableName, JsEventDispatcher jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEventDispatcher(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEventDispatcher JsSet(this JsEventDispatcher jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEventDispatcher(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEventDispatcher JsLet(this string jsVariableName, JsEventDispatcher jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEventDispatcher(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEventDispatcher JsLet(this JsEventDispatcher jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEventDispatcher(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEventDispatcher JsConst(this string jsVariableName, JsEventDispatcher jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEventDispatcher(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEventDispatcher JsConst(this JsEventDispatcher jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEventDispatcher(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEventDispatcher AsJsEventDispatcherVariable(this string jsVariableName, JsEventDispatcher jsVariableValue = null)
    {
        return new JsEventDispatcher(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEventDispatcher AsJsEventDispatcherVariable(this JsEventDispatcher jsVariableValue, string jsVariableName)
    {
        return new JsEventDispatcher(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEventDispatcher AsJsEventDispatcher(this JsType value)
    {
        return value is JsEventDispatcher typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsVector2 JsSet(this string jsVariableName, JsVector2 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector2 JsSet(this JsVector2 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector2 JsLet(this string jsVariableName, JsVector2 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector2 JsLet(this JsVector2 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector2 JsConst(this string jsVariableName, JsVector2 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector2 JsConst(this JsVector2 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector2 AsJsVector2Variable(this string jsVariableName, JsVector2 jsVariableValue = null)
    {
        return new JsVector2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector2 AsJsVector2Variable(this JsVector2 jsVariableValue, string jsVariableName)
    {
        return new JsVector2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector2 AsJsVector2(this JsType value)
    {
        return value is JsVector2 typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsMatrix3 JsSet(this string jsVariableName, JsMatrix3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMatrix3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMatrix3 JsSet(this JsMatrix3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMatrix3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMatrix3 JsLet(this string jsVariableName, JsMatrix3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMatrix3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMatrix3 JsLet(this JsMatrix3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMatrix3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMatrix3 JsConst(this string jsVariableName, JsMatrix3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMatrix3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMatrix3 JsConst(this JsMatrix3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMatrix3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMatrix3 AsJsMatrix3Variable(this string jsVariableName, JsMatrix3 jsVariableValue = null)
    {
        return new JsMatrix3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMatrix3 AsJsMatrix3Variable(this JsMatrix3 jsVariableValue, string jsVariableName)
    {
        return new JsMatrix3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMatrix3 AsJsMatrix3(this JsType value)
    {
        return value is JsMatrix3 typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsImageUtils JsSet(this string jsVariableName, JsImageUtils jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageUtils JsSet(this JsImageUtils jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageUtils JsLet(this string jsVariableName, JsImageUtils jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageUtils JsLet(this JsImageUtils jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageUtils JsConst(this string jsVariableName, JsImageUtils jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageUtils JsConst(this JsImageUtils jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageUtils AsJsImageUtilsVariable(this string jsVariableName, JsImageUtils jsVariableValue = null)
    {
        return new JsImageUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageUtils AsJsImageUtilsVariable(this JsImageUtils jsVariableValue, string jsVariableName)
    {
        return new JsImageUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageUtils AsJsImageUtils(this JsType value)
    {
        return value is JsImageUtils typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsTexture JsSet(this string jsVariableName, JsTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTexture JsSet(this JsTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTexture JsLet(this string jsVariableName, JsTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTexture JsLet(this JsTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTexture JsConst(this string jsVariableName, JsTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTexture JsConst(this JsTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTexture AsJsTextureVariable(this string jsVariableName, JsTexture jsVariableValue = null)
    {
        return new JsTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTexture AsJsTextureVariable(this JsTexture jsVariableValue, string jsVariableName)
    {
        return new JsTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTexture AsJsTexture(this JsType value)
    {
        return value is JsTexture typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsVector4 JsSet(this string jsVariableName, JsVector4 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector4(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector4 JsSet(this JsVector4 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector4(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector4 JsLet(this string jsVariableName, JsVector4 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector4(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector4 JsLet(this JsVector4 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector4(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector4 JsConst(this string jsVariableName, JsVector4 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector4(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector4 JsConst(this JsVector4 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector4(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector4 AsJsVector4Variable(this string jsVariableName, JsVector4 jsVariableValue = null)
    {
        return new JsVector4(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector4 AsJsVector4Variable(this JsVector4 jsVariableValue, string jsVariableName)
    {
        return new JsVector4(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector4 AsJsVector4(this JsType value)
    {
        return value is JsVector4 typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsWebGLRenderTarget JsSet(this string jsVariableName, JsWebGLRenderTarget jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLRenderTarget JsSet(this JsWebGLRenderTarget jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLRenderTarget JsLet(this string jsVariableName, JsWebGLRenderTarget jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLRenderTarget JsLet(this JsWebGLRenderTarget jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLRenderTarget JsConst(this string jsVariableName, JsWebGLRenderTarget jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLRenderTarget JsConst(this JsWebGLRenderTarget jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLRenderTarget AsJsWebGLRenderTargetVariable(this string jsVariableName, JsWebGLRenderTarget jsVariableValue = null)
    {
        return new JsWebGLRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLRenderTarget AsJsWebGLRenderTargetVariable(this JsWebGLRenderTarget jsVariableValue, string jsVariableName)
    {
        return new JsWebGLRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLRenderTarget AsJsWebGLRenderTarget(this JsType value)
    {
        return value is JsWebGLRenderTarget typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsWebGLMultipleRenderTargets JsSet(this string jsVariableName, JsWebGLMultipleRenderTargets jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLMultipleRenderTargets(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLMultipleRenderTargets JsSet(this JsWebGLMultipleRenderTargets jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLMultipleRenderTargets(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLMultipleRenderTargets JsLet(this string jsVariableName, JsWebGLMultipleRenderTargets jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLMultipleRenderTargets(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLMultipleRenderTargets JsLet(this JsWebGLMultipleRenderTargets jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLMultipleRenderTargets(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLMultipleRenderTargets JsConst(this string jsVariableName, JsWebGLMultipleRenderTargets jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLMultipleRenderTargets(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLMultipleRenderTargets JsConst(this JsWebGLMultipleRenderTargets jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLMultipleRenderTargets(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLMultipleRenderTargets AsJsWebGLMultipleRenderTargetsVariable(this string jsVariableName, JsWebGLMultipleRenderTargets jsVariableValue = null)
    {
        return new JsWebGLMultipleRenderTargets(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLMultipleRenderTargets AsJsWebGLMultipleRenderTargetsVariable(this JsWebGLMultipleRenderTargets jsVariableValue, string jsVariableName)
    {
        return new JsWebGLMultipleRenderTargets(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLMultipleRenderTargets AsJsWebGLMultipleRenderTargets(this JsType value)
    {
        return value is JsWebGLMultipleRenderTargets typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsWebGLMultisampleRenderTarget JsSet(this string jsVariableName, JsWebGLMultisampleRenderTarget jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLMultisampleRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLMultisampleRenderTarget JsSet(this JsWebGLMultisampleRenderTarget jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLMultisampleRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLMultisampleRenderTarget JsLet(this string jsVariableName, JsWebGLMultisampleRenderTarget jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLMultisampleRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLMultisampleRenderTarget JsLet(this JsWebGLMultisampleRenderTarget jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLMultisampleRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLMultisampleRenderTarget JsConst(this string jsVariableName, JsWebGLMultisampleRenderTarget jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLMultisampleRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLMultisampleRenderTarget JsConst(this JsWebGLMultisampleRenderTarget jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLMultisampleRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLMultisampleRenderTarget AsJsWebGLMultisampleRenderTargetVariable(this string jsVariableName, JsWebGLMultisampleRenderTarget jsVariableValue = null)
    {
        return new JsWebGLMultisampleRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLMultisampleRenderTarget AsJsWebGLMultisampleRenderTargetVariable(this JsWebGLMultisampleRenderTarget jsVariableValue, string jsVariableName)
    {
        return new JsWebGLMultisampleRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLMultisampleRenderTarget AsJsWebGLMultisampleRenderTarget(this JsType value)
    {
        return value is JsWebGLMultisampleRenderTarget typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsQuaternion JsSet(this string jsVariableName, JsQuaternion jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternion(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternion JsSet(this JsQuaternion jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternion(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternion JsLet(this string jsVariableName, JsQuaternion jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternion(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternion JsLet(this JsQuaternion jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternion(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternion JsConst(this string jsVariableName, JsQuaternion jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternion(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternion JsConst(this JsQuaternion jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternion(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternion AsJsQuaternionVariable(this string jsVariableName, JsQuaternion jsVariableValue = null)
    {
        return new JsQuaternion(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternion AsJsQuaternionVariable(this JsQuaternion jsVariableValue, string jsVariableName)
    {
        return new JsQuaternion(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternion AsJsQuaternion(this JsType value)
    {
        return value is JsQuaternion typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsVector3 JsSet(this string jsVariableName, JsVector3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector3 JsSet(this JsVector3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector3 JsLet(this string jsVariableName, JsVector3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector3 JsLet(this JsVector3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector3 JsConst(this string jsVariableName, JsVector3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector3 JsConst(this JsVector3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVector3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector3 AsJsVector3Variable(this string jsVariableName, JsVector3 jsVariableValue = null)
    {
        return new JsVector3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector3 AsJsVector3Variable(this JsVector3 jsVariableValue, string jsVariableName)
    {
        return new JsVector3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVector3 AsJsVector3(this JsType value)
    {
        return value is JsVector3 typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsBox3 JsSet(this string jsVariableName, JsBox3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox3 JsSet(this JsBox3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox3 JsLet(this string jsVariableName, JsBox3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox3 JsLet(this JsBox3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox3 JsConst(this string jsVariableName, JsBox3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox3 JsConst(this JsBox3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox3 AsJsBox3Variable(this string jsVariableName, JsBox3 jsVariableValue = null)
    {
        return new JsBox3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox3 AsJsBox3Variable(this JsBox3 jsVariableValue, string jsVariableName)
    {
        return new JsBox3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox3 AsJsBox3(this JsType value)
    {
        return value is JsBox3 typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsSphere JsSet(this string jsVariableName, JsSphere jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphere(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphere JsSet(this JsSphere jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphere(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphere JsLet(this string jsVariableName, JsSphere jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphere(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphere JsLet(this JsSphere jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphere(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphere JsConst(this string jsVariableName, JsSphere jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphere(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphere JsConst(this JsSphere jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphere(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphere AsJsSphereVariable(this string jsVariableName, JsSphere jsVariableValue = null)
    {
        return new JsSphere(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphere AsJsSphereVariable(this JsSphere jsVariableValue, string jsVariableName)
    {
        return new JsSphere(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphere AsJsSphere(this JsType value)
    {
        return value is JsSphere typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsRay JsSet(this string jsVariableName, JsRay jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRay(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRay JsSet(this JsRay jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRay(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRay JsLet(this string jsVariableName, JsRay jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRay(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRay JsLet(this JsRay jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRay(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRay JsConst(this string jsVariableName, JsRay jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRay(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRay JsConst(this JsRay jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRay(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRay AsJsRayVariable(this string jsVariableName, JsRay jsVariableValue = null)
    {
        return new JsRay(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRay AsJsRayVariable(this JsRay jsVariableValue, string jsVariableName)
    {
        return new JsRay(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRay AsJsRay(this JsType value)
    {
        return value is JsRay typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsMatrix4 JsSet(this string jsVariableName, JsMatrix4 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMatrix4(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMatrix4 JsSet(this JsMatrix4 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMatrix4(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMatrix4 JsLet(this string jsVariableName, JsMatrix4 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMatrix4(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMatrix4 JsLet(this JsMatrix4 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMatrix4(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMatrix4 JsConst(this string jsVariableName, JsMatrix4 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMatrix4(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMatrix4 JsConst(this JsMatrix4 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMatrix4(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMatrix4 AsJsMatrix4Variable(this string jsVariableName, JsMatrix4 jsVariableValue = null)
    {
        return new JsMatrix4(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMatrix4 AsJsMatrix4Variable(this JsMatrix4 jsVariableValue, string jsVariableName)
    {
        return new JsMatrix4(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMatrix4 AsJsMatrix4(this JsType value)
    {
        return value is JsMatrix4 typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsEuler JsSet(this string jsVariableName, JsEuler jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEuler(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEuler JsSet(this JsEuler jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEuler(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEuler JsLet(this string jsVariableName, JsEuler jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEuler(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEuler JsLet(this JsEuler jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEuler(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEuler JsConst(this string jsVariableName, JsEuler jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEuler(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEuler JsConst(this JsEuler jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEuler(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEuler AsJsEulerVariable(this string jsVariableName, JsEuler jsVariableValue = null)
    {
        return new JsEuler(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEuler AsJsEulerVariable(this JsEuler jsVariableValue, string jsVariableName)
    {
        return new JsEuler(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEuler AsJsEuler(this JsType value)
    {
        return value is JsEuler typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLayers JsSet(this string jsVariableName, JsLayers jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLayers(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLayers JsSet(this JsLayers jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLayers(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLayers JsLet(this string jsVariableName, JsLayers jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLayers(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLayers JsLet(this JsLayers jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLayers(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLayers JsConst(this string jsVariableName, JsLayers jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLayers(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLayers JsConst(this JsLayers jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLayers(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLayers AsJsLayersVariable(this string jsVariableName, JsLayers jsVariableValue = null)
    {
        return new JsLayers(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLayers AsJsLayersVariable(this JsLayers jsVariableValue, string jsVariableName)
    {
        return new JsLayers(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLayers AsJsLayers(this JsType value)
    {
        return value is JsLayers typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsObject3D JsSet(this string jsVariableName, JsObject3D jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsObject3D(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsObject3D JsSet(this JsObject3D jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsObject3D(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsObject3D JsLet(this string jsVariableName, JsObject3D jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsObject3D(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsObject3D JsLet(this JsObject3D jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsObject3D(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsObject3D JsConst(this string jsVariableName, JsObject3D jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsObject3D(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsObject3D JsConst(this JsObject3D jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsObject3D(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsObject3D AsJsObject3DVariable(this string jsVariableName, JsObject3D jsVariableValue = null)
    {
        return new JsObject3D(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsObject3D AsJsObject3DVariable(this JsObject3D jsVariableValue, string jsVariableName)
    {
        return new JsObject3D(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsObject3D AsJsObject3D(this JsType value)
    {
        return value is JsObject3D typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsTriangle JsSet(this string jsVariableName, JsTriangle jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTriangle(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTriangle JsSet(this JsTriangle jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTriangle(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTriangle JsLet(this string jsVariableName, JsTriangle jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTriangle(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTriangle JsLet(this JsTriangle jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTriangle(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTriangle JsConst(this string jsVariableName, JsTriangle jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTriangle(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTriangle JsConst(this JsTriangle jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTriangle(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTriangle AsJsTriangleVariable(this string jsVariableName, JsTriangle jsVariableValue = null)
    {
        return new JsTriangle(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTriangle AsJsTriangleVariable(this JsTriangle jsVariableValue, string jsVariableName)
    {
        return new JsTriangle(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTriangle AsJsTriangle(this JsType value)
    {
        return value is JsTriangle typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsMaterial JsSet(this string jsVariableName, JsMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMaterial JsSet(this JsMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMaterial JsLet(this string jsVariableName, JsMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMaterial JsLet(this JsMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMaterial JsConst(this string jsVariableName, JsMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMaterial JsConst(this JsMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMaterial AsJsMaterialVariable(this string jsVariableName, JsMaterial jsVariableValue = null)
    {
        return new JsMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMaterial AsJsMaterialVariable(this JsMaterial jsVariableValue, string jsVariableName)
    {
        return new JsMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMaterial AsJsMaterial(this JsType value)
    {
        return value is JsMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsColor JsSet(this string jsVariableName, JsColor jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsColor(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsColor JsSet(this JsColor jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsColor(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsColor JsLet(this string jsVariableName, JsColor jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsColor(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsColor JsLet(this JsColor jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsColor(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsColor JsConst(this string jsVariableName, JsColor jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsColor(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsColor JsConst(this JsColor jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsColor(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsColor AsJsColorVariable(this string jsVariableName, JsColor jsVariableValue = null)
    {
        return new JsColor(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsColor AsJsColorVariable(this JsColor jsVariableValue, string jsVariableName)
    {
        return new JsColor(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsColor AsJsColor(this JsType value)
    {
        return value is JsColor typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsMeshBasicMaterial JsSet(this string jsVariableName, JsMeshBasicMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshBasicMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshBasicMaterial JsSet(this JsMeshBasicMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshBasicMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshBasicMaterial JsLet(this string jsVariableName, JsMeshBasicMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshBasicMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshBasicMaterial JsLet(this JsMeshBasicMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshBasicMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshBasicMaterial JsConst(this string jsVariableName, JsMeshBasicMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshBasicMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshBasicMaterial JsConst(this JsMeshBasicMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshBasicMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshBasicMaterial AsJsMeshBasicMaterialVariable(this string jsVariableName, JsMeshBasicMaterial jsVariableValue = null)
    {
        return new JsMeshBasicMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshBasicMaterial AsJsMeshBasicMaterialVariable(this JsMeshBasicMaterial jsVariableValue, string jsVariableName)
    {
        return new JsMeshBasicMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshBasicMaterial AsJsMeshBasicMaterial(this JsType value)
    {
        return value is JsMeshBasicMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsBufferAttribute JsSet(this string jsVariableName, JsBufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferAttribute JsSet(this JsBufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferAttribute JsLet(this string jsVariableName, JsBufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferAttribute JsLet(this JsBufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferAttribute JsConst(this string jsVariableName, JsBufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferAttribute JsConst(this JsBufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferAttribute AsJsBufferAttributeVariable(this string jsVariableName, JsBufferAttribute jsVariableValue = null)
    {
        return new JsBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferAttribute AsJsBufferAttributeVariable(this JsBufferAttribute jsVariableValue, string jsVariableName)
    {
        return new JsBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferAttribute AsJsBufferAttribute(this JsType value)
    {
        return value is JsBufferAttribute typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsInt8BufferAttribute JsSet(this string jsVariableName, JsInt8BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt8BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt8BufferAttribute JsSet(this JsInt8BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt8BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt8BufferAttribute JsLet(this string jsVariableName, JsInt8BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt8BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt8BufferAttribute JsLet(this JsInt8BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt8BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt8BufferAttribute JsConst(this string jsVariableName, JsInt8BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt8BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt8BufferAttribute JsConst(this JsInt8BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt8BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt8BufferAttribute AsJsInt8BufferAttributeVariable(this string jsVariableName, JsInt8BufferAttribute jsVariableValue = null)
    {
        return new JsInt8BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt8BufferAttribute AsJsInt8BufferAttributeVariable(this JsInt8BufferAttribute jsVariableValue, string jsVariableName)
    {
        return new JsInt8BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt8BufferAttribute AsJsInt8BufferAttribute(this JsType value)
    {
        return value is JsInt8BufferAttribute typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsUint8BufferAttribute JsSet(this string jsVariableName, JsUint8BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint8BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint8BufferAttribute JsSet(this JsUint8BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint8BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint8BufferAttribute JsLet(this string jsVariableName, JsUint8BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint8BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint8BufferAttribute JsLet(this JsUint8BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint8BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint8BufferAttribute JsConst(this string jsVariableName, JsUint8BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint8BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint8BufferAttribute JsConst(this JsUint8BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint8BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint8BufferAttribute AsJsUint8BufferAttributeVariable(this string jsVariableName, JsUint8BufferAttribute jsVariableValue = null)
    {
        return new JsUint8BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint8BufferAttribute AsJsUint8BufferAttributeVariable(this JsUint8BufferAttribute jsVariableValue, string jsVariableName)
    {
        return new JsUint8BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint8BufferAttribute AsJsUint8BufferAttribute(this JsType value)
    {
        return value is JsUint8BufferAttribute typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsUint8ClampedBufferAttribute JsSet(this string jsVariableName, JsUint8ClampedBufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint8ClampedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint8ClampedBufferAttribute JsSet(this JsUint8ClampedBufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint8ClampedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint8ClampedBufferAttribute JsLet(this string jsVariableName, JsUint8ClampedBufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint8ClampedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint8ClampedBufferAttribute JsLet(this JsUint8ClampedBufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint8ClampedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint8ClampedBufferAttribute JsConst(this string jsVariableName, JsUint8ClampedBufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint8ClampedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint8ClampedBufferAttribute JsConst(this JsUint8ClampedBufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint8ClampedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint8ClampedBufferAttribute AsJsUint8ClampedBufferAttributeVariable(this string jsVariableName, JsUint8ClampedBufferAttribute jsVariableValue = null)
    {
        return new JsUint8ClampedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint8ClampedBufferAttribute AsJsUint8ClampedBufferAttributeVariable(this JsUint8ClampedBufferAttribute jsVariableValue, string jsVariableName)
    {
        return new JsUint8ClampedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint8ClampedBufferAttribute AsJsUint8ClampedBufferAttribute(this JsType value)
    {
        return value is JsUint8ClampedBufferAttribute typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsInt16BufferAttribute JsSet(this string jsVariableName, JsInt16BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt16BufferAttribute JsSet(this JsInt16BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt16BufferAttribute JsLet(this string jsVariableName, JsInt16BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt16BufferAttribute JsLet(this JsInt16BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt16BufferAttribute JsConst(this string jsVariableName, JsInt16BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt16BufferAttribute JsConst(this JsInt16BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt16BufferAttribute AsJsInt16BufferAttributeVariable(this string jsVariableName, JsInt16BufferAttribute jsVariableValue = null)
    {
        return new JsInt16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt16BufferAttribute AsJsInt16BufferAttributeVariable(this JsInt16BufferAttribute jsVariableValue, string jsVariableName)
    {
        return new JsInt16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt16BufferAttribute AsJsInt16BufferAttribute(this JsType value)
    {
        return value is JsInt16BufferAttribute typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsUint16BufferAttribute JsSet(this string jsVariableName, JsUint16BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint16BufferAttribute JsSet(this JsUint16BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint16BufferAttribute JsLet(this string jsVariableName, JsUint16BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint16BufferAttribute JsLet(this JsUint16BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint16BufferAttribute JsConst(this string jsVariableName, JsUint16BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint16BufferAttribute JsConst(this JsUint16BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint16BufferAttribute AsJsUint16BufferAttributeVariable(this string jsVariableName, JsUint16BufferAttribute jsVariableValue = null)
    {
        return new JsUint16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint16BufferAttribute AsJsUint16BufferAttributeVariable(this JsUint16BufferAttribute jsVariableValue, string jsVariableName)
    {
        return new JsUint16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint16BufferAttribute AsJsUint16BufferAttribute(this JsType value)
    {
        return value is JsUint16BufferAttribute typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsInt32BufferAttribute JsSet(this string jsVariableName, JsInt32BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt32BufferAttribute JsSet(this JsInt32BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt32BufferAttribute JsLet(this string jsVariableName, JsInt32BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt32BufferAttribute JsLet(this JsInt32BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt32BufferAttribute JsConst(this string jsVariableName, JsInt32BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt32BufferAttribute JsConst(this JsInt32BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInt32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt32BufferAttribute AsJsInt32BufferAttributeVariable(this string jsVariableName, JsInt32BufferAttribute jsVariableValue = null)
    {
        return new JsInt32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt32BufferAttribute AsJsInt32BufferAttributeVariable(this JsInt32BufferAttribute jsVariableValue, string jsVariableName)
    {
        return new JsInt32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInt32BufferAttribute AsJsInt32BufferAttribute(this JsType value)
    {
        return value is JsInt32BufferAttribute typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsUint32BufferAttribute JsSet(this string jsVariableName, JsUint32BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint32BufferAttribute JsSet(this JsUint32BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint32BufferAttribute JsLet(this string jsVariableName, JsUint32BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint32BufferAttribute JsLet(this JsUint32BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint32BufferAttribute JsConst(this string jsVariableName, JsUint32BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint32BufferAttribute JsConst(this JsUint32BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUint32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint32BufferAttribute AsJsUint32BufferAttributeVariable(this string jsVariableName, JsUint32BufferAttribute jsVariableValue = null)
    {
        return new JsUint32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint32BufferAttribute AsJsUint32BufferAttributeVariable(this JsUint32BufferAttribute jsVariableValue, string jsVariableName)
    {
        return new JsUint32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUint32BufferAttribute AsJsUint32BufferAttribute(this JsType value)
    {
        return value is JsUint32BufferAttribute typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsFloat16BufferAttribute JsSet(this string jsVariableName, JsFloat16BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat16BufferAttribute JsSet(this JsFloat16BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat16BufferAttribute JsLet(this string jsVariableName, JsFloat16BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat16BufferAttribute JsLet(this JsFloat16BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat16BufferAttribute JsConst(this string jsVariableName, JsFloat16BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat16BufferAttribute JsConst(this JsFloat16BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat16BufferAttribute AsJsFloat16BufferAttributeVariable(this string jsVariableName, JsFloat16BufferAttribute jsVariableValue = null)
    {
        return new JsFloat16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat16BufferAttribute AsJsFloat16BufferAttributeVariable(this JsFloat16BufferAttribute jsVariableValue, string jsVariableName)
    {
        return new JsFloat16BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat16BufferAttribute AsJsFloat16BufferAttribute(this JsType value)
    {
        return value is JsFloat16BufferAttribute typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsFloat32BufferAttribute JsSet(this string jsVariableName, JsFloat32BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat32BufferAttribute JsSet(this JsFloat32BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat32BufferAttribute JsLet(this string jsVariableName, JsFloat32BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat32BufferAttribute JsLet(this JsFloat32BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat32BufferAttribute JsConst(this string jsVariableName, JsFloat32BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat32BufferAttribute JsConst(this JsFloat32BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat32BufferAttribute AsJsFloat32BufferAttributeVariable(this string jsVariableName, JsFloat32BufferAttribute jsVariableValue = null)
    {
        return new JsFloat32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat32BufferAttribute AsJsFloat32BufferAttributeVariable(this JsFloat32BufferAttribute jsVariableValue, string jsVariableName)
    {
        return new JsFloat32BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat32BufferAttribute AsJsFloat32BufferAttribute(this JsType value)
    {
        return value is JsFloat32BufferAttribute typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsFloat64BufferAttribute JsSet(this string jsVariableName, JsFloat64BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat64BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat64BufferAttribute JsSet(this JsFloat64BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat64BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat64BufferAttribute JsLet(this string jsVariableName, JsFloat64BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat64BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat64BufferAttribute JsLet(this JsFloat64BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat64BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat64BufferAttribute JsConst(this string jsVariableName, JsFloat64BufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat64BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat64BufferAttribute JsConst(this JsFloat64BufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFloat64BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat64BufferAttribute AsJsFloat64BufferAttributeVariable(this string jsVariableName, JsFloat64BufferAttribute jsVariableValue = null)
    {
        return new JsFloat64BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat64BufferAttribute AsJsFloat64BufferAttributeVariable(this JsFloat64BufferAttribute jsVariableValue, string jsVariableName)
    {
        return new JsFloat64BufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFloat64BufferAttribute AsJsFloat64BufferAttribute(this JsType value)
    {
        return value is JsFloat64BufferAttribute typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsBufferGeometry JsSet(this string jsVariableName, JsBufferGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferGeometry JsSet(this JsBufferGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferGeometry JsLet(this string jsVariableName, JsBufferGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferGeometry JsLet(this JsBufferGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferGeometry JsConst(this string jsVariableName, JsBufferGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferGeometry JsConst(this JsBufferGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferGeometry AsJsBufferGeometryVariable(this string jsVariableName, JsBufferGeometry jsVariableValue = null)
    {
        return new JsBufferGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferGeometry AsJsBufferGeometryVariable(this JsBufferGeometry jsVariableValue, string jsVariableName)
    {
        return new JsBufferGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferGeometry AsJsBufferGeometry(this JsType value)
    {
        return value is JsBufferGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsMesh JsSet(this string jsVariableName, JsMesh jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMesh JsSet(this JsMesh jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMesh JsLet(this string jsVariableName, JsMesh jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMesh JsLet(this JsMesh jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMesh JsConst(this string jsVariableName, JsMesh jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMesh JsConst(this JsMesh jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMesh AsJsMeshVariable(this string jsVariableName, JsMesh jsVariableValue = null)
    {
        return new JsMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMesh AsJsMeshVariable(this JsMesh jsVariableValue, string jsVariableName)
    {
        return new JsMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMesh AsJsMesh(this JsType value)
    {
        return value is JsMesh typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsBoxGeometry JsSet(this string jsVariableName, JsBoxGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBoxGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBoxGeometry JsSet(this JsBoxGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBoxGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBoxGeometry JsLet(this string jsVariableName, JsBoxGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBoxGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBoxGeometry JsLet(this JsBoxGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBoxGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBoxGeometry JsConst(this string jsVariableName, JsBoxGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBoxGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBoxGeometry JsConst(this JsBoxGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBoxGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBoxGeometry AsJsBoxGeometryVariable(this string jsVariableName, JsBoxGeometry jsVariableValue = null)
    {
        return new JsBoxGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBoxGeometry AsJsBoxGeometryVariable(this JsBoxGeometry jsVariableValue, string jsVariableName)
    {
        return new JsBoxGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBoxGeometry AsJsBoxGeometry(this JsType value)
    {
        return value is JsBoxGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsShaderMaterial JsSet(this string jsVariableName, JsShaderMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShaderMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShaderMaterial JsSet(this JsShaderMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShaderMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShaderMaterial JsLet(this string jsVariableName, JsShaderMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShaderMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShaderMaterial JsLet(this JsShaderMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShaderMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShaderMaterial JsConst(this string jsVariableName, JsShaderMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShaderMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShaderMaterial JsConst(this JsShaderMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShaderMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShaderMaterial AsJsShaderMaterialVariable(this string jsVariableName, JsShaderMaterial jsVariableValue = null)
    {
        return new JsShaderMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShaderMaterial AsJsShaderMaterialVariable(this JsShaderMaterial jsVariableValue, string jsVariableName)
    {
        return new JsShaderMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShaderMaterial AsJsShaderMaterial(this JsType value)
    {
        return value is JsShaderMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCamera JsSet(this string jsVariableName, JsCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCamera JsSet(this JsCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCamera JsLet(this string jsVariableName, JsCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCamera JsLet(this JsCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCamera JsConst(this string jsVariableName, JsCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCamera JsConst(this JsCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCamera AsJsCameraVariable(this string jsVariableName, JsCamera jsVariableValue = null)
    {
        return new JsCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCamera AsJsCameraVariable(this JsCamera jsVariableValue, string jsVariableName)
    {
        return new JsCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCamera AsJsCamera(this JsType value)
    {
        return value is JsCamera typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsPerspectiveCamera JsSet(this string jsVariableName, JsPerspectiveCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPerspectiveCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPerspectiveCamera JsSet(this JsPerspectiveCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPerspectiveCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPerspectiveCamera JsLet(this string jsVariableName, JsPerspectiveCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPerspectiveCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPerspectiveCamera JsLet(this JsPerspectiveCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPerspectiveCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPerspectiveCamera JsConst(this string jsVariableName, JsPerspectiveCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPerspectiveCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPerspectiveCamera JsConst(this JsPerspectiveCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPerspectiveCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPerspectiveCamera AsJsPerspectiveCameraVariable(this string jsVariableName, JsPerspectiveCamera jsVariableValue = null)
    {
        return new JsPerspectiveCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPerspectiveCamera AsJsPerspectiveCameraVariable(this JsPerspectiveCamera jsVariableValue, string jsVariableName)
    {
        return new JsPerspectiveCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPerspectiveCamera AsJsPerspectiveCamera(this JsType value)
    {
        return value is JsPerspectiveCamera typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCubeCamera JsSet(this string jsVariableName, JsCubeCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeCamera JsSet(this JsCubeCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeCamera JsLet(this string jsVariableName, JsCubeCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeCamera JsLet(this JsCubeCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeCamera JsConst(this string jsVariableName, JsCubeCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeCamera JsConst(this JsCubeCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeCamera AsJsCubeCameraVariable(this string jsVariableName, JsCubeCamera jsVariableValue = null)
    {
        return new JsCubeCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeCamera AsJsCubeCameraVariable(this JsCubeCamera jsVariableValue, string jsVariableName)
    {
        return new JsCubeCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeCamera AsJsCubeCamera(this JsType value)
    {
        return value is JsCubeCamera typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCubeTexture JsSet(this string jsVariableName, JsCubeTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeTexture JsSet(this JsCubeTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeTexture JsLet(this string jsVariableName, JsCubeTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeTexture JsLet(this JsCubeTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeTexture JsConst(this string jsVariableName, JsCubeTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeTexture JsConst(this JsCubeTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeTexture AsJsCubeTextureVariable(this string jsVariableName, JsCubeTexture jsVariableValue = null)
    {
        return new JsCubeTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeTexture AsJsCubeTextureVariable(this JsCubeTexture jsVariableValue, string jsVariableName)
    {
        return new JsCubeTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeTexture AsJsCubeTexture(this JsType value)
    {
        return value is JsCubeTexture typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsWebGLCubeRenderTarget JsSet(this string jsVariableName, JsWebGLCubeRenderTarget jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLCubeRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLCubeRenderTarget JsSet(this JsWebGLCubeRenderTarget jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLCubeRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLCubeRenderTarget JsLet(this string jsVariableName, JsWebGLCubeRenderTarget jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLCubeRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLCubeRenderTarget JsLet(this JsWebGLCubeRenderTarget jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLCubeRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLCubeRenderTarget JsConst(this string jsVariableName, JsWebGLCubeRenderTarget jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLCubeRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLCubeRenderTarget JsConst(this JsWebGLCubeRenderTarget jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGLCubeRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLCubeRenderTarget AsJsWebGLCubeRenderTargetVariable(this string jsVariableName, JsWebGLCubeRenderTarget jsVariableValue = null)
    {
        return new JsWebGLCubeRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLCubeRenderTarget AsJsWebGLCubeRenderTargetVariable(this JsWebGLCubeRenderTarget jsVariableValue, string jsVariableName)
    {
        return new JsWebGLCubeRenderTarget(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGLCubeRenderTarget AsJsWebGLCubeRenderTarget(this JsType value)
    {
        return value is JsWebGLCubeRenderTarget typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsPlane JsSet(this string jsVariableName, JsPlane jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlane(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlane JsSet(this JsPlane jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlane(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlane JsLet(this string jsVariableName, JsPlane jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlane(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlane JsLet(this JsPlane jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlane(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlane JsConst(this string jsVariableName, JsPlane jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlane(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlane JsConst(this JsPlane jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlane(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlane AsJsPlaneVariable(this string jsVariableName, JsPlane jsVariableValue = null)
    {
        return new JsPlane(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlane AsJsPlaneVariable(this JsPlane jsVariableValue, string jsVariableName)
    {
        return new JsPlane(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlane AsJsPlane(this JsType value)
    {
        return value is JsPlane typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsFrustum JsSet(this string jsVariableName, JsFrustum jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFrustum(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFrustum JsSet(this JsFrustum jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFrustum(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFrustum JsLet(this string jsVariableName, JsFrustum jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFrustum(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFrustum JsLet(this JsFrustum jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFrustum(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFrustum JsConst(this string jsVariableName, JsFrustum jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFrustum(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFrustum JsConst(this JsFrustum jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFrustum(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFrustum AsJsFrustumVariable(this string jsVariableName, JsFrustum jsVariableValue = null)
    {
        return new JsFrustum(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFrustum AsJsFrustumVariable(this JsFrustum jsVariableValue, string jsVariableName)
    {
        return new JsFrustum(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFrustum AsJsFrustum(this JsType value)
    {
        return value is JsFrustum typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsPlaneGeometry JsSet(this string jsVariableName, JsPlaneGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlaneGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlaneGeometry JsSet(this JsPlaneGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlaneGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlaneGeometry JsLet(this string jsVariableName, JsPlaneGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlaneGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlaneGeometry JsLet(this JsPlaneGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlaneGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlaneGeometry JsConst(this string jsVariableName, JsPlaneGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlaneGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlaneGeometry JsConst(this JsPlaneGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlaneGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlaneGeometry AsJsPlaneGeometryVariable(this string jsVariableName, JsPlaneGeometry jsVariableValue = null)
    {
        return new JsPlaneGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlaneGeometry AsJsPlaneGeometryVariable(this JsPlaneGeometry jsVariableValue, string jsVariableName)
    {
        return new JsPlaneGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlaneGeometry AsJsPlaneGeometry(this JsType value)
    {
        return value is JsPlaneGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsOrthographicCamera JsSet(this string jsVariableName, JsOrthographicCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsOrthographicCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsOrthographicCamera JsSet(this JsOrthographicCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsOrthographicCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsOrthographicCamera JsLet(this string jsVariableName, JsOrthographicCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsOrthographicCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsOrthographicCamera JsLet(this JsOrthographicCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsOrthographicCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsOrthographicCamera JsConst(this string jsVariableName, JsOrthographicCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsOrthographicCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsOrthographicCamera JsConst(this JsOrthographicCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsOrthographicCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsOrthographicCamera AsJsOrthographicCameraVariable(this string jsVariableName, JsOrthographicCamera jsVariableValue = null)
    {
        return new JsOrthographicCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsOrthographicCamera AsJsOrthographicCameraVariable(this JsOrthographicCamera jsVariableValue, string jsVariableName)
    {
        return new JsOrthographicCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsOrthographicCamera AsJsOrthographicCamera(this JsType value)
    {
        return value is JsOrthographicCamera typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsRawShaderMaterial JsSet(this string jsVariableName, JsRawShaderMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRawShaderMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRawShaderMaterial JsSet(this JsRawShaderMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRawShaderMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRawShaderMaterial JsLet(this string jsVariableName, JsRawShaderMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRawShaderMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRawShaderMaterial JsLet(this JsRawShaderMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRawShaderMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRawShaderMaterial JsConst(this string jsVariableName, JsRawShaderMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRawShaderMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRawShaderMaterial JsConst(this JsRawShaderMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRawShaderMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRawShaderMaterial AsJsRawShaderMaterialVariable(this string jsVariableName, JsRawShaderMaterial jsVariableValue = null)
    {
        return new JsRawShaderMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRawShaderMaterial AsJsRawShaderMaterialVariable(this JsRawShaderMaterial jsVariableValue, string jsVariableName)
    {
        return new JsRawShaderMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRawShaderMaterial AsJsRawShaderMaterial(this JsType value)
    {
        return value is JsRawShaderMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsPMREMGenerator JsSet(this string jsVariableName, JsPMREMGenerator jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPMREMGenerator(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPMREMGenerator JsSet(this JsPMREMGenerator jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPMREMGenerator(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPMREMGenerator JsLet(this string jsVariableName, JsPMREMGenerator jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPMREMGenerator(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPMREMGenerator JsLet(this JsPMREMGenerator jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPMREMGenerator(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPMREMGenerator JsConst(this string jsVariableName, JsPMREMGenerator jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPMREMGenerator(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPMREMGenerator JsConst(this JsPMREMGenerator jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPMREMGenerator(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPMREMGenerator AsJsPMREMGeneratorVariable(this string jsVariableName, JsPMREMGenerator jsVariableValue = null)
    {
        return new JsPMREMGenerator(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPMREMGenerator AsJsPMREMGeneratorVariable(this JsPMREMGenerator jsVariableValue, string jsVariableName)
    {
        return new JsPMREMGenerator(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPMREMGenerator AsJsPMREMGenerator(this JsType value)
    {
        return value is JsPMREMGenerator typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsDataTexture2DArray JsSet(this string jsVariableName, JsDataTexture2DArray jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture2DArray(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture2DArray JsSet(this JsDataTexture2DArray jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture2DArray(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture2DArray JsLet(this string jsVariableName, JsDataTexture2DArray jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture2DArray(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture2DArray JsLet(this JsDataTexture2DArray jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture2DArray(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture2DArray JsConst(this string jsVariableName, JsDataTexture2DArray jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture2DArray(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture2DArray JsConst(this JsDataTexture2DArray jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture2DArray(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture2DArray AsJsDataTexture2DArrayVariable(this string jsVariableName, JsDataTexture2DArray jsVariableValue = null)
    {
        return new JsDataTexture2DArray(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture2DArray AsJsDataTexture2DArrayVariable(this JsDataTexture2DArray jsVariableValue, string jsVariableName)
    {
        return new JsDataTexture2DArray(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture2DArray AsJsDataTexture2DArray(this JsType value)
    {
        return value is JsDataTexture2DArray typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsDataTexture3D JsSet(this string jsVariableName, JsDataTexture3D jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture3D(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture3D JsSet(this JsDataTexture3D jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture3D(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture3D JsLet(this string jsVariableName, JsDataTexture3D jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture3D(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture3D JsLet(this JsDataTexture3D jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture3D(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture3D JsConst(this string jsVariableName, JsDataTexture3D jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture3D(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture3D JsConst(this JsDataTexture3D jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture3D(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture3D AsJsDataTexture3DVariable(this string jsVariableName, JsDataTexture3D jsVariableValue = null)
    {
        return new JsDataTexture3D(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture3D AsJsDataTexture3DVariable(this JsDataTexture3D jsVariableValue, string jsVariableName)
    {
        return new JsDataTexture3D(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture3D AsJsDataTexture3D(this JsType value)
    {
        return value is JsDataTexture3D typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsMeshDepthMaterial JsSet(this string jsVariableName, JsMeshDepthMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshDepthMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshDepthMaterial JsSet(this JsMeshDepthMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshDepthMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshDepthMaterial JsLet(this string jsVariableName, JsMeshDepthMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshDepthMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshDepthMaterial JsLet(this JsMeshDepthMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshDepthMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshDepthMaterial JsConst(this string jsVariableName, JsMeshDepthMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshDepthMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshDepthMaterial JsConst(this JsMeshDepthMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshDepthMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshDepthMaterial AsJsMeshDepthMaterialVariable(this string jsVariableName, JsMeshDepthMaterial jsVariableValue = null)
    {
        return new JsMeshDepthMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshDepthMaterial AsJsMeshDepthMaterialVariable(this JsMeshDepthMaterial jsVariableValue, string jsVariableName)
    {
        return new JsMeshDepthMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshDepthMaterial AsJsMeshDepthMaterial(this JsType value)
    {
        return value is JsMeshDepthMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsMeshDistanceMaterial JsSet(this string jsVariableName, JsMeshDistanceMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshDistanceMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshDistanceMaterial JsSet(this JsMeshDistanceMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshDistanceMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshDistanceMaterial JsLet(this string jsVariableName, JsMeshDistanceMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshDistanceMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshDistanceMaterial JsLet(this JsMeshDistanceMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshDistanceMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshDistanceMaterial JsConst(this string jsVariableName, JsMeshDistanceMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshDistanceMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshDistanceMaterial JsConst(this JsMeshDistanceMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshDistanceMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshDistanceMaterial AsJsMeshDistanceMaterialVariable(this string jsVariableName, JsMeshDistanceMaterial jsVariableValue = null)
    {
        return new JsMeshDistanceMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshDistanceMaterial AsJsMeshDistanceMaterialVariable(this JsMeshDistanceMaterial jsVariableValue, string jsVariableName)
    {
        return new JsMeshDistanceMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshDistanceMaterial AsJsMeshDistanceMaterial(this JsType value)
    {
        return value is JsMeshDistanceMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsArrayCamera JsSet(this string jsVariableName, JsArrayCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArrayCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArrayCamera JsSet(this JsArrayCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArrayCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArrayCamera JsLet(this string jsVariableName, JsArrayCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArrayCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArrayCamera JsLet(this JsArrayCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArrayCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArrayCamera JsConst(this string jsVariableName, JsArrayCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArrayCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArrayCamera JsConst(this JsArrayCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArrayCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArrayCamera AsJsArrayCameraVariable(this string jsVariableName, JsArrayCamera jsVariableValue = null)
    {
        return new JsArrayCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArrayCamera AsJsArrayCameraVariable(this JsArrayCamera jsVariableValue, string jsVariableName)
    {
        return new JsArrayCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArrayCamera AsJsArrayCamera(this JsType value)
    {
        return value is JsArrayCamera typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsGroup JsSet(this string jsVariableName, JsGroup jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGroup(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGroup JsSet(this JsGroup jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGroup(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGroup JsLet(this string jsVariableName, JsGroup jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGroup(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGroup JsLet(this JsGroup jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGroup(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGroup JsConst(this string jsVariableName, JsGroup jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGroup(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGroup JsConst(this JsGroup jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGroup(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGroup AsJsGroupVariable(this string jsVariableName, JsGroup jsVariableValue = null)
    {
        return new JsGroup(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGroup AsJsGroupVariable(this JsGroup jsVariableValue, string jsVariableName)
    {
        return new JsGroup(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGroup AsJsGroup(this JsType value)
    {
        return value is JsGroup typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsWebXRController JsSet(this string jsVariableName, JsWebXRController jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebXRController(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebXRController JsSet(this JsWebXRController jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebXRController(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebXRController JsLet(this string jsVariableName, JsWebXRController jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebXRController(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebXRController JsLet(this JsWebXRController jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebXRController(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebXRController JsConst(this string jsVariableName, JsWebXRController jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebXRController(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebXRController JsConst(this JsWebXRController jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebXRController(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebXRController AsJsWebXRControllerVariable(this string jsVariableName, JsWebXRController jsVariableValue = null)
    {
        return new JsWebXRController(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebXRController AsJsWebXRControllerVariable(this JsWebXRController jsVariableValue, string jsVariableName)
    {
        return new JsWebXRController(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebXRController AsJsWebXRController(this JsType value)
    {
        return value is JsWebXRController typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsWebXRManager JsSet(this string jsVariableName, JsWebXRManager jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebXRManager(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebXRManager JsSet(this JsWebXRManager jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebXRManager(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebXRManager JsLet(this string jsVariableName, JsWebXRManager jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebXRManager(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebXRManager JsLet(this JsWebXRManager jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebXRManager(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebXRManager JsConst(this string jsVariableName, JsWebXRManager jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebXRManager(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebXRManager JsConst(this JsWebXRManager jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebXRManager(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebXRManager AsJsWebXRManagerVariable(this string jsVariableName, JsWebXRManager jsVariableValue = null)
    {
        return new JsWebXRManager(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebXRManager AsJsWebXRManagerVariable(this JsWebXRManager jsVariableValue, string jsVariableName)
    {
        return new JsWebXRManager(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebXRManager AsJsWebXRManager(this JsType value)
    {
        return value is JsWebXRManager typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsWebGL1Renderer JsSet(this string jsVariableName, JsWebGL1Renderer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGL1Renderer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGL1Renderer JsSet(this JsWebGL1Renderer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGL1Renderer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGL1Renderer JsLet(this string jsVariableName, JsWebGL1Renderer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGL1Renderer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGL1Renderer JsLet(this JsWebGL1Renderer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGL1Renderer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGL1Renderer JsConst(this string jsVariableName, JsWebGL1Renderer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGL1Renderer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGL1Renderer JsConst(this JsWebGL1Renderer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWebGL1Renderer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGL1Renderer AsJsWebGL1RendererVariable(this string jsVariableName, JsWebGL1Renderer jsVariableValue = null)
    {
        return new JsWebGL1Renderer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGL1Renderer AsJsWebGL1RendererVariable(this JsWebGL1Renderer jsVariableValue, string jsVariableName)
    {
        return new JsWebGL1Renderer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWebGL1Renderer AsJsWebGL1Renderer(this JsType value)
    {
        return value is JsWebGL1Renderer typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsFogExp2 JsSet(this string jsVariableName, JsFogExp2 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFogExp2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFogExp2 JsSet(this JsFogExp2 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFogExp2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFogExp2 JsLet(this string jsVariableName, JsFogExp2 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFogExp2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFogExp2 JsLet(this JsFogExp2 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFogExp2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFogExp2 JsConst(this string jsVariableName, JsFogExp2 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFogExp2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFogExp2 JsConst(this JsFogExp2 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFogExp2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFogExp2 AsJsFogExp2Variable(this string jsVariableName, JsFogExp2 jsVariableValue = null)
    {
        return new JsFogExp2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFogExp2 AsJsFogExp2Variable(this JsFogExp2 jsVariableValue, string jsVariableName)
    {
        return new JsFogExp2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFogExp2 AsJsFogExp2(this JsType value)
    {
        return value is JsFogExp2 typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsFog JsSet(this string jsVariableName, JsFog jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFog(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFog JsSet(this JsFog jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFog(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFog JsLet(this string jsVariableName, JsFog jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFog(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFog JsLet(this JsFog jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFog(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFog JsConst(this string jsVariableName, JsFog jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFog(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFog JsConst(this JsFog jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFog(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFog AsJsFogVariable(this string jsVariableName, JsFog jsVariableValue = null)
    {
        return new JsFog(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFog AsJsFogVariable(this JsFog jsVariableValue, string jsVariableName)
    {
        return new JsFog(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFog AsJsFog(this JsType value)
    {
        return value is JsFog typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsScene JsSet(this string jsVariableName, JsScene jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsScene(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsScene JsSet(this JsScene jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsScene(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsScene JsLet(this string jsVariableName, JsScene jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsScene(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsScene JsLet(this JsScene jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsScene(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsScene JsConst(this string jsVariableName, JsScene jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsScene(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsScene JsConst(this JsScene jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsScene(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsScene AsJsSceneVariable(this string jsVariableName, JsScene jsVariableValue = null)
    {
        return new JsScene(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsScene AsJsSceneVariable(this JsScene jsVariableValue, string jsVariableName)
    {
        return new JsScene(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsScene AsJsScene(this JsType value)
    {
        return value is JsScene typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsInterleavedBuffer JsSet(this string jsVariableName, JsInterleavedBuffer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterleavedBuffer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterleavedBuffer JsSet(this JsInterleavedBuffer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterleavedBuffer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterleavedBuffer JsLet(this string jsVariableName, JsInterleavedBuffer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterleavedBuffer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterleavedBuffer JsLet(this JsInterleavedBuffer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterleavedBuffer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterleavedBuffer JsConst(this string jsVariableName, JsInterleavedBuffer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterleavedBuffer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterleavedBuffer JsConst(this JsInterleavedBuffer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterleavedBuffer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterleavedBuffer AsJsInterleavedBufferVariable(this string jsVariableName, JsInterleavedBuffer jsVariableValue = null)
    {
        return new JsInterleavedBuffer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterleavedBuffer AsJsInterleavedBufferVariable(this JsInterleavedBuffer jsVariableValue, string jsVariableName)
    {
        return new JsInterleavedBuffer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterleavedBuffer AsJsInterleavedBuffer(this JsType value)
    {
        return value is JsInterleavedBuffer typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsInterleavedBufferAttribute JsSet(this string jsVariableName, JsInterleavedBufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterleavedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterleavedBufferAttribute JsSet(this JsInterleavedBufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterleavedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterleavedBufferAttribute JsLet(this string jsVariableName, JsInterleavedBufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterleavedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterleavedBufferAttribute JsLet(this JsInterleavedBufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterleavedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterleavedBufferAttribute JsConst(this string jsVariableName, JsInterleavedBufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterleavedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterleavedBufferAttribute JsConst(this JsInterleavedBufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterleavedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterleavedBufferAttribute AsJsInterleavedBufferAttributeVariable(this string jsVariableName, JsInterleavedBufferAttribute jsVariableValue = null)
    {
        return new JsInterleavedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterleavedBufferAttribute AsJsInterleavedBufferAttributeVariable(this JsInterleavedBufferAttribute jsVariableValue, string jsVariableName)
    {
        return new JsInterleavedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterleavedBufferAttribute AsJsInterleavedBufferAttribute(this JsType value)
    {
        return value is JsInterleavedBufferAttribute typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsSpriteMaterial JsSet(this string jsVariableName, JsSpriteMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpriteMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpriteMaterial JsSet(this JsSpriteMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpriteMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpriteMaterial JsLet(this string jsVariableName, JsSpriteMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpriteMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpriteMaterial JsLet(this JsSpriteMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpriteMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpriteMaterial JsConst(this string jsVariableName, JsSpriteMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpriteMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpriteMaterial JsConst(this JsSpriteMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpriteMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpriteMaterial AsJsSpriteMaterialVariable(this string jsVariableName, JsSpriteMaterial jsVariableValue = null)
    {
        return new JsSpriteMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpriteMaterial AsJsSpriteMaterialVariable(this JsSpriteMaterial jsVariableValue, string jsVariableName)
    {
        return new JsSpriteMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpriteMaterial AsJsSpriteMaterial(this JsType value)
    {
        return value is JsSpriteMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsSprite JsSet(this string jsVariableName, JsSprite jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSprite(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSprite JsSet(this JsSprite jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSprite(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSprite JsLet(this string jsVariableName, JsSprite jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSprite(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSprite JsLet(this JsSprite jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSprite(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSprite JsConst(this string jsVariableName, JsSprite jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSprite(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSprite JsConst(this JsSprite jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSprite(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSprite AsJsSpriteVariable(this string jsVariableName, JsSprite jsVariableValue = null)
    {
        return new JsSprite(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSprite AsJsSpriteVariable(this JsSprite jsVariableValue, string jsVariableName)
    {
        return new JsSprite(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSprite AsJsSprite(this JsType value)
    {
        return value is JsSprite typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLOD JsSet(this string jsVariableName, JsLOD jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLOD(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLOD JsSet(this JsLOD jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLOD(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLOD JsLet(this string jsVariableName, JsLOD jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLOD(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLOD JsLet(this JsLOD jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLOD(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLOD JsConst(this string jsVariableName, JsLOD jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLOD(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLOD JsConst(this JsLOD jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLOD(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLOD AsJsLODVariable(this string jsVariableName, JsLOD jsVariableValue = null)
    {
        return new JsLOD(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLOD AsJsLODVariable(this JsLOD jsVariableValue, string jsVariableName)
    {
        return new JsLOD(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLOD AsJsLOD(this JsType value)
    {
        return value is JsLOD typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsSkinnedMesh JsSet(this string jsVariableName, JsSkinnedMesh jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkinnedMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkinnedMesh JsSet(this JsSkinnedMesh jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkinnedMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkinnedMesh JsLet(this string jsVariableName, JsSkinnedMesh jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkinnedMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkinnedMesh JsLet(this JsSkinnedMesh jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkinnedMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkinnedMesh JsConst(this string jsVariableName, JsSkinnedMesh jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkinnedMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkinnedMesh JsConst(this JsSkinnedMesh jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkinnedMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkinnedMesh AsJsSkinnedMeshVariable(this string jsVariableName, JsSkinnedMesh jsVariableValue = null)
    {
        return new JsSkinnedMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkinnedMesh AsJsSkinnedMeshVariable(this JsSkinnedMesh jsVariableValue, string jsVariableName)
    {
        return new JsSkinnedMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkinnedMesh AsJsSkinnedMesh(this JsType value)
    {
        return value is JsSkinnedMesh typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsBone JsSet(this string jsVariableName, JsBone jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBone(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBone JsSet(this JsBone jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBone(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBone JsLet(this string jsVariableName, JsBone jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBone(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBone JsLet(this JsBone jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBone(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBone JsConst(this string jsVariableName, JsBone jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBone(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBone JsConst(this JsBone jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBone(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBone AsJsBoneVariable(this string jsVariableName, JsBone jsVariableValue = null)
    {
        return new JsBone(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBone AsJsBoneVariable(this JsBone jsVariableValue, string jsVariableName)
    {
        return new JsBone(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBone AsJsBone(this JsType value)
    {
        return value is JsBone typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsDataTexture JsSet(this string jsVariableName, JsDataTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture JsSet(this JsDataTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture JsLet(this string jsVariableName, JsDataTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture JsLet(this JsDataTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture JsConst(this string jsVariableName, JsDataTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture JsConst(this JsDataTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture AsJsDataTextureVariable(this string jsVariableName, JsDataTexture jsVariableValue = null)
    {
        return new JsDataTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture AsJsDataTextureVariable(this JsDataTexture jsVariableValue, string jsVariableName)
    {
        return new JsDataTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTexture AsJsDataTexture(this JsType value)
    {
        return value is JsDataTexture typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsSkeleton JsSet(this string jsVariableName, JsSkeleton jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkeleton(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkeleton JsSet(this JsSkeleton jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkeleton(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkeleton JsLet(this string jsVariableName, JsSkeleton jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkeleton(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkeleton JsLet(this JsSkeleton jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkeleton(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkeleton JsConst(this string jsVariableName, JsSkeleton jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkeleton(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkeleton JsConst(this JsSkeleton jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkeleton(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkeleton AsJsSkeletonVariable(this string jsVariableName, JsSkeleton jsVariableValue = null)
    {
        return new JsSkeleton(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkeleton AsJsSkeletonVariable(this JsSkeleton jsVariableValue, string jsVariableName)
    {
        return new JsSkeleton(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkeleton AsJsSkeleton(this JsType value)
    {
        return value is JsSkeleton typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsInstancedBufferAttribute JsSet(this string jsVariableName, JsInstancedBufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedBufferAttribute JsSet(this JsInstancedBufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedBufferAttribute JsLet(this string jsVariableName, JsInstancedBufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedBufferAttribute JsLet(this JsInstancedBufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedBufferAttribute JsConst(this string jsVariableName, JsInstancedBufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedBufferAttribute JsConst(this JsInstancedBufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedBufferAttribute AsJsInstancedBufferAttributeVariable(this string jsVariableName, JsInstancedBufferAttribute jsVariableValue = null)
    {
        return new JsInstancedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedBufferAttribute AsJsInstancedBufferAttributeVariable(this JsInstancedBufferAttribute jsVariableValue, string jsVariableName)
    {
        return new JsInstancedBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedBufferAttribute AsJsInstancedBufferAttribute(this JsType value)
    {
        return value is JsInstancedBufferAttribute typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsInstancedMesh JsSet(this string jsVariableName, JsInstancedMesh jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedMesh JsSet(this JsInstancedMesh jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedMesh JsLet(this string jsVariableName, JsInstancedMesh jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedMesh JsLet(this JsInstancedMesh jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedMesh JsConst(this string jsVariableName, JsInstancedMesh jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedMesh JsConst(this JsInstancedMesh jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedMesh AsJsInstancedMeshVariable(this string jsVariableName, JsInstancedMesh jsVariableValue = null)
    {
        return new JsInstancedMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedMesh AsJsInstancedMeshVariable(this JsInstancedMesh jsVariableValue, string jsVariableName)
    {
        return new JsInstancedMesh(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedMesh AsJsInstancedMesh(this JsType value)
    {
        return value is JsInstancedMesh typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLineBasicMaterial JsSet(this string jsVariableName, JsLineBasicMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineBasicMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineBasicMaterial JsSet(this JsLineBasicMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineBasicMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineBasicMaterial JsLet(this string jsVariableName, JsLineBasicMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineBasicMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineBasicMaterial JsLet(this JsLineBasicMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineBasicMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineBasicMaterial JsConst(this string jsVariableName, JsLineBasicMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineBasicMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineBasicMaterial JsConst(this JsLineBasicMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineBasicMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineBasicMaterial AsJsLineBasicMaterialVariable(this string jsVariableName, JsLineBasicMaterial jsVariableValue = null)
    {
        return new JsLineBasicMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineBasicMaterial AsJsLineBasicMaterialVariable(this JsLineBasicMaterial jsVariableValue, string jsVariableName)
    {
        return new JsLineBasicMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineBasicMaterial AsJsLineBasicMaterial(this JsType value)
    {
        return value is JsLineBasicMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLine JsSet(this string jsVariableName, JsLine jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLine(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLine JsSet(this JsLine jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLine(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLine JsLet(this string jsVariableName, JsLine jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLine(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLine JsLet(this JsLine jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLine(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLine JsConst(this string jsVariableName, JsLine jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLine(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLine JsConst(this JsLine jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLine(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLine AsJsLineVariable(this string jsVariableName, JsLine jsVariableValue = null)
    {
        return new JsLine(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLine AsJsLineVariable(this JsLine jsVariableValue, string jsVariableName)
    {
        return new JsLine(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLine AsJsLine(this JsType value)
    {
        return value is JsLine typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLineSegments JsSet(this string jsVariableName, JsLineSegments jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineSegments(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineSegments JsSet(this JsLineSegments jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineSegments(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineSegments JsLet(this string jsVariableName, JsLineSegments jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineSegments(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineSegments JsLet(this JsLineSegments jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineSegments(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineSegments JsConst(this string jsVariableName, JsLineSegments jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineSegments(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineSegments JsConst(this JsLineSegments jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineSegments(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineSegments AsJsLineSegmentsVariable(this string jsVariableName, JsLineSegments jsVariableValue = null)
    {
        return new JsLineSegments(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineSegments AsJsLineSegmentsVariable(this JsLineSegments jsVariableValue, string jsVariableName)
    {
        return new JsLineSegments(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineSegments AsJsLineSegments(this JsType value)
    {
        return value is JsLineSegments typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLineLoop JsSet(this string jsVariableName, JsLineLoop jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineLoop(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineLoop JsSet(this JsLineLoop jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineLoop(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineLoop JsLet(this string jsVariableName, JsLineLoop jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineLoop(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineLoop JsLet(this JsLineLoop jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineLoop(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineLoop JsConst(this string jsVariableName, JsLineLoop jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineLoop(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineLoop JsConst(this JsLineLoop jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineLoop(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineLoop AsJsLineLoopVariable(this string jsVariableName, JsLineLoop jsVariableValue = null)
    {
        return new JsLineLoop(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineLoop AsJsLineLoopVariable(this JsLineLoop jsVariableValue, string jsVariableName)
    {
        return new JsLineLoop(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineLoop AsJsLineLoop(this JsType value)
    {
        return value is JsLineLoop typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsPointsMaterial JsSet(this string jsVariableName, JsPointsMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointsMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointsMaterial JsSet(this JsPointsMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointsMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointsMaterial JsLet(this string jsVariableName, JsPointsMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointsMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointsMaterial JsLet(this JsPointsMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointsMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointsMaterial JsConst(this string jsVariableName, JsPointsMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointsMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointsMaterial JsConst(this JsPointsMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointsMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointsMaterial AsJsPointsMaterialVariable(this string jsVariableName, JsPointsMaterial jsVariableValue = null)
    {
        return new JsPointsMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointsMaterial AsJsPointsMaterialVariable(this JsPointsMaterial jsVariableValue, string jsVariableName)
    {
        return new JsPointsMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointsMaterial AsJsPointsMaterial(this JsType value)
    {
        return value is JsPointsMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsPoints JsSet(this string jsVariableName, JsPoints jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPoints(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPoints JsSet(this JsPoints jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPoints(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPoints JsLet(this string jsVariableName, JsPoints jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPoints(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPoints JsLet(this JsPoints jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPoints(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPoints JsConst(this string jsVariableName, JsPoints jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPoints(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPoints JsConst(this JsPoints jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPoints(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPoints AsJsPointsVariable(this string jsVariableName, JsPoints jsVariableValue = null)
    {
        return new JsPoints(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPoints AsJsPointsVariable(this JsPoints jsVariableValue, string jsVariableName)
    {
        return new JsPoints(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPoints AsJsPoints(this JsType value)
    {
        return value is JsPoints typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsVideoTexture JsSet(this string jsVariableName, JsVideoTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVideoTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVideoTexture JsSet(this JsVideoTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVideoTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVideoTexture JsLet(this string jsVariableName, JsVideoTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVideoTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVideoTexture JsLet(this JsVideoTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVideoTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVideoTexture JsConst(this string jsVariableName, JsVideoTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVideoTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVideoTexture JsConst(this JsVideoTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVideoTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVideoTexture AsJsVideoTextureVariable(this string jsVariableName, JsVideoTexture jsVariableValue = null)
    {
        return new JsVideoTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVideoTexture AsJsVideoTextureVariable(this JsVideoTexture jsVariableValue, string jsVariableName)
    {
        return new JsVideoTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVideoTexture AsJsVideoTexture(this JsType value)
    {
        return value is JsVideoTexture typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCompressedTexture JsSet(this string jsVariableName, JsCompressedTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCompressedTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCompressedTexture JsSet(this JsCompressedTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCompressedTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCompressedTexture JsLet(this string jsVariableName, JsCompressedTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCompressedTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCompressedTexture JsLet(this JsCompressedTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCompressedTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCompressedTexture JsConst(this string jsVariableName, JsCompressedTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCompressedTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCompressedTexture JsConst(this JsCompressedTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCompressedTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCompressedTexture AsJsCompressedTextureVariable(this string jsVariableName, JsCompressedTexture jsVariableValue = null)
    {
        return new JsCompressedTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCompressedTexture AsJsCompressedTextureVariable(this JsCompressedTexture jsVariableValue, string jsVariableName)
    {
        return new JsCompressedTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCompressedTexture AsJsCompressedTexture(this JsType value)
    {
        return value is JsCompressedTexture typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCanvasTexture JsSet(this string jsVariableName, JsCanvasTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCanvasTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCanvasTexture JsSet(this JsCanvasTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCanvasTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCanvasTexture JsLet(this string jsVariableName, JsCanvasTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCanvasTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCanvasTexture JsLet(this JsCanvasTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCanvasTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCanvasTexture JsConst(this string jsVariableName, JsCanvasTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCanvasTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCanvasTexture JsConst(this JsCanvasTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCanvasTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCanvasTexture AsJsCanvasTextureVariable(this string jsVariableName, JsCanvasTexture jsVariableValue = null)
    {
        return new JsCanvasTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCanvasTexture AsJsCanvasTextureVariable(this JsCanvasTexture jsVariableValue, string jsVariableName)
    {
        return new JsCanvasTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCanvasTexture AsJsCanvasTexture(this JsType value)
    {
        return value is JsCanvasTexture typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsDepthTexture JsSet(this string jsVariableName, JsDepthTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDepthTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDepthTexture JsSet(this JsDepthTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDepthTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDepthTexture JsLet(this string jsVariableName, JsDepthTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDepthTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDepthTexture JsLet(this JsDepthTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDepthTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDepthTexture JsConst(this string jsVariableName, JsDepthTexture jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDepthTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDepthTexture JsConst(this JsDepthTexture jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDepthTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDepthTexture AsJsDepthTextureVariable(this string jsVariableName, JsDepthTexture jsVariableValue = null)
    {
        return new JsDepthTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDepthTexture AsJsDepthTextureVariable(this JsDepthTexture jsVariableValue, string jsVariableName)
    {
        return new JsDepthTexture(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDepthTexture AsJsDepthTexture(this JsType value)
    {
        return value is JsDepthTexture typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCircleGeometry JsSet(this string jsVariableName, JsCircleGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCircleGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCircleGeometry JsSet(this JsCircleGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCircleGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCircleGeometry JsLet(this string jsVariableName, JsCircleGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCircleGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCircleGeometry JsLet(this JsCircleGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCircleGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCircleGeometry JsConst(this string jsVariableName, JsCircleGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCircleGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCircleGeometry JsConst(this JsCircleGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCircleGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCircleGeometry AsJsCircleGeometryVariable(this string jsVariableName, JsCircleGeometry jsVariableValue = null)
    {
        return new JsCircleGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCircleGeometry AsJsCircleGeometryVariable(this JsCircleGeometry jsVariableValue, string jsVariableName)
    {
        return new JsCircleGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCircleGeometry AsJsCircleGeometry(this JsType value)
    {
        return value is JsCircleGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCylinderGeometry JsSet(this string jsVariableName, JsCylinderGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCylinderGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCylinderGeometry JsSet(this JsCylinderGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCylinderGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCylinderGeometry JsLet(this string jsVariableName, JsCylinderGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCylinderGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCylinderGeometry JsLet(this JsCylinderGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCylinderGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCylinderGeometry JsConst(this string jsVariableName, JsCylinderGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCylinderGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCylinderGeometry JsConst(this JsCylinderGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCylinderGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCylinderGeometry AsJsCylinderGeometryVariable(this string jsVariableName, JsCylinderGeometry jsVariableValue = null)
    {
        return new JsCylinderGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCylinderGeometry AsJsCylinderGeometryVariable(this JsCylinderGeometry jsVariableValue, string jsVariableName)
    {
        return new JsCylinderGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCylinderGeometry AsJsCylinderGeometry(this JsType value)
    {
        return value is JsCylinderGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsConeGeometry JsSet(this string jsVariableName, JsConeGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsConeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsConeGeometry JsSet(this JsConeGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsConeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsConeGeometry JsLet(this string jsVariableName, JsConeGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsConeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsConeGeometry JsLet(this JsConeGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsConeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsConeGeometry JsConst(this string jsVariableName, JsConeGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsConeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsConeGeometry JsConst(this JsConeGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsConeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsConeGeometry AsJsConeGeometryVariable(this string jsVariableName, JsConeGeometry jsVariableValue = null)
    {
        return new JsConeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsConeGeometry AsJsConeGeometryVariable(this JsConeGeometry jsVariableValue, string jsVariableName)
    {
        return new JsConeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsConeGeometry AsJsConeGeometry(this JsType value)
    {
        return value is JsConeGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsPolyhedronGeometry JsSet(this string jsVariableName, JsPolyhedronGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPolyhedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPolyhedronGeometry JsSet(this JsPolyhedronGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPolyhedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPolyhedronGeometry JsLet(this string jsVariableName, JsPolyhedronGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPolyhedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPolyhedronGeometry JsLet(this JsPolyhedronGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPolyhedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPolyhedronGeometry JsConst(this string jsVariableName, JsPolyhedronGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPolyhedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPolyhedronGeometry JsConst(this JsPolyhedronGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPolyhedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPolyhedronGeometry AsJsPolyhedronGeometryVariable(this string jsVariableName, JsPolyhedronGeometry jsVariableValue = null)
    {
        return new JsPolyhedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPolyhedronGeometry AsJsPolyhedronGeometryVariable(this JsPolyhedronGeometry jsVariableValue, string jsVariableName)
    {
        return new JsPolyhedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPolyhedronGeometry AsJsPolyhedronGeometry(this JsType value)
    {
        return value is JsPolyhedronGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsDodecahedronGeometry JsSet(this string jsVariableName, JsDodecahedronGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDodecahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDodecahedronGeometry JsSet(this JsDodecahedronGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDodecahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDodecahedronGeometry JsLet(this string jsVariableName, JsDodecahedronGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDodecahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDodecahedronGeometry JsLet(this JsDodecahedronGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDodecahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDodecahedronGeometry JsConst(this string jsVariableName, JsDodecahedronGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDodecahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDodecahedronGeometry JsConst(this JsDodecahedronGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDodecahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDodecahedronGeometry AsJsDodecahedronGeometryVariable(this string jsVariableName, JsDodecahedronGeometry jsVariableValue = null)
    {
        return new JsDodecahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDodecahedronGeometry AsJsDodecahedronGeometryVariable(this JsDodecahedronGeometry jsVariableValue, string jsVariableName)
    {
        return new JsDodecahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDodecahedronGeometry AsJsDodecahedronGeometry(this JsType value)
    {
        return value is JsDodecahedronGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsEdgesGeometry JsSet(this string jsVariableName, JsEdgesGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEdgesGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEdgesGeometry JsSet(this JsEdgesGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEdgesGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEdgesGeometry JsLet(this string jsVariableName, JsEdgesGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEdgesGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEdgesGeometry JsLet(this JsEdgesGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEdgesGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEdgesGeometry JsConst(this string jsVariableName, JsEdgesGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEdgesGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEdgesGeometry JsConst(this JsEdgesGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEdgesGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEdgesGeometry AsJsEdgesGeometryVariable(this string jsVariableName, JsEdgesGeometry jsVariableValue = null)
    {
        return new JsEdgesGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEdgesGeometry AsJsEdgesGeometryVariable(this JsEdgesGeometry jsVariableValue, string jsVariableName)
    {
        return new JsEdgesGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEdgesGeometry AsJsEdgesGeometry(this JsType value)
    {
        return value is JsEdgesGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCurve JsSet(this string jsVariableName, JsCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCurve JsSet(this JsCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCurve JsLet(this string jsVariableName, JsCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCurve JsLet(this JsCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCurve JsConst(this string jsVariableName, JsCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCurve JsConst(this JsCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCurve AsJsCurveVariable(this string jsVariableName, JsCurve jsVariableValue = null)
    {
        return new JsCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCurve AsJsCurveVariable(this JsCurve jsVariableValue, string jsVariableName)
    {
        return new JsCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCurve AsJsCurve(this JsType value)
    {
        return value is JsCurve typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsEllipseCurve JsSet(this string jsVariableName, JsEllipseCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEllipseCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEllipseCurve JsSet(this JsEllipseCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEllipseCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEllipseCurve JsLet(this string jsVariableName, JsEllipseCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEllipseCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEllipseCurve JsLet(this JsEllipseCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEllipseCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEllipseCurve JsConst(this string jsVariableName, JsEllipseCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEllipseCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEllipseCurve JsConst(this JsEllipseCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsEllipseCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEllipseCurve AsJsEllipseCurveVariable(this string jsVariableName, JsEllipseCurve jsVariableValue = null)
    {
        return new JsEllipseCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEllipseCurve AsJsEllipseCurveVariable(this JsEllipseCurve jsVariableValue, string jsVariableName)
    {
        return new JsEllipseCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsEllipseCurve AsJsEllipseCurve(this JsType value)
    {
        return value is JsEllipseCurve typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsArcCurve JsSet(this string jsVariableName, JsArcCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArcCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArcCurve JsSet(this JsArcCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArcCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArcCurve JsLet(this string jsVariableName, JsArcCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArcCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArcCurve JsLet(this JsArcCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArcCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArcCurve JsConst(this string jsVariableName, JsArcCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArcCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArcCurve JsConst(this JsArcCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArcCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArcCurve AsJsArcCurveVariable(this string jsVariableName, JsArcCurve jsVariableValue = null)
    {
        return new JsArcCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArcCurve AsJsArcCurveVariable(this JsArcCurve jsVariableValue, string jsVariableName)
    {
        return new JsArcCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArcCurve AsJsArcCurve(this JsType value)
    {
        return value is JsArcCurve typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCatmullRomCurve3 JsSet(this string jsVariableName, JsCatmullRomCurve3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCatmullRomCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCatmullRomCurve3 JsSet(this JsCatmullRomCurve3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCatmullRomCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCatmullRomCurve3 JsLet(this string jsVariableName, JsCatmullRomCurve3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCatmullRomCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCatmullRomCurve3 JsLet(this JsCatmullRomCurve3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCatmullRomCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCatmullRomCurve3 JsConst(this string jsVariableName, JsCatmullRomCurve3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCatmullRomCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCatmullRomCurve3 JsConst(this JsCatmullRomCurve3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCatmullRomCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCatmullRomCurve3 AsJsCatmullRomCurve3Variable(this string jsVariableName, JsCatmullRomCurve3 jsVariableValue = null)
    {
        return new JsCatmullRomCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCatmullRomCurve3 AsJsCatmullRomCurve3Variable(this JsCatmullRomCurve3 jsVariableValue, string jsVariableName)
    {
        return new JsCatmullRomCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCatmullRomCurve3 AsJsCatmullRomCurve3(this JsType value)
    {
        return value is JsCatmullRomCurve3 typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCubicBezierCurve JsSet(this string jsVariableName, JsCubicBezierCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicBezierCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicBezierCurve JsSet(this JsCubicBezierCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicBezierCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicBezierCurve JsLet(this string jsVariableName, JsCubicBezierCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicBezierCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicBezierCurve JsLet(this JsCubicBezierCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicBezierCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicBezierCurve JsConst(this string jsVariableName, JsCubicBezierCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicBezierCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicBezierCurve JsConst(this JsCubicBezierCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicBezierCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicBezierCurve AsJsCubicBezierCurveVariable(this string jsVariableName, JsCubicBezierCurve jsVariableValue = null)
    {
        return new JsCubicBezierCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicBezierCurve AsJsCubicBezierCurveVariable(this JsCubicBezierCurve jsVariableValue, string jsVariableName)
    {
        return new JsCubicBezierCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicBezierCurve AsJsCubicBezierCurve(this JsType value)
    {
        return value is JsCubicBezierCurve typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCubicBezierCurve3 JsSet(this string jsVariableName, JsCubicBezierCurve3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicBezierCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicBezierCurve3 JsSet(this JsCubicBezierCurve3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicBezierCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicBezierCurve3 JsLet(this string jsVariableName, JsCubicBezierCurve3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicBezierCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicBezierCurve3 JsLet(this JsCubicBezierCurve3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicBezierCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicBezierCurve3 JsConst(this string jsVariableName, JsCubicBezierCurve3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicBezierCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicBezierCurve3 JsConst(this JsCubicBezierCurve3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicBezierCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicBezierCurve3 AsJsCubicBezierCurve3Variable(this string jsVariableName, JsCubicBezierCurve3 jsVariableValue = null)
    {
        return new JsCubicBezierCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicBezierCurve3 AsJsCubicBezierCurve3Variable(this JsCubicBezierCurve3 jsVariableValue, string jsVariableName)
    {
        return new JsCubicBezierCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicBezierCurve3 AsJsCubicBezierCurve3(this JsType value)
    {
        return value is JsCubicBezierCurve3 typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLineCurve JsSet(this string jsVariableName, JsLineCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineCurve JsSet(this JsLineCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineCurve JsLet(this string jsVariableName, JsLineCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineCurve JsLet(this JsLineCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineCurve JsConst(this string jsVariableName, JsLineCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineCurve JsConst(this JsLineCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineCurve AsJsLineCurveVariable(this string jsVariableName, JsLineCurve jsVariableValue = null)
    {
        return new JsLineCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineCurve AsJsLineCurveVariable(this JsLineCurve jsVariableValue, string jsVariableName)
    {
        return new JsLineCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineCurve AsJsLineCurve(this JsType value)
    {
        return value is JsLineCurve typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLineCurve3 JsSet(this string jsVariableName, JsLineCurve3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineCurve3 JsSet(this JsLineCurve3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineCurve3 JsLet(this string jsVariableName, JsLineCurve3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineCurve3 JsLet(this JsLineCurve3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineCurve3 JsConst(this string jsVariableName, JsLineCurve3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineCurve3 JsConst(this JsLineCurve3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineCurve3 AsJsLineCurve3Variable(this string jsVariableName, JsLineCurve3 jsVariableValue = null)
    {
        return new JsLineCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineCurve3 AsJsLineCurve3Variable(this JsLineCurve3 jsVariableValue, string jsVariableName)
    {
        return new JsLineCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineCurve3 AsJsLineCurve3(this JsType value)
    {
        return value is JsLineCurve3 typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsQuadraticBezierCurve JsSet(this string jsVariableName, JsQuadraticBezierCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuadraticBezierCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuadraticBezierCurve JsSet(this JsQuadraticBezierCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuadraticBezierCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuadraticBezierCurve JsLet(this string jsVariableName, JsQuadraticBezierCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuadraticBezierCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuadraticBezierCurve JsLet(this JsQuadraticBezierCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuadraticBezierCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuadraticBezierCurve JsConst(this string jsVariableName, JsQuadraticBezierCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuadraticBezierCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuadraticBezierCurve JsConst(this JsQuadraticBezierCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuadraticBezierCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuadraticBezierCurve AsJsQuadraticBezierCurveVariable(this string jsVariableName, JsQuadraticBezierCurve jsVariableValue = null)
    {
        return new JsQuadraticBezierCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuadraticBezierCurve AsJsQuadraticBezierCurveVariable(this JsQuadraticBezierCurve jsVariableValue, string jsVariableName)
    {
        return new JsQuadraticBezierCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuadraticBezierCurve AsJsQuadraticBezierCurve(this JsType value)
    {
        return value is JsQuadraticBezierCurve typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsQuadraticBezierCurve3 JsSet(this string jsVariableName, JsQuadraticBezierCurve3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuadraticBezierCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuadraticBezierCurve3 JsSet(this JsQuadraticBezierCurve3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuadraticBezierCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuadraticBezierCurve3 JsLet(this string jsVariableName, JsQuadraticBezierCurve3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuadraticBezierCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuadraticBezierCurve3 JsLet(this JsQuadraticBezierCurve3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuadraticBezierCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuadraticBezierCurve3 JsConst(this string jsVariableName, JsQuadraticBezierCurve3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuadraticBezierCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuadraticBezierCurve3 JsConst(this JsQuadraticBezierCurve3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuadraticBezierCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuadraticBezierCurve3 AsJsQuadraticBezierCurve3Variable(this string jsVariableName, JsQuadraticBezierCurve3 jsVariableValue = null)
    {
        return new JsQuadraticBezierCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuadraticBezierCurve3 AsJsQuadraticBezierCurve3Variable(this JsQuadraticBezierCurve3 jsVariableValue, string jsVariableName)
    {
        return new JsQuadraticBezierCurve3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuadraticBezierCurve3 AsJsQuadraticBezierCurve3(this JsType value)
    {
        return value is JsQuadraticBezierCurve3 typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsSplineCurve JsSet(this string jsVariableName, JsSplineCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSplineCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSplineCurve JsSet(this JsSplineCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSplineCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSplineCurve JsLet(this string jsVariableName, JsSplineCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSplineCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSplineCurve JsLet(this JsSplineCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSplineCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSplineCurve JsConst(this string jsVariableName, JsSplineCurve jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSplineCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSplineCurve JsConst(this JsSplineCurve jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSplineCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSplineCurve AsJsSplineCurveVariable(this string jsVariableName, JsSplineCurve jsVariableValue = null)
    {
        return new JsSplineCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSplineCurve AsJsSplineCurveVariable(this JsSplineCurve jsVariableValue, string jsVariableName)
    {
        return new JsSplineCurve(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSplineCurve AsJsSplineCurve(this JsType value)
    {
        return value is JsSplineCurve typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCurvePath JsSet(this string jsVariableName, JsCurvePath jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCurvePath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCurvePath JsSet(this JsCurvePath jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCurvePath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCurvePath JsLet(this string jsVariableName, JsCurvePath jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCurvePath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCurvePath JsLet(this JsCurvePath jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCurvePath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCurvePath JsConst(this string jsVariableName, JsCurvePath jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCurvePath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCurvePath JsConst(this JsCurvePath jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCurvePath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCurvePath AsJsCurvePathVariable(this string jsVariableName, JsCurvePath jsVariableValue = null)
    {
        return new JsCurvePath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCurvePath AsJsCurvePathVariable(this JsCurvePath jsVariableValue, string jsVariableName)
    {
        return new JsCurvePath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCurvePath AsJsCurvePath(this JsType value)
    {
        return value is JsCurvePath typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsPath JsSet(this string jsVariableName, JsPath jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPath JsSet(this JsPath jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPath JsLet(this string jsVariableName, JsPath jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPath JsLet(this JsPath jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPath JsConst(this string jsVariableName, JsPath jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPath JsConst(this JsPath jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPath AsJsPathVariable(this string jsVariableName, JsPath jsVariableValue = null)
    {
        return new JsPath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPath AsJsPathVariable(this JsPath jsVariableValue, string jsVariableName)
    {
        return new JsPath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPath AsJsPath(this JsType value)
    {
        return value is JsPath typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsShape JsSet(this string jsVariableName, JsShape jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShape(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShape JsSet(this JsShape jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShape(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShape JsLet(this string jsVariableName, JsShape jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShape(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShape JsLet(this JsShape jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShape(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShape JsConst(this string jsVariableName, JsShape jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShape(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShape JsConst(this JsShape jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShape(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShape AsJsShapeVariable(this string jsVariableName, JsShape jsVariableValue = null)
    {
        return new JsShape(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShape AsJsShapeVariable(this JsShape jsVariableValue, string jsVariableName)
    {
        return new JsShape(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShape AsJsShape(this JsType value)
    {
        return value is JsShape typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsShapeUtils JsSet(this string jsVariableName, JsShapeUtils jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapeUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapeUtils JsSet(this JsShapeUtils jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapeUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapeUtils JsLet(this string jsVariableName, JsShapeUtils jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapeUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapeUtils JsLet(this JsShapeUtils jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapeUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapeUtils JsConst(this string jsVariableName, JsShapeUtils jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapeUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapeUtils JsConst(this JsShapeUtils jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapeUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapeUtils AsJsShapeUtilsVariable(this string jsVariableName, JsShapeUtils jsVariableValue = null)
    {
        return new JsShapeUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapeUtils AsJsShapeUtilsVariable(this JsShapeUtils jsVariableValue, string jsVariableName)
    {
        return new JsShapeUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapeUtils AsJsShapeUtils(this JsType value)
    {
        return value is JsShapeUtils typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsExtrudeGeometry JsSet(this string jsVariableName, JsExtrudeGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsExtrudeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsExtrudeGeometry JsSet(this JsExtrudeGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsExtrudeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsExtrudeGeometry JsLet(this string jsVariableName, JsExtrudeGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsExtrudeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsExtrudeGeometry JsLet(this JsExtrudeGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsExtrudeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsExtrudeGeometry JsConst(this string jsVariableName, JsExtrudeGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsExtrudeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsExtrudeGeometry JsConst(this JsExtrudeGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsExtrudeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsExtrudeGeometry AsJsExtrudeGeometryVariable(this string jsVariableName, JsExtrudeGeometry jsVariableValue = null)
    {
        return new JsExtrudeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsExtrudeGeometry AsJsExtrudeGeometryVariable(this JsExtrudeGeometry jsVariableValue, string jsVariableName)
    {
        return new JsExtrudeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsExtrudeGeometry AsJsExtrudeGeometry(this JsType value)
    {
        return value is JsExtrudeGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsIcosahedronGeometry JsSet(this string jsVariableName, JsIcosahedronGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsIcosahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsIcosahedronGeometry JsSet(this JsIcosahedronGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsIcosahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsIcosahedronGeometry JsLet(this string jsVariableName, JsIcosahedronGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsIcosahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsIcosahedronGeometry JsLet(this JsIcosahedronGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsIcosahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsIcosahedronGeometry JsConst(this string jsVariableName, JsIcosahedronGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsIcosahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsIcosahedronGeometry JsConst(this JsIcosahedronGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsIcosahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsIcosahedronGeometry AsJsIcosahedronGeometryVariable(this string jsVariableName, JsIcosahedronGeometry jsVariableValue = null)
    {
        return new JsIcosahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsIcosahedronGeometry AsJsIcosahedronGeometryVariable(this JsIcosahedronGeometry jsVariableValue, string jsVariableName)
    {
        return new JsIcosahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsIcosahedronGeometry AsJsIcosahedronGeometry(this JsType value)
    {
        return value is JsIcosahedronGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLatheGeometry JsSet(this string jsVariableName, JsLatheGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLatheGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLatheGeometry JsSet(this JsLatheGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLatheGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLatheGeometry JsLet(this string jsVariableName, JsLatheGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLatheGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLatheGeometry JsLet(this JsLatheGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLatheGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLatheGeometry JsConst(this string jsVariableName, JsLatheGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLatheGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLatheGeometry JsConst(this JsLatheGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLatheGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLatheGeometry AsJsLatheGeometryVariable(this string jsVariableName, JsLatheGeometry jsVariableValue = null)
    {
        return new JsLatheGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLatheGeometry AsJsLatheGeometryVariable(this JsLatheGeometry jsVariableValue, string jsVariableName)
    {
        return new JsLatheGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLatheGeometry AsJsLatheGeometry(this JsType value)
    {
        return value is JsLatheGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsOctahedronGeometry JsSet(this string jsVariableName, JsOctahedronGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsOctahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsOctahedronGeometry JsSet(this JsOctahedronGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsOctahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsOctahedronGeometry JsLet(this string jsVariableName, JsOctahedronGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsOctahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsOctahedronGeometry JsLet(this JsOctahedronGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsOctahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsOctahedronGeometry JsConst(this string jsVariableName, JsOctahedronGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsOctahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsOctahedronGeometry JsConst(this JsOctahedronGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsOctahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsOctahedronGeometry AsJsOctahedronGeometryVariable(this string jsVariableName, JsOctahedronGeometry jsVariableValue = null)
    {
        return new JsOctahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsOctahedronGeometry AsJsOctahedronGeometryVariable(this JsOctahedronGeometry jsVariableValue, string jsVariableName)
    {
        return new JsOctahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsOctahedronGeometry AsJsOctahedronGeometry(this JsType value)
    {
        return value is JsOctahedronGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsRingGeometry JsSet(this string jsVariableName, JsRingGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRingGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRingGeometry JsSet(this JsRingGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRingGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRingGeometry JsLet(this string jsVariableName, JsRingGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRingGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRingGeometry JsLet(this JsRingGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRingGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRingGeometry JsConst(this string jsVariableName, JsRingGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRingGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRingGeometry JsConst(this JsRingGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRingGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRingGeometry AsJsRingGeometryVariable(this string jsVariableName, JsRingGeometry jsVariableValue = null)
    {
        return new JsRingGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRingGeometry AsJsRingGeometryVariable(this JsRingGeometry jsVariableValue, string jsVariableName)
    {
        return new JsRingGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRingGeometry AsJsRingGeometry(this JsType value)
    {
        return value is JsRingGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsShapeGeometry JsSet(this string jsVariableName, JsShapeGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapeGeometry JsSet(this JsShapeGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapeGeometry JsLet(this string jsVariableName, JsShapeGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapeGeometry JsLet(this JsShapeGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapeGeometry JsConst(this string jsVariableName, JsShapeGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapeGeometry JsConst(this JsShapeGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapeGeometry AsJsShapeGeometryVariable(this string jsVariableName, JsShapeGeometry jsVariableValue = null)
    {
        return new JsShapeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapeGeometry AsJsShapeGeometryVariable(this JsShapeGeometry jsVariableValue, string jsVariableName)
    {
        return new JsShapeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapeGeometry AsJsShapeGeometry(this JsType value)
    {
        return value is JsShapeGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsSphereGeometry JsSet(this string jsVariableName, JsSphereGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphereGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphereGeometry JsSet(this JsSphereGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphereGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphereGeometry JsLet(this string jsVariableName, JsSphereGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphereGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphereGeometry JsLet(this JsSphereGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphereGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphereGeometry JsConst(this string jsVariableName, JsSphereGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphereGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphereGeometry JsConst(this JsSphereGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphereGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphereGeometry AsJsSphereGeometryVariable(this string jsVariableName, JsSphereGeometry jsVariableValue = null)
    {
        return new JsSphereGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphereGeometry AsJsSphereGeometryVariable(this JsSphereGeometry jsVariableValue, string jsVariableName)
    {
        return new JsSphereGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphereGeometry AsJsSphereGeometry(this JsType value)
    {
        return value is JsSphereGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsTetrahedronGeometry JsSet(this string jsVariableName, JsTetrahedronGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTetrahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTetrahedronGeometry JsSet(this JsTetrahedronGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTetrahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTetrahedronGeometry JsLet(this string jsVariableName, JsTetrahedronGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTetrahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTetrahedronGeometry JsLet(this JsTetrahedronGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTetrahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTetrahedronGeometry JsConst(this string jsVariableName, JsTetrahedronGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTetrahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTetrahedronGeometry JsConst(this JsTetrahedronGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTetrahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTetrahedronGeometry AsJsTetrahedronGeometryVariable(this string jsVariableName, JsTetrahedronGeometry jsVariableValue = null)
    {
        return new JsTetrahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTetrahedronGeometry AsJsTetrahedronGeometryVariable(this JsTetrahedronGeometry jsVariableValue, string jsVariableName)
    {
        return new JsTetrahedronGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTetrahedronGeometry AsJsTetrahedronGeometry(this JsType value)
    {
        return value is JsTetrahedronGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsTorusGeometry JsSet(this string jsVariableName, JsTorusGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTorusGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTorusGeometry JsSet(this JsTorusGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTorusGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTorusGeometry JsLet(this string jsVariableName, JsTorusGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTorusGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTorusGeometry JsLet(this JsTorusGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTorusGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTorusGeometry JsConst(this string jsVariableName, JsTorusGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTorusGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTorusGeometry JsConst(this JsTorusGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTorusGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTorusGeometry AsJsTorusGeometryVariable(this string jsVariableName, JsTorusGeometry jsVariableValue = null)
    {
        return new JsTorusGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTorusGeometry AsJsTorusGeometryVariable(this JsTorusGeometry jsVariableValue, string jsVariableName)
    {
        return new JsTorusGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTorusGeometry AsJsTorusGeometry(this JsType value)
    {
        return value is JsTorusGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsTorusKnotGeometry JsSet(this string jsVariableName, JsTorusKnotGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTorusKnotGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTorusKnotGeometry JsSet(this JsTorusKnotGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTorusKnotGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTorusKnotGeometry JsLet(this string jsVariableName, JsTorusKnotGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTorusKnotGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTorusKnotGeometry JsLet(this JsTorusKnotGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTorusKnotGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTorusKnotGeometry JsConst(this string jsVariableName, JsTorusKnotGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTorusKnotGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTorusKnotGeometry JsConst(this JsTorusKnotGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTorusKnotGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTorusKnotGeometry AsJsTorusKnotGeometryVariable(this string jsVariableName, JsTorusKnotGeometry jsVariableValue = null)
    {
        return new JsTorusKnotGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTorusKnotGeometry AsJsTorusKnotGeometryVariable(this JsTorusKnotGeometry jsVariableValue, string jsVariableName)
    {
        return new JsTorusKnotGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTorusKnotGeometry AsJsTorusKnotGeometry(this JsType value)
    {
        return value is JsTorusKnotGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsTubeGeometry JsSet(this string jsVariableName, JsTubeGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTubeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTubeGeometry JsSet(this JsTubeGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTubeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTubeGeometry JsLet(this string jsVariableName, JsTubeGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTubeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTubeGeometry JsLet(this JsTubeGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTubeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTubeGeometry JsConst(this string jsVariableName, JsTubeGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTubeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTubeGeometry JsConst(this JsTubeGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTubeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTubeGeometry AsJsTubeGeometryVariable(this string jsVariableName, JsTubeGeometry jsVariableValue = null)
    {
        return new JsTubeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTubeGeometry AsJsTubeGeometryVariable(this JsTubeGeometry jsVariableValue, string jsVariableName)
    {
        return new JsTubeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTubeGeometry AsJsTubeGeometry(this JsType value)
    {
        return value is JsTubeGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsWireframeGeometry JsSet(this string jsVariableName, JsWireframeGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWireframeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWireframeGeometry JsSet(this JsWireframeGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWireframeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWireframeGeometry JsLet(this string jsVariableName, JsWireframeGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWireframeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWireframeGeometry JsLet(this JsWireframeGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWireframeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWireframeGeometry JsConst(this string jsVariableName, JsWireframeGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWireframeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWireframeGeometry JsConst(this JsWireframeGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsWireframeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWireframeGeometry AsJsWireframeGeometryVariable(this string jsVariableName, JsWireframeGeometry jsVariableValue = null)
    {
        return new JsWireframeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWireframeGeometry AsJsWireframeGeometryVariable(this JsWireframeGeometry jsVariableValue, string jsVariableName)
    {
        return new JsWireframeGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsWireframeGeometry AsJsWireframeGeometry(this JsType value)
    {
        return value is JsWireframeGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsShadowMaterial JsSet(this string jsVariableName, JsShadowMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShadowMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShadowMaterial JsSet(this JsShadowMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShadowMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShadowMaterial JsLet(this string jsVariableName, JsShadowMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShadowMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShadowMaterial JsLet(this JsShadowMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShadowMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShadowMaterial JsConst(this string jsVariableName, JsShadowMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShadowMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShadowMaterial JsConst(this JsShadowMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShadowMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShadowMaterial AsJsShadowMaterialVariable(this string jsVariableName, JsShadowMaterial jsVariableValue = null)
    {
        return new JsShadowMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShadowMaterial AsJsShadowMaterialVariable(this JsShadowMaterial jsVariableValue, string jsVariableName)
    {
        return new JsShadowMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShadowMaterial AsJsShadowMaterial(this JsType value)
    {
        return value is JsShadowMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsMeshStandardMaterial JsSet(this string jsVariableName, JsMeshStandardMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshStandardMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshStandardMaterial JsSet(this JsMeshStandardMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshStandardMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshStandardMaterial JsLet(this string jsVariableName, JsMeshStandardMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshStandardMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshStandardMaterial JsLet(this JsMeshStandardMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshStandardMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshStandardMaterial JsConst(this string jsVariableName, JsMeshStandardMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshStandardMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshStandardMaterial JsConst(this JsMeshStandardMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshStandardMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshStandardMaterial AsJsMeshStandardMaterialVariable(this string jsVariableName, JsMeshStandardMaterial jsVariableValue = null)
    {
        return new JsMeshStandardMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshStandardMaterial AsJsMeshStandardMaterialVariable(this JsMeshStandardMaterial jsVariableValue, string jsVariableName)
    {
        return new JsMeshStandardMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshStandardMaterial AsJsMeshStandardMaterial(this JsType value)
    {
        return value is JsMeshStandardMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsMeshPhysicalMaterial JsSet(this string jsVariableName, JsMeshPhysicalMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshPhysicalMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshPhysicalMaterial JsSet(this JsMeshPhysicalMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshPhysicalMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshPhysicalMaterial JsLet(this string jsVariableName, JsMeshPhysicalMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshPhysicalMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshPhysicalMaterial JsLet(this JsMeshPhysicalMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshPhysicalMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshPhysicalMaterial JsConst(this string jsVariableName, JsMeshPhysicalMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshPhysicalMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshPhysicalMaterial JsConst(this JsMeshPhysicalMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshPhysicalMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshPhysicalMaterial AsJsMeshPhysicalMaterialVariable(this string jsVariableName, JsMeshPhysicalMaterial jsVariableValue = null)
    {
        return new JsMeshPhysicalMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshPhysicalMaterial AsJsMeshPhysicalMaterialVariable(this JsMeshPhysicalMaterial jsVariableValue, string jsVariableName)
    {
        return new JsMeshPhysicalMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshPhysicalMaterial AsJsMeshPhysicalMaterial(this JsType value)
    {
        return value is JsMeshPhysicalMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsMeshPhongMaterial JsSet(this string jsVariableName, JsMeshPhongMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshPhongMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshPhongMaterial JsSet(this JsMeshPhongMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshPhongMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshPhongMaterial JsLet(this string jsVariableName, JsMeshPhongMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshPhongMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshPhongMaterial JsLet(this JsMeshPhongMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshPhongMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshPhongMaterial JsConst(this string jsVariableName, JsMeshPhongMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshPhongMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshPhongMaterial JsConst(this JsMeshPhongMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshPhongMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshPhongMaterial AsJsMeshPhongMaterialVariable(this string jsVariableName, JsMeshPhongMaterial jsVariableValue = null)
    {
        return new JsMeshPhongMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshPhongMaterial AsJsMeshPhongMaterialVariable(this JsMeshPhongMaterial jsVariableValue, string jsVariableName)
    {
        return new JsMeshPhongMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshPhongMaterial AsJsMeshPhongMaterial(this JsType value)
    {
        return value is JsMeshPhongMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsMeshToonMaterial JsSet(this string jsVariableName, JsMeshToonMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshToonMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshToonMaterial JsSet(this JsMeshToonMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshToonMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshToonMaterial JsLet(this string jsVariableName, JsMeshToonMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshToonMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshToonMaterial JsLet(this JsMeshToonMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshToonMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshToonMaterial JsConst(this string jsVariableName, JsMeshToonMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshToonMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshToonMaterial JsConst(this JsMeshToonMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshToonMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshToonMaterial AsJsMeshToonMaterialVariable(this string jsVariableName, JsMeshToonMaterial jsVariableValue = null)
    {
        return new JsMeshToonMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshToonMaterial AsJsMeshToonMaterialVariable(this JsMeshToonMaterial jsVariableValue, string jsVariableName)
    {
        return new JsMeshToonMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshToonMaterial AsJsMeshToonMaterial(this JsType value)
    {
        return value is JsMeshToonMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsMeshNormalMaterial JsSet(this string jsVariableName, JsMeshNormalMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshNormalMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshNormalMaterial JsSet(this JsMeshNormalMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshNormalMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshNormalMaterial JsLet(this string jsVariableName, JsMeshNormalMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshNormalMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshNormalMaterial JsLet(this JsMeshNormalMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshNormalMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshNormalMaterial JsConst(this string jsVariableName, JsMeshNormalMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshNormalMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshNormalMaterial JsConst(this JsMeshNormalMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshNormalMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshNormalMaterial AsJsMeshNormalMaterialVariable(this string jsVariableName, JsMeshNormalMaterial jsVariableValue = null)
    {
        return new JsMeshNormalMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshNormalMaterial AsJsMeshNormalMaterialVariable(this JsMeshNormalMaterial jsVariableValue, string jsVariableName)
    {
        return new JsMeshNormalMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshNormalMaterial AsJsMeshNormalMaterial(this JsType value)
    {
        return value is JsMeshNormalMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsMeshLambertMaterial JsSet(this string jsVariableName, JsMeshLambertMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshLambertMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshLambertMaterial JsSet(this JsMeshLambertMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshLambertMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshLambertMaterial JsLet(this string jsVariableName, JsMeshLambertMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshLambertMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshLambertMaterial JsLet(this JsMeshLambertMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshLambertMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshLambertMaterial JsConst(this string jsVariableName, JsMeshLambertMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshLambertMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshLambertMaterial JsConst(this JsMeshLambertMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshLambertMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshLambertMaterial AsJsMeshLambertMaterialVariable(this string jsVariableName, JsMeshLambertMaterial jsVariableValue = null)
    {
        return new JsMeshLambertMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshLambertMaterial AsJsMeshLambertMaterialVariable(this JsMeshLambertMaterial jsVariableValue, string jsVariableName)
    {
        return new JsMeshLambertMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshLambertMaterial AsJsMeshLambertMaterial(this JsType value)
    {
        return value is JsMeshLambertMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsMeshMatcapMaterial JsSet(this string jsVariableName, JsMeshMatcapMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshMatcapMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshMatcapMaterial JsSet(this JsMeshMatcapMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshMatcapMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshMatcapMaterial JsLet(this string jsVariableName, JsMeshMatcapMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshMatcapMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshMatcapMaterial JsLet(this JsMeshMatcapMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshMatcapMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshMatcapMaterial JsConst(this string jsVariableName, JsMeshMatcapMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshMatcapMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshMatcapMaterial JsConst(this JsMeshMatcapMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMeshMatcapMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshMatcapMaterial AsJsMeshMatcapMaterialVariable(this string jsVariableName, JsMeshMatcapMaterial jsVariableValue = null)
    {
        return new JsMeshMatcapMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshMatcapMaterial AsJsMeshMatcapMaterialVariable(this JsMeshMatcapMaterial jsVariableValue, string jsVariableName)
    {
        return new JsMeshMatcapMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMeshMatcapMaterial AsJsMeshMatcapMaterial(this JsType value)
    {
        return value is JsMeshMatcapMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLineDashedMaterial JsSet(this string jsVariableName, JsLineDashedMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineDashedMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineDashedMaterial JsSet(this JsLineDashedMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineDashedMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineDashedMaterial JsLet(this string jsVariableName, JsLineDashedMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineDashedMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineDashedMaterial JsLet(this JsLineDashedMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineDashedMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineDashedMaterial JsConst(this string jsVariableName, JsLineDashedMaterial jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineDashedMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineDashedMaterial JsConst(this JsLineDashedMaterial jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLineDashedMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineDashedMaterial AsJsLineDashedMaterialVariable(this string jsVariableName, JsLineDashedMaterial jsVariableValue = null)
    {
        return new JsLineDashedMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineDashedMaterial AsJsLineDashedMaterialVariable(this JsLineDashedMaterial jsVariableValue, string jsVariableName)
    {
        return new JsLineDashedMaterial(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLineDashedMaterial AsJsLineDashedMaterial(this JsType value)
    {
        return value is JsLineDashedMaterial typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsInterpolant JsSet(this string jsVariableName, JsInterpolant jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterpolant JsSet(this JsInterpolant jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterpolant JsLet(this string jsVariableName, JsInterpolant jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterpolant JsLet(this JsInterpolant jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterpolant JsConst(this string jsVariableName, JsInterpolant jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterpolant JsConst(this JsInterpolant jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterpolant AsJsInterpolantVariable(this string jsVariableName, JsInterpolant jsVariableValue = null)
    {
        return new JsInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterpolant AsJsInterpolantVariable(this JsInterpolant jsVariableValue, string jsVariableName)
    {
        return new JsInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInterpolant AsJsInterpolant(this JsType value)
    {
        return value is JsInterpolant typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCubicInterpolant JsSet(this string jsVariableName, JsCubicInterpolant jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicInterpolant JsSet(this JsCubicInterpolant jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicInterpolant JsLet(this string jsVariableName, JsCubicInterpolant jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicInterpolant JsLet(this JsCubicInterpolant jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicInterpolant JsConst(this string jsVariableName, JsCubicInterpolant jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicInterpolant JsConst(this JsCubicInterpolant jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubicInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicInterpolant AsJsCubicInterpolantVariable(this string jsVariableName, JsCubicInterpolant jsVariableValue = null)
    {
        return new JsCubicInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicInterpolant AsJsCubicInterpolantVariable(this JsCubicInterpolant jsVariableValue, string jsVariableName)
    {
        return new JsCubicInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubicInterpolant AsJsCubicInterpolant(this JsType value)
    {
        return value is JsCubicInterpolant typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLinearInterpolant JsSet(this string jsVariableName, JsLinearInterpolant jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLinearInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLinearInterpolant JsSet(this JsLinearInterpolant jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLinearInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLinearInterpolant JsLet(this string jsVariableName, JsLinearInterpolant jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLinearInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLinearInterpolant JsLet(this JsLinearInterpolant jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLinearInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLinearInterpolant JsConst(this string jsVariableName, JsLinearInterpolant jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLinearInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLinearInterpolant JsConst(this JsLinearInterpolant jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLinearInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLinearInterpolant AsJsLinearInterpolantVariable(this string jsVariableName, JsLinearInterpolant jsVariableValue = null)
    {
        return new JsLinearInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLinearInterpolant AsJsLinearInterpolantVariable(this JsLinearInterpolant jsVariableValue, string jsVariableName)
    {
        return new JsLinearInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLinearInterpolant AsJsLinearInterpolant(this JsType value)
    {
        return value is JsLinearInterpolant typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsDiscreteInterpolant JsSet(this string jsVariableName, JsDiscreteInterpolant jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDiscreteInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDiscreteInterpolant JsSet(this JsDiscreteInterpolant jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDiscreteInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDiscreteInterpolant JsLet(this string jsVariableName, JsDiscreteInterpolant jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDiscreteInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDiscreteInterpolant JsLet(this JsDiscreteInterpolant jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDiscreteInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDiscreteInterpolant JsConst(this string jsVariableName, JsDiscreteInterpolant jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDiscreteInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDiscreteInterpolant JsConst(this JsDiscreteInterpolant jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDiscreteInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDiscreteInterpolant AsJsDiscreteInterpolantVariable(this string jsVariableName, JsDiscreteInterpolant jsVariableValue = null)
    {
        return new JsDiscreteInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDiscreteInterpolant AsJsDiscreteInterpolantVariable(this JsDiscreteInterpolant jsVariableValue, string jsVariableName)
    {
        return new JsDiscreteInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDiscreteInterpolant AsJsDiscreteInterpolant(this JsType value)
    {
        return value is JsDiscreteInterpolant typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsKeyframeTrack JsSet(this string jsVariableName, JsKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsKeyframeTrack JsSet(this JsKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsKeyframeTrack JsLet(this string jsVariableName, JsKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsKeyframeTrack JsLet(this JsKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsKeyframeTrack JsConst(this string jsVariableName, JsKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsKeyframeTrack JsConst(this JsKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsKeyframeTrack AsJsKeyframeTrackVariable(this string jsVariableName, JsKeyframeTrack jsVariableValue = null)
    {
        return new JsKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsKeyframeTrack AsJsKeyframeTrackVariable(this JsKeyframeTrack jsVariableValue, string jsVariableName)
    {
        return new JsKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsKeyframeTrack AsJsKeyframeTrack(this JsType value)
    {
        return value is JsKeyframeTrack typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsBooleanKeyframeTrack JsSet(this string jsVariableName, JsBooleanKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBooleanKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBooleanKeyframeTrack JsSet(this JsBooleanKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBooleanKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBooleanKeyframeTrack JsLet(this string jsVariableName, JsBooleanKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBooleanKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBooleanKeyframeTrack JsLet(this JsBooleanKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBooleanKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBooleanKeyframeTrack JsConst(this string jsVariableName, JsBooleanKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBooleanKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBooleanKeyframeTrack JsConst(this JsBooleanKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBooleanKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBooleanKeyframeTrack AsJsBooleanKeyframeTrackVariable(this string jsVariableName, JsBooleanKeyframeTrack jsVariableValue = null)
    {
        return new JsBooleanKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBooleanKeyframeTrack AsJsBooleanKeyframeTrackVariable(this JsBooleanKeyframeTrack jsVariableValue, string jsVariableName)
    {
        return new JsBooleanKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBooleanKeyframeTrack AsJsBooleanKeyframeTrack(this JsType value)
    {
        return value is JsBooleanKeyframeTrack typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsColorKeyframeTrack JsSet(this string jsVariableName, JsColorKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsColorKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsColorKeyframeTrack JsSet(this JsColorKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsColorKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsColorKeyframeTrack JsLet(this string jsVariableName, JsColorKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsColorKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsColorKeyframeTrack JsLet(this JsColorKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsColorKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsColorKeyframeTrack JsConst(this string jsVariableName, JsColorKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsColorKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsColorKeyframeTrack JsConst(this JsColorKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsColorKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsColorKeyframeTrack AsJsColorKeyframeTrackVariable(this string jsVariableName, JsColorKeyframeTrack jsVariableValue = null)
    {
        return new JsColorKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsColorKeyframeTrack AsJsColorKeyframeTrackVariable(this JsColorKeyframeTrack jsVariableValue, string jsVariableName)
    {
        return new JsColorKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsColorKeyframeTrack AsJsColorKeyframeTrack(this JsType value)
    {
        return value is JsColorKeyframeTrack typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsNumberKeyframeTrack JsSet(this string jsVariableName, JsNumberKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsNumberKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsNumberKeyframeTrack JsSet(this JsNumberKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsNumberKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsNumberKeyframeTrack JsLet(this string jsVariableName, JsNumberKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsNumberKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsNumberKeyframeTrack JsLet(this JsNumberKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsNumberKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsNumberKeyframeTrack JsConst(this string jsVariableName, JsNumberKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsNumberKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsNumberKeyframeTrack JsConst(this JsNumberKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsNumberKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsNumberKeyframeTrack AsJsNumberKeyframeTrackVariable(this string jsVariableName, JsNumberKeyframeTrack jsVariableValue = null)
    {
        return new JsNumberKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsNumberKeyframeTrack AsJsNumberKeyframeTrackVariable(this JsNumberKeyframeTrack jsVariableValue, string jsVariableName)
    {
        return new JsNumberKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsNumberKeyframeTrack AsJsNumberKeyframeTrack(this JsType value)
    {
        return value is JsNumberKeyframeTrack typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsQuaternionLinearInterpolant JsSet(this string jsVariableName, JsQuaternionLinearInterpolant jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternionLinearInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternionLinearInterpolant JsSet(this JsQuaternionLinearInterpolant jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternionLinearInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternionLinearInterpolant JsLet(this string jsVariableName, JsQuaternionLinearInterpolant jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternionLinearInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternionLinearInterpolant JsLet(this JsQuaternionLinearInterpolant jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternionLinearInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternionLinearInterpolant JsConst(this string jsVariableName, JsQuaternionLinearInterpolant jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternionLinearInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternionLinearInterpolant JsConst(this JsQuaternionLinearInterpolant jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternionLinearInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternionLinearInterpolant AsJsQuaternionLinearInterpolantVariable(this string jsVariableName, JsQuaternionLinearInterpolant jsVariableValue = null)
    {
        return new JsQuaternionLinearInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternionLinearInterpolant AsJsQuaternionLinearInterpolantVariable(this JsQuaternionLinearInterpolant jsVariableValue, string jsVariableName)
    {
        return new JsQuaternionLinearInterpolant(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternionLinearInterpolant AsJsQuaternionLinearInterpolant(this JsType value)
    {
        return value is JsQuaternionLinearInterpolant typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsQuaternionKeyframeTrack JsSet(this string jsVariableName, JsQuaternionKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternionKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternionKeyframeTrack JsSet(this JsQuaternionKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternionKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternionKeyframeTrack JsLet(this string jsVariableName, JsQuaternionKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternionKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternionKeyframeTrack JsLet(this JsQuaternionKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternionKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternionKeyframeTrack JsConst(this string jsVariableName, JsQuaternionKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternionKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternionKeyframeTrack JsConst(this JsQuaternionKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsQuaternionKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternionKeyframeTrack AsJsQuaternionKeyframeTrackVariable(this string jsVariableName, JsQuaternionKeyframeTrack jsVariableValue = null)
    {
        return new JsQuaternionKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternionKeyframeTrack AsJsQuaternionKeyframeTrackVariable(this JsQuaternionKeyframeTrack jsVariableValue, string jsVariableName)
    {
        return new JsQuaternionKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsQuaternionKeyframeTrack AsJsQuaternionKeyframeTrack(this JsType value)
    {
        return value is JsQuaternionKeyframeTrack typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsStringKeyframeTrack JsSet(this string jsVariableName, JsStringKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsStringKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsStringKeyframeTrack JsSet(this JsStringKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsStringKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsStringKeyframeTrack JsLet(this string jsVariableName, JsStringKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsStringKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsStringKeyframeTrack JsLet(this JsStringKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsStringKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsStringKeyframeTrack JsConst(this string jsVariableName, JsStringKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsStringKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsStringKeyframeTrack JsConst(this JsStringKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsStringKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsStringKeyframeTrack AsJsStringKeyframeTrackVariable(this string jsVariableName, JsStringKeyframeTrack jsVariableValue = null)
    {
        return new JsStringKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsStringKeyframeTrack AsJsStringKeyframeTrackVariable(this JsStringKeyframeTrack jsVariableValue, string jsVariableName)
    {
        return new JsStringKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsStringKeyframeTrack AsJsStringKeyframeTrack(this JsType value)
    {
        return value is JsStringKeyframeTrack typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsVectorKeyframeTrack JsSet(this string jsVariableName, JsVectorKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVectorKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVectorKeyframeTrack JsSet(this JsVectorKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVectorKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVectorKeyframeTrack JsLet(this string jsVariableName, JsVectorKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVectorKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVectorKeyframeTrack JsLet(this JsVectorKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVectorKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVectorKeyframeTrack JsConst(this string jsVariableName, JsVectorKeyframeTrack jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVectorKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVectorKeyframeTrack JsConst(this JsVectorKeyframeTrack jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsVectorKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVectorKeyframeTrack AsJsVectorKeyframeTrackVariable(this string jsVariableName, JsVectorKeyframeTrack jsVariableValue = null)
    {
        return new JsVectorKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVectorKeyframeTrack AsJsVectorKeyframeTrackVariable(this JsVectorKeyframeTrack jsVariableValue, string jsVariableName)
    {
        return new JsVectorKeyframeTrack(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsVectorKeyframeTrack AsJsVectorKeyframeTrack(this JsType value)
    {
        return value is JsVectorKeyframeTrack typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsAnimationClip JsSet(this string jsVariableName, JsAnimationClip jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationClip(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationClip JsSet(this JsAnimationClip jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationClip(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationClip JsLet(this string jsVariableName, JsAnimationClip jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationClip(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationClip JsLet(this JsAnimationClip jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationClip(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationClip JsConst(this string jsVariableName, JsAnimationClip jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationClip(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationClip JsConst(this JsAnimationClip jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationClip(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationClip AsJsAnimationClipVariable(this string jsVariableName, JsAnimationClip jsVariableValue = null)
    {
        return new JsAnimationClip(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationClip AsJsAnimationClipVariable(this JsAnimationClip jsVariableValue, string jsVariableName)
    {
        return new JsAnimationClip(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationClip AsJsAnimationClip(this JsType value)
    {
        return value is JsAnimationClip typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLoadingManager JsSet(this string jsVariableName, JsLoadingManager jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoadingManager(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoadingManager JsSet(this JsLoadingManager jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoadingManager(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoadingManager JsLet(this string jsVariableName, JsLoadingManager jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoadingManager(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoadingManager JsLet(this JsLoadingManager jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoadingManager(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoadingManager JsConst(this string jsVariableName, JsLoadingManager jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoadingManager(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoadingManager JsConst(this JsLoadingManager jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoadingManager(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoadingManager AsJsLoadingManagerVariable(this string jsVariableName, JsLoadingManager jsVariableValue = null)
    {
        return new JsLoadingManager(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoadingManager AsJsLoadingManagerVariable(this JsLoadingManager jsVariableValue, string jsVariableName)
    {
        return new JsLoadingManager(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoadingManager AsJsLoadingManager(this JsType value)
    {
        return value is JsLoadingManager typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLoader JsSet(this string jsVariableName, JsLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoader JsSet(this JsLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoader JsLet(this string jsVariableName, JsLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoader JsLet(this JsLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoader JsConst(this string jsVariableName, JsLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoader JsConst(this JsLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoader AsJsLoaderVariable(this string jsVariableName, JsLoader jsVariableValue = null)
    {
        return new JsLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoader AsJsLoaderVariable(this JsLoader jsVariableValue, string jsVariableName)
    {
        return new JsLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoader AsJsLoader(this JsType value)
    {
        return value is JsLoader typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsFileLoader JsSet(this string jsVariableName, JsFileLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFileLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFileLoader JsSet(this JsFileLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFileLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFileLoader JsLet(this string jsVariableName, JsFileLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFileLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFileLoader JsLet(this JsFileLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFileLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFileLoader JsConst(this string jsVariableName, JsFileLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFileLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFileLoader JsConst(this JsFileLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsFileLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFileLoader AsJsFileLoaderVariable(this string jsVariableName, JsFileLoader jsVariableValue = null)
    {
        return new JsFileLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFileLoader AsJsFileLoaderVariable(this JsFileLoader jsVariableValue, string jsVariableName)
    {
        return new JsFileLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsFileLoader AsJsFileLoader(this JsType value)
    {
        return value is JsFileLoader typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsAnimationLoader JsSet(this string jsVariableName, JsAnimationLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationLoader JsSet(this JsAnimationLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationLoader JsLet(this string jsVariableName, JsAnimationLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationLoader JsLet(this JsAnimationLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationLoader JsConst(this string jsVariableName, JsAnimationLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationLoader JsConst(this JsAnimationLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationLoader AsJsAnimationLoaderVariable(this string jsVariableName, JsAnimationLoader jsVariableValue = null)
    {
        return new JsAnimationLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationLoader AsJsAnimationLoaderVariable(this JsAnimationLoader jsVariableValue, string jsVariableName)
    {
        return new JsAnimationLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationLoader AsJsAnimationLoader(this JsType value)
    {
        return value is JsAnimationLoader typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCompressedTextureLoader JsSet(this string jsVariableName, JsCompressedTextureLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCompressedTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCompressedTextureLoader JsSet(this JsCompressedTextureLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCompressedTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCompressedTextureLoader JsLet(this string jsVariableName, JsCompressedTextureLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCompressedTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCompressedTextureLoader JsLet(this JsCompressedTextureLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCompressedTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCompressedTextureLoader JsConst(this string jsVariableName, JsCompressedTextureLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCompressedTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCompressedTextureLoader JsConst(this JsCompressedTextureLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCompressedTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCompressedTextureLoader AsJsCompressedTextureLoaderVariable(this string jsVariableName, JsCompressedTextureLoader jsVariableValue = null)
    {
        return new JsCompressedTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCompressedTextureLoader AsJsCompressedTextureLoaderVariable(this JsCompressedTextureLoader jsVariableValue, string jsVariableName)
    {
        return new JsCompressedTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCompressedTextureLoader AsJsCompressedTextureLoader(this JsType value)
    {
        return value is JsCompressedTextureLoader typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsImageLoader JsSet(this string jsVariableName, JsImageLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageLoader JsSet(this JsImageLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageLoader JsLet(this string jsVariableName, JsImageLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageLoader JsLet(this JsImageLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageLoader JsConst(this string jsVariableName, JsImageLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageLoader JsConst(this JsImageLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageLoader AsJsImageLoaderVariable(this string jsVariableName, JsImageLoader jsVariableValue = null)
    {
        return new JsImageLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageLoader AsJsImageLoaderVariable(this JsImageLoader jsVariableValue, string jsVariableName)
    {
        return new JsImageLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageLoader AsJsImageLoader(this JsType value)
    {
        return value is JsImageLoader typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCubeTextureLoader JsSet(this string jsVariableName, JsCubeTextureLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeTextureLoader JsSet(this JsCubeTextureLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeTextureLoader JsLet(this string jsVariableName, JsCubeTextureLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeTextureLoader JsLet(this JsCubeTextureLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeTextureLoader JsConst(this string jsVariableName, JsCubeTextureLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeTextureLoader JsConst(this JsCubeTextureLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCubeTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeTextureLoader AsJsCubeTextureLoaderVariable(this string jsVariableName, JsCubeTextureLoader jsVariableValue = null)
    {
        return new JsCubeTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeTextureLoader AsJsCubeTextureLoaderVariable(this JsCubeTextureLoader jsVariableValue, string jsVariableName)
    {
        return new JsCubeTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCubeTextureLoader AsJsCubeTextureLoader(this JsType value)
    {
        return value is JsCubeTextureLoader typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsDataTextureLoader JsSet(this string jsVariableName, JsDataTextureLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTextureLoader JsSet(this JsDataTextureLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTextureLoader JsLet(this string jsVariableName, JsDataTextureLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTextureLoader JsLet(this JsDataTextureLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTextureLoader JsConst(this string jsVariableName, JsDataTextureLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTextureLoader JsConst(this JsDataTextureLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTextureLoader AsJsDataTextureLoaderVariable(this string jsVariableName, JsDataTextureLoader jsVariableValue = null)
    {
        return new JsDataTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTextureLoader AsJsDataTextureLoaderVariable(this JsDataTextureLoader jsVariableValue, string jsVariableName)
    {
        return new JsDataTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataTextureLoader AsJsDataTextureLoader(this JsType value)
    {
        return value is JsDataTextureLoader typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsTextureLoader JsSet(this string jsVariableName, JsTextureLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTextureLoader JsSet(this JsTextureLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTextureLoader JsLet(this string jsVariableName, JsTextureLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTextureLoader JsLet(this JsTextureLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTextureLoader JsConst(this string jsVariableName, JsTextureLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTextureLoader JsConst(this JsTextureLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTextureLoader AsJsTextureLoaderVariable(this string jsVariableName, JsTextureLoader jsVariableValue = null)
    {
        return new JsTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTextureLoader AsJsTextureLoaderVariable(this JsTextureLoader jsVariableValue, string jsVariableName)
    {
        return new JsTextureLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsTextureLoader AsJsTextureLoader(this JsType value)
    {
        return value is JsTextureLoader typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLight JsSet(this string jsVariableName, JsLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLight JsSet(this JsLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLight JsLet(this string jsVariableName, JsLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLight JsLet(this JsLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLight JsConst(this string jsVariableName, JsLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLight JsConst(this JsLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLight AsJsLightVariable(this string jsVariableName, JsLight jsVariableValue = null)
    {
        return new JsLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLight AsJsLightVariable(this JsLight jsVariableValue, string jsVariableName)
    {
        return new JsLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLight AsJsLight(this JsType value)
    {
        return value is JsLight typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsHemisphereLight JsSet(this string jsVariableName, JsHemisphereLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLight JsSet(this JsHemisphereLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLight JsLet(this string jsVariableName, JsHemisphereLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLight JsLet(this JsHemisphereLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLight JsConst(this string jsVariableName, JsHemisphereLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLight JsConst(this JsHemisphereLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLight AsJsHemisphereLightVariable(this string jsVariableName, JsHemisphereLight jsVariableValue = null)
    {
        return new JsHemisphereLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLight AsJsHemisphereLightVariable(this JsHemisphereLight jsVariableValue, string jsVariableName)
    {
        return new JsHemisphereLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLight AsJsHemisphereLight(this JsType value)
    {
        return value is JsHemisphereLight typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLightShadow JsSet(this string jsVariableName, JsLightShadow jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLightShadow JsSet(this JsLightShadow jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLightShadow JsLet(this string jsVariableName, JsLightShadow jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLightShadow JsLet(this JsLightShadow jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLightShadow JsConst(this string jsVariableName, JsLightShadow jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLightShadow JsConst(this JsLightShadow jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLightShadow AsJsLightShadowVariable(this string jsVariableName, JsLightShadow jsVariableValue = null)
    {
        return new JsLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLightShadow AsJsLightShadowVariable(this JsLightShadow jsVariableValue, string jsVariableName)
    {
        return new JsLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLightShadow AsJsLightShadow(this JsType value)
    {
        return value is JsLightShadow typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsSpotLightShadow JsSet(this string jsVariableName, JsSpotLightShadow jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLightShadow JsSet(this JsSpotLightShadow jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLightShadow JsLet(this string jsVariableName, JsSpotLightShadow jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLightShadow JsLet(this JsSpotLightShadow jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLightShadow JsConst(this string jsVariableName, JsSpotLightShadow jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLightShadow JsConst(this JsSpotLightShadow jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLightShadow AsJsSpotLightShadowVariable(this string jsVariableName, JsSpotLightShadow jsVariableValue = null)
    {
        return new JsSpotLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLightShadow AsJsSpotLightShadowVariable(this JsSpotLightShadow jsVariableValue, string jsVariableName)
    {
        return new JsSpotLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLightShadow AsJsSpotLightShadow(this JsType value)
    {
        return value is JsSpotLightShadow typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsSpotLight JsSet(this string jsVariableName, JsSpotLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLight JsSet(this JsSpotLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLight JsLet(this string jsVariableName, JsSpotLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLight JsLet(this JsSpotLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLight JsConst(this string jsVariableName, JsSpotLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLight JsConst(this JsSpotLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLight AsJsSpotLightVariable(this string jsVariableName, JsSpotLight jsVariableValue = null)
    {
        return new JsSpotLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLight AsJsSpotLightVariable(this JsSpotLight jsVariableValue, string jsVariableName)
    {
        return new JsSpotLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLight AsJsSpotLight(this JsType value)
    {
        return value is JsSpotLight typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsPointLightShadow JsSet(this string jsVariableName, JsPointLightShadow jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLightShadow JsSet(this JsPointLightShadow jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLightShadow JsLet(this string jsVariableName, JsPointLightShadow jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLightShadow JsLet(this JsPointLightShadow jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLightShadow JsConst(this string jsVariableName, JsPointLightShadow jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLightShadow JsConst(this JsPointLightShadow jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLightShadow AsJsPointLightShadowVariable(this string jsVariableName, JsPointLightShadow jsVariableValue = null)
    {
        return new JsPointLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLightShadow AsJsPointLightShadowVariable(this JsPointLightShadow jsVariableValue, string jsVariableName)
    {
        return new JsPointLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLightShadow AsJsPointLightShadow(this JsType value)
    {
        return value is JsPointLightShadow typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsPointLight JsSet(this string jsVariableName, JsPointLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLight JsSet(this JsPointLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLight JsLet(this string jsVariableName, JsPointLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLight JsLet(this JsPointLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLight JsConst(this string jsVariableName, JsPointLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLight JsConst(this JsPointLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLight AsJsPointLightVariable(this string jsVariableName, JsPointLight jsVariableValue = null)
    {
        return new JsPointLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLight AsJsPointLightVariable(this JsPointLight jsVariableValue, string jsVariableName)
    {
        return new JsPointLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLight AsJsPointLight(this JsType value)
    {
        return value is JsPointLight typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsDirectionalLightShadow JsSet(this string jsVariableName, JsDirectionalLightShadow jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLightShadow JsSet(this JsDirectionalLightShadow jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLightShadow JsLet(this string jsVariableName, JsDirectionalLightShadow jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLightShadow JsLet(this JsDirectionalLightShadow jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLightShadow JsConst(this string jsVariableName, JsDirectionalLightShadow jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLightShadow JsConst(this JsDirectionalLightShadow jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLightShadow AsJsDirectionalLightShadowVariable(this string jsVariableName, JsDirectionalLightShadow jsVariableValue = null)
    {
        return new JsDirectionalLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLightShadow AsJsDirectionalLightShadowVariable(this JsDirectionalLightShadow jsVariableValue, string jsVariableName)
    {
        return new JsDirectionalLightShadow(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLightShadow AsJsDirectionalLightShadow(this JsType value)
    {
        return value is JsDirectionalLightShadow typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsDirectionalLight JsSet(this string jsVariableName, JsDirectionalLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLight JsSet(this JsDirectionalLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLight JsLet(this string jsVariableName, JsDirectionalLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLight JsLet(this JsDirectionalLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLight JsConst(this string jsVariableName, JsDirectionalLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLight JsConst(this JsDirectionalLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLight AsJsDirectionalLightVariable(this string jsVariableName, JsDirectionalLight jsVariableValue = null)
    {
        return new JsDirectionalLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLight AsJsDirectionalLightVariable(this JsDirectionalLight jsVariableValue, string jsVariableName)
    {
        return new JsDirectionalLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLight AsJsDirectionalLight(this JsType value)
    {
        return value is JsDirectionalLight typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsAmbientLight JsSet(this string jsVariableName, JsAmbientLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAmbientLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAmbientLight JsSet(this JsAmbientLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAmbientLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAmbientLight JsLet(this string jsVariableName, JsAmbientLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAmbientLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAmbientLight JsLet(this JsAmbientLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAmbientLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAmbientLight JsConst(this string jsVariableName, JsAmbientLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAmbientLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAmbientLight JsConst(this JsAmbientLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAmbientLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAmbientLight AsJsAmbientLightVariable(this string jsVariableName, JsAmbientLight jsVariableValue = null)
    {
        return new JsAmbientLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAmbientLight AsJsAmbientLightVariable(this JsAmbientLight jsVariableValue, string jsVariableName)
    {
        return new JsAmbientLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAmbientLight AsJsAmbientLight(this JsType value)
    {
        return value is JsAmbientLight typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsRectAreaLight JsSet(this string jsVariableName, JsRectAreaLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRectAreaLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRectAreaLight JsSet(this JsRectAreaLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRectAreaLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRectAreaLight JsLet(this string jsVariableName, JsRectAreaLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRectAreaLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRectAreaLight JsLet(this JsRectAreaLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRectAreaLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRectAreaLight JsConst(this string jsVariableName, JsRectAreaLight jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRectAreaLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRectAreaLight JsConst(this JsRectAreaLight jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRectAreaLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRectAreaLight AsJsRectAreaLightVariable(this string jsVariableName, JsRectAreaLight jsVariableValue = null)
    {
        return new JsRectAreaLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRectAreaLight AsJsRectAreaLightVariable(this JsRectAreaLight jsVariableValue, string jsVariableName)
    {
        return new JsRectAreaLight(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRectAreaLight AsJsRectAreaLight(this JsType value)
    {
        return value is JsRectAreaLight typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsSphericalHarmonics3 JsSet(this string jsVariableName, JsSphericalHarmonics3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphericalHarmonics3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphericalHarmonics3 JsSet(this JsSphericalHarmonics3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphericalHarmonics3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphericalHarmonics3 JsLet(this string jsVariableName, JsSphericalHarmonics3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphericalHarmonics3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphericalHarmonics3 JsLet(this JsSphericalHarmonics3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphericalHarmonics3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphericalHarmonics3 JsConst(this string jsVariableName, JsSphericalHarmonics3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphericalHarmonics3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphericalHarmonics3 JsConst(this JsSphericalHarmonics3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSphericalHarmonics3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphericalHarmonics3 AsJsSphericalHarmonics3Variable(this string jsVariableName, JsSphericalHarmonics3 jsVariableValue = null)
    {
        return new JsSphericalHarmonics3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphericalHarmonics3 AsJsSphericalHarmonics3Variable(this JsSphericalHarmonics3 jsVariableValue, string jsVariableName)
    {
        return new JsSphericalHarmonics3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSphericalHarmonics3 AsJsSphericalHarmonics3(this JsType value)
    {
        return value is JsSphericalHarmonics3 typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLightProbe JsSet(this string jsVariableName, JsLightProbe jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLightProbe JsSet(this JsLightProbe jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLightProbe JsLet(this string jsVariableName, JsLightProbe jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLightProbe JsLet(this JsLightProbe jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLightProbe JsConst(this string jsVariableName, JsLightProbe jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLightProbe JsConst(this JsLightProbe jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLightProbe AsJsLightProbeVariable(this string jsVariableName, JsLightProbe jsVariableValue = null)
    {
        return new JsLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLightProbe AsJsLightProbeVariable(this JsLightProbe jsVariableValue, string jsVariableName)
    {
        return new JsLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLightProbe AsJsLightProbe(this JsType value)
    {
        return value is JsLightProbe typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsMaterialLoader JsSet(this string jsVariableName, JsMaterialLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMaterialLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMaterialLoader JsSet(this JsMaterialLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMaterialLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMaterialLoader JsLet(this string jsVariableName, JsMaterialLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMaterialLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMaterialLoader JsLet(this JsMaterialLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMaterialLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMaterialLoader JsConst(this string jsVariableName, JsMaterialLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMaterialLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMaterialLoader JsConst(this JsMaterialLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsMaterialLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMaterialLoader AsJsMaterialLoaderVariable(this string jsVariableName, JsMaterialLoader jsVariableValue = null)
    {
        return new JsMaterialLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMaterialLoader AsJsMaterialLoaderVariable(this JsMaterialLoader jsVariableValue, string jsVariableName)
    {
        return new JsMaterialLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsMaterialLoader AsJsMaterialLoader(this JsType value)
    {
        return value is JsMaterialLoader typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLoaderUtils JsSet(this string jsVariableName, JsLoaderUtils jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoaderUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoaderUtils JsSet(this JsLoaderUtils jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoaderUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoaderUtils JsLet(this string jsVariableName, JsLoaderUtils jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoaderUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoaderUtils JsLet(this JsLoaderUtils jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoaderUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoaderUtils JsConst(this string jsVariableName, JsLoaderUtils jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoaderUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoaderUtils JsConst(this JsLoaderUtils jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLoaderUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoaderUtils AsJsLoaderUtilsVariable(this string jsVariableName, JsLoaderUtils jsVariableValue = null)
    {
        return new JsLoaderUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoaderUtils AsJsLoaderUtilsVariable(this JsLoaderUtils jsVariableValue, string jsVariableName)
    {
        return new JsLoaderUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLoaderUtils AsJsLoaderUtils(this JsType value)
    {
        return value is JsLoaderUtils typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsInstancedBufferGeometry JsSet(this string jsVariableName, JsInstancedBufferGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedBufferGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedBufferGeometry JsSet(this JsInstancedBufferGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedBufferGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedBufferGeometry JsLet(this string jsVariableName, JsInstancedBufferGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedBufferGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedBufferGeometry JsLet(this JsInstancedBufferGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedBufferGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedBufferGeometry JsConst(this string jsVariableName, JsInstancedBufferGeometry jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedBufferGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedBufferGeometry JsConst(this JsInstancedBufferGeometry jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedBufferGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedBufferGeometry AsJsInstancedBufferGeometryVariable(this string jsVariableName, JsInstancedBufferGeometry jsVariableValue = null)
    {
        return new JsInstancedBufferGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedBufferGeometry AsJsInstancedBufferGeometryVariable(this JsInstancedBufferGeometry jsVariableValue, string jsVariableName)
    {
        return new JsInstancedBufferGeometry(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedBufferGeometry AsJsInstancedBufferGeometry(this JsType value)
    {
        return value is JsInstancedBufferGeometry typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsBufferGeometryLoader JsSet(this string jsVariableName, JsBufferGeometryLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferGeometryLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferGeometryLoader JsSet(this JsBufferGeometryLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferGeometryLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferGeometryLoader JsLet(this string jsVariableName, JsBufferGeometryLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferGeometryLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferGeometryLoader JsLet(this JsBufferGeometryLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferGeometryLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferGeometryLoader JsConst(this string jsVariableName, JsBufferGeometryLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferGeometryLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferGeometryLoader JsConst(this JsBufferGeometryLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBufferGeometryLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferGeometryLoader AsJsBufferGeometryLoaderVariable(this string jsVariableName, JsBufferGeometryLoader jsVariableValue = null)
    {
        return new JsBufferGeometryLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferGeometryLoader AsJsBufferGeometryLoaderVariable(this JsBufferGeometryLoader jsVariableValue, string jsVariableName)
    {
        return new JsBufferGeometryLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBufferGeometryLoader AsJsBufferGeometryLoader(this JsType value)
    {
        return value is JsBufferGeometryLoader typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsObjectLoader JsSet(this string jsVariableName, JsObjectLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsObjectLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsObjectLoader JsSet(this JsObjectLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsObjectLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsObjectLoader JsLet(this string jsVariableName, JsObjectLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsObjectLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsObjectLoader JsLet(this JsObjectLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsObjectLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsObjectLoader JsConst(this string jsVariableName, JsObjectLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsObjectLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsObjectLoader JsConst(this JsObjectLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsObjectLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsObjectLoader AsJsObjectLoaderVariable(this string jsVariableName, JsObjectLoader jsVariableValue = null)
    {
        return new JsObjectLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsObjectLoader AsJsObjectLoaderVariable(this JsObjectLoader jsVariableValue, string jsVariableName)
    {
        return new JsObjectLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsObjectLoader AsJsObjectLoader(this JsType value)
    {
        return value is JsObjectLoader typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsImageBitmapLoader JsSet(this string jsVariableName, JsImageBitmapLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageBitmapLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageBitmapLoader JsSet(this JsImageBitmapLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageBitmapLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageBitmapLoader JsLet(this string jsVariableName, JsImageBitmapLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageBitmapLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageBitmapLoader JsLet(this JsImageBitmapLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageBitmapLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageBitmapLoader JsConst(this string jsVariableName, JsImageBitmapLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageBitmapLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageBitmapLoader JsConst(this JsImageBitmapLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImageBitmapLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageBitmapLoader AsJsImageBitmapLoaderVariable(this string jsVariableName, JsImageBitmapLoader jsVariableValue = null)
    {
        return new JsImageBitmapLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageBitmapLoader AsJsImageBitmapLoaderVariable(this JsImageBitmapLoader jsVariableValue, string jsVariableName)
    {
        return new JsImageBitmapLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImageBitmapLoader AsJsImageBitmapLoader(this JsType value)
    {
        return value is JsImageBitmapLoader typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsAudioLoader JsSet(this string jsVariableName, JsAudioLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioLoader JsSet(this JsAudioLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioLoader JsLet(this string jsVariableName, JsAudioLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioLoader JsLet(this JsAudioLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioLoader JsConst(this string jsVariableName, JsAudioLoader jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioLoader JsConst(this JsAudioLoader jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioLoader AsJsAudioLoaderVariable(this string jsVariableName, JsAudioLoader jsVariableValue = null)
    {
        return new JsAudioLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioLoader AsJsAudioLoaderVariable(this JsAudioLoader jsVariableValue, string jsVariableName)
    {
        return new JsAudioLoader(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioLoader AsJsAudioLoader(this JsType value)
    {
        return value is JsAudioLoader typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsHemisphereLightProbe JsSet(this string jsVariableName, JsHemisphereLightProbe jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLightProbe JsSet(this JsHemisphereLightProbe jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLightProbe JsLet(this string jsVariableName, JsHemisphereLightProbe jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLightProbe JsLet(this JsHemisphereLightProbe jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLightProbe JsConst(this string jsVariableName, JsHemisphereLightProbe jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLightProbe JsConst(this JsHemisphereLightProbe jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLightProbe AsJsHemisphereLightProbeVariable(this string jsVariableName, JsHemisphereLightProbe jsVariableValue = null)
    {
        return new JsHemisphereLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLightProbe AsJsHemisphereLightProbeVariable(this JsHemisphereLightProbe jsVariableValue, string jsVariableName)
    {
        return new JsHemisphereLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLightProbe AsJsHemisphereLightProbe(this JsType value)
    {
        return value is JsHemisphereLightProbe typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsAmbientLightProbe JsSet(this string jsVariableName, JsAmbientLightProbe jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAmbientLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAmbientLightProbe JsSet(this JsAmbientLightProbe jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAmbientLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAmbientLightProbe JsLet(this string jsVariableName, JsAmbientLightProbe jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAmbientLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAmbientLightProbe JsLet(this JsAmbientLightProbe jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAmbientLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAmbientLightProbe JsConst(this string jsVariableName, JsAmbientLightProbe jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAmbientLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAmbientLightProbe JsConst(this JsAmbientLightProbe jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAmbientLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAmbientLightProbe AsJsAmbientLightProbeVariable(this string jsVariableName, JsAmbientLightProbe jsVariableValue = null)
    {
        return new JsAmbientLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAmbientLightProbe AsJsAmbientLightProbeVariable(this JsAmbientLightProbe jsVariableValue, string jsVariableName)
    {
        return new JsAmbientLightProbe(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAmbientLightProbe AsJsAmbientLightProbe(this JsType value)
    {
        return value is JsAmbientLightProbe typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsStereoCamera JsSet(this string jsVariableName, JsStereoCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsStereoCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsStereoCamera JsSet(this JsStereoCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsStereoCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsStereoCamera JsLet(this string jsVariableName, JsStereoCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsStereoCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsStereoCamera JsLet(this JsStereoCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsStereoCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsStereoCamera JsConst(this string jsVariableName, JsStereoCamera jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsStereoCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsStereoCamera JsConst(this JsStereoCamera jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsStereoCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsStereoCamera AsJsStereoCameraVariable(this string jsVariableName, JsStereoCamera jsVariableValue = null)
    {
        return new JsStereoCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsStereoCamera AsJsStereoCameraVariable(this JsStereoCamera jsVariableValue, string jsVariableName)
    {
        return new JsStereoCamera(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsStereoCamera AsJsStereoCamera(this JsType value)
    {
        return value is JsStereoCamera typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsClock JsSet(this string jsVariableName, JsClock jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsClock(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsClock JsSet(this JsClock jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsClock(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsClock JsLet(this string jsVariableName, JsClock jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsClock(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsClock JsLet(this JsClock jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsClock(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsClock JsConst(this string jsVariableName, JsClock jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsClock(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsClock JsConst(this JsClock jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsClock(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsClock AsJsClockVariable(this string jsVariableName, JsClock jsVariableValue = null)
    {
        return new JsClock(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsClock AsJsClockVariable(this JsClock jsVariableValue, string jsVariableName)
    {
        return new JsClock(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsClock AsJsClock(this JsType value)
    {
        return value is JsClock typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsAudioListener JsSet(this string jsVariableName, JsAudioListener jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioListener(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioListener JsSet(this JsAudioListener jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioListener(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioListener JsLet(this string jsVariableName, JsAudioListener jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioListener(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioListener JsLet(this JsAudioListener jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioListener(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioListener JsConst(this string jsVariableName, JsAudioListener jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioListener(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioListener JsConst(this JsAudioListener jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioListener(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioListener AsJsAudioListenerVariable(this string jsVariableName, JsAudioListener jsVariableValue = null)
    {
        return new JsAudioListener(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioListener AsJsAudioListenerVariable(this JsAudioListener jsVariableValue, string jsVariableName)
    {
        return new JsAudioListener(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioListener AsJsAudioListener(this JsType value)
    {
        return value is JsAudioListener typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsAudio JsSet(this string jsVariableName, JsAudio jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudio(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudio JsSet(this JsAudio jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudio(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudio JsLet(this string jsVariableName, JsAudio jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudio(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudio JsLet(this JsAudio jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudio(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudio JsConst(this string jsVariableName, JsAudio jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudio(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudio JsConst(this JsAudio jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudio(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudio AsJsAudioVariable(this string jsVariableName, JsAudio jsVariableValue = null)
    {
        return new JsAudio(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudio AsJsAudioVariable(this JsAudio jsVariableValue, string jsVariableName)
    {
        return new JsAudio(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudio AsJsAudio(this JsType value)
    {
        return value is JsAudio typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsPositionalAudio JsSet(this string jsVariableName, JsPositionalAudio jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPositionalAudio(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPositionalAudio JsSet(this JsPositionalAudio jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPositionalAudio(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPositionalAudio JsLet(this string jsVariableName, JsPositionalAudio jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPositionalAudio(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPositionalAudio JsLet(this JsPositionalAudio jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPositionalAudio(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPositionalAudio JsConst(this string jsVariableName, JsPositionalAudio jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPositionalAudio(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPositionalAudio JsConst(this JsPositionalAudio jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPositionalAudio(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPositionalAudio AsJsPositionalAudioVariable(this string jsVariableName, JsPositionalAudio jsVariableValue = null)
    {
        return new JsPositionalAudio(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPositionalAudio AsJsPositionalAudioVariable(this JsPositionalAudio jsVariableValue, string jsVariableName)
    {
        return new JsPositionalAudio(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPositionalAudio AsJsPositionalAudio(this JsType value)
    {
        return value is JsPositionalAudio typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsAudioAnalyser JsSet(this string jsVariableName, JsAudioAnalyser jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioAnalyser(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioAnalyser JsSet(this JsAudioAnalyser jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioAnalyser(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioAnalyser JsLet(this string jsVariableName, JsAudioAnalyser jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioAnalyser(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioAnalyser JsLet(this JsAudioAnalyser jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioAnalyser(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioAnalyser JsConst(this string jsVariableName, JsAudioAnalyser jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioAnalyser(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioAnalyser JsConst(this JsAudioAnalyser jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAudioAnalyser(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioAnalyser AsJsAudioAnalyserVariable(this string jsVariableName, JsAudioAnalyser jsVariableValue = null)
    {
        return new JsAudioAnalyser(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioAnalyser AsJsAudioAnalyserVariable(this JsAudioAnalyser jsVariableValue, string jsVariableName)
    {
        return new JsAudioAnalyser(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAudioAnalyser AsJsAudioAnalyser(this JsType value)
    {
        return value is JsAudioAnalyser typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsPropertyMixer JsSet(this string jsVariableName, JsPropertyMixer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPropertyMixer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPropertyMixer JsSet(this JsPropertyMixer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPropertyMixer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPropertyMixer JsLet(this string jsVariableName, JsPropertyMixer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPropertyMixer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPropertyMixer JsLet(this JsPropertyMixer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPropertyMixer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPropertyMixer JsConst(this string jsVariableName, JsPropertyMixer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPropertyMixer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPropertyMixer JsConst(this JsPropertyMixer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPropertyMixer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPropertyMixer AsJsPropertyMixerVariable(this string jsVariableName, JsPropertyMixer jsVariableValue = null)
    {
        return new JsPropertyMixer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPropertyMixer AsJsPropertyMixerVariable(this JsPropertyMixer jsVariableValue, string jsVariableName)
    {
        return new JsPropertyMixer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPropertyMixer AsJsPropertyMixer(this JsType value)
    {
        return value is JsPropertyMixer typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsComposite JsSet(this string jsVariableName, JsComposite jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsComposite(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsComposite JsSet(this JsComposite jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsComposite(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsComposite JsLet(this string jsVariableName, JsComposite jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsComposite(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsComposite JsLet(this JsComposite jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsComposite(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsComposite JsConst(this string jsVariableName, JsComposite jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsComposite(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsComposite JsConst(this JsComposite jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsComposite(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsComposite AsJsCompositeVariable(this string jsVariableName, JsComposite jsVariableValue = null)
    {
        return new JsComposite(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsComposite AsJsCompositeVariable(this JsComposite jsVariableValue, string jsVariableName)
    {
        return new JsComposite(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsComposite AsJsComposite(this JsType value)
    {
        return value is JsComposite typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsPropertyBinding JsSet(this string jsVariableName, JsPropertyBinding jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPropertyBinding(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPropertyBinding JsSet(this JsPropertyBinding jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPropertyBinding(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPropertyBinding JsLet(this string jsVariableName, JsPropertyBinding jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPropertyBinding(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPropertyBinding JsLet(this JsPropertyBinding jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPropertyBinding(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPropertyBinding JsConst(this string jsVariableName, JsPropertyBinding jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPropertyBinding(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPropertyBinding JsConst(this JsPropertyBinding jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPropertyBinding(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPropertyBinding AsJsPropertyBindingVariable(this string jsVariableName, JsPropertyBinding jsVariableValue = null)
    {
        return new JsPropertyBinding(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPropertyBinding AsJsPropertyBindingVariable(this JsPropertyBinding jsVariableValue, string jsVariableName)
    {
        return new JsPropertyBinding(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPropertyBinding AsJsPropertyBinding(this JsType value)
    {
        return value is JsPropertyBinding typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsAnimationObjectGroup JsSet(this string jsVariableName, JsAnimationObjectGroup jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationObjectGroup(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationObjectGroup JsSet(this JsAnimationObjectGroup jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationObjectGroup(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationObjectGroup JsLet(this string jsVariableName, JsAnimationObjectGroup jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationObjectGroup(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationObjectGroup JsLet(this JsAnimationObjectGroup jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationObjectGroup(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationObjectGroup JsConst(this string jsVariableName, JsAnimationObjectGroup jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationObjectGroup(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationObjectGroup JsConst(this JsAnimationObjectGroup jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationObjectGroup(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationObjectGroup AsJsAnimationObjectGroupVariable(this string jsVariableName, JsAnimationObjectGroup jsVariableValue = null)
    {
        return new JsAnimationObjectGroup(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationObjectGroup AsJsAnimationObjectGroupVariable(this JsAnimationObjectGroup jsVariableValue, string jsVariableName)
    {
        return new JsAnimationObjectGroup(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationObjectGroup AsJsAnimationObjectGroup(this JsType value)
    {
        return value is JsAnimationObjectGroup typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsAnimationAction JsSet(this string jsVariableName, JsAnimationAction jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationAction(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationAction JsSet(this JsAnimationAction jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationAction(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationAction JsLet(this string jsVariableName, JsAnimationAction jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationAction(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationAction JsLet(this JsAnimationAction jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationAction(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationAction JsConst(this string jsVariableName, JsAnimationAction jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationAction(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationAction JsConst(this JsAnimationAction jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationAction(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationAction AsJsAnimationActionVariable(this string jsVariableName, JsAnimationAction jsVariableValue = null)
    {
        return new JsAnimationAction(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationAction AsJsAnimationActionVariable(this JsAnimationAction jsVariableValue, string jsVariableName)
    {
        return new JsAnimationAction(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationAction AsJsAnimationAction(this JsType value)
    {
        return value is JsAnimationAction typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsAnimationMixer JsSet(this string jsVariableName, JsAnimationMixer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationMixer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationMixer JsSet(this JsAnimationMixer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationMixer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationMixer JsLet(this string jsVariableName, JsAnimationMixer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationMixer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationMixer JsLet(this JsAnimationMixer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationMixer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationMixer JsConst(this string jsVariableName, JsAnimationMixer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationMixer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationMixer JsConst(this JsAnimationMixer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAnimationMixer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationMixer AsJsAnimationMixerVariable(this string jsVariableName, JsAnimationMixer jsVariableValue = null)
    {
        return new JsAnimationMixer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationMixer AsJsAnimationMixerVariable(this JsAnimationMixer jsVariableValue, string jsVariableName)
    {
        return new JsAnimationMixer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAnimationMixer AsJsAnimationMixer(this JsType value)
    {
        return value is JsAnimationMixer typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsUniform JsSet(this string jsVariableName, JsUniform jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUniform(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUniform JsSet(this JsUniform jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUniform(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUniform JsLet(this string jsVariableName, JsUniform jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUniform(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUniform JsLet(this JsUniform jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUniform(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUniform JsConst(this string jsVariableName, JsUniform jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUniform(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUniform JsConst(this JsUniform jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsUniform(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUniform AsJsUniformVariable(this string jsVariableName, JsUniform jsVariableValue = null)
    {
        return new JsUniform(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUniform AsJsUniformVariable(this JsUniform jsVariableValue, string jsVariableName)
    {
        return new JsUniform(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsUniform AsJsUniform(this JsType value)
    {
        return value is JsUniform typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsInstancedInterleavedBuffer JsSet(this string jsVariableName, JsInstancedInterleavedBuffer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedInterleavedBuffer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedInterleavedBuffer JsSet(this JsInstancedInterleavedBuffer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedInterleavedBuffer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedInterleavedBuffer JsLet(this string jsVariableName, JsInstancedInterleavedBuffer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedInterleavedBuffer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedInterleavedBuffer JsLet(this JsInstancedInterleavedBuffer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedInterleavedBuffer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedInterleavedBuffer JsConst(this string jsVariableName, JsInstancedInterleavedBuffer jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedInterleavedBuffer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedInterleavedBuffer JsConst(this JsInstancedInterleavedBuffer jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsInstancedInterleavedBuffer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedInterleavedBuffer AsJsInstancedInterleavedBufferVariable(this string jsVariableName, JsInstancedInterleavedBuffer jsVariableValue = null)
    {
        return new JsInstancedInterleavedBuffer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedInterleavedBuffer AsJsInstancedInterleavedBufferVariable(this JsInstancedInterleavedBuffer jsVariableValue, string jsVariableName)
    {
        return new JsInstancedInterleavedBuffer(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsInstancedInterleavedBuffer AsJsInstancedInterleavedBuffer(this JsType value)
    {
        return value is JsInstancedInterleavedBuffer typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsGLBufferAttribute JsSet(this string jsVariableName, JsGLBufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGLBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGLBufferAttribute JsSet(this JsGLBufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGLBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGLBufferAttribute JsLet(this string jsVariableName, JsGLBufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGLBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGLBufferAttribute JsLet(this JsGLBufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGLBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGLBufferAttribute JsConst(this string jsVariableName, JsGLBufferAttribute jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGLBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGLBufferAttribute JsConst(this JsGLBufferAttribute jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGLBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGLBufferAttribute AsJsGLBufferAttributeVariable(this string jsVariableName, JsGLBufferAttribute jsVariableValue = null)
    {
        return new JsGLBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGLBufferAttribute AsJsGLBufferAttributeVariable(this JsGLBufferAttribute jsVariableValue, string jsVariableName)
    {
        return new JsGLBufferAttribute(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGLBufferAttribute AsJsGLBufferAttribute(this JsType value)
    {
        return value is JsGLBufferAttribute typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsRaycaster JsSet(this string jsVariableName, JsRaycaster jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRaycaster(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRaycaster JsSet(this JsRaycaster jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRaycaster(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRaycaster JsLet(this string jsVariableName, JsRaycaster jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRaycaster(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRaycaster JsLet(this JsRaycaster jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRaycaster(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRaycaster JsConst(this string jsVariableName, JsRaycaster jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRaycaster(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRaycaster JsConst(this JsRaycaster jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsRaycaster(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRaycaster AsJsRaycasterVariable(this string jsVariableName, JsRaycaster jsVariableValue = null)
    {
        return new JsRaycaster(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRaycaster AsJsRaycasterVariable(this JsRaycaster jsVariableValue, string jsVariableName)
    {
        return new JsRaycaster(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsRaycaster AsJsRaycaster(this JsType value)
    {
        return value is JsRaycaster typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsSpherical JsSet(this string jsVariableName, JsSpherical jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpherical(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpherical JsSet(this JsSpherical jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpherical(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpherical JsLet(this string jsVariableName, JsSpherical jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpherical(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpherical JsLet(this JsSpherical jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpherical(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpherical JsConst(this string jsVariableName, JsSpherical jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpherical(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpherical JsConst(this JsSpherical jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpherical(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpherical AsJsSphericalVariable(this string jsVariableName, JsSpherical jsVariableValue = null)
    {
        return new JsSpherical(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpherical AsJsSphericalVariable(this JsSpherical jsVariableValue, string jsVariableName)
    {
        return new JsSpherical(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpherical AsJsSpherical(this JsType value)
    {
        return value is JsSpherical typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCylindrical JsSet(this string jsVariableName, JsCylindrical jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCylindrical(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCylindrical JsSet(this JsCylindrical jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCylindrical(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCylindrical JsLet(this string jsVariableName, JsCylindrical jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCylindrical(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCylindrical JsLet(this JsCylindrical jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCylindrical(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCylindrical JsConst(this string jsVariableName, JsCylindrical jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCylindrical(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCylindrical JsConst(this JsCylindrical jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCylindrical(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCylindrical AsJsCylindricalVariable(this string jsVariableName, JsCylindrical jsVariableValue = null)
    {
        return new JsCylindrical(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCylindrical AsJsCylindricalVariable(this JsCylindrical jsVariableValue, string jsVariableName)
    {
        return new JsCylindrical(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCylindrical AsJsCylindrical(this JsType value)
    {
        return value is JsCylindrical typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsBox2 JsSet(this string jsVariableName, JsBox2 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox2 JsSet(this JsBox2 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox2 JsLet(this string jsVariableName, JsBox2 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox2 JsLet(this JsBox2 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox2 JsConst(this string jsVariableName, JsBox2 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox2 JsConst(this JsBox2 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox2 AsJsBox2Variable(this string jsVariableName, JsBox2 jsVariableValue = null)
    {
        return new JsBox2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox2 AsJsBox2Variable(this JsBox2 jsVariableValue, string jsVariableName)
    {
        return new JsBox2(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox2 AsJsBox2(this JsType value)
    {
        return value is JsBox2 typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsLine3 JsSet(this string jsVariableName, JsLine3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLine3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLine3 JsSet(this JsLine3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLine3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLine3 JsLet(this string jsVariableName, JsLine3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLine3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLine3 JsLet(this JsLine3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLine3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLine3 JsConst(this string jsVariableName, JsLine3 jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLine3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLine3 JsConst(this JsLine3 jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsLine3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLine3 AsJsLine3Variable(this string jsVariableName, JsLine3 jsVariableValue = null)
    {
        return new JsLine3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLine3 AsJsLine3Variable(this JsLine3 jsVariableValue, string jsVariableName)
    {
        return new JsLine3(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsLine3 AsJsLine3(this JsType value)
    {
        return value is JsLine3 typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsImmediateRenderObject JsSet(this string jsVariableName, JsImmediateRenderObject jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImmediateRenderObject(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImmediateRenderObject JsSet(this JsImmediateRenderObject jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImmediateRenderObject(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImmediateRenderObject JsLet(this string jsVariableName, JsImmediateRenderObject jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImmediateRenderObject(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImmediateRenderObject JsLet(this JsImmediateRenderObject jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImmediateRenderObject(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImmediateRenderObject JsConst(this string jsVariableName, JsImmediateRenderObject jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImmediateRenderObject(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImmediateRenderObject JsConst(this JsImmediateRenderObject jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsImmediateRenderObject(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImmediateRenderObject AsJsImmediateRenderObjectVariable(this string jsVariableName, JsImmediateRenderObject jsVariableValue = null)
    {
        return new JsImmediateRenderObject(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImmediateRenderObject AsJsImmediateRenderObjectVariable(this JsImmediateRenderObject jsVariableValue, string jsVariableName)
    {
        return new JsImmediateRenderObject(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsImmediateRenderObject AsJsImmediateRenderObject(this JsType value)
    {
        return value is JsImmediateRenderObject typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsSpotLightHelper JsSet(this string jsVariableName, JsSpotLightHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLightHelper JsSet(this JsSpotLightHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLightHelper JsLet(this string jsVariableName, JsSpotLightHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLightHelper JsLet(this JsSpotLightHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLightHelper JsConst(this string jsVariableName, JsSpotLightHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLightHelper JsConst(this JsSpotLightHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSpotLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLightHelper AsJsSpotLightHelperVariable(this string jsVariableName, JsSpotLightHelper jsVariableValue = null)
    {
        return new JsSpotLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLightHelper AsJsSpotLightHelperVariable(this JsSpotLightHelper jsVariableValue, string jsVariableName)
    {
        return new JsSpotLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSpotLightHelper AsJsSpotLightHelper(this JsType value)
    {
        return value is JsSpotLightHelper typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsSkeletonHelper JsSet(this string jsVariableName, JsSkeletonHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkeletonHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkeletonHelper JsSet(this JsSkeletonHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkeletonHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkeletonHelper JsLet(this string jsVariableName, JsSkeletonHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkeletonHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkeletonHelper JsLet(this JsSkeletonHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkeletonHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkeletonHelper JsConst(this string jsVariableName, JsSkeletonHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkeletonHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkeletonHelper JsConst(this JsSkeletonHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsSkeletonHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkeletonHelper AsJsSkeletonHelperVariable(this string jsVariableName, JsSkeletonHelper jsVariableValue = null)
    {
        return new JsSkeletonHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkeletonHelper AsJsSkeletonHelperVariable(this JsSkeletonHelper jsVariableValue, string jsVariableName)
    {
        return new JsSkeletonHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsSkeletonHelper AsJsSkeletonHelper(this JsType value)
    {
        return value is JsSkeletonHelper typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsPointLightHelper JsSet(this string jsVariableName, JsPointLightHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLightHelper JsSet(this JsPointLightHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLightHelper JsLet(this string jsVariableName, JsPointLightHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLightHelper JsLet(this JsPointLightHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLightHelper JsConst(this string jsVariableName, JsPointLightHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLightHelper JsConst(this JsPointLightHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPointLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLightHelper AsJsPointLightHelperVariable(this string jsVariableName, JsPointLightHelper jsVariableValue = null)
    {
        return new JsPointLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLightHelper AsJsPointLightHelperVariable(this JsPointLightHelper jsVariableValue, string jsVariableName)
    {
        return new JsPointLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPointLightHelper AsJsPointLightHelper(this JsType value)
    {
        return value is JsPointLightHelper typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsHemisphereLightHelper JsSet(this string jsVariableName, JsHemisphereLightHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLightHelper JsSet(this JsHemisphereLightHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLightHelper JsLet(this string jsVariableName, JsHemisphereLightHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLightHelper JsLet(this JsHemisphereLightHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLightHelper JsConst(this string jsVariableName, JsHemisphereLightHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLightHelper JsConst(this JsHemisphereLightHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsHemisphereLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLightHelper AsJsHemisphereLightHelperVariable(this string jsVariableName, JsHemisphereLightHelper jsVariableValue = null)
    {
        return new JsHemisphereLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLightHelper AsJsHemisphereLightHelperVariable(this JsHemisphereLightHelper jsVariableValue, string jsVariableName)
    {
        return new JsHemisphereLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsHemisphereLightHelper AsJsHemisphereLightHelper(this JsType value)
    {
        return value is JsHemisphereLightHelper typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsGridHelper JsSet(this string jsVariableName, JsGridHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGridHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGridHelper JsSet(this JsGridHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGridHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGridHelper JsLet(this string jsVariableName, JsGridHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGridHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGridHelper JsLet(this JsGridHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGridHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGridHelper JsConst(this string jsVariableName, JsGridHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGridHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGridHelper JsConst(this JsGridHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsGridHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGridHelper AsJsGridHelperVariable(this string jsVariableName, JsGridHelper jsVariableValue = null)
    {
        return new JsGridHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGridHelper AsJsGridHelperVariable(this JsGridHelper jsVariableValue, string jsVariableName)
    {
        return new JsGridHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsGridHelper AsJsGridHelper(this JsType value)
    {
        return value is JsGridHelper typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsPolarGridHelper JsSet(this string jsVariableName, JsPolarGridHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPolarGridHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPolarGridHelper JsSet(this JsPolarGridHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPolarGridHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPolarGridHelper JsLet(this string jsVariableName, JsPolarGridHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPolarGridHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPolarGridHelper JsLet(this JsPolarGridHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPolarGridHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPolarGridHelper JsConst(this string jsVariableName, JsPolarGridHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPolarGridHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPolarGridHelper JsConst(this JsPolarGridHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPolarGridHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPolarGridHelper AsJsPolarGridHelperVariable(this string jsVariableName, JsPolarGridHelper jsVariableValue = null)
    {
        return new JsPolarGridHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPolarGridHelper AsJsPolarGridHelperVariable(this JsPolarGridHelper jsVariableValue, string jsVariableName)
    {
        return new JsPolarGridHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPolarGridHelper AsJsPolarGridHelper(this JsType value)
    {
        return value is JsPolarGridHelper typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsDirectionalLightHelper JsSet(this string jsVariableName, JsDirectionalLightHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLightHelper JsSet(this JsDirectionalLightHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLightHelper JsLet(this string jsVariableName, JsDirectionalLightHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLightHelper JsLet(this JsDirectionalLightHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLightHelper JsConst(this string jsVariableName, JsDirectionalLightHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLightHelper JsConst(this JsDirectionalLightHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDirectionalLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLightHelper AsJsDirectionalLightHelperVariable(this string jsVariableName, JsDirectionalLightHelper jsVariableValue = null)
    {
        return new JsDirectionalLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLightHelper AsJsDirectionalLightHelperVariable(this JsDirectionalLightHelper jsVariableValue, string jsVariableName)
    {
        return new JsDirectionalLightHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDirectionalLightHelper AsJsDirectionalLightHelper(this JsType value)
    {
        return value is JsDirectionalLightHelper typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsCameraHelper JsSet(this string jsVariableName, JsCameraHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCameraHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCameraHelper JsSet(this JsCameraHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCameraHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCameraHelper JsLet(this string jsVariableName, JsCameraHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCameraHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCameraHelper JsLet(this JsCameraHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCameraHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCameraHelper JsConst(this string jsVariableName, JsCameraHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCameraHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCameraHelper JsConst(this JsCameraHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsCameraHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCameraHelper AsJsCameraHelperVariable(this string jsVariableName, JsCameraHelper jsVariableValue = null)
    {
        return new JsCameraHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCameraHelper AsJsCameraHelperVariable(this JsCameraHelper jsVariableValue, string jsVariableName)
    {
        return new JsCameraHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsCameraHelper AsJsCameraHelper(this JsType value)
    {
        return value is JsCameraHelper typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsBoxHelper JsSet(this string jsVariableName, JsBoxHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBoxHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBoxHelper JsSet(this JsBoxHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBoxHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBoxHelper JsLet(this string jsVariableName, JsBoxHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBoxHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBoxHelper JsLet(this JsBoxHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBoxHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBoxHelper JsConst(this string jsVariableName, JsBoxHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBoxHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBoxHelper JsConst(this JsBoxHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBoxHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBoxHelper AsJsBoxHelperVariable(this string jsVariableName, JsBoxHelper jsVariableValue = null)
    {
        return new JsBoxHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBoxHelper AsJsBoxHelperVariable(this JsBoxHelper jsVariableValue, string jsVariableName)
    {
        return new JsBoxHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBoxHelper AsJsBoxHelper(this JsType value)
    {
        return value is JsBoxHelper typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsBox3Helper JsSet(this string jsVariableName, JsBox3Helper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox3Helper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox3Helper JsSet(this JsBox3Helper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox3Helper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox3Helper JsLet(this string jsVariableName, JsBox3Helper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox3Helper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox3Helper JsLet(this JsBox3Helper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox3Helper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox3Helper JsConst(this string jsVariableName, JsBox3Helper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox3Helper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox3Helper JsConst(this JsBox3Helper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsBox3Helper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox3Helper AsJsBox3HelperVariable(this string jsVariableName, JsBox3Helper jsVariableValue = null)
    {
        return new JsBox3Helper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox3Helper AsJsBox3HelperVariable(this JsBox3Helper jsVariableValue, string jsVariableName)
    {
        return new JsBox3Helper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsBox3Helper AsJsBox3Helper(this JsType value)
    {
        return value is JsBox3Helper typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsPlaneHelper JsSet(this string jsVariableName, JsPlaneHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlaneHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlaneHelper JsSet(this JsPlaneHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlaneHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlaneHelper JsLet(this string jsVariableName, JsPlaneHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlaneHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlaneHelper JsLet(this JsPlaneHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlaneHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlaneHelper JsConst(this string jsVariableName, JsPlaneHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlaneHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlaneHelper JsConst(this JsPlaneHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsPlaneHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlaneHelper AsJsPlaneHelperVariable(this string jsVariableName, JsPlaneHelper jsVariableValue = null)
    {
        return new JsPlaneHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlaneHelper AsJsPlaneHelperVariable(this JsPlaneHelper jsVariableValue, string jsVariableName)
    {
        return new JsPlaneHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsPlaneHelper AsJsPlaneHelper(this JsType value)
    {
        return value is JsPlaneHelper typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsArrowHelper JsSet(this string jsVariableName, JsArrowHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArrowHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArrowHelper JsSet(this JsArrowHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArrowHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArrowHelper JsLet(this string jsVariableName, JsArrowHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArrowHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArrowHelper JsLet(this JsArrowHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArrowHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArrowHelper JsConst(this string jsVariableName, JsArrowHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArrowHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArrowHelper JsConst(this JsArrowHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsArrowHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArrowHelper AsJsArrowHelperVariable(this string jsVariableName, JsArrowHelper jsVariableValue = null)
    {
        return new JsArrowHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArrowHelper AsJsArrowHelperVariable(this JsArrowHelper jsVariableValue, string jsVariableName)
    {
        return new JsArrowHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsArrowHelper AsJsArrowHelper(this JsType value)
    {
        return value is JsArrowHelper typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsAxesHelper JsSet(this string jsVariableName, JsAxesHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAxesHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAxesHelper JsSet(this JsAxesHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAxesHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAxesHelper JsLet(this string jsVariableName, JsAxesHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAxesHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAxesHelper JsLet(this JsAxesHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAxesHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAxesHelper JsConst(this string jsVariableName, JsAxesHelper jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAxesHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAxesHelper JsConst(this JsAxesHelper jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsAxesHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAxesHelper AsJsAxesHelperVariable(this string jsVariableName, JsAxesHelper jsVariableValue = null)
    {
        return new JsAxesHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAxesHelper AsJsAxesHelperVariable(this JsAxesHelper jsVariableValue, string jsVariableName)
    {
        return new JsAxesHelper(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsAxesHelper AsJsAxesHelper(this JsType value)
    {
        return value is JsAxesHelper typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsShapePath JsSet(this string jsVariableName, JsShapePath jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapePath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapePath JsSet(this JsShapePath jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapePath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapePath JsLet(this string jsVariableName, JsShapePath jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapePath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapePath JsLet(this JsShapePath jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapePath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapePath JsConst(this string jsVariableName, JsShapePath jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapePath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapePath JsConst(this JsShapePath jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsShapePath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapePath AsJsShapePathVariable(this string jsVariableName, JsShapePath jsVariableValue = null)
    {
        return new JsShapePath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapePath AsJsShapePathVariable(this JsShapePath jsVariableValue, string jsVariableName)
    {
        return new JsShapePath(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsShapePath AsJsShapePath(this JsType value)
    {
        return value is JsShapePath typedValue ? typedValue : value.GetJsCode();
    }
        
    public static JsDataUtils JsSet(this string jsVariableName, JsDataUtils jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataUtils JsSet(this JsDataUtils jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"{jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataUtils JsLet(this string jsVariableName, JsDataUtils jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataUtils JsLet(this JsDataUtils jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"let {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataUtils JsConst(this string jsVariableName, JsDataUtils jsVariableValue)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataUtils JsConst(this JsDataUtils jsVariableValue, string jsVariableName)
    {
        JavaScriptCodeComposer.DefaultComposer.CodeLine($"const {jsVariableName} = {jsVariableValue.GetJsCode()};");
        
        return new JsDataUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataUtils AsJsDataUtilsVariable(this string jsVariableName, JsDataUtils jsVariableValue = null)
    {
        return new JsDataUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataUtils AsJsDataUtilsVariable(this JsDataUtils jsVariableValue, string jsVariableName)
    {
        return new JsDataUtils(
            new JsVariableConstructor(jsVariableName),
            jsVariableValue
        );
    }
        
    public static JsDataUtils AsJsDataUtils(this JsType value)
    {
        return value is JsDataUtils typedValue ? typedValue : value.GetJsCode();
    }
        
        
}