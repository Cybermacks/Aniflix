using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbLib.Objects.General;
using System.Collections.Generic;
using Microsoft.VisualBasic.Devices;

namespace Aniflix.Models
{
    public class Series
    {
        public string? Titulo { get; set; }
        public string? Audio { get; set; }
        public string? Sinopse { get; set; }
        public string? TituloOriginal { get; set; }
        public string? DataLancamento { get; set; }
        public string? TituloAlternativo { get; set; }
        public string? PaisOrigem { get; set; }
        public string? IdiomaOriginal { get; set; }
        public string? Serie { get; set; }
        public string? Autores { get; set; }
        public string? Criadores { get; set; }
        public string? ObraOriginal { get; set; }
        public string? Genero { get; set; }
        public string? Tags { get; set; }
        public string? Diretor { get; set; }
        public string? MCU { get; set; }
        public string? Estrelas { get; set; }
        public string? Estudio { get; set; }
    }
}
