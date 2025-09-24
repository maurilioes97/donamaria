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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            TipoCozinha.TipoCozinhas = new List<TipoCozinha>();

            Application.Run(new FormMenu());

            Ingrediente.Ingredientes = new List<Ingrediente>();
            
            for (int i = 1; i < 11; i++)
            {
                Ingrediente Ingrediente = new Ingrediente();
                Ingrediente.Id = i;
                Ingrediente.Nome = $"Ingrediente {i}";
                Ingrediente.Descricao = $"Descri��o {i}";
                Ingrediente.Ingredientes.Add(Ingrediente);
            }

            Application.Run(new FormCadastrarIngrediente());
        }
    }
}