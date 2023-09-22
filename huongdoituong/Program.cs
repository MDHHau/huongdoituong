using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huongdoituong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            thuvien TV = new thuvien();
            // Thêm sách vào thư viện
            Sach sach1 = new Sach(1, "Cuốn theo chiều gió", "Margaret Mitchell");
            TV.ThemSach(sach1);

            Sach sach2 = new Sach(2, "Harry Potter và Hòn đá Phù thủy", "J.K. Rowling");
            TV.ThemSach(sach2);

            // Hiển thị danh sách sách
            TV.HienThiDanhSachSach();

            // Xoá sách khỏi thư viện
            TV.XoaSach(1);

            // Hiển thị danh sách sách sau khi xoá
            TV.HienThiDanhSachSach();

            Console.ReadKey();
        }
    }
}
