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



public class Prestito
{
    public Prestito(int id, Cliente cliente, int ammontare, double rata, DateOnly dataInizio, DateOnly dataFine)
    {
        this.Id = id;
        this.Cliente = cliente;
        this.Ammontare = ammontare;
        this.Rata = rata;
        this.DataInizio = dataInizio;
        this.DataFine = dataFine;
    }

    public Prestito()
    {

    }

    public int Id { get; set; }
    public Cliente Cliente { get; set; }
    public int Ammontare { get; set; }
    public double Rata { get; set; }
    public DateOnly DataInizio { get; set; }
    public DateOnly DataFine { get; set; }


}
