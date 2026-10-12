/* 
 * ho va ten: Le Xuan Nguyen
 * mssv: 26dh140178
 * ngay tao: 12/10/2026
 */
using System;
namespace BT41
{ 
    class Program
    {
        // tính doanh thu 7 ngay liên tiếp, cho biết ngày trong tuần có doanh thu cao nhất
        static void Main(string[] agrs)
        {
            // nhập doanh thu mỗi ngày trong tuần
            double[] doanhThu = new double[7]; // danh sách doanh thu 7 ngày
            string[] thu = { "Thu 2", "Thu 3", "Thu 4", " thu 5", "Thu 6", "Thu 7", "CN" }; // ten thu trong tuan
            double tongDoanhThu = 0; // chứa tổng doanh thu cả tuần
            int maxId = 0; // chứa chỉ số thứ doanh thu r=trng tuần có doanh thu cao nhất
            double binhQuanDoanhThu = 0; // bình quân doanh thu mỗi ngày trong tuần
            // --- chạy vòng lặp doanh thu cho mỗi ngày
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Nhap doanh thu ca ngay {thu[i]}: "); // hiển thiện câu nhắc nhập...
                doanhThu[i] = double.Parse(Console.ReadLine()); // nhập doanh thu cho ngày thứ 1
                tongDoanhThu += doanhThu[i]; // cộng dồn doanh thu...
                if (doanhThu[i] > doanhThu[maxId]) // so sánh...
                    maxId = i;
            }
            binhQuanDoanhThu = tongDoanhThu / 7; // binfnh quân chia đều 7 ngày

            // xuất
            Console.WriteLine("==========================================================");
            for (int i = 0; i < 7; i++) // xuất lần lượt doanh thu 7 ngày
            {
                Console.WriteLine($" Thu {thu[i]} : {doanhThu[i]} vnd ");
            }
            Console.WriteLine($"Tong doanh thu         :{tongDoanhThu: 0,0} trieu vnd ");
            Console.WriteLine($"Binh quan doanh thu    :{binhQuanDoanhThu: 0,0} trieu vnd ");
            Console.WriteLine($"Ngay co doanh thu cao nhat la {thu[maxId]}, voi so tien la {doanhThu[maxId]} trieu vnd ");
            Console.Read();
        }

    }
}