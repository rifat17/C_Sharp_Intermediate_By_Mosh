using System;
using C_Sharp_Intermediate_By_Mosh.AssociationBetweenClasses_03.Composition;
using C_Sharp_Intermediate_By_Mosh.AssociationBetweenClasses_03.Inheritance;
using C_Sharp_Intermediate_By_Mosh.Exercises.Solve;
using C_Sharp_Intermediate_By_Mosh.Exercises.Exercise01;
using C_Sharp_Intermediate_By_Mosh.Exercises.Exercise02;
using C_Sharp_Intermediate_By_Mosh.TestAbility;
using System.Threading;


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
            //Exercise_04_stack();

            /*
             * 05_Third Pillar of OOP
             */
            //Exercise_01_DesignDbCOnnection();
            //Exercise_02_DesignDbCommand();

            /*
             * 06_Interface_and_OOP
             */

            //Lecture_033();

            //Lecture_034();

            //Lecture_036();

            //Exercise038_DesigningWorkflowEngine();

            StopWatchSolveByMosh();







        }

        private static void StopWatchSolveByMosh()
        {
            var stopWatch = new Classes_02.Exercises.SolveByMosh.StopWatch();

            for(var i = 0; i < 2; i++)
            {
                stopWatch.Start();

                Thread.Sleep(1000);

                stopWatch.Stop();

                Console.WriteLine("Duration : {0}." , stopWatch.GetInterval());
                Console.WriteLine("Press Enter to run the stopwatch again.");
                Console.ReadLine();
            }
        }

        private static void Exercise038_DesigningWorkflowEngine()
        {
            var workflow = new E06.Solve.WorkFlow();
            var activity1 = new E06.Solve.VideoUploadActivity();
            var activity2 = new E06.Solve.VideoReadyNotifyActivity();
            var activity3 = new E06.Solve.SendEmailActivity();
            var activity4 = new E06.Solve.DatabaseActivity();
            workflow.AddActivity(activity1);
            workflow.AddActivity(activity2);
            workflow.AddActivity(activity3);
            workflow.AddActivity(activity4);

            var workflowEngine = new E06.Solve.WorkFlowEngine(workflow);
            workflowEngine.Run();

        }

        private static void Lecture_036()
        {
            var encoder = new Interfaces_Polymorphism036.VideoEncoder();
            encoder.RegisterNotificationChannel(new Interfaces_Polymorphism036.MainNotificationChannel());
            encoder.RegisterNotificationChannel(new Interfaces_Polymorphism036.SmsNotificationChannel());
            encoder.Encode(new Interfaces_Polymorphism036.Video());
        }

        private static void Lecture_034()
        {
            var path = "/home/hasib/Projects/C_Sharp_Intermediate_By_Mosh/C_Sharp_Intermediate_By_Mosh";
            var dbMigrator = new Extensibility034.DbMigrator( new Extensibility034.FileLogger( path ) );
            dbMigrator.Migrate();

            dbMigrator = new Extensibility034.DbMigrator(new Extensibility034.ConsoleLogger());
            dbMigrator.Migrate();
        }

        private static void Lecture_033()
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }

        private static void Exercise_02_DesignDbCommand()
        {
            var sql = new SqlConnection("SQL Connection");
            var instruction = "Instruction";
            var command = new DbCommand(sql, instruction);
            command.Execute();
        }

        private static void Exercise_01_DesignDbCOnnection()
        {
            var sql = new SqlConnection("SQL");
            sql.Open();
            sql.Close();

            var oracle = new OracleConnection("Oracle");
            oracle.Open();
            oracle.Close();
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
