using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_25
{
    class String01
    {
        static void Main() {
            int Count = 0;
            while (true)
            {
                //string str1 = "가나다라마바사";
                //Console.WriteLine(str1.Contains("@"));
                //Console.WriteLine("올바른 이메일 입력");
                //string str2 = Console.ReadLine();
                //if (!str2.Contains('@'))
                //{
                //    Console.WriteLine("올바른 주소가아닙니다.");
                //}

                //if(str2.IndexOf('@') < 1)
                //{
                //    Console.WriteLine("올바른 주소가아닙니다.");
                //}
                //Console.WriteLine("주민등록번호 입력");
                //string Num = Console.ReadLine();

                //string year = Num.Substring(0, 2);
                //string month = Num.Substring(2, 2).TrimStart('0');
                //string day = Num.Substring(4, 2);
                //string sex = (Num.Substring(Num.IndexOf('-')+1, 1) == "1") ? "남자": "여자";
                //Console.WriteLine($"19{year}년 {month}월 {day}일 {sex}");

                //string temp = "C:\\Users\\GDC6\\Downloads\\PhoneComparator.cs";
                //string temp01 = temp.Substring(temp.LastIndexOf("\\")+1);
                //string temp02 = temp.Substring(temp.LastIndexOf(".") + 1);
                //Console.WriteLine(temp01);
                //Console.WriteLine(temp02.ToLower());
                //C:\Users\GDC6\Downloads


                DateTime date = DateTime.Now;

                string temp = date.ToString("yyyy\\MM\\dd") + (++Count).ToString().PadLeft(5, '0');
                Console.WriteLine(temp);

                Console.ReadLine();
            }
        }
    }
}
