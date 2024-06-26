﻿using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.GraphViz.Dot.Color;
using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.GraphViz.Dot.Image;
using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.GraphViz.Dot.Label;
using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.GraphViz.Dot.Label.Text;
using GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.GraphViz.Dot.Value;
using GeometricAlgebraFulcrumLib.Utilities.Text;

namespace GeometricAlgebraFulcrumLib.Modeling.Graphics.Rendering.GraphViz.Dot;

/// <summary>
/// This class represents a GraphViz node in the AST
/// See  http://www.graphviz.org/content/dot-language 
/// and http://www.graphviz.org/content/attrs for more details
/// </summary>
public sealed class DotNode : IDotStatement
{
    internal readonly Dictionary<string, string> AttrValues 
        = new Dictionary<string, string>();


    public IDotGraph ParentGraph { get; }

    /// <summary>
    /// The name of this node
    /// </summary>
    public string NodeName { get; }

    public DotGraph MainGraph => ParentGraph.MainGraph;

    /// <summary>
    /// True if this node contain attributes
    /// </summary>
    public bool HasAttributes => AttrValues.Count > 0;

    /// <summary>
    /// True if this is an actual node not a node defauls statement
    /// </summary>
    public bool IsNode => String.IsNullOrEmpty(NodeName) == false;

    /// <summary>
    /// True if this is a node defaults statement not an actual node
    /// </summary>
    public bool IsNodeDefaults => String.IsNullOrEmpty(NodeName);

    #region Attribute Accessors
    public string Url
    {
        get => AttrValues.GetAttribute("URL");
        set => AttrValues.SetAttribute("URL", value);
    }

    public string Area
    {
        get => AttrValues.GetAttribute("area");
        set => AttrValues.SetAttribute("area", value);
    }

    public string Color
    {
        get => AttrValues.GetAttribute("color");
        set => AttrValues.SetAttribute("color", value);
    }

    public string ColorScheme
    {
        get => AttrValues.GetAttribute("colorscheme");
        set => AttrValues.SetAttribute("colorscheme", value);
    }

    public string Comment
    {
        get => AttrValues.GetAttribute("comment");
        set => AttrValues.SetAttribute("comment", value);
    }

    public string Distortion
    {
        get => AttrValues.GetAttribute("distortion");
        set => AttrValues.SetAttribute("distortion", value);
    }

    public string FillColor
    {
        get => AttrValues.GetAttribute("fillcolor");
        set => AttrValues.SetAttribute("fillcolor", value);
    }

    public string FixedSize
    {
        get => AttrValues.GetAttribute("fixedsize");
        set => AttrValues.SetAttribute("fixedsize", value);
    }

    public string FontColor
    {
        get => AttrValues.GetAttribute("fontcolor");
        set => AttrValues.SetAttribute("fontcolor", value);
    }

    public string FontName
    {
        get => AttrValues.GetAttribute("fontname");
        set => AttrValues.SetAttribute("fontname", value);
    }

    public string FontSize
    {
        get => AttrValues.GetAttribute("fontsize");
        set => AttrValues.SetAttribute("fontsize", value);
    }

    public string GradientAngle
    {
        get => AttrValues.GetAttribute("gradientangle");
        set => AttrValues.SetAttribute("gradientangle", value);
    }

    public string Group
    {
        get => AttrValues.GetAttribute("group");
        set => AttrValues.SetAttribute("group", value);
    }

    public string Height
    {
        get => AttrValues.GetAttribute("height");
        set => AttrValues.SetAttribute("height", value);
    }

    public string HRef
    {
        get => AttrValues.GetAttribute("href");
        set => AttrValues.SetAttribute("href", value);
    }

    public string Id
    {
        get => AttrValues.GetAttribute("id");
        set => AttrValues.SetAttribute("id", value);
    }

    public string Image
    {
        get => AttrValues.GetAttribute("image");
        set => AttrValues.SetAttribute("image", value);
    }

    public string ImageScale
    {
        get => AttrValues.GetAttribute("imagescale");
        set => AttrValues.SetAttribute("imagescale", value);
    }

    public string TeXLabel
    {
        get => AttrValues.GetAttribute("texlbl");
        set => AttrValues.SetAttribute("texlbl", value);
    }

    public string Label
    {
        get => AttrValues.GetAttribute("label");
        set => AttrValues.SetAttribute("label", value);
    }

    public string LabelLocation
    {
        get => AttrValues.GetAttribute("labelloc");
        set => AttrValues.SetAttribute("labelloc", value);
    }

    public string Layer
    {
        get => AttrValues.GetAttribute("layer");
        set => AttrValues.SetAttribute("layer", value);
    }

    public string Margin
    {
        get => AttrValues.GetAttribute("margin");
        set => AttrValues.SetAttribute("margin", value);
    }

    public string NoJustify
    {
        get => AttrValues.GetAttribute("nojustify");
        set => AttrValues.SetAttribute("nojustify", value);
    }

    public string Ordering
    {
        get => AttrValues.GetAttribute("ordering");
        set => AttrValues.SetAttribute("ordering", value);
    }

    public string Orientation
    {
        get => AttrValues.GetAttribute("orientation");
        set => AttrValues.SetAttribute("orientation", value);
    }

    public string PenWidth
    {
        get => AttrValues.GetAttribute("penwidth");
        set => AttrValues.SetAttribute("penwidth", value);
    }

    public string Peripheries
    {
        get => AttrValues.GetAttribute("peripheries");
        set => AttrValues.SetAttribute("peripheries", value);
    }

    public string Pin
    {
        get => AttrValues.GetAttribute("pin");
        set => AttrValues.SetAttribute("pin", value);
    }

    public string Pos
    {
        get => AttrValues.GetAttribute("pos");
        set => AttrValues.SetAttribute("pos", value);
    }

    public string Rects
    {
        get => AttrValues.GetAttribute("rects");
        set => AttrValues.SetAttribute("rects", value);
    }

    public string Regular
    {
        get => AttrValues.GetAttribute("regular");
        set => AttrValues.SetAttribute("regular", value);
    }

    public string Root
    {
        get => AttrValues.GetAttribute("root");
        set => AttrValues.SetAttribute("root", value);
    }

    public string SamplePoints
    {
        get => AttrValues.GetAttribute("samplepoints");
        set => AttrValues.SetAttribute("samplepoints", value);
    }

    public string Shape
    {
        get => AttrValues.GetAttribute("shape");
        set => AttrValues.SetAttribute("shape", value);
    }

    public string ShapeFile
    {
        get => AttrValues.GetAttribute("shapefile");
        set => AttrValues.SetAttribute("shapefile", value);
    }

    public string ShowBoxes
    {
        get => AttrValues.GetAttribute("showboxes");
        set => AttrValues.SetAttribute("showboxes", value);
    }

    public string Sides
    {
        get => AttrValues.GetAttribute("sides");
        set => AttrValues.SetAttribute("sides", value);
    }

    public string Skew
    {
        get => AttrValues.GetAttribute("skew");
        set => AttrValues.SetAttribute("skew", value);
    }

    public string SortVertical
    {
        get => AttrValues.GetAttribute("sortv");
        set => AttrValues.SetAttribute("sortv", value);
    }

    public string Style
    {
        get => AttrValues.GetAttribute("style");
        set => AttrValues.SetAttribute("style", value);
    }

    public string Target
    {
        get => AttrValues.GetAttribute("target");
        set => AttrValues.SetAttribute("target", value);
    }

    public string ToolTip
    {
        get => AttrValues.GetAttribute("tooltip");
        set => AttrValues.SetAttribute("tooltip", value);
    }

    public string Vertices
    {
        get => AttrValues.GetAttribute("vertices");
        set => AttrValues.SetAttribute("vertices", value);
    }

    public string Width
    {
        get => AttrValues.GetAttribute("width");
        set => AttrValues.SetAttribute("width", value);
    }

    public string ExternalLabel
    {
        get => AttrValues.GetAttribute("xlabel");
        set => AttrValues.SetAttribute("xlabel", value);
    }

    public string ExternalLabelPosition
    {
        get => AttrValues.GetAttribute("xlp");
        set => AttrValues.SetAttribute("xlp", value);
    }




    public DotNode SetUrl(DotHtmlString value)
    {
        AttrValues.SetAttribute("URL", value.QuotedValue);

        return this;
    }

    public DotNode SetArea(float value)
    {
        AttrValues.SetAttribute("area", value);

        return this;
    }

    public DotNode SetColor(DotColor value)
    {
        AttrValues.SetAttribute("color", value.QuotedValue);

        return this;
    }

    public DotNode SetColor(DotColorList value)
    {
        AttrValues.SetAttribute("color", value.QuotedValue);

        return this;
    }

    public DotNode SetColorScheme(DotColorScheme value)
    {
        AttrValues.SetAttribute("colorscheme", value.QuotedValue);

        return this;
    }

    public DotNode SetComment(string value)
    {
        AttrValues.SetAttribute("comment", value.ValueToQuotedLiteral());

        return this;
    }

    public DotNode SetDistortion(float value)
    {
        AttrValues.SetAttribute("distortion", value);

        return this;
    }

    public DotNode SetFillColor(DotColor value)
    {
        AttrValues.SetAttribute("fillcolor", value.QuotedValue);

        return this;
    }

    public DotNode SetFillColor(DotColorList value)
    {
        AttrValues.SetAttribute("fillcolor", value.QuotedValue);

        return this;
    }

    public DotNode SetFixedSize(bool value)
    {
        AttrValues.SetAttribute("fixedsize", value);

        return this;
    }

    public DotNode SetFixedSizeShape()
    {
        AttrValues.SetAttribute("fixedsize", "shape");

        return this;
    }

    public DotNode SetFontColor(DotColor value)
    {
        AttrValues.SetAttribute("fontcolor", value.QuotedValue);

        return this;
    }

    public DotNode SetFontName(string value)
    {
        AttrValues.SetAttribute("fontname", value.DoubleQuote());

        return this;
    }

    public DotNode SetFontSize(float value)
    {
        AttrValues.SetAttribute("fontsize", value);

        return this;
    }

    public DotNode SetGradientAngle(int value)
    {
        AttrValues.SetAttribute("gradientangle", value);

        return this;
    }

    public DotNode SetGroup(string value)
    {
        AttrValues.SetAttribute("group", value.ValueToQuotedLiteral());

        return this;
    }

    public DotNode SetHeight(float value)
    {
        AttrValues.SetAttribute("height", value);

        return this;
    }

    public DotNode SetHRef(string value)
    {
        AttrValues.SetAttribute("href", value.ValueToQuotedLiteral());

        return this;
    }

    public DotNode SetId(DotHtmlString value)
    {
        AttrValues.SetAttribute("id", value.QuotedValue);

        return this;
    }

    public DotNode SetLaTeXImage(string imageId, string latexMath)
    {
        var image = MainGraph.SetLaTeXImage(imageId, latexMath);

        AttrValues.SetAttribute(
            "image", 
            image.ImageFileName.ValueToQuotedLiteral()
        );

        return this;
    }

    public DotNode SetLaTeXImage(string latexMath)
    {
        var imageId = NodeName;
        var image = MainGraph.SetLaTeXImage(imageId, latexMath);

        AttrValues.SetAttribute(
            "image", 
            image.ImageFileName.ValueToQuotedLiteral()
        );

        return this;
    }

    public DotNode SetLaTeXImage(DotGraphLaTeXImage image)
    {
        AttrValues.SetAttribute(
            "image", 
            image.ImageFileName.ValueToQuotedLiteral()
        );

        return this;
    }

    public DotNode SetImage(string value)
    {
        AttrValues.SetAttribute("image", value.ValueToQuotedLiteral());

        return this;
    }

    public DotNode SetImageScale(bool value)
    {
        AttrValues.SetAttribute("image", value);

        return this;
    }

    public DotNode SetImageScale(DotNodeImageScale value)
    {
        AttrValues.SetAttribute("image", value.Value);

        return this;
    }

    public DotNode SetTeXLabel(string value)
    {
        AttrValues.SetAttribute("texlbl", value.ValueToQuotedLiteral());

        return this;
    }

    public DotNode SetLabel(string value)
    {
        AttrValues.SetAttribute("label", value.ValueToQuotedLiteral());

        return this;
    }

    public DotNode SetLabel(IDotHtmlLabel value)
    {
        AttrValues.SetAttribute("label", value.TaggedValue);

        return this;
    }

    public DotNode SetLabelVerticalLocation(DotVerticalLocation value)
    {
        AttrValues.SetAttribute("labelloc", value.Value);

        return this;
    }

    public DotNode SetLayer(string value)
    {
        AttrValues.SetAttribute("layer", value.ValueToQuotedLiteral());

        return this;
    }

    public DotNode SetMargin(float value)
    {
        AttrValues.SetAttribute("margin", value);

        return this;
    }

    public DotNode SetMargin(float x, float y)
    {
        AttrValues.SetAttribute("margin", DotUtils.ToDotPoint(x, y));

        return this;
    }

    public DotNode SetNoJustify(bool value)
    {
        AttrValues.SetAttribute("nojustify", value);

        return this;
    }

    public DotNode SetOrdering(DotOrdering value)
    {
        AttrValues.SetAttribute("ordering", value.QuotedValue);

        return this;
    }

    public DotNode SetOrientation(float value)
    {
        AttrValues.SetAttribute("orientation", value);

        return this;
    }

    public DotNode SetPenWidth(float value)
    {
        AttrValues.SetAttribute("penwidth", value);

        return this;
    }

    public DotNode SetPeripheries(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value));

        AttrValues.SetAttribute("peripheries", value);

        return this;
    }

    public DotNode SetPin(bool value)
    {
        AttrValues.SetAttribute("pin", value);

        return this;
    }

    public DotNode SetPosition(float x, float y)
    {
        AttrValues.SetAttribute("pos", DotUtils.ToDotPoint(x, y));

        return this;
    }

    public DotNode SetPosition(float x, float y, float z)
    {
        AttrValues.SetAttribute("pos", DotUtils.ToDotPoint(x, y, z));

        return this;
    }

    public DotNode SetPosition(string value)
    {
        AttrValues.SetAttribute("pos", value.ValueToQuotedLiteral());

        return this;
    }

    public DotNode SetRectangleSides(float x1, float y1, float x2, float y2)
    {
        AttrValues.SetAttribute("rects", DotUtils.ToDotRect(x1, y1, x2, y2));

        return this;
    }

    public DotNode SetRegular(bool value)
    {
        AttrValues.SetAttribute("regular", value);

        return this;
    }

    public DotNode SetRoot(bool value)
    {
        AttrValues.SetAttribute("root", value);

        return this;
    }

    public DotNode SetSamplePoints(int value)
    {
        AttrValues.SetAttribute("samplepoints", value);

        return this;
    }

    public DotNode SetShape(DotNodeShape value)
    {
        AttrValues.SetAttribute("shape", value.Value);

        return this;
    }

    public DotNode SetShapeFile(string value)
    {
        AttrValues.SetAttribute("shapefile", value.ValueToQuotedLiteral());

        return this;
    }

    public DotNode SetShowBoxes(int value)
    {
        AttrValues.SetAttribute("showboxes", value);

        return this;
    }

    public DotNode SetSides(int value)
    {
        AttrValues.SetAttribute("sides", value);

        return this;
    }

    public DotNode SetSkew(float value)
    {
        AttrValues.SetAttribute("skew", value);

        return this;
    }

    public DotNode SetSortValue(int value)
    {
        AttrValues.SetAttribute("sortv", value);

        return this;
    }

    public DotNode SetStyle(DotNodeStyle value)
    {
        AttrValues.SetAttribute("style", value.QuotedValue);

        return this;
    }

    public DotNode SetStyle(params DotNodeStyle[] values)
    {
        AttrValues.SetAttribute("style", values.ToDotStyle());

        return this;
    }

    public DotNode SetTarget(DotHtmlString value)
    {
        AttrValues.SetAttribute("target", value.QuotedValue);

        return this;
    }

    public DotNode SetToolTip(DotHtmlString value)
    {
        AttrValues.SetAttribute("tooltip", value.QuotedValue);

        return this;
    }

    public DotNode SetVertices(string value)
    {
        AttrValues.SetAttribute("vertices", value.DoubleQuote());

        return this;
    }

    public DotNode SetExternalLabel(string value)
    {
        AttrValues.SetAttribute("xlabel", value.ValueToQuotedLiteral());

        return this;
    }

    public DotNode SetExternalLabel(IDotHtmlLabel value)
    {
        AttrValues.SetAttribute("xlabel", value.TaggedValue);

        return this;
    }

    public DotNode SetExternalLabelPosition(float x, float y)
    {
        AttrValues.SetAttribute("xlp", DotUtils.ToDotPoint(x, y));

        return this;
    }

    public DotNode SetExternalLabelPosition(float x, float y, float z)
    {
        AttrValues.SetAttribute("xlp", DotUtils.ToDotPoint(x, y, z));

        return this;
    }

    public DotNode SetWidth(float value)
    {
        AttrValues.SetAttribute("width", value);

        return this;
    }
    #endregion


    internal DotNode(IDotGraph parentGraph, string name)
    {
        NodeName = name;
        ParentGraph = parentGraph;
    }
}