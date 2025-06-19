using Interface.IArticle;
using Audit.Logger;
using Publisher.Seo;
using Publisher.Slug;
using Publisher.Storage;


namespace Publisher.PublisherFacade
{
    public class ArticlePublisher
    {
        private IArticle article;
        private string user;

        public ArticlePublisher(IArticle article, string user)
        {
            this.article = article;
            this.user = user;
        }

        public async Task Publish()
        {
            var seo = new SeoSuggestions();
            var slugger = new Slugger();
            var logger = new Logger();

            if(!Validator.Validator.Validate(article))
            {
                Console.WriteLine("❌ Publicación cancelada: Artículo inválido");
                return;
            }

            article.Slug = slugger.SlugGenerator(article.Title);
            _ = seo.SeoOptimizer(article);

            article.Html = HTMLConverter.HTMLConverter.PlainHtml(article.Content ?? "");

            await StorageDB.SaveToDB(article);
            StorageDB.PublishToCDN(article);

            logger.LoggerAction(user, "publish");
        }
    }
}