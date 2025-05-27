using Interface.IArticle;
using Audit.Logger;


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
            var seo = new Seo.Seo();
            var slugger = new Slug.Slug();
            var logger = new Logger();

            if(!Validator.Validator.Validate(this.article))
            {
                Console.WriteLine("❌ Publicación cancelada: Artículo inválido");
                return;
            }

            this.article.Slug = slugger.SlugGenerator(this.article.Title);

            var suggestions = seo.SeoOptimizer(this.article);

            this.article.Html = Publisher.HTMLConverter.HTMLConverter.PlainHtml(this.article.Content ?? "");

            await Publisher.Storage.Storage.SaveToDB(this.article);
            Publisher.Storage.Storage.PublishToCDN(this.article);

            logger.LoggerAction(this.user, "publish");
        }
    }
}