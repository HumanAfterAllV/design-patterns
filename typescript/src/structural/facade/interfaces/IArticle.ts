export interface Article {
    title: string
    slug: string;
    html?: string;
    content?: string;
    keywords?: string[];
    internalLinks: string[];
    metaDescription: string;
}

export interface Suggestions {
    keywords: string[];
    metaDescription: string[];
    internalLinks: string[];
}
