﻿using System.Runtime.CompilerServices;
using GeometricAlgebraFulcrumLib.Algebra.Scalars.Generic;
using GeometricAlgebraFulcrumLib.Utilities.Structures.BitManipulation;

namespace GeometricAlgebraFulcrumLib.Modeling.Calculus.Functions.Generic;

public sealed class FnCos<T> :
    IScalarFunction<T>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static FnCos<T> Create(IScalarFunctionProcessor<T> functionProcessor, T magnitude, T frequency)
    {
        return new FnCos<T>(
            functionProcessor,
            magnitude,
            frequency,
            functionProcessor.ScalarProcessor.ZeroValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static FnCos<T> Create(IScalarFunctionProcessor<T> functionProcessor, T magnitude, T frequency, T phase)
    {
        return new FnCos<T>(
            functionProcessor,
            magnitude,
            frequency,
            phase
        );
    }


    public IScalarProcessor<T> ScalarProcessor
        => FunctionProcessor.ScalarProcessor;

    public IScalarFunctionProcessor<T> FunctionProcessor { get; }

    public Scalar<T> Magnitude { get; }

    public Scalar<T> Frequency { get; }

    public Scalar<T> Phase { get; }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FnCos(IScalarFunctionProcessor<T> functionProcessor, T magnitude, T frequency, T phase)
    {
        var scalarProcessor = functionProcessor.ScalarProcessor;

        FunctionProcessor = functionProcessor;
        Magnitude = magnitude.ScalarFromValue(scalarProcessor);
        Frequency = frequency.ScalarFromValue(scalarProcessor);
        Phase = phase.ScalarFromValue(scalarProcessor);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T GetValue(T t)
    {
        return (Magnitude * (Frequency * t + Phase).Cos()).ScalarValue;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T GetDerivativeValue(T t)
    {
        return (-Magnitude * Frequency * (Frequency * t + Phase).Sin()).ScalarValue;
    }

    public T GetDerivativeValue(T t, int degree)
    {
        if (degree < 0)
            throw new ArgumentOutOfRangeException(nameof(degree));

        var magnitude = degree switch
        {
            0 => Magnitude,
            1 => Magnitude * Frequency,
            2 => Magnitude * Frequency.Square(),
            3 => Magnitude * Frequency.Cube(),
            _ => Magnitude * Frequency.Power(degree)
        };

        degree %= 4;

        if (degree is 1 or 2)
            magnitude = -magnitude;

        return degree.IsEven()
            ? (magnitude * (Frequency * t + Phase).Cos()).ScalarValue
            : (magnitude * (Frequency * t + Phase).Sin()).ScalarValue;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IScalarFunction<T> GetDerivative()
    {
        return FnSin<T>.Create(
            FunctionProcessor,
            (-Magnitude * Frequency).ScalarValue,
            Frequency.ScalarValue,
            Phase.ScalarValue
        );
    }

    public IScalarFunction<T> GetDerivative(int degree)
    {
        if (degree < 0)
            throw new ArgumentOutOfRangeException(nameof(degree));

        var magnitude = degree switch
        {
            0 => Magnitude,
            1 => Magnitude * Frequency,
            2 => Magnitude * Frequency.Square(),
            3 => Magnitude * Frequency.Cube(),
            _ => Magnitude * Frequency.Power(degree)
        };

        degree %= 4;

        if (degree is 1 or 2)
            magnitude = -magnitude;

        return degree.IsEven()
            ? Create(FunctionProcessor, magnitude.ScalarValue, Frequency.ScalarValue, Phase.ScalarValue)
            : FnSin<T>.Create(FunctionProcessor, magnitude.ScalarValue, Frequency.ScalarValue, Phase.ScalarValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ScalarFunction<T> ToScalarFunction()
    {
        return ScalarFunction<T>.Create(
            FunctionProcessor,
            t => (Magnitude * (Frequency * t + Phase).Cos()).ScalarValue
        );
    }
}