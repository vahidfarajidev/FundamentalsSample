// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using FundamentalsSample.FuncUsage.InjectingLogicWithFunc;

var processor = new PaymentProcessor(amount => amount < 1000);
processor.Pay(500);

Console.ReadLine();