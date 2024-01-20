
int  Fibonacci(int a )
{
    if(a<=0) 
     { return 1;
    }
    else{
          return a*Fibonacci(a-1);
    }
}
System.Console.WriteLine(Fibonacci(Convert.ToInt32(Console.ReadLine)));
