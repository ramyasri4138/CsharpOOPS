using Csharp1;

//public class Program
//{
//    public static void Main()
//    {
//        BankAccount account = new BankAccount();

//        account.Deposit(1000);
//        account.Withdraw(500);
//        account.Withdraw(600);

//        Console.WriteLine($"Final balance: {account.GetBalance():C}");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        try
//        {
//            Student student = new Student("John Doe", 123);
//            Console.WriteLine($"Student: {student.Name1}, Roll No: {student.RollNo}");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}


//public class Program
//{
//    public static void Main()
//    {
//        Book defaultBook = new Book();
//        Console.WriteLine($"Default Book - Title: {defaultBook.Title}, Author: {defaultBook.Author}, ISBN: {defaultBook.ISBN}");

//        Book bookWithTitleAndAuthor = new Book("1984", "George Orwell");
//        Console.WriteLine($"Book with Title and Author - Title: {bookWithTitleAndAuthor.Title}, Author: {bookWithTitleAndAuthor.Author}, ISBN: {bookWithTitleAndAuthor.ISBN}");

//        Book bookWithAllDetails = new Book("1984", "George Orwell", "978-0451524935");
//        Console.WriteLine($"Book with All Details - Title: {bookWithAllDetails.Title}, Author: {bookWithAllDetails.Author}, ISBN: {bookWithAllDetails.ISBN}");
//    }
//}


//public class Program
//{
//    public static void Main()
//    {
//        Shape circle = new Circle(5);
//        Shape rectangle = new Rectangle(4, 6);

//        Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
//        Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Vehicle myCar = new Car();
//        Vehicle myBike = new Bike();

//        myCar.Start(); // Output: Car is starting with a roar...
//        myBike.Start(); // Output: Bike is starting with a zoom...
//    }
//}


//public class Program
//{
//    public static void Main()
//    {
//        Person student = new Student("Alice", 20, 12345);
//        Person teacher = new Teacher("Bob", 40, "Mathematics");

//        Console.WriteLine(student.GetDetails());
//        Console.WriteLine(teacher.GetDetails());
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Calculator calculator = new Calculator();

//        int sum1 = calculator.Add(5, 10);
//        int sum2 = calculator.Add(5, 10, 15);
//        double sum3 = calculator.Add(5.5, 10.5);

//        Console.WriteLine($"Sum of 5 and 10: {sum1}");
//        Console.WriteLine($"Sum of 5, 10, and 15: {sum2}");
//        Console.WriteLine($"Sum of 5.5 and 10.5: {sum3}");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        IPlayable musicPlayer = new MusicPlayer();
//        IPlayable videoPlayer = new VideoPlayer();

//        musicPlayer.Play(); 
//        videoPlayer.Play(); 
//    }
//}


//public class Program
//{
//    public static void Main()
//    {
//        Report report = new Report("Annual Report", "This is the content of the annual report.");
//        report.Print();

//        // Demonstrate ISerializable implementation
//        report.SaveToFile("report.txt");
//    }
//}


//public class Program
//{
//    public static void Main()
//    {
//        User admin = new Admin("Alice");
//        User customer = new Customer("Bob");

//        admin.AccessControl(); // Output: Alice with role Admin has access to all features.
//        customer.AccessControl(); // Output: Bob with role Customer has limited access.
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        ComplexNumber c1 = new ComplexNumber(1.5, 2.5);
//        ComplexNumber c2 = new ComplexNumber(3.0, 4.0);

//        ComplexNumber sum = c1 + c2;

//        Console.WriteLine($"First complex number: {c1}");
//        Console.WriteLine($"Second complex number: {c2}");
//        Console.WriteLine($"Sum: {sum}");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Manager manager = new Manager("Alice");
//        Department originalDept = new Department("IT", manager);
//        Department shallowCopiedDept = originalDept.ShallowCopy();
//        Department deepCopiedDept = originalDept.DeepCopy();
//        Console.WriteLine("Original Department: " + originalDept);
//        Console.WriteLine("Shallow Copied Department: " + shallowCopiedDept);
//        Console.WriteLine("Deep Copied Department: " + deepCopiedDept);
//        originalDept.Manager.Name = "Bob";
//        Console.WriteLine("\nAfter modifying the manager's name in the original department:");
//        Console.WriteLine("Original Department: " + originalDept);
//        Console.WriteLine("Shallow Copied Department: " + shallowCopiedDept);
//        Console.WriteLine("Deep Copied Department: " + deepCopiedDept);
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        // Set the interest rate for all bank accounts
//        Bank.SetInterestRate(3.5);

//        Bank account1 = new Bank("Account1", 1000);
//        Bank account2 = new Bank("Account2", 2000);

//        Console.WriteLine(account1);
//        Console.WriteLine(account2);
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        SecuritySystem security = new SecuritySystem("Home Security", false);
//        security.Activate();
//        security.Deactivate();
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Button button = new Button();

//        // Subscribe to the OnClick event
//        button.OnClick += Button_OnClick;

//        // Simulate button click
//        button.Click();
//    }

//    // Event handler method
//    private static void Button_OnClick(object sender, EventArgs e)
//    {
//        Console.WriteLine("OnClick event handler executed.");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Button button = new Button();

//        // Subscribe to the OnClick event
//        button.OnClick += Button_OnClick;

//        // Simulate button click
//        button.Click();
//    }

//    // Event handler method
//    private static void Button_OnClick(object sender, EventArgs e)
//    {
//        Console.WriteLine("OnClick event handler executed.");
//    }
//}


//public class Program
//{
//    public static void Main()
//    {
//        // Create a Car using the VehicleFactory
//        Vehicle1 car = VehicleFactory.CreateVehicle("car");
//        car.Drive(); // Output: Car is driving...

//        // Create a Bike using the VehicleFactory
//        Vehicle1 bike = VehicleFactory.CreateVehicle("bike");
//        bike.Drive(); // Output: Bike is driving...
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        ILogger logger = new FileLogger();
//        logger = new TimestampDecorator(logger);
//        logger = new ErrorCategoryDecorator(logger);
//        logger.Log("An error has occurred.");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        ConfigurationManager configManager = ConfigurationManager.Instance;
//        string value = configManager.GetConfigValue("SomeKey");

//        Console.WriteLine(value);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        NotificationService notificationService = new NotificationService();

//        INotificationObserver emailNotifier = new EmailNotifier();
//        INotificationObserver smsNotifier = new SMSNotifier();

//        notificationService.Attach(emailNotifier);
//        notificationService.Attach(smsNotifier);

//        notificationService.Notify("New message arrived!");
//    }
//}


class Program
{
    static void Main(string[] args)
    {
        decimal totalAmount = 100m;

        // No discount
        ShoppingCart cart = new ShoppingCart(new NoDiscount());
        Console.WriteLine($"Total with No Discount: {cart.CalculateTotal(totalAmount)}");

        // Percentage discount
        cart.SetDiscountStrategy(new PercentageDiscount(10m)); // 10% discount
        Console.WriteLine($"Total with 10% Discount: {cart.CalculateTotal(totalAmount)}");

        // Fixed amount discount
        cart.SetDiscountStrategy(new FixedAmountDiscount(15m)); // Fixed discount of $15
        Console.WriteLine($"Total with $15 Discount: {cart.CalculateTotal(totalAmount)}");
    }
}