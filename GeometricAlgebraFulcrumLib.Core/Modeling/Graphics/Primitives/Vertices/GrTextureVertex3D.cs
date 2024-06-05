﻿using GeometricAlgebraFulcrumLib.Utilities.Structures.Basic;
using GeometricAlgebraFulcrumLib.Core.Modeling.Graphics.Structures.Vertices;
using GeometricAlgebraFulcrumLib.Core.Algebra.LinearAlgebra.Float64.Frames.Space3D;
using GeometricAlgebraFulcrumLib.Core.Algebra.LinearAlgebra.Float64.Vectors.Space3D;
using GeometricAlgebraFulcrumLib.Core.Algebra.Scalars.Float64;
using SixLabors.ImageSharp;

namespace GeometricAlgebraFulcrumLib.Core.Modeling.Graphics.Primitives.Vertices;

public sealed class GrTextureVertex3D 
    : IGraphicsVertex3D
{
    public int Index { get; }
        
    public int VSpaceDimensions 
        => 3;

    public LinFloat64Vector3D Point { get; }

    public Color Color
    {
        get => Color.Black;
        set => throw new InvalidOperationException();
    }

    public Pair<Float64Scalar> ParameterValue { get; set; }

    public LinFloat64Normal3D Normal
        => null;

    public bool HasColor 
        => false;

    public bool HasParameterValue 
        => true;

    public bool HasNormal 
        => false;

    public GraphicsVertexDataKind3D DataKind
        => GraphicsVertexDataKind3D.TextureData;

    public Float64Scalar X 
        => Point.X;

    public Float64Scalar Y 
        => Point.Y;

    public Float64Scalar Z 
        => Point.Z;

    public Float64Scalar Item1
        => X;

    public Float64Scalar Item2
        => Y;

    public Float64Scalar Item3
        => Z;

    public double TextureU 
        => ParameterValue.Item1;

    public bool IsValid() =>
        Point.IsValid() &&
        ParameterValue.Item1.IsValid() &&
        ParameterValue.Item2.IsValid();


    public GrTextureVertex3D(int index, ITriplet<Float64Scalar> point)
    {
        Index = index;
        Point = point.ToLinVector3D();
        ParameterValue = new Pair<Float64Scalar>(0, 0);
    }

    public GrTextureVertex3D(int index, ITriplet<Float64Scalar> point, IPair<Float64Scalar> textureUv)
    {
        Index = index;
        Point = point.ToLinVector3D();
        ParameterValue = textureUv.ToPair();
    }

    public GrTextureVertex3D(int index, IGraphicsSurfaceLocalFrame3D vertex)
    {
        Index = index;
        Point = vertex.Point;
        ParameterValue = vertex.ParameterValue;
    }

}