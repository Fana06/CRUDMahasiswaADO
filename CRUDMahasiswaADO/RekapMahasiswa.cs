using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public partial class RekapMahasiswa : Form
    {
        // =============================================
        // LANGKAH 15 - Tambahkan DAL
        // =============================================
        DAL dbLogic = new DAL();

        public RekapMahasiswa()
        {
            InitializeComponent();
        }

        // =============================================
        // LANGKAH 6 - Event Form_Load
        // =============================================
        private void RekapMahasiswa_Load(object sender, EventArgs e)
        {
            // Setting DateTimePicker agar hanya tampil tahun
            dtpTanggalMasuk.Format = DateTimePickerFormat.Custom;
            dtpTanggalMasuk.CustomFormat = "yyyy";
            dtpTanggalMasuk.ShowUpDown = true;
            dtpTanggalMasuk.MinDate = new DateTime(2000, 1, 1);
            dtpTanggalMasuk.MaxDate = DateTime.Now;

            cmbProdi.DropDownStyle = ComboBoxStyle.DropDownList;

            // Tombol cetak disabled dulu sebelum data di-load
            btnCetak.Enabled = false;

            try
            {
                DataTable dtProdi = dbLogic.getProdi();
                cmbProdi.DataSource = dtProdi;
                cmbProdi.DisplayMember = "namaprodi";
                cmbProdi.ValueMember = "namaprodi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data: " + ex.Message);
            }
        }

        // =============================================
        // LANGKAH 7 - Event btnLoad_Click
        // =============================================
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtMahasiswa = dbLogic.getDataRekap(
                    cmbProdi.SelectedValue.ToString(),
                    dtpTanggalMasuk.Value
                );

                dataGridView1.DataSource = dtMahasiswa;

                if (dtMahasiswa.Rows.Count > 0)
                {
                    btnCetak.Enabled = true;
                }
                else
                {
                    btnCetak.Enabled = false;
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data: " + ex.Message);
            }
        }

        // =============================================
        // TOMBOL CETAK
        // =============================================
        private void BtnCetak_Click(object sender, EventArgs e)
        {
            Report frm2 = new Report(
                cmbProdi.SelectedValue.ToString(),
                dtpTanggalMasuk.Value
            );
            frm2.Show();
            this.Hide();
        }
    }
}