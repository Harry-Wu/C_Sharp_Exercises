class HelloWorld
{
    static void Main()
    {
         System.Console.WriteLine("请输入:");
        string message1 = System.Console.ReadLine();
        string str1,str2;
        str1 = str2 = "qwe";

        str1 = "abc";
        System.Console.WriteLine(str1);
        str1 = "123123123";
        System.Console.WriteLine(str1);
        System.Console.WriteLine(str2);
        //message1 = "这是我的第一个C#程序！";       
        System.Console.WriteLine("你输入的是:"+message1);
    }
}