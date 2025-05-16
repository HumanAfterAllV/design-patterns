export class Contact {
    private name: string
    private phone: string

    constructor(name: string, phone: string) {
        this.name = name
        this.phone = phone
    }

    toString(): string {
        return `Contact: ${this.name} - ${this.phone}`
    }
}