class disco
{
    string artista { get; set; }
    string productor { get; set; }
    string genero { get; set; }
    Dictionary<string, tema> temas { get; set; }
    string id { get; }
    string foto { get; set; }
    public disco(string artista, string productor, string genero, string id, string foto, Dictionary<string, tema> temas)
    {
        this.artista = artista;
        this.productor = productor;
        this.genero = genero;
        this.temas = temas;
        this.id = id;
        this.foto = foto;
    }
}