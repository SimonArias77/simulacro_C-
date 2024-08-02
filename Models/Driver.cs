using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMULACRO_C_.Models;

public class Driver
{
    // propiedades de la clase driver
    public string LicenseNumber { get; set; }
    public string LicenseCategory { get; set; }
    public int DrivingExperience { get; set; }
    // lista o colección de drivers (conductores)
    public static  List<Driver> drivers = new List<Driver>()
    {
        new Driver("123", "A2", 5),
        new Driver("456", "B2", 3),
        new Driver("789", "A2", 7),
        new Driver("986", "B2", 4),
        new Driver("693", "A2", 9)
    };
    // constructor de la clase Driver
    public Driver(string licenseNumber, string licenseCategory, int drivingExperience)
    {
        LicenseNumber = licenseNumber;
        LicenseCategory = licenseCategory;
        DrivingExperience = drivingExperience;
    }
    // metodo para actualizar la categoría de la licencia
    public void UpdateLicenseCategory(string newCategory)
    {
        LicenseCategory = newCategory;
    }
    // metodo para agregar años de experiencia en el conducir
    public void AddExperience(int years)
    {
        DrivingExperience += years;
    }
}
