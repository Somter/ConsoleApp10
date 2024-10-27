using ConsoleApp10;
using System.Collections;   

class MainClass
{
    public static void Main()
    {
        try
        {
            ClassMenu menu = new ClassMenu(); 
            menu.Menu();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
