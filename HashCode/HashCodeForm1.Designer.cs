namespace HashCode
{
    partial class HashCodeForm1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashCodeForm1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RandomNumber = new System.Windows.Forms.Label();
            this.txtRandomNumber = new System.Windows.Forms.TextBox();
            this.txtPaymentValue = new System.Windows.Forms.TextBox();
            this.txtRecipientSortCode = new System.Windows.Forms.TextBox();
            this.txtOriginatorSortCode = new System.Windows.Forms.TextBox();
            this.txtRandomString = new System.Windows.Forms.TextBox();
            this.PaymentValue = new System.Windows.Forms.Label();
            this.Recipient = new System.Windows.Forms.Label();
            this.Originator = new System.Windows.Forms.Label();
            this.BACSRandomString = new System.Windows.Forms.Label();
            this.PaymentDetails = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Advice = new System.Windows.Forms.Label();
            this.txtGeneratedHash = new System.Windows.Forms.TextBox();
            this.Hash_Code = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Generate = new System.Windows.Forms.Button();
            this.Compare = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpIsComingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ClearAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RandomNumber);
            this.panel1.Controls.Add(this.txtRandomNumber);
            this.panel1.Controls.Add(this.txtPaymentValue);
            this.panel1.Controls.Add(this.txtRecipientSortCode);
            this.panel1.Controls.Add(this.txtOriginatorSortCode);
            this.panel1.Controls.Add(this.txtRandomString);
            this.panel1.Controls.Add(this.PaymentValue);
            this.panel1.Controls.Add(this.Recipient);
            this.panel1.Controls.Add(this.Originator);
            this.panel1.Controls.Add(this.BACSRandomString);
            this.panel1.Controls.Add(this.PaymentDetails);
            this.panel1.Location = new System.Drawing.Point(12, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 261);
            this.panel1.TabIndex = 0;
            // 
            // RandomNumber
            // 
            this.RandomNumber.AutoSize = true;
            this.RandomNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomNumber.Location = new System.Drawing.Point(3, 215);
            this.RandomNumber.Name = "RandomNumber";
            this.RandomNumber.Size = new System.Drawing.Size(169, 16);
            this.RandomNumber.TabIndex = 6;
            this.RandomNumber.Text = "Hash Code Random Number";
            // 
            // txtRandomNumber
            // 
            this.txtRandomNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRandomNumber.Location = new System.Drawing.Point(191, 212);
            this.txtRandomNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRandomNumber.MaxLength = 4;
            this.txtRandomNumber.Name = "txtRandomNumber";
            this.txtRandomNumber.Size = new System.Drawing.Size(452, 23);
            this.txtRandomNumber.TabIndex = 5;
            this.txtRandomNumber.TextChanged += new System.EventHandler(this.txtRandomNumber_TextChanged);
            // 
            // txtPaymentValue
            // 
            this.txtPaymentValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentValue.Location = new System.Drawing.Point(191, 169);
            this.txtPaymentValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPaymentValue.MaxLength = 12;
            this.txtPaymentValue.Name = "txtPaymentValue";
            this.txtPaymentValue.Size = new System.Drawing.Size(452, 23);
            this.txtPaymentValue.TabIndex = 4;
            this.txtPaymentValue.TextChanged += new System.EventHandler(this.TxtPaymentValue_TextChanged);
            this.txtPaymentValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaymentValue_KeyPress);
            this.txtPaymentValue.MouseLeave += new System.EventHandler(this.txtPaymentValue_MouseLeave);
            this.txtPaymentValue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtPaymentValue_MouseMove);
            // 
            // txtRecipientSortCode
            // 
            this.txtRecipientSortCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipientSortCode.Location = new System.Drawing.Point(191, 127);
            this.txtRecipientSortCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRecipientSortCode.MaxLength = 6;
            this.txtRecipientSortCode.Name = "txtRecipientSortCode";
            this.txtRecipientSortCode.Size = new System.Drawing.Size(452, 23);
            this.txtRecipientSortCode.TabIndex = 3;
            this.txtRecipientSortCode.TextChanged += new System.EventHandler(this.TxtRecipientSortCode_TextChanged);
            this.txtRecipientSortCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecipientSortCode_KeyPress);
            this.txtRecipientSortCode.MouseLeave += new System.EventHandler(this.txtRecipientSortCode_MouseLeave);
            this.txtRecipientSortCode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtRecipientSortCode_MouseMove);
            // 
            // txtOriginatorSortCode
            // 
            this.txtOriginatorSortCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginatorSortCode.Location = new System.Drawing.Point(191, 81);
            this.txtOriginatorSortCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOriginatorSortCode.MaxLength = 6;
            this.txtOriginatorSortCode.Name = "txtOriginatorSortCode";
            this.txtOriginatorSortCode.Size = new System.Drawing.Size(452, 23);
            this.txtOriginatorSortCode.TabIndex = 2;
            this.txtOriginatorSortCode.TextChanged += new System.EventHandler(this.TxtOriginatorSortCode_TextChanged);
            this.txtOriginatorSortCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOriginatorSortCode_KeyPress);
            this.txtOriginatorSortCode.MouseLeave += new System.EventHandler(this.txtOriginatorSortCode_MouseLeave);
            this.txtOriginatorSortCode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtOriginatorSortCode_MouseMove);
            // 
            // txtRandomString
            // 
            this.txtRandomString.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRandomString.Location = new System.Drawing.Point(191, 34);
            this.txtRandomString.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRandomString.MaxLength = 64;
            this.txtRandomString.Name = "txtRandomString";
            this.txtRandomString.Size = new System.Drawing.Size(452, 23);
            this.txtRandomString.TabIndex = 1;
            this.txtRandomString.TextChanged += new System.EventHandler(this.txtRandomString_TextChanged);
            this.txtRandomString.MouseLeave += new System.EventHandler(this.txtRandomString_MouseLeave);
            this.txtRandomString.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtRandomString_MouseMove);
            // 
            // PaymentValue
            // 
            this.PaymentValue.AutoSize = true;
            this.PaymentValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentValue.Location = new System.Drawing.Point(3, 172);
            this.PaymentValue.Name = "PaymentValue";
            this.PaymentValue.Size = new System.Drawing.Size(93, 16);
            this.PaymentValue.TabIndex = 3;
            this.PaymentValue.Text = "Payment Value";
            this.PaymentValue.Click += new System.EventHandler(this.PaymentValue_Click);
            // 
            // Recipient
            // 
            this.Recipient.AutoSize = true;
            this.Recipient.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recipient.Location = new System.Drawing.Point(3, 130);
            this.Recipient.Name = "Recipient";
            this.Recipient.Size = new System.Drawing.Size(121, 16);
            this.Recipient.TabIndex = 1;
            this.Recipient.Text = "Recipient Sort Code";
            this.Recipient.Click += new System.EventHandler(this.Recipient_Click);
            // 
            // Originator
            // 
            this.Originator.AutoSize = true;
            this.Originator.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Originator.Location = new System.Drawing.Point(3, 84);
            this.Originator.Name = "Originator";
            this.Originator.Size = new System.Drawing.Size(126, 16);
            this.Originator.TabIndex = 2;
            this.Originator.Text = "Originator Sort Code";
            this.Originator.Click += new System.EventHandler(this.Originator_Click);
            // 
            // BACSRandomString
            // 
            this.BACSRandomString.AutoSize = true;
            this.BACSRandomString.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACSRandomString.Location = new System.Drawing.Point(3, 37);
            this.BACSRandomString.Name = "BACSRandomString";
            this.BACSRandomString.Size = new System.Drawing.Size(128, 16);
            this.BACSRandomString.TabIndex = 1;
            this.BACSRandomString.Text = "BACS Random String";
            this.BACSRandomString.Click += new System.EventHandler(this.BACSRandomString_Click);
            // 
            // PaymentDetails
            // 
            this.PaymentDetails.AutoSize = true;
            this.PaymentDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentDetails.Location = new System.Drawing.Point(3, 0);
            this.PaymentDetails.Name = "PaymentDetails";
            this.PaymentDetails.Size = new System.Drawing.Size(113, 16);
            this.PaymentDetails.TabIndex = 0;
            this.PaymentDetails.Text = "Payment Details";
            this.PaymentDetails.Click += new System.EventHandler(this.PaymentDetails_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Advice);
            this.panel2.Controls.Add(this.txtGeneratedHash);
            this.panel2.Controls.Add(this.Hash_Code);
            this.panel2.Location = new System.Drawing.Point(12, 367);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 114);
            this.panel2.TabIndex = 1;
            // 
            // Advice
            // 
            this.Advice.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Advice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Advice.Location = new System.Drawing.Point(6, 33);
            this.Advice.Name = "Advice";
            this.Advice.Size = new System.Drawing.Size(637, 40);
            this.Advice.TabIndex = 6;
            this.Advice.Text = "Enter a hash code here and click Compare to test it against the BACS Random Strin" +
    "g above, or just enter the details above and click Generate to create a hash cod" +
    "e.";
            // 
            // txtGeneratedHash
            // 
            this.txtGeneratedHash.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneratedHash.Location = new System.Drawing.Point(101, 77);
            this.txtGeneratedHash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGeneratedHash.MaxLength = 64;
            this.txtGeneratedHash.Name = "txtGeneratedHash";
            this.txtGeneratedHash.Size = new System.Drawing.Size(452, 23);
            this.txtGeneratedHash.TabIndex = 6;
            this.txtGeneratedHash.TextChanged += new System.EventHandler(this.GeneratedHash_TextChanged);
            this.txtGeneratedHash.MouseLeave += new System.EventHandler(this.GeneratedHash_MouseLeave);
            this.txtGeneratedHash.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GeneratedHash_MouseMove);
            // 
            // Hash_Code
            // 
            this.Hash_Code.AutoSize = true;
            this.Hash_Code.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hash_Code.Location = new System.Drawing.Point(3, 0);
            this.Hash_Code.Name = "Hash_Code";
            this.Hash_Code.Size = new System.Drawing.Size(76, 16);
            this.Hash_Code.TabIndex = 0;
            this.Hash_Code.Text = "Hash Code";
            this.Hash_Code.Click += new System.EventHandler(this.Hash_Code_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(591, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Generate
            // 
            this.Generate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Generate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Generate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.Location = new System.Drawing.Point(12, 489);
            this.Generate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(166, 66);
            this.Generate.TabIndex = 7;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Compare
            // 
            this.Compare.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Compare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Compare.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compare.Location = new System.Drawing.Point(504, 489);
            this.Compare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(166, 66);
            this.Compare.TabIndex = 8;
            this.Compare.Text = "Compare";
            this.Compare.UseVisualStyleBackColor = true;
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpIsComingToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpIsComingToolStripMenuItem
            // 
            this.helpIsComingToolStripMenuItem.Name = "helpIsComingToolStripMenuItem";
            this.helpIsComingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.helpIsComingToolStripMenuItem.Text = "Help is coming!";
            // 
            // ClearAll
            // 
            this.ClearAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearAll.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAll.Location = new System.Drawing.Point(263, 489);
            this.ClearAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(166, 66);
            this.ClearAll.TabIndex = 9;
            this.ClearAll.Text = "Clear All";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // HashCodeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.Generate;
            this.ClientSize = new System.Drawing.Size(678, 561);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.Compare);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "HashCodeForm1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BACS Hash Code Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HashCodeForm1_FormClosing);
            this.Load += new System.EventHandler(this.HashCodeForm1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Recipient;
        private System.Windows.Forms.Label Originator;
        private System.Windows.Forms.Label PaymentDetails;
        private System.Windows.Forms.TextBox txtPaymentValue;
        private System.Windows.Forms.TextBox txtRecipientSortCode;
        private System.Windows.Forms.TextBox txtOriginatorSortCode;
        private System.Windows.Forms.TextBox txtRandomString;
        private System.Windows.Forms.Label PaymentValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Hash_Code;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txtGeneratedHash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Compare;
        private System.Windows.Forms.Label Advice;
        internal System.Windows.Forms.Label BACSRandomString;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpIsComingToolStripMenuItem;
        private System.Windows.Forms.Label RandomNumber;
        private System.Windows.Forms.TextBox txtRandomNumber;
    }
}

