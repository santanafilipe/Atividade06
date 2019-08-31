using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade06.MVVM
{
    public class Model
    {
        public Model()
        {
            this.Descricao = "Model - Ação executada.";
            this.DataHora = DateTime.Now;
        }

        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
    }
}
