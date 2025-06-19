from factory import create_notification

article_message = "Your article has been successfully published"

notification_type = "EMAIL"

notification = create_notification(notification_type)
notification.send(article_message)
