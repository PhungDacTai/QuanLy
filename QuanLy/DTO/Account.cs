using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
   public  class Account
    {
<<<<<<< HEAD
=======
        //bé tài
        private string name;
>>>>>>> 0b2375563a707c91935198cdec922f17540baf2c
        private string UserName;

        public string userName
        {
            get { return UserName; }
            set { UserName = value; }
        }

        private string PassWord;
        public string passWord
        {
            get { return PassWord; }
            set { PassWord = value; }
        }

        private string LoaiTaiKhoan;
        public string loaiTaiKhoan
        {
            get { return LoaiTaiKhoan; }
            set { LoaiTaiKhoan = value; }
        }
        public Account(string UserName, string PassWord, string LoaiTaiKhoan)
        {
            
            this.UserName = UserName;
            this.PassWord = PassWord;
            this.LoaiTaiKhoan = LoaiTaiKhoan;
        }
    }
}
