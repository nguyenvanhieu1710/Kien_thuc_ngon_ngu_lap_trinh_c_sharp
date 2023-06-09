using System; //có thể sử dụng các lớp từ System không gian tên
using System.Linq;// thư viện Linq

namespace MyApplication //được sử dụng để sắp xếp mã của bạn và là nơi chứa các lớp và không gian tên khác
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter name: ");// xuất ra màn hình
            string name = Console.ReadLine();// nhập vào màn hình
            Console.WriteLine("My name is " + name);

            Console.WriteLine("Enter my age: ");
            int age = Convert.ToInt32(Console.ReadLine());// Conver. là ép kiểu
            Console.WriteLine("My age is " + age);

            string name_age= string.Concat(name, age);//.Concat là nối 2 chuỗi
            Console.WriteLine(name_age);

            string name_name = $"My name and age is: {name} {age}";// $ là nội suy chuỗi
            Console.WriteLine(name_name);

            // Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long) là các kiểu ép kiểu
            // && là end, || là or, ! là not
            // Math.Max(x,y), Math.Min(x,y), Math.Sqrt(x) là căn, Math.Abs(x) là trị tuyệt đối, Math.Round(x) là làm tròn

            string fist_and_last_name = "Nguyen Van Hieu";
            Console.WriteLine("The length of the fist_and_last_name is: " + fist_and_last_name.Length);// Length là trả về kí tự(cả khoảng trống)
            Console.WriteLine(fist_and_last_name.ToUpper());// .ToUpper là chuyển thành chữ hoa
            Console.WriteLine(fist_and_last_name.ToLower());// .ToLower là chuyển thành chữ thường
            Console.WriteLine(fist_and_last_name.IndexOf("N"));// .IndexOf là tìm vị trí kí tự

            int vi_tri_ki_tu = fist_and_last_name.IndexOf("a");
            string chuoi_sau = fist_and_last_name.Substring(vi_tri_ki_tu);// .Substring hiển thị chuỗi phía sau
            Console.WriteLine($"Đoan sau cua chuoi là:{chuoi_sau}");

            Console.WriteLine("We are the so-called \"Vikings\" from the north.");// Thêm kí hiệu " " vào
            Console.WriteLine("It\'s alright.");// Thêm kí hiệu ' vào
            Console.WriteLine("The character \\ is called backslash.");// Thêm \ vào

            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";// điều kiện ? True : Fale ;
            Console.WriteLine(result);

            switch (time)// xét điều kiện
            {
                case 19: Console.WriteLine("Sai");// case như if
                    break;
                default: Console.WriteLine("Đúng");// default như else
                    break;
            }

            int h = 0;
            do { Console.WriteLine(h++); }// do/while là 1 cặp, chạy do trước xong mới chạy while
            while(h<5);

            for (int i = 1; i <= 2;++i) // khai báo; điều kiện(T->ok,F->thoát); kết quả
            {
                Console.WriteLine("Outer: " + i);
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("Inner: " + j);
                }
            }

            int[] myNumbers = { 1, 2, 3, 4, 5, 6, };// tạo mảng int 
            Console.WriteLine(myNumbers.Max());
            Console.WriteLine(myNumbers.Min());
            Console.WriteLine(myNumbers.Sum());

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };// tạo mảng string
            Array.Sort(cars);// Array.Sort là sắp xếp theo bảng chữ cái
            foreach (string i in cars)// vòng lặp foreach / i trong cars
            {
                Console.WriteLine(i);
            }

            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };// [,] là 2 mảng,{1,2,3} là hàng 1,{4,5,6} là hàng 2
            Console.WriteLine(numbers[0,2]);// [0,2] là hàng 1 cột 3
            for (int i = 0; i < numbers.GetLength(0); i++)// GetLength(0) là trả về tổng kí tự hàng thứ 1
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }


        }
    }
}