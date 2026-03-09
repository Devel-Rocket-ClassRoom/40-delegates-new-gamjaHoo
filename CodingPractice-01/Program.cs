using System;

////1
//SayDelegate sayPointer = new SayDelegate(Hello);

//sayPointer();

//sayPointer.Invoke();

//void Hello() => Console.WriteLine("Hello Delegate");

//delegate void SayDelegate();



////2
//static void Hi() => Console.WriteLine("안녕하세요.");

//SayDelegate say = Hi;
//say();

//var hi = new SayDelegate(Hi);
//hi();

//delegate void SayDelegate();



////3

//static double GetArea(int r)
//{
//    return 3.14 * r * r; 
//}

//GetAreaDelegate g = GetArea;

//Console.WriteLine(g(10));
//Console.WriteLine(g.Invoke(10));

//delegate double GetAreaDelegate(int r);



////4
//MathOperation pow = Math.Pow;

//Console.WriteLine(pow(2, 10));

//delegate double MathOperation(double a, double b);



////5

//Transformer t = Calculator.Square;
//Console.WriteLine(t(5));
//class Calculator
//{
//    public static int Square(int x)
//    {
//        return x * x;
//    }
//}
//delegate int Transformer(int i);



////6
//ProgressReporter r = WriteToConsole;
//r += WriteToFile;

//for (int i = 0; i <= 100; i += 25)
//{
//    r(i);
//    Console.WriteLine();
//}

//static void WriteToConsole(int percent)
//{
//    Console.WriteLine($"진행률: {percent}%");
//}

//static void WriteToFile(int percent)
//{
//    Console.WriteLine($"[파일 기록] {percent}%");
//}

//delegate void ProgressReporter(int percent);



////7
//RunnerCall(Go);
//RunnerCall(Back);
//static void RunnerCall(Runner runner)
//{
//    Console.WriteLine("=== 실행 시작 ===");
//    runner();
//    Console.WriteLine("=== 실행 종료 ===");
//}
//static void Go()
//{
//    Console.WriteLine("직진");
//}

//static void Back()
//{
//    Console.WriteLine("후진");
//}

//delegate void Runner();



////8
//Action greet = () => Console.WriteLine("안녕하세요!");
//greet();

//Action<string> print = (msg) => Console.WriteLine(msg);
//print("Hello, Action!");

//Action<string, int> printRepeat = (msg, count) =>
//{
//    for (int i = 0; i < count; i++)
//    {
//        Console.WriteLine(msg);
//    }
//};
//printRepeat("반복", 3);



////9
//Func<int> f1= () => 42;
//Func<int, int> f2 = (x) => x * x;
//Func<int, int, int> f3 = (x, y) => x + y;
//Func<int, int, string> f4 = (x, y) => $"{x + y}";

//Console.WriteLine(f1());
//Console.WriteLine(f2(5));
//Console.WriteLine(f3(5, 5));
//Console.WriteLine(f4(4, 4));



////10
//Predicate<int> isEven = (x) => x % 2 == 0;
//Predicate<int> isPositive = (x) => x > 0;
//Console.WriteLine(isEven(4));
//Console.WriteLine(isEven(7));
//Console.WriteLine(isPositive(5));
//Console.WriteLine(isPositive(-3));



////11
//SayDelegate say = delegate ()
//{
//    Console.WriteLine("반갑습니다.");
//};

//say();

//delegate void SayDelegate();