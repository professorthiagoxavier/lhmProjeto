using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LHMDiscosAPI.Models
{
    public class DiscoRepositorio : IDiscoRepositorio
    {
        private List<Disco> discos = new List<Disco>();
        private int _nextId = 1;

        public DiscoRepositorio()
        {
            Add(new Disco { Nome = "Beleza Rara", Cantor = "Banda Eva", Genero = "Axé", Preco = 50.00M, QuantidadeEstoque = 20 });
            Add(new Disco { Nome = "Na Ponta da Lingua", Cantor = "Chiclete Com Banana", Genero = "Axé", Preco = 80.00M, QuantidadeEstoque = 15 });
            Add(new Disco { Nome = "Todo Mundo Gosta", Cantor = "Parangolé", Genero = "Axé", Preco = 75.00M, QuantidadeEstoque = 10 });

            Add(new Disco { Nome = "Live", Cantor = "Buffalo Springfield", Genero = "Country", Preco = 25.00M, QuantidadeEstoque = 10 });
            Add(new Disco { Nome = "The 20 Greatest Hits", Cantor = "C. Clearwater Revival", Genero = "Country", Preco = 100.00M, QuantidadeEstoque = 25 });
            Add(new Disco { Nome = "Turn! Turn! Turn!", Cantor = "The Birds", Genero = "Country", Preco = 30.00M, QuantidadeEstoque = 35 });

            Add(new Disco { Nome = "True", Cantor = "Avicii", Genero = "Eletrônica", Preco = 150.00M, QuantidadeEstoque = 5 });
            Add(new Disco { Nome = "Enter The Spektrem", Cantor = "Spektrem", Genero = "Eletrônica", Preco = 100.00M, QuantidadeEstoque = 10 });
            Add(new Disco { Nome = "Moving On", Cantor = "Marshmello", Genero = "Eletrônica", Preco = 230.00M, QuantidadeEstoque = 5 });

            Add(new Disco { Nome = "Especial de 10 Anos", Cantor = "Aviões do Forró", Genero = "Forró", Preco = 10.00M, QuantidadeEstoque = 20 });
            Add(new Disco { Nome = "Primeiro Amor", Cantor = "Bonde do Forró", Genero = "Forró", Preco = 30.00M, QuantidadeEstoque = 35 });
            Add(new Disco { Nome = "Ao Vivo", Cantor = "Calcinha Preta", Genero = "Forró", Preco = 45.00M, QuantidadeEstoque = 25 });

            Add(new Disco { Nome = "Medicina", Cantor = "Anitta", Genero = "Funk", Preco = 75.00M, QuantidadeEstoque = 15 });
            Add(new Disco { Nome = "Pa Pum", Cantor = "MC Kevinho", Genero = "Funk", Preco = 40.00M, QuantidadeEstoque = 10 });
            Add(new Disco { Nome = "Vagabundo Romântico", Cantor = "MC Livinho", Genero = "Funk", Preco = 50.00M, QuantidadeEstoque = 5 });

            Add(new Disco { Nome = "Feito Pra Durar", Cantor = "Péricles", Genero = "Pagode", Preco = 180.00M, QuantidadeEstoque = 15 });
            Add(new Disco { Nome = "Ousadia e Alegria", Cantor = "Thiaguinho", Genero = "Pagode", Preco = 250.00M, QuantidadeEstoque = 45 });
            Add(new Disco { Nome = "Uma Prova de Amor", Cantor = "Zeca Pagodinho", Genero = "Pagode", Preco = 130.00M, QuantidadeEstoque = 35 });

            Add(new Disco { Nome = "Legend", Cantor = "Bob Marley", Genero = "Reggae", Preco = 500.00M, QuantidadeEstoque = 5 });
            Add(new Disco { Nome = "Ultimate Collection", Cantor = "Jimmy Cliff", Genero = "Reggae", Preco = 80.00M, QuantidadeEstoque = 5 });
            Add(new Disco { Nome = "War Ina Babylon", Cantor = "Max Romeo", Genero = "Reggae", Preco = 95.00M, QuantidadeEstoque = 10 });

            Add(new Disco { Nome = "Highway To Hell", Cantor = "AC/DC", Genero = "Rock", Preco = 450.00M, QuantidadeEstoque = 5 });
            Add(new Disco { Nome = "What Do You Got?", Cantor = "Bon Jovi", Genero = "Rock", Preco = 550.00M, QuantidadeEstoque = 5 });
            Add(new Disco { Nome = "We Are Not Your Kind", Cantor = "Slipknot", Genero = "Rock", Preco = 600.00M, QuantidadeEstoque = 5 });

            Add(new Disco { Nome = "Pé na Areia", Cantor = "Diogo Nogueira", Genero = "Samba", Preco = 100.00M, QuantidadeEstoque = 15 });
            Add(new Disco { Nome = "Não Deixe o Samba Morrer", Cantor = "Alcione", Genero = "Samba", Preco = 210.00M, QuantidadeEstoque = 25 });
            Add(new Disco { Nome = "Sambista Perfeito", Cantor = "Arlindo Cruz", Genero = "Samba", Preco = 175.00M, QuantidadeEstoque = 35 });

            Add(new Disco { Nome = "Nossas Histórias", Cantor = "Henrique e Juliano", Genero = "Sertanejo", Preco = 5.00M, QuantidadeEstoque = 100 });
            Add(new Disco { Nome = "Terra sem CEP", Cantor = "Jorge e Mateus", Genero = "Sertanejo", Preco = 2.00M, QuantidadeEstoque = 200 });
            Add(new Disco { Nome = "Um Novo Sonho", Cantor = "Zé Neto e Cristiano", Genero = "Sertanejo", Preco = 1.00M, QuantidadeEstoque = 50 });
        }

        public Disco Add(Disco item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            discos.Add(item);
            return item;
        }

        public Disco Get(int id)
        {
            return discos.Find(p => p.Id == id);
        }

        public IEnumerable<Disco> GetAll()
        {
            return discos;
        }

        public void Remove(int id)
        {
            discos.RemoveAll(p => p.Id == id);
        }

        public bool Update(Disco item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = discos.FindIndex(p => p.Id == item.Id);

            if (index == -1)
            {
                return false;
            }
            discos.RemoveAt(index);
            discos.Add(item);
            return true;
        }
    }
}