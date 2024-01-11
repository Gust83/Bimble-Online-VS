namespace WinFormsApp1
{
    partial class data_siswa
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
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 69);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(11, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 60);
            label1.TabIndex = 0;
            label1.Text = "Data Siswa";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(570, 85);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 2;
            label2.Text = "Cari";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(657, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 31);
            textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(34, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(967, 225);
            dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nis";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Alamat";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "tanggal Lahir";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Jenis Kelamin";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lianne_w_m_1e68Ea5E7bU_unsplash;
            pictureBox1.Location = new Point(34, 446);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(34, 383);
            button1.Name = "button1";
            button1.Size = new Size(142, 46);
            button1.TabIndex = 17;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(413, 397);
            label3.Name = "label3";
            label3.Size = new Size(51, 32);
            label3.TabIndex = 18;
            label3.Text = "NIS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(413, 446);
            label4.Name = "label4";
            label4.Size = new Size(77, 32);
            label4.TabIndex = 19;
            label4.Text = "Nama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(413, 499);
            label5.Name = "label5";
            label5.Size = new Size(159, 32);
            label5.TabIndex = 20;
            label5.Text = "Jenis Kelamin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(413, 554);
            label6.Name = "label6";
            label6.Size = new Size(88, 32);
            label6.TabIndex = 21;
            label6.Text = "Alamat";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(586, 400);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 31);
            textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(586, 449);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 31);
            textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(586, 557);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(249, 31);
            textBox4.TabIndex = 24;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Laki-Laki", "Perempuan" });
            comboBox1.Location = new Point(586, 502);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 33);
            comboBox1.TabIndex = 25;
            // 
            // button2
            // 
            button2.Location = new Point(34, 698);
            button2.Name = "button2";
            button2.Size = new Size(142, 46);
            button2.TabIndex = 26;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(204, 698);
            button3.Name = "button3";
            button3.Size = new Size(142, 46);
            button3.TabIndex = 27;
            button3.Text = "Ubah";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(376, 698);
            button4.Name = "button4";
            button4.Size = new Size(142, 46);
            button4.TabIndex = 28;
            button4.Text = "Hapus";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(552, 698);
            button5.Name = "button5";
            button5.Size = new Size(142, 46);
            button5.TabIndex = 29;
            button5.Text = "Tambah";
            button5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(413, 608);
            label7.Name = "label7";
            label7.Size = new Size(154, 32);
            label7.TabIndex = 30;
            label7.Text = "Tanggal Lahir";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(586, 608);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 31;
            // 
            // data_siswa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 756);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "data_siswa";
            Text = "data_siswa";
            Load += data_siswa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label7;
        private DateTimePicker dateTimePicker1;
    }
}