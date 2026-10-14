namespace C__database_me_Chapter17
{
    partial class FrmEmployees
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
            lblTitle = new Label();
            lblEmployeeName = new Label();
            txtEmployeeName = new TextBox();
            lblDepartment = new Label();
            cmbDepartment = new ComboBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            btnSave = new Button();
            dgvEmployees = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(179, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(356, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Employee Department Management";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(99, 113);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(119, 20);
            lblEmployeeName.TabIndex = 1;
            lblEmployeeName.Text = "Employee Name";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(99, 147);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(216, 27);
            txtEmployeeName.TabIndex = 2;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(572, 113);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(89, 20);
            lblDepartment.TabIndex = 1;
            lblDepartment.Text = "Department";
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(572, 157);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(181, 28);
            cmbDepartment.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(99, 192);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(112, 20);
            lblPhoneNumber.TabIndex = 1;
            lblPhoneNumber.Text = "Phone Number ";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(106, 236);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(185, 27);
            txtPhoneNumber.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(572, 217);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 31);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Employee";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(99, 337);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(631, 154);
            dgvEmployees.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 297);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 1;
            label1.Text = "Employee Records";
            // 
            // FrmEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(dgvEmployees);
            Controls.Add(btnSave);
            Controls.Add(txtPhoneNumber);
            Controls.Add(cmbDepartment);
            Controls.Add(txtEmployeeName);
            Controls.Add(label1);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblDepartment);
            Controls.Add(lblEmployeeName);
            Controls.Add(lblTitle);
            Name = "FrmEmployees";
            Text = "Employee Department Management";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblEmployeeName;
        private TextBox txtEmployeeName;
        private Label lblDepartment;
        private ComboBox cmbDepartment;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Button btnSave;
        private DataGridView dgvEmployees;
        private Label label1;
    }
}
