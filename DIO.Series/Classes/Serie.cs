using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series
{
    public enum Genero
    {
        Acao = 1, Aventura, Comedia, Documentario, Drama,
        Espionagem, Faroeste, Fantasia, Ficcao_Cientifica,
        Musical, Romance, Suspense, Terror
    }

    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + Genero + Environment.NewLine;
            retorno += "Titulo: " + Titulo + Environment.NewLine;
            retorno += "Descricao: " + Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + Ano;
            return retorno;
        }

        public string RetornaTitulo()
        {
            return Titulo;
        }

        public int RetornaId()
        {
            return Id;
        }

        public void Excluir()
        {
            Excluido = true;
        }
    }
}
