def validator(article: dict) -> bool:
    required_keys = ["title", "author" ,"content"]
    forbidden_words = ["sucks", "idiot", "stupid"]
    

    for key in required_keys:
        if key not in article:
            print(f"The require key is missing: {key}")
            return False
    
    content = article.get("content", "")
    if any(word in content for word in forbidden_words):
        print("Forbidden words found in content.")
        return False

    title = article.get("title", "")
    if len(content) > 100 and len(title) > 10:
        print("The amount of content and title is correct.")
        return True
    
    print("Validation failed: Content or title does not meet the criteria.")
    return False