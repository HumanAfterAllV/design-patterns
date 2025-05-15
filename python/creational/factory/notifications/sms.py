from notifications.base import Notification

class SMS(Notification):
    def send(self, message: str) -> str:
        print(f"SMS sent: {message}")
        