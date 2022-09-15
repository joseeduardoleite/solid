namespace SOLID.SRP.Violacao
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }

        public string AdicionarCliente(Cliente cliente)
        {
            if (Nome == null)
                return "Nome deve ser preenchido";

            if (Email == null || !Email.Contains("@"))
                return "Cliente com e-mail inválido";

            // Faz conexão com banco
            // Salva no banco

            return "Cliente cadastrado com sucesso!";
        }

        public string EditarCliente(int id)
        {

            // Valida no banco se existe um cliente com este id
            // Faz conexão com banco
            // Edita
            // Salva no banco as alterações

            return "Cliente editado com sucesso!";
        }

        public string DeletarCliente(int id)
        {

            // Valida no banco se existe um cliente com este id
            // Faz conexão com banco
            // Remove o cliente
            // Salva no banco as alterações
            
            return "Cliente removido com sucesso!";
        }
    }
}