namespace Login_System
{
    partial class Form4
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgv = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            deadline = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            textDeadline = new TextBox();
            texSubject = new TextBox();
            textName = new TextBox();
            btnDelete = new Button();
            btnAdd = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            buttonRefresh = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { name, subject, deadline });
            dgv.Dock = DockStyle.Right;
            dgv.Location = new Point(518, 0);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(426, 519);
            dgv.TabIndex = 8;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // subject
            // 
            subject.HeaderText = "Subject";
            subject.MinimumWidth = 6;
            subject.Name = "subject";
            subject.ReadOnly = true;
            // 
            // deadline
            // 
            deadline.HeaderText = "Deadline";
            deadline.MinimumWidth = 6;
            deadline.Name = "deadline";
            deadline.ReadOnly = true;
            // 
            // button1
            // 
            button1.ForeColor = Color.DimGray;
            button1.Location = new Point(12, 13);
            button1.Name = "button1";
            button1.Size = new Size(94, 27);
            button1.TabIndex = 9;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(133, 66);
            label1.Name = "label1";
            label1.Size = new Size(229, 60);
            label1.TabIndex = 10;
            label1.Text = "To Do List";
            // 
            // textDeadline
            // 
            textDeadline.Location = new Point(91, 339);
            textDeadline.Multiline = true;
            textDeadline.Name = "textDeadline";
            textDeadline.Size = new Size(341, 47);
            textDeadline.TabIndex = 18;
            // 
            // texSubject
            // 
            texSubject.Location = new Point(91, 245);
            texSubject.Multiline = true;
            texSubject.Name = "texSubject";
            texSubject.Size = new Size(341, 53);
            texSubject.TabIndex = 17;
            texSubject.TextChanged += texSubject_TextChanged;
            // 
            // textName
            // 
            textName.Location = new Point(91, 159);
            textName.Multiline = true;
            textName.Name = "textName";
            textName.Size = new Size(341, 51);
            textName.TabIndex = 16;
            textName.TextChanged += textName_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.DimGray;
            btnDelete.Location = new Point(203, 408);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 32);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.DimGray;
            btnAdd.Location = new Point(91, 408);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 31);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(80, 311);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 13;
            label4.Text = "Deadline";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(80, 217);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 12;
            label3.Text = "Subject";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(80, 131);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 11;
            label2.Text = "Task";
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DimGray;
            button2.Location = new Point(327, 407);
            button2.Name = "button2";
            button2.Size = new Size(106, 32);
            button2.TabIndex = 19;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(203, 460);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(94, 29);
            buttonRefresh.TabIndex = 20;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // button3
            // 
            button3.Location = new Point(244, 12);
            button3.Name = "button3";
            button3.Size = new Size(112, 31);
            button3.TabIndex = 21;
            button3.Text = "Schedule";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(362, 12);
            button4.Name = "button4";
            button4.Size = new Size(129, 31);
            button4.TabIndex = 22;
            button4.Text = "View All Subjects";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(167, 197, 200);
            ClientSize = new Size(944, 519);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(buttonRefresh);
            Controls.Add(button2);
            Controls.Add(textDeadline);
            Controls.Add(texSubject);
            Controls.Add(textName);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Form";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn deadline;
        private Button button1;
        private Label label1;
        private TextBox textDeadline;
        private TextBox texSubject;
        private TextBox textName;
        private Button btnDelete;
        private Button btnAdd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button buttonRefresh;
        private Button button3;
        private Button button4;
    }
}