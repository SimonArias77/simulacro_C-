using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMULACRO_C_.Models;

public class User
{
    // propiedades de la clase user
    protected Guid Id { get; set; }
    protected string Name { get; set; }
    protected string LastName { get; set; }
    protected string TypeDocument { get; set; }
    protected string IdentificationNumber { get; set; }
    protected DateOnly Birthdate { get; set; }
    protected string Email { get; set; }
    protected string PhoneNumber { get; set; }
    protected string Adress { get; set; }

    // constructor de la clase User
    protected User(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string adress)
    {
        Id = Guid.NewGuid();
        Name = name;
        LastName = lastName;
        TypeDocument = typeDocument;
        IdentificationNumber = identificationNumber;
        Birthdate = birthdate;
        Email = email;
        PhoneNumber = phoneNumber;
        Adress = adress;
    }
    // lista o colección de usuarios
    public static  List<User> users = new List<User>()
    {
        new User("John", "Doe", "CC", "123456789", new DateOnly(1990, 1, 1), "john.doe@example.com", "+506 8888-9999", "Calle 123, Apartamento 456"),
        new User("Jane", "Smith", "CC", "987654321", new DateOnly(1985, 5, 20), "jane.smith@example.com", "+506 9999-8888", "Calle 456, Apartamento 789")
    };
    // método para mostrar detalles del usuario
    protected void ShowDetails()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name} {LastName}, Type Document: {TypeDocument}, Identification Number: {IdentificationNumber}, Birthdate: {Birthdate.ToString("dd/MM/yyyy")}, Email: {Email}, Phone Number: {PhoneNumber}, Adress: {Adress}");
    }
    // método público para obtener propiedades encapsuladas
    public string GetFullName()
    {
        return $"{Name} {LastName}";
    }
    // método para calcular la edad del usuario
    protected int CalculateAge()
    {
        return DateTime.Now.Year - Birthdate.Year;
    }
    // método publico para poder calcular la edad del usuario sin encapsulamiento
    public int GetAge()
    {
        return CalculateAge();
    }
    // método para mostrar la edad del usuario en años, meses y días
    protected void ShowAge()
    {
        Console.WriteLine($"Age: {CalculateAge()}");
    }
    // método para crear un nuevo usuario
    

}
