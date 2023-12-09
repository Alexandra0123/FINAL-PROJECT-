namespace Login_System
{
    partial class Form5
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
            dgv = new DataGridView();
            txtID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtRoom = new TextBox();
            label4 = new Label();
            txtTime = new TextBox();
            label5 = new Label();
            txtInstructor = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label6 = new Label();
            course_id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            room_ = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            instructor_ = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ControlLightLight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { course_id, name, room_, time, instructor_ });
            dgv.Location = new Point(0, 243);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(912, 329);
            dgv.TabIndex = 0;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // txtID
            // 
            txtID.Location = new Point(150, 39);
            txtID.Name = "txtID";
            txtID.Size = new Size(265, 27);
            txtID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 39);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "Course ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 91);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 4;
            label2.Text = "Subject Name :";
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 27);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 140);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 6;
            label3.Text = "Room :";
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(150, 140);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(265, 27);
            txtRoom.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(463, 39);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 8;
            label4.Text = "Time :";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(571, 39);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(265, 27);
            txtTime.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(463, 81);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 10;
            label5.Text = "Instructor :";
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(571, 81);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.Size = new Size(265, 27);
            txtInstructor.TabIndex = 9;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(731, 131);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(665, 175);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(590, 131);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(850, 9);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 15;
            label6.Visible = false;
            // 
            // course_id
            // 
            course_id.HeaderText = "Course ID";
            course_id.MinimumWidth = 6;
            course_id.Name = "course_id";
            // 
            // name
            // 
            name.HeaderText = "Subject Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 250;
            // 
            // room_
            // 
            room_.HeaderText = "Room";
            room_.MinimumWidth = 6;
            room_.Name = "room_";
            room_.Width = 160;
            // 
            // time
            // 
            time.HeaderText = "Time";
            time.MinimumWidth = 6;
            time.Name = "time";
            time.Width = 125;
            // 
            // instructor_
            // 
            instructor_.HeaderText = "Instructor";
            instructor_.MinimumWidth = 6;
            instructor_.Name = "instructor_";
            instructor_.Width = 250;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(167, 197, 200);
            ClientSize = new Size(911, 568);
            Controls.Add(label6);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(label5);
            Controls.Add(txtInstructor);
            Controls.Add(label4);
            Controls.Add(txtTime);
            Controls.Add(label3);
            Controls.Add(txtRoom);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(dgv);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private TextBox txtID;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtRoom;
        private Label label4;
        private TextBox txtTime;
        private Label label5;
        private TextBox txtInstructor;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridViewTextBoxColumn courseid;
        private DataGridViewTextBoxColumn subjectname;
        private DataGridViewTextBoxColumn room;
        private DataGridViewTextBoxColumn time_;
        private DataGridViewTextBoxColumn instructor;
        private Label label6;
        private DataGridViewTextBoxColumn course_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn room_;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn instructor_;
    }
}