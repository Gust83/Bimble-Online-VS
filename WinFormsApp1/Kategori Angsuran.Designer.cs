namespace WinFormsApp1
{
    partial class Kategori_Angsuran
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
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 69);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(246, 38);
            label1.TabIndex = 2;
            label1.Text = "Kategori Angsuran";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(765, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 31);
            textBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(691, 92);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 8;
            label2.Text = "Cari";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(23, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(965, 281);
            dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nama";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Jenis Paket";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Keterangan";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Dp";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Besar Cicilan";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Banyak Cicilan";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(23, 447);
            label3.Name = "label3";
            label3.Size = new Size(77, 32);
            label3.TabIndex = 11;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(23, 495);
            label4.Name = "label4";
            label4.Size = new Size(123, 32);
            label4.TabIndex = 12;
            label4.Text = "Pilih Paket";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 450);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(293, 31);
            textBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(159, 494);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 33);
            comboBox1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveBorder;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(394, 495);
            label5.Name = "label5";
            label5.Size = new Size(141, 32);
            label5.TabIndex = 15;
            label5.Text = "Harga Paket";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(159, 565);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(411, 114);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(23, 565);
            label6.Name = "label6";
            label6.Size = new Size(136, 32);
            label6.TabIndex = 17;
            label6.Text = "Keterangan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(598, 447);
            label7.Name = "label7";
            label7.Size = new Size(45, 32);
            label7.TabIndex = 18;
            label7.Text = "Dp";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(598, 495);
            label8.Name = "label8";
            label8.Size = new Size(148, 32);
            label8.TabIndex = 19;
            label8.Text = "Besar Cicilan";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(598, 541);
            label9.Name = "label9";
            label9.Size = new Size(177, 71);
            label9.TabIndex = 20;
            label9.Text = "Banyak Nya Cicilan";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(765, 450);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(169, 31);
            textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(765, 498);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(169, 31);
            textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(765, 565);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(169, 31);
            textBox5.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(28, 705);
            button1.Name = "button1";
            button1.Size = new Size(131, 52);
            button1.TabIndex = 35;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(189, 705);
            button2.Name = "button2";
            button2.Size = new Size(131, 52);
            button2.TabIndex = 36;
            button2.Text = "Ubah";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(349, 705);
            button3.Name = "button3";
            button3.Size = new Size(131, 52);
            button3.TabIndex = 37;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(503, 705);
            button4.Name = "button4";
            button4.Size = new Size(131, 52);
            button4.TabIndex = 38;
            button4.Text = "Tambah";
            button4.UseVisualStyleBackColor = true;
            // 
            // Kategori_Angsuran
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 780);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Kategori_Angsuran";
            Text = "Kategori_Angsuran";
            Load += Kategori_Angsuran_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label5;
        private RichTextBox richTextBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}