// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.
using KnowBetter.Markdig.Helpers;

namespace KnowBetter.Markdig.Renderers
{
    /// <summary>
    /// A collection of <see cref="IMarkdownObjectRenderer"/>.
    /// </summary>
    /// <seealso cref="Markdig.Helpers.OrderedList{Markdig.Renderers.IMarkdownObjectRenderer}" />
    public class ObjectRendererCollection : OrderedList<IMarkdownObjectRenderer>
    {
    }
}