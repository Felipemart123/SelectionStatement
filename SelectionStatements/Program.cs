

        //-----------------Exercise 1----------------------

        
            var r = new Random();

            var favNumber = r.Next(1, 1000);
            Console.WriteLine("enter a number".ToUpper());

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high");
            }
            else if (userInput == favNumber)
            {
                Console.WriteLine("You guessed it!!!");
            }



            //-----------------Exercise 2----------------------




            Console.WriteLine("what is your favorite subject?");

            string subject = Console.ReadLine();


            switch (subject)
            {
                case "math":
                    Console.WriteLine("Math is boring!");
                    break;
                case "science":
                    Console.WriteLine("Science is interesting!");
                    break;
                case "coding":
                    Console.WriteLine("Coding is the best!");
                    break;
                case "history":
                    Console.WriteLine("History is my favorite!");
                    break;
                case "literature":
                    Console.WriteLine("Literature is the worst!");
                    break;
                default:
                    Console.WriteLine("Thats not a subject");
                    break;

            }

        
    
