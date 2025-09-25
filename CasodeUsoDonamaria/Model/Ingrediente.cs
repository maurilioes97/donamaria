using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasodeUsoDonamaria.Model
{
    public class Ingrediente
    {
        /// <summary>
        /// Id sequencial 0..n dos Ingredientes do sistema.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome dos ingredientes do sistema. Ex.: sal, açúcar.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Descrição do ingrediente.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Receitas que contêm o ingrediente.
        /// </summary>
        public List<Receita> receitas { get; set; }

        /// <summary>
        /// Lista dos ingredientes.
        /// </summary>
        public static List<Ingrediente> Ingredientes;

        /// <summary>
        /// Metodo da classe ingrediente para selecionar todos da lista.
        /// </summary>
        /// <returns></returns>
        public static List<Ingrediente> SelecionarTodos()
        {
            return (from p in Ingrediente.Ingredientes select p).ToList();
        }

        /// <summary>
        /// Método da classe ingrediente para selecionar apenas pelo Id.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static Ingrediente? SelecionarPeloId(int Id)
        {
            return (from p in Ingrediente.Ingredientes where p.Id == Id select p).FirstOrDefault();
        }

        /// <summary>
        /// Este método inclui um objeto ingrediente na memória.
        /// </summary>
        /// <returns></returns>
        public int Incluir()
        {
            int NovoId = 1;
            var MaiorNumero = (from p in Ingredientes orderby p.Id descending select p.Id).FirstOrDefault();
            if (MaiorNumero!=null)
            {
                NovoId = MaiorNumero + 1;
            }
            this.Id = NovoId;


            Ingredientes.Add(this);
            return this.Id;
        }

        /// <summary>
        /// Método para excluir um objeto ingrediente pelo id.
        /// </summary>
        /// <param name="Id"></param>
        public static void Excluir(int Id)
        {
            Ingrediente? oIngrediente = Ingrediente.SelecionarPeloId(Id);
            if(oIngrediente!=null)
            {
                Ingrediente.Ingredientes.Remove(oIngrediente);
            }
        }
    }
}
