namespace GestionVenteApp
{
    partial class frmArticle
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
            tPU = new TextBox();
            tQT = new TextBox();
            txDesignation = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            dgArticles = new DataGridView();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            tCode = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgArticles).BeginInit();
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
            button1.Location = new Point(29, 522);
            button1.Name = "button1";
            button1.Size = new Size(124, 39);
            button1.TabIndex = 0;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tPU
            // 
            tPU.Location = new Point(181, 121);
            tPU.Name = "tPU";
            tPU.Size = new Size(316, 31);
            tPU.TabIndex = 2;
            // 
            // tQT
            // 
            tQT.Location = new Point(159, 168);
            tQT.Name = "tQT";
            tQT.Size = new Size(338, 31);
            tQT.TabIndex = 3;
            // 
            // txDesignation
            // 
            txDesignation.Location = new Point(181, 77);
            txDesignation.Name = "txDesignation";
            txDesignation.Size = new Size(316, 31);
            txDesignation.TabIndex = 4;
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
            button2.Location = new Point(289, 522);
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
            button3.Location = new Point(159, 522);
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
            // dgArticles
            // 
            dgArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgArticles.Location = new Point(39, 37);
            dgArticles.Name = "dgArticles";
            dgArticles.RowHeadersWidth = 62;
            dgArticles.Size = new Size(665, 196);
            dgArticles.TabIndex = 12;
            dgArticles.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgArticles);
            groupBox1.Font = new Font("Poppins", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(29, 262);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 207);
            label5.Name = "label5";
            label5.Size = new Size(77, 31);
            label5.TabIndex = 15;
            label5.Text = "Code :";
            // 
            // tCode
            // 
            tCode.Location = new Point(112, 209);
            tCode.Name = "tCode";
            tCode.Size = new Size(385, 31);
            tCode.TabIndex = 16;
            // 
            // frmArticle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 577);
            Controls.Add(tCode);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txDesignation);
            Controls.Add(tQT);
            Controls.Add(tPU);
            Controls.Add(button1);
            Name = "frmArticle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Article";
            Load += frmArticle_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgArticles).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tPU;
        private TextBox tQT;
        private TextBox txDesignation;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private DataGridView dgArticles;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private TextBox tCode;
    }
}