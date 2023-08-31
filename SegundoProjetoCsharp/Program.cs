Banda queen = new Banda("Queen");
Album albumDoQueen = new Album("A night at the opera");
Musica musica1 = new Musica(queen, "Love of my life", "Classic rock")
{
    Duracao = 213,
    Disponivel = true
};
Musica musica2 = new Musica(queen, "Bohemian Rhapsody", "Classic rock")
{
    Duracao = 354,
    Disponivel = false
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
albumDoQueen.ExibirMusicasDoAlbum();
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");

Episodio ep1 = new Episodio(2, "Título inicial", 40);
ep1.AdicionarConvidados("Fulano");
ep1.AdicionarConvidados("Ciclano");
Console.WriteLine($"\nResumo: {ep1.Resumo}");
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");

Episodio ep2 = new Episodio(1, "Título secundário", 32);
ep2.AdicionarConvidados("Beltrano");
Console.WriteLine($"\nResumo: {ep2.Resumo}");
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");

Episodio ep3 = new Episodio(3, "Título terceiro", 63);
ep3.AdicionarConvidados("Antônio");
ep3.AdicionarConvidados("Beatriz");
ep3.AdicionarConvidados("Camila");
Console.WriteLine($"\nResumo: {ep3.Resumo}");
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");

Podcast pod1 = new Podcast("C# Cast", "O programador");
pod1.AdicionarEpisodio(ep1);
pod1.ExibirDetalhes();
pod1.AdicionarEpisodio(ep2);
pod1.AdicionarEpisodio(ep3);
pod1.ExibirDetalhes();
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");

Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");

/* Testes extras
Banda pinkFloyd = new Banda("Pink Floyd");
Album albumDoPinkFloyd = new Album("The Dark Side of the Moon");
Musica musica3 = new Musica(pinkFloyd, "Money", "Progressive rock")
{
    Duracao = 382,
    Disponivel = false
};

albumDoPinkFloyd.AdicionarMusica(musica3);
albumDoPinkFloyd.ExibirMusicasDoAlbum();
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");

pinkFloyd.AdicionarAlbum(albumDoPinkFloyd);
pinkFloyd.ExibirDiscografia();
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");

Playlist playlist = new Playlist("Nova playlist");
playlist.AdicionarAlbum(albumDoQueen);
playlist.ExibirPlaylistSalva();
playlist.AdicionarMusica(musica3);
playlist.ExibirPlaylistSalva();
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");
*/

/* Testes anteriores

Banda thePolice = new Banda("The Police");
Musica musica11 = new Musica(thePolice, "Roxane", "Rock")
{
    Duracao = 273,
    Disponivel = true
};

Console.WriteLine(musica11.DescricaoResumida);

Banda u2 = new Banda("U2");
Musica musica22 = new Musica(u2, "Vertigo", "Rock")
{
    Duracao = 367,
    Disponivel = false
};

musica11.ExibirNomeEArtista();
musica22.ExibirNomeEArtista();
*/