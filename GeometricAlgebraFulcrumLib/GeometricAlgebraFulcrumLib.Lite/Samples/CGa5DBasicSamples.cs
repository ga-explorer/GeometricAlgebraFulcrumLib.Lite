using System.Diagnostics;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors;
using GeometricAlgebraFulcrumLib.Lite.Geometry.Conformal;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;

namespace GeometricAlgebraFulcrumLib.Lite.Samples
{
    public static class CGa5DBasicSamples
    {
        public static void BasisExample()
        {
            var cga = RGaConformalSpace5D.Instance;

            var cgaBasisBlades = cga.GetCGaBasisBlades();
            var pgaBasisBlades = cga.GetPGaBasisBlades();
            var cgaInfBasisBlades = cga.GetCGaInfBasisBlades();
            var egaBasisBlades = cga.GetEGaBasisBlades();

            Console.WriteLine("EGA Basis Blades:");

            foreach (var kv in egaBasisBlades) 
                Console.WriteLine(cga.ToLaTeX(kv));

            Console.WriteLine();
            
            Console.WriteLine("PGA (= CGAo) Basis Blades:");

            foreach (var kv in pgaBasisBlades)
                Console.WriteLine($"{cga.ToLaTeX(kv)} (PGA Dual = {cga.ToLaTeX(cga.PGaDual(kv))})");

            Console.WriteLine();
            
            Console.WriteLine("CGAi Basis Blades:");

            foreach (var kv in cgaInfBasisBlades) 
                Console.WriteLine(cga.ToLaTeX(kv));

            Console.WriteLine();

            Console.WriteLine("CGA Basis Blades:");

            foreach (var kv in cgaBasisBlades) 
                Console.WriteLine(cga.ToLaTeX(kv));

            Console.WriteLine();
        }

        public static void TranslationExamples()
        {
            var ga = RGaConformalSpace5D.Instance;

            var point1 = 
                ga.IpnsEncodePoint(-1.4, 2.4, 5.2);

            var point2 = ga.Translate(
                point1,
                ga.EGaEncodeVector(1, -2, -5)
            );

            Console.WriteLine($"${ga.ToLaTeX(ga.IpnsSphereToEGaCenter(point1))}$");
            Console.WriteLine($"${ga.ToLaTeX(ga.IpnsSphereToEGaCenter(point2))}$");
            Console.WriteLine();
        }

        public static void DefineDirectionsExample()
        {
            var ga = RGaConformalSpace5D.Instance;

            var d1 = ga.DefineDirection(
                2.1, 
                ga.EGaEncodeVector(1, 1.2, 3)
            );
            
            var d1Opns = d1.EncodeOpns();
            var d1Ipns = d1.EncodeIpns();
            
            Console.WriteLine("Vector Direction Example:");
            Console.WriteLine("Original Direction:");
            Console.WriteLine(d1.ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded OPNS Direction:");
            Console.WriteLine(ga.OpnsDecodeDirection(d1Opns).ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded IPNS Direction:");
            Console.WriteLine(ga.IpnsDecodeDirection(d1Ipns).ToString());
            Console.WriteLine();


            var d2 = ga.DefineDirectionFromVectors(
                1.2, 
                ga.EGaEncodeVector(1, 1.2, 3),
                ga.EGaEncodeVector(-1.1, 2.6, 1)
            );
            
            var d2Opns = d2.EncodeOpns();
            var d2Ipns = d2.EncodeIpns();
            
            Console.WriteLine("Bivector Direction Example:");
            Console.WriteLine("Original Direction:");
            Console.WriteLine(d2.ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded OPNS Direction:");
            Console.WriteLine(ga.OpnsDecodeDirection(d2Opns).ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded IPNS Direction:");
            Console.WriteLine(ga.IpnsDecodeDirection(d2Ipns).ToString());
            Console.WriteLine();

            var d2Vectors = 
                d2.GetDirectionVectors();

            var d21 = d2Vectors.Op();

            var angleCos = 
                d21.Sp(d2.Direction)
                    .Divide(d21.Norm() * d2.Direction.Norm())
                    .ScalarValue();

            Console.WriteLine("Original Direction Orthonormal Vectors:");
            var i = 0;
            foreach (var dv in d2Vectors)
            {
                Console.WriteLine($"Direction Vector {i + 1}: ${ga.ToLaTeX(dv)}$");
                i++;
            }

            Console.WriteLine($"Angle Cos: ${ga.ToLaTeX(angleCos)}$");
            Console.WriteLine();
        }

        public static void DefineFlatsExample()
        {
            var ga = RGaConformalSpace5D.Instance;
            
            var d0 = ga.DefineFlatPoint(
                2.1, 
                ga.EGaEncodeVector(2.5, 1.3, -3.6)
            );
            
            var d0Opns = d0.EncodeOpns();
            var d0Ipns = d0.EncodeIpns();
            var d0PGa = d0.EncodePGa();
            
            Debug.Assert(d0.NearContainsEGaPoint(d0.Position));
            Debug.Assert(d0.NearContainsEGaPoint(ga.OpnsDecodeFlat(d0Opns).Position));
            Debug.Assert(d0.NearContainsEGaPoint(ga.IpnsDecodeFlat(d0Ipns).Position));

            Debug.Assert(ga.OpnsDecodeFlat(d0Opns).NearContainsEGaPoint(d0.Position));
            Debug.Assert(ga.OpnsDecodeFlat(d0Opns).NearContainsEGaPoint(ga.OpnsDecodeFlat(d0Opns).Position));
            Debug.Assert(ga.OpnsDecodeFlat(d0Opns).NearContainsEGaPoint(ga.IpnsDecodeFlat(d0Ipns).Position));
            
            Debug.Assert(ga.IpnsDecodeFlat(d0Ipns).NearContainsEGaPoint(d0.Position));
            Debug.Assert(ga.IpnsDecodeFlat(d0Ipns).NearContainsEGaPoint(ga.OpnsDecodeFlat(d0Opns).Position));
            Debug.Assert(ga.IpnsDecodeFlat(d0Ipns).NearContainsEGaPoint(ga.IpnsDecodeFlat(d0Ipns).Position));

            Debug.Assert(d0.EncodeIpnsPosition().Op(d0Opns).IsNearZero());
            Debug.Assert(d0.EncodeIpnsPosition().Lcp(d0Ipns).IsNearZero());
            
            Debug.Assert(ga.OpnsDecodeFlat(d0Opns).EncodeIpnsPosition().Op(d0Opns).IsNearZero());
            Debug.Assert(ga.OpnsDecodeFlat(d0Opns).EncodeIpnsPosition().Lcp(d0Ipns).IsNearZero());
            
            Debug.Assert(ga.IpnsDecodeFlat(d0Ipns).EncodeIpnsPosition().Op(d0Opns).IsNearZero());
            Debug.Assert(ga.IpnsDecodeFlat(d0Ipns).EncodeIpnsPosition().Lcp(d0Ipns).IsNearZero());

            Console.WriteLine("Point Flat Example:");
            Console.WriteLine("Original Flat:");
            Console.WriteLine(d0.ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded OPNS Flat:");
            Console.WriteLine(ga.OpnsDecodeFlat(d0Opns).ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded IPNS Flat:");
            Console.WriteLine(ga.IpnsDecodeFlat(d0Ipns).ToString());
            Console.WriteLine();
            
            Console.WriteLine("Decoded PGA Flat:");
            Console.WriteLine(ga.PGaDecodeFlat(d0PGa).ToString());
            Console.WriteLine();

            var d1 = ga.DefineFlat(
                2.1, 
                ga.EGaEncodeVector(2.5, 1.3, -3.6),
                ga.EGaEncodeVector(1, 1.2, 3)
            );
            
            var d1Opns = d1.EncodeOpns();
            var d1Ipns = d1.EncodeIpns();
            var d1PGa = d1.EncodePGa();
            
            Debug.Assert(d1.NearContainsEGaPoint(d1.Position));
            Debug.Assert(d1.NearContainsEGaPoint(ga.OpnsDecodeFlat(d1Opns).Position));
            Debug.Assert(d1.NearContainsEGaPoint(ga.IpnsDecodeFlat(d1Ipns).Position));

            Debug.Assert(ga.OpnsDecodeFlat(d1Opns).NearContainsEGaPoint(d1.Position));
            Debug.Assert(ga.OpnsDecodeFlat(d1Opns).NearContainsEGaPoint(ga.OpnsDecodeFlat(d1Opns).Position));
            Debug.Assert(ga.OpnsDecodeFlat(d1Opns).NearContainsEGaPoint(ga.IpnsDecodeFlat(d1Ipns).Position));
            
            Debug.Assert(ga.IpnsDecodeFlat(d1Ipns).NearContainsEGaPoint(d1.Position));
            Debug.Assert(ga.IpnsDecodeFlat(d1Ipns).NearContainsEGaPoint(ga.OpnsDecodeFlat(d1Opns).Position));
            Debug.Assert(ga.IpnsDecodeFlat(d1Ipns).NearContainsEGaPoint(ga.IpnsDecodeFlat(d1Ipns).Position));

            Debug.Assert(d1.EncodeIpnsPosition().Op(d1Opns).IsNearZero());
            Debug.Assert(d1.EncodeIpnsPosition().Lcp(d1Ipns).IsNearZero());
            
            Debug.Assert(ga.OpnsDecodeFlat(d1Opns).EncodeIpnsPosition().Op(d1Opns).IsNearZero());
            Debug.Assert(ga.OpnsDecodeFlat(d1Opns).EncodeIpnsPosition().Lcp(d1Ipns).IsNearZero());
            
            Debug.Assert(ga.IpnsDecodeFlat(d1Ipns).EncodeIpnsPosition().Op(d1Opns).IsNearZero());
            Debug.Assert(ga.IpnsDecodeFlat(d1Ipns).EncodeIpnsPosition().Lcp(d1Ipns).IsNearZero());

            Console.WriteLine("Line Flat Example:");
            Console.WriteLine("Original Flat:");
            Console.WriteLine(d1.ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded OPNS Flat:");
            Console.WriteLine(ga.OpnsDecodeFlat(d1Opns).ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded IPNS Flat:");
            Console.WriteLine(ga.IpnsDecodeFlat(d1Ipns).ToString());
            Console.WriteLine();
            
            Console.WriteLine("Decoded PGA Flat:");
            Console.WriteLine(ga.PGaDecodeFlat(d1PGa).ToString());
            Console.WriteLine();


            var d2 = ga.DefineFlatFromVectors(
                1.2, 
                ga.EGaEncodeVector(2.5, 1.3, -3.6),
                ga.EGaEncodeVector(1, 1.2, 3),
                ga.EGaEncodeVector(-1.1, 2.6, 1)
            );
            
            var d2Opns = d2.EncodeOpns();
            var d2Ipns = d2.EncodeIpns();
            var d2PGa = d2.EncodePGa();
            
            Debug.Assert(d2.NearContainsEGaPoint(d2.Position));
            Debug.Assert(d2.NearContainsEGaPoint(ga.OpnsDecodeFlat(d2Opns).Position));
            Debug.Assert(d2.NearContainsEGaPoint(ga.IpnsDecodeFlat(d2Ipns).Position));

            Debug.Assert(ga.OpnsDecodeFlat(d2Opns).NearContainsEGaPoint(d2.Position));
            Debug.Assert(ga.OpnsDecodeFlat(d2Opns).NearContainsEGaPoint(ga.OpnsDecodeFlat(d2Opns).Position));
            Debug.Assert(ga.OpnsDecodeFlat(d2Opns).NearContainsEGaPoint(ga.IpnsDecodeFlat(d2Ipns).Position));
            
            Debug.Assert(ga.IpnsDecodeFlat(d2Ipns).NearContainsEGaPoint(d2.Position));
            Debug.Assert(ga.IpnsDecodeFlat(d2Ipns).NearContainsEGaPoint(ga.OpnsDecodeFlat(d2Opns).Position));
            Debug.Assert(ga.IpnsDecodeFlat(d2Ipns).NearContainsEGaPoint(ga.IpnsDecodeFlat(d2Ipns).Position));

            Debug.Assert(d2.EncodeIpnsPosition().Op(d2Opns).IsNearZero());
            Debug.Assert(d2.EncodeIpnsPosition().Lcp(d2Ipns).IsNearZero());
            
            Debug.Assert(ga.OpnsDecodeFlat(d2Opns).EncodeIpnsPosition().Op(d2Opns).IsNearZero());
            Debug.Assert(ga.OpnsDecodeFlat(d2Opns).EncodeIpnsPosition().Lcp(d2Ipns).IsNearZero());
            
            Debug.Assert(ga.IpnsDecodeFlat(d2Ipns).EncodeIpnsPosition().Op(d2Opns).IsNearZero());
            Debug.Assert(ga.IpnsDecodeFlat(d2Ipns).EncodeIpnsPosition().Lcp(d2Ipns).IsNearZero());

            var d2Points = 
                d2.GetEGaPoints();

            var d2FromPoints = ga.DefineFlatFromPoints(
                d2.Weight,
                d2Points
            );

            Console.WriteLine("Plane Flat Example:");
            Console.WriteLine("Original Flat:");
            Console.WriteLine(d2.ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded OPNS Flat:");
            Console.WriteLine(ga.OpnsDecodeFlat(d2Opns).ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded IPNS Flat:");
            Console.WriteLine(ga.IpnsDecodeFlat(d2Ipns).ToString());
            Console.WriteLine();
            
            Console.WriteLine("Decoded PGA Flat:");
            Console.WriteLine(ga.PGaDecodeFlat(d2PGa).ToString());
            Console.WriteLine();
            
            Console.WriteLine("Original Flat From Points:");
            Console.WriteLine(d2FromPoints.ToString());
            Console.WriteLine();
            
            Console.WriteLine("Original Flat Points:");

            var i = 0;
            foreach (var dv in d2Points)
            {
                Console.WriteLine($"Point {i + 1}: ${ga.ToLaTeX(dv)}$");
                i++;
            }

            Console.WriteLine();
        }

        public static void DefineTangentsExample()
        {
            var ga = RGaConformalSpace5D.Instance;
            
            var d0 = ga.DefineTangentPoint(
                2.1, 
                ga.EGaEncodeVector(2.5, 1.3, -3.6)
            );
            
            var d0Opns = d0.EncodeOpns();
            var d0Ipns = d0.EncodeIpns();
            
            Debug.Assert(d0.EncodeIpnsPosition().Op(d0Opns).IsNearZero());
            Debug.Assert(d0.EncodeIpnsPosition().Lcp(d0Ipns).IsNearZero());
            
            Debug.Assert(ga.OpnsDecodeTangent(d0Opns).EncodeIpnsPosition().Op(d0Opns).IsNearZero());
            Debug.Assert(ga.OpnsDecodeTangent(d0Opns).EncodeIpnsPosition().Lcp(d0Ipns).IsNearZero());
            
            Debug.Assert(ga.IpnsDecodeTangent(d0Ipns).EncodeIpnsPosition().Op(d0Opns).IsNearZero());
            Debug.Assert(ga.IpnsDecodeTangent(d0Ipns).EncodeIpnsPosition().Lcp(d0Ipns).IsNearZero());

            Console.WriteLine("Point Tangent Example:");
            Console.WriteLine("Original Tangent:");
            Console.WriteLine(d0.ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded OPNS Tangent:");
            Console.WriteLine(ga.OpnsDecodeTangent(d0Opns).ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded IPNS Tangent:");
            Console.WriteLine(ga.IpnsDecodeTangent(d0Ipns).ToString());
            Console.WriteLine();
            
            var d1 = ga.DefineTangent(
                2.1, 
                ga.EGaEncodeVector(2.5, 1.3, -3.6),
                ga.EGaEncodeVector(1, 1.2, 3)
            );
            
            var d1Opns = d1.EncodeOpns();
            var d1Ipns = d1.EncodeIpns();
            
            Debug.Assert(d1.EncodeIpnsPosition().Op(d1Opns).IsNearZero());
            Debug.Assert(d1.EncodeIpnsPosition().Lcp(d1Ipns).IsNearZero());
            
            Debug.Assert(ga.OpnsDecodeTangent(d1Opns).EncodeIpnsPosition().Op(d1Opns).IsNearZero());
            Debug.Assert(ga.OpnsDecodeTangent(d1Opns).EncodeIpnsPosition().Lcp(d1Ipns).IsNearZero());
            
            Debug.Assert(ga.IpnsDecodeTangent(d1Ipns).EncodeIpnsPosition().Op(d1Opns).IsNearZero());
            Debug.Assert(ga.IpnsDecodeTangent(d1Ipns).EncodeIpnsPosition().Lcp(d1Ipns).IsNearZero());

            Console.WriteLine("Line Tangent Example:");
            Console.WriteLine("Original Tangent:");
            Console.WriteLine(d1.ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded OPNS Tangent:");
            Console.WriteLine(ga.OpnsDecodeTangent(d1Opns).ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded IPNS Tangent:");
            Console.WriteLine(ga.IpnsDecodeTangent(d1Ipns).ToString());
            Console.WriteLine();
            

            var d2 = ga.DefineTangentFromVectors(
                1.2, 
                ga.EGaEncodeVector(2.5, 1.3, -3.6),
                ga.EGaEncodeVector(1, 1.2, 3),
                ga.EGaEncodeVector(-1.1, 2.6, 1)
            );
            
            var d2Opns = d2.EncodeOpns();
            var d2Ipns = d2.EncodeIpns();
            
            Debug.Assert(d2.EncodeIpnsPosition().Op(d2Opns).IsNearZero());
            Debug.Assert(d2.EncodeIpnsPosition().Lcp(d2Ipns).IsNearZero());
            
            Debug.Assert(ga.OpnsDecodeTangent(d2Opns).EncodeIpnsPosition().Op(d2Opns).IsNearZero());
            Debug.Assert(ga.OpnsDecodeTangent(d2Opns).EncodeIpnsPosition().Lcp(d2Ipns).IsNearZero());
            
            Debug.Assert(ga.IpnsDecodeTangent(d2Ipns).EncodeIpnsPosition().Op(d2Opns).IsNearZero());
            Debug.Assert(ga.IpnsDecodeTangent(d2Ipns).EncodeIpnsPosition().Lcp(d2Ipns).IsNearZero());

            var d2Vectors = 
                d2.GetDirectionVectors();

            var d2FromVectors = ga.DefineTangentFromVectors(
                d2.Weight,
                d2.Position,
                d2Vectors
            );

            Console.WriteLine("Plane Tangent Example:");
            Console.WriteLine("Original Tangent:");
            Console.WriteLine(d2.ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded OPNS Tangent:");
            Console.WriteLine(ga.OpnsDecodeTangent(d2Opns).ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded IPNS Tangent:");
            Console.WriteLine(ga.IpnsDecodeTangent(d2Ipns).ToString());
            Console.WriteLine();
            
            Console.WriteLine("Original Tangent From Vectors:");
            Console.WriteLine(d2FromVectors.ToString());
            Console.WriteLine();
            
            Console.WriteLine("Original Flat Points:");

            var i = 0;
            foreach (var dv in d2Vectors)
            {
                Console.WriteLine($"Vector {i + 1}: ${ga.ToLaTeX(dv)}$");
                i++;
            }

            Console.WriteLine();
        }
        
        public static void DefineRoundsExample()
        {
            var ga = RGaConformalSpace5D.Instance;
            
            var d0 = ga.DefineRound(
                2.1, 
                4,
                ga.EGaEncodeVector(2.5, 1.3, -3.6),
                ga.OneScalar
            );
            
            var d0Opns = d0.EncodeOpns();
            var d0Ipns = d0.EncodeIpns();
            
            //Debug.Assert(d0.NearContainsEGaPoint(d0.Position));
            //Debug.Assert(d0.NearContainsEGaPoint(ga.OpnsDecodeRound(d0Opns).Position));
            //Debug.Assert(d0.NearContainsEGaPoint(ga.IpnsDecodeRound(d0Ipns).Position));

            //Debug.Assert(ga.OpnsDecodeRound(d0Opns).NearContainsEGaPoint(d0.Position));
            //Debug.Assert(ga.OpnsDecodeRound(d0Opns).NearContainsEGaPoint(ga.OpnsDecodeRound(d0Opns).Position));
            //Debug.Assert(ga.OpnsDecodeRound(d0Opns).NearContainsEGaPoint(ga.IpnsDecodeRound(d0Ipns).Position));
            
            //Debug.Assert(ga.IpnsDecodeRound(d0Ipns).NearContainsEGaPoint(d0.Position));
            //Debug.Assert(ga.IpnsDecodeRound(d0Ipns).NearContainsEGaPoint(ga.OpnsDecodeRound(d0Opns).Position));
            //Debug.Assert(ga.IpnsDecodeRound(d0Ipns).NearContainsEGaPoint(ga.IpnsDecodeRound(d0Ipns).Position));

            //Debug.Assert(d0.EncodeIpnsPosition().Op(d0Opns).IsNearZero());
            //Debug.Assert(d0.EncodeIpnsPosition().Lcp(d0Ipns).IsNearZero());
            
            //Debug.Assert(ga.OpnsDecodeRound(d0Opns).EncodeIpnsPosition().Op(d0Opns).IsNearZero());
            //Debug.Assert(ga.OpnsDecodeRound(d0Opns).EncodeIpnsPosition().Lcp(d0Ipns).IsNearZero());
            
            //Debug.Assert(ga.IpnsDecodeRound(d0Ipns).EncodeIpnsPosition().Op(d0Opns).IsNearZero());
            //Debug.Assert(ga.IpnsDecodeRound(d0Ipns).EncodeIpnsPosition().Lcp(d0Ipns).IsNearZero());

            Console.WriteLine("Point Round Example:");
            Console.WriteLine("Original Round:");
            Console.WriteLine(d0.ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded OPNS Round:");
            Console.WriteLine(ga.OpnsDecodeRound(d0Opns).ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded IPNS Round:");
            Console.WriteLine(ga.IpnsDecodeRound(d0Ipns).ToString());
            Console.WriteLine();
            
            var d1 = ga.DefineRound(
                2.1, 
                4,
                ga.EGaEncodeVector(2.5, 1.3, -3.6),
                ga.EGaEncodeVector(1, 1.2, 3)
            );
            
            var d1Opns = d1.EncodeOpns();
            var d1Ipns = d1.EncodeIpns();
            
            //Debug.Assert(d1.NearContainsEGaPoint(d1.Position));
            //Debug.Assert(d1.NearContainsEGaPoint(ga.OpnsDecodeRound(d1Opns).Position));
            //Debug.Assert(d1.NearContainsEGaPoint(ga.IpnsDecodeRound(d1Ipns).Position));

            //Debug.Assert(ga.OpnsDecodeRound(d1Opns).NearContainsEGaPoint(d1.Position));
            //Debug.Assert(ga.OpnsDecodeRound(d1Opns).NearContainsEGaPoint(ga.OpnsDecodeRound(d1Opns).Position));
            //Debug.Assert(ga.OpnsDecodeRound(d1Opns).NearContainsEGaPoint(ga.IpnsDecodeRound(d1Ipns).Position));
            
            //Debug.Assert(ga.IpnsDecodeRound(d1Ipns).NearContainsEGaPoint(d1.Position));
            //Debug.Assert(ga.IpnsDecodeRound(d1Ipns).NearContainsEGaPoint(ga.OpnsDecodeRound(d1Opns).Position));
            //Debug.Assert(ga.IpnsDecodeRound(d1Ipns).NearContainsEGaPoint(ga.IpnsDecodeRound(d1Ipns).Position));

            //Debug.Assert(d1.EncodeIpnsPosition().Op(d1Opns).IsNearZero());
            //Debug.Assert(d1.EncodeIpnsPosition().Lcp(d1Ipns).IsNearZero());
            
            //Debug.Assert(ga.OpnsDecodeRound(d1Opns).EncodeIpnsPosition().Op(d1Opns).IsNearZero());
            //Debug.Assert(ga.OpnsDecodeRound(d1Opns).EncodeIpnsPosition().Lcp(d1Ipns).IsNearZero());
            
            //Debug.Assert(ga.IpnsDecodeRound(d1Ipns).EncodeIpnsPosition().Op(d1Opns).IsNearZero());
            //Debug.Assert(ga.IpnsDecodeRound(d1Ipns).EncodeIpnsPosition().Lcp(d1Ipns).IsNearZero());

            Console.WriteLine("Line Round Example:");
            Console.WriteLine("Original Round:");
            Console.WriteLine(d1.ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded OPNS Round:");
            Console.WriteLine(ga.OpnsDecodeRound(d1Opns).ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded IPNS Round:");
            Console.WriteLine(ga.IpnsDecodeRound(d1Ipns).ToString());
            Console.WriteLine();
            

            var d2 = ga.DefineRoundFromVectors(
                1.2, 
                4,
                ga.EGaEncodeVector(2.5, 1.3, -3.6),
                ga.EGaEncodeVector(1, 1.2, 3),
                ga.EGaEncodeVector(-1.1, 2.6, 1)
            );
            
            var d2Opns = d2.EncodeOpns();
            var d2Ipns = d2.EncodeIpns();
            
            //Debug.Assert(d2.NearContainsEGaPoint(d2.Position));
            //Debug.Assert(d2.NearContainsEGaPoint(ga.OpnsDecodeRound(d2Opns).Position));
            //Debug.Assert(d2.NearContainsEGaPoint(ga.IpnsDecodeRound(d2Ipns).Position));

            //Debug.Assert(ga.OpnsDecodeRound(d2Opns).NearContainsEGaPoint(d2.Position));
            //Debug.Assert(ga.OpnsDecodeRound(d2Opns).NearContainsEGaPoint(ga.OpnsDecodeRound(d2Opns).Position));
            //Debug.Assert(ga.OpnsDecodeRound(d2Opns).NearContainsEGaPoint(ga.IpnsDecodeRound(d2Ipns).Position));
            
            //Debug.Assert(ga.IpnsDecodeRound(d2Ipns).NearContainsEGaPoint(d2.Position));
            //Debug.Assert(ga.IpnsDecodeRound(d2Ipns).NearContainsEGaPoint(ga.OpnsDecodeRound(d2Opns).Position));
            //Debug.Assert(ga.IpnsDecodeRound(d2Ipns).NearContainsEGaPoint(ga.IpnsDecodeRound(d2Ipns).Position));

            //Debug.Assert(d2.EncodeIpnsPosition().Op(d2Opns).IsNearZero());
            //Debug.Assert(d2.EncodeIpnsPosition().Lcp(d2Ipns).IsNearZero());
            
            //Debug.Assert(ga.OpnsDecodeRound(d2Opns).EncodeIpnsPosition().Op(d2Opns).IsNearZero());
            //Debug.Assert(ga.OpnsDecodeRound(d2Opns).EncodeIpnsPosition().Lcp(d2Ipns).IsNearZero());
            
            //Debug.Assert(ga.IpnsDecodeRound(d2Ipns).EncodeIpnsPosition().Op(d2Opns).IsNearZero());
            //Debug.Assert(ga.IpnsDecodeRound(d2Ipns).EncodeIpnsPosition().Lcp(d2Ipns).IsNearZero());

            var d2Points = 
                d2.GetEGaPoints();

            var d2FromPoints = ga.DefineRoundFromPoints(
                d2.Weight,
                d2Points
            );

            Console.WriteLine("Plane Round Example:");
            Console.WriteLine("Original Round:");
            Console.WriteLine(d2.ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded OPNS Round:");
            Console.WriteLine(ga.OpnsDecodeRound(d2Opns).ToString());
            Console.WriteLine();

            Console.WriteLine("Decoded IPNS Round:");
            Console.WriteLine(ga.IpnsDecodeRound(d2Ipns).ToString());
            Console.WriteLine();
            
            Console.WriteLine("Original Round From Points:");
            Console.WriteLine(d2FromPoints.ToString());
            Console.WriteLine();
            
            Console.WriteLine("Original Round Points:");

            var i = 0;
            foreach (var dv in d2Points)
            {
                Console.WriteLine($"Point {i + 1}: ${ga.ToLaTeX(dv)}$");
                i++;
            }

            Console.WriteLine();
        }

        public static void CGaEncodingExamples()
        {
            // Encoding a geometric object is to convert the components of the object
            // into a multivector in CGA space.
            // Decoding the object is to convert the CGA multivector into the object
            // components.
            // Components of an object are, for example, the radius and center of a sphere
            // or the weight and coordinates of a weighted point.

            var cga = RGaConformalSpace5D.Instance;

            var cgaScalar = cga.EncodeScalar(2.5);

            Console.WriteLine("Original Scalar: 2.5");
            Console.WriteLine($"Encoded Scalar : {cga.ToLaTeX(cgaScalar)}");
            Console.WriteLine($"Decoded Scalar : {cga.DecodeScalar(cgaScalar)}");
            Console.WriteLine();

            var cgaVector = cga.EGaEncodeVector(-1.3, 2.8, 1.4);

            Console.WriteLine("Original Vector: (-1.3)<1> + (2.8)<2> + (1.4)<3>");
            Console.WriteLine($"Encoded Vector : {cga.ToLaTeX(cgaVector)}");
            Console.WriteLine($"Decoded Vector : {cga.EGaDecodeVector3D(cgaVector)}");
            Console.WriteLine();

            var cgaBivector = cga.EGaEncodeBivector(-3.4, -1.4, 2.5);

            Console.WriteLine("Original Bivector: (-3.4)<1,2> + (-1.4)<1,3> + (2.5)<2,3>");
            Console.WriteLine($"Encoded Bivector : {cga.ToLaTeX(cgaBivector)}");
            Console.WriteLine($"Decoded Bivector : {cga.EGaDecodeBivector3D(cgaBivector)}");
            Console.WriteLine();

            var cgaPoint = 3.7 * cga.IpnsEncodePoint(-1.3, 2.8, 1.4);
            var (w1, p1) = cga.IpnsDecodeWeightedPoint3D(cgaPoint);
            var point = cga.IpnsDecodePoint3D(cgaPoint);

            Console.WriteLine("Original Point: Weight: 3.7, Position: (-1.3)<1> + (2.8)<2> + (1.4)<3>");
            Console.WriteLine($"Encoded Point : {cga.ToLaTeX(cgaPoint)}");
            Console.WriteLine($"Decoded Point : {point}");
            Console.WriteLine($"Decoded Weighted Point: Weight: {w1:G10}, Position: {p1}");
            Console.WriteLine();

            var cgaSphere = 2.4 * cga.IpnsEncodeRealSphere(4, -1.3, 2.8, 1.4);
            var sphere = cga.IpnsDecodeSphere3D(cgaSphere);
            
            Console.WriteLine("Original Sphere: Weight: 2.4, Radius: 4, Center: (-1.3, 2.8, 1.4)");
            Console.WriteLine($"Encoded Sphere: {cga.ToLaTeX(cgaSphere)}");
            Console.WriteLine($"Decoded Sphere: Weight: {sphere.Weight:G10}, Radius: {sphere.RealRadius:G10}, Center: {sphere.Center3D}");
            Console.WriteLine();

            var n = Float64Vector3D.CreateUnitVector(-1.2, -3.4, 1.4);
            var cgaPlane = -4.1 * cga.IpnsEncodePlane(3.5, n);
            var plane = cga.IpnsDecodePlane3D(cgaPlane);

            Console.WriteLine($"Original Plane: Weight: -4.1, Distance: 3.5, Unit Normal: {n}");
            Console.WriteLine($"Encoded Plane : {cga.ToLaTeX(cgaPlane)}");
            Console.WriteLine($"Decoded Weighted Plane: Weight: {plane.Weight:G10}, Distance: {plane.OriginToHyperPlaneDistance:G10}, Normal: {plane.NormalDirectionVector3D}");
            Console.WriteLine();

            var cgaLine = cga.IpnsEncodeLine(
                Float64Vector3D.Create(-1.2, -3.4, 1.4),
                Float64Vector3D.Create(-1, 1, 1)
            );

            Console.WriteLine($"Original Line: Weight: 1, Point: (-1.2, -3.4, 1.4), Direction: (-1, 1, 1)");
            Console.WriteLine($"Encoded Line : {cga.ToLaTeX(cgaLine)}");
            //Console.WriteLine($"Decoded Plane : Distance: {distance:G10}, Normal: {normal}");
            //Console.WriteLine($"Decoded Weighted Plane: Weight: {w3:G10}, Distance: {d3:G10}, Normal: {n3}");
            Console.WriteLine();
        }

        public static void SphereExample()
        {
            var ga = RGaConformalSpace5D.Instance;

            // Create 4 position vectors (points)
            var p1 = Float64Vector3D.Create(0.5, 0, -1.5);
            var p2 = Float64Vector3D.Create(1, 0, 0);
            var p3 = Float64Vector3D.Create(0, 1, 0);
            var p4 = Float64Vector3D.Create(0, 0, -1);

            // Encode the real sphere passing through the 4 points as a
            // OPNS blade
            var opnsSphere1 = 
                ga.OpnsEncodeSphere(p1, p2, p3, p4);

            // Convert the OPNS blade into IPNS vector
            var ipnsSphere1 = 
                ga.OpnsToIpns(opnsSphere1).GetVectorPart();

            // Decode the sphere parameters of the IPNS
            var sphere1 = 
                ga.IpnsDecodeSphere3D(ipnsSphere1);

            Console.WriteLine($"OPNS Sphere: {ga.ToLaTeX(opnsSphere1)}");
            Console.WriteLine($"IPNS Sphere: {ga.ToLaTeX(ipnsSphere1)}");
            Console.WriteLine($"     Weight: {sphere1.Weight}");
            Console.WriteLine($"     Radius: {sphere1.RealRadius}");
            Console.WriteLine($"     Center: {sphere1.Center3D}");
            Console.WriteLine();

            Console.WriteLine($"  Distance1: {sphere1.Center3D.GetDistanceToPoint(p1)}");
            Console.WriteLine($"  Distance2: {sphere1.Center3D.GetDistanceToPoint(p2)}");
            Console.WriteLine($"  Distance3: {sphere1.Center3D.GetDistanceToPoint(p3)}");
            Console.WriteLine($"  Distance3: {sphere1.Center3D.GetDistanceToPoint(p4)}");
            Console.WriteLine();
        }
        
        public static void PGaExamples()
        {
            var cga = RGaConformalSpace5D.Instance;

            var io = cga.EoIe;
            var ii = cga.IeEi;
            var ios = cga.MusicalIsomorphism.OmMap(io);
            var iis = cga.MusicalIsomorphism.OmMap(ii);
            
            Console.WriteLine($"Io123 = {cga.ToLaTeX(io)}");
            Console.WriteLine($"I123i = {cga.ToLaTeX(ii)}");
            Console.WriteLine($"#[Io123] = {cga.ToLaTeX(ios)}");
            Console.WriteLine($"#[I123i] = {cga.ToLaTeX(iis)}");
            Console.WriteLine();


        }

        public static void CGaPGaExample()
        {
            var ga = RGaConformalSpace5D.Instance;

            // Create 4 3D position vectors (points)
            var p = Float64Vector3D.Create(0.5, 0, -1.5);
            var p1 = Float64Vector3D.Create(1, 0, 0);
            var p2 = Float64Vector3D.Create(0, 1, 0);
            var p3 = Float64Vector3D.Create(0, 0, -1);

            // Encode a point as a PGA blade
            var pgaPoint = ga.PGaEncodePoint(p);
            
            // Encode a line passing through two points as a PGA blade
            var pgaLine = 
                ga.PGaEncodeLineFromPoints(p, p2);

            // Encode a plane passing through three points as a PGA blade
            var pgaPlane = 
                ga.PGaEncodePlaneFromPoints(p1, p2, p3);
            
            // Encode a real sphere as an IPNS CGA vector
            var ipnsSphere = 
                ga.IpnsEncodeRealSphere(0.25, 1, 0.5, 0);

            // PGA Intersection of line and plane
            var pgaLinePlaneIntersection = 
                ga.PGaDecodePoint3D(ga.Intersect(pgaLine, pgaPlane));
            
            // PGA Projection of point on plane
            var pgaPointOnPlaneProjection =
                ga.Project(pgaPoint, pgaPlane);

            // CGA Intersection of plane and sphere
            var ipnsSpherePlaneIntersection =
                ga.IntersectCGaPGa(ipnsSphere, pgaPlane);

            // CGA Projection of line on sphere
            var ipnsLineOnSphereProjection =
                ga.ProjectPGaOnCGa(pgaLine, ipnsSphere);
            
            Console.WriteLine($"PGA Point : ${ga.ToLaTeX(pgaPoint)}$");
            Console.WriteLine($"PGA Line  : ${ga.ToLaTeX(pgaLine)}$");
            Console.WriteLine($"PGA Plane : ${ga.ToLaTeX(pgaPlane)}$");
            Console.WriteLine($"CGA Sphere: ${ga.ToLaTeX(ipnsSphere)}$");
            Console.WriteLine();

            Console.WriteLine($"PGA Line-Plane intersection  : ${ga.ToLaTeX(pgaLinePlaneIntersection)}$");
            Console.WriteLine($"PGA Point on Plane projection: ${ga.ToLaTeX(pgaPointOnPlaneProjection)}$");
            Console.WriteLine($"CGA Plane-Sphere intersection: ${ga.ToLaTeX(ipnsSpherePlaneIntersection)}$");
            Console.WriteLine($"CGA Line on Sphere projection: ${ga.ToLaTeX(ipnsLineOnSphereProjection)}$");
            Console.WriteLine();
        }

        public static void VisualizationExample1()
        {
            var ga = RGaConformalSpace5D.Instance;

            var ipnsSphere1 =
                ga.IpnsEncodeRealSphere(
                    3, 
                    Float64Vector3D.Create(1, 1, 2)
                );

            var ipnsSphere1Points =
                ga.IpnsDecodeRound(ipnsSphere1).GetIpnsPoints();

            var ipnsSphere2 =
                ga.IpnsEncodeRealSphere(
                    2, 
                    Float64Vector3D.Create(-2, 1, 2)
                );

            var ipnsCircle = 
                ga.Intersect(ipnsSphere1, ipnsSphere2).GetBivectorPart();

            var scene = 
                ga.CreateVisualizer();

            scene
                .BeginDrawing()
                .SetDefaultThickness(0.15)
                .SetSurfaceStyle(Color.Beige.WithAlpha(0.2f))
                .DrawIpnsSphere(ipnsSphere1)
                .DrawIpnsPoints(ipnsSphere1Points)
                .SetSurfaceStyle(Color.GreenYellow.WithAlpha(0.2f))
                .DrawIpnsSphere(ipnsSphere2)
                .SetCurveStyle(Color.Red, 0.03)
                .DrawIpnsCircle(ipnsCircle)
                .GenerateHtml(@"D:\VisualizationExample1");

        }

    }
}
