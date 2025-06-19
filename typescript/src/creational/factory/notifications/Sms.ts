import { Notification } from "../interface/IBase";

export class SMS implements Notification {
    send(message: string): void {
        console.log(`SMS sent: ${message}`)
    }
}