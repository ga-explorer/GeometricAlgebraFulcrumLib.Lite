using GeometricAlgebraFulcrumLib.Lite.Geometry;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space2D;

namespace GeometricAlgebraFulcrumLib.Lite.Samples;

public static class CGa4DBasicSamples
{
    public static void EncodingSamples()
    {
        // Encoding a geometric object is to convert the components of the object
        // into a multivector in CGA space.
        // Decoding the object is to convert the CGA multivector into the object
        // components.
        // Components of an object are, for example, the radius and center of a circle
        // or the weight and coordinates of a weighted point.

        var cga = CGa4D.Instance;

        var cgaScalar = cga.EncodeScalar(2.5);

        Console.WriteLine("Original Scalar: 2.5");
        Console.WriteLine($"Encoded Scalar : {cga.GetLaTeX(cgaScalar)}");
        Console.WriteLine($"Decoded Scalar : {cga.DecodeScalar(cgaScalar)}");
        Console.WriteLine();

        var cgaVector = cga.EncodeVector(-1.3, 2.8);

        Console.WriteLine("Original Vector: (-1.3)<1> + (2.8)<2>");
        Console.WriteLine($"Encoded Vector : {cga.GetLaTeX(cgaVector)}");
        Console.WriteLine($"Decoded Vector : {cga.DecodeVector(cgaVector)}");
        Console.WriteLine();

        var cgaBivector = cga.EncodeBivector(-3.4);

        Console.WriteLine("Original Bivector: (-3.4)<1,2>");
        Console.WriteLine($"Encoded Bivector : {cga.GetLaTeX(cgaBivector)}");
        Console.WriteLine($"Decoded Bivector : {cga.DecodeBivector(cgaBivector)}");
        Console.WriteLine();

        var cgaPoint = 3.7 * cga.EncodePoint(-1.3, 2.8);
        var (w1, p1) = cga.DecodeWeightedPoint(cgaPoint);
        var point = cga.DecodePoint(cgaPoint);

        Console.WriteLine("Original Point: Weight: 3.7, Position: (-1.3)<1> + (2.8)<2>");
        Console.WriteLine($"Encoded Point : {cga.GetLaTeX(cgaPoint)}");
        Console.WriteLine($"Decoded Point : {point}");
        Console.WriteLine($"Decoded Weighted Point: Weight: {w1:G10}, Position: {p1}");
        Console.WriteLine();

        var cgaSphere = 2.4 * cga.EncodeRealCircleIpns(4, -1.3, 2.8);
        var (w2, r2, c2) = cga.DecodeWeightedRealCircleIpns(cgaSphere);
        var (radius, center) = cga.DecodeRealCircleIpns(cgaSphere);

        Console.WriteLine("Original Sphere: Weight: 2.4, Radius: 4, Center: (-1.3, 2.8)");
        Console.WriteLine($"Encoded Sphere : {cga.GetLaTeX(cgaSphere)}");
        Console.WriteLine($"Decoded Sphere : Radius: {radius:G10}, Center: {center}");
        Console.WriteLine($"Decoded Weighted Sphere: Weight: {w2:G10}, Radius: {r2:G10}, Center: {c2}");
        Console.WriteLine();

        var n = Float64Vector2D.CreateUnitVector(-1.2, -3.4);
        var cgaPlane = -4.1 * cga.EncodeLineIpns(3.5, n);
        var (w3, d3, n3) = cga.DecodeWeightedLineIpns(cgaPlane);
        var (distance, normal) = cga.DecodeLineIpns(cgaPlane);

        Console.WriteLine($"Original Plane: Weight: -4.1, Distance: 3.5, Unit Normal: {n}");
        Console.WriteLine($"Encoded Plane : {cga.GetLaTeX(cgaPlane)}");
        Console.WriteLine($"Decoded Plane : Distance: {distance:G10}, Normal: {normal}");
        Console.WriteLine($"Decoded Weighted Plane: Weight: {w3:G10}, Distance: {d3}, Normal: {n3}");
        Console.WriteLine();

    }

    public static void PointsExample()
    {
        var cga = CGa4D.Instance;

        var cgaPoint1 = 
            cga.EncodePoint(-1, -1);

        var cgaPoint2 = 
            cga.EncodePoint(2, 3);

        var squaredDistance = 
            cga.GetDistance(cgaPoint1, cgaPoint2);
        
        Console.WriteLine("CGA Point 1:" + cga.GetLaTeX(cgaPoint1));
        Console.WriteLine("CGA Point 2:" + cga.GetLaTeX(cgaPoint2));
        Console.WriteLine("Squared Distance: " + squaredDistance);
        Console.WriteLine();

        var egaPoint1 = cga.DecodePoint(cgaPoint1);
        var egaPoint2 = cga.DecodePoint(cgaPoint2);
        
        Console.WriteLine("EGA Point 1:" + egaPoint1);
        Console.WriteLine("EGA Point 2:" + egaPoint2);
        Console.WriteLine();

    }

    public static void CirclesExample()
    {
        var cga = CGa4D.Instance;

        var cgaCircle1 = 
            cga.EncodeRealCircleIpns(4, Float64Vector2D.Create(-1, 2));

        var cgaLine =
            cga.EncodeLineOpns(
                Float64Vector2D.Create(-1, 1),
                Float64Vector2D.Create(1, -1)
            );

        var cgaCircle2 = 
            cga.Normalize(
                cgaLine.Gp(cgaCircle1).Gp(cgaLine).GetVectorPart()
            );

        Console.WriteLine("CGA Circle 1:" + cga.GetLaTeX(cgaCircle1));
        Console.WriteLine("CGA Line:" + cga.GetLaTeX(cgaLine));
        Console.WriteLine("CGA Circle 2:" + cga.GetLaTeX(cgaCircle2));
        Console.WriteLine();

        var (center1, radius1) = 
            cga.DecodeRealCircleIpns(cgaCircle1);
        
        var (center2, radius2) = 
            cga.DecodeRealCircleIpns(cgaCircle2);

        Console.WriteLine($"Circle 1: center = {center1}, radius = {radius1}");
        Console.WriteLine($"Circle 2: center = {center2}, radius = {radius2}");
        Console.WriteLine();
    }
}