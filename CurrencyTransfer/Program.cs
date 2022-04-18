using CurrencyTransfer;

User first = new User();
first.EnteringUserName();
first.EnterTheBalance();
Console.Clear();
first.DisplayUserInfo();

Conversion.ShowUsdCourse();
Conversion.SetUsdCourse(78);
Conversion.ShowUsdCourse();
Conversion.ConversionToUSD(Conversion.usdRub, first.CurrencyBalance);
