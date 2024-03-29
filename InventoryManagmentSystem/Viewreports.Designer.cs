
namespace InventoryManagmentSystem
{
    partial class Viewreports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewreports));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reportIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDBDataSet1 = new InventoryManagmentSystem.EmpDBDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.empDBDataSet = new InventoryManagmentSystem.EmpDBDataSet();
            this.empDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new InventoryManagmentSystem.EmpDBDataSet1TableAdapters.InventoryTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.frequencyDataGridViewTextBoxColumn,
            this.bownerDataGridViewTextBoxColumn,
            this.cartownerDataGridViewTextBoxColumn,
            this.reporttypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(76, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1051, 296);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reportIdDataGridViewTextBoxColumn
            // 
            this.reportIdDataGridViewTextBoxColumn.DataPropertyName = "Report_Id";
            this.reportIdDataGridViewTextBoxColumn.HeaderText = "Report_Id";
            this.reportIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reportIdDataGridViewTextBoxColumn.Name = "reportIdDataGridViewTextBoxColumn";
            this.reportIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.reportIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // frequencyDataGridViewTextBoxColumn
            // 
            this.frequencyDataGridViewTextBoxColumn.DataPropertyName = "frequency";
            this.frequencyDataGridViewTextBoxColumn.HeaderText = "frequency";
            this.frequencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.frequencyDataGridViewTextBoxColumn.Name = "frequencyDataGridViewTextBoxColumn";
            this.frequencyDataGridViewTextBoxColumn.ReadOnly = true;
            this.frequencyDataGridViewTextBoxColumn.Width = 125;
            // 
            // bownerDataGridViewTextBoxColumn
            // 
            this.bownerDataGridViewTextBoxColumn.DataPropertyName = "B_owner";
            this.bownerDataGridViewTextBoxColumn.HeaderText = "B_owner";
            this.bownerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bownerDataGridViewTextBoxColumn.Name = "bownerDataGridViewTextBoxColumn";
            this.bownerDataGridViewTextBoxColumn.ReadOnly = true;
            this.bownerDataGridViewTextBoxColumn.Width = 125;
            // 
            // cartownerDataGridViewTextBoxColumn
            // 
            this.cartownerDataGridViewTextBoxColumn.DataPropertyName = "Cart_owner";
            this.cartownerDataGridViewTextBoxColumn.HeaderText = "Cart_owner";
            this.cartownerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cartownerDataGridViewTextBoxColumn.Name = "cartownerDataGridViewTextBoxColumn";
            this.cartownerDataGridViewTextBoxColumn.ReadOnly = true;
            this.cartownerDataGridViewTextBoxColumn.Width = 125;
            // 
            // reporttypeDataGridViewTextBoxColumn
            // 
            this.reporttypeDataGridViewTextBoxColumn.DataPropertyName = "Report_type";
            this.reporttypeDataGridViewTextBoxColumn.HeaderText = "Report_type";
            this.reporttypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reporttypeDataGridViewTextBoxColumn.Name = "reporttypeDataGridViewTextBoxColumn";
            this.reporttypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.reporttypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.empDBDataSet1;
            // 
            // empDBDataSet1
            // 
            this.empDBDataSet1.DataSetName = "EmpDBDataSet1";
            this.empDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(538, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "View The  Reports";
            // 
            // empDBDataSet
            // 
            this.empDBDataSet.DataSetName = "EmpDBDataSet";
            this.empDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empDBDataSetBindingSource
            // 
            this.empDBDataSetBindingSource.DataSource = this.empDBDataSet;
            this.empDBDataSetBindingSource.Position = 0;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(619, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 37);
            this.button1.TabIndex = 30;
            this.button1.Text = "DOWNLOAD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Viewreports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1341, 737);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Viewreports";
            this.Text = "Viewreports";
            this.Load += new System.EventHandler(this.Viewreports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource empDBDataSetBindingSource;
        private EmpDBDataSet empDBDataSet;
        private EmpDBDataSet1 empDBDataSet1;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private EmpDBDataSet1TableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reporttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}