def seo_optimizer(article: dict) -> dict:
    suggestions = {}
    
    if "keywords" not in article:
        suggestions["keywords"] = "Add relevant keywords"
    else:
        if len(article["keywords"]) < 3:
            suggestions["keywords"] = "Add at least 3 relevant keywords"

    if "meta_description" not in article:
        suggestions["meta_descriptions"] = "Add a meta description to the article"
    else:
        if len(article["meta_description"]) > 100 or len(article["meta_description"]) > 110:
            suggestions["meta_descriptions"] = "The meta description at least between 100 and 110 characters"
    
    if "internal_links" not in article or len(article["internal_links"]) == 0:
        suggestions["internal_links"] = "Add at least one internal link"

    return suggestions