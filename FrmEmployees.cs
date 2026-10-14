
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace C__database_me_Chapter17
{
    public partial class FrmEmployees : Form
    {
        // SQL Server LocalDB connection
        private readonly string connectionString =
            @"Server=(localdb)\MSSQLLocalDB;" +
            "Database=EmployeeDepartmentDB;" +
            "Integrated Security=True;" +
            "TrustServerCertificate=True;";

        // Constructor
        public FrmEmployees()
        {
            InitializeComponent();

            // Connect event handlers
            Load += FrmEmployees_Load;
            btnSave.Click += btnSave_Click;
        }

        // Load departments into ComboBox
        private void LoadDepartments()
        {
            string sql =
                "SELECT DepartmentID, DepartmentName " +
                "FROM Departments " +
                "ORDER BY DepartmentName";

            using (SqlConnection con =
                new SqlConnection(connectionString))
            using (SqlDataAdapter da =
                new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbDepartment.DisplayMember = "DepartmentName";
                cmbDepartment.ValueMember = "DepartmentID";
                cmbDepartment.DataSource = dt;

                // No department selected initially
                cmbDepartment.SelectedIndex = -1;
            }
        }

        // Load employees into DataGridView
        private void LoadEmployees()
        {
            string sql =
                "SELECT E.EmployeeID, " +
                "E.EmployeeName, " +
                "D.DepartmentName, " +
                "E.PhoneNumber " +
                "FROM Employees E " +
                "INNER JOIN Departments D " +
                "ON E.DepartmentID = D.DepartmentID " +
                "ORDER BY E.EmployeeID";

            using (SqlConnection con =
                new SqlConnection(connectionString))
            using (SqlDataAdapter da =
                new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvEmployees.DataSource = dt;

                dgvEmployees.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvEmployees.ReadOnly = true;
                dgvEmployees.AllowUserToAddRows = false;
                dgvEmployees.AllowUserToDeleteRows = false;
                dgvEmployees.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
            }
        }

        // Form Load event
        private void FrmEmployees_Load(
            object? sender, EventArgs e)
        {
            try
            {
                LoadDepartments();
                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load data:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Save Employee button
        private void btnSave_Click(
            object? sender, EventArgs e)
        {
            // Validate employee name
            if (string.IsNullOrWhiteSpace(
                txtEmployeeName.Text))
            {
                MessageBox.Show(
                    "Please enter employee name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmployeeName.Focus();
                return;
            }

            // Validate department selection
            if (cmbDepartment.SelectedIndex == -1 ||
                cmbDepartment.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please select a department.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbDepartment.Focus();
                return;
            }

            // Retrieve entered values
            string employeeName =
                txtEmployeeName.Text.Trim();

            string phoneNumber =
                txtPhoneNumber.Text.Trim();

            int departmentID =
                Convert.ToInt32(
                    cmbDepartment.SelectedValue);

            // SQL INSERT statement
            string sql =
                "INSERT INTO Employees " +
                "(EmployeeName, DepartmentID, PhoneNumber) " +
                "VALUES (@EmployeeName, " +
                "@DepartmentID, @PhoneNumber)";

            try
            {
                using (SqlConnection con =
                    new SqlConnection(connectionString))
                using (SqlCommand cmd =
                    new SqlCommand(sql, con))
                {
                    // Employee Name parameter
                    cmd.Parameters.Add(
                        "@EmployeeName",
                        SqlDbType.NVarChar,
                        100).Value = employeeName;

                    // Department ID parameter
                    cmd.Parameters.Add(
                        "@DepartmentID",
                        SqlDbType.Int).Value = departmentID;

                    // Phone Number parameter
                    cmd.Parameters.Add(
                        "@PhoneNumber",
                        SqlDbType.NVarChar,
                        30).Value =
                        string.IsNullOrWhiteSpace(phoneNumber)
                        ? DBNull.Value
                        : phoneNumber;

                    con.Open();

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Employee saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Clear input fields
                txtEmployeeName.Clear();
                txtPhoneNumber.Clear();
                cmbDepartment.SelectedIndex = -1;

                // Refresh employee grid
                LoadEmployees();

                txtEmployeeName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving employee:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
