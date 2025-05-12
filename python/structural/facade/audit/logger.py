from datetime import datetime

def log_action(user: str, action: str):
    dt = datetime.now().isoformat(timespec="seconds")
    print(f"{dt} Attempted access by: {user} - {action}")