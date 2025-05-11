import { SimpleProduct, CompositeProduct } from "./products/Products";
import { Order } from "./orders/Order";

class CompositeMain {
    private ram4gb: SimpleProduct | null = null;
    private ram8gb: SimpleProduct | null = null;
    private disk500gb: SimpleProduct | null = null;
    private disk1tb: SimpleProduct | null = null;
    private cpuAMD: SimpleProduct | null = null;
    private cpuIntel: SimpleProduct | null = null;
    private smallCabinete: SimpleProduct | null = null;
    private bigCabinete: SimpleProduct | null = null;
    private monitor20inch: SimpleProduct | null = null;
    private monitor30inch: SimpleProduct | null = null;
    private simpleMouse: SimpleProduct | null = null;
    private gammerMouse: SimpleProduct | null = null;

    private gammerPC: CompositeProduct | null = null;
    private homePC: CompositeProduct | null = null;
    private pc2x1: CompositeProduct | null = null;
 
    buildProducts(): void {
        // Simple product construction
        this.ram4gb = new SimpleProduct("RAM 4GB", 750, "KingStone");
        this.ram8gb = new SimpleProduct("RAM 8GB", 1000, "KingStone");
        this.disk500gb = new SimpleProduct("HDD 500GB", 1500, "ACME");
        this.disk1tb = new SimpleProduct("HDD 1TB", 2000, "ACME");
        this.cpuAMD = new SimpleProduct("AMD phenon", 4000, "AMD");
        this.cpuIntel = new SimpleProduct("Intel i7", 4500, "Intel");
        this.smallCabinete = new SimpleProduct("Small cabinet", 2000, "ExCom");
        this.bigCabinete = new SimpleProduct("Big Cabinet", 2200, "ExCom");
        this.monitor20inch = new SimpleProduct("Display 20'", 1500, "HP");
        this.monitor30inch = new SimpleProduct("Display 30'", 2000, "HP");
        this.simpleMouse = new SimpleProduct("Simple mouse", 150, "Genius");
        this.gammerMouse = new SimpleProduct("Gammer mouse", 750, "Alien");

        // Gammer PC
        this.gammerPC = new CompositeProduct("Gammer PC");
        this.gammerPC.addProduct(this.ram8gb!);
        this.gammerPC.addProduct(this.disk1tb!);
        this.gammerPC.addProduct(this.cpuIntel!);
        this.gammerPC.addProduct(this.bigCabinete!);
        this.gammerPC.addProduct(this.monitor30inch!);
        this.gammerPC.addProduct(this.gammerMouse!);

        // Home PC
        this.homePC = new CompositeProduct("Home PC");
        this.homePC.addProduct(this.ram4gb!);
        this.homePC.addProduct(this.disk500gb!);
        this.homePC.addProduct(this.cpuAMD!);
        this.homePC.addProduct(this.smallCabinete!);
        this.homePC.addProduct(this.monitor20inch!);
        this.homePC.addProduct(this.simpleMouse!);

        // Combo PC
        this.pc2x1 = new CompositeProduct("Pack PC Gammer + Home PC");
        this.pc2x1.addProduct(this.gammerPC);
        this.pc2x1.addProduct(this.homePC);
    }

    orderSimpleProducts(): void {
        const simpleProductOrder = new Order(Math.floor(Math.random() * 1000), "Galicia Raúl");
        simpleProductOrder.addProduct(this.ram4gb!);
        simpleProductOrder.addProduct(this.disk1tb!);
        simpleProductOrder.addProduct(this.simpleMouse!);
        simpleProductOrder.printOrder();
    }

    orderGammerPC(): void {
        const gammerOrder = new Order(1, "Juan Perez");
        gammerOrder.addProduct(this.gammerPC!);
        gammerOrder.printOrder();
    }

    orderHomePC(): void {
        const homeOrder = new Order(2, "Marcos Guerra");
        homeOrder.addProduct(this.homePC!);
        homeOrder.printOrder();
    }

    orderCombo(): void {
        const comboOrder = new Order(3, "Paquete 2x1 en PC");
        comboOrder.addProduct(this.pc2x1!);
        comboOrder.printOrder();
    }

    orderBig(): void {
        const customOrder = new Order(4, "Israel Galicia");
        customOrder.addProduct(this.homePC!);
        customOrder.addProduct(this.ram8gb!);
        customOrder.addProduct(this.ram4gb!);
        customOrder.addProduct(this.monitor30inch!);
        customOrder.addProduct(this.gammerMouse!);
        customOrder.printOrder();
    }

}
// Main execution
const main = new CompositeMain();
main.buildProducts();

main.orderSimpleProducts();
main.orderHomePC();
main.orderGammerPC();
main.orderCombo();
main.orderBig();