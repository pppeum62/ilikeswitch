using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilikeswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            // 다음 if 조건문으로 작성된 프로그램을 switch 조건문으로 옮기세요

            Console.Write("학년을 입력하세요 >> ");
            int level = int.Parse(Console.ReadLine());

            switch(level)
            {
                case 1:
                    Console.WriteLine("수강해야 하는 전공 학점 : 12학점");
                    break;
                case 2:
                    Console.WriteLine("수강해야 하는 전공 학점 : 18학점");
                    break;
                case 3:
                    Console.WriteLine("수강해야 하는 전공 학점 : 10학점");
                    break;
                case 4:
                    Console.WriteLine("수강해야 하는 전공 학점 : 18학점");
                    break;
                default:
                    Console.WriteLine("입력 값을 확인해주세요");
                    break;
            }
        }
    }
}
