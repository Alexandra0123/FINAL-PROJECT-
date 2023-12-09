namespace Login_System
{
    partial class Form1
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
            loginButton = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(167, 197, 200);
            loginButton.Location = new Point(70, 271);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(135, 35);
            loginButton.TabIndex = 0;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(167, 197, 200);
            button2.Location = new Point(228, 271);
            button2.Name = "button2";
            button2.Size = new Size(140, 35);
            button2.TabIndex = 1;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 85);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 2;
            label1.Text = "Username: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 169);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 3;
            label2.Text = "Password: ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(167, 197, 200);
            textBox1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(142, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 47);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(167, 197, 200);
            textBox2.Font = new Font("Segoe UI Historic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(142, 149);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(226, 47);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(112, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 347);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(115, 142, 146);
            label3.Location = new Point(183, 26);
            label3.Name = "label3";
            label3.Size = new Size(281, 60);
            label3.TabIndex = 7;
            label3.Text = "USER LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(648, 497);
            Controls.Add(label3);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login System";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Label label3;
    }
}