using MauiApp1.Models;

namespace MauiApp1.Interfaces;

public interface ICuenta
{
    public Task<List<CuentaModels>> GetAll();
    public Task<CuentaModels> GetById(int id);
    public Task<int> InsertEquipo(CuentaModels A);
    public Task<int> DeleteEquipo(CuentaModels A);
    public Task<int> UpdateEquipo(CuentaModels A);

}

