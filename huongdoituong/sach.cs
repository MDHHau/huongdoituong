using huongdoituong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huongdoituong
{
    internal class Sach
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }

        public Sach() { }


        public Sach(int maSach, string tenSach, string tacGia)
        {
            MaSach = maSach;
            TenSach = tenSach;
            TacGia = tacGia;
        }
        public void hienthi()
        {
            Console.WriteLine("ma sach :" + MaSach + "    ten sach :" + TenSach + "      tac gia :" + TacGia);
        }
    }



    class thuvien
    {
        
        List<Sach> ds1 = new List<Sach>();
        public void ThemSach(Sach SACH)
        {           
           ds1.Add(SACH);
            Console.WriteLine("sach da duoc them vao thu vien.");
            Console.WriteLine("");
        }
        public void XoaSach(int maSach)
        {
            Sach sachxoa = ds1.Find(s => s.MaSach == maSach);
            if (sachxoa != null)
            {
                ds1.Remove(sachxoa);
                Console.WriteLine("sach da bi xoa.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("khong tim thay sach");
                Console.WriteLine("");
            }
        }
        public void HienThiDanhSachSach()
        {
            Console.WriteLine("danh sach trong thu vien:");
            
            foreach (Sach SACH in ds1)
            {
                Console.WriteLine(SACH);
            }
        }
    }
}


