class inicializarDisco
{
    static Dictionary<string, disco> discos { get; set; }
    static Dictionary<string, tema> temas { get; set; }
    public static void Cargardiscos()
{
    discos = new Dictionary<string, disco>();
    temas = new Dictionary<string, tema>();
    tema tema;

    // Álbum 1 (Ejemplo cambiado)
    tema = new tema("Get Lucky");
    temas.Add("1-1", tema);
    tema = new tema("Lose Yourself to Dance");
    temas.Add("1-2", tema);
    tema = new tema("Instant Crush");
    temas.Add("1-3", tema);
    disco disco1 = new disco("Daft Punk", "Random Access Memories", "Electrónica", "1", "", temas);
    discos.Add("1", disco1);

    // Álbum 2
    temas = new Dictionary<string, tema>();
    tema = new tema("Anti-Hero");
    temas.Add("2-1", tema);
    tema = new tema("Lavender Haze");
    temas.Add("2-2", tema);
    tema = new tema("Snow on the Beach");
    temas.Add("2-3", tema);
    disco disco2 = new disco("Taylor Swift", "Midnights", "Pop", "2", "", temas);
    discos.Add("2", disco2);

    // Álbum 3
    temas = new Dictionary<string, tema>();
    tema = new tema("Adventure of a Lifetime");
    temas.Add("3-1", tema);
    tema = new tema("Up&Up");
    temas.Add("3-2", tema);
    tema = new tema("Everglow");
    temas.Add("3-3", tema);
    disco disco3 = new disco("Coldplay", "A Head Full of Dreams", "Rock", "3", "", temas);
    discos.Add("3", disco3);

    // Álbum 4
    temas = new Dictionary<string, tema>();
    tema = new tema("Blinding Lights");
    temas.Add("4-1", tema);
    tema = new tema("Save Your Tears");
    temas.Add("4-2", tema);
    tema = new tema("In Your Eyes");
    temas.Add("4-3", tema);
    disco disco4 = new disco("The Weeknd", "After Hours", "R&B", "4", "", temas);
    discos.Add("4", disco4);

    // Álbum 5
    temas = new Dictionary<string, tema>();
    tema = new tema("Moscow Mule");
    temas.Add("5-1", tema);
    tema = new tema("Me Porto Bonito");
    temas.Add("5-2", tema);
    tema = new tema("Ojitos Lindos");
    temas.Add("5-3", tema);
    disco disco5 = new disco("Bad Bunny", "Un Verano Sin Ti", "Reggaetón", "5", "", temas);
    discos.Add("5", disco5);

    // Álbum 6
    temas = new Dictionary<string, tema>();
    tema = new tema("Battery");
    temas.Add("6-1", tema);
    tema = new tema("Master of Puppets");
    temas.Add("6-2", tema);
    tema = new tema("Disposable Heroes");
    temas.Add("6-3", tema);
    disco disco6 = new disco("Metallica", "Master of Puppets", "Metal", "6", "", temas);
    discos.Add("6", disco6);

    // Álbum 7
    temas = new Dictionary<string, tema>();
    tema = new tema("Bohemian Rhapsody");
    temas.Add("7-1", tema);
    tema = new tema("Love of My Life");
    temas.Add("7-2", tema);
    tema = new tema("You're My Best Friend");
    temas.Add("7-3", tema);
    disco disco7 = new disco("Queen", "A Night at the Opera", "Rock", "7", "", temas);
    discos.Add("7", disco7);

    // Álbum 8
    temas = new Dictionary<string, tema>();
    tema = new tema("Without Me");
    temas.Add("8-1", tema);
    tema = new tema("Superman");
    temas.Add("8-2", tema);
    tema = new tema("Till I Collapse");
    temas.Add("8-3", tema);
    disco disco8 = new disco("Eminem", "The Eminem Show", "Rap", "8", "", temas);
    discos.Add("8", disco8);

    // Álbum 9
    temas = new Dictionary<string, tema>();
    tema = new tema("Hello");
    temas.Add("9-1", tema);
    tema = new tema("Send My Love");
    temas.Add("9-2", tema);
    tema = new tema("Water Under the Bridge");
    temas.Add("9-3", tema);
    disco disco9 = new disco("Adele", "25", "Soul", "9", "", temas);
    discos.Add("9", disco9);

    // Álbum 10
    temas = new Dictionary<string, tema>();
    tema = new tema("Formation");
    temas.Add("10-1", tema);
    tema = new tema("Sorry");
    temas.Add("10-2", tema);
    tema = new tema("Hold Up");
    temas.Add("10-3", tema);
    disco disco10 = new disco("Beyoncé", "Lemonade", "R&B", "10", "", temas);
    discos.Add("10", disco10);

    // Álbum 11
    temas = new Dictionary<string, tema>();
    tema = new tema("Shape of You");
    temas.Add("11-1", tema);
    tema = new tema("Castle on the Hill");
    temas.Add("11-2", tema);
    tema = new tema("Perfect");
    temas.Add("11-3", tema);
    disco disco11 = new disco("Ed Sheeran", "Divide", "Pop", "11", "", temas);
    discos.Add("11", disco11);
    
    // Álbum 12
    temas = new Dictionary<string, tema>();
    tema = new tema("Let It Happen");
    temas.Add("12-1", tema);
    tema = new tema("The Less I Know The Better");
    temas.Add("12-2", tema);
    tema = new tema("Eventually");
    temas.Add("12-3", tema);
    disco disco12 = new disco("Tame Impala", "Currents", "Psychedelic Rock", "12", "", temas);
    discos.Add("12", disco12);
}

}