
namespace InventoryManagmentSystem
{
    partial class NewRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRequest));
            this.Title = new System.Windows.Forms.TextBox();
            this.ReportType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BU_Owner = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Frequency = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CART_Owner = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Report_Status = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TO = new System.Windows.Forms.TextBox();
            this.CC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BU_Approver = new System.Windows.Forms.ComboBox();
            this.CART_Approver = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Attachments = new System.Windows.Forms.TextBox();
            this.Attach = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.empDBDataSet1 = new InventoryManagmentSystem.EmpDBDataSet1();
            this.empDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDBDataSet2 = new InventoryManagmentSystem.EmpDBDataSet2();
            this.empdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empdataTableAdapter = new InventoryManagmentSystem.EmpDBDataSet2TableAdapters.empdataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.Location = new System.Drawing.Point(89, 95);
            this.Title.Margin = new System.Windows.Forms.Padding(4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(689, 22);
            this.Title.TabIndex = 18;
            this.Title.TextChanged += new System.EventHandler(this.titile_TextChanged_1);
            // 
            // ReportType
            // 
            this.ReportType.BackColor = System.Drawing.Color.Lavender;
            this.ReportType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReportType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportType.FormattingEnabled = true;
            this.ReportType.Items.AddRange(new object[] {
            "Operations Report",
            "Executive Report",
            "Client Report"});
            this.ReportType.Location = new System.Drawing.Point(961, 102);
            this.ReportType.Margin = new System.Windows.Forms.Padding(4);
            this.ReportType.Name = "ReportType";
            this.ReportType.Size = new System.Drawing.Size(295, 36);
            this.ReportType.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(87, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Report status";
            // 
            // Comment
            // 
            this.Comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Comment.Location = new System.Drawing.Point(89, 559);
            this.Comment.Margin = new System.Windows.Forms.Padding(4);
            this.Comment.Multiline = true;
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(411, 65);
            this.Comment.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(87, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "BU Owner";
            // 
            // BU_Owner
            // 
            this.BU_Owner.BackColor = System.Drawing.Color.Lavender;
            this.BU_Owner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BU_Owner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BU_Owner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BU_Owner.FormattingEnabled = true;
            this.BU_Owner.Location = new System.Drawing.Point(86, 282);
            this.BU_Owner.Margin = new System.Windows.Forms.Padding(4);
            this.BU_Owner.Name = "BU_Owner";
            this.BU_Owner.Size = new System.Drawing.Size(295, 36);
            this.BU_Owner.TabIndex = 26;
            this.BU_Owner.SelectedIndexChanged += new System.EventHandler(this.BU_Owner_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(961, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Frquency";
            // 
            // Frequency
            // 
            this.Frequency.BackColor = System.Drawing.Color.Lavender;
            this.Frequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Frequency.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Frequency.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frequency.FormattingEnabled = true;
            this.Frequency.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Bi Weekly",
            "Monthly",
            "Yearly"});
            this.Frequency.Location = new System.Drawing.Point(962, 193);
            this.Frequency.Margin = new System.Windows.Forms.Padding(4);
            this.Frequency.Name = "Frequency";
            this.Frequency.Size = new System.Drawing.Size(295, 36);
            this.Frequency.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(958, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Report Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(87, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(87, 523);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "Comment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(87, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 23);
            this.label8.TabIndex = 34;
            this.label8.Text = "CART Owner";
            // 
            // CART_Owner
            // 
            this.CART_Owner.BackColor = System.Drawing.Color.Lavender;
            this.CART_Owner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CART_Owner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CART_Owner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CART_Owner.FormattingEnabled = true;
            this.CART_Owner.Location = new System.Drawing.Point(89, 383);
            this.CART_Owner.Margin = new System.Windows.Forms.Padding(4);
            this.CART_Owner.Name = "CART_Owner";
            this.CART_Owner.Size = new System.Drawing.Size(295, 36);
            this.CART_Owner.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Report_Status
            // 
            this.Report_Status.BackColor = System.Drawing.Color.Lavender;
            this.Report_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Report_Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Report_Status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report_Status.FormattingEnabled = true;
            this.Report_Status.Items.AddRange(new object[] {
            "Automated",
            "Manual",
            "Semi Automated"});
            this.Report_Status.Location = new System.Drawing.Point(91, 193);
            this.Report_Status.Margin = new System.Windows.Forms.Padding(4);
            this.Report_Status.Name = "Report_Status";
            this.Report_Status.Size = new System.Drawing.Size(295, 36);
            this.Report_Status.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(85, 453);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 23);
            this.label9.TabIndex = 40;
            this.label9.Text = "TO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumBlue;
            this.label10.Location = new System.Drawing.Point(781, 453);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 23);
            this.label10.TabIndex = 41;
            this.label10.Text = "CC";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // TO
            // 
            this.TO.Location = new System.Drawing.Point(86, 480);
            this.TO.Multiline = true;
            this.TO.Name = "TO";
            this.TO.Size = new System.Drawing.Size(501, 22);
            this.TO.TabIndex = 42;
            // 
            // CC
            // 
            this.CC.Location = new System.Drawing.Point(785, 480);
            this.CC.Multiline = true;
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(419, 22);
            this.CC.TabIndex = 43;
            this.CC.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumBlue;
            this.label11.Location = new System.Drawing.Point(521, 255);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 23);
            this.label11.TabIndex = 44;
            this.label11.Text = "BU Approver";
            // 
            // BU_Approver
            // 
            this.BU_Approver.BackColor = System.Drawing.Color.Lavender;
            this.BU_Approver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BU_Approver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BU_Approver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BU_Approver.FormattingEnabled = true;
            this.BU_Approver.Location = new System.Drawing.Point(515, 282);
            this.BU_Approver.Margin = new System.Windows.Forms.Padding(4);
            this.BU_Approver.Name = "BU_Approver";
            this.BU_Approver.Size = new System.Drawing.Size(295, 36);
            this.BU_Approver.TabIndex = 45;
            this.BU_Approver.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // CART_Approver
            // 
            this.CART_Approver.BackColor = System.Drawing.Color.Lavender;
            this.CART_Approver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CART_Approver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CART_Approver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CART_Approver.FormattingEnabled = true;
            this.CART_Approver.Location = new System.Drawing.Point(515, 383);
            this.CART_Approver.Margin = new System.Windows.Forms.Padding(4);
            this.CART_Approver.Name = "CART_Approver";
            this.CART_Approver.Size = new System.Drawing.Size(295, 36);
            this.CART_Approver.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MediumBlue;
            this.label12.Location = new System.Drawing.Point(521, 356);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 23);
            this.label12.TabIndex = 47;
            this.label12.Text = "CART Approver";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(812, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 36);
            this.button1.TabIndex = 48;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1089, 643);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 36);
            this.button2.TabIndex = 49;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Attachments
            // 
            this.Attachments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Attachments.Location = new System.Drawing.Point(624, 559);
            this.Attachments.Margin = new System.Windows.Forms.Padding(4);
            this.Attachments.Multiline = true;
            this.Attachments.Name = "Attachments";
            this.Attachments.Size = new System.Drawing.Size(411, 65);
            this.Attachments.TabIndex = 50;
            // 
            // Attach
            // 
            this.Attach.AutoSize = true;
            this.Attach.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attach.ForeColor = System.Drawing.Color.MediumBlue;
            this.Attach.Location = new System.Drawing.Point(635, 523);
            this.Attach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(112, 23);
            this.Attach.TabIndex = 51;
            this.Attach.Text = "Attachments";
            // 
            // Location
            // 
            this.Location.BackColor = System.Drawing.Color.Lavender;
            this.Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Location.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Location.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location.FormattingEnabled = true;
            this.Location.Items.AddRange(new object[] {
            "Onshore",
            "Offshore"});
            this.Location.Location = new System.Drawing.Point(961, 282);
            this.Location.Margin = new System.Windows.Forms.Padding(4);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(295, 36);
            this.Location.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(961, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "Onshore/Offshore";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // empDBDataSet1
            // 
            this.empDBDataSet1.DataSetName = "EmpDBDataSet1";
            this.empDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empDBDataSet1BindingSource
            // 
            this.empDBDataSet1BindingSource.DataSource = this.empDBDataSet1;
            this.empDBDataSet1BindingSource.Position = 0;
            // 
            // empDBDataSet2
            // 
            this.empDBDataSet2.DataSetName = "EmpDBDataSet2";
            this.empDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empdataBindingSource
            // 
            this.empdataBindingSource.DataMember = "empdata";
            this.empdataBindingSource.DataSource = this.empDBDataSet2;
            // 
            // empdataTableAdapter
            // 
            this.empdataTableAdapter.ClearBeforeFill = true;
            // 
            // NewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1341, 737);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.Attach);
            this.Controls.Add(this.Attachments);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CART_Approver);
            this.Controls.Add(this.BU_Approver);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.TO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Report_Status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CART_Owner);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ReportType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BU_Owner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Frequency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewRequest";
            this.Text = "CART Approver";
            this.Load += new System.EventHandler(this.NewRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.ComboBox ReportType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Comment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BU_Owner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Frequency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CART_Owner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Report_Status;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TO;
        private System.Windows.Forms.TextBox CC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox BU_Approver;
        private System.Windows.Forms.ComboBox CART_Approver;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Attachments;
        private System.Windows.Forms.Label Attach;
        private System.Windows.Forms.ComboBox Location;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource empDBDataSet1BindingSource;
        private EmpDBDataSet1 empDBDataSet1;
        private EmpDBDataSet2 empDBDataSet2;
        private System.Windows.Forms.BindingSource empdataBindingSource;
        private EmpDBDataSet2TableAdapters.empdataTableAdapter empdataTableAdapter;
    }
}