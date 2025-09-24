using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasodeUsoDonamaria.Model
{
    public class IngredienteReceita
    {
        /// <summary>
        /// Id sequencial de 0..n dos ingredientes da receita.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Quantidade dos ingredientes da receita.
        /// </summary>
        public float Qtd { get; set; }
    }
}
