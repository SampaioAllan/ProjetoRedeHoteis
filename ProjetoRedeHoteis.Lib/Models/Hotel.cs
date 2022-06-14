namespace ProjetoRedeHoteis.Lib.Models;
public class Hotel : ModelBase
{
    private string Nome { get; set; }
    private string Endereco { get; set; }
    private string Cep { get; set; }
    private string Descricao { get; set; }
    private string Telefone { get; set; }
    private string Email { get; set; }
    private DateTime HorarioCheckIn { get; set; }
    private DateTime HorarioCheckOut { get; set; }
    public Hotel(int id, DateTime dataCadastro, DateTime dataUltimaAtualizacao, string nome, string endereco, string cep,
                 string descricao, string telefone, string email, DateTime horarioCheckIn, DateTime horarioCheckOut) : base(
                 id, dataCadastro, dataUltimaAtualizacao)
    {
        SetNome(nome);
        SetEndereco(endereco);
        SetCep(cep);
        SetDescricao(descricao);
        SetTelefone(telefone);
        SetEmail(email);
        SetHorarioCheckIn(horarioCheckIn);
        SetHorarioCheckOut(horarioCheckOut);
    }
    public string GetNome()
    {
        return Nome;
    }
    public void SetNome(string nome)
    {
        Nome = nome;
    }
    public string GetEndereco()
    {
        return Endereco;
    }
    public void SetEndereco(string endereco)
    {
        Endereco = endereco;
    }
    public string GetCep()
    {
        return Cep;
    }
    public void SetCep(string cep)
    {
        Cep = cep;
    }
    public string GetDescricao()
    {
        return Descricao;
    }
    public void SetDescricao(string descricao)
    {
        Descricao = descricao;
    }
    public string GetTelefone()
    {
        return Telefone;
    }
    public void SetTelefone(string telefone)
    {
        Telefone = telefone;
    }
    public string GetEmail()
    {
        return Email;
    }
    public void SetEmail(string email)
    {
        Email = email;
    }
    public DateTime GetHorarioCheckIn()
    {
        return HorarioCheckIn;
    }
    public void SetHorarioCheckIn(DateTime horarioCheckIn)
    {
        HorarioCheckIn = horarioCheckIn;
    }
    public DateTime GetHorarioCheckOut()
    {
        return HorarioCheckOut;
    }
    public void SetHorarioCheckOut(DateTime horarioCheckOut)
    {
        HorarioCheckOut = horarioCheckOut;
    }
}
