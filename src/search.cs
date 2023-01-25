using System;
using System.IO;
using System.Collections.Generic;
 
class Search
{
    static void PrintInstructions(){
            Console.WriteLine("Per lanciare lo script e' necessario specificare:");
            Console.WriteLine("1. il percorso del file .csv da cui estrarre i dati;");
            Console.WriteLine("2. il numero della colonna in cui cercare;");
            Console.WriteLine("3. una chiave di ricerca\n");
            Console.WriteLine("Esempio:");
            Console.WriteLine("$ search.exe ../file.csv 2 Alberto");
    }

    static void Main(string[] args){

        int n;
        if(args.Length != 3){
            Console.WriteLine("Il numero di argomenti passati non e' corretto.\n");
            PrintInstructions();
            return;

        } if(!File.Exists(args[0])){
            Console.WriteLine("Il percorso specificato non è corretto.\n");
            PrintInstructions();
            return;

        } if(!Int32.TryParse(args[1], out n)){

            Console.WriteLine("Il numero della colonna specificato non è corretto.\n");
            PrintInstructions();
            return;
        }

        List<string> column = new List<string>();
        string line = "";

        using(var reader = new StreamReader(args[0]))
        {
            
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                var values = line.Split(',');
 
                column.Add(values[n]);
            }
        }

        foreach(string item in column)
        {
            if(item.Contains(args[2])){
                Console.WriteLine(line);
                return;
            }
        
        }

        Console.WriteLine("La ricerca non ha prodotto risultati");

    }
}