using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMULACRO_C_.Models;

public class Vehicle
{
    // propiedades de la clase Vehicle
    public int Id { get; set; }
    public string Plate { get; set; }
    public string Type { get; set; }
    public string EngineNumber { get; set; }
    public string SerialNumber { get; set; }
    public byte PeopleCapacity { get; set; }
    public Driver Owner { get; set; }
    // lista o colección de vehículos
    List<Vehicle> vehicles = new List<Vehicle>()
    {
        new Vehicle(1, "ABC123", "Carro", "123456", "789012", 5, new Driver("123", "A2", 5)),
        new Vehicle(2, "DEF456", "Moto", "654321", "987654", 2, new Driver("456", "B2", 3)),
        new Vehicle(3, "GHI789", "Camioneta", "321654", "901234", 10, new Driver("789", "A2", 7)),
        new Vehicle(4, "JKL012", "Microbus", "456789", "321098", 13, new Driver("986", "B2", 4)),
        new Vehicle(5, "MNO321", "Carro", "987654", "123456", 5, new Driver("693", "A2", 9))
    };
    // constructor de la clase Vehicle
    public Vehicle(int id, string plate, string type, string engineNumber, string serialNumber, byte peopleCapacity, Driver owner)
    {
        Id = id;
        Plate = plate;
        Type = type;
        EngineNumber = engineNumber;
        SerialNumber = serialNumber;
        PeopleCapacity = peopleCapacity;
        Owner = owner;
    }
    // método para eliminar vehiculo
    public void DeleteVehicle(int id)
    {
        vehicles.RemoveAll(v => v.Id == id);

    }

}
