import { createNotification } from "./Factory";

const articleMessage: string = "Your article has been successfully published"

const notificationType : string = "EMAIL";

const notification = createNotification(notificationType)
notification.send(articleMessage)