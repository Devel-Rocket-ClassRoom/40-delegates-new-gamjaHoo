using System;

string original = "Hello World";
Action<string> printer = PrintOriginal;
Console.WriteLine("===문자열 처리 파이프라인\n");
Console.WriteLine("--- 단계 1: 원본 출력만 ---");
printer(original);
Console.WriteLine("\n--- 단계 2: 대문자 추가 ---");
printer += PrintUpper;
printer(original);
Console.WriteLine("\n--- 단계 3: 소문자, 길이 추가 ---");
printer += PrintLower;
printer += PrintLength;
printer(original);
Console.WriteLine("\n--- 단계 4: 대문자 제거 ---");
printer -= PrintUpper;
printer(original);


static void PrintOriginal(string text)
{
    Console.WriteLine($"원본: {text}");
}

static void PrintUpper(string text)
{
    Console.WriteLine($"대문자: {text.ToUpper()}");
}

static void PrintLower(string text)
{
    Console.WriteLine($"소문자: {text.ToLower()}");
}

static void PrintLength(string text)
{
    Console.WriteLine($"길이: {text.Length}");
}