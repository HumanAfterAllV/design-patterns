export interface IMessage {
    processMessage(): IMessage;
    getContent(): string;
    setContent(content: string): void;
}