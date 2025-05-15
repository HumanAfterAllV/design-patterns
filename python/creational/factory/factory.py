from notifications.base import Notification
from notifications.email import Email
from notifications.sms import SMS
from notifications.push import Push


def create_notification(type: str) -> Notification:
    type = type.lower().strip().replace(" ", "")

    if type == "email":
        return Email()
    elif type == "sms":
        return SMS()
    elif type == "push":
        return Push()
    else:
        raise ValueError("Notification type not supported")