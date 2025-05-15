import { Document, RealDocument } from "./Document";
import { logAccess } from "../audit/Logger";

enum USER_ROLES {
    Admin = "admin",
    Dr = "Dr.House",
    Patient = "Patient"
}

export class ProxyDocument implements Document{
    private filename: string
    private authorizedUser : Record<string, string>
    private realDocument: RealDocument | null

    constructor(filename: string, realDocument: null, authorizedUser: Record<string, string>){
        this.filename = filename
        this.authorizedUser = authorizedUser
        this.realDocument = realDocument
    }

    async display(user: string): Promise<void> {
        logAccess(user, this.filename);

        if (!Object.values(USER_ROLES).includes(user as USER_ROLES)) {
            throw new Error(`Invalid user role: ${user}`);
        }

        if (!Object.keys(this.authorizedUser).includes(user)) {
            throw new Error(`${user} does not have permission to access this document.`);
        }

        if (this.realDocument === null) {
            this.realDocument = new RealDocument(this.filename, null);
        }

        if (this.realDocument) {
            await this.realDocument.loadFromDisk(); // Esperar a que el documento se cargue
            this.realDocument.display(user);
        }
    }
}