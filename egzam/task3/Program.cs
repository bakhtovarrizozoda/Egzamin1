
var n = Convert.ToInt32(Console.ReadLine());
double cnt=0;
for(int i=0; i<n+1; i++)
{
    cnt +=Math.Pow(2,i);
}
Console.WriteLine(cnt);