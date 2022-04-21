using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAppuntamenti
{
    internal class Appuntamento
    {
        private DateTime dataOra;
        private string nome;
        private string localitaAppuntamento;

        public Appuntamento(DateTime dateTime, string nome, string localita)
        {
            setDataOra(dateTime);
            setNome(nome);  
            setLocalita(localita);
        }

        public DateTime getDataOra()
        {
            return dataOra;
        }
        public string getNome()
        {
            return nome;
        }
        public string getLocalita()
        {
            return localitaAppuntamento;
        }
        public void setDataOra(DateTime dateTime)
        {
            if (dateTime > DateTime.Now)
                this.dataOra = dateTime;
            else
                throw new Exception("Ora inserita non corretta, l'orario è nel passato");
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setLocalita(string localita)
        {
            localitaAppuntamento = localita;
        }

        public override string ToString()
        {
            return "Data: " + dataOra + "\nNome: " + nome + "\nLocalità: " + localitaAppuntamento;
        }
    }
}
