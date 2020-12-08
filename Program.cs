﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan1.GUI;

namespace doan1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            bool end = false;
            while (!end)
            {
                Console.Clear();
                Console.Title = "\t          CHƯƠNG TRÌNH QUẢN LÝ  CỬA HÀNG SỮA CHUA HOUJICHA ";
                Console.SetWindowSize(103, 40);
                Console.Write("\n\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t║                CHƯƠNG TRÌNH QUẢN LÝ  CỬA HÀNG SỮA CHUA HOUJICHA       ║");
                Console.Write("\n\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                Console.Write("\n\t\t║                                                                       ║");
                Console.Write("\n\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                           MENU                                    ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 1.║    QUẢN LÝ  LOẠI HÀNG        ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 2.║     QUẢN LÝ BÁN HÀNG         ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 3.║     QUẢN LÝ NHẬP HÀNG        ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 4.║     QUẢN LÝ KHÁCH HÀNG       ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 5.║     THOÁT KHỎI CHƯƠNG TRÌNH  ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║ Bấm phím theo số để chọn:    ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ╚═══╩══════════════════════════════╝                 ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ╚═══════════════════════════════════════════════════════════════════╝ ║");
                Console.Write("\n\t\t║                                                                       ║");
                Console.Write("\n\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(65, 26);
                Char key = Char.ToUpper(Console.ReadKey(true).KeyChar);
                switch (key)
                {
                    case '1':
                        LoaiHangGUI loaiHang = new LoaiHangGUI();
                        loaiHang.HienMENU(); break;
                    case '2':
                        HoaDonGUI hoaDon = new HoaDonGUI();
                        hoaDon.HienMENU(); break;
                    case '3':
                        HangHoaGUI hangHoa = new HangHoaGUI();
                        hangHoa.HienMENU(); break;
                    case '4':
                        KhachHangGUI khachHang = new KhachHangGUI();
                        khachHang.HienMenu(); break;
                    case '5': end = true; break;
                }
            }

        }
    }
}