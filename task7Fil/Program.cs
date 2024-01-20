
int SumOfDigits(int n)
{
    int s = n%10;
    if(n<=0)
    {
        return 0;
    }
    else{
      SumOfDigits(n%10);
         s++;
      SumOfDigits(n/10);

    }
}

System.Console.WriteLine(s++);

