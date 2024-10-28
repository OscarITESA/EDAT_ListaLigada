using ListaLigada.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! Lista Ligada Simple");
        Console.WriteLine("");

        var singleList = new SingleList<string>();

        singleList.Add("Alondra");
        singleList.Add("Karla");
        singleList.Add("Juan");
        singleList.Add("Luis");
        singleList.Add("Jose");

        Console.WriteLine(singleList);

        Console.ReadKey();
    }
}