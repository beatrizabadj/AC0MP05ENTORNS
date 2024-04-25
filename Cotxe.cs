using System;
using System.Collections.Generic;

public class Cotxe
{
    public string? Marca { get; set; }
    public string? Model { get; set; }
    public int Kilometres { get; set; }
    public int anyFabricacio { get; set; }
    public int anyMatriculacio { get; set; }
    public DateTime dataCompra { get; set; }
    public double preuCompra { get; set; }
    public bool probat { get; set; }

    public Cotxe() { }

    public double CalculPreuVenta()
    {
        double recarrec = 0.30;
        return preuCompra * (1 + recarrec);
    }
}

public class Client
{
    public string nom { get; set; }
    public string dni { get; set; }
    public double pagaSenyal { get; set; }

    public Client(string nom, string dni, double pagaSenyal)
    {
        this.nom = nom;
        this.dni = dni;
        this.pagaSenyal = pagaSenyal;
    }
}

public class Proveidor
{
    public string nom { get; set; }
    public string dni { get; set; }

    public Proveidor(string nom, string dni)
    {
        this.nom = nom;
        this.dni = dni;
    }
}

public class Concessionari
{
    public string nom { get; set; }
    public string direccio { get; set; }
    public List<Cotxe> Inventari { get; set; }
    public List<Client> Clients { get; set; }
    public List<Proveidor> Proveidors { get; set; }

    public Concessionari(string nom, string direccio)
    {
        this.nom = nom;
        this.direccio = direccio;
        this.Inventari = new List<Cotxe>();
        this.Clients = new List<Client>();
        this.Proveidors = new List<Proveidor>();
    }

    public void AgregarCotxe(Cotxe cotxe)
    {
        Inventari.Add(cotxe);
    }

    public void EliminarCotxe(Cotxe cotxe)
    {
        Inventari.Remove(cotxe);
    }

    public void AgregarClient(Client client)
    {
        Clients.Add(client);
    }

    public void AgregarProveidor(Proveidor proveidor)
    {
        Proveidors.Add(proveidor);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Cotxe cotxe = new Cotxe //creacio coche
        {
            Marca = "Hyundai",
            Model = "Elantra",
            Kilometres = 25000,
            anyFabricacio = 2019,
            anyMatriculacio = 2019,
            dataCompra = DateTime.Now,
            preuCompra = 15000,
            probat = true
        };

        Console.WriteLine($"Preu de venta: {cotxe.CalculPreuVenta()}");

        Client client = new Client("Beatriz Abad", "88888888K", 1000); //Creacio client
        Console.WriteLine($"Client: {client.nom}, DNI: {client.dni}, Paga i senyal: {client.pagaSenyal}");

        Concessionari concessionari = new Concessionari("El meu concessinoari", "Mercat de Santa Catarina");
        concessionari.AgregarCotxe(cotxe);
        Console.WriteLine($"Concessionari: {concessionari.nom}, Direcció: {concessionari.direccio}");
    }
}
