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

void stampa() { 
    Console.WriteLine("Lista degli appuntamenti:");
    foreach (Appuntamento app in appuntamenti)
    {
        Console.WriteLine(app.ToString());
    }
}

stampa();

Console.WriteLine("Vuoi modificare un'appuntamento: Si/No");
string risposta = Console.ReadLine();

if(risposta.ToLower() == "si")
{
    Console.WriteLine("Inserisci il nome dell'appuntamento");
    risposta = Console.ReadLine();
    for (int i = 0; i < appuntamenti.Count; i++)
    {
        if (appuntamenti[i].getNome() == risposta)
        {
            bool flag=true;
            do {
                try
                {
                    Console.WriteLine("Inserisci la nuova data per appuntamento " + appuntamenti[i].getNome());
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    appuntamenti[i].setDataOra(data);
                    flag = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    flag = false;
                }
            } while (flag==false);

            if (flag==true)
            {
                Console.WriteLine("Data modificata con successo");
                stampa();
            }
        }
    }
}