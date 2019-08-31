using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade06.MVVM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio...");
            ViewModel vm = new ViewModel();
            Console.WriteLine("Chamada da função.");
            DTO dto = vm.FuncaoTeste();
            Console.WriteLine("Retorno do resultado");
            Console.WriteLine(string.Format("Msg de Retorno: {0} - {1}", dto.Descricao, dto.DataHora));
            Console.ReadKey();
        }
    }
}
