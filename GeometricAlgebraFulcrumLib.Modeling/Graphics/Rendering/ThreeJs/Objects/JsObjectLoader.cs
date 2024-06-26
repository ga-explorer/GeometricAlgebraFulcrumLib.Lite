using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsObjectLoaderConstructor :
    JsTypeConstructor
{
    public JsType Manager { get; }
        
        


    internal JsObjectLoaderConstructor(JsType argManager)
    {
        Manager = argManager ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.ObjectLoader({Manager.GetJsCode()})";
    }
}
    
public partial class JsObjectLoader :
    JsLoader
{
    public static implicit operator JsObjectLoader(string jsTextCode)
    {
        return new JsObjectLoader(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsObjectLoader value)
    {
        return value.GetJsCode();
    }


    private readonly JsObjectLoader _jsVariableValue;
    public JsObjectLoader JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _resourcePath;
    public JsType ResourcePath
    {
        get => _resourcePath ?? throw new InvalidOperationException();
        set
        {
            if (_resourcePath is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.resourcePath = {valueCode};");
        }
    }

    internal JsObjectLoader(JsTypeConstructor jsCodeSource, JsObjectLoader jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _resourcePath = $"{variableName}.resourcePath".AsJsTypeVariable();
    }

    public JsObjectLoader(JsType argManager = null)
        : base(new JsObjectLoaderConstructor(argManager))
    {
    }

    public JsType Load(JsType argUrl = null, JsType argOnLoad = null, JsType argOnProgress = null, JsType argOnError = null)
    {
        return CallMethod("load", argUrl ?? new JsObject(), argOnLoad ?? new JsObject(), argOnProgress ?? new JsObject(), argOnError ?? new JsObject());
    }
        
    public JsType LoadAsync(JsType argUrl = null, JsType argOnProgress = null)
    {
        return CallMethod("loadAsync", argUrl ?? new JsObject(), argOnProgress ?? new JsObject());
    }
        
    public JsType Parse(JsType argJson = null, JsType argOnLoad = null)
    {
        return CallMethod("parse", argJson ?? new JsObject(), argOnLoad ?? new JsObject());
    }
        
    public JsType ParseAsync(JsType argJson = null)
    {
        return CallMethod("parseAsync", argJson ?? new JsObject());
    }
        
    public JsObject ParseShapes(JsType argJson = null)
    {
        return CallMethod("parseShapes", argJson ?? new JsObject());
    }
        
    public JsObject ParseSkeletons(JsType argJson = null, JsType argObject = null)
    {
        return CallMethod("parseSkeletons", argJson ?? new JsObject(), argObject ?? new JsObject());
    }
        
    public JsObject ParseGeometries(JsType argJson = null, JsType argShapes = null)
    {
        return CallMethod("parseGeometries", argJson ?? new JsObject(), argShapes ?? new JsObject());
    }
        
    public JsObject ParseMaterials(JsType argJson = null, JsType argTextures = null)
    {
        return CallMethod("parseMaterials", argJson ?? new JsObject(), argTextures ?? new JsObject());
    }
        
    public JsObject ParseAnimations(JsType argJson = null)
    {
        return CallMethod("parseAnimations", argJson ?? new JsObject());
    }
        
    public JsObject ParseImages(JsType argJson = null, JsType argOnLoad = null)
    {
        return CallMethod("parseImages", argJson ?? new JsObject(), argOnLoad ?? new JsObject());
    }
        
    public JsObject ParseImagesAsync(JsType argJson = null)
    {
        return CallMethod("parseImagesAsync", argJson ?? new JsObject());
    }
        
    public JsObject ParseTextures(JsType argJson = null, JsType argImages = null)
    {
        return CallMethod("parseTextures", argJson ?? new JsObject(), argImages ?? new JsObject());
    }
        
    public JsType ParseObject(JsType argData = null, JsType argGeometries = null, JsType argMaterials = null, JsType argTextures = null, JsType argAnimations = null)
    {
        return CallMethod("parseObject", argData ?? new JsObject(), argGeometries ?? new JsObject(), argMaterials ?? new JsObject(), argTextures ?? new JsObject(), argAnimations ?? new JsObject());
    }
        
    public JsType BindSkeletons(JsType argObject = null, JsType argSkeletons = null)
    {
        return CallMethod("bindSkeletons", argObject ?? new JsObject(), argSkeletons ?? new JsObject());
    }
        
    public JsType SetTexturePath(JsType argValue = null)
    {
        return CallMethod("setTexturePath", argValue ?? new JsObject());
    }
        
        
}