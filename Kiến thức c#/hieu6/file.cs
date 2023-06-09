using System;
using System.IO;  // include the System.IO namespace

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

            string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
            Console.WriteLine(readText); // Output the content
        }
    }
}
// AppendText() là Nối văn bản vào cuối tệp hiện có
// Copy() là Sao chép một tập tin
// Create()	là Tạo hoặc ghi đè lên một tập tin
// Delete()	là Xóa một tập tin
// Exists()	là Kiểm tra xem tệp có tồn tại không
// ReadAllText() là Đọc nội dung của một tập tin
// Replace() là Thay thế nội dung của một tệp bằng nội dung của một tệp khác
// WriteAllText() là Tạo một tệp mới và ghi nội dung vào đó. Nếu tệp đã tồn tại, nó sẽ bị ghi đè.
