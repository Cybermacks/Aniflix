namespace Aniflix.Services
{
    public class SeriesServices(string titulo, string? audio, string? sinopse = null, string? tituloOriginal = null,
               string? dataLancamento = null, string? tituloAlternativo = null, string? paisOrigem, string? idiomaOriginal, string? serie,
               string? autores, string? criadores, string? obraOriginal,
               string? genero = null, string? tags = null, string? diretor = null, string? mcu = null, string? estrelas = null, string? estudio = null)
    {
        public string Titulo { get; private set; } = titulo;
        public string? Audio { get; private set; } = audio;
        public string? Sinopse { get; private set; } = sinopse;
        public string? TituloOriginal { get; private set; } = tituloOriginal;
        public string? DataLancamento { get; private set; } = dataLancamento;
        public string? TituloAlternativo { get; private set; } = tituloAlternativo;
        public string? PaisOrigem { get; private set; } = paisOrigem;
        public string? IdiomaOriginal { get; private set; } = idiomaOriginal;
        public string? Serie { get; private set; } = serie;
        public string? Autores { get; private set; } = autores;
        public string? Criadores { get; private set; } = criadores;
        public string? ObraOriginal { get; private set; } = obraOriginal;
        public string? Genero { get; private set; } = genero;
        public string? Tags { get; private set; } = tags;
        public string? Diretor { get; private set; } = diretor;
        public string? MCU { get; private set; } = mcu;
        public string? Estrelas { get; private set; } = estrelas;
        public string? Estudio { get; private set; } = estudio;

        public string GetFormattedText()
        {
            string formattedText =
    $@"**{Titulo}** - **{Audio}**

**HD** - __720p__
**SD** - __480p__
__[Os vídeos estão em ordem crescente, ou seja, de cima para baixo, tal como na descrição das resoluções.]__

**Sinopse:** __{Sinopse}__

**Título Original:** __{TituloOriginal}__
**Título Alternativo:** {TituloAlternativo}
**Data de lançamento:** __{DataLancamento}__
**Filme:** #{Titulo.Replace(" ", string.Empty)}
**Franquia:** {Franquia}
**Gênero:** {Genero}
**Tags:** {Tags}
**Diretor:** {Diretor}
**FaseMCU:** {MCU}
**Estrelas:** {Estrelas}
**Estúdio:** {Estudio?.TrimEnd()}
";
            return formattedText;
        }
    }
}