namespace Interface.IArticle
{
    public interface IArticle
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string? Html { get; set; }
        public string? Content { get; set; }
        public List<string> Keywords { get; set; }
        public List<string> MetaDescription { get; set; }
        public List<string> InternalLinks { get; set; }
    }
}