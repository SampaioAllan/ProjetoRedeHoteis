namespace ProjetoRedeHoteis.Lib.Models
{
    public class Hospede : ModelBase
    {
        private string Nome { get; set; }
        private string Telefone { get; set; }
        private string Cpf { get; set; }
        private string Email { get; set; }
        private DateOnly DataNascimento { get; set; }
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
            Telefone = telefone;
        }
        public string GetCpf()
        {
            return Cpf;
        }

        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }
        public string GetEmail()
        {
            return Email;
        }

        public void SetEmail(string email)
        {
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
    }
}