using System;
using System.Text;

string original = "Hello World";

Console.WriteLine("=== 문자열 가공기 ===");
Console.WriteLine($"\n원본: {original}");

Console.WriteLine("\n[대문자 변환]");
ProcessAndPrint(original, ToUpperCase);

Console.WriteLine("\n[소문자 변환]");
ProcessAndPrint(original, ToLowerCase);

Console.WriteLine("\n[괄호 추가]");
ProcessAndPrint(original, AddBrackkets);

Console.WriteLine("\n[문자열 뒤집기]");
ProcessAndPrint(original, Reverse);
static string ToUpperCase(string s)
{
    return s.ToUpper(); 
}

static string ToLowerCase(string s)
{
    return s.ToLower(); 
}

static string AddBrackkets(string s)
{
    StringBuilder sb = new StringBuilder();
    sb.Append("[");
    sb.Append(s);
    sb.Append("]");
    return sb.ToString();
}

static string Reverse(string s)
{
    char[] chars = new char[s.Length];
    for(int i = s.Length - 1; i >= 0; i--)
    {
        chars[i] = s[(s.Length - 1) - i];
    }
    return new string(chars);
}

static void ProcessAndPrint(string input, StringProcessor processor)
{
    Console.WriteLine(processor(input));
}


delegate string StringProcessor(string s);