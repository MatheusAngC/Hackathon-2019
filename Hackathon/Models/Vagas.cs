using System;

namespace Hackathon.Models
{
    public class Vagas
    {
        public Vagas(
            Guid id,
            string imagem,
            string local,
            string distancia,
            int rate)
        {
            Id = id;
            Imagem = imagem;
            Local = local;
            Distancia = distancia;
            Rate = rate;
        }

        public Guid Id { get; set; }
        public string Imagem { get; set; }
        public string Local { get; set; }
        public string Distancia { get; set; }
        public int Rate { get; set; }
    }
}