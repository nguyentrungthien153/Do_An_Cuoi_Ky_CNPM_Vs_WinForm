using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
    internal class TaiKhoan
    {
        private string tentaikhoan;
        private string matkhau;
        private string loaitk;
        

        public TaiKhoan()
        {
        }

        public TaiKhoan(string tentaikhoan, string matkhau, string loaitk)
        {
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.loaitk = loaitk;
          
            
        }

        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }

        public string Loaitk { get => loaitk; set => loaitk = value; }


    }
}
