namespace API.Consultas.Domain.Services
{
    public interface IConsultasService
    {
        Task<int> ObterConsultasPorClienteId(int clienteId);
    }
}
