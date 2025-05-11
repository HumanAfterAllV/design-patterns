from datetime import datetime

def log_access(user: str, filename: str):
    dt = datetime.now().isoformat(timespec="seconds")
    print(f"{dt} Attempted access by: {user} - {filename}")