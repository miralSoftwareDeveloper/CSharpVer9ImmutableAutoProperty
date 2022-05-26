using System;

namespace CSharpVer9ImmutableAutoProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Friend friend = new Friend();
            friend.FirstName = "Miral";
            friend.LastName = "Shah";
            Console.WriteLine($"First Name :{friend.FirstName}");
            Console.WriteLine($"Last Name :{friend.LastName}");
            Console.WriteLine("Now assigning new value to same object FirstName:Vimal,LastName:Patel");
            friend.FirstName = "Vimal";
            friend.LastName = "Patel";
            Console.WriteLine($"First Name :{friend.FirstName}");
            Console.WriteLine($"Last Name :{friend.LastName}");
            Console.WriteLine("Both Auto-Properties changes because it is Mutuable auto-properties");
            Console.WriteLine("How to make these properties Immutable i.e we cant change after it assign once.");
            Console.WriteLine("Are you ready to know? Press 'y'");

            ConsoleKeyInfo cki = Console.ReadKey();

            if (cki.Key.ToString() == "Y")
            {
                Console.WriteLine("1.Step : Writing constructor and initalize properties within in constructor makes Immutable properties");
                Console.WriteLine("2nd Step : Remove <set> from Auto-Properties");
                Console.WriteLine("Let's write another class FriendVersion2 with constructor");
                FriendVersion2 friendVersion2 = new FriendVersion2("Miral","Shah");
                Console.WriteLine("Initializing properites in Constructor and making it immutable");
                Console.WriteLine($"First Name : {friendVersion2.FirstName}");
                Console.WriteLine($"Last Name : {friendVersion2.LastName}");
                //friendVersion2.FirstName = "Vimal";
                //friendVersion2.LastName = "Sheth";
                Console.WriteLine("Compile-time error:friendVersion2.FirstName = Vimal");
                Console.WriteLine("Compile-time error:friendVersion2.LastName = Sheth");
                Console.WriteLine("Above error is because properites are immutable.");
                Console.WriteLine("Once assign in constructor it cant be changed.");

                Console.WriteLine("Do you want to learn INIT of C#9 version ? Press 'Y'");

                ConsoleKeyInfo cki2 = Console.ReadKey();

                if(cki2.Key.ToString() == "Y")
                {
                    Console.WriteLine("Creating FriendVersion3 class replacing set with INIT");
                    FriendVersion3 friendVersion3 = new FriendVersion3 { FirstName = "Miral", LastName = "Shah" };
                    Console.WriteLine($"First Name : {friendVersion3.FirstName}");
                    Console.WriteLine($"Last Name : {friendVersion3.LastName}");
                    //friendVersion3.FirstName = "Vimal";
                    //friendVersion3.LastName = "Sheth";
                    Console.WriteLine("Compile-time error:friendVersion2.FirstName = Vimal");
                    Console.WriteLine("Compile-time error:friendVersion2.LastName = Sheth");
                    Console.WriteLine("Above error is because properites are immutable by using INIT.");
                    

                }


            }
            else
            {
                // presses something other then Y
            }




        }
    }
}
