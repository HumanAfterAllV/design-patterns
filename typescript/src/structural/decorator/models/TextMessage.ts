import { IMessage } from "../interfaces/IMessage";

export class TextMessage implements IMessage {
    private content: string;

    constructor(content: string){
        this.content = content
    }

    processMessage(): IMessage {
        return this
    }

    getContent(): string {
        return this.content
    }

    setContent(content: string): void {
        this.content = content
    }
}