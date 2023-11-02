Main();
static void Main()
{
    Console.WriteLine("Красные клавиши: A, S, D, F, G, H");
    Console.WriteLine("Фиолетовые клавиши: W, E, R, T, Y");
    Console.WriteLine("Октавы: F1, F2, F3");
    Console.WriteLine("Для выхода программы нажмите клавишу Escape");
    Console.WriteLine("Выберите октаву");
    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    switch (key.Key)
    {
        case ConsoleKey.F1:
            PlayOctave(new int[] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 });
            break;
        case ConsoleKey.F2:
            PlayOctave(new int[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 });
            break;
        case ConsoleKey.F3:
            PlayOctave(new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 });
            break;
        case ConsoleKey.Escape:
            Environment.Exit(0);
            break;
    }
}


static void PlayOctave(int[] Octave)
{
    Console.WriteLine("Если вы хотите вернутся в меню к выбору октавы, нажмите клавишу Backspace");
    Console.WriteLine("Для выхода программы нажмите клавишу Escape");
    while (true)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        Console.Clear();
        switch (key.Key)
        {
            case ConsoleKey.A:
                MakeSound(Octave[0]);
                break;
            case ConsoleKey.S:
                MakeSound(Octave[1]);
                break;
            case ConsoleKey.D:
                MakeSound(Octave[2]);
                break;
            case ConsoleKey.F:
                MakeSound(Octave[3]);
                break;
            case ConsoleKey.G:
                MakeSound(Octave[4]);
                break;
            case ConsoleKey.H:
                MakeSound(Octave[5]);
                break;
            case ConsoleKey.W:
                MakeSound(Octave[6]);
                break;
            case ConsoleKey.E:
                MakeSound(Octave[7]);
                break;
            case ConsoleKey.R:
                MakeSound(Octave[8]);
                break;
            case ConsoleKey.T:
                MakeSound(Octave[9]);
                break;
            case ConsoleKey.Y:
                MakeSound(Octave[10]);
                break;
            case ConsoleKey.Backspace:
                Main();
                break;
            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;
        }
    }
}
static void MakeSound(int frequency)
{
    Console.Beep(frequency, 100);
    Console.Clear();
}