using System;
using System.Text;
using static System.Console;//щоб не писати консоле кожен раз

namespace Сшарппочаток
{
    class Program
    {
        static void Main()
        {
            OutputEncoding = Encoding.Unicode;//для кирилиці
                                              //Завдання 1
            WriteLine("Введіть число від 1 до 100");
            String b = ReadLine();//считую консоль

            int a = Convert.ToInt32(b);//конвертую зачення в інт 

            if (a <= 0 || a > 100) //роблю перевірки за умовою завдання
            {
                WriteLine("Ви ввели некоректне значення !");
            }
            else if (a % 3 == 0 && a % 5 == 0)
            {
                WriteLine("Fizz Buzz");
            }
            else if (a % 3 == 0)
            {
                WriteLine("Fizz");
            }
            else if (a % 5 == 0)
            {
                WriteLine("Buzz");
            }
            else
            {
                WriteLine(a);
            }


            //Завдання 2
            WriteLine("Введіть два числа.Перше число - значення ,а друге число процент який необхідно порахувати від першого ");
            double a1 = Convert.ToDouble(ReadLine());
            double a2 = Convert.ToDouble(ReadLine());

            double results = a1 * a2 / 100;//пропорція

            WriteLine($"Результат { results} ");

            //Завдання 3
            WriteLine("Введіть чотири цифри  ");
            String c = ReadLine();
            String c1 = ReadLine();
            String c2 = ReadLine();
            String c3 = ReadLine();

            String sum = c + c1 + c2 + c3;//конкатенація           

            int num = Convert.ToInt32(sum);
            WriteLine(num);

            //Завдання 4
            WriteLine("Введіть шестизначне число ");
            int newnumb = Convert.ToInt32(ReadLine());
            if (newnumb >= 100000 && newnumb <= 999999)//перевірка на коректність введення числа
            {
                int six = newnumb % 10;//розбиваю шестизначне число 
                newnumb = newnumb / 10;
                int fif = newnumb % 10;
                newnumb = newnumb / 10;
                int four = newnumb % 10;
                newnumb = newnumb / 10;
                int thre = newnumb % 10;
                newnumb = newnumb / 10;
                int two = newnumb % 10;
                newnumb = newnumb / 10;
                int one = newnumb % 10;//на окремі цифри

                int[] arr = { one, two, thre, four, fif, six };//закидую цифри в масив за напрямком як вони були в числі
                int[] arr2 = new int[6];//створюю масив для нового перетвореного числа

                WriteLine("\n\tВведіть індекси цифр які хочете поміняти місцями  ");
                WriteLine("Наприклад: ви вели число 345678 , а потім ввели індекси 3 та 5 ,то врезультаті отримаєте число 347658  ");
                int t1 = Convert.ToInt32(ReadLine());
                int t2 = Convert.ToInt32(ReadLine());
                int q1 = t1 - 1;//віднімаю 1 від індекса оскільки в масиві перше число піл 0 індексом
                int q2 = t2 - 1;

                for (int i = 0; i < 6; i++)//запускаю цикл в якому заповнюю другий масив
                {
                    if (i != q1 && i != q2)//умови за якими
                    {
                        arr2[i] = arr[i];
                    }
                    else if (i == q1)//другий масив запоаниться значеннями першого масиву
                    {
                        arr2[i] = arr[q2];
                    }
                    else if (i == q2)//але поміняютясядва числа місцями відповідно до введених індексів
                    {
                        arr2[i] = arr[q1];
                    }
                }

                String nt1 = Convert.ToString(arr2[0]);
                String nt2 = Convert.ToString(arr2[1]);
                String nt3 = Convert.ToString(arr2[2]);
                String nt4 = Convert.ToString(arr2[3]);
                String nt5 = Convert.ToString(arr2[4]);
                String nt6 = Convert.ToString(arr2[5]);
                String nt7 = nt1 + nt2 + nt3 + nt4 + nt5 + nt6;
                int finall = Convert.ToInt32(nt7);//перетворюю в інт число яке в стрінгу
                
                WriteLine(finall);

            }
            else
            {
                WriteLine("\t\tОй , помилка ви ввели неправельне число! ");
            }


            //Завдання 5
            WriteLine("\nВведіть дату ");
            DateTime newdt = Convert.ToDateTime(ReadLine());

            if (newdt.Month == 1 || newdt.Month == 2 || newdt.Month == 12) { WriteLine("Winter"); }//умови виводу пір року
            else if (newdt.Month == 3 || newdt.Month == 4 || newdt.Month == 5) { WriteLine("Spring"); }
            else if (newdt.Month == 6 || newdt.Month == 7 || newdt.Month == 8) { WriteLine("Summer"); }
            else if (newdt.Month == 9 || newdt.Month == 10 || newdt.Month == 11) { WriteLine("Autumm"); }

            WriteLine(newdt.DayOfWeek);

            //Завдання 6
            WriteLine("\nВведіть температуру за цельсієм або фаренгейтом  ");
            int tem = Convert.ToInt32(ReadLine());
            WriteLine("\nВведіть варіант перетворення температури\n1:покаже температуру за целбсцієм\n2:покаже тепературу за фаренгейтом  ");
            int f = Convert.ToInt32(ReadLine());
            switch (f)
            {
                case 1:
                    double cels = (tem - 32) / 1.8;
                    WriteLine($"За целсієм {cels} градусів"); break;
                case 2:
                    double faren = tem * 1.8 + 32;
                    WriteLine($"За фаренгейтом {faren} градусів "); break;
                default:
                    WriteLine("Ви вели не коректну функцію");
                    break;
            }

            //Завдання 7
            WriteLine("\nВведіть два числа для діапазону пошуку парних чисел");
            int beggin = Convert.ToInt32(ReadLine());
            int end = Convert.ToInt32(ReadLine());
            int beggin2=0;
            int end2=0;
            if (beggin < end) //умова за якої значення моміняються місцями якщо користувач ввів наприклад 30 а потім 15 
            {
                beggin2 = beggin;
                end2 = end;
            }
            else if (beggin>end)
            {
                beggin2 = end;
                end2 = beggin;
            }

            for (int i = beggin2; i <= end2; i++)
            {
                if (i % 2 == 0) //пошук парних чисел
                {
                    WriteLine("Число "+ i +" парне");
                }
            }
        }
    }
}
