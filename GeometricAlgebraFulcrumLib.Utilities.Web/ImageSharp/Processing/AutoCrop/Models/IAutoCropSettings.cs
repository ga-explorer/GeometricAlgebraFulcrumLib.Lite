﻿namespace GeometricAlgebraFulcrumLib.Utilities.Web.ImageSharp.Processing.AutoCrop.Models;

public interface IAutoCropSettings
{
    int PadX { get; }
    int PadY { get; }
    int? ColorThreshold { get; }
    float? BucketThreshold { get; }
    PadMode PadMode { get; }
    bool AnalyzeWeights { get; }
}