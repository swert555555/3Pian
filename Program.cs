namespace Пианино
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("В программе есть 2 октавы.\nВыбери октаву через F1, F2 соответственно.\nДля выхода из программы нажми клавишу F5");
            ConsoleKeyInfo octav = Console.ReadKey();
            Console.WriteLine(octav);
            for (; octav.Key != ConsoleKey.F5; octav = Console.ReadKey())
            switch (octav.Key)
                {
                    case ConsoleKey.F1:
                        Octav1();
                        break;
                    case ConsoleKey.F2:
                        Octav2();
                        break;
                    case ConsoleKey.F5:
                        break;
                    default:
                        Console.WriteLine("Вы ввели несуществующую команду");
                        break;
                }
            
            Console.WriteLine("Конец программы");
        }
        static void Octav1()
        {
            Console.WriteLine("Для выбора другой октавы нажми F5\nКлавиши: Q,W,E,R,A,S,D,F,Z,X,C,V");
            ConsoleKeyInfo noti = Console.ReadKey();
            int[] gerc1 = new int[] {261, 277, 293, 311, 330, 350, 370, 392, 415, 440, 466, 494};
            for (; noti.Key != ConsoleKey.F5; noti = Console.ReadKey())
                switch (noti.Key)
                {
                    case ConsoleKey.Q:
                        Vivod_beepa(gerc1[0]);
                        break;
                    case ConsoleKey.W:
                        Vivod_beepa(gerc1[1]);
                        break;
                    case ConsoleKey.E:
                        Vivod_beepa(gerc1[2]);
                        break;
                    case ConsoleKey.R:
                        Vivod_beepa(gerc1[3]); ;
                        break;
                    case ConsoleKey.A:
                        Vivod_beepa(gerc1[4]);
                        break;
                    case ConsoleKey.S:
                        Vivod_beepa(gerc1[5]);
                        break;
                    case ConsoleKey.D:
                        Vivod_beepa(gerc1[6]);
                        break;
                    case ConsoleKey.F:
                        Vivod_beepa(gerc1[7]);
                        break;
                    case ConsoleKey.Z:
                        Vivod_beepa(gerc1[8]);
                        break;
                    case ConsoleKey.X:
                        Vivod_beepa(gerc1[9]);
                        break;
                    case ConsoleKey.C:
                        Vivod_beepa(gerc1[10]);
                        break;
                    case ConsoleKey.V:
                        Vivod_beepa(gerc1[11]);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Такой ноты нет");
                        break;
                }
            Console.WriteLine("Введите F1 или F2 для выбора октавы. Для завершения программы введите F5 ");
        }
        static void Octav2()
        {
            Console.WriteLine("Для выбора другой октавы нажми F5\nКлавиши: Q,W,E,R,A,S,D,F,Z,X,C,V");
            ConsoleKeyInfo noti = Console.ReadKey();
            int[] gerc1 = new int[] {4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902};
            for (; noti.Key != ConsoleKey.F5; noti = Console.ReadKey())
                switch (noti.Key)
                {
                    case ConsoleKey.Q:
                        Vivod_beepa(gerc1[0]);
                        break;
                    case ConsoleKey.W:
                        Vivod_beepa(gerc1[1]);
                        break;
                    case ConsoleKey.E:
                        Vivod_beepa(gerc1[2]);
                        break;
                    case ConsoleKey.R:
                        Vivod_beepa(gerc1[3]);
                        break;
                    case ConsoleKey.A:
                        Vivod_beepa(gerc1[4]);
                        break;
                    case ConsoleKey.S:
                        Vivod_beepa(gerc1[5]);
                        break;
                    case ConsoleKey.D:
                        Vivod_beepa(gerc1[6]);
                        break;
                    case ConsoleKey.F:
                        Vivod_beepa(gerc1[7]);
                        break;
                    case ConsoleKey.Z:
                        Vivod_beepa(gerc1[8]);
                        break;
                    case ConsoleKey.X:
                        Vivod_beepa(gerc1[9]);
                        break;
                    case ConsoleKey.C:
                        Vivod_beepa(gerc1[10]);
                        break;
                    case ConsoleKey.V:
                        Vivod_beepa(gerc1[11]);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Такой ноты нет");
                        break;
                }
            Console.WriteLine("Введите F1 или F2 для выбора октавы. Для завершения программы введите F5 ");
        }
        static void Vivod_beepa(int rand)
        {
             Console.Beep(rand, 600);
             Console.Clear();
        }
    }
}