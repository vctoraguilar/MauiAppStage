using MauiApp1.Models;

namespace MauiApp1.Interfaces;

public interface IProgramarFecha
{
    public Task<List<ProgramarFechaModels>> GetAll();
    public Task<ProgramarFechaModels> GetById(int id);
    public Task<int> InsertOrganizador(ProgramarFechaModels A);
    public Task<int> DeleteOrganizador(ProgramarFechaModels A);
    public Task<int> UpdateOrganizador(ProgramarFechaModels A);

}

