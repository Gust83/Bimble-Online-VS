namespace WinFormsApp1
{
    partial class Anggota
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
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label7 = new Label();
            textBox4 = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label8 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            textBox5 = new TextBox();
            label11 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-22, -16);
            panel1.Name = "panel1";
            panel1.Size = new Size(1360, 79);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(48, 35);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 1;
            label1.Text = "Anggota Bimble";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5, Column6, Column1, Column7, Column8 });
            dataGridView1.Location = new Point(12, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1264, 290);
            dataGridView1.TabIndex = 6;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama Siswa";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Jenis Paket";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Kelas";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Tgl Registrasi";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Tipe Bayar";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "Pilihan Hari";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Diskon";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // Column8
            // 
            Column8.HeaderText = "Total Bayar";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.Width = 150;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1052, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 31);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(975, 85);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 4;
            label2.Text = "Cari";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 453);
            label3.Name = "label3";
            label3.Size = new Size(124, 32);
            label3.TabIndex = 5;
            label3.Text = "Pilih Siswa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 503);
            label4.Name = "label4";
            label4.Size = new Size(123, 32);
            label4.TabIndex = 7;
            label4.Text = "Pilih Paket";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 548);
            label5.Name = "label5";
            label5.Size = new Size(125, 32);
            label5.TabIndex = 8;
            label5.Text = "Tipe Bayar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 603);
            label6.Name = "label6";
            label6.Size = new Size(174, 32);
            label6.TabIndex = 9;
            label6.Text = "Jenis Angsuran";
            label6.Click += label6_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 459);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 31);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(221, 509);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 31);
            textBox3.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(795, 496);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(267, 33);
            comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(221, 553);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(228, 33);
            comboBox2.TabIndex = 13;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(221, 602);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(228, 33);
            comboBox3.TabIndex = 14;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ButtonShadow;
            flowLayoutPanel1.Location = new Point(413, 459);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(36, 31);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.ButtonShadow;
            flowLayoutPanel2.Location = new Point(413, 509);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(36, 31);
            flowLayoutPanel2.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(587, 456);
            label7.Name = "label7";
            label7.Size = new Size(121, 32);
            label7.TabIndex = 17;
            label7.Text = "Pilih Kelas";
            label7.Click += label7_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(795, 459);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(225, 31);
            textBox4.TabIndex = 18;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = SystemColors.ButtonShadow;
            flowLayoutPanel3.Location = new Point(1026, 459);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(36, 31);
            flowLayoutPanel3.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(587, 506);
            label8.Name = "label8";
            label8.Size = new Size(160, 32);
            label8.TabIndex = 19;
            label8.Text = "Pilih Hari/Sesi";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(587, 548);
            label9.Name = "label9";
            label9.Size = new Size(203, 32);
            label9.TabIndex = 20;
            label9.Text = "Tanggal Registrasi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(795, 551);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(587, 599);
            label10.Name = "label10";
            label10.Size = new Size(87, 32);
            label10.TabIndex = 22;
            label10.Text = "Diskon";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(680, 600);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(121, 31);
            textBox5.TabIndex = 23;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(807, 597);
            label11.Name = "label11";
            label11.Size = new Size(141, 32);
            label11.TabIndex = 24;
            label11.Text = "Total Bayar";
            label11.Click += label11_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(954, 597);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(261, 31);
            textBox6.TabIndex = 25;
            // 
            // button1
            // 
            button1.Location = new Point(26, 692);
            button1.Name = "button1";
            button1.Size = new Size(131, 52);
            button1.TabIndex = 26;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(189, 692);
            button3.Name = "button3";
            button3.Size = new Size(131, 52);
            button3.TabIndex = 27;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(342, 692);
            button4.Name = "button4";
            button4.Size = new Size(131, 52);
            button4.TabIndex = 28;
            button4.Text = "Tambah";
            button4.UseVisualStyleBackColor = true;
            // 
            // Anggota
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 756);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label11);
            Controls.Add(textBox5);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Anggota";
            Text = "Anggota";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label7;
        private TextBox textBox4;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private TextBox textBox5;
        private Label label11;
        private TextBox textBox6;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}