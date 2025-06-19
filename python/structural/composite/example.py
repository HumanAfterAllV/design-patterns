import random
from products.products import SimpleProduct, CompositeProduct
from order.orders import Order

class CompositeMain:
    def __init__(self):
        self.ram4gb = None
        self.ram8gb = None
        self.disk500gb = None
        self.disk1tb = None
        self.cpuAMD = None
        self.cpuIntel = None
        self.smallCabinete = None
        self.bigCabinete = None
        self.monitor20inch = None
        self.monitor30inch = None
        self.simpleMouse = None
        self.gammerMouse = None

        self.gammerPC = None
        self.homePC = None
        self.pc2x1 = None

    def build_products(self):
        # Simple product construction
        self.ram4gb = SimpleProduct("RAM 4GB", 750, "KingStone")
        self.ram8gb = SimpleProduct("RAM 8GB", 1000, "KingStone")
        self.disk500gb = SimpleProduct("HDD 500GB", 1500, "ACME")
        self.disk1tb = SimpleProduct("HDD 1TB", 2000, "ACME")
        self.cpuAMD = SimpleProduct("AMD phenon", 4000, "AMD")
        self.cpuIntel = SimpleProduct("Intel i7", 4500, "Intel")
        self.smallCabinete = SimpleProduct("Small cabinet", 2000, "ExCom")
        self.bigCabinete = SimpleProduct("Big Cabinet", 2200, "ExCom")
        self.monitor20inch = SimpleProduct("Display 20'", 1500, "HP")
        self.monitor30inch = SimpleProduct("Display 30'", 2000, "HP")
        self.simpleMouse = SimpleProduct("Simple mouse", 150, "Genius")
        self.gammerMouse = SimpleProduct("Gammer mouse", 750, "Alien")

        # Gammer PC
        self.gammerPC = CompositeProduct("Gammer PC")
        self.gammerPC.add_product(self.ram8gb)
        self.gammerPC.add_product(self.disk1tb)
        self.gammerPC.add_product(self.cpuIntel)
        self.gammerPC.add_product(self.bigCabinete)
        self.gammerPC.add_product(self.monitor30inch)
        self.gammerPC.add_product(self.gammerMouse)

        # Home PC
        self.homePC = CompositeProduct("Home PC")
        self.homePC.add_product(self.ram4gb)
        self.homePC.add_product(self.disk500gb)
        self.homePC.add_product(self.cpuAMD)
        self.homePC.add_product(self.smallCabinete)
        self.homePC.add_product(self.monitor20inch)
        self.homePC.add_product(self.simpleMouse)

        # Combo PC
        self.pc2x1 = CompositeProduct("Pack PC Gammer + Home PC")
        self.pc2x1.add_product(self.gammerPC)
        self.pc2x1.add_product(self.homePC)

    def order_simple_products(self):
        simple_product_order = Order(random.randint(1, 1000), "Galicia Raúl")
        simple_product_order.add_product(self.ram4gb)
        simple_product_order.add_product(self.disk1tb)
        simple_product_order.add_product(self.simpleMouse)
        simple_product_order.print_order()

    def order_gammer_pc(self):
        gammer_order = Order(1, "Juan Perez")
        gammer_order.add_product(self.gammerPC)
        gammer_order.print_order()

    def order_home_pc(self):
        home_order = Order(2, "Marcos Guerra")
        home_order.add_product(self.homePC)
        home_order.print_order()

    def order_combo(self):
        combo_order = Order(3, "Paquete 2x1 en PC")
        combo_order.add_product(self.pc2x1)
        combo_order.print_order()

    def order_big(self):
        custom_order = Order(4, "Israel Galicia")
        custom_order.add_product(self.homePC)
        custom_order.add_product(self.ram8gb)
        custom_order.add_product(self.ram4gb)
        custom_order.add_product(self.monitor30inch)
        custom_order.add_product(self.gammerMouse)
        custom_order.print_order()


if __name__ == "__main__":
    main = CompositeMain()
    main.build_products()

    main.order_simple_products()
    main.order_home_pc()
    main.order_gammer_pc()
    main.order_combo()
    main.order_big()