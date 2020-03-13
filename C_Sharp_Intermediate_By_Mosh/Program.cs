using System;
using C_Sharp_Intermediate_By_Mosh.AssociationBetweenClasses_03.Composition;
using C_Sharp_Intermediate_By_Mosh.AssociationBetweenClasses_03.Inheritance;
using C_Sharp_Intermediate_By_Mosh.Exercises;

namespace C_Sharp_Intermediate_By_Mosh
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
             * 02_classes
             */
            //Constructor();
            //ObjectInitializer();
            //Method();
            //UseOutModifier();
            //Fields();
            //AccessModifier();
            //Properties();
            //HttpCookieTest();
            //Exercise();

            /*
             * 03_Association between classes
             */

            //Inheritance();
            //Composition();

            /*
             * 04_Inheritance Second Pillar of OOP
             */
            Exercise_04_stack();


        }

        private static void Exercise_04_stack()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            //stack.Pop();
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }

        private static void Composition()
        {
            var dbMigrator = new DbMigrator(new Logger());
            dbMigrator.Migrate();

            var logger = new Logger();
            var installer = new Installer(logger);
            installer.Install();

        }

        private static void Inheritance()
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }

        private static void Exercise()
        {
            Exercise01();
            Exercise02();


        }

        private static void Exercise02()
        {
            var post = new Classes_02.Exercises.Post("A Post", "A Description.....");
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();
            post.UpVote();
            post.UpVote();

            post.CurrentVote();
        }

        private static void Exercise01()
        {
            var stopWatch = new Classes_02.Exercises.StopWatch();
            try
            {
                stopWatch.Start();
                //stopWatch.Start();
                stopWatch.Stop();
                Console.WriteLine(stopWatch.Duaration());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void HttpCookieTest()
        {
            var cookie = new Classes_02.Indexres.HttpCookie();
            cookie["name"] = "Hasib";
            Console.WriteLine(cookie["name"]);
        }

        private static void Properties()
        {
            var person = new Classes_02.Properties.Person();
            person.Birthdate = new DateTime(2000, 1, 1);
            Console.WriteLine(person.Age);
        }

        private static void AccessModifier()
        {
            var person = new Classes_02.AccessModifiers.Person();
            person.SetBirthdate(new DateTime(2000, 1, 1));
            Console.WriteLine(person.GetBirthdate());
        }

        private static void Fields()
        {
            var customer = new Classes_02.Fields.Customer(1);
            customer.Orders.Add(new Classes_02.Fields.Order());
            customer.Orders.Add(new Classes_02.Fields.Order());
            customer.Orders.Add(new Classes_02.Fields.Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);
        }

        private static void UseOutModifier()
        {
            //int.Parse("asa");

            int number;
            var result = int.TryParse("asa", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
        }

        private static void Method()
        {
            //Signature of Method : 
            //1. Name
            //2. Number and Type of parameters
            UsePoints();

            UseCalculator();
        }

        private static void UseCalculator()
        {
            var calculator = new Classes_02.Methods.Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
        }

        private static void UsePoints()
        {
            try
            {
                var point = new Classes_02.Methods.Point(10, 20);

                //point.Move(new Point(40, 60));
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexception error occured.");
            }
        }

        private static void ObjectInitializer()
        {
            var person = new Classes_02.ObjectInitilizers.Person
            {
                Name = "test"
            };
        }

        private static void Constructor()
        {
            var customer = new Classes_02.Constructors.Customer(1, "John");
            var order = new Classes_02.Constructors.Order();

            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
