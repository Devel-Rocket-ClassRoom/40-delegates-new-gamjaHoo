using System;

////1
//Action a = Go;
//a += Left;
//a += Right;
//a();
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



//2

Action driver = Go;
driver += Left;

driver += delegate ()
{
    Console.WriteLine("우회전");
};

driver();


static void Go()
{
    Console.WriteLine("직진");
}

static void Left()
{
    Console.WriteLine("좌회전");
}

static void Right()
{
    Console.WriteLine("우회전");
}