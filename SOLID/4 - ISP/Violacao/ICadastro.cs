namespace SOLID.ISP.Violacao
{
    public interface ICadastro
    {
        void Validar();
        void Salvar();
        void EnviarEmail();
    }
}