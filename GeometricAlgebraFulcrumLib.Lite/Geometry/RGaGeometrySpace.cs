using System.Diagnostics;
using System.Runtime.CompilerServices;
using DataStructuresLib;
using DataStructuresLib.BitManipulation;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Basis;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.LinearMaps.Outermorphisms;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors.Composers;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Processors;
// ReSharper disable CompareOfFloatsByEqualityOperator

namespace GeometricAlgebraFulcrumLib.Lite.Geometry;

public abstract class RGaGeometrySpace
{
    public int VSpaceDimensions { get; }
    
    public ulong GaSpaceDimensions 
        => 1UL << VSpaceDimensions;

    public abstract RGaFloat64Processor Processor { get; }

    public abstract IReadOnlyList<string> LaTeXVectorSubscripts { get; }
    
    public abstract IRGaFloat64Outermorphism LaTeXBasisMap { get; }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected RGaGeometrySpace(int vSpaceDimensions)
    {
        VSpaceDimensions = vSpaceDimensions;
    }

    
    protected string GetLaTeX(ulong id)
    {
        Debug.Assert(id > 0 && id < GaSpaceDimensions);

        var subscriptText = 
            id
                .PatternToPositions()
                .Select(i => LaTeXVectorSubscripts[i])
                .ConcatenateText(",");;

        return @$"\boldsymbol{{e}}_{{{subscriptText}}}";
    }

    protected string GetLaTeX(double scalar)
    {
        Debug.Assert(scalar != 0);

        if (scalar == 1)
            return " +";

        if (scalar == -1)
            return " -";

        var scalarText = 
            Math.Abs(scalar).ToString("G8");
            
        var eIndex = 
            scalarText.IndexOf(
                'E', 
                StringComparison.InvariantCultureIgnoreCase
            );

        if (eIndex < 0)
            return scalar > 0 
                ? " + " + scalarText
                : " - " + scalarText;

        var scalarTextPart1 = 
            scalarText[..eIndex];
            
        var scalarTextPart2 = 
            scalarText[(eIndex + 1)..];

        scalarText = @$"{scalarTextPart1}\times10^{{{scalarTextPart2}}}";
        
        return scalar > 0 
            ? " + " + scalarText
            : " - " + scalarText; 
    }

    protected string GetLaTeX(ulong id, double scalar)
    {
        var scalarText = 
            GetLaTeX(scalar);

        if (id == 0)
            return scalarText;

        var basisText = 
            GetLaTeX(id);

        return $"{scalarText} {basisText}";
    }
    
    public string GetLaTeX(RGaFloat64Multivector mv)
    {
        if (mv.IsZero)
            return "0";
            
        var latexText =
            LaTeXBasisMap.OmMap(mv)
                .IdScalarPairs
                .OrderBy(p => p.Key.Grade())
                .ThenBy(p => p.Key)
                .Select(p => GetLaTeX(p.Key, p.Value))
                .ConcatenateText();

        return latexText[1] == '+'
            ? latexText[2..]
            : "-" + latexText[2..];
    }
    

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Scalar EncodeScalar(double s)
    {
        return Processor.CreateScalar(s);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public double DecodeScalar(RGaFloat64Scalar scalar)
    {
        return scalar.Scalar();
    }
}