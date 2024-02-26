//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

using System.Text;

void Main()
{
    EncludeRussian();
    string? text = EnterText("Введите слово или строку: ");
    Console.WriteLine(IsPalindrome(text) ? "Данная строка является полиндромом." : "Данная строка не является полиндромом.");
}

void EncludeRussian()
{
    //you need to use "using System.Text;"
    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    Console.InputEncoding = Encoding.GetEncoding(1251);
}

string? EnterText(string output)
{
    Console.WriteLine(output);
    return Console.ReadLine();
}

bool IsPalindrome(string? text)
{
    if (string.IsNullOrEmpty(text)) { Console.Write("Вы ввели пустую строку. "); return false; }
    else if (text.Length == 1) { return true; }
    text = text.ToLower();
    for (int i = 0; i < text.Length / 2; i++)
        if (text[i] != text[text.Length - 1 - i]) return false;
    return true;
}

Main();