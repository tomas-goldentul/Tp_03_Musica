class disco
{
    public string artista { get; set; }
     public string productor { get; set; }
     public string genero { get; set; }
   public Dictionary<string, tema> temas { get; set; }
  public  string id { get; }
  public  string foto { get; set; }

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