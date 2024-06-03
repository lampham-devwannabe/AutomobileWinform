namespace LAB1_AutomobileWinform
{
    partial class frmCarManagement
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
            lbPrice = new Label();
            lbCarName = new Label();
            lbReleaseYear = new Label();
            lbCarID = new Label();
            label5 = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtManufacturer = new TextBox();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            lbManufacturer = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(342, 42);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 0;
            lbPrice.Text = "Price";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(64, 79);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 0;
            lbCarName.Text = "Car Name";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(342, 79);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(71, 15);
            lbReleaseYear.TabIndex = 0;
            lbReleaseYear.Text = "Release Year";
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(64, 40);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(39, 15);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 5;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(149, 37);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(170, 23);
            txtCarID.TabIndex = 1;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(149, 79);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(170, 23);
            txtCarName.TabIndex = 1;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(149, 124);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(170, 23);
            txtManufacturer.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(419, 37);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(170, 23);
            txtPrice.TabIndex = 1;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(419, 76);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(170, 23);
            txtReleaseYear.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(140, 177);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(283, 177);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(437, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(12, 206);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(629, 212);
            dgvCarList.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(283, 424);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(64, 127);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 0;
            lbManufacturer.Text = "Manufacturer";
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 450);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(label5);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Controls.Add(lbPrice);
            MaximizeBox = false;
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPrice;
        private Label lbCarName;
        private Label lbReleaseYear;
        private Label lbCarID;
        private Label label5;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private TextBox txtManufacturer;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private Button btnClose;
        private Label lbManufacturer;
    }
}