﻿namespace GeometricAlgebraFulcrumLib.Utilities.Structures.Basic;

public interface IUInt64IndexedValue<out T>
{
    public ulong Index { get; }

    public T Value { get; }
}