using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    ///<summary>
    ///Перечислимый тип данных, отображающий виды банковского счета
    ///</summary>
    enum TypesOfBankAccount
    {
        ///<summary>
        ///Текущий
        ///</summary>
        Сurrent,
        ///<summary>
        ///Сберегательный
        ///</summary>
        Savings
    }

    ///<summary>
    ///Структура Банковского счёта
    ///</summary>
    struct BankAccount
    {
        ///<summary>
        ///Номер банковского счёта
        ///</summary>
        public string number;
        ///<summary>
        ///Тип банковского счёта
        ///</summary>
        public TypesOfBankAccount type;
        ///<summary>
        ///Баланс банковского счета
        ///</summary>
        public int balance;
    }
    ///<summary>
    ///Перечислимый тип ВУЗ
    ///</summary>
    enum ВУЗ
    {
        ///<summary>
        ///ВУЗ КГУ
        ///</summary>
        КГУ,
        ///<summary>
        ///ВУЗ КАИ
        ///</summary>
        КАИ,
        ///<summary>
        ///ВУЗ КХТИ
        ///</summary>
        КХТИ
    }
    ///<summary>
    ///Сруктура работника
    ///</summary>
    struct Работник
    {
        ///<summary>
        ///Имя работника
        ///</summary>
        public string name;
        ///<summary>
        ///Место работы
        ///</summary>
        public ВУЗ university;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создать перечислимый тип данных отображающий виды банковского счета(текущий и сберегательный).
            //Создать переменную типа перечисления, присвоить ей значение и вывести это значение на печать.
            Console.WriteLine("Упражнение 3.1");
            TypesOfBankAccount FirstTypesOfBankAccount = new TypesOfBankAccount();
            Console.WriteLine(FirstTypesOfBankAccount);

            // Создать структуру данных, которая хранит информацию о банковском счете – его номер, тип и баланс.
            // Создать переменную такого тип, заполнить структуру значениями и напечатать результат.
            Console.WriteLine("\nУпражнение 3.2");
            BankAccount FirstBankAccount = new BankAccount();
            FirstBankAccount.number = "525252";
            FirstBankAccount.type = TypesOfBankAccount.Сurrent;
            FirstBankAccount.balance = 123456789;
            Console.WriteLine($"Информация о банковском счёте \nНомер банковского счёта: {FirstBankAccount.number} \nТип банковского счёта: {FirstBankAccount.type} \nБаланс банковского счёта: {FirstBankAccount.balance}");


            //Создать перечислимый тип ВУЗ {КГУ, КАИ, КХТИ}.
            //Создать структуру работник с двумя полями: имя, ВУЗ.Заполнить структуру данными и распечатать.
            Console.WriteLine("\nДомашнее задание 3.1");
            Работник worker = new Работник();
            worker.name = "Дмитрий";
            worker.university = ВУЗ.КХТИ;
            Console.WriteLine($"Информация о Работнике \nИмя: {worker.name} \nВУЗ: {worker.university}");
        }
    }
}
