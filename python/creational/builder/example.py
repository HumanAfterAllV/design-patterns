from builders.EmployeeBuilder import EmployeeBuilder


builder = EmployeeBuilder()
employee = (
    builder.set_name("John Doe")
    .set_age(30)
    .set_gender("MALE")
    .set_address("123 Main St", "New York", "USA", "10001")
    .add_phone("123456789", "Home")
    .add_contact("Jane Doe", "987654321")
    .build()
)

print(employee)