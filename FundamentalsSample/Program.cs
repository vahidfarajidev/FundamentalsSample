// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//using FundamentalsSample.FuncUsage.InjectingLogicWithFunc;
//var processor = new PaymentProcessor(amount => amount < 1000);
//processor.Pay(500);


//using FundamentalsSample.FuncUsage.CallbackFunctionWithFunc;
//var downloader = new FileDownloader();
//downloader.Download("http://example.com/file.zip", percent => $"Progress: {percent}%");

//var validator = new InputValidator();
//string result = validator.Validate("hello123", value => value.Length >= 5 && value.All(char.IsLetterOrDigit));
//Console.WriteLine(result);

//result = validator.Validate("hell@", value => value.All(char.IsLetterOrDigit));
//Console.WriteLine(result);



using FundamentalsSample.FuncUsage.EventHandlingWithAction;

var button = new Button();
button.Clicked += name => Console.WriteLine($"{name} clicked!");

button.SimulateClick(); // Output: Button1 clicked!


Console.ReadLine();