using SOLID.ISP.Solucao.Interfaces;

namespace SOLID.ISP.Solucao
{
     public class CadastroCliente : ICadastroCliente
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