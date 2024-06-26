using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsMaterialLoaderConstructor :
    JsTypeConstructor
{
    public JsType Manager { get; }
        
        


    internal JsMaterialLoaderConstructor(JsType argManager)
    {
        Manager = argManager ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.MaterialLoader({Manager.GetJsCode()})";
    }
}
    
public partial class JsMaterialLoader :
    JsLoader
{
    public static implicit operator JsMaterialLoader(string jsTextCode)
    {
        return new JsMaterialLoader(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsMaterialLoader value)
    {
        return value.GetJsCode();
    }


    private readonly JsMaterialLoader _jsVariableValue;
    public JsMaterialLoader JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _textures;
    public JsType Textures
    {
        get => _textures ?? throw new InvalidOperationException();
        set
        {
            if (_textures is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.textures = {valueCode};");
        }
    }

    internal JsMaterialLoader(JsTypeConstructor jsCodeSource, JsMaterialLoader jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _textures = $"{variableName}.textures".AsJsTypeVariable();
    }

    public JsMaterialLoader(JsType argManager = null)
        : base(new JsMaterialLoaderConstructor(argManager))
    {
    }

    public JsType Load(JsType argUrl = null, JsType argOnLoad = null, JsType argOnProgress = null, JsType argOnError = null)
    {
        return CallMethod("load", argUrl ?? new JsObject(), argOnLoad ?? new JsObject(), argOnProgress ?? new JsObject(), argOnError ?? new JsObject());
    }
        
    public JsType Parse(JsType argJson = null)
    {
        return CallMethod("parse", argJson ?? new JsObject());
    }
        
    public JsMaterialLoader SetTextures(JsType argValue = null)
    {
        CallMethodVoid("setTextures", argValue ?? new JsObject());
            
        return this;
    }
        
        
}