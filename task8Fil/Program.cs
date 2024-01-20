int a= Convert.ToInt32(Console.ReadLine);
int b = Convert.ToInt32(Console.ReadLine);
int c;
void Swap(ref int a, ref int b){
     a = c;
     b = a;
     c = b;
}

System.Console.WriteLine( ref Swap(a) );
System.Console.WriteLine( ref Swap(b) );