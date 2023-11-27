using CleverenseSoftTests.Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Compressor c = new Compressor();
        string a = c.Compression("aaacbbd");
        string b = c.Decompression(a);
        Console.WriteLine(a);

    }
}