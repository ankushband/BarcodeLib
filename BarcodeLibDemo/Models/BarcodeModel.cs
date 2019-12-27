using gotoconfig.BarcodeLibDemo.Helpers;
using System;
using System.Collections.Generic;

namespace gotoconfig.BarcodeLibDemo.Models
{
    public class BarcodeModel
    {
        public List<BarcodeInfoDto> BarcodeInfoList { get; set; }
        public BarcodeInfoDto BarcodeInfo { get; set; }

        public BarcodeInfoDto GetBarcodeInfo(string patientId)
        {
            BarcodeInfo = new BarcodeInfoDto();
            BarcodeInfo = GetListBarcodeInfo().Find(x => x.PatientId == patientId);

            return BarcodeInfo;
        }

        public List<BarcodeInfoDto> GetListBarcodeInfo()
        {
            BarcodeInfoList = new List<BarcodeInfoDto>();           

            BarcodeInfoList.Add(new BarcodeInfoDto { PatientId = "ABP1000Z", PatientFirstName = "FirstName1", PatientLastName = "LastName1", BarcodeImageUrl = BarcodeBase64Image("ABP1000Z") });
            BarcodeInfoList.Add(new BarcodeInfoDto { PatientId = "XYZ20011", PatientFirstName = "FirstName2", PatientLastName = "LastName2", BarcodeImageUrl = BarcodeBase64Image("XYZ20011") });
            BarcodeInfoList.Add(new BarcodeInfoDto { PatientId = "WVX30362", PatientFirstName = "FirstName3", PatientLastName = "LastName3", BarcodeImageUrl = BarcodeBase64Image("WVX30362") });
            BarcodeInfoList.Add(new BarcodeInfoDto { PatientId = "JKL40044", PatientFirstName = "FirstName4", PatientLastName = "LastName4", BarcodeImageUrl = BarcodeBase64Image("JKL40044") });

            return BarcodeInfoList;
        }

        public string BarcodeBase64Image(string patientId)
        {
            int width = 250;
            int height = 50;
            bool includeLabel = true;

            byte[] img = null;

            int imageWidth = width;
            int imageHeight = height;

            BarcodeHelper barcodeHelper = new BarcodeHelper();
            img = barcodeHelper.Generate(patientId, imageWidth, imageHeight, includeLabel);
            return img != null ? "data:image/jpg;base64," + Convert.ToBase64String(img) : "";
        }
    }

    public class BarcodeInfoDto
    {
        public string PatientId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string BarcodeImageUrl { get; set; }
    }
}