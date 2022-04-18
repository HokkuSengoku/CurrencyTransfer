using System;



namespace CurrencyTransfer
{
    static class Conversion
    {
        public static  decimal usdRub;

        
        static Conversion()
        {
            usdRub = 75M;
        }
        public static void SetUsdCourse(decimal newUsd) => usdRub = newUsd;
        
        public static decimal GetUsdCourse() => usdRub;
        public static void ShowUsdCourse()
        {
            Console.WriteLine($"На данный момент 1$ США равен {usdRub} рублей.");
        }
        
        public static void ConversionToUSD(decimal usd, decimal rub)
        {
            Console.WriteLine($"Перевод из рублей в доллары составил: {rub / usd} долларов.");
            Console.WriteLine($"Перевод выполнен по курсу 1 доллар = {usd} рублей");
        }
    }
}
