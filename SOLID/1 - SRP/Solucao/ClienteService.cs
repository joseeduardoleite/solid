namespace SOLID.SRP.Solucao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente) 
        {
            // _validacao

            var repository = new ClienteRepository();
            repository.AdicionarCliente(cliente);

            return "Cliente cadastrado com sucesso";
        }
    }
}