using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ApplicationTemplate.Services;

/// <summary>
///     This concrete service and method only exists an example.
///     It can either be copied and modified, or deleted.
/// </summary>
public class FileService : IFileService
{
    private readonly ILogger<IFileService> _logger;

    private string file = "movies.json";


    private Movie movie;

    private List<Movie> movieList = new List<Movie>();

    private List<string> list = new List<string>();


   // MovieList list = new MovieList();



    public FileService(ILogger<IFileService> logger)
    {
        _logger = logger;
    }

    public void Read()

    {
      
        _logger.Log(LogLevel.Information, "Reading");
        Console.WriteLine("*** I am reading");

        if (File.Exists(file))
        {
            var sr = new StreamReader(file);
            try
            {
                sr.ReadLine();


                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();

                    movie = JsonConvert.DeserializeObject<Movie>(line);
                    
                    list.Add(movie);
                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                sr.Close();
            }
           /* Console.WriteLine("how many records would you like to see ");
            var amount = Convert.ToInt32(Console.ReadLine());
            var loop = list.getMovies() - amount;*/

               for (var i = 0; i < list.Count; i++)
               {
                   Console.WriteLine(list[i]);
                   Console.WriteLine();
               }


           //var sw = new StreamWriter(file, true);

            // json = JsonConvert.;

        }

    }


    public void Write()
    {

        using (var sw = new StreamWriter(movie))
        {
            //  movie = JsonConvert.SerializeObject("");
            sw.WriteLine(movie);

            //var sw = new StreamWriter(file, true);
        }
    // gathering user input

        //  var id = Lines.Count + 1;


        Console.WriteLine("Movie Id");
        var id = Convert.ToInt64(Console.ReadLine());

        while (check.IdContains(id))
        {
            Console.WriteLine($"ID {id} already exists make another ID");
            id = Convert.ToInt64(Console.ReadLine());
        }


        Console.WriteLine("Title");
        var title = Console.ReadLine();
        while (check.TitleContains(title))
        {
            Console.WriteLine($"Title {title} already exists make another Title");
            title = Console.ReadLine();
        }


        Console.WriteLine("how many genres");
        var genre = Convert.ToInt32(Console.ReadLine());


        // a string array with the sise of watchers variable i can add to in my loop 
        var genres = new string[genre];
        // for loop to store the names the user enters followed by a pipe so i don't have to edit the way the file reads 
        for (var i = 0; i < genre; i++)
        {
            Console.WriteLine("whats the genre(s)");
            genres[i] = Console.ReadLine();
        }


        sw.WriteLine(check.create(id, title, string.Join('|', genres)));
        Lines.Add(check.create(id, title, string.Join('|', genres)));


        sw.Close(); // always close and don't loop your close statement
        list.AddMovie(movie, json);
    }
}
    