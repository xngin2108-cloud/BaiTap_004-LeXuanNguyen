/* 
 * ho va ten: Le Xuan Nguyen
 * mssv: 26dh140178
 * ngay tao: 12/10/2026
 */
using System;
namespace BT42
{
    class Program
    {
        // Nhập sản phẩm đến khi đủ giỏ hàng (do_While)
        // Nhap danh sach gom ten_san_pham và gia_san_pham, cuoi cung xuat lai danh sach va tong gia tri
        static void Main(string[] args)
        {
            // Nhap danh sach ma khong biet so lan nhap bao nhieu lan
            string[] tenSanPham = new string[1000]; // danh sách tên sản phẩm cần nhập
            double[] giaSanPham = new double[1000]; // danh sách đơn giá cần cập nhật

            double tongGiaTri = 0; // tổng giá trị nhập
            int soLuongSanPhamDaNhap = 0; // số lượng sản phẩm đã nhập thực sự
            string tiepTuc = ""; // ghi nhận có tiếp tục nhập sản phẩm kế tiếp không? c/k
            do
            {
                Console.Write("Nhap ten san pham: ");
                tenSanPham[soLuongSanPhamDaNhap] = Console.ReadLine();
                Console.Write("Nhap gia san pham: ");
                giaSanPham[soLuongSanPhamDaNhap] = double.Parse(Console.ReadLine());


                tongGiaTri += giaSanPham[soLuongSanPhamDaNhap]; // cộng dồn

                soLuongSanPhamDaNhap++; // tăng số lượng thực sự đã nhập

                Console.Write("Ban co tiep tuc khong? (c/k): "); // hỏi người dùng xác nhận...
                tiepTuc = Console.ReadLine();

            } while (tiepTuc == "c" || tiepTuc == "C"); // muốn tiếp tục?

            // xuat lai danh sach va tong gia tri
            for (int i = 0; i < soLuongSanPhamDaNhap; i++)
            {
                Console.WriteLine($"{i}) --- {tenSanPham[i],25} --- {giaSanPham[i]:0,0} vnd ");
            }
            Console.WriteLine($"Tong gia tri: {tongGiaTri: 0,0} vnd");


        }

    }
}