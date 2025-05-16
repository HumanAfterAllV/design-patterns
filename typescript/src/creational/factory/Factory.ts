import { Notification } from "./interface/IBase"; 
import { Email } from "./notifications/Email";
import { Push } from "./notifications/Push";
import { SMS } from "./notifications/Sms";

export function createNotification(type: string): Notification{
    type = type.toLowerCase().trim().replace(/\s+/g, "");

    if (type == "email"){
        return new Email()
    }
    else if(type == "sms"){
        return new SMS()
    }
    else if(type == "push"){
        return new Push()
    }
    else{
        throw new Error("Notification type not supported.")
    }

} 