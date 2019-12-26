using System.Collections.Generic;

namespace gotoconfig.BarcodeLib.Models
{
    public class BarcodeModel
    {
        public List<BarcodeInfoDto> BarcodeInfoList { get; set; }
        public BarcodeInfoDto BarcodeInfo { get; set; }
    }

    public class BarcodeInfoDto
    {
        public string PatientId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string HospitalName { get; set; }
        public string City { get; set; }
    }
}