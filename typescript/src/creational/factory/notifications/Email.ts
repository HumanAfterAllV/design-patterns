import { Notification } from "../interface/IBase";

export class Email implements Notification {

    send(message: string): void {
        console.log(`Email sent: ${message}`)
    }
}