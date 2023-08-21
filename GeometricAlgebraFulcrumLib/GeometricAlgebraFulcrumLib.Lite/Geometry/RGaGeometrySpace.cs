using System.Diagnostics;
using System.Runtime.CompilerServices;
using DataStructuresLib;
using DataStructuresLib.BitManipulation;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Basis;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.LinearMaps.Outermorphisms;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.LinearMaps.Reflectors;
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

    public RGaMetric Metric 
        => Processor;

    public abstract RGaFloat64Processor Processor { get; }

    public abstract IReadOnlyList<string> LaTeXVectorSubscripts { get; }
    
    public abstract IRGaFloat64Outermorphism LaTeXBasisMap { get; }

    public abstract IRGaFloat64Outermorphism LaTeXBasisMapInverse { get; }
    

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected RGaGeometrySpace(int vSpaceDimensions)
    {
        VSpaceDimensions = vSpaceDimensions;
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValidElement(RGaFloat64Multivector mv)
    {
        return mv.Metric.HasSameSignature(Processor) && 
               mv.VSpaceDimensions <= VSpaceDimensions;
    }


    protected string BasisBladeToLaTeX(ulong id)
    {
        Debug.Assert(id > 0 && id < GaSpaceDimensions);

        var subscriptText = 
            id
                .PatternToPositions()
                .Select(i => LaTeXVectorSubscripts[i])
                .ConcatenateText(",");

        return @$"\boldsymbol{{e}}_{{{subscriptText}}}";
    }

    protected string ScalarToLaTeX(double scalar)
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

    protected string ScalarTermToLaTeX(double scalar)
    {
        Debug.Assert(scalar != 0);

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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected string TermToLaTeX(ulong id, double scalar)
    {
        return id == 0 
            ? ScalarTermToLaTeX(scalar) 
            : $"{ScalarToLaTeX(scalar)} {BasisBladeToLaTeX(id)}";
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string ToLaTeX(double mv)
    {
        return ToLaTeX(
            (RGaFloat64Multivector) Processor.CreateScalar(mv)
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string ToLaTeX(RGaFloat64Scalar mv)
    {
        return ToLaTeX(
            (RGaFloat64Multivector) mv
        );
    }

    public string ToLaTeX(RGaFloat64Multivector mv)
    {
        if (mv.IsZero)
            return "0";
        
        var latexText =
            LaTeXBasisMap.OmMap(mv)
                .IdScalarPairs
                .OrderBy(p => p.Key.Grade())
                .ThenBy(p => p.Key)
                .Select(p => TermToLaTeX(p.Key, p.Value))
                .ConcatenateText();

        latexText = latexText[1] == '+'
            ? latexText[2..] 
            : "-" + latexText[2..];

        return latexText.Trim();
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


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Scalar ReflectOn(RGaFloat64Scalar mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectOn(subspace);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector ReflectOn(RGaFloat64Vector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectOn(subspace);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Bivector ReflectOn(RGaFloat64Bivector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectOn(subspace);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64HigherKVector ReflectOn(RGaFloat64HigherKVector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectOn(subspace);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector ReflectOn(RGaFloat64KVector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectOn(subspace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector ReflectOn(RGaFloat64Multivector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectOn(subspace);
    }
    

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Scalar ReflectOpnsOnOpns(RGaFloat64Scalar mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDirectOnDirect(subspace);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector ReflectOpnsOnOpns(RGaFloat64Vector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDirectOnDirect(subspace);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Bivector ReflectOpnsOnOpns(RGaFloat64Bivector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDirectOnDirect(subspace);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64HigherKVector ReflectOpnsOnOpns(RGaFloat64HigherKVector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDirectOnDirect(subspace);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector ReflectOpnsOnOpns(RGaFloat64KVector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDirectOnDirect(subspace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector ReflectOpnsOnOpns(RGaFloat64Multivector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDirectOnDirect(subspace);
    }
    

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Scalar ReflectOpnsOnIpns(RGaFloat64Scalar mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDirectOnDual(subspace);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector ReflectOpnsOnIpns(RGaFloat64Vector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDirectOnDual(subspace);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Bivector ReflectOpnsOnIpns(RGaFloat64Bivector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDirectOnDual(subspace);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64HigherKVector ReflectOpnsOnIpns(RGaFloat64HigherKVector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDirectOnDual(subspace);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector ReflectOpnsOnIpns(RGaFloat64KVector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDirectOnDual(subspace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector ReflectOpnsOnIpns(RGaFloat64Multivector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDirectOnDual(subspace);
    }
    

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Scalar ReflectIpnsOnOpns(RGaFloat64Scalar mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDualOnDirect(subspace, VSpaceDimensions);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector ReflectIpnsOnOpns(RGaFloat64Vector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDualOnDirect(subspace, VSpaceDimensions);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Bivector ReflectIpnsOnOpns(RGaFloat64Bivector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDualOnDirect(subspace, VSpaceDimensions);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64HigherKVector ReflectIpnsOnOpns(RGaFloat64HigherKVector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDualOnDirect(subspace, VSpaceDimensions);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector ReflectIpnsOnOpns(RGaFloat64KVector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDualOnDirect(subspace, VSpaceDimensions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector ReflectIpnsOnOpns(RGaFloat64Multivector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDualOnDirect(subspace, VSpaceDimensions);
    }
    

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Scalar ReflectIpnsOnIpns(RGaFloat64Scalar mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDualOnDual(subspace);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector ReflectIpnsOnIpns(RGaFloat64Vector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDualOnDual(subspace);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Bivector ReflectIpnsOnIpns(RGaFloat64Bivector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDualOnDual(subspace);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64HigherKVector ReflectIpnsOnIpns(RGaFloat64HigherKVector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDualOnDual(subspace);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector ReflectIpnsOnIpns(RGaFloat64KVector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDualOnDual(subspace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector ReflectIpnsOnIpns(RGaFloat64Multivector mv, RGaFloat64KVector subspace)
    {
        return mv.ReflectDualOnDual(subspace);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector Intersect(RGaFloat64KVector blade1, RGaFloat64KVector blade2)
    {
        return blade1.Op(blade2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector Intersect(RGaFloat64KVector blade1, RGaFloat64KVector blade2, RGaFloat64KVector blade3)
    {
        return blade1.Op(blade2).Op(blade3);
    }
    

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Scalar Project(RGaFloat64Scalar blade, RGaFloat64KVector subspace)
    {
        return blade
            .Fdp(subspace)
            .Gp(subspace)
            .GetScalarPart();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector Project(RGaFloat64Vector blade, RGaFloat64KVector subspace)
    {
        return blade
            .Fdp(subspace)
            .Gp(subspace)
            .GetVectorPart();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Bivector Project(RGaFloat64Bivector blade, RGaFloat64KVector subspace)
    {
        return blade
            .Fdp(subspace)
            .Gp(subspace)
            .GetBivectorPart();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64HigherKVector Project(RGaFloat64HigherKVector blade, RGaFloat64KVector subspace)
    {
        return blade
            .Fdp(subspace)
            .Gp(subspace)
            .GetHigherKVectorPart(blade.Grade);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector Project(RGaFloat64KVector blade, RGaFloat64KVector subspace)
    {
        return blade
            .Fdp(subspace)
            .Gp(subspace)
            .GetKVectorPart(blade.Grade);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector Project(RGaFloat64Multivector blade, RGaFloat64KVector subspace)
    {
        return blade
            .Fdp(subspace)
            .Gp(subspace);
    }

}