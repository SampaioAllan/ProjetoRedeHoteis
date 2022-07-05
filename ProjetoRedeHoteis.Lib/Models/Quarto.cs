namespace ProjetoRedeHoteis.Lib.Models
{
    public class Quarto : ModelBase
    {
        public int Numero { get; private set; }
        public int Andar { get; private set; }
        public int IdCategoria { get; private set; }
        public int IdHotel { get; private set; }
        public virtual CategoriaQuarto Categoria { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual List<Estadia> Estadias { get; set; }
        protected Quarto()
        {
            
        }
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