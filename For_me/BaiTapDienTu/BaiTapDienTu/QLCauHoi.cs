using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapDienTu
{
    internal class QLCauHoi
    {
        public QLCauHoi(string cauhoi, List<string> dapan, string cauhoi_kemdapan)
        {
            this.Cauhoi = cauhoi;
            this.Dapan = dapan;
            this.Cauhoi_kemdapan = cauhoi_kemdapan;
        }
        public string Cauhoi 
        { 
            get => cauhoi; set => cauhoi = value; 
        }
        public List<string> Dapan
        {
            get => dapan; set => dapan = value; }
        public string Cauhoi_kemdapan
        {
            get => cauhoi_kemdapan; set => cauhoi_kemdapan = value; 
        }

    }
}
