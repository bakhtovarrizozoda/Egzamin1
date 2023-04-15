

public class Calculator
{
    public long n;
    public double a;
    public double b;


    public long Factorial()
    {
        int cnt=1;
       for(int i=1; i<n+1; i++)
       {
        cnt= cnt *=i;
       }
       return cnt;
    }
    public double Multiple()
    {
        return a * b;
    }
    public double Division()
    {
        return a / b;
    }
    

}