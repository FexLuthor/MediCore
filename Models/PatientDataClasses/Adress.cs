using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCore.Models.PatientDataClasses
{
    public class address
    {
        public int? addressId { get; set; }
        public string? street { get; set; }
        public int? number { get; set; }
        public string? town { get; set; }
        public int? postalCode { get; set; }
        public int? patientId { get; set; }
    }
}
