from publisher.publisher_facade import ArticlePublisher

def main():
    article = {
        "title": "The Rise of AI",
        "author": "Israel Galicia",
        "content": """# Introduction
Artificial Intelligence is changing the world.
## Impact
- Healthcare
- Finance
- Education
""",
        "keywords": ["AI", "machine learning", "technology"],
        "meta_description": "This article explains the impact of AI across industries.",
        "internal_links": ["/ai-history", "/future-of-ai"]
    }

    user = "Admin"

    publisher = ArticlePublisher(article, user)
    publisher.publish()

if __name__ == "__main__":
    main()
