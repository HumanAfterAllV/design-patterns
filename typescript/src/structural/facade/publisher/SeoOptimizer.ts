import { Article, Suggestions } from "../interfaces/IArticle";

export function seoOptimizer(article: Article): Suggestions {
    const suggestions: Suggestions = {
        keywords: [],
        metaDescription: [],
        internalLinks: [],
    }

    if (!article.keywords){
        suggestions.keywords.push("Add relevant keywords")
    }
    else{
        if (article.keywords && article.keywords.length <= 3){
            suggestions.keywords.push("Add at least 3 relevant keywords")
        }
    }

    if (!article.metaDescription){
        suggestions.metaDescription.push("Add meta description to the article")
    }
    else{
        if (article.metaDescription && article.metaDescription.length <= 100 || article.metaDescription.length <= 110){
            suggestions.metaDescription.push("The meta description at least between 100 and 110 characters")
        }
    }

    if (!article.internalLinks || article.internalLinks.length == 0){
        suggestions.internalLinks.push("Add at least one internal link")
    }

    return suggestions
}