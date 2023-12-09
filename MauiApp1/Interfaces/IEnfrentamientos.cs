using MauiApp1.Models;

namespace MauiApp1.Interfaces;

public interface IEnfrentamientos
{
    public Task<List<EnfrentamientosModels>> GetAll();
    public Task<EnfrentamientosModels> GetById(int id);
    public Task<int> InsertEquipo(EnfrentamientosModels A);
    public Task<int> DeleteEquipo(EnfrentamientosModels A);
    public Task<int> UpdateEquipo(EnfrentamientosModels A);

}

