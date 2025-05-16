import { Notification } from "../interface/IBase";

export class Push implements Notification {
    send(message: string): void {
        console.log(`Push sent: ${message}`)
    }
}