using Interface.IArticle;

namespace Publisher.Validator
{
    public static class Validator
    {
        public static bool Validate(IArticle article)
        {
            string[] forbiddenWords = { "sucks", "idiot", "stupid" };
            string[] requireKeys = { "title", "author", "content" };
            string content = article.Content ?? "";
            string title = article.Title ?? "";

            foreach (var key in requireKeys)
            {
                if (string.IsNullOrEmpty(key))
                {
                    Console.WriteLine($"The require key is missing: {key}");
                    return false;
                }
            }

            if (forbiddenWords.Any(word => content.Contains(word)))
            {
                Console.WriteLine("Forbidden words found in content");
            }

            if (content.Length <= 200 && title.Length <= 10)
            {
                Console.WriteLine("The amount of content and title is correct");
                return false;
            }

            Console.WriteLine("Validation passed: Article is valid");
            return true;
        }
    }
}