﻿using DataStructuresLib.Basic;
using GeometricAlgebraFulcrumLib.Lite.Graphics.Structures.Vertices;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Frames.Space3D;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;
using GeometricAlgebraFulcrumLib.Lite.ScalarAlgebra;

namespace GeometricAlgebraFulcrumLib.Lite.Graphics.Primitives.Vertices;

public sealed class GrTextureVertex3D 
    : IGraphicsVertex3D
{
    public int Index { get; }
        
    public int VSpaceDimensions 
        => 3;

    public Float64Vector3D Point { get; }

    public Color Color
    {
        get => Color.Black;
        set => throw new InvalidOperationException();
    }

    public Pair<double> ParameterValue { get; set; }

    public Normal3D Normal
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

    public double Item1
        => X;

    public double Item2
        => Y;

    public double Item3
        => Z;

    public double TextureU 
        => ParameterValue.Item1;

    public bool IsValid() =>
        Point.IsValid() &&
        ParameterValue.Item1.IsValid() &&
        ParameterValue.Item2.IsValid();


    public GrTextureVertex3D(int index, ITriplet<double> point)
    {
        Index = index;
        Point = point.ToVector3D();
        ParameterValue = new Pair<double>(0, 0);
    }

    public GrTextureVertex3D(int index, ITriplet<double> point, IPair<double> textureUv)
    {
        Index = index;
        Point = point.ToVector3D();
        ParameterValue = textureUv.ToPair();
    }

    public GrTextureVertex3D(int index, IGraphicsSurfaceLocalFrame3D vertex)
    {
        Index = index;
        Point = vertex.Point;
        ParameterValue = vertex.ParameterValue;
    }

}