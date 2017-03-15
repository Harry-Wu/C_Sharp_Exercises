class HelloWorld
{
    static void Main()
    {
        string name,sex;
        System.Console.WriteLine("请输入你的名字:");
        name = System.Console.ReadLine();   
        System.Console.WriteLine("请输入你的性别:");
        sex = System.Console.ReadLine();   
        System.Console.WriteLine("你的名字\a和性别是:{1}{0}",name,sex);
    }
}