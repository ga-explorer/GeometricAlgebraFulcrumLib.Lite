﻿using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using GeometricAlgebraFulcrumLib.Utilities.Web.ImageSharp.Processing.AutoCrop.Analyzers;
using GeometricAlgebraFulcrumLib.Utilities.Web.ImageSharp.Processing.AutoCrop.Models;

namespace GeometricAlgebraFulcrumLib.Utilities.Web.ImageSharp.Processing.AutoCrop;

public sealed class RgbAutoCropProcessor : AutoCropProcessor<Rgb24>
{
    private readonly ICropAnalyzer<Rgb24> _cropAnalyzer;
    private readonly IWeightAnalyzer<Rgb24> _weightAnalyzer;

    public RgbAutoCropProcessor(Configuration configuration, IAutoCropSettings settings, Image<Rgb24> source) : base(configuration, settings, source)
    {
        _cropAnalyzer = new RgbThresholdAnalyzer();
        _weightAnalyzer = new RgbWeightAnalyzer();

        CropAnalysis = _cropAnalyzer.GetAnalysis(source, settings.ColorThreshold, settings.BucketThreshold);

        if (settings.AnalyzeWeights)
            WeightAnalysis = _weightAnalyzer.GetAnalysis(source, CropAnalysis.Background);
    }
}