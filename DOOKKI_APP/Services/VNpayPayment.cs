using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOOKKI_APP.Services
{

    public class VNpayPayment
    {
        private static VNpayPayment _instance;
        private static readonly object _lock = new object();
        public static VNpayPayment Instance {  
            get 
            { 
                if(_instance == null)
                {
                    lock(_lock)
                    {
                        if(_instance == null)
                        {
                            _instance = new VNpayPayment();
                        }
                    }
                }

                return _instance;
            }
        }


        public void CreatePaymentUrl(PictureBox pictureBox, string acqId, string accountnumber,string accountName, string amount)
        {
            var apiRequest = new ApiRequest();

            apiRequest.acqId = Convert.ToInt32(acqId);
            apiRequest.accountNo = long.Parse(accountnumber);
            apiRequest.accountName = accountName;
            apiRequest.amount = Convert.ToInt32(amount);
            apiRequest.format = "text";
            apiRequest.template = "compact2";
            var jsonRequest = JsonConvert.SerializeObject(apiRequest);
            // use restsharp for request api.
            var client = new RestClient("https://api.vietqr.io/v2/generate");
            var request = new RestRequest();

            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");

            request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

            var response = client.Execute(request);
            var content = response.Content;
            var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);


            var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
            pictureBox.Image = image;
        }

        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
    }

    internal class ApiRequest
    {
        public long accountNo { get; set; }
        public string accountName { get; set; }
        public int acqId { get; set; }
        public int amount { get; set; }
        public string addInfo { get; set; }
        public string format { get; set; }
        public string template { get; set; }
    }
    internal class Data
    {
        public int acpId { get; set; }
        public string accountName { get; set; }
        public string qrCode { get; set; }
        public string qrDataURL { get; set; }
    }

    internal class ApiResponse
    {
        public string code { get; set; }
        public string desc { get; set; }
        public Data data { get; set; }
    }

}
