import { ProxyDocument } from "./proxy/Proxy";

function main() {
    const proxy = new ProxyDocument("Patients.pdf", null, { doctor: "Doctor", admin: "Admin" });

    try {
        proxy.display("admin"); // Cambiado de "Admin" a "admin"
    } catch (e) {
        console.error(e);
    }
    console.log("*------*");

/*     try {
        proxy.display("Patient");
    } catch (e) {
        console.error(e);
    }
    console.log("*------*");
 */
/*     try {
        proxy.display("Dr.House");
    } catch (e) {
        console.error(e);
    }
    console.log("*------*"); */
}

main();