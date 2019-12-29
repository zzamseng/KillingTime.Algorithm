using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001
{
    class Program
    {
        //시간 제한    메모리 제한  제출 정답  맞은 사람   정답 비율
        //2 초	128 MB	103526	72483	63764	72.143%
        //문제
        //두 정수 A와 B를 입력받은 다음, A-B를 출력하는 프로그램을 작성하시오.

        //입력
        //첫째 줄에 A와 B가 주어진다. (0 < A, B< 10)

        //출력
        //첫째 줄에 A-B를 출력한다.

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please Input A, B (0 < A, B < 10)");
                var line = Console.ReadLine();

                var numbers = line.Split(',');

                if (numbers.Length == 2)
                {
                    if (int.TryParse(numbers[0], out int a))
                    {
                        if (!(0 < a))
                            Console.WriteLine("have to 0 < A");
                        else
                        {
                            if (int.TryParse(numbers[1], out int b))
                            {
                                if (!(b < 10))
                                    Console.WriteLine("have to B < 10");
                                else
                                {
                                    Console.WriteLine($"A-B = {a - b}");
                                }

                            }
                            else
                                Console.WriteLine("This is not nubmer");
                        }
                    }
                    else
                        Console.WriteLine("This is not nubmer");
                }
                else
                {
                    Console.WriteLine("You have to Input (A,B)");
                }

                Console.WriteLine("Please enter for retry");
                Console.ReadLine();
            }

        }
    }
}
