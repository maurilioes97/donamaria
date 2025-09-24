using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasodeUsoDonamaria.Model
{
    public class Receita
    {
        /// <summary>
        /// Id sequencial 0..n receitas.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Modo de preparo da receita, com detalhes, etc...
        /// </summary>
        public string ModoPreparo { get; set; }

        /// <summary>
        /// Tipo de cozinha da receita.
        /// </summary>
        public TipoCozinha TipoCozinha { get; set; }

        /// <summary>
        /// Lista de ingredientes associados à receita.
        /// </summary>
        public List<Ingrediente> Ingredientes { get; set; }

        /// <summary>
        /// Lista de ingredientes da receita.
        /// </summary>
        public List<IngredienteReceita> IngredienteReceita { get; set; }
    }
}
