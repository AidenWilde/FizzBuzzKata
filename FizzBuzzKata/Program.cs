namespace FizzBuzzKata
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var kata = new FizzBuzzKata();
            var results = kata.Execute(Enumerable.Range(1, 100));
        
            foreach(var result in results)
            {
                Console.WriteLine($"({result.GetValue()}) {result.GetType().Name}");
            }
        }
    }
}