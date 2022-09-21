﻿
/*
 
Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.
La banca è caratterizzata da
un nome
un insieme di clienti (una lista)
un insieme di prestiti concessi ai clienti (una lista)
I clienti sono caratterizzati da
nome,
cognome,
codice fiscale
stipendio
I prestiti sono caratterizzati da
ID
intestatario del prestito (il cliente),
un ammontare,
una rata,
una data inizio,
una data fine.
Per la banca deve essere possibile:
aggiungere, modificare e ricercare un cliente.
aggiungere un prestito.
effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.
Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati che li
caratterizzano in un formato di tipo stringa a piacere.
Bonus:
visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.

 */
public class Banca
{
    public Banca(string nome, List<Cliente> listaClienti, List<Prestito> listaPrestiti)
    {
        this.Nome = nome;
        this.ListaClienti = listaClienti;
        this.ListaPrestiti = listaPrestiti;
    }

    public string Nome { get; set; }
    public List<Cliente> ListaClienti { get; set; }
    public List<Prestito> ListaPrestiti { get; set; }

    public void AddUser(List<Cliente> Clienti)
    {
        Console.WriteLine("Inserimento Cliente:");
        Console.WriteLine("");
        Cliente c = new Cliente();
        Console.WriteLine("Inserisci il nome del Codice Fiscale: ");
        c.CF = Console.ReadLine();
        Console.WriteLine("Inserisci il nome del cliente: ");
        c.Nome = Console.ReadLine();
        Console.WriteLine("Inserisci il cognome del cliente: ");
        c.Cognome = Console.ReadLine();
        Console.WriteLine("Inserisci lo stipendio  del cliente: ");
        c.Stipendio = Convert.ToDouble(Console.ReadLine());
        Clienti.Add(c);
        Console.WriteLine("Utente aggiunto!");
    }
}