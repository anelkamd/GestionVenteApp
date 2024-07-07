namespace GestionVenteApp
{
    partial class Article
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Designation = new DataGridViewTextBoxColumn();
            PU = new DataGridViewTextBoxColumn();
            QT = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(29, 485);
            button1.Name = "button1";
            button1.Size = new Size(124, 39);
            button1.TabIndex = 0;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(338, 31);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(181, 77);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(316, 31);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 80);
            label1.Name = "label1";
            label1.Size = new Size(146, 31);
            label1.TabIndex = 5;
            label1.Text = "Designation :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(257, 13);
            label2.Name = "label2";
            label2.Size = new Size(271, 39);
            label2.TabIndex = 6;
            label2.Text = "Enregistrement Article";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 124);
            label3.Name = "label3";
            label3.Size = new Size(146, 31);
            label3.TabIndex = 7;
            label3.Text = "Prix Unitaire :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 168);
            label4.Name = "label4";
            label4.Size = new Size(124, 31);
            label4.TabIndex = 8;
            label4.Text = "Quantites :";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(289, 485);
            button2.Name = "button2";
            button2.Size = new Size(124, 39);
            button2.TabIndex = 9;
            button2.Text = "Supprimer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(159, 485);
            button3.Name = "button3";
            button3.Size = new Size(124, 39);
            button3.TabIndex = 10;
            button3.Text = "Modifier";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Paomedia_Small_N_Flat_Sign_left_1024;
            pictureBox1.Location = new Point(29, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Designation, PU, QT });
            dataGridView1.Location = new Point(39, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(665, 196);
            dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "Code Article";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Designation
            // 
            Designation.HeaderText = "Designation";
            Designation.MinimumWidth = 8;
            Designation.Name = "Designation";
            Designation.Width = 150;
            // 
            // PU
            // 
            PU.HeaderText = "Prix Unitaire";
            PU.MinimumWidth = 8;
            PU.Name = "PU";
            PU.Width = 150;
            // 
            // QT
            // 
            QT.HeaderText = "Quantites";
            QT.MinimumWidth = 8;
            QT.Name = "QT";
            QT.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Poppins", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(29, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(744, 252);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Article Recemment Enregistre";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.e29f9af1680d9c079c05b4e09ce59d8f_removebg_preview;
            pictureBox2.Location = new Point(538, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // Article
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Article";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Article";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Designation;
        private DataGridViewTextBoxColumn PU;
        private DataGridViewTextBoxColumn QT;
        private PictureBox pictureBox2;
    }
}