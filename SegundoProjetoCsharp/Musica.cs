class Musica
{
    public Musica(Banda artista, string nome, string estilo)
    {
        Artista = artista;
        Nome = nome;
        Estilo = new Genero(estilo);
    }

    public string Nome { get;  }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Estilo { get; }
    public string DescricaoResumida => // propriedade somente leitura
                                       // arrow function -> lambda
        $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Gênero: {Estilo.Nome}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus!");
        }
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
    }
}