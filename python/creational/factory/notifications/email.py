from notifications.base import Notification

class Email(Notification):
    def send(self, message: str) -> str:
        print(f"Email sent: {message}")
        