using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsShapePathConstructor :
    JsTypeConstructor
{
        


    internal JsShapePathConstructor()
    {
            
    }

    public override string GetJsCode()
    {
        return $"new THREE.ShapePath()";
    }
}
    
public partial class JsShapePath :
    JsObjectType
{
    public static implicit operator JsShapePath(string jsTextCode)
    {
        return new JsShapePath(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsShapePath value)
    {
        return value.GetJsCode();
    }


    private readonly JsShapePath _jsVariableValue;
    public JsShapePath JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"ShapePath\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _color;
    public JsType Color
    {
        get => _color ?? throw new InvalidOperationException();
        set
        {
            if (_color is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.color = {valueCode};");
        }
    }
        
    private readonly JsType _subPaths;
    public JsType SubPaths
    {
        get => _subPaths ?? throw new InvalidOperationException();
        set
        {
            if (_subPaths is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.subPaths = {valueCode};");
        }
    }
        
    private readonly JsType _currentPath;
    public JsType CurrentPath
    {
        get => _currentPath ?? throw new InvalidOperationException();
        set
        {
            if (_currentPath is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.currentPath = {valueCode};");
        }
    }

    internal JsShapePath(JsTypeConstructor jsCodeSource, JsShapePath jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _color = $"{variableName}.color".AsJsTypeVariable();
        _subPaths = $"{variableName}.subPaths".AsJsTypeVariable();
        _currentPath = $"{variableName}.currentPath".AsJsTypeVariable();
    }

    public JsShapePath()
        : base(new JsShapePathConstructor())
    {
    }

    public JsShapePath MoveTo(JsType argX = null, JsType argY = null)
    {
        CallMethodVoid("moveTo", argX ?? new JsObject(), argY ?? new JsObject());
            
        return this;
    }
        
    public JsShapePath LineTo(JsType argX = null, JsType argY = null)
    {
        CallMethodVoid("lineTo", argX ?? new JsObject(), argY ?? new JsObject());
            
        return this;
    }
        
    public JsShapePath QuadraticCurveTo(JsType argACPx = null, JsType argACPy = null, JsType argAX = null, JsType argAY = null)
    {
        CallMethodVoid("quadraticCurveTo", argACPx ?? new JsObject(), argACPy ?? new JsObject(), argAX ?? new JsObject(), argAY ?? new JsObject());
            
        return this;
    }
        
    public JsShapePath BezierCurveTo(JsType argACP1x = null, JsType argACP1y = null, JsType argACP2x = null, JsType argACP2y = null, JsType argAX = null, JsType argAY = null)
    {
        CallMethodVoid("bezierCurveTo", argACP1x ?? new JsObject(), argACP1y ?? new JsObject(), argACP2x ?? new JsObject(), argACP2y ?? new JsObject(), argAX ?? new JsObject(), argAY ?? new JsObject());
            
        return this;
    }
        
    public JsShapePath SplineThru(JsType argPts = null)
    {
        CallMethodVoid("splineThru", argPts ?? new JsObject());
            
        return this;
    }
        
    public JsArray ToShapes(JsType argIsCCW = null, JsType argNoHoles = null)
    {
        return CallMethod("toShapes", argIsCCW ?? new JsObject(), argNoHoles ?? new JsObject());
    }
        
        
}