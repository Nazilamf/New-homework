using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Net.WebSockets;
using System.Security;

namespace New_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // var result = NewString("Salam",3);
            //Console.WriteLine(result);

            //string[] names = { "Cavid", "Leyla", "Gunel", "Tural", "Nermin" };

            //var result = FindName(names, "Melek");
            //Console.WriteLine(result);


            //int[] numbers = { 45, 78, 82, 12, 5, 77 };

            //var result = FindNum(numbers, 78);
            //Console.WriteLine(result);


            //int[] array = { 14, 66, , 55, 89 };
            //var check = HasValue(array, numbers);
            //Console.WriteLine(check);


            //var cavab = IsDigit('a');
            //Console.WriteLine(cavab);


            //var word = HasDigit("Baku2023");
            //Console.WriteLine(word);


            //Console.WriteLine(FindIndex("Baku" ,'d'));


            //Layihe ise dusdukdue console-dan email deyeri daxil etmeyimizi istesin
            //Eger email @ simvolu yoxdursa yeniden daxil etmeyimizi istesin


            //string email;

            //do
            //{
            //    Console.WriteLine("Email daxil edin:");
            //    email = Console.ReadLine();

            //} while(FindIndex(email,'@') == -1);




            //Console.WriteLine(Newstr("Salam"));



            //int[] array = { 25, 117, 5, 89 };
            //var min = Findmax(array);   
            //Console.WriteLine(min);




            //Console.WriteLine(Quvvet(5, 3)) ;



            //var cavab = (FindWord("Hello World"));
            //Console.WriteLine(cavab);

            //string[] array = { "I", " ", "love", " ", "Baku" };
            //var result = CountWord(array);
            //Console.WriteLine(result);



            string[] arr= { "salam", "2", "baku", "london", "62", "88" };
            var result = CountDigit(arr);
            Console.WriteLine(result);




            //var result = ReturnIndex("  Baku");
            //Console.WriteLine(result);



            //var result = ReturnWord("a       Hello World ! ! !    b");
            //Console.WriteLine(result);



        }







        //Verimis yazini verilmis indexe qeder kesib qaytaran metod


        static string NewString(string str, int index)
        {
            string Newstr = "";

            for (int i = 0; i < index; i++)
            {

                {
                    Newstr += str[i];
                }
            }
            return Newstr;
        }


        //Verilmis adlar siyahisinda verilmis adin olub olmadigini tapan metod


        static bool FindName(string[] names, string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    return true;


            }

            return false;



        }



        //Verilmis ededler siyahisinda verilmis ededin oldub olmaddigini tapan metod


        static bool FindNum(int[] numbers, int num)
        {
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] == num)
                    return true;
            }
            return false;
        }




        //Verilmis ededler siyahisinda verilis diger ededler siyahisindan hansisa
        //ededin olub olmadigini tapan metod


        static bool HasNum(int[] numbers, int[] numbers2)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers2.Length; j++)
                {
                    if (numbers[i] == numbers2[j])
                        return true;
                }

            }
            return false;
        }



        static bool HasValue(int[] arr, int[] arr2)
        {
            for (int i = 0; i < arr2.Length; i++)

                if (FindNum(arr, arr2[i]))

                {
                    return true;
                }

            return false;
        }

        //Verilmis charin reqem olub olmadigini tapan bir metod


        static bool IsDigit(Char cr)
        {
            int[] array = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == cr)
                {
                    return true;
                }

            }
            return false;
        }


        //Verilmis yazida reqem olub olmadigini tapan bir metod


        static bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (IsDigit(str[i]))
                {
                    return true;
                }
            }

            return false;
        }


        //Verilmis yazinin icerisinde verilmis charin indexini tapan metod


        static int FindIndex(string str, char cr)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == cr)
                {
                    return i;
                }

            }
            return -1;
        }



        //Verilmis yazidan yalniz cut indexlerinde duran charlardan yeni bir yazi duzelden metod

        static string Newstr(string str)
        {
            string Newstr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Newstr += str[i];
                }
            }
            return Newstr;
        }



        //Verilmis ededler siyahisindaki en boyuk ededi tapan metod

        static int Findmax(int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }
            return max;
        }


        //Verilmis ededi verilmis quvvete yukselden metod

        static int Quvvet(int num, int pow)
        {
            int result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }
            return result;
        }

        //New homework


        //Verilmiş string dəyərindəki ilk sözü tapan metod (ilk söz ilk boşluğa qədərki ifadədir)

        static string FindWord(string str)
        {

            string newstr = " ";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    newstr += str[i];
                }

                else break;

            }


            return newstr;
        }




        // Verilmiş string dəyərindəki sözlərin sayını tapan metod (boşluqlarla ayrılan
        // bütün ifadələri söz kimi nəzərə alın)


        static int CountWord(string[] arr)
        {
            int Count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != " ")
                {
                    Count++;

                }



            }
            return Count;
        }


        



        //Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod

        static int CountDigit(string[] arr)
        {
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if(arr[i] == numbers[i])
                    {
                        count++;
                    }
                }
            }
           
            
            return count ;
        }


        //- Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod.
        //Misalçun "  Salam" yazısında S ilk boşluq olmayan char-dır.


        static int ReturnIndex(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    return i;
                }

            }
            return -1;
        }




        //- Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod


        static string ReturnWord(string str)
        {
            string newstr = " ";
            
          
            for (int i = 0; i < str.Length; i++)
            {

                while (str[i] != ' ' )
               
                {
                    newstr += str[i];
                    break;
                }

            }

            return newstr;





            
        }


        




    }
}




