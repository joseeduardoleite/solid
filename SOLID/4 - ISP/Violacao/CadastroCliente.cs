namespace SOLID.ISP.Violacao
{
    public class CadastroCliente : ICadastro
    {
        public void Validar()
        {
            // Validar CPF, Email
        }

        public void Salvar()
        {
            // Insert na tabela Cliente
        }

        public void EnviarEmail()
        {
            // Enviar e-mail para o cliente
        }
    }
}