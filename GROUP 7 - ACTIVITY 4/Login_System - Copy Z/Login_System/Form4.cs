using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_System
{
    public partial class Form4 : Form
    {
        public string loggedInUsername { get; set; }
        private MySqlConnection connection = new MySqlConnection
            ("datasource=localhost;port=3306;username=root;password='';Convert Zero Datetime=True;");

        //  string connectionString = "Server=localhost;Database=your_database;Uid=root;Pwd=your_password;";
        private MySqlCommand command;
        private MySqlDataReader mdr;



        //private string loggedInUsername;
        public Form4(string username)
        {
            InitializeComponent();
            loggedInUsername = username;

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // Load tasks from the database when the form is loaded
            LoadTasksFromDatabase();
            dgv.Sort(dgv.Columns["deadline"], ListSortDirection.Ascending);
        }

        private void LoadTasksFromDatabase()
        {


        }


        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginPage = new Form1();
            loginPage.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(textDeadline.Text, out DateTime deadline))
            {
                try
                {

                    connection.Open();

                    string insertQuery = $"INSERT INTO loginportal.tasks (username, name, subject, deadline) VALUES ('{loggedInUsername}', '{textName.Text}', '{texSubject.Text}', '{textDeadline.Text}');";
                    command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue($"{textDeadline}", DateTime.Parse(deadline.ToString("yyyy-MM-dd")));
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving task to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }

                textName.Clear();
                texSubject.Clear();
                textDeadline.Clear();
            }
            else
            {
                MessageBox.Show("Invalid deadline format. Please enter a valid date (YYYY-MM-DD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                string rowUsername = dgv.CurrentRow.Cells["username"].Value.ToString();

                // Check if the data belongs to the logged-in user
                if (rowUsername == loggedInUsername)
                {
                    textName.Text = dgv.CurrentRow.Cells["name"].Value.ToString();
                    texSubject.Text = dgv.CurrentRow.Cells["subject"].Value.ToString();
                    textDeadline.Text = dgv.CurrentRow.Cells["deadline"].Value.ToString();
                }
                else
                {
                    // Clear the fields if the data doesn't belong to the logged-in user
                    textName.Clear();
                    texSubject.Clear();
                    textDeadline.Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                int selectedIndex = dgv.CurrentRow.Index;
                string selectedTaskName = dgv.CurrentRow.Cells["name"].Value.ToString();

                try
                {
                    connection.Open();

                    // Delete the task from the database
                    string deleteQuery = $"DELETE FROM loginportal.tasks WHERE username = '{loggedInUsername}' AND name = '{selectedTaskName}'";
                    command = new MySqlCommand(deleteQuery, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting task from database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }

                // Remove the selected row from the DataGridView
                dgv.Rows.RemoveAt(selectedIndex);
            }

        }
        private void button2_Click(object sender, EventArgs e)//EDIT BUTTON
        {
            if (dgv.CurrentRow != null)
            {
                dgv.CurrentRow.Cells["name"].Value = textName.Text;
                dgv.CurrentRow.Cells["subject"].Value = texSubject.Text;
                dgv.CurrentRow.Cells["deadline"].Value = textDeadline.Text;

            }
        }

        private void texSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                dgv.Rows.Clear();
                // Select tasks for the logged-in user from the database
                string selectQuery = $"SELECT * FROM loginportal.tasks WHERE username = '{loggedInUsername}'";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();

                while (mdr.Read())
                {
                    // Retrieve the DateTime value directly using GetDateTime
                    DateTime deadline = mdr.GetDateTime("deadline");

                    // Add tasks to the DataGridView
                    dgv.Rows.Add(mdr["name"].ToString(), mdr["subject"].ToString(), deadline.ToShortDateString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tasks from database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

