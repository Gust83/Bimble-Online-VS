namespace WinFormsApp1
{
    partial class Angsuran_Baru
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 141);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 46);
            label1.Name = "label1";
            label1.Size = new Size(303, 48);
            label1.TabIndex = 3;
            label1.Text = "Tambah Angsuran";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 31);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 158);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 10;
            label2.Text = "Pilih Siswa";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ButtonShadow;
            flowLayoutPanel1.Location = new Point(361, 161);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(36, 31);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(454, 161);
            label3.Name = "label3";
            label3.Size = new Size(160, 32);
            label3.TabIndex = 17;
            label3.Text = "Histori Cicilan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(454, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(541, 381);
            dataGridView1.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 208);
            label4.Name = "label4";
            label4.Size = new Size(253, 32);
            label4.TabIndex = 19;
            label4.Text = "Sisa Banyaknya Cicilan";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(271, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(62, 31);
            textBox2.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 341);
            label5.Name = "label5";
            label5.Size = new Size(207, 38);
            label5.TabIndex = 21;
            label5.Text = "PEMBAYARAN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 403);
            label6.Name = "label6";
            label6.Size = new Size(135, 32);
            label6.TabIndex = 22;
            label6.Text = "Cicilan Ke -";
            label6.Click += label6_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(142, 404);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(62, 31);
            textBox3.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(12, 452);
            label7.Name = "label7";
            label7.Size = new Size(148, 32);
            label7.TabIndex = 24;
            label7.Text = "Besar Cicilan";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(157, 452);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(158, 31);
            textBox4.TabIndex = 25;
            // 
            // button1
            // 
            button1.Location = new Point(16, 524);
            button1.Name = "button1";
            button1.Size = new Size(131, 52);
            button1.TabIndex = 36;
            button1.Text = "BAYAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
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
            Column3.HeaderText = "Cicilan Ke";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Besar Cicilan";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Banyak Cicilan";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Angsuran_Baru
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 641);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Angsuran_Baru";
            Text = "Angsuran_Baru";
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
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button1;
    }
}