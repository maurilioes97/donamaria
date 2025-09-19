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
    }
}
