from publisher.validator import validator
from publisher.slug_generator import slug_generator
from publisher.seo_optimIzer import seo_optimizer
from publisher.html_converter import plain_to_html
from publisher.storage import publish_to_cdn, save_to_db
from audit.logger import log_action

class ArticlePublisher():
    def __init__(self, article: dict, user: str):
        self.article = article
        self.user = user

    def publish(self):
        validator(self.article)
        self.article["slug"] = slug_generator(self.article["title"])
        seo_optimizer(self.article)
        self.article["html"] = plain_to_html(self.article["content"])
        save_to_db(self.article)
        publish_to_cdn(self.article)
        log_action(self.user, "publish")



        



        