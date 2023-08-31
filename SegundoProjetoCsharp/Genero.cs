class Genero
{
    private List<Banda> ListaArtistas = new List<Banda>();
    private List<Musica> ListaMusicas = new List<Musica>();

    public Genero(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public string Descricao { get; set; }    
}