int FindMinimum(int a, int b, int c, int d)
{
     if(a<b && a<c && a<d){
        return a;
     }
     if(b<a && b<c && b<d){
        return b;
     }
     if(c<b && c<a && c<d){
        return c;
     }
     else {
        return d;
     }
}

int a, b, c, d;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindMinimum(a,b,c,d));