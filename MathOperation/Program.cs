using System;


MathOp add = Add;
MathOp sub = Subtract;
MathOp multiply = Multiply;
MathOp divide = Divide;

Console.WriteLine("=== 사칙연산 대리자 ===");
Console.WriteLine();
Console.WriteLine($"[덧셈]\n20 + 4 = {add(20, 4)}\n");
Console.WriteLine($"[뺄셈]\n20 - 4 = {sub(20, 4)}\n");
Console.WriteLine($"[곱셈]\n20 * 4 = {multiply(20, 4)}\n");
Console.WriteLine($"[나눗셈]\n20 / 4 = {divide(20, 4)}\n");

static int Add(int a, int b) => a + b;
static int Subtract(int a, int b) => a - b;
static int Multiply(int  a, int b) => a * b;
static int Divide(int  a, int b) => a / b;

delegate int MathOp(int a, int b);