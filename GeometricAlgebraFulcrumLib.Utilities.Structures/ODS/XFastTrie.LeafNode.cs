﻿namespace GeometricAlgebraFulcrumLib.Utilities.Structures.ODS;

partial class XFastTrie<T>
{
    internal class LeafNode : XFastNode
    {
        internal uint Key;
        internal T Value;
    }
}