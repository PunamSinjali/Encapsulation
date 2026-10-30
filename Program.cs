// // Student a=new Student();
// // int c=a.study();
// // Student d =new Student("Punam");
// // d.draw();

// // Student b=new Student();
// // b.draw();
// // Console.WriteLine("Enter any two numbers:");
// // int a=Convert.ToInt32(Console.ReadLine());
// // int c=Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine(b.study(a,c));

// // class Student{
// //     public string Name="";

// //     public Student(string name){
// //         Name=name;
// //     }

// //     public void draw(){
// //         Console.WriteLine($"name={Name}");
// //     }
// //     public int study(int x,int y){
// //         return x+y;
// //     }
// // }

// // Console.WriteLine("WELCOME TO THE MOVIE BOOKING APP");

// // Console.Write("Enter your name: ");
// // string ? name = Console.ReadLine();

// // Console.Write("Enter your age: ");
// // int age = Convert.ToInt32(Console.ReadLine());

// // Console.Write("Enter your contact number: ");
// // string ? contact= Console.ReadLine();

// // Movie a = new Movie();
// // a.list();

// // Console.Write("Choose a movie (1-5): ");
// // int choice = Convert.ToInt32(Console.ReadLine());

// // if (choice>=1 && choice<=a.title.Length)
// // {
// //     a.movieName = a.title[choice-1];

// //     Console.Write("Enter number of tickets: ");
// //     int tickets = Convert.ToInt32(Console.ReadLine());

// //     a.customerList.Add(name);
// //     a.Ticket(tickets, 150);

// //     a.Show(age);
// // }
// // else
// // {
// //     Console.WriteLine("Invalid movie choice!");
// // }

// // class Movie
// // {
// //     public string[] title =
// //     {
// //         "Inception",
// //         "Final Destination",
// //         "Obsession",
// //         "Frozen",
// //         "Train to Busan"
// //     };

// //     public string movieName = "";
// //     public int ticketPrice = 0;
// //     public int numberOfTickets = 0;
// //     public string[] date={
// //         "7:30 am",
// //         "10:45 am",
// //         "1:30 pm",
// //         "4:15 pm",
// //         "7:30 pm"
// //     };
// //     public string[] durartion={
// //         "180 mins",
// //         "165 mins",
// //         "180 mins",
// //         "120 mins",
// //         "160 mins"
// //     };

// //     public List<string> customerList = new List<string>();

// //     public void list()
// //     {
// //         Console.WriteLine("\nAVAILABLE MOVIES");

// //         for (int i = 0; i < title.Length; i++)
// //         {
// //             Console.WriteLine((i + 1) + ". " + title[i]);
// //         }
// //     }

// //     public void Ticket(int tickets, int price)
// //     {
// //         numberOfTickets = tickets;
// //         ticketPrice = price;
// //     }

// //     public int TotalPrice()
// //     {
// //         return ticketPrice * numberOfTickets;
// //     }

// //     public void Show(int age)
// //     {
// //         Console.WriteLine("\nCUSTOMER DETAILS");
// //         Console.WriteLine($"Name: {customerList[0]} ");
// //         Console.WriteLine($"Age: {age} ");
// //         Console.WriteLine($"Contact number: {contact}");
// //         Console.WriteLine($"Movie: {movieName} ");
// //         Console.WriteLine($"Number of tickets: {numberOfTickets}");
// //         Console.WriteLine($"Price per ticket: Rs. {ticketPrice}");
// //         Console.WriteLine($"Total price: Rs. {TotalPrice}");
// //     }
// // }

// Movie[] movies = new Movie[5]
// {
//     new Movie("Inception", "2h 28m", 12.50),
//     new Movie("Avatar: The Way of Water", "3h 12m", 15.00),
//     new Movie("The Dark Knight", "2h 32m", 10.00),
//     new Movie("Interstellar", "2h 49m", 11.50),
//     new Movie("Spider-Man: Across the Spider-Verse", "2h 20m", 13.00)
// };


// Console.WriteLine("========================================");
// Console.WriteLine("    WELCOME TO THE MOVIE BOOKING APP    ");
// Console.WriteLine("========================================\n");

// Console.Write("Enter Customer Name: ");
// string customerName = Console.ReadLine()??"";

// Console.Write("Enter Contact Number: ");
// string contact = Console.ReadLine()??"";

// Console.WriteLine("\n--- Available Movies ---");
// for (int i = 0; i < movies.Length; i++)
// {
//     Console.WriteLine($"{i + 1}. {movies[i].Name} | Duration: {movies[i].Duration} | Price: ${movies[i].Price}");
// }

// int choice = 0;
// while (choice < 1 || choice > movies.Length)
// {
//     Console.Write($"\nSelect a movie (1-{movies.Length}): ");
//     if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > movies.Length)
//     {
//         Console.WriteLine("Invalid choice. Please select a valid movie number.");
//     }
// }

// Movie chosenMovie = movies[choice - 1];

// Console.Write("Enter Show Date (e.g., YYYY-MM-DD): ");
// string date = Console.ReadLine()??"";

// Console.Write("Enter Show Time (e.g., 06:30 PM): ");
// string time = Console.ReadLine()??"";

// Customer customer = new Customer(customerName, contact, chosenMovie, date, time);
// customer.PrintTicket();






// class Movie{
//     public string Name;
//     public string Duration;
//     public double Price;

//     public Movie(string name, string duration, double price)
//     {
//         Name = name;
//         Duration = duration;
//         Price = price;
//     }
// }

// class Customer
// {
//     public string Name;
//     public string Contact;
//     public Movie SelectedMovie;
//     public string ShowDate;
//     public string ShowTime;

//     public Customer(string name, string contact, Movie selectedMovie, string showDate, string showTime)
//     {
//         Name = name;
//         Contact = contact;
//         SelectedMovie = selectedMovie;
//         ShowDate = showDate;
//         ShowTime = showTime;
//     }

//     public void PrintTicket()
//     {
//         Console.WriteLine("\n========================================");
//         Console.WriteLine("          BOOKING CONFIRMATION          ");
//         Console.WriteLine("========================================");
//         Console.WriteLine($"Customer Name  : {Name}");
//         Console.WriteLine($"Contact Number : {Contact}");
//         Console.WriteLine($"Movie Selected : {SelectedMovie.Name}");
//         Console.WriteLine($"Movie Duration : {SelectedMovie.Duration}");
//         Console.WriteLine($"Ticket Price   : ${SelectedMovie.Price}");
//         Console.WriteLine($"Show Date      : {ShowDate}");
//         Console.WriteLine($"Show Time      : {ShowTime}");
//         Console.WriteLine("========================================");
//         Console.WriteLine("   Thank you for booking with us!      ");
//         Console.WriteLine("========================================");
//     }
// }

// Student s=new Student();
// s.SetAge(22);
// Console.WriteLine(s.GetAge());

// class Student
// {
//     private int age;

//     public void SetAge(int newAge)
//     {
//         if (newAge>=0 && newAge<=120) age=newAge;
//         else Console.WriteLine("Invalid Age");
//     }
//     public int GetAge()
//     {
        // return age;
    // }
// }

Person p= new Person();
p.Name="Shyam";
Console.WriteLine(p.Name);

class Person
{
    private string name ="";
    public string Name
    {
        get {return name;}
        set{name=value;}
    }
}