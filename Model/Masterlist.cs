using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.DeskApp.Model
{
    public class Masterlist
    {
        public string kode_mitra { get; set; }
        public string nama_mitra { get; set; }
        public string ketua_kelompok { get; set; }
        public string nama_kelompok { get; set; }
        public string jenis_mitra { get; set; }
        public string alamat_ktp { get; set; }
        public string no_ktp { get; set; }
        public string no_hp { get; set; }
        public string no_kontrak { get; set; }
        public DateTime tgl_kontrak { get; set; }
        public double luas { get; set; }
        public string kategori { get; set; }
        public string varietas { get; set; }
        public DateTime tgl_tanam { get; set; }
        public string rayon { get; set; }
        public string penanggung_jawab { get; set; }
        public string koordinat_x { get; set; }
        public string koordinat_y { get; set; }
        public string kelurahan { get; set; }
        public string kecamatan { get; set; }
        public string kabupaten { get; set; }
        public string no_rek { get; set; }
        public string an_rek { get; set; }
        public string bank_rek { get; set; }
        public string kud { get; set; }
        public DateTime tgl_panen { get; set; }
        public double est_tch { get; set; }
        public double est_hasil_panen { get; set; }
        public string est_radius { get; set; }
        public string value_1 { get; set; }
        public string value_2 { get; set; }
    }
}
