﻿using LojaVirtual.dominio;
using LojaVirtual.service;
using NUnit.Framework;

namespace NUnitTestLivroTDDTesteDesignNoMundoReal.TesteLojaVirtual
{
    [TestFixture]
    public class TestandoBuscaProdutoMaiorEMenor
    {
        [Test]
        public void OrdemDecrescente()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Geladeira", 450.0));
            carrinho.Adiciona(new Produto("Liquidificador", 250.0));
            carrinho.Adiciona(new Produto("Jogo de pratos", 70.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Jogo de pratos", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }

        [Test]
        public void ApenasUmProduto()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Geladeira", 450.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Geladeira", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }
    }
}