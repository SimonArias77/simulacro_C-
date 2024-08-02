using SIMULACRO_C_.Models;



void ShowMenu()
{
    Console.WriteLine(@$"1. Listar todos los clientes
2. Listar todos los conductores
3. Listar todos los usuarios que tienen más de 30 años de edad.
4. Ordenar los conductores por su experiencia de conducción en orden descendente.
5. Encontrar todos los clientes que prefieren pagar con tarjeta de crédito.
6. Listar Todos los Conductores con Licencia de Categoría 'A2'
7. Salir");

    int option;

    do
    {
        Console.Write("Ingrese una opción: ");
        option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                // Listar todos los clientes
                ListCustomer();
                break;
            case 2:
                // Listar todos los conductores
                ListDrivers();
                break;
            case 3:
                // Listar todos los usuarios que tienen más de 30 años de edad.
                ListUsersAgeMore30Years();
                break;
            case 4:
                // Ordenar los conductores por su experiencia de conducción en orden descendente.
                OrderDriversDrivingExperienceDescending();
                break;
            case 5:
                // Encontrar todos los clientes que prefieren pagar con tarjeta de crédito.
                FindCustomersPreferPayCreditCard();
                break;
            case 6:
                // Listar Todos los conductores con Licencia de Categoría 'A2'
                ListDriversLicenseCategoryA2();
                break;
            case 7:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opción inválida. Intente nuevamente.");
                break;
        }
    } while (true);

}
void ListCustomer()
{
    // Implementar código para listar todos los clientes
    Console.WriteLine("Listado de clientes:");
    foreach (var customer in Customer.customers)
    {
        Console.WriteLine($"Nivel de afiliación: {customer.MembershiptLevel}, Método de pago: {customer.PreferredPaymentMethod}");
    }
}
void ListDrivers()
{
    // Implementar código para listar todos los conductores
    Console.WriteLine("Listado de conductores:");
    foreach (var driver in Driver.drivers)
    {
        Console.WriteLine($"Licencia: {driver.LicenseNumber}, Categoría: {driver.LicenseCategory}, Experiencia: {driver.DrivingExperience} años");
    }
}
void ListUsersAgeMore30Years()
{
    // Implementar código para listar todos los usuarios que tienen más de 30 años de edad.
    Console.WriteLine("Listado de usuarios con más de 30 años:");
    foreach (var user in User.users)
    {
        if (user.GetAge() > 30) // usar GetAge() si CalcularAge() es ŕivado o protected
        {
            Console.WriteLine($"{user.GetFullName()}, Edad: {user.GetAge()} años");
        }
    }
}
void OrderDriversDrivingExperienceDescending()
{
    // Implementar código para ordenar los conductores por su experiencia de conducción en orden descendente.
    Console.WriteLine("Listado de conductores ordenados por experiencia en orden  descendente:");
    var sortedDrivers = Driver.drivers.OrderByDescending(d => d.DrivingExperience).ToList();
    foreach (var driver in sortedDrivers)
    {
        Console.WriteLine($"Licencia: {driver.LicenseNumber}, Categoría: {driver.LicenseCategory}, Experiencia: {driver.DrivingExperience} años");
    }
}
void FindCustomersPreferPayCreditCard()
{
    // Implementar código para encontrar todos los clientes que prefieren pagar con tarjeta de crédito.
    Console.WriteLine("Clientes que prefieren pagar con tarjeta de crédito:");
    foreach (var customer in Customer.customers)
    {
        if (customer.PreferredPaymentMethod == "Credit Card")
        {
            Console.WriteLine($"{customer.MembershiptLevel} {customer.PreferredPaymentMethod}");
        }
    }
}
void ListDriversLicenseCategoryA2()
{
    // Implementar código para listar Todos los conductores con Licencia de Categoría 'A2'
    Console.WriteLine("Listado de conductores con Licencia de Categoría 'A2':");
    foreach (var driver in Driver.drivers)
    {
        if (driver.LicenseCategory == "A2")
        {
            Console.WriteLine($"Licencia: {driver.LicenseNumber}, Categoría: {driver.LicenseCategory}, Experiencia: {driver.DrivingExperience} años");
        }
    }
}

ShowMenu();
