using GeometricAlgebraFulcrumLib.Lite.Geometry;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;

namespace GeometricAlgebraFulcrumLib.Lite.Samples
{
    public static class CGa5DBasicSamples
    {
        public static void EncodingSamples()
        {
            // Encoding a geometric object is to convert the components of the object
            // into a multivector in CGA space.
            // Decoding the object is to convert the CGA multivector into the object
            // components.
            // Components of an object are, for example, the radius and center of a sphere
            // or the weight and coordinates of a weighted point.

            var cga = CGa5D.Instance;

            var cgaScalar = cga.EncodeScalar(2.5);

            Console.WriteLine("Original Scalar: 2.5");
            Console.WriteLine($"Encoded Scalar : {cga.GetLaTeX(cgaScalar)}");
            Console.WriteLine($"Decoded Scalar : {cga.DecodeScalar(cgaScalar)}");
            Console.WriteLine();

            var cgaVector = cga.EncodeVector(-1.3, 2.8, 1.4);

            Console.WriteLine("Original Vector: (-1.3)<1> + (2.8)<2> + (1.4)<3>");
            Console.WriteLine($"Encoded Vector : {cga.GetLaTeX(cgaVector)}");
            Console.WriteLine($"Decoded Vector : {cga.DecodeVector(cgaVector)}");
            Console.WriteLine();

            var cgaBivector = cga.EncodeBivector(-3.4, -1.4, 2.5);

            Console.WriteLine("Original Bivector: (-3.4)<1,2> + (-1.4)<1,3> + (2.5)<2,3>");
            Console.WriteLine($"Encoded Bivector : {cga.GetLaTeX(cgaBivector)}");
            Console.WriteLine($"Decoded Bivector : {cga.DecodeBivector(cgaBivector)}");
            Console.WriteLine();

            var cgaPoint = 3.7 * cga.EncodePoint(-1.3, 2.8, 1.4);
            var (w1, p1) = cga.DecodeWeightedPoint(cgaPoint);
            var point = cga.DecodePoint(cgaPoint);

            Console.WriteLine("Original Point: Weight: 3.7, Position: (-1.3)<1> + (2.8)<2> + (1.4)<3>");
            Console.WriteLine($"Encoded Point : {cga.GetLaTeX(cgaPoint)}");
            Console.WriteLine($"Decoded Point : {point}");
            Console.WriteLine($"Decoded Weighted Point: Weight: {w1:G10}, Position: {p1}");
            Console.WriteLine();

            var cgaSphere = 2.4 * cga.EncodeRealSphereIpns(4, -1.3, 2.8, 1.4);
            var (w2, r2, c2) = cga.DecodeWeightedRealSphereIpns(cgaSphere);
            var (radius, center) = cga.DecodeRealSphereIpns(cgaSphere);

            Console.WriteLine("Original Sphere: Weight: 2.4, Radius: 4, Center: (-1.3, 2.8, 1.4)");
            Console.WriteLine($"Encoded Sphere : {cga.GetLaTeX(cgaSphere)}");
            Console.WriteLine($"Decoded Sphere : Radius: {radius:G10}, Center: {center}");
            Console.WriteLine($"Decoded Weighted Sphere: Weight: {w2:G10}, Radius: {r2:G10}, Center: {c2}");
            Console.WriteLine();

            var n = Float64Vector3D.CreateUnitVector(-1.2, -3.4, 1.4);
            var cgaPlane = -4.1 * cga.EncodePlaneIpns(3.5, n);
            var (w3, d3, n3) = cga.DecodeWeightedPlaneIpns(cgaPlane);
            var (distance, normal) = cga.DecodePlaneIpns(cgaPlane);

            Console.WriteLine($"Original Plane: Weight: -4.1, Distance: 3.5, Unit Normal: {n}");
            Console.WriteLine($"Encoded Plane : {cga.GetLaTeX(cgaPlane)}");
            Console.WriteLine($"Decoded Plane : Distance: {distance:G10}, Normal: {normal}");
            Console.WriteLine($"Decoded Weighted Plane: Weight: {w3:G10}, Distance: {d3:G10}, Normal: {n3}");
            Console.WriteLine();

        }


        public static void Example1()
        {
            var cga = CGa5D.Instance;
            
            var cgaPoint = 
                cga.EncodePoint(1, 2, 3);
            
            Console.WriteLine("CGA Point (conformal basis):");
            Console.WriteLine(cga.GetLaTeX(cgaPoint));
            Console.WriteLine();


        }
    }
}
