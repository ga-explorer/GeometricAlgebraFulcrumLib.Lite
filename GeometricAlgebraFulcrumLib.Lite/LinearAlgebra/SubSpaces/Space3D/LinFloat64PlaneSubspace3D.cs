﻿using System.Diagnostics;
using System.Runtime.CompilerServices;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;

namespace GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.SubSpaces.Space3D
{
    public sealed class LinFloat64PlaneSubspace3D :
        ILinFloat64Subspace3D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LinFloat64PlaneSubspace3D CreateFromVectors(IFloat64Vector3D vector1, IFloat64Vector3D vector2)
        {
            var u = vector1.ToUnitVector();
            var v = vector2.RejectOnUnitVector(u).ToUnitVector();

            return new LinFloat64PlaneSubspace3D(u, v);

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LinFloat64PlaneSubspace3D CreateFromUnitVectors(IFloat64Vector3D vector1, IFloat64Vector3D vector2)
        {
            return new LinFloat64PlaneSubspace3D(
                vector1.ToVector3D(),
                vector2.RejectOnUnitVector(vector1).ToUnitVector()
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LinFloat64PlaneSubspace3D CreateFromOrthogonalVectors(IFloat64Vector3D vector1, IFloat64Vector3D vector2)
        {
            return new LinFloat64PlaneSubspace3D(
                vector1.ToUnitVector(),
                vector2.ToUnitVector()
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LinFloat64PlaneSubspace3D CreateFromOrthonormalVectors(IFloat64Vector3D vector1, IFloat64Vector3D vector2)
        {
            return new LinFloat64PlaneSubspace3D(
                vector1.ToVector3D(),
                vector2.ToVector3D()
            );
        }


        public int VSpaceDimensions
            => 3;

        public int SubspaceDimensions
            => 2;

        public IEnumerable<Float64Vector3D> BasisVectors
        {
            get
            {
                yield return BasisVector1;
                yield return BasisVector2;
            }
        }

        public Float64Vector3D BasisVector1 { get; }

        public Float64Vector3D BasisVector2 { get; }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private LinFloat64PlaneSubspace3D(Float64Vector3D vector1, Float64Vector3D vector2)
        {
            Debug.Assert(
                vector1.IsNearOrthonormalWith(vector2)
            );

            BasisVector1 = vector1;
            BasisVector2 = vector2;
        }


        public bool NearContains(IFloat64Vector3D vector, double epsilon = 1E-12D)
        {
            if (vector.IsNearZero(epsilon))
                return true;

            // Project vector on subspace plane and compare with original vector

            var (xuDot, xvDot) = vector.ESp(BasisVector1, BasisVector2);

            var diffNorm = (vector - (xuDot * BasisVector1 + xvDot * BasisVector2)).ENormSquared();

            return diffNorm < epsilon;

            //var rank = Matrix<double>.Build.DenseOfColumnArrays(
            //    vector,
            //    BasisVector1,
            //    BasisVector2
            //).Rank();

            //Debug.Assert(
            //    rank is 2 or 3
            //);

            //return rank == 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool NearContains(ILinFloat64Subspace3D subspace, double epsilon = 1E-12)
        {
            return subspace.VSpaceDimensions <= VSpaceDimensions &&
                   subspace.BasisVectors.All(v => NearContains(v, epsilon));
        }

        public bool IsValid()
        {
            throw new NotImplementedException();
        }
        
        public Float64Vector3D GetVectorProjection(IFloat64Vector3D vector)
        {
            throw new NotImplementedException();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float64PlanarAngle GetVectorProjectionPolarAngle(IFloat64Vector3D vector)
        {
            var (u1Dot, u2Dot) = 
                vector.ESp(BasisVector1, BasisVector2);

            return Math.Atan2(u2Dot, u1Dot).RadiansToAngle().GetAngleInPositiveRange();
        }

        public Float64Vector3D GetVectorRejection(IFloat64Vector3D vector)
        {
            throw new NotImplementedException();
        }

    }
}