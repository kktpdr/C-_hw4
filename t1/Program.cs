int Promt(string msg)
{
    System.Console.WriteLine($"{msg}: ");
    return int.Parse(Console.ReadLine());
}


int a = Promt("Put A");
int b = Promt("Put B");

int Exponentiation(int a, int b){
    int result = 1;
    for (int i=1; i<b+1; i++)
    {
        result = result*a;
    }

    return result;
}
int exponentiation = Exponentiation(a, b);
System.Console.WriteLine($"{exponentiation}");