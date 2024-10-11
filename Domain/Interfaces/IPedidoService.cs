using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces;
public interface IPedidoService
{
    Task CriarPedidoAsync(Pedido pedido);
    Task<Pedido> ObterPedidoPorIdAsync(int id);
}
