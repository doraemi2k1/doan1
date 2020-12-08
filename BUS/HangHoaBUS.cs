using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using doan1.DAL;

namespace doan1.BUS
{
    class HangHoaBus
    {
    {
        private HangHoaDAL hhDAL = new HangHoaDAL();

        public void Them(string maHH, string tenHH, string loaiHH, double giaban)
        {
            hhDAL.Them(maHH, tenHH, loaiHH, giaban);
        }

        public void Sua(string maHH, string tenHH, string loaiHH, double giaban)
        {
            hhDAL.Sua(maHH, tenHH, loaiHH, giaban);
        }

        public void Xoa(string maHH)
        {
            hhDAL.Xoa(maHH);
        }

        public List<String> LayDanhSach()
        {
            return hhDAL.Laydanhsach();
        }
    }
}
