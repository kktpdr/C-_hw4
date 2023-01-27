int Promt(string msg)
{
    System.Console.WriteLine($"{msg}: ");
    return int.Parse(Console.ReadLine());
}


int num = Promt("Put a number");
int SumNumber(int numberN){
int counter = Convert.ToString(num).Length;
int advance = 0;
int result = 0;

for (int i = 0; i < counter; i++)
{
    advance = num - num % 10;
    result = result + (num - advance);
    num = num / 10;
    }
   return result;
}

int sumNumber = SumNumber(num);
Console.WriteLine("Sum: " + sumNumber);