using Interface.ISuggestions;
using Interface.IArticle;

namespace Publisher.Seo
{
    public class Suggestions : ISuggestions
    {
        public List<string> Keywords { get; set; } = new List<string>();
        public List<string> MetaDescription { get; set; } = new List<string>();
        public List<string> InternalLinks { get; set; } = new List<string>();
    }
    public class Seo
    {
        public Suggestions SeoOptimizer(IArticle article)
        {
            var suggestions = new Suggestions();

            if (article.Keywords != null)
            {
                suggestions.Keywords.Add("Add relevant keywords");
            }
            else
            {
                if (article.Keywords != null && article.Keywords.Count <= 3)
                {
                    suggestions.Keywords.Add("Add at least 3 relevant keywords");
                }
            }

            if (article.MetaDescription == null)
            {
                suggestions.MetaDescription.Add("Add meta description to the article");
            }
            else
            {
                if (article.MetaDescription != null)
                {
                    if (article.MetaDescription.Count <= 100 || article.MetaDescription.Count <= 110)
                    {
                        suggestions.MetaDescription.Add("The meta description at least between 100 and 110 characters");
                    }
                }
            }

            if (article.InternalLinks != null)
            {
                if (article.InternalLinks.Count == 0)
                {
                    suggestions.InternalLinks.Add("Add at least one internal link");
                }
            }

            return suggestions;
        }
    }
}