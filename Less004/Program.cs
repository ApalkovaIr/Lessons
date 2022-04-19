// Принимаем, что работаем с целыми числами
int N = Console.Read(); 
int a = 1;
int i = 1;
while (true)
{
    if(a % 2 == 0)
    {
      System.Console.WriteLine("a");
      i = i + 1;
    }
    if (i > N )
    { 
        break;
    }
}