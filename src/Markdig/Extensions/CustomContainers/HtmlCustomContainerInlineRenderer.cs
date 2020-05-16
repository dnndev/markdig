// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.
using KnowBetter.Markdig.Renderers;
using KnowBetter.Markdig.Renderers.Html;

namespace KnowBetter.Markdig.Extensions.CustomContainers
{
    /// <summary>
    /// A HTML renderer for a <see cref="CustomContainerInline"/>.
    /// </summary>
    /// <seealso cref="Renderers.Html.HtmlObjectRenderer{CustomContainerInline}" />
    public class HtmlCustomContainerInlineRenderer : HtmlObjectRenderer<CustomContainerInline>
    {
        protected override void Write(HtmlRenderer renderer, CustomContainerInline obj)
        {
            renderer.Write("<span").WriteAttributes(obj).Write(">");
            renderer.WriteChildren(obj);
            renderer.Write("</span>");
        }
    }
}