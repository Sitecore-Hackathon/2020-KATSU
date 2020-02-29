namespace KATSU.Feature.PageContent.Models
{
    public interface IRichTextEditor : IRichTextEditorGlassBase
    {
        string Content { get; set; }
    }
}