﻿namespace Login_System
{
    partial class Form2
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label6 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(110, 139);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Username: ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(167, 197, 200);
            textBox1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(266, 122);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 43);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(167, 197, 200);
            textBox2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(266, 193);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 43);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(110, 209);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(167, 197, 200);
            textBox3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(266, 262);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(234, 43);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(110, 279);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "First Name";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(167, 197, 200);
            textBox4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(266, 334);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(234, 43);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(110, 351);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 6;
            label4.Text = "Last Name";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(167, 197, 200);
            textBox5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(266, 405);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(234, 43);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(110, 422);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 8;
            label5.Text = "Address";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(167, 197, 200);
            button1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(140, 494);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(152, 40);
            button1.TabIndex = 10;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(167, 197, 200);
            button2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(326, 494);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(152, 40);
            button2.TabIndex = 11;
            button2.Text = "Back to Login Page";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(115, 142, 146);
            label6.Location = new Point(140, 20);
            label6.Name = "label6";
            label6.Size = new Size(338, 60);
            label6.TabIndex = 12;
            label6.Text = "REGISTRATION";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(167, 197, 200);
            panel1.Location = new Point(128, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 10);
            panel1.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(609, 569);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Account";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Button button1;
        private Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label6;
        private Panel panel1;
    }
}