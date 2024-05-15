﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe07
{
    public class Musica
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Gravadora { get; set; }

        public Musica(string nome, string autor, string gravadora)
        {
            Nome = nome;
            Autor = autor;
            Gravadora = gravadora;
        }
    }

    public class Playlist
    {
        private List<Musica> listaDeMusicas;
        private string donoDaPlaylist;
        private Random random;

        public Playlist(string dono)
        {
            listaDeMusicas = new List<Musica>();
            donoDaPlaylist = dono;
            random = new Random();
        }

        public void AdicionarMusica(Musica musica)
        {
            listaDeMusicas.Add(musica);
        }

        public void TocarMusicaAleatoria()
        {
            if (listaDeMusicas.Count == 0)
            {
                Console.WriteLine("Playlist vazia. Adicione músicas primeiro.");
            }
            else
            {
                int indiceAleatorio = random.Next(listaDeMusicas.Count);
                Musica musicaSelecionada = listaDeMusicas[indiceAleatorio];
                Console.WriteLine($"Tocando música: {musicaSelecionada.Nome} - {musicaSelecionada.Autor}");
            }
        }
    }
}
