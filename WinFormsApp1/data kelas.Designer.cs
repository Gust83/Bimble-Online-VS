namespace WinFormsApp1
{
    partial class data_kelas
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
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(661, 594);
            button4.Name = "button4";
            button4.Size = new Size(157, 61);
            button4.TabIndex = 21;
            button4.Text = "Tambah";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(475, 594);
            button3.Name = "button3";
            button3.Size = new Size(157, 61);
            button3.TabIndex = 20;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(283, 594);
            button2.Name = "button2";
            button2.Size = new Size(157, 61);
            button2.TabIndex = 19;
            button2.Text = "Ubah";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(55, 594);
            button1.Name = "button1";
            button1.Size = new Size(161, 61);
            button1.TabIndex = 18;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3 });
            dataGridView1.Location = new Point(55, 278);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(763, 242);
            dataGridView1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(283, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(99, 31);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(283, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 31);
            textBox1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 127);
            label4.Name = "label4";
            label4.Size = new Size(77, 32);
            label4.TabIndex = 13;
            label4.Text = "Nama";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 90);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(31, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 60);
            label1.TabIndex = 0;
            label1.Text = "Data Kelas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 186);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 22;
            label2.Text = "Maksimal SIswa";
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
            Column3.HeaderText = "Maksimal_siswa";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // data_kelas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 711);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "data_kelas";
            Text = "data_kelas";
            Load += data_kelas_Load;
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
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}