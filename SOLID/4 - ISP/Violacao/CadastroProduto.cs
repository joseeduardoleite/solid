namespace SOLID.ISP.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void Validar()
        {
            // Validar valor
        }

        public void Salvar()
        {
            // Insert tabela Produto
        }

        public void EnviarEmail()
        {
            throw new NotImplementedException("Esse metodo não serve pra nada");
        }
    }
}