namespace WinFormsApp1
{
    partial class Data_Paket_Bimble6
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            textBox4 = new TextBox();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(503, 637);
            button4.Name = "button4";
            button4.Size = new Size(131, 52);
            button4.TabIndex = 37;
            button4.Text = "Tambah";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(345, 637);
            button3.Name = "button3";
            button3.Size = new Size(131, 52);
            button3.TabIndex = 36;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(190, 637);
            button2.Name = "button2";
            button2.Size = new Size(131, 52);
            button2.TabIndex = 35;
            button2.Text = "Ubah";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(38, 637);
            button1.Name = "button1";
            button1.Size = new Size(131, 52);
            button1.TabIndex = 34;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(317, 502);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(229, 31);
            textBox3.TabIndex = 29;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(38, 557);
            label5.Name = "label5";
            label5.Size = new Size(212, 32);
            label5.TabIndex = 28;
            label5.Text = "Jumlah Pertemuan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(38, 490);
            label4.Name = "label4";
            label4.Size = new Size(77, 32);
            label4.TabIndex = 26;
            label4.Text = "Harga";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(317, 441);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 31);
            textBox2.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(38, 438);
            label3.Name = "label3";
            label3.Size = new Size(77, 32);
            label3.TabIndex = 24;
            label3.Text = "Nama";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column5, Column6 });
            dataGridView1.Location = new Point(38, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(895, 232);
            dataGridView1.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(589, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 31);
            textBox1.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(491, 113);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 21;
            label2.Text = "Cari";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-8, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 77);
            panel1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 0);
            label1.Name = "label1";
            label1.Size = new Size(378, 60);
            label1.TabIndex = 0;
            label1.Text = "Data Paket Bimble";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(317, 560);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(159, 31);
            textBox4.TabIndex = 38;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Harga";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Jumlah Pertemuan";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Data_Paket_Bimble6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 715);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Data_Paket_Bimble6";
            Text = "Paket Bimble";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox textBox4;
    }
}