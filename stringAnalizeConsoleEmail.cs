namespace RegularWord;

public class stringAnalizeConsoleEmail
{
    public static void MatchStringToPattern(StringAnalize stringAnalize)
    {
        Console.Write("Введите почту для проверки");
        string mail = Console.ReadLine();
        if (stringAnalize.matchNumberToPattern(mail))
        {
            Console.WriteLine("Ваша почта принята");
            consoleDialog(stringAnalize);
            
        }
        else
        {
            Console.WriteLine("Неправильный формат почты");
            consoleDialog(stringAnalize);
        }

        void consoleDialog(StringAnalize stringAnalize)
        {
            Console.WriteLine("Если хотите завершить программу, введите 1");
            Console.WriteLine("Если хотите продолжить проверку, введите 2");
            Console.WriteLine("Ввод: ");
            int a;
            if (!Int32.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Нужно ввести либо 1, либо 2");
                MatchStringToPattern(stringAnalize);
            }
            else
            {
                switch (a)
                {
                    case 1:
                        return;
                    case 2:
                        MatchStringToPattern(stringAnalize);
                        break;
                    default:
                        Console.WriteLine("Нужно ввести либо 1, либо 2");
                        MatchStringToPattern(stringAnalize);
                        break;
                }
            }
        }
    } 
}