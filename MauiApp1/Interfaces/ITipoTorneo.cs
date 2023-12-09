using MauiApp1.Models;

namespace MauiApp1.Interfaces;

public interface ITipoTorneo
{
    public Task<List<TipoTorneoModels>> GetAll();
    public Task<TipoTorneoModels> GetById(int id);
    public Task<int> InsertTorneo(TipoTorneoModels A);
    public Task<int> DeleteTorneo(TipoTorneoModels A);
    public Task<int> UpdateTorneo(TipoTorneoModels A);

}

