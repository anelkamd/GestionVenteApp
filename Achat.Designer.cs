﻿namespace GestionVenteApp
{
    partial class Achat
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
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 101);
            label1.Name = "label1";
            label1.Size = new Size(149, 31);
            label1.TabIndex = 0;
            label1.Text = "Code Article :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(110, 373);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(435, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 270);
            label2.Name = "label2";
            label2.Size = new Size(146, 31);
            label2.TabIndex = 4;
            label2.Text = "Prix Unitaire :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 212);
            label3.Name = "label3";
            label3.Size = new Size(146, 31);
            label3.TabIndex = 5;
            label3.Text = "Designation :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 160);
            label4.Name = "label4";
            label4.Size = new Size(143, 31);
            label4.TabIndex = 6;
            label4.Text = "Code Client :";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(367, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(364, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(184, 270);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(361, 31);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(184, 101);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(361, 31);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 317);
            label5.Name = "label5";
            label5.Size = new Size(124, 31);
            label5.TabIndex = 11;
            label5.Text = "Quantites :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(162, 317);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(383, 31);
            textBox5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 373);
            label6.Name = "label6";
            label6.Size = new Size(72, 31);
            label6.TabIndex = 13;
            label6.Text = "Date :";
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(32, 436);
            button1.Name = "button1";
            button1.Size = new Size(180, 53);
            button1.TabIndex = 14;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(211, 30);
            label7.Name = "label7";
            label7.Size = new Size(334, 42);
            label7.TabIndex = 15;
            label7.Text = "Enregistrement de l'Achat";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Paomedia_Small_N_Flat_Sign_left_1024;
            pictureBox1.Location = new Point(32, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Location = new Point(581, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 525);
            panel1.TabIndex = 17;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(228, 436);
            button2.Name = "button2";
            button2.Size = new Size(179, 53);
            button2.TabIndex = 18;
            button2.Text = "Annuler l'Achat";
            button2.UseVisualStyleBackColor = false;
            // 
            // Achat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "Achat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Achat";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Button button1;
        private Label label7;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button2;
    }
}