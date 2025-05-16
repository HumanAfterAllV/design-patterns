export enum TYPE_PHONE {
    MOBILE = "Mobile",
    HOME = "Home",
    WORK = "Work",
    OTHER = "Other"
}

export class Phone {
    private phone: string
    private typePhone: TYPE_PHONE

    constructor(phone: string, typePhone: TYPE_PHONE){
        this.phone = phone
        this.typePhone = typePhone
    }

    toString(): string{
        return `Phone: ${this.phone} - ${this.typePhone}`
    }
}