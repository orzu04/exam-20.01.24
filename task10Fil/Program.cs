int a=1;
int b=20;
void Even(int a,int b)
{
    if(a%2==0)
    {
        if(a>b)return;
        else{
            System.Console.Write(a+" ");
          Even(a+2,b);     
        }
        
    }
    else {
         System.Console.Write($"{a+1} ");
         Even(a+3,b);
    }
}
System.Console.WriteLine();
void Odd(int a,int b)
{
    if(a%2!=0)
    {
        if(a>b)return;
        else{
            System.Console.Write(a+" ");
         Odd(a+2,b);     
        }
        
    }
    else {
         System.Console.Write($"{a+1} ");
         Odd(a+3,b);
    }
}
Even(1,20);
System.Console.WriteLine();
Odd(1,20);

