using System;
using Publisher.PublisherFacade;
using Interface.IArticle;

namespace Facade
{
    public class Article : IArticle
    {
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string? Content { get; set; } = string.Empty;
        public string? Html { get; set; } = string.Empty; 
        public List<string> Keywords { get; set; } = new();
        public List<string> MetaDescription { get; set; } = new(); 
        public List<string> InternalLinks { get; set; } = new();
    }

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var article = new Article
            {
                Title = "The Rise of AI",
                Slug = "the-rise-of-ai",
                Content = @"# Introduction
            Artificial Intelligence is changing the world.
            ## Impact
                - Healthcare
                - Finance
                - Education",
                Keywords = new List<string> { "AI", "machine learning", "technology" },
                MetaDescription = new List<string> { "This article explains the impact of AI across industries." }, // Ahora es lista
                InternalLinks = new List<string> { "/ai-history", "/future-of-ai" },
                Html = string.Empty 
            };

            var publisher = new ArticlePublisher(article, "Admin");
            await publisher.Publish();
        }
    }
}