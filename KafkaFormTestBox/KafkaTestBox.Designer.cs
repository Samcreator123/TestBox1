namespace KafkaFormTestBox
{
    partial class KafkaTestBox
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendMsgBtn = new System.Windows.Forms.Button();
            this.SendMsgTB = new System.Windows.Forms.RichTextBox();
            this.UserBConnectionBtn = new System.Windows.Forms.Button();
            this.UserAConnectionBtn = new System.Windows.Forms.Button();
            this.ARecieveTB = new System.Windows.Forms.RichTextBox();
            this.BRecieveTB = new System.Windows.Forms.RichTextBox();
            this.SendTopicBtn = new System.Windows.Forms.Button();
            this.SendTopicTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SendMsgBtn
            // 
            this.SendMsgBtn.Location = new System.Drawing.Point(561, 197);
            this.SendMsgBtn.Name = "SendMsgBtn";
            this.SendMsgBtn.Size = new System.Drawing.Size(94, 29);
            this.SendMsgBtn.TabIndex = 0;
            this.SendMsgBtn.Text = "發送訊息";
            this.SendMsgBtn.UseVisualStyleBackColor = true;
            // 
            // SendMsgTB
            // 
            this.SendMsgTB.Location = new System.Drawing.Point(485, 61);
            this.SendMsgTB.Name = "SendMsgTB";
            this.SendMsgTB.Size = new System.Drawing.Size(259, 120);
            this.SendMsgTB.TabIndex = 1;
            this.SendMsgTB.Text = "";
            // 
            // UserBConnectionBtn
            // 
            this.UserBConnectionBtn.Location = new System.Drawing.Point(286, 307);
            this.UserBConnectionBtn.Name = "UserBConnectionBtn";
            this.UserBConnectionBtn.Size = new System.Drawing.Size(94, 29);
            this.UserBConnectionBtn.TabIndex = 2;
            this.UserBConnectionBtn.Text = "連線";
            this.UserBConnectionBtn.UseVisualStyleBackColor = true;
            this.UserBConnectionBtn.Click += new System.EventHandler(this.UserBConnectionBtn_Click);
            // 
            // UserAConnectionBtn
            // 
            this.UserAConnectionBtn.Location = new System.Drawing.Point(286, 111);
            this.UserAConnectionBtn.Name = "UserAConnectionBtn";
            this.UserAConnectionBtn.Size = new System.Drawing.Size(94, 29);
            this.UserAConnectionBtn.TabIndex = 3;
            this.UserAConnectionBtn.Text = "連線";
            this.UserAConnectionBtn.UseVisualStyleBackColor = true;
            this.UserAConnectionBtn.Click += new System.EventHandler(this.UserAConnectionBtn_Click);
            // 
            // ARecieveTB
            // 
            this.ARecieveTB.Location = new System.Drawing.Point(36, 61);
            this.ARecieveTB.Name = "ARecieveTB";
            this.ARecieveTB.Size = new System.Drawing.Size(224, 140);
            this.ARecieveTB.TabIndex = 4;
            this.ARecieveTB.Text = "";
            // 
            // BRecieveTB
            // 
            this.BRecieveTB.Location = new System.Drawing.Point(36, 253);
            this.BRecieveTB.Name = "BRecieveTB";
            this.BRecieveTB.Size = new System.Drawing.Size(224, 120);
            this.BRecieveTB.TabIndex = 5;
            this.BRecieveTB.Text = "";
            // 
            // SendTopicBtn
            // 
            this.SendTopicBtn.Location = new System.Drawing.Point(561, 241);
            this.SendTopicBtn.Name = "SendTopicBtn";
            this.SendTopicBtn.Size = new System.Drawing.Size(94, 29);
            this.SendTopicBtn.TabIndex = 6;
            this.SendTopicBtn.Text = "發送主題";
            this.SendTopicBtn.UseVisualStyleBackColor = true;
            this.SendTopicBtn.Click += new System.EventHandler(this.SendTopicBtn_Click);
            // 
            // SendTopicTB
            // 
            this.SendTopicTB.Location = new System.Drawing.Point(485, 285);
            this.SendTopicTB.Name = "SendTopicTB";
            this.SendTopicTB.Size = new System.Drawing.Size(257, 120);
            this.SendTopicTB.TabIndex = 7;
            this.SendTopicTB.Text = "";
            // 
            // KafkaTestBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendTopicTB);
            this.Controls.Add(this.SendTopicBtn);
            this.Controls.Add(this.BRecieveTB);
            this.Controls.Add(this.ARecieveTB);
            this.Controls.Add(this.UserAConnectionBtn);
            this.Controls.Add(this.UserBConnectionBtn);
            this.Controls.Add(this.SendMsgTB);
            this.Controls.Add(this.SendMsgBtn);
            this.Name = "KafkaTestBox";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button SendMsgBtn;
        private RichTextBox SendMsgTB;
        private Button UserBConnectionBtn;
        private Button UserAConnectionBtn;
        private RichTextBox ARecieveTB;
        private RichTextBox BRecieveTB;
        private Button SendTopicBtn;
        private RichTextBox SendTopicTB;
    }
}