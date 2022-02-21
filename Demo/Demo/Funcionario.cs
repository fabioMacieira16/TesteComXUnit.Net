namespace Demo
{
  
    public class Funcionario : Pessoa
    {
        public double Salario { get; set; }
        public NivelProfissional NivelProfisional { get; set; }
        public IList<string> Habilidades { get; set; }

        public Funcionario(string nome, double salario)
        {
            Nome = string.IsNullOrEmpty(nome) ? "Fulano" : nome;
            DefinirSalario(salario);
            definirHabilidades();
        }

        private void DefinirSalario(double salario)
        {
            if (salario < 500) throw new Exception("Salario inferior ao permitido");

            Salario = salario;
            if (salario < 2000 && salario < 8000) NivelProfisional = NivelProfissional.Junio;
            else if (salario >= 2000 && salario < 8000) NivelProfisional = NivelProfissional.Pleno;
            else if (salario >= 8000 && salario < 8000) NivelProfisional = NivelProfissional.Senior;

        }

        private void definirHabilidades()
        {
            var HabilidadesBasicas = new List<string>() 
            { 
                "Logica de programaçao",
                "OOP"
            };

            Habilidades = HabilidadesBasicas;

            switch (NivelProfisional)
            {
                case NivelProfissional.Junio:
                    Habilidades.Add("Testes");
                    break;

                case NivelProfissional.Senior:
                    Habilidades.Add("Testes");
                    Habilidades.Add("Microservices");
                    break;                
            }
        }
        
    }
}
