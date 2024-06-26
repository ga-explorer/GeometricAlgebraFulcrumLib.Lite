using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsSkeletonHelperConstructor :
    JsTypeConstructor
{
    public JsType Object { get; }
        
        


    internal JsSkeletonHelperConstructor(JsType argObject)
    {
        Object = argObject ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.SkeletonHelper({Object.GetJsCode()})";
    }
}
    
public partial class JsSkeletonHelper :
    JsLineSegments
{
    public static implicit operator JsSkeletonHelper(string jsTextCode)
    {
        return new JsSkeletonHelper(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsSkeletonHelper value)
    {
        return value.GetJsCode();
    }


    private readonly JsSkeletonHelper _jsVariableValue;
    public JsSkeletonHelper JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsString _type;
    public JsString Type
    {
        get => _type ?? throw new InvalidOperationException();
        set
        {
            if (_type is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"SkeletonHelper\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsBoolean _isSkeletonHelper;
    public JsBoolean IsSkeletonHelper
    {
        get => _isSkeletonHelper ?? throw new InvalidOperationException();
        set
        {
            if (_isSkeletonHelper is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.isSkeletonHelper = {valueCode};");
        }
    }
        
    private readonly JsType _root;
    public JsType Root
    {
        get => _root ?? throw new InvalidOperationException();
        set
        {
            if (_root is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.root = {valueCode};");
        }
    }
        
    private readonly JsType _bones;
    public JsType Bones
    {
        get => _bones ?? throw new InvalidOperationException();
        set
        {
            if (_bones is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.bones = {valueCode};");
        }
    }
        
    private readonly JsType _matrix;
    public JsType Matrix
    {
        get => _matrix ?? throw new InvalidOperationException();
        set
        {
            if (_matrix is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matrix = {valueCode};");
        }
    }
        
    private readonly JsBoolean _matrixAutoUpdate;
    public JsBoolean MatrixAutoUpdate
    {
        get => _matrixAutoUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_matrixAutoUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matrixAutoUpdate = {valueCode};");
        }
    }

    internal JsSkeletonHelper(JsTypeConstructor jsCodeSource, JsSkeletonHelper jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _isSkeletonHelper = $"{variableName}.isSkeletonHelper".AsJsBooleanVariable();
        _root = $"{variableName}.root".AsJsTypeVariable();
        _bones = $"{variableName}.bones".AsJsTypeVariable();
        _matrix = $"{variableName}.matrix".AsJsTypeVariable();
        _matrixAutoUpdate = $"{variableName}.matrixAutoUpdate".AsJsBooleanVariable();
    }

    public JsSkeletonHelper(JsType argObject = null)
        : base(new JsSkeletonHelperConstructor(argObject))
    {
    }

    public JsType UpdateMatrixWorld(JsType argForce = null)
    {
        return CallMethod("updateMatrixWorld", argForce ?? new JsObject());
    }
        
        
}