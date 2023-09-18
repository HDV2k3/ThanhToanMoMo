using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThanhToanMoMo
{
    public partial class MOMO : Form
    {
        public MOMO()
        {
            InitializeComponent();
        }


        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private void MOMO_Load(object sender, EventArgs e)
        {

        }

        private void btn_request_Click(object sender, EventArgs e)
        {
            // khi kích nút thanh toán 
            //request params need to request to MoMo system
            string endpoint = textEndpoint.Text.Equals("") ? "https://test-payment.momo.vn/v2/gateway/api/create" : textEndpoint.Text;
            string partnerCode = textPartnerCode.Text; // đường link endpoint https://test-payment.momo.vn/v2/gateway/api/create  được momo cung cấp
            string accessKey = textAccessKey.Text;
            string serectkey = "nqQiVSgDMy809JoPF6OzP5OdBUB550Y4";
            string orderInfo = textOrderInfo.Text;
            string redirectUrl = textReturn.Text;// đây là đường link mà momo sẽ gọi ngược lại cho doanh nghiệp https://webhook.site/b3088a6a-2d17-4f8d-a383-71389a6c600b
            string ipnUrl = textNotify.Text;                  // sau khi thanh toán thành công hay thất bại

            string requestType = "captureWallet";
            string amount = textAmount.Text;
            string orderId = Guid.NewGuid().ToString();
            string requestId = Guid.NewGuid().ToString();   
            string extraData = "";


            // tạo thông tin dữ liệu gửi cho momo


            //Before sign HMAC SHA256 signature
            string rawHash = "accessKey=" + accessKey +
                "&amount=" + amount +
                "&extraData=" + extraData +
                "&ipnUrl=" + ipnUrl +
                "&orderId=" + orderId +
                "&orderInfo=" + orderInfo +
                "&partnerCode=" + partnerCode +
                "&redirectUrl=" + redirectUrl +
                "&requestId=" + requestId +
                "&requestType=" + requestType
                ;

            log.Debug("rawHash = " + rawHash);

            // ký dữ liệu thông qua cú pháp mã hóa dữ liệu SHA256
            MoMoSecurity crypto = new MoMoSecurity();
            //sign signature SHA256
            string signature = crypto.signSHA256(rawHash, serectkey);
            log.Debug("Signature = " + signature);
            // tại đây mình sẽ tạo ra chữ ký
            //build body json request
            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "partnerName", "Test" },
                { "storeId", "MomoTestStore" },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderId },
                { "orderInfo", orderInfo },
                { "redirectUrl", redirectUrl },
                { "ipnUrl", ipnUrl },
                { "lang", "en" },
                { "extraData", extraData },
                { "requestType", requestType },
                { "signature", signature }

            };

            // sau ký dữ liệu thì sẽ gửi 1 request qua cho momo thông qua đường link endpoint
            log.Debug("Json request to MoMo: " + message.ToString());
            string responseFromMomo = PaymentRequest.sendPaymentRequest(endpoint, message.ToString());
            // JObject jmessage = JObject.Parse(responseFromMomo);kết quả mà momo sẽ trả về cho mình
            JObject jmessage = JObject.Parse(responseFromMomo);
            // sau đó mình sẽ chuyển hướng sang trang thanh toán có mã qr code 
            //https://test-payment.momo.vn/pay/pos

            log.Debug("Return from MoMo: " + jmessage.ToString());
            DialogResult result = MessageBox.Show(responseFromMomo, "Open in browser", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //yes...
                System.Diagnostics.Process.Start(jmessage.GetValue("payUrl").ToString());
            }
            else if (result == DialogResult.Cancel)
            {
                //no...
            }
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            // mình sẽ đọc ra các Query  và sẽ ký lại key mà momo đã cung cấp 
            string endpoint = "https://test-payment.momo.vn/pay/query-status";
            string partnerCode = "MOMO5RGX20191128";
            string merchantRefId = "1519717410468";
            string version = "2.0";
            string publicKey = textPubkey.Text;
            string requestId = Guid.NewGuid().ToString();
            string description = "";
          
          
            //get hash
            MoMoSecurity momoCrypto = new MoMoSecurity();
            string hash = momoCrypto.buildQueryHash(partnerCode, merchantRefId, requestId,
                publicKey);
            // sau đó mình sẽ ký lại dữ liệu 
            
            //request to MoMo 
            string jsonRequest = "{\"partnerCode\":\"" +
                partnerCode + "\",\"partnerRefId\":\"" +
                merchantRefId + "\",\"description\":\"" +
                description + "\",\"version\":" +
                version + ",\"hash\":\"" +
                hash + "\"}";
            log.Debug(jsonRequest);
            // nếu mà chữ ký không trùng hoặc không trùng với momo truyền sang
            // thông báo thông tin 
            //response from MoMo
            string responseFromMomo = PaymentRequest.sendPaymentRequest(endpoint, jsonRequest.ToString());
            log.Debug(responseFromMomo);
            log.Debug(hash);
            JObject jmessage = JObject.Parse(responseFromMomo);
            log.Debug("Return from MoMo: " + jmessage.ToString());
            DialogResult result = MessageBox.Show(responseFromMomo, "MoMo response", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //yes... thanh toán thành công
            }
            else if (result == DialogResult.Cancel)
            {
                //no...thanh toán thất bại
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string endpoint = "https://test-payment.momo.vn/pay/refund";
            string partnerCode = "MOMO5RGX20191128";
            string merchantRefId = "1519717410468";
            string momoTransId = "137489899";
            string version = "2.0";
            string publicKey = textPubkey.Text;
            string requestId = Guid.NewGuid().ToString();
            string description = "";
            long amount = 15000000;

            //get hash
            MoMoSecurity momoCrypto = new MoMoSecurity();
            string hash = momoCrypto.buildRefundHash(partnerCode, merchantRefId, momoTransId, amount,
                description,
                publicKey);

            //request to MoMo
            string jsonRequest = "{\"partnerCode\":\"" +
                partnerCode + "\",\"requestId\":\"" +
                requestId + "\",\"version\":" +
                version + ",\"hash\":\"" +
                hash + "\"}";
            log.Debug(jsonRequest);

            //response from MoMo
            string responseFromMomo = PaymentRequest.sendPaymentRequest(endpoint, jsonRequest.ToString());
            log.Debug(responseFromMomo);
            log.Debug(hash);
            JObject jmessage = JObject.Parse(responseFromMomo);
            log.Debug("Return from MoMo: " + jmessage.ToString());
            DialogResult result = MessageBox.Show(responseFromMomo, "MoMo response", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //yes...
            }
            else if (result == DialogResult.Cancel)
            {
                //no...
            }
        }

    }
}
