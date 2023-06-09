using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try // try là thử,kiểm tra lỗi
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)// catch là thông báo,hiển thị lỗi
            {
                Console.WriteLine(e.Message);
            }
            finally// finally là câu lệnh cuối cùng cho phép bạn thực thi mã
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}

using System;

namespace MyApplication
{
    class Program
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }// throw là tạo ra một lỗi tùy chỉnh,nhưng throw phải thực hiện cùng 1 lớp ngoại lệ(ví dụ:ArithmeticException)
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        static void Main(string[] args)
        {
            checkAge(15);
        }
    }
}