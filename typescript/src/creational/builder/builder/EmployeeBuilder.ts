import { Address } from "../dto/Address";
import { Phone, TYPE_PHONE } from "../dto/Phone";
import { Contact } from "../dto/Contact";
import { Employee, GENDER } from "../dto/Employee";

export class EmployeeBuilder {
    private name: string | null = null;
    private age: number | null = null;
    private gender: GENDER | null = null;
    private address: Address | null = null;
    private phones: Phone[] = [];
    private contacts: Contact[] = [];

    setName(name: string): this {
        this.name = name;
        return this;
    }

    setAge(age: number): this {
        this.age = age;
        return this;
    }

    setGender(gender: GENDER): this {
        this.gender = gender;
        return this;
    }

    setAddress(addr: string, city: string, country: string, cp: string): this {
        this.address = new Address(city, country, cp, addr);
        return this;
    }

    addPhone(phoneNumber: string, phoneType: TYPE_PHONE): this {
        this.phones.push(new Phone(phoneNumber, phoneType));
        return this;
    }

    addContact(name: string, phoneNumber: string): this {
        this.contacts.push(new Contact(name, phoneNumber));
        return this;
    }

    build(): Employee {
        if (!this.name || !this.age || !this.gender || !this.address) {
            throw new Error("Missing required fields to build Employee");
        }
        return new Employee(this.name, this.age, this.gender, this.address, this.phones, this.contacts);
    }
}