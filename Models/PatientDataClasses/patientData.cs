using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCore.Models.PatientDataClasses
{
    public class PatientData
    {
        public int patientId { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? birthDate { get; set; }
        public int? gender { get; set; }
        public string? phone { get; set; }
        public string? email { get; set; }
        public string? notes { get; set; }
        public List<Image>? images { get; set; }

        public address? address { get; set; }
    }
}
