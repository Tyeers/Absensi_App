namespace Absensi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.inputNIS = new System.Windows.Forms.TextBox();
            this.inputNama = new System.Windows.Forms.TextBox();
            this.checkHadir = new System.Windows.Forms.CheckBox();
            this.checkTidakHadir = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mapel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kehadiran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputMapel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // inputNIS
            // 
            this.inputNIS.Location = new System.Drawing.Point(216, 48);
            this.inputNIS.Name = "inputNIS";
            this.inputNIS.Size = new System.Drawing.Size(216, 27);
            this.inputNIS.TabIndex = 1;
            // 
            // inputNama
            // 
            this.inputNama.Location = new System.Drawing.Point(216, 114);
            this.inputNama.Name = "inputNama";
            this.inputNama.Size = new System.Drawing.Size(216, 27);
            this.inputNama.TabIndex = 2;
            // 
            // checkHadir
            // 
            this.checkHadir.AutoSize = true;
            this.checkHadir.Location = new System.Drawing.Point(216, 282);
            this.checkHadir.Name = "checkHadir";
            this.checkHadir.Size = new System.Drawing.Size(68, 24);
            this.checkHadir.TabIndex = 4;
            this.checkHadir.Text = "Hadir";
            this.checkHadir.UseVisualStyleBackColor = true;
            // 
            // checkTidakHadir
            // 
            this.checkTidakHadir.AutoSize = true;
            this.checkTidakHadir.Location = new System.Drawing.Point(350, 282);
            this.checkTidakHadir.Name = "checkTidakHadir";
            this.checkTidakHadir.Size = new System.Drawing.Size(108, 24);
            this.checkTidakHadir.TabIndex = 5;
            this.checkTidakHadir.Text = "Tidak Hadir";
            this.checkTidakHadir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "NIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mapel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kehadiran";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Absen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NIS,
            this.Nama,
            this.Tanggal,
            this.Mapel,
            this.Kehadiran});
            this.dataGridView1.Location = new System.Drawing.Point(12, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(938, 242);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NIS
            // 
            this.NIS.HeaderText = "NIS";
            this.NIS.MinimumWidth = 6;
            this.NIS.Name = "NIS";
            this.NIS.ReadOnly = true;
            this.NIS.Width = 200;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            this.Nama.Width = 200;
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.MinimumWidth = 6;
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.ReadOnly = true;
            this.Tanggal.Width = 200;
            // 
            // Mapel
            // 
            this.Mapel.HeaderText = "Mapel";
            this.Mapel.MinimumWidth = 6;
            this.Mapel.Name = "Mapel";
            this.Mapel.ReadOnly = true;
            this.Mapel.Width = 125;
            // 
            // Kehadiran
            // 
            this.Kehadiran.HeaderText = "Kehadiran";
            this.Kehadiran.MinimumWidth = 6;
            this.Kehadiran.Name = "Kehadiran";
            this.Kehadiran.ReadOnly = true;
            this.Kehadiran.Width = 125;
            // 
            // inputMapel
            // 
            this.inputMapel.Location = new System.Drawing.Point(216, 220);
            this.inputMapel.Name = "inputMapel";
            this.inputMapel.Size = new System.Drawing.Size(242, 27);
            this.inputMapel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 607);
            this.Controls.Add(this.inputMapel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkTidakHadir);
            this.Controls.Add(this.checkHadir);
            this.Controls.Add(this.inputNama);
            this.Controls.Add(this.inputNIS);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox inputNIS;
        private TextBox inputNama;
        private CheckBox checkHadir;
        private CheckBox checkTidakHadir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NIS;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Tanggal;
        private DataGridViewTextBoxColumn Mapel;
        private DataGridViewTextBoxColumn Kehadiran;
        private TextBox inputMapel;
    }
}