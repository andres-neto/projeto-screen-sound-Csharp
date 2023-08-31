class Playlist
{
    public List<Musica> ListaDeReproducao = new List<Musica>();

    public Playlist(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    
    public void AdicionarMusica(Musica musica)
    {
        ListaDeReproducao.Add(musica);
    }

    public void AdicionarAlbum(Album album)
    {
        foreach (var musica in album.RetornaListaAlbum())
        {
            ListaDeReproducao.Add(musica);
        }       
    }

    public void ExibirPlaylistSalva()
    {
        Console.WriteLine("");
        foreach (Musica musica in ListaDeReproducao)
        {
            Console.WriteLine($"{musica.Nome}");
        }
    }
}
