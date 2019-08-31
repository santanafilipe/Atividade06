using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade06.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio...");
            Controller c = new Controller();
            Console.WriteLine("Chamada da função.");
            Model m = c.FuncaoTeste();
            Console.WriteLine("Retorno do resultado");
            Console.WriteLine(string.Format("Msg de Retorno: {0} - {1}", m.Descricao, m.DataHora));
            Console.ReadKey();
        }
    }
}
