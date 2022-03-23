using ProjetoElevador.Controller;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instância do controlador
            ElevadorController elevadorController = new ElevadorController();

            //Início da aplicação e comunicação entre Model, View e Controller
            elevadorController.IniciarElevador();
        }
    }
}
