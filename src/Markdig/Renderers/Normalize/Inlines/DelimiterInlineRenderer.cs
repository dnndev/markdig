// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.
using KnowBetter.Markdig.Syntax.Inlines;

namespace KnowBetter.Markdig.Renderers.Normalize.Inlines
{
    /// <summary>
    /// A Normalize renderer for a <see cref="DelimiterInline"/>.
    /// </summary>
    /// <seealso cref="Markdig.Renderers.Normalize.NormalizeObjectRenderer{Markdig.Syntax.Inlines.DelimiterInline}" />
    public class DelimiterInlineRenderer : NormalizeObjectRenderer<DelimiterInline>
    {
        protected override void Write(NormalizeRenderer renderer, DelimiterInline obj)
        {
            renderer.Write(obj.ToLiteral());
            renderer.WriteChildren(obj);
        }
    }
}