using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gugudan

{
    // 입력받은 숫자는 : 입력한 변수
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하시오");

            string input = Console.ReadLine();
            int inputNumber = int.Parse(input);

            Console.WriteLine("입력받은 숫자는: " + inputNumber);

            for ( int i = 1; i<=19; i++)
            {
                Console.WriteLine(inputNumber+"X" + i + "=" + 2 * i);
            }
            Console.ReadLine();
            

        }
       
      }
          
        
    }

