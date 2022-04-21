using ListaAppuntamenti;

List<Appuntamento> appuntamenti = new List<Appuntamento>();

Console.WriteLine("Quanti appuntamenti vuoi inserire: ");
int numeroAppuntamenti = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci le informazioni per ogni appuntamento uno per volta");
for (int i = 0; i < numeroAppuntamenti; i++)
{
    DateTime data;
    string nome;
    string local;
    Console.WriteLine("Appuntamento numero " + (i+1));
    Console.WriteLine("Inserisci la data:");
    try
    { 
        data = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il nome:");
        nome = Console.ReadLine();
        Console.WriteLine("Inserisci la località:");
        local = Console.ReadLine();
        Appuntamento app = new(data, nome, local);
        appuntamenti.Add(app);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        data = DateTime.MinValue;
        i--;
    }

}

foreach (Appuntamento app in appuntamenti)
{
    Console.WriteLine(app.ToString());
}