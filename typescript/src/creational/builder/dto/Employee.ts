import { Phone } from "./Phone";
import { Address } from "./Address";
import { Contact } from "./Contact";

export interface Builder<T> {
    build(): T; 
}

export enum GENDER {
    MALE = "Male",
    FEMALE = "Female",
    OTHER = "Other"
}

export class Employee {
    private name: string
    private age: number
    private gender: GENDER
    private address: Address
    private phones: Array<Phone>
    private contacts: Array<Contact>

    constructor(name: string, age: number, gender: GENDER, address: Address, phones: Array<Phone>, contacts: Array<Contact> ){
        this.name = name
        this.age = age
        this.gender = gender
        this.address = address
        this.phones = phones
        this.contacts = contacts
    }

    toString(): string {
        return (
            `Employee\n` +
            `Name: ${this.name}\n` +
            `Age: ${this.age}\n` +
            `Gender: ${this.gender}\n` +
            `Address: ${this.address.toString()}\n` +
            `Phones: ${this.phones.map(phone => phone.toString()).join(", ")}\n` +
            `Contacts: ${this.contacts.map(contact => contact.toString()).join(", ")}`
    );
    }

}