using KnowBetter.Markdig.Renderers;
using KnowBetter.Markdig.Renderers.Normalize;
using KnowBetter.Markdig.Syntax;
using KnowBetter.Markdig.Syntax.Inlines;

namespace KnowBetter.Markdig.Extensions.AutoLinks
{
    public class NormalizeAutoLinkRenderer : NormalizeObjectRenderer<LinkInline>
    {
        public override bool Accept(RendererBase renderer, MarkdownObject obj)
        {
            if (base.Accept(renderer, obj))
            {
                var normalizeRenderer = renderer as NormalizeRenderer;
                var link = obj as LinkInline;

                return normalizeRenderer != null && link != null && !normalizeRenderer.Options.ExpandAutoLinks && link.IsAutoLink;
            }
            else
            {
                return false;
            }
        }
        protected override void Write(NormalizeRenderer renderer, LinkInline obj)
        {
            renderer.Write(obj.Url);
        }
    }
}
