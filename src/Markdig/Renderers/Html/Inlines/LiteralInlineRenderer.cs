// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.
using KnowBetter.Markdig.Syntax.Inlines;

namespace KnowBetter.Markdig.Renderers.Html.Inlines
{
    /// <summary>
    /// A HTML renderer for a <see cref="LiteralInline"/>.
    /// </summary>
    /// <seealso cref="Markdig.Renderers.Html.HtmlObjectRenderer{Markdig.Syntax.Inlines.LiteralInline}" />
    public class LiteralInlineRenderer : HtmlObjectRenderer<LiteralInline>
    {
        protected override void Write(HtmlRenderer renderer, LiteralInline obj)
        {
            if (renderer.EnableHtmlEscape)
            {
                renderer.WriteEscape(ref obj.Content);
            }
            else
            {
                renderer.Write(ref obj.Content);
            }
        }
    }
}
