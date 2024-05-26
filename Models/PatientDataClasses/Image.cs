using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCore.Models.PatientDataClasses
{
    public class Image
    {
        public int? imageId { get; set; }
        public string? uploadDate { get; set; }
        public string? filePath { get; set; }
        public string? contentType { get; set; }
        public int? patientId { get; set; }
    }
}
