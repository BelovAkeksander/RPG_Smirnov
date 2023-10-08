namespace log
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("приветствую, салага!!!");
            Console.WriteLine("Выбери 1) ЧТОБЫ НАЧАТЬ ИГРАТЬ.");
            string action = Console.ReadLine();
            bool isOpened = false;
            while (isOpened != true)
            {
                Console.WriteLine("Ты захотел выучить базу данных нажми 1) чтобы пойти к Смирнову ");
                action = Console.ReadLine();
                {
                    if (action == "1")
                    {
                        Console.WriteLine("нажми 1) чтобы подняться к нему");
                        Console.WriteLine(" нажми 2) чтобы уйти домой");
                        action = Console.ReadLine();
                    }
                    if (action == "1")
                    {

                        Console.WriteLine("Поздравляю ты выучил, ты легенда!!!");
                        action = Console.ReadLine();
                    }
                    if (action == "2")
                    {
                        Console.WriteLine("Ты отчислен, у тебя осталась (3) попытки чтобы попросить прощение. жми (1) чтобы попросить прощение");
                        action = Console.ReadLine();
                    }
                    if (action == "1")
                    {
                        Console.WriteLine("Смирнов:пошел вон отсюда, у тебя осталась (2) попытки чтобы попросить прощение. жми (1) чтобы попросить прощение ");
                        action = Console.ReadLine();

                        Console.WriteLine("Смирнов: Я тебе уже все сказал, у тебя осталась (1) попытка чтобы попросить прощение. жми (1) чтобы попросить прощение");
                        action = Console.ReadLine();

                    }
                    if (action == "1")
                    {
                        Console.WriteLine("Смирнов: не хочу с тобой разговаривать, найди ему чай чтобы спасти свою жизнь. нажми (2)");
                        action = Console.ReadLine();
                    }
                    if (action == "2")
                    {
                        Console.WriteLine("нажми 2 чтобы спуститься в столовую");
                        action = Console.ReadLine();
                    }
                    if (action == "2")
                    {
                        Console.WriteLine("ты в столовой!!! нажми (2) чтобы найти Антонину Ивановну");
                        action = Console.ReadLine();
                    }
                    if (action == "2")
                    {
                        Console.WriteLine("чай у тебя! нажми (1) чтобы отнести его Смирнову");
                        action = Console.ReadLine();
                    }
                    if (action == "1")
                    {
                        Console.WriteLine(" нажми (1) чтобы подняться с Смирнову");
                        action = Console.ReadLine();
                    }
                    if (action == "1")
                    {
                        Console.WriteLine(" ты у Смирнова, нажми (1) чтобы попросить прощения");
                        action = Console.ReadLine();
                    }
                    if (action == "1")
                    {
                        Console.WriteLine(" Смирнов: Так уж и быть, ты прощен");
                        action = Console.ReadLine();
                    }



                }

            }
        }
    }
}


