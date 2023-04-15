
var n = Convert.ToInt32(Console.ReadLine());
var arr = new int[n];
for(int i=0; i<n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int cnt=1;
for(int i=1; i<n; i++)
{
    if(arr[i]!=arr[i-1])cnt++;
}
Console.WriteLine(cnt);