using CasodeUsoDonamaria.Model;

namespace CasodeUsoDonamaria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Para personalizar a configuração da aplicação, como a configuração de DPI alto ou fonte padrão,
            // veja https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Mova a inicialização dos dados para cá, antes de iniciar o formulário.
            TipoCozinha.TipoCozinhas = new List<TipoCozinha>();
            Ingrediente.Ingredientes = new List<Ingrediente>();

            for (int i = 1; i < 11; i++)
            {
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.Id = i;
                ingrediente.Nome = $"Ingrediente {i}";
                ingrediente.Descricao = $"Descrição {i}";
                Ingrediente.Ingredientes.Add(ingrediente);
            }

            // A chamada para Application.Run() deve ser a última instrução a ser executada.
            Application.Run(new FormPrincipal());
        }
    }
}