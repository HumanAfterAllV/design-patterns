using Interface.IArticle;

namespace Publisher.Storage
{
    public static class StorageDB
    {
        public static async Task SaveToDB(IArticle article)
        {
            Console.WriteLine($"Uploading to the database: {article.Slug}");
            await Task.Delay(3000);
            Console.WriteLine("Completed");
        }

        public static void PublishToCDN(IArticle article)
        {
            Console.WriteLine($"Publishing in CDN: {article.Slug} with HTML content");
            Console.WriteLine($"{article.Html}");
        }
    }
}