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
        public int id { get; set; }
        
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
            return (from p in TipoCozinha.TipoCozinhas select p).ToList();
        }

        public int Incluir()
        {
            if (TipoCozinhas.Count > 0)
            {
                this.id = TipoCozinhas.Last().id + 1;
            }
            else
            {
                this.id = 1;

            }
            TipoCozinhas.Add(this);
            return this.id;
        }

        public static void Excluir(int id)
        {
            // Encontra o item na lista que corresponde ao ID
            var itemParaExcluir = TipoCozinhas.FirstOrDefault(c => c.id == id);

            // Se o item for encontrado, o remove da lista
            if (itemParaExcluir != null)
            {
                TipoCozinhas.Remove(itemParaExcluir);
            }
        }

        public static void Atualizar(TipoCozinha cozinhaAtualizada)
        {
            // Encontra o item na lista que corresponde ao ID do objeto atualizado
            var itemOriginal = TipoCozinhas.FirstOrDefault(c => c.id == cozinhaAtualizada.id);

            // Se o item for encontrado, atualiza as suas propriedades
            if (itemOriginal != null)
            {
                itemOriginal.Nome = cozinhaAtualizada.Nome;
                itemOriginal.Descricao = cozinhaAtualizada.Descricao;
            }
        }

        public static List<TipoCozinha> TipoCozinhas;
        /// <summary>
        /// Lista de Receitas que estão contidas no tipo de cozinha.
        /// </summary>
        public List<Receita> receitas {  get; set; }
    }
}
