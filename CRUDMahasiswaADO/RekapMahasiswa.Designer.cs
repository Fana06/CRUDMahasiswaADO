namespace CRUDMahasiswaADO
{
    partial class RekapMahasiswa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblProdi = new System.Windows.Forms.Label();
            this.cmbProdi = new System.Windows.Forms.ComboBox();
            this.lblTahun = new System.Windows.Forms.Label();
            this.dtpTanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCetak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblJudul.Location = new System.Drawing.Point(12, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(760, 30);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "REKAP DATA MAHASISWA";
            this.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProdi
            // 
            this.lblProdi.AutoSize = true;
            this.lblProdi.Location = new System.Drawing.Point(12, 50);
            this.lblProdi.Name = "lblProdi";
            this.lblProdi.Size = new System.Drawing.Size(31, 13);
            this.lblProdi.TabIndex = 1;
            this.lblProdi.Text = "Prodi";
            // 
            // cmbProdi
            // 
            this.cmbProdi.Location = new System.Drawing.Point(55, 47);
            this.cmbProdi.Name = "cmbProdi";
            this.cmbProdi.Size = new System.Drawing.Size(200, 21);
            this.cmbProdi.TabIndex = 2;
            // 
            // lblTahun
            // 
            this.lblTahun.AutoSize = true;
            this.lblTahun.Location = new System.Drawing.Point(270, 50);
            this.lblTahun.Name = "lblTahun";
            this.lblTahun.Size = new System.Drawing.Size(73, 13);
            this.lblTahun.TabIndex = 3;
            this.lblTahun.Text = "Tahun Masuk";
            // 
            // dtpTanggalMasuk
            // 
            this.dtpTanggalMasuk.Location = new System.Drawing.Point(345, 47);
            this.dtpTanggalMasuk.Name = "dtpTanggalMasuk";
            this.dtpTanggalMasuk.Size = new System.Drawing.Size(100, 20);
            this.dtpTanggalMasuk.TabIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(460, 45);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(760, 350);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(697, 445);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(75, 23);
            this.btnCetak.TabIndex = 7;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.BtnCetak_Click);
            // 
            // RekapMahasiswa
            // 
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblProdi);
            this.Controls.Add(this.cmbProdi);
            this.Controls.Add(this.lblTahun);
            this.Controls.Add(this.dtpTanggalMasuk);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCetak);
            this.Name = "RekapMahasiswa";
            this.Text = "Rekap Mahasiswa";
            this.Load += new System.EventHandler(this.RekapMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Deklarasi kontrol
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblProdi;
        private System.Windows.Forms.ComboBox cmbProdi;
        private System.Windows.Forms.Label lblTahun;
        private System.Windows.Forms.DateTimePicker dtpTanggalMasuk;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCetak;
    }
}