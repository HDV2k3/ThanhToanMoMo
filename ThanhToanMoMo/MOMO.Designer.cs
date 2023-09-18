namespace ThanhToanMoMo
{
    partial class MOMO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MOMO));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textEndpoint = new System.Windows.Forms.TextBox();
            this.textAccessKey = new System.Windows.Forms.TextBox();
            this.textPartnerCode = new System.Windows.Forms.TextBox();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.textOrderInfo = new System.Windows.Forms.TextBox();
            this.textNotify = new System.Windows.Forms.TextBox();
            this.textReturn = new System.Windows.Forms.TextBox();
            this.textPubkey = new System.Windows.Forms.TextBox();
            this.btn_Query = new System.Windows.Forms.Button();
            this.btn_request = new System.Windows.Forms.Button();
            this.btn_refund = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAY WEB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Endpoint:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "AccessKey:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "PartnerCode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "OrderInfo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "IpnUrl:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "RedirectUrl:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 254);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Public key:";
            // 
            // textEndpoint
            // 
            this.textEndpoint.Location = new System.Drawing.Point(94, 35);
            this.textEndpoint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textEndpoint.Name = "textEndpoint";
            this.textEndpoint.Size = new System.Drawing.Size(342, 20);
            this.textEndpoint.TabIndex = 55;
            this.textEndpoint.Text = "https://test-payment.momo.vn/v2/gateway/api/create";
            // 
            // textAccessKey
            // 
            this.textAccessKey.Location = new System.Drawing.Point(94, 61);
            this.textAccessKey.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textAccessKey.Name = "textAccessKey";
            this.textAccessKey.Size = new System.Drawing.Size(250, 20);
            this.textAccessKey.TabIndex = 56;
            this.textAccessKey.Text = "M8brj9K6E22vXoDB";
            // 
            // textPartnerCode
            // 
            this.textPartnerCode.Location = new System.Drawing.Point(94, 97);
            this.textPartnerCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textPartnerCode.Name = "textPartnerCode";
            this.textPartnerCode.Size = new System.Drawing.Size(250, 20);
            this.textPartnerCode.TabIndex = 57;
            this.textPartnerCode.Text = "MOMO5RGX20191128";
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(94, 123);
            this.textAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(250, 20);
            this.textAmount.TabIndex = 58;
            this.textAmount.Text = "15000000";
            // 
            // textOrderInfo
            // 
            this.textOrderInfo.Location = new System.Drawing.Point(94, 152);
            this.textOrderInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textOrderInfo.Name = "textOrderInfo";
            this.textOrderInfo.Size = new System.Drawing.Size(250, 20);
            this.textOrderInfo.TabIndex = 59;
            this.textOrderInfo.Text = "Cửa Hàng Điện Thoại Vip";
            // 
            // textNotify
            // 
            this.textNotify.Location = new System.Drawing.Point(94, 183);
            this.textNotify.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textNotify.Name = "textNotify";
            this.textNotify.Size = new System.Drawing.Size(250, 20);
            this.textNotify.TabIndex = 60;
            this.textNotify.Text = "https://webhook.site/b3088a6a-2d17-4f8d-a383-71389a6c600b";
            // 
            // textReturn
            // 
            this.textReturn.Location = new System.Drawing.Point(94, 214);
            this.textReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textReturn.Name = "textReturn";
            this.textReturn.Size = new System.Drawing.Size(250, 20);
            this.textReturn.TabIndex = 61;
            this.textReturn.Text = "https://webhook.site/b3088a6a-2d17-4f8d-a383-71389a6c600b";
            // 
            // textPubkey
            // 
            this.textPubkey.Location = new System.Drawing.Point(26, 282);
            this.textPubkey.Margin = new System.Windows.Forms.Padding(2);
            this.textPubkey.Multiline = true;
            this.textPubkey.Name = "textPubkey";
            this.textPubkey.Size = new System.Drawing.Size(490, 129);
            this.textPubkey.TabIndex = 65;
            this.textPubkey.Text = resources.GetString("textPubkey.Text");
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(546, 74);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(140, 23);
            this.btn_Query.TabIndex = 66;
            this.btn_Query.Text = "Query Status";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_request
            // 
            this.btn_request.Location = new System.Drawing.Point(546, 145);
            this.btn_request.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_request.Name = "btn_request";
            this.btn_request.Size = new System.Drawing.Size(138, 23);
            this.btn_request.TabIndex = 68;
            this.btn_request.Text = "Web Payment request";
            this.btn_request.UseVisualStyleBackColor = true;
            this.btn_request.Click += new System.EventHandler(this.btn_request_Click);
            // 
            // btn_refund
            // 
            this.btn_refund.Location = new System.Drawing.Point(546, 224);
            this.btn_refund.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refund.Name = "btn_refund";
            this.btn_refund.Size = new System.Drawing.Size(140, 23);
            this.btn_refund.TabIndex = 69;
            this.btn_refund.Text = "Refund";
            this.btn_refund.UseVisualStyleBackColor = true;
            this.btn_refund.Click += new System.EventHandler(this.button3_Click);
            // 
            // MOMO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 541);
            this.Controls.Add(this.btn_refund);
            this.Controls.Add(this.btn_request);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.textPubkey);
            this.Controls.Add(this.textReturn);
            this.Controls.Add(this.textNotify);
            this.Controls.Add(this.textOrderInfo);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.textPartnerCode);
            this.Controls.Add(this.textAccessKey);
            this.Controls.Add(this.textEndpoint);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MOMO";
            this.Text = "MOMO";
            this.Load += new System.EventHandler(this.MOMO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textEndpoint;
        private System.Windows.Forms.TextBox textAccessKey;
        private System.Windows.Forms.TextBox textPartnerCode;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.TextBox textOrderInfo;
        private System.Windows.Forms.TextBox textNotify;
        private System.Windows.Forms.TextBox textReturn;
        private System.Windows.Forms.TextBox textPubkey;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.Button btn_request;
        private System.Windows.Forms.Button btn_refund;
    }
}