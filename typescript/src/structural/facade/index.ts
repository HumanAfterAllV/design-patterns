import { ArticlePublisher } from "./publisher/PublisherFacade";
import { Article } from "./interfaces/IArticle";

function main(): void {
    const article: Article = {
        title: "The Rise of AI",
        slug: "the-rise-of-ai",
        content: `# Introduction
                    Artificial Intelligence is changing the world.
                    ## Impact
                    - Healthcare
                    - Finance
                    - Education`,
        keywords: ["AI", "machine learning", "technology"],
        metaDescription: "This article explains the impact of AI across industries.",
        internalLinks: ["/ai-history", "/future-of-ai"]
    };

    const user = "Admin";

    const publisher = new ArticlePublisher(article, user);
    publisher.publish();
}

main();