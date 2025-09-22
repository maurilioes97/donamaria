using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasodeUsoDonamaria.Model
{
    public class TipoCozinha
    {
        /// <summary>
        /// Id sequencial de 0..n dos Tipos de cozinha.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Nome do tipo de cozinha
        /// Ex.: Cozinha Mexicana, Brasileira, Italiana etc.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Descrição sobre o tipo de cozinha. Ex.: Cozinha famosa por suas pizzas.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Seleciona todos os tipos de cozinha existentes.
        /// </summary>
        /// <returns>Lista dos tipos de cozinha cadastrados no sistema</returns>
        public static List<TipoCozinha> SelecionarTodos()
        {
            return null;
        }

        /// <summary>
        /// Lista de Receitas que estão contidas no tipo de cozinha.
        /// </summary>
        public List<Receita> receitas {  get; set; }
    }
}
