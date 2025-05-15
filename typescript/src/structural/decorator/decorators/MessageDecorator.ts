import { IMessage } from "../interfaces/IMessage";

export class MessageDecorator implements IMessage{
    protected message: IMessage

    constructor(message: IMessage){
        this.message = message
    }

    processMessage(): IMessage {
        return this.message.processMessage()
    }

    getContent(): string {
        return this.message.getContent()
    }

    setContent(content: string): void {
        this.message.setContent(content)
    }


}