using GeometricAlgebraFulcrumLib.Utilities.Text.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsInstancedMeshConstructor :
    JsTypeConstructor
{
    public JsType Geometry { get; }
        
    public JsType Material { get; }
        
    public JsType Count { get; }
        
        


    internal JsInstancedMeshConstructor(JsType argGeometry, JsType argMaterial, JsType argCount)
    {
        Geometry = argGeometry ?? new JsObject();
        Material = argMaterial ?? new JsObject();
        Count = argCount ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.InstancedMesh({Geometry.GetJsCode()}, {Material.GetJsCode()}, {Count.GetJsCode()})";
    }
}
    
public partial class JsInstancedMesh :
    JsMesh
{
    public static implicit operator JsInstancedMesh(string jsTextCode)
    {
        return new JsInstancedMesh(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsInstancedMesh value)
    {
        return value.GetJsCode();
    }


    private readonly JsInstancedMesh _jsVariableValue;
    public JsInstancedMesh JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _instanceMatrix;
    public JsType InstanceMatrix
    {
        get => _instanceMatrix ?? throw new InvalidOperationException();
        set
        {
            if (_instanceMatrix is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.instanceMatrix = {valueCode};");
        }
    }
        
    private readonly JsType _instanceColor;
    public JsType InstanceColor
    {
        get => _instanceColor ?? throw new InvalidOperationException();
        set
        {
            if (_instanceColor is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.instanceColor = {valueCode};");
        }
    }
        
    private readonly JsType _count;
    public JsType Count
    {
        get => _count ?? throw new InvalidOperationException();
        set
        {
            if (_count is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.count = {valueCode};");
        }
    }
        
    private readonly JsBoolean _frustumCulled;
    public JsBoolean FrustumCulled
    {
        get => _frustumCulled ?? throw new InvalidOperationException();
        set
        {
            if (_frustumCulled is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.frustumCulled = {valueCode};");
        }
    }

    internal JsInstancedMesh(JsTypeConstructor jsCodeSource, JsInstancedMesh jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _instanceMatrix = $"{variableName}.instanceMatrix".AsJsTypeVariable();
        _instanceColor = $"{variableName}.instanceColor".AsJsTypeVariable();
        _count = $"{variableName}.count".AsJsTypeVariable();
        _frustumCulled = $"{variableName}.frustumCulled".AsJsBooleanVariable();
    }

    public JsInstancedMesh(JsType argGeometry = null, JsType argMaterial = null, JsType argCount = null)
        : base(new JsInstancedMeshConstructor(argGeometry, argMaterial, argCount))
    {
    }

    public JsInstancedMesh Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
    public JsType GetColorAt(JsType argIndex = null, JsType argColor = null)
    {
        return CallMethod("getColorAt", argIndex ?? new JsObject(), argColor ?? new JsObject());
    }
        
    public JsType GetMatrixAt(JsType argIndex = null, JsType argMatrix = null)
    {
        return CallMethod("getMatrixAt", argIndex ?? new JsObject(), argMatrix ?? new JsObject());
    }
        
    public JsType Raycast(JsType argRaycaster = null, JsType argIntersects = null)
    {
        return CallMethod("raycast", argRaycaster ?? new JsObject(), argIntersects ?? new JsObject());
    }
        
    public JsType SetColorAt(JsType argIndex = null, JsType argColor = null)
    {
        return CallMethod("setColorAt", argIndex ?? new JsObject(), argColor ?? new JsObject());
    }
        
    public JsType SetMatrixAt(JsType argIndex = null, JsType argMatrix = null)
    {
        return CallMethod("setMatrixAt", argIndex ?? new JsObject(), argMatrix ?? new JsObject());
    }
        
    public JsType UpdateMorphTargets()
    {
        return CallMethod("updateMorphTargets");
    }
        
    public JsType Dispose()
    {
        return CallMethod("dispose");
    }
        
        
}