// Написать метод, который заменяет в тексте пробелы на тире,
// малекькие "к" на большие, а большие "С" на маленькие

using static System.Console;
Clear();

string poem = "Мы мирные люди, но наш бронепоезд кровавую пищу клюет под окном";
string newText = ChangeString(poem, ' ', '|');
WriteLine(newText);
string newText1 = ChangeString(newText, 'к', 'К');
WriteLine(newText1);
string newText2 = ChangeString(newText1, 'з', 'Z');
WriteLine(newText2);






string ChangeString(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";

    }

    return result;  
}