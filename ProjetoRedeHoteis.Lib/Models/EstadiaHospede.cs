namespace ProjetoRedeHoteis.Lib.Models
{
    public class EstadiaHospede : ModelBase
    {
        public int IdEstadia { get; private set; }
        public int IdHospede { get; private set; }
        public virtual Estadia Estadia { get; set; }
        public virtual Hospede Hospede { get; set; }
        protected EstadiaHospede()
        {
            
        }
        public EstadiaHospede(int id, DateTime dataCadastro, DateTime dataUltimaAtualizacao, int idEstadia, int idHospede) : base
                             (id, dataCadastro, dataUltimaAtualizacao)
        {
            SetIdEstadia(idEstadia);
            SetIdHospede(idHospede);
        }
        public int GetIdEstadia()
        {
            return IdEstadia;
        }
        public void SetIdEstadia(int idEstadia)
        {
            IdEstadia = idEstadia;
        }
        public int GetIdHospede()
        {
            return IdHospede;
        }
        public void SetIdHospede(int idHospede)
        {
            IdHospede = idHospede;
        }
    }
}