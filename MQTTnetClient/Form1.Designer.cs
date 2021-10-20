namespace MQTTnetClient
{
    partial class Form1
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtTopic1 = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.lblTopic1 = new System.Windows.Forms.Label();
            this.lblTopic2 = new System.Windows.Forms.Label();
            this.txtTopic2 = new System.Windows.Forms.TextBox();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.lblValue1 = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblV1 = new System.Windows.Forms.Label();
            this.txtValueReceived = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnPublish2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(395, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtTopic1
            // 
            this.txtTopic1.Location = new System.Drawing.Point(77, 50);
            this.txtTopic1.Name = "txtTopic1";
            this.txtTopic1.Size = new System.Drawing.Size(118, 20);
            this.txtTopic1.TabIndex = 1;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(395, 48);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(100, 23);
            this.btnPublish.TabIndex = 2;
            this.btnPublish.Text = "Start";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblTopic1
            // 
            this.lblTopic1.AutoSize = true;
            this.lblTopic1.Location = new System.Drawing.Point(16, 53);
            this.lblTopic1.Name = "lblTopic1";
            this.lblTopic1.Size = new System.Drawing.Size(43, 13);
            this.lblTopic1.TabIndex = 3;
            this.lblTopic1.Text = "Topic 1";
            // 
            // lblTopic2
            // 
            this.lblTopic2.AutoSize = true;
            this.lblTopic2.Location = new System.Drawing.Point(16, 81);
            this.lblTopic2.Name = "lblTopic2";
            this.lblTopic2.Size = new System.Drawing.Size(43, 13);
            this.lblTopic2.TabIndex = 4;
            this.lblTopic2.Text = "Topic 2";
            // 
            // txtTopic2
            // 
            this.txtTopic2.Location = new System.Drawing.Point(77, 81);
            this.txtTopic2.Name = "txtTopic2";
            this.txtTopic2.Size = new System.Drawing.Size(118, 20);
            this.txtTopic2.TabIndex = 5;
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(268, 50);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(100, 20);
            this.txtValue1.TabIndex = 6;
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.Location = new System.Drawing.Point(218, 53);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(34, 13);
            this.lblValue1.TabIndex = 7;
            this.lblValue1.Text = "Value";
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Location = new System.Drawing.Point(218, 84);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(34, 13);
            this.lblValue2.TabIndex = 8;
            this.lblValue2.Text = "Value";
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(268, 80);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(100, 20);
            this.txtValue2.TabIndex = 9;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(77, 18);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(118, 20);
            this.txtPort.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Port";
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Location = new System.Drawing.Point(13, 123);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(83, 13);
            this.lblV1.TabIndex = 13;
            this.lblV1.Text = "Value Received";
            // 
            // txtValueReceived
            // 
            this.txtValueReceived.Location = new System.Drawing.Point(102, 120);
            this.txtValueReceived.Name = "txtValueReceived";
            this.txtValueReceived.Size = new System.Drawing.Size(393, 20);
            this.txtValueReceived.TabIndex = 12;
            this.txtValueReceived.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(218, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "ID";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(268, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 16;
            // 
            // btnPublish2
            // 
            this.btnPublish2.Location = new System.Drawing.Point(395, 78);
            this.btnPublish2.Name = "btnPublish2";
            this.btnPublish2.Size = new System.Drawing.Size(100, 23);
            this.btnPublish2.TabIndex = 18;
            this.btnPublish2.Text = "Stop";
            this.btnPublish2.UseVisualStyleBackColor = true;
            this.btnPublish2.Click += new System.EventHandler(this.btnPublish2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 154);
            this.Controls.Add(this.btnPublish2);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblV1);
            this.Controls.Add(this.txtValueReceived);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblValue1);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.txtTopic2);
            this.Controls.Add(this.lblTopic2);
            this.Controls.Add(this.lblTopic1);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.txtTopic1);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtTopic1;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Label lblTopic1;
        private System.Windows.Forms.Label lblTopic2;
        private System.Windows.Forms.TextBox txtTopic2;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.TextBox txtValueReceived;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnPublish2;
    }
}

