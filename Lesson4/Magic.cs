using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public static class Magic
    {
        ///1.
        public static void CombinerName()
        { 
            Console.WriteLine("Введите имя");
            string Name=Console.ReadLine();
            Console.WriteLine("Введите фомилию");
            string LastName=Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string Patronimic=Console.ReadLine();
            Console.WriteLine("Полное имя:" + GetFullName2(Name, LastName, Patronimic));
        }

        
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return firstName + " " + lastName + " " + patronymic;
        }
        static string GetFullName2(string firstName, string lastName, string patronymic)
        {
           return string.Join(" ",firstName,lastName, patronymic);
        }
        ///2.
        public static void GetSumOfElementsOfString()
        {
            Console.WriteLine("ВВедите строку для сложения");
            string myString = Console.ReadLine();
            double sumOfElements = 0;
            string[] stringArray=myString.Split(" ".ToCharArray());
            foreach(string str in stringArray)
            {
                if (int.TryParse(str, out int number))
                {
                    sumOfElements += number;
                    continue;
                }
                if (double.TryParse(str,out double doubleNumber))
                    sumOfElements += doubleNumber;
            }
            Console.WriteLine(sumOfElements);            
        }
        ///3.
        public  static void GetSeasonByMonth()
        {
            Console.WriteLine("Введите номер месяца");
            bool flag=true;
            while(flag)
            {
                try 
	            {
                    bool flag2=true;
                    if(int.TryParse(Console.ReadLine(),out int monthNumber)&&(monthNumber>0&&monthNumber<=12))
                    {
                        Console.WriteLine(GetSeasonString(GetSeasonByEnum(monthNumber)));
                        flag=false;
                    }
                    else
	                {
                        throw new Exception("Ошибка: введите число от 1 до 12");
	                }
		
	            }
	            catch (Exception ex)
	            {
                    Console.WriteLine(ex.Message);
	            }
            }   

            
        }
        enum SeasonEnum
        {
            Winter,
            Spring,
            Summer,
            Autumn,
            Error = -1
        }
        static SeasonEnum GetSeasonByEnum(int monthNumber)
        {
            try
            {
                
                switch ((monthNumber % 12) / 3)
                {
                    case 0:
                        return SeasonEnum.Winter;
                    case 1:
                        return SeasonEnum.Spring;
                    case 2:
                        return SeasonEnum.Summer;
                    case 3:
                        return SeasonEnum.Autumn;
                        break;

                }
                return SeasonEnum.Error;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return SeasonEnum.Error;
            }
        }
        static string GetSeasonString(SeasonEnum seasonEnum)
        {
            switch (seasonEnum)
            {
                case SeasonEnum.Winter:
                    return "Зима";
                case SeasonEnum.Spring:
                    return "Весна";
                case SeasonEnum.Summer:
                    return "Лето";
                case SeasonEnum.Autumn:
                    return "Осень";
                    break;
            }
            return "error";
        }
        ///4.
        public static void PrintFibonachi()
        {
            bool flag=true;
            Console.WriteLine("Введите число");
            while (flag)
            {
                if(int.TryParse(Console.ReadLine(),out int number))
                {
                    Console.WriteLine(FibonachiCalc(number));
                    flag=false;
                    
                }
                else
                {
                    Console.WriteLine("ошибка, введитее число");
                }
            }
        }
        static int FibonachiCalc(int n)
        {
            if(n==0)
                return 0;
            if(n==1)
                return 1;
            return FibonachiCalc(n-1)+FibonachiCalc(n-2);
        }
    }

}
