using DesignPatternsC_.AdapterPattern;
using DesignPatternsC_.DependencyInjection;
using DesignPatternsC_.FactoryPattern;
using DesignPatternsC_.StrategyPattern;
using DesignPatternsC_.StrategyPatternEX2;
using System;

namespace DesignPatternsC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Factory Pattern in Action

            //Console.WriteLine("Enter document type (pdf, word, excel)");
            //string documentType = Console.ReadLine().ToLower();

            //try
            //{
            //    IDocument document = DocumentFactory.CreateDocument(documentType);
            //    document.Print();

            //    Console.ReadLine();
            //}
            //catch (Exception ex)
            //{ 
            //    Console.WriteLine(ex.Message);
            //}

            // 1. Factory Pattern in Action

            // 2. Strategy Pattern

            //Console.WriteLine("Enter the amount of tax calculation");
            //decimal amount = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("Select the country for tax calculation (USA, UK, Canada):");
            //string country = Console.ReadLine().ToLower();

            //ITaxStrategy taxStrategy;

            //switch(country)
            //{
            //    case "usa":
            //        taxStrategy = new USATaxStrategy();
            //        break;
            //    case "uk":
            //        taxStrategy = new UKTaxStrategy();
            //        break;
            //    case "canada":
            //        taxStrategy = new CanadaTaxStrategy();
            //        break;
            //    default:
            //        Console.WriteLine("Invalid country selection. Defaulting to USA");
            //        taxStrategy = new USATaxStrategy();
            //        break;
            //}

            //var taxCalculator = new TaxCalculator(taxStrategy);
            //decimal tax = taxCalculator.Calculate(amount);

            //Console.WriteLine($"The tax for {amount:C} is {tax:C}");

            //Console.ReadLine();

            // 2. Strategy Pattern


            // 3. Adapter Pattern

            //var thirdPartyService = new ThirdPartyPaymentService();

            //IPaymentProcessor paymentProcessor = new PaymentAdapter(thirdPartyService);

            //decimal amount = 100.50m;
            //paymentProcessor.ProcessPayment(amount);

            //Console.ReadLine();

            // 3. Adapter Pattern


            // 4. Dependency Injection

            //INotificationService emailService = new EmailNotificationService();
            //var emailNotificationManager = new NotificationManager(emailService);
            //emailNotificationManager.Notify("Hello via Email.");

            //INotificationService smsService = new SmsNotificationService();
            //var smsNotificationManager = new NotificationManager(smsService);
            //smsNotificationManager.Notify("Hello via SMS!");

            //Console.ReadLine();

            // 4. Dependency Injection



            // 5. Strategy Pattern Example 2
            Logger consoleLogger = new Logger(new ConsoleLogStrategy());
            consoleLogger.Log("This is a message logged to the console.");

            Logger fileLogger = new Logger(new FileLogStrategy());
            fileLogger.Log("This is a message logged to the file.");

            Logger databaseLogger = new Logger(new DatabaseLogStrategy());
            databaseLogger.Log("This is a message logged to the file.");


            Console.ReadLine();

            // 5. Strategy Pattern Example 2

        }
    }
}
