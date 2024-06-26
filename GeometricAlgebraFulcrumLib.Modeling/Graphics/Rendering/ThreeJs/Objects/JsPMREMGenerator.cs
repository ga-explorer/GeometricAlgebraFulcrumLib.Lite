using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsPMREMGeneratorConstructor :
    JsTypeConstructor
{
    public JsType Renderer { get; }
        
        


    internal JsPMREMGeneratorConstructor(JsType argRenderer)
    {
        Renderer = argRenderer ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.PMREMGenerator({Renderer.GetJsCode()})";
    }
}
    
public partial class JsPMREMGenerator :
    JsObjectType
{
    public static implicit operator JsPMREMGenerator(string jsTextCode)
    {
        return new JsPMREMGenerator(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsPMREMGenerator value)
    {
        return value.GetJsCode();
    }


    private readonly JsPMREMGenerator _jsVariableValue;
    public JsPMREMGenerator JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

        

    internal JsPMREMGenerator(JsTypeConstructor jsCodeSource, JsPMREMGenerator jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

            
    }

    public JsPMREMGenerator(JsType argRenderer = null)
        : base(new JsPMREMGeneratorConstructor(argRenderer))
    {
    }

    public JsType FromScene(JsType argScene = null, JsNumber argSigma = null, JsNumber argNear = null, JsNumber argFar = null)
    {
        return CallMethod("fromScene", argScene ?? new JsObject(), argSigma ?? (0).AsJsNumber(), argNear ?? (0.1).AsJsNumber(), argFar ?? (100).AsJsNumber());
    }
        
    public JsType FromEquirectangular(JsType argEquirectangular = null)
    {
        return CallMethod("fromEquirectangular", argEquirectangular ?? new JsObject());
    }
        
    public JsType FromCubemap(JsType argCubemap = null)
    {
        return CallMethod("fromCubemap", argCubemap ?? new JsObject());
    }
        
    public JsType CompileCubemapShader()
    {
        return CallMethod("compileCubemapShader");
    }
        
    public JsType CompileEquirectangularShader()
    {
        return CallMethod("compileEquirectangularShader");
    }
        
    public JsType Dispose()
    {
        return CallMethod("dispose");
    }
        
    public JsType _cleanup(JsType argOutputTarget = null)
    {
        return CallMethod("_cleanup", argOutputTarget ?? new JsObject());
    }
        
    public JsType _fromTexture(JsType argTexture = null)
    {
        return CallMethod("_fromTexture", argTexture ?? new JsObject());
    }
        
    public JsType _allocateTargets(JsType argTexture = null)
    {
        return CallMethod("_allocateTargets", argTexture ?? new JsObject());
    }
        
    public JsType _compileMaterial(JsType argMaterial = null)
    {
        return CallMethod("_compileMaterial", argMaterial ?? new JsObject());
    }
        
    public JsType _sceneToCubeUV(JsType argScene = null, JsType argNear = null, JsType argFar = null, JsType argCubeUVRenderTarget = null)
    {
        return CallMethod("_sceneToCubeUV", argScene ?? new JsObject(), argNear ?? new JsObject(), argFar ?? new JsObject(), argCubeUVRenderTarget ?? new JsObject());
    }
        
    public JsType _setEncoding(JsType argUniform = null, JsType argTexture = null)
    {
        return CallMethod("_setEncoding", argUniform ?? new JsObject(), argTexture ?? new JsObject());
    }
        
    public JsType _textureToCubeUV(JsType argTexture = null, JsType argCubeUVRenderTarget = null)
    {
        return CallMethod("_textureToCubeUV", argTexture ?? new JsObject(), argCubeUVRenderTarget ?? new JsObject());
    }
        
    public JsType _applyPMREM(JsType argCubeUVRenderTarget = null)
    {
        return CallMethod("_applyPMREM", argCubeUVRenderTarget ?? new JsObject());
    }
        
    public JsType _blur(JsType argCubeUVRenderTarget = null, JsType argLodIn = null, JsType argLodOut = null, JsType argSigma = null, JsType argPoleAxis = null)
    {
        return CallMethod("_blur", argCubeUVRenderTarget ?? new JsObject(), argLodIn ?? new JsObject(), argLodOut ?? new JsObject(), argSigma ?? new JsObject(), argPoleAxis ?? new JsObject());
    }
        
    public JsType _halfBlur(JsType argTargetIn = null, JsType argTargetOut = null, JsType argLodIn = null, JsType argLodOut = null, JsType argSigmaRadians = null, JsType argDirection = null, JsType argPoleAxis = null)
    {
        return CallMethod("_halfBlur", argTargetIn ?? new JsObject(), argTargetOut ?? new JsObject(), argLodIn ?? new JsObject(), argLodOut ?? new JsObject(), argSigmaRadians ?? new JsObject(), argDirection ?? new JsObject(), argPoleAxis ?? new JsObject());
    }
        
        
}