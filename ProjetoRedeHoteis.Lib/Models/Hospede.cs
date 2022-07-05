using ProjetoRedeHoteis.Lib.MyExceptions;

namespace ProjetoRedeHoteis.Lib.Models
{
    public class Hospede : ModelBase
    {
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; private set; }
        public DateOnly DataNascimento { get; private set; }
        public virtual List<EstadiaHospede> EstadiasHospedes { get; set; }
        public virtual List<Estadia> Estadias { get; set; }
        protected Hospede()
        {
            
        }
        public Hospede(int id, DateTime dataCadastro, DateTime dataUltimaAtualizacao, string nome, string telefone, string cpf,
                       string email, DateOnly dataNascimento) : base(id, dataCadastro, dataUltimaAtualizacao)
        {
            SetNome(nome);
            SetTelefone(telefone);
            SetCpf(cpf);
            SetEmail(email);
            SetDataNascimento(dataNascimento);
        }
        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetTelefone()
        {
            return Telefone;
        }

        public void SetTelefone(string telefone)
        {
            ValidarTelefone(telefone);
            Telefone = telefone;
        }
        public string GetCpf()
        {
            return Cpf;
        }

        public void SetCpf(string cpf)
        {
            ValidarCpf(cpf);
            Cpf = cpf;
        }
        public string GetEmail()
        {
            return Email;
        }

        public void SetEmail(string email)
        {
            ValidarEmail(email);
            Email = email;
        }
        public DateOnly GetDataNascimento()
        {
            return DataNascimento;
        }

        public void SetDataNascimento(DateOnly dataNascimento)
        {
            DataNascimento = dataNascimento;
        }
        public void ValidarTelefone(string telefone)
        {
            if (telefone.Length == 14)
            {
                return;
            }
            throw new ValidacaoDadosException("Número de telefone deve ter 14 caracteres!");
        }
        public void ValidarCpf(string cpf)
        {
            if (cpf.All(char.IsNumber))
            {
                return;
            }
            throw new ValidacaoDadosException("CPF deve conter apenas números!");
        }
        public void ValidarEmail(string email)
        {
            if (email.Contains("@"))
            {
                return;
            }
            throw new ValidacaoDadosException("Email deve conter @!");
        }
    }
}