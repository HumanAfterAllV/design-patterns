import { Article } from "../interfaces/IArticle";


export function validator(article: Article): boolean{

    const requireKeys: string[] = ["title", "author", "content"]
    const forbiddenWords: string[] = ["sucks", "idiot", "stupid"]

    for (const key in requireKeys){
        if (!(key in article)){
            console.log(`The require key us missing: ${key}`)
            return false
        }
    }

    const content: string = article.content || "";
    if (forbiddenWords.some(word => content.includes(word))){
        console.log("Forbidden words found in content")
        return false
    }

    const title : string = article.title || "";
    if (content.length <= 200 && title.length <= 10){
        console.log("The amount of content and title is correct.")
        return false
    }

    console.log("Validation passed: Article is valid.")
    return true

}