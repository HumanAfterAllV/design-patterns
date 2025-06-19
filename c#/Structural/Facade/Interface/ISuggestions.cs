namespace Interface.ISuggestions
{
    public interface ISuggestions
    {
        List<string> Keywords { get; set; }
        List<string> MetaDescription { get; set; }
        List<string> InternalLinks { get; set; }
    }
}