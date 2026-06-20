using System;

namespace CRUDMahasiswaADO
{
    public class DataMahasiswa
    {
        public string NIM { get; set; }

        public string Nama { get; set; }

        public string JenisKelamin { get; set; }

        public string Alamat { get; set; }

        public string NamaProdi { get; set; }

        public DateTime TanggalLahir { get; set; }

        public DateTime TanggalDaftar { get; set; }
    }
}