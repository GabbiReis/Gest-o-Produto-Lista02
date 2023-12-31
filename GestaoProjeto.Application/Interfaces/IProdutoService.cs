﻿using GestaoProduto.Domain.Entities;
using GestaoProjeto.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProjeto.Application.Interfaces
{
    public interface IProdutoService
    {
        IEnumerable<ProdutoViewModel> ObterTodos();
        Task<ProdutoViewModel> ObterPorId(int id);
        Task<IEnumerable<ProdutoViewModel>> ObterPorNome(string produtoNome);
        void Adicionar(NovoProdutoViewModel novoProdutoViewModel);
        Task Atualizar(NovoProdutoViewModel novoProdutoViewModel);
        Task Deletar(int id);
        Task Ativar (int id);
        Task Desativar(int id);
        Task AlterarPreco(int id, decimal valor);
        Task AtualizarEstoque(int id, int quantidade);
    }
}