using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_System
{
    public partial class Form3 : Form
    {
        public string loggedInUsername {  get; set; }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginPage = new Form1();
            loginPage.ShowDialog();
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    if (DateTime.TryParse(textDeadline.Text, out DateTime deadline))
        //    {
        //        // Add a new row with the entered information
        //        dgv.Rows.Add(textName.Text, texSubject.Text, deadline.ToShortDateString());

        //        // Sort the DataGridView based on the "deadline" column to prioritize closest date
        //        dgv.Sort(dgv.Columns["deadline"], ListSortDirection.Ascending);

        //        // Clear the input fields after adding
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid deadline format. Please enter a valid date (Month, Day, Year).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    dgv.Rows.Add(textName.Text, texSubject.Text, textDeadline.Text);
        //}
        //private void dgv_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgv.CurrentRow != null)
        //    {
        //        textName.Text = dgv.CurrentRow.Cells["name"].Value.ToString();
        //        textName.Text = dgv.CurrentRow.Cells["subject"].Value.ToString();
        //        textName.Text = dgv.CurrentRow.Cells["deadline"].Value.ToString();
        //    }
        //}
        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (dgv.CurrentRow != null)
        //    {
        //        dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
