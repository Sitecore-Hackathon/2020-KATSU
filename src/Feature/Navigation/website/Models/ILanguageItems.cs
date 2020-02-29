namespace KATSU.Feature.Navigation.Models
{
    public interface ILanguageItems : IHeaderGlassBase
    {
        string Iso { get; set; }
        string RegionalIsoCode { get; set; }
        string LanguageIdentifier { get; set; }
    }
}