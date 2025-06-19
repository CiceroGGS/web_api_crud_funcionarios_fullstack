using WebApiFuncionario.Models;

namespace WebApiFuncionario.Service.FuncionarioService
{
    public interface IFuncionarioInterface
    {
        Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios();
        Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id);
        Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionarios(FuncionarioModel novoFuncionario);
        Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editadoFuncionario);
        Task<ServiceResponse<FuncionarioModel>> DeleteFuncionarioById(int id);
        Task<ServiceResponse<FuncionarioModel>> InativaFuncionario(int id);
    }
}