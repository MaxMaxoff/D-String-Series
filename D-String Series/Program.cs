using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// http://ejudge.1gb.ru/cgi-bin/new-register?contest_id=9
/// D-String Series
/// 
/// На вход программе подаются сведения о номерах школ учащихся, участвовавших в олимпиаде.
/// В первой строке сообщается количество учащихся N, каждая из следующих N строк имеет формат: 
/// [Фамилия] [Инициалы] [номер школы]
/// где
/// [Фамилия] – строка, состоящая не более чем из 20 символов,
/// [Инициалы] – строка, состоящая из 4-х символов(буква, точка, буква, точка),
/// [номер школы] – не более чем двузначный номер.
/// [Фамилия] и[Инициалы], а также[Инициалы] и[номер школы] разделены одним пробелом.
/// Пример входной строки: 
/// Иванов П.С. 57 
/// Требуется написать как можно более эффективную программу, которая будет выводить на экран информацию, из какой школы было меньше всего участников(таких школ может быть несколько).
/// При этом необходимо вывести информацию только по школам, пославшим хотя бы одного участника.
/// Следует учитывать, что N>=1000.
/// </summary>
namespace D_String_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays of schools
            int[] schools = new int[100];
            
            // Prepare console
            Console.ForegroundColor = ConsoleColor.Green;

            // read line count
            int n = Int32.Parse(Console.ReadLine());

            // frequency array of schools
            for (int i = 0; i < n; i++)
            {
                // split line using space symbol to new string array
                string[] a = Console.ReadLine().Split(' ');

                schools[Int32.Parse(a[2])]++;
            }

            // find minimum > 0
            int min = n;
            for (int i = 0; i < 100; i++) if (schools[i] < min && schools[i] != 0) min = schools[i];

            // print out all schools with equal min value
            for (int i = 0; i < 100; i++) if (schools[i] == min) Console.WriteLine($"{i}");

            Console.ReadKey();

        }
    }
}
