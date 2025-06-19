import time

def save_to_db(article: dict):
    print(f"Uploading to the database: {article['slug']}")
    time.sleep(3)
    print("Completed")

def publish_to_cdn(article: dict):
    print(f"Publishing in CDN: {article['slug']} with HTML content")
    print(f"{article['html']}")
