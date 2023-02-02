// See https://aka.ms/new-console-template for more information



//    Info info = new Info();
//    info.infoBack += Info1;
//    info.infoBack += Info2;
//    info.Call("Hello World !");


// static void Info1(string txt)
//{
//    Console.WriteLine($"This a first info: {txt}");
//}
//static void Info2(string txt)
//{
//    Console.WriteLine($"This a second info: {txt}");
//}


//public class Info
//{
//    private InfoCallback callback;
//    public event InfoCallback infoBack
//    {
//        add
//        {
//            Console.WriteLine($"Subscribe: {value}");
//            callback += value;
//        }
//        remove
//        {
//            callback -= value;
//        }
//    }

//    public void Call(string message)
//    {
//        callback(message);
//    }
//}
//public delegate void InfoCallback(string txt);



//try
//{

//    try
//    {
//        Console.Write("Input Number First: ");
//        int first = int.Parse(Console.ReadLine());
//        Console.Write("Input Number Second: ");
//        int second = int.Parse(Console.ReadLine());

//        int result = first / second;

//        Console.WriteLine($"Result: {result}");
//    }
//    catch (DivideByZeroException zero)
//    {
//        Console.WriteLine("The number here cannot be zero");
//    }
//}
//catch (FormatException form)
//{
//    Console.WriteLine("Input Only Number");
//}


//try
//{
//    int[] arr = new int[5] { 10, 15, 7, 3, 24 };


//    foreach (var item in arr)
//    {
//        Console.WriteLine("Arr {0}", item);
//    }
//    Console.WriteLine(arr[6]);
//}
//catch (IndexOutOfRangeException ex)
//{

//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("End of Block");
//}



