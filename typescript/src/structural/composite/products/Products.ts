export abstract class AbstractProduct {
    protected name: string;
    protected price: number;

    constructor(name: string, price: number) {
        this.name = name;
        this.price = price;
    }

    abstract getName(): string;
    abstract setName(name: string): void;
    abstract getPrice(): number;
    abstract setPrice(price: number): void;
}

export class SimpleProduct extends AbstractProduct{

    private brand: string;

    constructor(name: string, price: number, brand: string) {
        super(name, price);
        this.brand = brand;
    }

    getName(): string {
        return this.name
    }
    
    setName(name: string): void {
        this.name = name
    }

    getPrice(): number {
        return this.price
    }

    setPrice(price: number): void {
        this.price = price
    }

    getBrand(): string {
        return this.brand
    }

    setBrand(brand: string): void {
        this.brand = brand
    }
}

export class CompositeProduct extends AbstractProduct {

    private products : AbstractProduct[] = [];

    constructor(name: string) {
        super(name, 0.0);
    }

    getName(): string {
        return this.name
    }

    setName(name: string): void {
        this.name = name
    }

    getPrice(): number {

        let totalPrice: number = 0.0;

        for (const product of this.products){
            totalPrice += product.getPrice()
        }

        return totalPrice
    }

    setPrice(price: number): void {
        throw new Error("Setting price is not supported for CompositeProduct")
    }

    addProduct(product: AbstractProduct) {
        this.products.push(product)
    }

    removeProduct(product: AbstractProduct) : boolean {
        
        const index = this.products.indexOf(product);

        if (index in this.products){
            this.products.splice(index, 1);
            return true
        }

        return false
    }

}
