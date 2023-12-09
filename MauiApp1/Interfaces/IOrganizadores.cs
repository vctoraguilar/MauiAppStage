using MauiApp1.Models;

namespace MauiApp1.Interfaces;

public interface IOrganizadores
{
    public Task<List<OrganizadoresModels>> GetAll();
    public Task<OrganizadoresModels> GetById(int id);
    public Task<int> InsertOrganizador(OrganizadoresModels A);
    public Task<int> DeleteOrganizador(OrganizadoresModels A);
    public Task<int> UpdateOrganizador(OrganizadoresModels A);

}

