using Car_Rental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental.Common.Classes;

public class Customer : IPerson
{
    public string firstName { get; init; }

    public string lastName { get; init; }
    public string ssn { get; init; }

    public Customer(string FirstName, string LastName, string SSN)
    {
        this.firstName = FirstName;
        this.lastName = LastName;
        this.ssn = SSN;
    }
       
}
