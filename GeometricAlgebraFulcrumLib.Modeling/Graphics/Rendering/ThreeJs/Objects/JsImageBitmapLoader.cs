using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsImageBitmapLoaderConstructor :
    JsTypeConstructor
{
    public JsType Manager { get; }
        
        


    internal JsImageBitmapLoaderConstructor(JsType argManager)
    {
        Manager = argManager ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.ImageBitmapLoader({Manager.GetJsCode()})";
    }
}
    
public partial class JsImageBitmapLoader :
    JsLoader
{
    public static implicit operator JsImageBitmapLoader(string jsTextCode)
    {
        return new JsImageBitmapLoader(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsImageBitmapLoader value)
    {
        return value.GetJsCode();
    }


    private readonly JsImageBitmapLoader _jsVariableValue;
    public JsImageBitmapLoader JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _options;
    public JsType Options
    {
        get => _options ?? throw new InvalidOperationException();
        set
        {
            if (_options is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.options = {valueCode};");
        }
    }

    internal JsImageBitmapLoader(JsTypeConstructor jsCodeSource, JsImageBitmapLoader jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _options = $"{variableName}.options".AsJsTypeVariable();
    }

    public JsImageBitmapLoader(JsType argManager = null)
        : base(new JsImageBitmapLoaderConstructor(argManager))
    {
    }

    public JsImageBitmapLoader SetOptions(JsType argOptions = null)
    {
        CallMethodVoid("setOptions", argOptions ?? new JsObject());
            
        return this;
    }
        
    public JsType Load(JsType argUrl = null, JsType argOnLoad = null, JsType argOnProgress = null, JsType argOnError = null)
    {
        return CallMethod("load", argUrl ?? new JsObject(), argOnLoad ?? new JsObject(), argOnProgress ?? new JsObject(), argOnError ?? new JsObject());
    }
        
        
}