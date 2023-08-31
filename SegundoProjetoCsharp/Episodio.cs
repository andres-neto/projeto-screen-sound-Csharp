class Episodio
{
    private List<string> convidados = new List<string>();

    public Episodio(int numero, string titulo, int duracao)
    {
        Ordem = numero; 
        Titulo = titulo;        
        Duracao = duracao;
    }

    public string Titulo { get; }
    public int Ordem { get; }
    public int Duracao { get; }
    public string Resumo => 
        $"Episódio {Ordem}. {Titulo} ({Duracao} min) - Convidados: {string.Join(", ", convidados)}";
        
    public void AdicionarConvidados(string nome)
    {
        convidados.Add(nome);
    }
}