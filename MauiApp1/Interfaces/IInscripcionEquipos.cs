using MauiApp1.Models;

namespace MauiApp1.Interfaces;

public interface IInscripcionEquipos
{
    public Task<List<InscripcionEquiposModels>> GetAll();
    public Task<InscripcionEquiposModels> GetById(int id);
    public Task<int> InsertOrganizador(InscripcionEquiposModels A);
    public Task<int> DeleteOrganizador(InscripcionEquiposModels A);
    public Task<int> UpdateOrganizador(InscripcionEquiposModels A);

}

