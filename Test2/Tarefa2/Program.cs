namespace Tarefa2;

class Program
{
    static void Main(string[] args)
    {
        // Cenário 1
        int[] array1 = [3, 2, 1, 6, 0, 5];
        var arvore1 = new ArvoreBinariaMax();
        arvore1.ConstruirArvore(array1);

        Console.WriteLine("Cenário 1");
        Console.WriteLine($"Array de entrada: [{string.Join(", ", array1)}]");
        Console.WriteLine($"Raiz: {arvore1.Raiz}");
        Console.WriteLine($"Galhos da esquerda: {string.Join(", ", arvore1.GalhosEsquerda)}");
        Console.WriteLine($"Galhos da direita: {string.Join(", ", arvore1.GalhosDireita)}");

        Console.WriteLine();

        // Cenário 2
        int[] array2 = [7, 5, 13, 9, 1, 6, 4];
        var arvore2 = new ArvoreBinariaMax();
        arvore2.ConstruirArvore(array2);

        Console.WriteLine("Cenário 2");
        Console.WriteLine($"Array de entrada: [{string.Join(", ", array2)}]");
        Console.WriteLine($"Raiz: {arvore2.Raiz}");
        Console.WriteLine($"Galhos da esquerda: {string.Join(", ", arvore2.GalhosEsquerda)}");
        Console.WriteLine($"Galhos da direita: {string.Join(", ", arvore2.GalhosDireita)}");

        Console.WriteLine();

        // Cenário 3
        int[] array3 = [7, 5, 8, 13, 9, 29, 100, 1, 6, 4, 99, 50];
        var arvore3 = new ArvoreBinariaMax();
        arvore3.ConstruirArvore(array3);

        Console.WriteLine("Cenário 3");
        Console.WriteLine($"Array de entrada: [{string.Join(", ", array3)}]");
        Console.WriteLine($"Raiz: {arvore3.Raiz}");
        Console.WriteLine($"Galhos da esquerda: {string.Join(", ", arvore3.GalhosEsquerda)}");
        Console.WriteLine($"Galhos da direita: {string.Join(", ", arvore3.GalhosDireita)}");
    }
}