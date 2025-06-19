from datetime import datetime
from typing import List

class Logger:
    _instance = None    
    _logs_list: List = []

    def __new__(cls):
        if not cls._instance:
            cls._instance = super().__new__(cls)
        return cls._instance
    
    def log(self, message: str, level: str  = "INFO"):
        dt = datetime.now().isoformat(timespec="seconds")
        log = f"{dt}: {message} - {level}"
        self._logs_list.append(log)
        print(log)

    def get_logs(self) -> List[str]:
        return self.get_logs



def main():
    log = Logger()

    log.log("Hello, this is a message", "INFO")
    log.log("Goodbye", "INFO")
    log.get_logs()

main()