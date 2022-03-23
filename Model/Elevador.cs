using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal class Elevador
    {
        //Atributos de classe
        public int AndarAtual { get; set; }
        public int NumeroDeAndares { get; set; }
        public int Capacidade { get; set; }
        public int NumeroDePessoas { get; set; }

        //Método de inicialização, parametrizado no carregamento da aplicação
        public void Inicializar(int numeroDeAndares, int capacidade)
        {
            NumeroDeAndares = numeroDeAndares;
            Capacidade = capacidade;
            NumeroDePessoas = 0;
            AndarAtual = 0;
        }

        //Método que executa a entrada de pessoas no elevador, respeitando a capacidade de lotação
        //Retorna verdadeiro caso seja possível entrar no elevador, e falso caso já esteja lotado
        public bool Entrar()
        {
            if (NumeroDePessoas < Capacidade)
            {
                NumeroDePessoas++;  
                return true;
            }
            else
            {
                return false;   
            }
        }

        //Método que executa a saída de 1 pessoa do elevador, sendo necessário que haja ao menos 1 pessoa no elevador
        //Retorna verdadeiro caso seja possível remover 1 pessoa do elevador, e falso caso não haja ninguém no seu interior
        public bool Sair()
        {
            if (NumeroDePessoas > 0)
            {
                NumeroDePessoas--;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Método que permite o elevador subir 1 andar, respeitando o número de andares do prédio
        //Retorna verdadeiro caso seja possível subir 1 andar, e falso caso o elevador já esteja no último andar e não possa mais subir
        public bool Subir()
        {
            if (AndarAtual == NumeroDeAndares)
            {
                return false;
            }
            else
            {
                AndarAtual++;
                return true;    
            }
        }

        //Método que permite o elevador descer 1 andar, desde que já não esteja no térreo
        //Retorna verdadeiro caso seja possível descer 1 andar, e falso caso o elevador já esteja no térreo (andar 0)
        public bool Descer()
        {
            if (AndarAtual == 0)
            {
                return false;
            }
            else
            {
                AndarAtual--;
                return true;
            }
        }

    }
}
