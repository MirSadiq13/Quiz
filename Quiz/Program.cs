
static void ShuffleArray(int[] array)
{
    Random rand = new Random();
    int n = array.Length;
    for (int i = n - 1; i > 0; i--)
    {
        int j = rand.Next(0, i + 1);
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

string[,] Quiz = {

    { "Azerbaycanin paytaxti haradir?" , "Baki", "Naxcivan", "Gence", "Baki"},
    { "Amerikanin ilk prezidenti kimdir?", "G.Vasinqton", "T.Ruzvelt", "T.Cefferson", "G.Vasinqton"},
    { "Azerbaycanin en boyuk seheri hansidir?", "Kelbecer", "Quba", "Naxcivan", "Naxcivan"},
    { "Hansi olke bayraginda ag reng yoxdur?", "Cin", "Rusiya", "Yaponiya", "Cin"},
    { "Hansi .Net ailesine aid deyil?", "C#", "F#", "Java", "Java"},
    { "C# da structlar torene bilirmi?", "Beli", "Xeyr", "Baxir proqramiste", "Xeyr"},
    { "Yeni il ilk harda qeyd olunur?", "Amerika", "Yeni Zellandiya", "Filippin", "Yeni Zellandiya"},
    { "En boyuk Okean hansidir?", "Sakit Okean", "Atlantik Okean", "Simal Buzlu Okean", "Sakit Okean"},
    { "Sari ve qirmizi rengi qarisdirdiqda hansi reng alinir?", "Narinci", "Yasil", "Cehrayi", "Narinci"},
    { "Hansi kompyuterin beyni hesab olunur?", "Prosessor", "Ana plata", "RAM", "Prosessor"},

};

int[] question = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
ShuffleArray(question);

int point = 0;

foreach (int i in question)
{
    int[] variant = { 1, 2, 3 };
    ShuffleArray(variant);

    int select = 1;
    do
    {
        Console.Clear();
        switch (select)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\tPoint: " + point);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t\tSual: " + Quiz[i, 0] + "\n\n");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("\t\t --->");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" A: " + Quiz[i, variant[0]]);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t\tB: " + Quiz[i, variant[1]]);
                Console.WriteLine("\t\t\tC: " + Quiz[i, variant[2]]);
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\tPoint: " + point);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t\tSual: " + Quiz[i, 0] + "\n\n");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t\tA: " + Quiz[i, variant[0]]);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\t\t --->");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" B: " + Quiz[i, variant[1]]);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t\tC: " + Quiz[i, variant[2]]);
                break;
            case 3:
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\tPoint: " + point);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t\tSual: " + Quiz[i, 0] + "\n\n");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t\tA: " + Quiz[i, variant[0]]);
                Console.WriteLine("\t\t\tB: " + Quiz[i, variant[1]]);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\t\t --->");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" C: " + Quiz[i, variant[2]]);
                break;

        }

        ConsoleKeyInfo key = Console.ReadKey(true);
        if (key.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            if (Quiz[i, variant[select - 1]] == Quiz[i, 4])
            {
                point += 10;
                switch (select)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\tPoint: " + point);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\t\tSual: " + Quiz[i, 0] + "\n\n");

                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("\t\t --->");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" A: " + Quiz[i, variant[0]]);
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\t\t\tB: " + Quiz[i, variant[1]]);
                        Console.WriteLine("\t\t\tC: " + Quiz[i, variant[2]]);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\tPoint: " + point);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\t\tSual: " + Quiz[i, 0] + "\n\n");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\t\t\tA: " + Quiz[i, variant[0]]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\t\t --->");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" B: " + Quiz[i, variant[1]]);
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\t\t\tC: " + Quiz[i, variant[2]]);
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\tPoint: " + point);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\t\tSual: " + Quiz[i, 0] + "\n\n");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\t\t\tA: " + Quiz[i, variant[0]]);
                        Console.WriteLine("\t\t\tB: " + Quiz[i, variant[1]]);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("\t\t --->");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" C: " + Quiz[i, variant[2]]);
                        break;
                    default:
                        break;


                }
                Thread.Sleep(1000);
                break;
            }
            else
            {
                if (point != 0) point -= 10;

                switch (select)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\tPoint: " + point);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\t\tSual: " + Quiz[i, 0] + "\n\n");

                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("\t\t --->");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" A: " + Quiz[i, variant[0]]);
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\t\t\tB: " + Quiz[i, variant[1]]);
                        Console.WriteLine("\t\t\tC: " + Quiz[i, variant[2]]);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\tPoint: " + point);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\t\tSual: " + Quiz[i, 0] + "\n\n");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\t\t\tA: " + Quiz[i, variant[0]]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\t\t --->");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" B: " + Quiz[i, variant[1]]);
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\t\t\tC: " + Quiz[i, variant[2]]);
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\tPoint: " + point);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\t\tSual: " + Quiz[i, 0] + "\n\n");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\t\t\tA: " + Quiz[i, variant[0]]);
                        Console.WriteLine("\t\t\tB: " + Quiz[i, variant[1]]);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("\t\t --->");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" C: " + Quiz[i, variant[2]]);
                        break;
                    default:
                        break;


                }
                Thread.Sleep(1000);
                break;
            }
        }
        else if (key.Key == ConsoleKey.UpArrow)
        {
            if (select == 1) select = 3;
            else select--;
        }
        else if (key.Key == ConsoleKey.DownArrow)
        {
            if (select == 3) select = 1;
            else select++;
        }

    }
    while (true);

}

Console.Clear();
Console.WriteLine("Tebrikler! Quiz bitdi!");
Console.WriteLine("Sizin qazandiginiz Bal: " + point);
