using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan1.DAL;

namespace doan1.BUS
{
    class KhachHangBUS
    { 
    private KhachHangDAL khDAL = new KhachHangDAL();
        public List<String> LayDanhSach()
        {
            return khDAL.Laydanhsach();
        }
        public void Xoa(string maKH)
        {
            khDAL.Xoa(maKH);
        }
        public void Sua(string maKH, string tenKH, string diachiKH, int sdtKH)
        {
            khDAL.Sua(maKH, tenKH, diachiKH, sdtKH);
        }
        public void ThemKH(string maKH, string tenKH, string diachiKH, int sdtKH)
        {
            khDAL.ThemKH(maKH, tenKH, diachiKH, sdtKH);
        }
    }
}

