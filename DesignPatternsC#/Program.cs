using DesignPatternsC_.AdapterPattern;
using DesignPatternsC_.DependencyInjection;
using DesignPatternsC_.FactoryPattern;
using DesignPatternsC_.ObserverPattern;
using DesignPatternsC_.RepositoryPattern;
using DesignPatternsC_.Singleton;
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
            //Logger consoleLogger = new Logger(new ConsoleLogStrategy());
            //consoleLogger.Log("This is a message logged to the console.");

            //Logger fileLogger = new Logger(new FileLogStrategy());
            //fileLogger.Log("This is a message logged to the file.");

            //Logger databaseLogger = new Logger(new DatabaseLogStrategy());
            //databaseLogger.Log("This is a message logged to the file.");


            //Console.ReadLine();

            // 5. Strategy Pattern Example 2


            // 6. Singleton Design Pattern

            //SingletonLogger logger1 = SingletonLogger.Instance();
            //SingletonLogger logger2 = SingletonLogger.Instance();

            //logger1.Log("This is the first log message");
            //logger2.Log("This is the first log message");

            //Console.WriteLine($"Are both instance the same? {ReferenceEquals(logger1, logger2)}");

            // 6. Singleton Design Pattern


            // 6. Singleton Design Pattern

            // Step 7: Create the WeatherStation (Subject)
            //WeatherStation weatherStation = new WeatherStation();

            //// Step 8: Create observers (MobileApp and Website)
            //MobileApp mobileApp = new MobileApp("MobileApp");
            //Website website = new Website("WeatherWebsite");

            //// Step 9: Register observers
            //weatherStation.RegisterObserver(mobileApp);
            //weatherStation.RegisterObserver(website);

            //// Step 10: Change the temperature and notify observers
            //Console.WriteLine("Wether update: Temperature changes to 25 C");
            //weatherStation.SetTemperature(25);

            //// Step 11: Unregister an observer (MobileApp)
            //weatherStation.RegisterObserver(mobileApp);

            //// Step 12: Change the temperature again
            //Console.WriteLine("Weather update: Temperature changes to 30 C");
            //weatherStation.SetTemperature(30);

            // 6. Singleton Design Pattern


            // 6. Repository Design Pattern

            IRepository<Customer> customerRepository = new CustomerRepository();

            customerRepository.Add(new Customer { Id = 1, Name = "John Deo", Email = "john@example.com" });
            customerRepository.Add(new Customer { Id = 2, Name = "Jane Smith", Email = "jane@example.com" });

            var customers = customerRepository.GetAll();
            Console.WriteLine("\nList of customers:");

            foreach(var customer in customers)
            {
                Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}, Email: {customer.Email}");
            }

            var customerToUpdate = new Customer { Id = 1, Name = "John Deo Modified", Email = "john.updated@example.com" };
            customerRepository.Update(customerToUpdate);

            var updatedCustomer = customerRepository.GetById(1);
            Console.WriteLine($"\nUpdated customer: {updatedCustomer.Id}, {updatedCustomer.Name}, {updatedCustomer.Email}");

            customerRepository.Delete(2);

            customers = customerRepository.GetAll();
            Console.WriteLine("\nRemaining customers:");
            foreach (var customer in customers)
            {
                Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}, Email: {customer.Email}");
            }

            // 6. Repository Design Pattern

            Console.ReadLine();

        }
    }
}
