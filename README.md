# C#-challenge
Basic C# exercise to test my skills

## Consegna
Si implementi in C#, uno script da eseguire da linea di comando.<br/>
Si possono usare librerie di terze parti a vostro piacimento.<br/>
Lo script riceve in input il percorso di un file csv da importare, un numero di colonna nel quale cercare, una chiave di ricerca.<br/>
Lo script dovrà essere così invocato (esempio in PHP):

        $ php src/search.php ./file.csv 2 Alberto

dove ./file.csv è il percorso di un file csv così formattato:

        1,Rossi,Fabio,01/06/1990; <br/>
        2,Gialli,Alessandro,02/07/1989;<br/>
        3,Verdi,Alberto,03/08/1987;

Il numero 2 rappresenta l'indice di colonna in cui cercare (nel file precedente il nome)<br/>
Alberto rappresenta la chiave di ricerca.<br/>

L'output del comando deve essere la linea corrispondente, nel nostro caso:

        3,Verdi,Alberto,03/08/1987;

## How to run the script (Windows):

1. Open cmd
2. Set path of .net framework (generally: C:\Windows\Microsoft.NET\Framework\v4.0.30319)

        $ set path="C:\Windows\Microsoft.NET\Framework\v4.0.30319"

3. Go to C-Challenge\src
4. Build the C# script

        $ csc search.cs

5. The .exe file shoul be created
6. Run the .exe file

        $ search.exe
