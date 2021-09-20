using ApiCatalago.InputModel;
using ApiCatalago.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalago.Services
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(int pagina, int quantidade);
        Task Atualizar (Guid id, JogoInputModel Jogo);
        Task Atualizar (Guid id, double preco);
        Task Remover(Guid id);
    }
}
