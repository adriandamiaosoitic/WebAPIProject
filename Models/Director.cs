using System.Collections.Generic;

public class Director{

    public long Id { get; set; }
    public string Name { get; set; }
    public ICollection<Movie> Movies { get; set; }

    public Director(string name){ //Construido para poder inicializar uma lista de filmes
        Name = name;
        Movies = new List<Movie>();
    }

}