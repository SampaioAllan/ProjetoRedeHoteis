namespace ProjetoRedeHoteis.Lib.Models
{
    public class Quarto : ModelBase
    {
        private int Numero { get; set; }
        private int Andar { get; set; }
        private int IdCategoria { get; set; }
        private int IdHotel { get; set; }
        public Quarto(int id, DateTime dataCadastro, DateTime dataUltimaAtualizacao, int numero, int andar, int idCategoria,
                      int idHotel) : base(id, dataCadastro, dataUltimaAtualizacao)
        {
            SetNumero(numero);
            SetAndar(andar);
            SetIdCategoria(idCategoria);
            SetIdHotel(idHotel);
        }
        public int GetNumero()
        {
            return Numero;
        }
        public void SetNumero(int numero)
        {
            Numero = numero;
        }
        public int GetAndar()
        {
            return Andar;
        }
        public void SetAndar(int andar)
        {
            Andar = andar;
        }
        public int GetIdCategoria()
        {
            return IdCategoria;
        }
        public void SetIdCategoria(int idCategoria)
        {
            IdCategoria = idCategoria;
        }
        public int GetIdHotel()
        {
            return IdHotel;
        }
        public void SetIdHotel(int idHotel)
        {
            IdHotel = idHotel;
        }
    }
}