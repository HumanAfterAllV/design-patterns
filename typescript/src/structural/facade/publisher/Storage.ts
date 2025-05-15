import { Article } from "../interfaces/IArticle";

function sleep(ms: number): Promise<void> {
    return new Promise(resolve => setTimeout(resolve, ms));
}

async function saveToDb(article: Article): Promise<void> {
    console.log(`Uploading to the database: ${article.slug}`);
    await sleep(3000);
    console.log("Completed");
}

function publishToCdn(article: Article): void {
    console.log(`Publishing in CDN: ${article.slug} with HTML content`);
    console.log(`${article.html}`);
}

export { saveToDb, publishToCdn, Article };