
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
using System.Runtime.CompilerServices;

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
    }

    public void modificaStipendio(List<Cliente> Clienti)
    {
        Console.WriteLine("Inserisci il codice fiscale dell'utente che vuoi modificare: ");
        string CF = Console.ReadLine();

        for(int i = 0; i < Clienti.Count; i++)
        {
            if(Clienti[i].CF == CF) {
                Console.WriteLine("Inserisci il nuovo stipendio");
                double s = Convert.ToDouble(Console.ReadLine());
                Clienti[i].Stipendio = s;
            }
        }
    }

    public Cliente ricercaCliente(List<Cliente> Clienti)
    {
        Cliente c = new Cliente();
        Console.WriteLine("Inserisci il codice fiscale dell'utente");
        c.CF = Console.ReadLine();
        foreach (Cliente cliente in Clienti)
        {
            if (cliente.CF == c.CF)
            {
                c = cliente;
            }
        }
        return c;
    }

    public void stampaUtente(Cliente C)
    {
        Console.WriteLine($"Utente: {C.CF}");
        Console.WriteLine($"Nome: {C.Nome}");
        Console.WriteLine($"Cognome: {C.Cognome}");
        Console.WriteLine($"Stipendio: {C.Stipendio}");
    }

    public void addPrestito(List<Prestito> Prestiti)
    {
        Console.WriteLine("Inserimento Prestito:");
        Console.WriteLine("");
        Prestito p = new Prestito();
        Console.WriteLine("Inserisci l'ID del prestito: ");
        p.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci il codice Fiscale del Utente: ");
        p.Cliente.CF = Console.ReadLine();
        Console.WriteLine("Inserisci l'ammontare del prestito: ");
        p.Ammontare = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci la data di inizio del prestito: ");
        p.DataInizio = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci la data di fine del prestito: ");
        p.DataFine = DateOnly.Parse(Console.ReadLine());
        Prestiti.Add(p);
    }

    public Prestito ricercaPrestito(List<Prestito> Prestiti)
    {
        Prestito p = new Prestito();
        Console.WriteLine("Inserisci il codice fiscale dell'utente");
        p.Cliente.CF = Console.ReadLine();
        foreach (Prestito prestito in Prestiti)
        {
            if (prestito.Cliente.CF == p.Cliente.CF)
            {
                p = prestito;
            }
        }
        return p;
    }

    public List<int> numeroPrestiti(List<Prestito> Prestiti, string CF)
    {
        List<int> countPrestiti = new List<int>();
        Console.WriteLine("Inserisci il codice fiscale dell'utente");
        CF = Console.ReadLine();

        foreach (Prestito prestito in Prestiti)
        {
            if(prestito.Cliente.CF == CF)
            {
                countPrestiti.Add(prestito.Id);
            }
        }
        return countPrestiti;
    }

    public double rateRimanenti(List<Prestito> Prestiti)
    {
        List<int> countPrestiti = new List<int>(); 
        double totDaPagare = 0;
        int mesiRimasti = 0;
        DateOnly Today = new DateOnly();    
        Console.WriteLine("Inserisci il codice fiscale: ");
        string CF = Console.ReadLine();

        countPrestiti = numeroPrestiti(Prestiti, CF);

        
        foreach(int idPrestito in countPrestiti)
        {
            for(int i = 0; i < Prestiti.Count; i++)
            {
                if(idPrestito == Prestiti[i].Id)
                {
                    mesiRimasti = Prestiti[i].DataFine.AddMonths(- Today.FromDateTime(DateTime.Now));
                }
            }
        }

        return totDaPagare;
    }


}