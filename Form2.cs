using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace Skills
{
    public partial class Form2 : Form
    {
        string connectionString = "Data Source=LAPTOP-VCUT421O\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;Encrypt=False";

        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadStudentRegistrationNumbers();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LoadStudentRegistrationNumbers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT regNo FROM Registration";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbRegNo.Items.Add(reader["regNo"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {

            string firstName = txtFirstname.Text;
            string lastName = txtLastname.Text;
            DateTime dateOfBirth = dtimePicker.Value;

            string gender = "";
            if (radioMale.Checked)
            {
                gender = "Male";
            }
            else if (radioFemale.Checked)
            {
                gender = "Female";
            }

            string address = txtAddress.Text;
            string email = txtEmail.Text;
            string mobilePhone = txtPhoneNumber.Text;
            string homePhone = txtHomeNumber.Text;
            string parentName = txtParentname.Text;
            string nic = txtNIC.Text;
            string contactNo = txtContactNumber.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Registration (firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) " +
                                         "VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @Address, @Email, @MobilePhone, @HomePhone, @ParentName, @NIC, @ContactNo)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@MobilePhone", mobilePhone);
                        cmd.Parameters.AddWithValue("@HomePhone", homePhone);
                        cmd.Parameters.AddWithValue("@ParentName", parentName);
                        cmd.Parameters.AddWithValue("@NIC", nic);
                        cmd.Parameters.AddWithValue("@ContactNo", contactNo);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student data saved successfully!");
                            cmbRegNo.Items.Clear();
                            LoadStudentRegistrationNumbers();
                        }
                        else
                        {
                            MessageBox.Show("Error: Unable to save student data.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedIndex != -1)
            {
                string selectedRegNo = cmbRegNo.SelectedItem.ToString();
                PopulateStudentData(selectedRegNo);
            }
        }

        private void PopulateStudentData(string regNo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Registration WHERE regNo = @RegNo";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@RegNo", regNo);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtFirstname.Text = reader["firstName"].ToString();
                        txtLastname.Text = reader["lastName"].ToString();
                        dtimePicker.Value = Convert.ToDateTime(reader["dateOfBirth"]);

                        string gender = reader["gender"].ToString();
                        SetGenderRadioButton(gender);

                        txtAddress.Text = reader["address"].ToString();
                        txtEmail.Text = reader["email"].ToString();
                        txtPhoneNumber.Text = reader["mobilePhone"].ToString();
                        txtHomeNumber.Text = reader["homePhone"].ToString();
                        txtParentname.Text = reader["parentName"].ToString();
                        txtNIC.Text = reader["nic"].ToString();
                        txtContactNumber.Text = reader["contactNo"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void SetGenderRadioButton(string gender)
        {
            if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
            {
                radioMale.Checked = true;
            }
            else if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
            {
                radioFemale.Checked = true;
            }
            else
            {
                radioMale.Checked = false;
                radioFemale.Checked = false;
            }
        }


        private void UpdateStudentData(string regNo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE Registration " +
                                         "SET firstName = @FirstName, " +
                                         "lastName = @LastName, " +
                                         "dateOfBirth = @DateOfBirth, " +
                                         "gender = @Gender, " +
                                         "address = @Address, " +
                                         "email = @Email, " +
                                         "mobilePhone = @MobilePhone, " +
                                         "homePhone = @HomePhone, " +
                                         "parentName = @ParentName, " +
                                         "nic = @NIC, " +
                                         "contactNo = @ContactNo " +
                                         "WHERE regNo = @RegNo";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstname.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtLastname.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dtimePicker.Value);
                        cmd.Parameters.AddWithValue("@Gender", cmbRegNo.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@MobilePhone", txtPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@HomePhone", txtHomeNumber.Text);
                        cmd.Parameters.AddWithValue("@ParentName", txtParentname.Text);
                        cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
                        cmd.Parameters.AddWithValue("@ContactNo", txtContactNumber.Text);
                        cmd.Parameters.AddWithValue("@RegNo", regNo);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student data updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Error: Unable to update student data.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedIndex != -1)
            {
                string selectedRegNo = cmbRegNo.SelectedItem.ToString();
                UpdateStudentData(selectedRegNo);
            }
        }

        private void DeleteStudent(string regNo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Registration WHERE regNo = @RegNo";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@RegNo", regNo);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student deleted successfully!");
                            // Clear input fields or reset the form if needed
                            ClearInputFields();
                            // Refresh the ComboBox after deleting the student
                            cmbRegNo.Items.Clear();
                            LoadStudentRegistrationNumbers();
                        }
                        else
                        {
                            MessageBox.Show("Error: Unable to delete student.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedIndex != -1)
            {
                string selectedRegNo = cmbRegNo.SelectedItem.ToString();
                DeleteStudent(selectedRegNo);
            }
        }

        private void ClearInputFields()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            dtimePicker.Value = DateTime.Now;
            cmbRegNo.SelectedIndex = -1;
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtHomeNumber.Text = "";
            txtParentname.Text = "";
            txtNIC.Text = "";
            txtContactNumber.Text = "";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Close();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}
