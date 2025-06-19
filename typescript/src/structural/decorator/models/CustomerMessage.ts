import { IMessage } from "../interfaces/IMessage";

export class CustomerMessage implements IMessage {
    private name: string;
    private email: string;
    private telephone: number;

    constructor(name: string, email: string, telephone: number){
        this.name = name
        this.email = email
        this.telephone = telephone
    }

    processMessage(): IMessage {
        return this
    }

    toString(): string {
        return `Name: ${this.name} Email: ${this.email} Telephone: ${this.telephone}`
    }

    getContent(): string {
        return this.toString();
    }

    setContent(content: string): void {
        throw new Error("Not supported yet.")
    }

}