﻿using System.Collections;
using GeometricAlgebraFulcrumLib.Utilities.Structures.Basic;
using GeometricAlgebraFulcrumLib.Core.Modeling.Geometry.BasicShapes.Lines;
using GeometricAlgebraFulcrumLib.Core.Modeling.Geometry.BasicShapes.Lines.Immutable;
using GeometricAlgebraFulcrumLib.Core.Modeling.Graphics.Primitives.Vertices;
using GeometricAlgebraFulcrumLib.Core.Algebra.LinearAlgebra.Float64.Vectors.Space3D;

namespace GeometricAlgebraFulcrumLib.Core.Modeling.Graphics.Primitives.Lines;

public sealed class GrLineLoopGeometry3D
    : IGraphicsLineGeometry3D
{
    public static GrLineLoopGeometry3D Create(IReadOnlyList<ILinFloat64Vector3D> pointsList)
    {
        return new GrLineLoopGeometry3D(pointsList);
    }
        
    public static GrLineLoopGeometry3D Create(params ILinFloat64Vector3D[] pointsList)
    {
        return new GrLineLoopGeometry3D(pointsList);
    }

    public static GrLineLoopGeometry3D Create(IEnumerable<ILinFloat64Vector3D> pointsList)
    {
        return new GrLineLoopGeometry3D(pointsList.ToArray());
    }


    public GraphicsPrimitiveType3D PrimitiveType
        => GraphicsPrimitiveType3D.LineLoop;

    public int VertexCount 
        => _vertexPoints.Count;

    public IEnumerable<IGraphicsVertex3D> GeometryVertices
        => _vertexPoints.Select((p, i) => new GrVertex3D(i, p));

    private readonly IReadOnlyList<ILinFloat64Vector3D> _vertexPoints;
    public IEnumerable<ILinFloat64Vector3D> GeometryPoints 
        => _vertexPoints;

    public IEnumerable<int> GeometryIndices
        => Enumerable.Range(0, _vertexPoints.Count).ToArray();

    public int Count
        => _vertexPoints.Count;

    public ILineSegment3D this[int index] 
        => LineSegment3D.Create(
            _vertexPoints[index],
            _vertexPoints[(index + 1) % _vertexPoints.Count]
        );

    public IEnumerable<Pair<ILinFloat64Vector3D>> LineVertexPoints
    {
        get
        {
            for (var i = 0; i < _vertexPoints.Count - 1; i++)
                yield return new Pair<ILinFloat64Vector3D>(_vertexPoints[i], _vertexPoints[i + 1]);

            yield return new Pair<ILinFloat64Vector3D>(_vertexPoints[^1], _vertexPoints[0]);
        }
    }

    public IEnumerable<Pair<int>> LineVertexIndices
    {
        get
        {
            for (var i = 0; i < _vertexPoints.Count - 1; i++)
                yield return new Pair<int>(i, i + 1);

            yield return new Pair<int>(_vertexPoints.Count - 1, 0);
        }
    }


    private GrLineLoopGeometry3D(IReadOnlyList<ILinFloat64Vector3D> pointsList)
    {
        if (pointsList.Count < 2)
            throw new InvalidOperationException();

        _vertexPoints = pointsList;
    }

        
    public ILinFloat64Vector3D GetGeometryPoint(int index)
    {
        return _vertexPoints[index];
    }

    public IEnumerator<ILineSegment3D> GetEnumerator()
    {
        for (var i = 0; i < _vertexPoints.Count; i++)
        {
            var point1 = _vertexPoints[i];
            var point2 = _vertexPoints[(i + 1) % _vertexPoints.Count];

            yield return LineSegment3D.Create(point1, point2);
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}