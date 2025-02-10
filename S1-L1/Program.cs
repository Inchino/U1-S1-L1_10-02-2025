using System;

namespace EsercizioClassiCSharp
{
    class Atleta
    {
        public string Nome { get; set; }
        public string Sport { get; set; }
        public int Età { get; set; }

        public void MostraInfo()
        {
            Console.WriteLine($"Atleta: {Nome}, Sport: {Sport}, Età: {Età} anni.");
        }
    }

    class Dipendente
    {
        public string Nome { get; set; }
        public string Posizione { get; set; }
        public double Stipendio { get; set; }

        public void MostraInfo()
        {
            Console.WriteLine($"Dipendente: {Nome}, Posizione: {Posizione}, Stipendio: {Stipendio} euro.");
        }
    }

    class Animale
    {
        public string Specie { get; set; }
        public string Nome { get; set; }
        public int Età { get; set; }

        public void MostraInfo()
        {
            Console.WriteLine($"Animale: {Specie}, Nome: {Nome}, Età: {Età} anni.");
        }
    }

    class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Anno { get; set; }

        public void MostraInfo()
        {
            Console.WriteLine($"Veicolo: {Marca} {Modello}, Anno: {Anno}.");
        }
    }
}

