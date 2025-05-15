from notifications.base import Notification

class Push(Notification):
    def send(self, message: str) -> str:
        print(f"Push sent: {message}")
        