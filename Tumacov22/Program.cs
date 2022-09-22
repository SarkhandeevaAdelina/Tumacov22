using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumacov22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dz31();
        }
        enum BankAccount : int
        {
            Current = 7854,
            Saving = 1235
        }
        public static void up31()
        {
            Console.WriteLine("Создать перечислимый тип данных, отображающий виды банковского счета (текущий и сберегательный). Создать " +
                "переменную типа перечисления, присвоить ей значение и вывести это значение на печать");

            Console.WriteLine("Значение текущего счета: ");
            Console.WriteLine((int)Program.BankAccount.Current);
            Console.WriteLine("Значение сберегательного счета: ");
            Console.WriteLine((int)Program.BankAccount.Saving);
            Console.ReadKey();
        }
        public static void up32()
        {
            Console.WriteLine("Cоздать структуру данных, которая хранит информацию о банковском счете - его номер, тип и баланс.Создать переменную такого типа, заполнить структуру значениями и напечатать результат");
         Account numberAccount;
        Account typeAccount;
        Account balanceAccount;
        numberAccount.number=564;
        typeAccount.type="saving";
        balanceAccount.balance=855555555;

        Console.WriteLine("Номер счета аккаунта:{0}",numberAccount.number);
            Console.WriteLine("Тип счета аккаунта:{0}",typeAccount.type);
            Console.WriteLine("Баланс счета аккаунта:{0}",balanceAccount.balance);
            Console.ReadKey();
        }
       
            public struct Account
        { public int number;
          public string type;
          public double balance;
         }
        public static void dz31()
        {
            Console.WriteLine("Создать перечислимый тип ВУЗ{КГУ, КАИ,  КХТИ}. Создать структуру работник с двумя полями: имя, ВУЗ. Заполнить  структуру данными и распечатать.");
            Employee NameEmployee;
            Employee UniverEmployee;
            Console.Write("Введите имя работника:");
            NameEmployee.Name = Console.ReadLine();
            Console.Write("Введите вуз работника:");
            UniverEmployee.Univer= Console.ReadLine();
            Console.WriteLine($"Имя работника:{NameEmployee.Name}\nВУЗ работника:{UniverEmployee.Univer}");
            Console.ReadKey();

        }
        enum Univer
        {
            КГУ,
            КАИ,
            КХТИ
        }
        public struct Employee
        {
            
            public string Name;
            public string Univer;
        }



    }
}
