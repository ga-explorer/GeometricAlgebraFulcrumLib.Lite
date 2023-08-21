using System.Runtime.CompilerServices;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors.Composers;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;
using GeometricAlgebraFulcrumLib.Lite.ScalarAlgebra;

// ReSharper disable CompareOfFloatsByEqualityOperator

// ReSharper disable CheckNamespace

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Conformal
{
    /// <summary>
    /// Conformal Geometric Algebra for 3D Euclidean Space
    /// </summary>
    public sealed class RGaConformalSpace5D :
        RGaConformalSpace
    {
        public static RGaConformalSpace5D Instance { get; } = new RGaConformalSpace5D();


        public RGaFloat64Vector E3 { get; }

        public RGaFloat64Bivector E13 { get; }

        public RGaFloat64Bivector E23 { get; }


        private RGaConformalSpace5D() : base(5)
        {
            E3 = ConformalProcessor.CreateTermVector(4);

            E13 = ConformalProcessor.CreateTermBivector(2, 4);
            E23 = ConformalProcessor.CreateTermBivector(3, 4);
        }


        public RGaConformalVisualizer3D CreateVisualizer()
        {
            return new RGaConformalVisualizer3D(this);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector EGaEncodeVector(double x, double y, double z)
        {
            return ConformalProcessor.CreateVector(0, 0, x, y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector EGaEncodeVector(Float64Vector3D mv)
        {
            return ConformalProcessor.CreateVector(0, 0, mv.X, mv.Y, mv.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Bivector EGaEncodeBivector(double xy, double xz, double yz)
        {
            return ConformalProcessor
                .CreateComposer()
                .SetBivectorTerm(2, 3, xy)
                .SetBivectorTerm(2, 4, xz)
                .SetBivectorTerm(3, 4, yz)
                .GetBivector();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Bivector EGaEncodeBivector(Float64Bivector3D bivector)
        {
            return ConformalProcessor
                .CreateComposer()
                .SetBivectorTerm(2, 3, bivector.Xy)
                .SetBivectorTerm(2, 4, bivector.Xz)
                .SetBivectorTerm(3, 4, bivector.Yz)
                .GetBivector();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector EGaEncodeTrivector(double xyzScalar)
        {
            return xyzScalar * Ie;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector PGaEncodePoint(double pointX, double pointY, double pointZ)
        {
            return PGaEncodePoint(
                EGaEncodeVector(pointX, pointY, pointZ)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector PGaEncodePoint(Float64Vector3D point)
        {
            return PGaEncodePoint(
                EGaEncodeVector(point)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector PGaEncodeLineFromPoints(Float64Vector3D point1, Float64Vector3D point2)
        {
            return PGaEncodeLineFromPoints(
                EGaEncodeVector(point1),
                EGaEncodeVector(point2)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector PGaEncodePlaneFromPoints(Float64Vector3D point1, Float64Vector3D point2, Float64Vector3D point3)
        {
            return PGaEncodePlaneFromPoints(
                EGaEncodeVector(point1),
                EGaEncodeVector(point2),
                EGaEncodeVector(point3)
            );
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector IpnsEncodePoint(double pointX, double pointY, double pointZ)
        {
            return IpnsEncodePoint(
                EGaEncodeVector(pointX, pointY, pointZ)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector IpnsEncodePoint(Float64Vector3D point)
        {
            return IpnsEncodePoint(
                EGaEncodeVector(point)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Bivector IpnsEncodeLine(Float64Vector3D point, Float64Vector3D vector)
        {
            return IpnsEncodeLine(
                EGaEncodeVector(point),
                EGaEncodeVector(vector)
            ).GetBivectorPart();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Bivector IpnsEncodeLineFromPoints(Float64Vector3D point1, Float64Vector3D point2)
        {
            return IpnsEncodeLine(
                EGaEncodeVector(point1),
                EGaEncodeVector(point2 - point1)
            ).GetBivectorPart();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector IpnsEncodePlane(double distance, double normalX, double normalY, double normalZ)
        {
            return IpnsEncodeHyperPlane(
                distance, 
                EGaEncodeVector(normalX, normalY, normalZ)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector IpnsEncodePlane(double distance, Float64Vector3D normal)
        {
            return IpnsEncodeHyperPlane(
                distance, 
                EGaEncodeVector(normal)
            );
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector IpnsEncodeSphere(double radiusSquared, double centerX, double centerY, double centerZ)
        {
            return IpnsEncodeSphere(
                radiusSquared, 
                EGaEncodeVector(centerX, centerY, centerZ)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector IpnsEncodeSphere(double radiusSquared, Float64Vector3D center)
        {
            return IpnsEncodeSphere(
                radiusSquared, 
                EGaEncodeVector(center)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector IpnsEncodeRealSphere(double radius, double centerX, double centerY, double centerZ)
        {
            return IpnsEncodeRealSphere(
                radius, 
                EGaEncodeVector(centerX, centerY, centerZ)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector IpnsEncodeRealSphere(double radius, Float64Vector3D center)
        {
            return IpnsEncodeRealSphere(
                radius, 
                EGaEncodeVector(center)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector IpnsEncodeImaginarySphere(double radius, double centerX, double centerY, double centerZ)
        {
            return IpnsEncodeImaginarySphere(
                radius, 
                EGaEncodeVector(centerX, centerY, centerZ)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector IpnsEncodeImaginarySphere(double radius, Float64Vector3D center)
        {
            return IpnsEncodeImaginarySphere(
                radius, 
                EGaEncodeVector(center)
            );
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector OpnsEncodeFlatPoint(double pointX, double pointY, double pointZ)
        {
            return OpnsEncodeFlatPoint(
                EGaEncodeVector(pointX, pointY, pointZ)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector OpnsEncodeFlatPoint(Float64Vector3D egaPoint)
        {
            return OpnsEncodeFlatPoint(
                EGaEncodeVector(egaPoint)
            );
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector OpnsEncodeLine(Float64Vector3D egaPoint, Float64Vector3D egaVector)
        {
            return OpnsEncodeLineFromPoints(
                EGaEncodeVector(egaPoint),
                EGaEncodeVector(egaPoint + egaVector)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector OpnsEncodeLineFromPoints(Float64Vector3D egaPoint1, Float64Vector3D egaPoint2)
        {
            return OpnsEncodeLineFromPoints(
                EGaEncodeVector(egaPoint1),
                EGaEncodeVector(egaPoint2)
            );
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector OpnsEncodePlane(Float64Vector3D egaPoint, Float64Vector3D egaVector1, Float64Vector3D egaVector2)
        {
            return OpnsEncodeFlatFromPoints(
                EGaEncodeVector(egaPoint),
                EGaEncodeVector(egaPoint + egaVector1),
                EGaEncodeVector(egaPoint + egaVector2)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector OpnsEncodePlaneFromPoints(Float64Vector3D egaPoint1, Float64Vector3D egaPoint2, Float64Vector3D egaPoint3)
        {
            return OpnsEncodeFlatFromPoints(
                EGaEncodeVector(egaPoint1),
                EGaEncodeVector(egaPoint2),
                EGaEncodeVector(egaPoint3)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Bivector OpnsEncodePointPair(Float64Vector3D egaPoint1, Float64Vector3D egaPoint2)
        {
            return OpnsEncodePointPair(
                EGaEncodeVector(egaPoint1),
                EGaEncodeVector(egaPoint2)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector OpnsEncodeCircle(Float64Vector3D egaPoint1, Float64Vector3D egaPoint2, Float64Vector3D egaPoint3)
        {
            return OpnsEncodeCircle(
                EGaEncodeVector(egaPoint1),
                EGaEncodeVector(egaPoint2),
                EGaEncodeVector(egaPoint3)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector OpnsEncodeSphere(Float64Vector3D egaPoint1, Float64Vector3D egaPoint2, Float64Vector3D egaPoint3, Float64Vector3D egaPoint4)
        {
            return OpnsEncodeRound(
                EGaEncodeVector(egaPoint1),
                EGaEncodeVector(egaPoint2),
                EGaEncodeVector(egaPoint3),
                EGaEncodeVector(egaPoint4)
            );
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Multivector EncodeRotation(Float64PlanarAngle angle, double bivectorXy, double bivectorXz, double bivectorYz)
        {
            var scalar = Math.Cos(angle / 2);
            var bivectorNorm = (bivectorXy * bivectorXy + bivectorXz * bivectorXz + bivectorYz * bivectorYz).Sqrt();
            var bivectorScalar = Math.Sin(angle / 2) / bivectorNorm;

            return Processor
                .CreateComposer()
                .SetScalarTerm(scalar)
                .SetBivectorTerm(2, 3, bivectorScalar * bivectorXy)
                .SetBivectorTerm(2, 4, bivectorScalar * bivectorXz)
                .SetBivectorTerm(3, 4, bivectorScalar * bivectorYz)
                .GetSimpleMultivector();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Multivector EncodeRotation(Float64PlanarAngle angle, Float64Bivector3D bivector)
        {
            var scalar = Math.Cos(angle / 2);
            var bivectorScalar = Math.Sin(angle / 2) / bivector.Norm();

            return Processor
                .CreateComposer()
                .SetScalarTerm(scalar)
                .SetBivectorTerm(2, 3, bivectorScalar * bivector.Xy)
                .SetBivectorTerm(2, 4, bivectorScalar * bivector.Xz)
                .SetBivectorTerm(3, 4, bivectorScalar * bivector.Yz)
                .GetSimpleMultivector();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Multivector EncodeRotation(Float64PlanarAngle angle, Float64Vector3D egaAxisPoint1, Float64Vector3D egaAxisPoint2)
        {
            var bivector = CGaUnDual(
                OpnsEncodeLineFromPoints(egaAxisPoint1, egaAxisPoint2)
            ).GetBivectorPart();

            return EncodeRotation(angle, bivector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Multivector EncodeTranslation(double vectorX, double vectorY, double vectorZ)
        {
            return EncodeTranslation(
                EGaEncodeVector(vectorX, vectorY, vectorZ)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Multivector EncodeTranslation(Float64Vector3D vector)
        {
            return EncodeTranslation(
                EGaEncodeVector(vector)
            );
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float64Vector3D EGaDecodeVector3D(RGaFloat64Vector vector)
        {
            return Float64Vector3D.Create(
                vector[2],
                vector[3],
                vector[4]
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float64Bivector3D EGaDecodeBivector3D(RGaFloat64Bivector bivector)
        {
            return Float64Bivector3D.Create(
                bivector[2, 3],
                bivector[2, 4],
                bivector[3, 4]
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float64Trivector3D EGaDecodeTrivector3D(RGaFloat64KVector trivector)
        {
            return Float64Trivector3D.Create(
                trivector[2, 3, 4]
            );
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float64Vector3D PGaDecodePoint3D(RGaFloat64KVector pgaPoint)
        {
            var hgaPoint =
                PGaDual(pgaPoint);

            //Debug.Assert(IsValidHGaPoint(hgaPoint));

            return Float64Vector3D.Create(
                hgaPoint[2],
                hgaPoint[3],
                hgaPoint[4]
            );
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float64Vector3D IpnsDecodePoint3D(RGaFloat64Vector vector)
        {
            var eoScalar = vector[0] + vector[1];

            if (eoScalar.IsNearZero())
                throw new InvalidOperationException();

            return Float64Vector3D.Create(
                vector[2] / eoScalar,
                vector[3] / eoScalar,
                vector[4] / eoScalar
            );
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Tuple<double, Float64Vector3D> IpnsDecodeWeightedPoint3D(RGaFloat64Vector vector)
        {
            var weight = vector[0] + vector[1];

            if (weight.IsNearZero())
                throw new InvalidOperationException();

            var egaPoint = Float64Vector3D.Create(
                vector[2] / weight,
                vector[3] / weight,
                vector[4] / weight
            );

            return new Tuple<double, Float64Vector3D>(weight, egaPoint);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaConformalRound IpnsDecodeSphere3D(RGaFloat64Vector vector)
        {
            return IpnsDecodeHyperSphere(vector);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaConformalFlat IpnsDecodePlane3D(RGaFloat64Vector vector)
        {
            return IpnsDecodeHyperPlane(
                vector, 
                ZeroVector
            );

            //var normal = EGaDecodeVector3D(vector);
            //var normalNorm = normal.Norm();
            //var distance = 0.5 * (vector[0] - vector[1]) / normalNorm;

            //return new Tuple<double, Float64Vector3D>(
            //    distance,
            //    normal / normalNorm
            //);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaConformalFlat IpnsDecodePlane3D(RGaFloat64Vector vector, Float64Vector3D egaProbePoint)
        {
            return IpnsDecodeHyperPlane(
                vector,
                EGaEncodeVector(egaProbePoint)
            );

            //var normal = EGaDecodeVector3D(vector);
            //var normalNorm = normal.Norm();
            //var distance = 0.5 * (vector[0] - vector[1]) / normalNorm;

            //return new Tuple<double, Float64Vector3D>(
            //    distance,
            //    normal / normalNorm
            //);
        }
        
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public Tuple<double, double, Float64Vector3D> IpnsDecodeWeightedPlane3D(RGaFloat64Vector vector)
        //{
        //    var normal = EGaDecodeVector3D(vector);
        //    var normalNorm = normal.Norm();
        //    var distance = 0.5 * (vector[0] - vector[1]) / normalNorm;

        //    return new Tuple<double, double, Float64Vector3D>(
        //        normalNorm,
        //        distance,
        //        normal / normalNorm
        //    );
        //}


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Scalar Translate(RGaFloat64Scalar mv, Float64Vector3D egaTranslationVector)
        {
            return Translate(mv, EGaEncodeVector(egaTranslationVector));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Scalar Translate(RGaFloat64Scalar mv, double egaTranslationVectorX, double egaTranslationVectorY, double egaTranslationVectorZ)
        {
            return Translate(
                mv,
                EGaEncodeVector(
                    egaTranslationVectorX,
                    egaTranslationVectorY,
                    egaTranslationVectorZ
                )
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector Translate(RGaFloat64Vector mv, Float64Vector3D egaTranslationVector)
        {
            return Translate(mv, EGaEncodeVector(egaTranslationVector));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector Translate(RGaFloat64Vector mv, double egaTranslationVectorX, double egaTranslationVectorY, double egaTranslationVectorZ)
        {
            return Translate(
                mv,
                EGaEncodeVector(
                    egaTranslationVectorX,
                    egaTranslationVectorY,
                    egaTranslationVectorZ
                )
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Bivector Translate(RGaFloat64Bivector mv, Float64Vector3D egaTranslationVector)
        {
            return Translate(mv, EGaEncodeVector(egaTranslationVector));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Bivector Translate(RGaFloat64Bivector mv, double egaTranslationVectorX, double egaTranslationVectorY, double egaTranslationVectorZ)
        {
            return Translate(
                mv,
                EGaEncodeVector(
                    egaTranslationVectorX,
                    egaTranslationVectorY,
                    egaTranslationVectorZ
                )
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64HigherKVector Translate(RGaFloat64HigherKVector mv, Float64Vector3D egaTranslationVector)
        {
            return Translate(mv, EGaEncodeVector(egaTranslationVector));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64HigherKVector Translate(RGaFloat64HigherKVector mv, double egaTranslationVectorX, double egaTranslationVectorY, double egaTranslationVectorZ)
        {
            return Translate(
                mv,
                EGaEncodeVector(
                    egaTranslationVectorX,
                    egaTranslationVectorY,
                    egaTranslationVectorZ
                )
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector Translate(RGaFloat64KVector mv, Float64Vector3D egaTranslationVector)
        {
            return Translate(mv, EGaEncodeVector(egaTranslationVector));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector Translate(RGaFloat64KVector mv, double egaTranslationVectorX, double egaTranslationVectorY, double egaTranslationVectorZ)
        {
            return Translate(
                mv,
                EGaEncodeVector(
                    egaTranslationVectorX,
                    egaTranslationVectorY,
                    egaTranslationVectorZ
                )
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Multivector Translate(RGaFloat64Multivector mv, Float64Vector3D egaTranslationVector)
        {
            return Translate(mv, EGaEncodeVector(egaTranslationVector));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Multivector Translate(RGaFloat64Multivector mv, double egaTranslationVectorX, double egaTranslationVectorY, double egaTranslationVectorZ)
        {
            return Translate(
                mv,
                EGaEncodeVector(
                    egaTranslationVectorX,
                    egaTranslationVectorY,
                    egaTranslationVectorZ
                )
            );
        }



        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToLaTeX(Float64Vector3D vector)
        {
            return ToLaTeX(
                EGaEncodeVector(vector)
            );
        }
    }
}
