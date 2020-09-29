using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_25
{
    enum Calculations { Add = 1, MINUS = 2, TIMES = 3, DIVISION = 4 };
    class PMath
    {
        int x, y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public int Add()
        {
            return x + y;
        }

        public int Minus()
        {
            return x - y;
        }

        public int Times()
        {
            return x * y;
        }

        public int Division()
        {
            return x / y;
        }

    }

    class OneException : Exception
    {
        PMath math = new PMath();
        public void ShowMessge()
        {
            Console.WriteLine("첫번째 유형을 실행합니다.");
        }

        public void Run(int x, int y, int calculations)
        {
            math.X = x; math.Y = y;
            int temp = 0; char showcal = 'c';
            switch (calculations)
            {
                case (int)Calculations.Add: temp = math.Add(); showcal = '+'; break;
                case (int)Calculations.MINUS: temp = math.Minus(); showcal = '-'; break;
                case (int)Calculations.TIMES: temp = math.Times(); showcal = '*'; break;
                case (int)Calculations.DIVISION: temp = math.Division(); showcal = '/'; ; break;
            }

            while (true)
            {
                Console.WriteLine($"해당 연산은 다음과 같습니다. 정답을 맞춰주세요\n{math.X} {showcal} {math.Y} = ");
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input == temp)
                    {
                        Console.WriteLine("정답입니다!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("틀렸습니다. 계속하시겠습니까? 1.예 2.종료");
                        input = int.Parse(Console.ReadLine());
                        switch (input)
                        {
                            case 1: break;
                            case 2: return;
                            default:
                                throw new Exception();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("입력이 잘못되었습니다.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
            }
        }
    }
    class TwoException : Exception
    {
        PMath math = new PMath();


        public void ShowMessge()
        {
            Console.WriteLine("두번째 유형을 실행합니다.");
        }

        public void Run(int x, int y, int calculations)
        {
            math.X = x; math.Y = y;
            int temp = 0; char showcal = 'c';
            switch (calculations)
            {
                case (int)Calculations.Add: temp = math.Add(); showcal = '+'; break;
                case (int)Calculations.MINUS: temp = math.Minus(); showcal = '-'; break;
                case (int)Calculations.TIMES: temp = math.Times(); showcal = '*'; break;
                case (int)Calculations.DIVISION: temp = math.Division(); showcal = '/'; ; break;
            }

            while (true)
            {
                Console.WriteLine($"해당 연산은 다음과 같습니다. 정답을 맞춰주세요\n{math.X} {showcal} {math.Y} = ");
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input == temp)
                    {
                        Console.WriteLine("정답입니다!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("틀렸습니다. 계속하시겠습니까? 1.예 2.종료");
                        input = int.Parse(Console.ReadLine());
                        switch (input)
                        {
                            case 1: break;
                            case 2: return;
                            default:
                                throw new Exception();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("입력이 잘못되었습니다.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
            }
        }
    }
    class ThreeException : Exception
    {
        PMath math = new PMath();
        public void ShowMessge()
        {
            Console.WriteLine("셋째 유형을 실행합니다.");
        }
    }


    class Class1
    {
        static void Main()
        {
            PMath Math = new PMath();
            Random random = new Random(DateTime.UtcNow.Millisecond);

            while (true)
            {
                try
                {
                    while (true)
                    {
                        Console.WriteLine("1.유형1 실행\t2.유형2 실행\t3.유형3 실행");
                        int input = 0;
                        input = int.Parse(Console.ReadLine());
                        switch (input)
                        {
                            case 1: throw new OneException(); break;
                            case 2: throw new TwoException(); break;
                            case 3: throw new ThreeException(); break;
                            default:
                                Console.WriteLine("범위내에서 입력해주세요"); break;
                        }
                    }
                }
                catch (OneException er)
                {
                    er.ShowMessge();
                    er.Run(random.Next(1, 10), random.Next(1, 10), random.Next(1, 5));
                }
                catch (TwoException er)
                {
                    er.ShowMessge();
                    er.Run(random.Next(10, 100), random.Next(10, 100), random.Next(1, 5));
                }
                catch (ThreeException er)
                {

                }

            }
        }

    }
}
