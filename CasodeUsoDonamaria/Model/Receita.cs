using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasodeUsoDonamaria.Model
{
    public class Receita
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? ModoPreparo { get; set; }
        public string? Ingredientes { get; set; }
        public Image? Imagem { get; set; } // agora é Image, não string
    }
}
