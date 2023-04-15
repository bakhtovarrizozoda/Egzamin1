var n = Convert.ToInt32(Console.ReadLine());
var arr = new int[n];
for(int i=0; i<n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i=1; i<n-1; i++)
{
    Console.Write(arr[i] + " ");
}