using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{

    ///<summary>
    ///Создаем структуру студента
    ///</summary>
    struct Student
    {
        ///<summary>
        ///Фамилия студента
        ///</summary>
        public string Surname;
        ///<summary>
        ///Имя студента
        ///</summary>
        public string Name;
        ///<summary>
        ///ID студента
        ///</summary>
        public int ID;
        ///<summary>
        ///Дата рождения
        ///</summary>
        public DateTime DateOfBirth;
        ///<summary>
        ///Категория алкоголизма
        ///</summary>
        public string Category;
        ///<summary>
        ///Количество выпитого
        ///</summary>
        public double VolumeDrunk;
        ///<summary>
        ///Предпочитаемый напиток
        ///</summary>
        public Drink FavoriteDrink;
    }
    ///<summary>
    ///Создаем структуру для напитков
    ///</summary>
    struct Drink
    {
        ///<summary>
        ///Название напитка
        ///</summary>
        public string Title;
        ///<summary>
        ///Процентное содержание алкоголя в напитке
        ///</summary>
        public double AlcoholPercentage;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Выведите на экран информацию о каждом типе данных в виде: Тип данных – максимальное значение – минимальное значение
            Console.WriteLine("Задание 1");
            Console.WriteLine($"Тип данных int: - Максимальное значение: {int.MaxValue} - Минимальное значение: {int.MinValue}");
            Console.WriteLine($"Тип данных uint: - Максимальное значение: {uint.MaxValue} - Минимальное значение: {uint.MinValue}");
            Console.WriteLine($"Тип данных long: - Максимальное значение: {long.MaxValue} - Минимальное значение: {long.MinValue}");
            Console.WriteLine($"Тип данных ulong: - Максимальное значение: {ulong.MaxValue} - Минимальное значение: {ulong.MinValue}");
            Console.WriteLine($"Тип данных short: - Максимальное значение: {short.MaxValue} - Минимальное значение: {short.MinValue}");
            Console.WriteLine($"Тип данных ushort: - Максимальное значение: {ushort.MaxValue} - Минимальное значение: {ushort.MinValue}");
            Console.WriteLine($"Тип данных float: - Максимальное значение: {float.MaxValue} - Минимальное значение: {float.MinValue}");
            Console.WriteLine($"Тип данных double: - Максимальное значение: {double.MaxValue} - Минимальное значение: {double.MinValue}");
            Console.WriteLine($"Тип данных byte: - Максимальное значение: {byte.MaxValue} - Минимальное значение: {byte.MinValue}");
            Console.WriteLine($"Тип данных sbyte: - Максимальное значение: {sbyte.MaxValue} - Минимальное значение: {sbyte.MinValue}");
            Console.WriteLine($"Тип данных decimal: - Максимальное значение: {decimal.MaxValue} - Минимальное значение: {decimal.MinValue}");

            //Напишите программу, в которой принимаются данные пользователя в виде имени, города, возраста и PIN - кода.
            //Далее сохраните все значение в соответствующей переменной, а затем распечатайте всю информацию в правильном формате.
            Console.WriteLine("\nЗадание 2");
            string name, city;
            int age, PIN;
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите город: ");
            city = Console.ReadLine();
            Console.Write("Введите возраст (полных лет): ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите PIN-код (в цифровом виде): ");
            PIN = Convert.ToInt32(Console.ReadLine());
            if ((age <= 0) || (PIN <= 0))
            {
                string user = String.Format($"\nИмя: {name} Город: {city} Возраст: {age} PIN-код: {PIN}");
                Console.WriteLine($"\nИнформация о пользователе: {user}");
            }
            else
            {
                Console.WriteLine("Вы ошиблись при вводе данных");
            }


            //Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на строчные.
            Console.WriteLine("\nЗадание 3");
            Console.Write("Введите букву/слово для преобразования: ");
            string stringnew = Console.ReadLine();
            string stringresult = "";
            foreach (var a in stringnew)
            {
                if (char.IsLower(a))
                {
                    stringresult = stringresult + char.ToUpper(a);
                }
                else
                {
                    stringresult = stringresult + char.ToLower(a);
                }
            }
            Console.WriteLine(stringresult);

            //Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести на экран.
            Console.WriteLine("\nЗадание 4");
            Console.Write("Введите строку: ");
            string string1 = Console.ReadLine();
            Console.Write("Введите подстрoку: ");
            string substring = Console.ReadLine();
            Console.WriteLine((string1.Length - string1.Replace(substring, "").Length) / substring.Length);

            //Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам нужно будет купить, чтобы экономия
            //по сравнению с обычной средней ценой фактически покрыла расходы на ваш отпуск.
            //Вам будет предоставлена стандартная цена(normPrice), скидка в Duty Free(salePrice) и стоимость отпуска(holidayPrice).
            //Все входные данные будут целыми числами.Пожалуйста, верните целое число.Округлить в меньшую сторону.
            Console.WriteLine("\nЗадание 5");
            int normPrice, salePrice, holidayPrice;
            Console.Write("Введите стандартную цену: ");
            normPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите скидку в Duty Free: ");
            salePrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите стоимость отпуска: ");
            holidayPrice = Convert.ToInt32(Console.ReadLine());
            if ((normPrice > 0) && (salePrice > 0) && (holidayPrice > 0))
            {
                int discount = normPrice / 100 * salePrice;
                int bottles = holidayPrice / discount;
                Console.WriteLine(bottles);
            }
            else
            {
                Console.WriteLine("Вы ошиблись при вводе данных");
            }

            //Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата рождения, Категория алкоголизма(a – студент алкоголик,
            //b – студент любитель выпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у студента есть
            //Объем выпитой жидкости конкретного напитка.Создать 5 студентов с различными параметрами.
            //Посчитать общий объем выпитого, общий объем алкоголя (процент спирта) и кто сколько процентов алкоголя и жидкости от
            //общего количества выпил.Предполагается, что студент пьет один вид напитка.
            //Напитки задать в виде структуры: наименование типа напитка и процент спирта.
            Console.WriteLine("\nЗадание 6");
            Drink drink1 = new Drink();
            drink1.Title = "Водка";
            drink1.AlcoholPercentage = 40.0;
            Drink drink2 = new Drink();
            drink2.Title = "Вино";
            drink2.AlcoholPercentage = 14.0;
            Drink drink3 = new Drink();
            drink3.Title = "Пиво";
            drink3.AlcoholPercentage = 7.0;
            Drink drink4 = new Drink();
            drink4.Title = "Вода";
            drink4.AlcoholPercentage = 0.0;
            Drink drink5 = new Drink();
            drink5.Title = "Шампанское";
            drink5.AlcoholPercentage = 10.0;

            Student student1 = new Student();
            student1.Surname = "Шилов";
            student1.Name = "Марк";
            student1.ID = 111;
            student1.DateOfBirth = new DateTime(2001, 11, 11);
            student1.Category = "c";
            student1.VolumeDrunk = 10.0;
            student1.FavoriteDrink = drink2;

            Student student2 = new Student();
            student2.Surname = "Овсянников";
            student2.Name = "Леонид";
            student2.ID = 222;
            student2.DateOfBirth = new DateTime(2002, 12, 22);
            student2.Category = "b";
            student2.VolumeDrunk = 50.0;
            student2.FavoriteDrink = drink3;

            Student student3 = new Student();
            student3.Surname = "Степанов";
            student3.Name = "Ярослав";
            student3.ID = 333;
            student3.DateOfBirth = new DateTime(2003, 03, 31);
            student3.Category = "a";
            student3.VolumeDrunk = 100.0;
            student3.FavoriteDrink = drink1;

            Student student4 = new Student();
            student4.Surname = "Макарова";
            student4.Name = "Василиса";
            student4.ID = 444;
            student4.DateOfBirth = new DateTime(2004, 04, 14);
            student4.Category = "d";
            student4.VolumeDrunk = 100.0;
            student4.FavoriteDrink = drink4;

            Student student5 = new Student();
            student5.Surname = "Попова";
            student5.Name = "Ника";
            student5.ID = 555;
            student5.DateOfBirth = new DateTime(2005, 05, 15);
            student5.Category = "c";
            student5.VolumeDrunk = 5.0;
            student5.FavoriteDrink = drink5;

            double allVolumDrunk = (student1.VolumeDrunk + student2.VolumeDrunk + student3.VolumeDrunk + student4.VolumeDrunk + student5.VolumeDrunk);
            double allAlcohol = (student1.VolumeDrunk * drink2.AlcoholPercentage / 100 + student2.VolumeDrunk * drink3.AlcoholPercentage / 100 + student3.VolumeDrunk * drink1.AlcoholPercentage / 100 + student4.VolumeDrunk * drink4.AlcoholPercentage / 100 + student5.VolumeDrunk * drink5.AlcoholPercentage / 100);
            Console.WriteLine($"Количество всех выпитых напитков студентами: {allVolumDrunk}");
            Console.WriteLine($"Общий объем алкоголя: {allAlcohol}");
            Console.WriteLine($"{student1.Surname} {student1.Name} выпил {student1.VolumeDrunk * 100 / allVolumDrunk:F1}% от общего объёма напитков ({student1.VolumeDrunk * drink2.AlcoholPercentage / 100} л алкоголя) это {student1.VolumeDrunk * drink2.AlcoholPercentage / allAlcohol:F1}% от общего выпитого алкоголя");
            Console.WriteLine($"{student2.Surname} {student2.Name} выпил {student2.VolumeDrunk * 100 / allVolumDrunk:F1}% от общего объёма напитков ({student2.VolumeDrunk * drink3.AlcoholPercentage / 100} л алкоголя) это {student2.VolumeDrunk * drink3.AlcoholPercentage / allAlcohol:F1}% от общего выпитого алкоголя");
            Console.WriteLine($"{student3.Surname} {student3.Name} выпил {student3.VolumeDrunk * 100 / allVolumDrunk:F1}% от общего объёма напитков ({student3.VolumeDrunk * drink1.AlcoholPercentage / 100} л алкоголя) это {student3.VolumeDrunk * drink1.AlcoholPercentage / allAlcohol:F1}% от общего выпитого алкоголя");
            Console.WriteLine($"{student4.Surname} {student4.Name} выпила {student4.VolumeDrunk * 100 / allVolumDrunk:F1}% от общего объёма напитков ({student4.VolumeDrunk * drink4.AlcoholPercentage / 100} л алкоголя) это {student4.VolumeDrunk * drink4.AlcoholPercentage / allAlcohol:F1}% от общего выпитого алкоголя");
            Console.WriteLine($"{student5.Surname} {student5.Name} выпила {student5.VolumeDrunk * 100 / allVolumDrunk:F1}% от общего объёма напитков ({student5.VolumeDrunk * drink5.AlcoholPercentage / 100} л алкоголя) это {student5.VolumeDrunk * drink5.AlcoholPercentage / allAlcohol:F1}% от общего выпитого алкоголя");
        }
    }
}
