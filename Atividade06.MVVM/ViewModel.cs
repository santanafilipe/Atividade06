using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade06.MVVM
{
    public class ViewModel
    {
        public DTO FuncaoTeste()
        {
            Model m = new Model();

            return new DTO { Descricao = m.Descricao, DataHora = m.DataHora };
        }
    }
}
