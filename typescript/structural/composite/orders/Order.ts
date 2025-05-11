import { AbstractProduct } from "../products/Products";

export class Order {

    private orderId: number;
    private customer: string;
    private products: AbstractProduct[] = [];

    constructor(orderId: number, customer: string){
        this.orderId = orderId;
        this.customer = customer;
    }

    getPrice(): number {
        let totalPrice: number = 0.0
        for (const product of this.products){
            totalPrice += product.getPrice()
        }
        return totalPrice
    }

    addProduct(product: AbstractProduct) {
        this.products.push(product)
    }

    printOrder(){
        console.log("\n=============================================")
        console.log(`Order: ${this.orderId}`);
        console.log(`Costumer: ${this.customer}`);
        console.log("Products: \n");
        for (const product of this.products){
            console.log(`${product.getName()} \t\t\t ${Number(product.getPrice())}`)
        }
        console.log(`Total: ${Number(this.getPrice())}`)
    }

    getOrderId(): number{
        return this.orderId
    }

    setOrderId(orderId: number) {
        this.orderId = orderId
    }

    getCustomer(): string {
        return this.customer
    }

    setCustomer(customer: string) {
        this.customer = customer
    }

    getProducts(): AbstractProduct[]{
        return this.products
    }

    setProducts(products: AbstractProduct[]){
        this.products = products
    }
    
}
