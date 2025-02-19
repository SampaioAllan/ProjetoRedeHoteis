﻿using ProjetoRedeHoteis.Lib.MyExceptions;

namespace ProjetoRedeHoteis.Lib.Models;
public class Hotel : ModelBase
{
    public string Nome { get; private set; }
    public string Endereco { get; private set; }
    public string Cep { get; private set; }
    public string Descricao { get; private set; }
    public string Telefone { get; private set; }
    public string Email { get; private set; }
    public DateTime HorarioCheckIn { get; private set; }
    public DateTime HorarioCheckOut { get; private set; }
    public virtual List<Quarto> Quartos { get; set; }
    public virtual List<ServicoHotel> ServicosHoteis { get; set; }
    protected Hotel()
    {
        
    }
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
        ValidarTelefone(telefone);
        Telefone = telefone;
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
    public void ValidarTelefone(string telefone)
    {
        if (telefone.Length == 14)
        {
            return;
        }
        throw new ValidacaoDadosException("Número de telefone deve ter 14 caracteres!");
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
