using ProjetoElevador.Model;
using ProjetoElevador.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Controller
{
    internal class ElevadorController
    {
        //Definição de constantes
        private const int NUMERO_ANDARES = 10;
        private const int CAPACIDADE = 4;

        //Instância da model e view
        Elevador elevador = new Elevador();
        ElevadorView elevadorView = new ElevadorView();

        //Método que inicializa a model e interage com a view
        public void IniciarElevador()
        {
            //Elevador inicializado com o número de andares acessíveis e sua capacidade máxima
            elevador.Inicializar(NUMERO_ANDARES, CAPACIDADE);

            //Comunicação entre Model e View
            elevadorView.InterfaceComUsuario(elevador);
        }
        

    }
}
