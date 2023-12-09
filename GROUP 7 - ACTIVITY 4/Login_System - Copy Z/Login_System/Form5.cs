using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login_System
{
    public partial class Form5 : Form
    {
        public string loggedInUsername { get; set; }
        private MySqlConnection connection = new MySqlConnection
        ("datasource=localhost;port=3306;username=root;password='';");
        private MySqlCommand command;
        private MySqlDataReader mdr;

        public Form5()
        {
            InitializeComponent();
            label6.Text = Form1.username;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadTasksFromDatabase();

        }
        private void LoadTasksFromDatabase()
        {


        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (dgv.CurrentRow != null)
            {
                string rowUsername = dgv.CurrentRow.Cells["username"].Value.ToString();

                // Check if the data belongs to the logged-in user
                if (rowUsername == loggedInUsername)
                {
                    txtID.Text = dgv.CurrentRow.Cells["courseid"].Value.ToString();
                    txtName.Text = dgv.CurrentRow.Cells["subjectname"].Value.ToString();
                    txtTime.Text = dgv.CurrentRow.Cells["time_"].Value.ToString();
                    txtRoom.Text = dgv.CurrentRow.Cells["room"].Value.ToString();
                    txtInstructor.Text = dgv.CurrentRow.Cells["instructor"].Value.ToString();
                }
                else
                {
                    // Clear the fields if the data doesn't belong to the logged-in user
                    txtID.Clear();
                    txtName.Clear();
                    txtTime.Clear();
                    txtRoom.Clear();
                    txtInstructor.Clear();

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                connection.Open(); // Open the connection

                // Validate if txtID.Text is a valid integer
                if (int.TryParse(txtID.Text, out int courseId))
                {
                    string query = "INSERT INTO loginportal.schedule1 (username, subjectName, instructor, room, time_) VALUES (@user, @subject, @instructor, @room, @time)";
                    using (MySqlCommand comm = new MySqlCommand(query, connection))
                    {
                        comm.Parameters.AddWithValue("@user", label6.Text);
                        comm.Parameters.AddWithValue("@subject", txtName.Text);
                        comm.Parameters.AddWithValue("@instructor", txtInstructor.Text);
                        comm.Parameters.AddWithValue("@room", txtRoom.Text);
                        comm.Parameters.AddWithValue("@time", txtTime.Text);

                        dgv.Rows.Add(txtID.Text, txtName.Text, txtRoom.Text, txtTime.Text, txtInstructor.Text);

                        int rowsAffected = comm.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Saved Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No rows were affected. Data not saved.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Course ID. Please enter a valid integer.");
                }
            }

            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connection.Close(); // Close the connection in a finally block
            }
            txtName.Clear();
            txtRoom.Clear();
            txtTime.Clear();
            txtRoom.Clear();
            txtInstructor.Clear();
        }





        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgv.SelectedRows.Count > 0)
            {
                dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];

                // Assuming that the columns are in the order of ID, Name, Time, Room, Instructor
                txtID.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                txtTime.Text = selectedRow.Cells[2].Value.ToString();
                txtRoom.Text = selectedRow.Cells[3].Value.ToString();
                txtInstructor.Text = selectedRow.Cells[4].Value.ToString();

                // Remove the selected row from the DataGridView
                dgv.Rows.RemoveAt(selectedRow.Index);
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

