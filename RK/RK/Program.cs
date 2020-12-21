using System;

namespace RK
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account<int> acc1 = new Account<int>(1857) { Sum = 4500 };
            Account<int> acc2 = new Account<int>(3453) { Sum = 5000 };

            Transaction<Account<int>> transaction1 = new Transaction<Account<int>>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 6900
            };
            transaction1.Execute();

            Console.Read();
        }
    }
    //class Account<T>
    //{
    //    public T Id { get; private set; } // номер счета
    //    public int Sum { get; set; }
    //    public Account(T _id)
    //    {
    //        Id = _id;
    //    }
    //}

    class Fig <T>
    {
        public T Id { get; private set; } // id 
        public T A { get; set; } // сторона фигуры
        public Fig(T _id)
        {
            Id = _id;
        }
    }

    class Square_ <T> where T : Fig<int>
    {
        public T Fig_1 { get; set; }  // первая фигура 
        public T Fig_2 { get; set; }    // вторая фигура
        

        public void Execute()
        {
            if (Math.Pow(Fig_1.A, 2) != Math.Pow(Fig_2.A, 2))
            {
                if (Math.Pow(Fig_1.A, 2) > Math.Pow(Fig_2.A, 2))
                {
                    Console.WriteLine($"{Math.Pow(Fig_1.A, 2)}>{Math.Pow(Fig_2.A, 2)}$ \n То есть площадь фигуры {Fig_1.Id}>{Fig_2.Id}$");
                }

                else
                {
                    Console.WriteLine($"{Math.Pow(Fig_1.A, 2)}<{Math.Pow(Fig_2.A, 2)}$ \n То есть площадь фигуры {Fig_1.Id}<{Fig_2.Id}$");
                }
            }
            else Console.WriteLine($"{Math.Pow(Fig_1.A, 2)}={Math.Pow(Fig_2.A, 2)}$ \n То есть площадь фигуры {Fig_1.Id}={Fig_2.Id}$");
        }
    }
}

//    class Transaction<T> where T : Account<int>
//    {
//        public T FromAccount { get; set; }  // с какого счета перевод
//        public T ToAccount { get; set; }    // на какой счет перевод
//        public int Sum { get; set; }        // сумма перевода

//        public void Execute()
//        {
//            if (FromAccount.Sum > Sum)
//            {
//                FromAccount.Sum -= Sum;
//                ToAccount.Sum += Sum;
//                Console.WriteLine($"Счет {FromAccount.Id}: {FromAccount.Sum}$ \nСчет {ToAccount.Id}: {ToAccount.Sum}$");
//            }
//            else
//            {
//                Console.WriteLine($"Недостаточно денег на счете {FromAccount.Id}");
//            }
//        }
//    }
//}
