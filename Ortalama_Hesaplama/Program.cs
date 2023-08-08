internal class Program
{
    private static void Main(string[] args)
    {
        
       
        System.Console.WriteLine("ne kadar derin bi seri istiyorsunuz: ");
        int n = int.Parse(Console.ReadLine());

        
        int[] f = new int[n];

        f[0] = 0;
        if(n > 1)
            f[1] = 1;
        
        for (int i = 2; i < n; i++)
        {
            f[i] = f[i-1] + f[i-2];
        }
        
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum+=f[i];
        }
        
        double avr = sum / n;
        System.Console.WriteLine(avr);
        
    }
}