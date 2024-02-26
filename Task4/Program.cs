// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами.
// Сформировать строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.

using System.Text;

void Main()
{
    EncludeRussian();
    string? input = EnterText("Введите строку, разделенную пробелами: ");
    Console.WriteLine(ReverseWords(input));
}

string? EnterText(string output)
{
    Console.WriteLine(output);
    return Console.ReadLine();
}

void EncludeRussian()
{
    //you need to use "using System.Text;"
    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    Console.InputEncoding = Encoding.GetEncoding(1251);
}

string ReverseWords(string? input)
{
    if (string.IsNullOrEmpty(input)) { return "Строка пуста. Попробуйте снова."; }
    string[] words = input!.Trim().Split(' ');
    Array.Reverse(words);
    return string.Join(" ", words);
}

Main();