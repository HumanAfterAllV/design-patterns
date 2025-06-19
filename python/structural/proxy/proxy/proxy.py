from proxy.document import RealDocument, Document
from audit.logger import log_access
from users.roles import USER_ROLES
from typing import Dict

class ProxyDocument(Document):
    def __init__(self, filename: str, authorized_user: Dict[str, str]):
        self.filename = filename
        self.authorized_user = authorized_user
        self.real_document = None

    def display(self, user: str):
        log_access(user, self.filename)

        if user not in USER_ROLES:
            raise PermissionError(f"Access denied for user: {user}")
        
        role = USER_ROLES[user]

        if role not in self.authorized_user:
            raise PermissionError(f"{user} without permission: {role} ")
        
        if self.real_document is None:
            self.real_document = RealDocument(self.filename)
            
        self.real_document.display(user)