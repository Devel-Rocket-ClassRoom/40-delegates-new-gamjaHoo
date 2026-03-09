using System;

////1
//Calculator calc = new Calculator();
//Transformer t = calc.Multiply;

//Console.WriteLine(t(5));
//class Calculator
//{
//    public int multiplier = 3;
//    public int Multiply(int x)
//    {
//        return x * multiplier;
//    }
//}

//delegate int Transformer(int i);



////2
//CarDriver c = Go;
//c += Left;
//c += Right;
//c();
//Console.WriteLine();
//c-=Left;
//c();
//static void Go()
//{
//    Console.WriteLine("직진");
//}

//static void Left()
//{
//    Console.WriteLine("좌회전");
//}

//static void Right()
//{
//    Console.WriteLine("우회전");
//}

//delegate void CarDriver();



//3
int[] numbers = { 1, 2, 3, 4, 5 };

Transform(numbers, Square);
PrintArray(numbers);

numbers = new int[] { 1, 2, 3, 4, 5 };

Transform(numbers, Cube);
PrintArray(numbers);

static int Square(int x) => x * x;
static int Cube(int x) => x * x * x;

static void Transform(int[] values, Transformer t)
{
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = t(values[i]);
    }
}

static void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(", ", arr));
}

delegate int Transformer(int x);
