using System;

namespace CurrencyTransfer
{
    class User 
    {
        private string _userName;
        private decimal _currencyBalance;

        public decimal CurrencyBalance
        {
            get => _currencyBalance;
            set
            {
                if (value < 0 || value > decimal.MaxValue)
                {
                    Console.WriteLine("Сумма баланса не является возможной");
                }
                else
                {
                    _currencyBalance = value;
                }
            }
        }

        public void EnterTheBalance()
        {
            decimal result;
            Console.Write("Введите сумму пополнения баланса:");
            string value = Console.ReadLine();

            if (decimal.TryParse(value, out result))
            {
                CurrencyBalance = result;
            }
            else
            {
                Console.WriteLine("Введено недопустимое значение счета");
            }
        }

        
        public string UserName
        {
            get => _userName;
            set
            {
                if (value.Length > 10 || value.Length == 0)
                {
                    Console.WriteLine("Слишком длинное имя пользователя или Вы ничего не ввели!");
                }
                else
                {
                    _userName = value;
                }
            }
        }

        public User() 
        {
            
        }

        public void EnteringUserName()
        {
            Console.WriteLine("Введите имя пользователя");
            UserName = Console.ReadLine();
        }

        public void DisplayUserInfo()
        {
            Console.WriteLine($"Имя пользователя: {UserName}");
            Console.WriteLine($"Ваш баланс равен: {CurrencyBalance} руб.");
        }
    }
}

