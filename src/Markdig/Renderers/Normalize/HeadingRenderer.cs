// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.
using System.Globalization;
using KnowBetter.Markdig.Syntax;

namespace KnowBetter.Markdig.Renderers.Normalize
{
    /// <summary>
    /// An Normalize renderer for a <see cref="HeadingBlock"/>.
    /// </summary>
    /// <seealso cref="Markdig.Renderers.Normalize.NormalizeObjectRenderer{Markdig.Syntax.HeadingBlock}" />
    public class HeadingRenderer : NormalizeObjectRenderer<HeadingBlock>
    {
        private static readonly string[] HeadingTexts = {
            "#",
            "##",
            "###",
            "####",
            "#####",
            "######",
        };

        protected override void Write(NormalizeRenderer renderer, HeadingBlock obj)
        {
            var headingText = obj.Level > 0 && obj.Level <= 6
                ? HeadingTexts[obj.Level - 1]
                : new string('#', obj.Level);

            renderer.Write(headingText).Write(' ');
            renderer.WriteLeafInline(obj);

            renderer.FinishBlock(renderer.Options.EmptyLineAfterHeading);
        }
    }
}