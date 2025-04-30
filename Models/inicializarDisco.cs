class inicializarDisco
{
     static Dictionary<string, disco> discos { get; set; }
    static Dictionary<string, tema> temas { get; set; }
    public static Dictionary<string, disco> Cargardiscos()
{
    discos = new Dictionary<string, disco>();
    temas = new Dictionary<string, tema>();
    tema tema;

    // Álbum 1 
    tema = new tema("Get Lucky");
    temas.Add("1-1", tema);
    tema = new tema("Lose Yourself to Dance");
    temas.Add("1-2", tema);
    tema = new tema("Instant Crush");
    temas.Add("1-3", tema);
    disco disco1 = new disco("Daft Punk", "Thomas Bangalter, Guy-Manuel de Homem-Christo", "Electrónica", "1", "/image/Random Access Memories.jpg", temas);
    discos.Add("Random Access Memories", disco1);

    // Álbum 2
    temas = new Dictionary<string, tema>();
    tema = new tema("Anti-Hero");
    temas.Add("2-1", tema);
    tema = new tema("Lavender Haze");
    temas.Add("2-2", tema);
    tema = new tema("Snow on the Beach");
    temas.Add("2-3", tema);
    disco disco2 = new disco("Taylor Swift", "Jack Antonoff", "Pop", "2", "/image/Midnights.jpg", temas);
    discos.Add("Midnights", disco2);

    // Álbum 3
    temas = new Dictionary<string, tema>();
    tema = new tema("Adventure of a Lifetime");
    temas.Add("3-1", tema);
    tema = new tema("Up&Up");
    temas.Add("3-2", tema);
    tema = new tema("Everglow");
    temas.Add("3-3", tema);
    disco disco3 = new disco("Coldplay", "Coldplay, Rik Simpson", "Rock", "3", "/image/A Head Full of Dreams.jpg", temas);
    discos.Add("A Head Full of Dreams", disco3);

    // Álbum 4
    temas = new Dictionary<string, tema>();
    tema = new tema("Blinding Lights");
    temas.Add("4-1", tema);
    tema = new tema("Save Your Tears");
    temas.Add("4-2", tema);
    tema = new tema("In Your Eyes");
    temas.Add("4-3", tema);
    disco disco4 = new disco("The Weeknd", "Max Martin, The Weeknd", "R&B", "4", "/image/after hours.jpg", temas);
    discos.Add("After Hours", disco4);

    // Álbum 5
    temas = new Dictionary<string, tema>();
    tema = new tema("Moscow Mule");
    temas.Add("5-1", tema);
    tema = new tema("Me Porto Bonito");
    temas.Add("5-2", tema);
    tema = new tema("Ojitos Lindos");
    temas.Add("5-3", tema);
    disco disco5 = new disco("Bad Bunny", "Tainy", "Reggaetón", "5", "/image/Un Verano Sin Ti.jpg", temas);
    discos.Add("Un Verano Sin Ti", disco5);

    // Álbum 6
    temas = new Dictionary<string, tema>();
    tema = new tema("Battery");
    temas.Add("6-1", tema);
    tema = new tema("Master of Puppets");
    temas.Add("6-2", tema);
    tema = new tema("Disposable Heroes");
    temas.Add("6-3", tema);
    disco disco6 = new disco("Metallica", "Flemming Rasmussen", "Metal", "6", "/image/Master of Puppets.jpg", temas);
    discos.Add("Master of Puppets", disco6);

    // Álbum 7
    temas = new Dictionary<string, tema>();
    tema = new tema("Bohemian Rhapsody");
    temas.Add("7-1", tema);
    tema = new tema("Love of My Life");
    temas.Add("7-2", tema);
    tema = new tema("You're My Best Friend");
    temas.Add("7-3", tema);
    disco disco7 = new disco("Queen", "Roy Thomas Baker", "Rock", "7", "/image/A Night at the Opera.jpg", temas);
    discos.Add("A Night at the Opera", disco7);

    // Álbum 8
    temas = new Dictionary<string, tema>();
    tema = new tema("Without Me");
    temas.Add("8-1", tema);
    tema = new tema("Superman");
    temas.Add("8-2", tema);
    tema = new tema("Till I Collapse");
    temas.Add("8-3", tema);
    disco disco8 = new disco("Eminem", "Dr. Dre", "Rap", "8", "/image/The Eminem Show.jpg", temas);
    discos.Add("The Eminem Show", disco8);

    // Álbum 9
    temas = new Dictionary<string, tema>();
    tema = new tema("Hello");
    temas.Add("9-1", tema);
    tema = new tema("Send My Love");
    temas.Add("9-2", tema);
    tema = new tema("Water Under the Bridge");
    temas.Add("9-3", tema);
    disco disco9 = new disco("Adele", "Greg Kurstin", "Soul", "9", "/image/25.jpg", temas);
    discos.Add("25", disco9);

    // Álbum 10
    temas = new Dictionary<string, tema>();
    tema = new tema("Formation");
    temas.Add("10-1", tema);
    tema = new tema("Sorry");
    temas.Add("10-2", tema);
    tema = new tema("Hold Up");
    temas.Add("10-3", tema);
    disco disco10 = new disco("Beyoncé", "Beyoncé, Diplo, Ezra Koenig", "R&B", "10", "/image/Lemonade.jpg", temas);
    discos.Add("Lemonade", disco10);

    // Álbum 11
    temas = new Dictionary<string, tema>();
    tema = new tema("Shape of You");
    temas.Add("11-1", tema);
    tema = new tema("Castle on the Hill");
    temas.Add("11-2", tema);
    tema = new tema("Perfect");
    temas.Add("11-3", tema);
    disco disco11 = new disco("Ed Sheeran", "Ed Sheeran, Benny Blanco", "Pop", "11", "/image/Divide.jpg", temas);
    discos.Add("Divide", disco11);
    
    // Álbum 12
    temas = new Dictionary<string, tema>();
    tema = new tema("Let It Happen");
    temas.Add("12-1", tema);
    tema = new tema("The Less I Know The Better");
    temas.Add("12-2", tema);
    tema = new tema("Eventually");
    temas.Add("12-3", tema);
    disco disco12 = new disco("Tame Impala", "Kevin Parker", "Psychedelic Rock", "12", "/image/Currents.jpg", temas);
    discos.Add("Currents", disco12);
    return discos;
}
}