// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

void Main() //65-91, 97-123
{
    string letters = RandomLatinLine(15);
    Console.WriteLine("Моя строка: " + letters);
    Console.WriteLine("Моя строка в нижнем регистре: " + letters.ToLower());
}

string RandomLatinLine(int lengthOfMyString)
{
    string letters = "";
    Random rand = new Random();
    char letter;
    while (lengthOfMyString > 0)
    {
        letter = (char)rand.Next(65, 123);
        if (letter > 90 && letter < 97) { continue; }
        letters += letter;
        lengthOfMyString--;
    }
    return letters;
}

Main();