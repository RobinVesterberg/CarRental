using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental.Common.Interfaces
{
    public interface IPerson
    {
        public string firstName { get; init; }
        public string lastName { get; init; }
        public string ssn { get; init; }
       
    }
}
