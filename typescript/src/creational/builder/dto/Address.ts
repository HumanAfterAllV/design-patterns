export class Address {
    private city: string
    private country: string
    private cp: string
    private addr: string

    constructor(city: string, country: string, cp: string, addr: string) {
        this.city = city
        this.country = country
        this.cp = cp
        this.addr = addr
    }

    toString(): string {
        return `Address: ${this.addr} - ${this.city} - ${this.cp} - ${this.country}`
    }
}