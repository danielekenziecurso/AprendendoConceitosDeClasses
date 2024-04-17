﻿namespace AprendendoConceitosDeClasses.Modelos;
internal class Banda : IAvaliavel
{
    private List<Album> albums = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public List<Album> Albums => albums;
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
    public void ExibirDiscogrsfia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach(Album album in albums)
        {
            Console.WriteLine($"Album: {album.Nome} {album.DuracaoTotal}");
        }
    }
}