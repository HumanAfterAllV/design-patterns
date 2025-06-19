import { Article } from "../interfaces/IArticle";
import { validator } from "./Validator";
import { slugGenerator } from "./SlugGenerator";
import { seoOptimizer } from "./SeoOptimizer";
import { plainToHtml } from "./HtmlConverter";
import { saveToDb } from "./Storage";
import { loggerAction } from "../audit/Logger";

export class ArticlePublisher {
    private article: Article;
    private user: string;

    constructor(article: Article, user: string){
        this.article = article
        this.user = user
    }

    public publish(): void {
        validator(this.article);
        this.article.slug = slugGenerator(this.article.title);
        seoOptimizer(this.article);
        this.article.html = plainToHtml(this.article.content || "");
        saveToDb(this.article);
        loggerAction(this.user, "publish");
    }
}