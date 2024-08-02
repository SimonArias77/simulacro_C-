using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMULACRO_C_.Models;

public class Customer
{
    // propiedades de la clase Customer
    public string MembershiptLevel { get; set; }
    public string PreferredPaymentMethod { get; set; }
    // lista o colección de clientes (clientes)
    public static  List<Customer> customers  = new List<Customer>()
    {
        new Customer("Gold", "Credit Card"),
        new Customer("Platinum", "PayPal"),
        new Customer("Diamond", "E-Transfer"),
        new Customer("Bronze", "Bank Transfer"),
        new Customer("Free", "Free")
    };
    // constructor de la clase Customer
    public Customer(string membershipLevel, string preferredPaymentMethod)
    {
        MembershiptLevel = membershipLevel;
        PreferredPaymentMethod = preferredPaymentMethod;
    }
    // método paraactualizar el nivel de afiliación del cliente (customer)
    public void UpdateMembershipLevel(string newLevel)
    {
        MembershiptLevel = newLevel;
    }

}


