namespace Tarefa2;

class ArvoreBinariaMax
{
    public int Raiz { get; private set; }
    public List<int> GalhosEsquerda { get; } = [];
    public List<int> GalhosDireita { get; } = [];

    public void ConstruirArvore(int[] numeros)
    {
        var indiceRaiz = Array.IndexOf(numeros, numeros.Max());
        Raiz = numeros[indiceRaiz];

        for (var i = 0; i < numeros.Length; i++)
        {
            if (i == indiceRaiz)
                continue;

            if (i < indiceRaiz)
                GalhosEsquerda.Add(numeros[i]);

            if (i > indiceRaiz)
                GalhosDireita.Add(numeros[i]);
        }

        GalhosEsquerda.Sort((a, b) => b.CompareTo(a));
        GalhosDireita.Sort((a, b) => b.CompareTo(a));
    }
}