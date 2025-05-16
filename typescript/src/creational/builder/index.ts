import { EmployeeBuilder } from "./builder/EmployeeBuilder";
import { GENDER } from "./dto/Employee";
import { TYPE_PHONE } from "./dto/Phone"; 

const builder = new EmployeeBuilder()

const employee = (
    builder.setName("John Doe")
    .setAge(30)
    .setGender(GENDER.MALE)
    .setAddress("123 Main St", "New York", "USA", "10001")
    .addPhone("123456789", TYPE_PHONE.MOBILE)
    .addContact("Jane Doe", "987654321")
    .build()
)

console.log(employee)