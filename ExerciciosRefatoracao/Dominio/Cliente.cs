using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.Dominio
{
    public class Cliente
    {
        public RazaoSocial RazaoSocial { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public CNPJ CNPJ { get; private set; }

        public Endereco EnderecoEntrega { get; private set; }
        public Endereco EnderecoCobranca { get; private set; }
        public Endereco EnderecoFaturamento { get; private set; }

        public string GetTextoEndereco(Endereco endereco)
        {
            return $"Endereço: {endereco.Logradouro} {endereco.Numero} {endereco.Complemento} - {endereco.Bairro} - CEP {endereco.CEP} - {endereco.Municipio} - {endereco.UF}";
        }

        public string GetTextoEnderecoCobranca()
        {
            return GetTextoEndereco(EnderecoCobranca);
        }

        public string GetTextoEnderecoEntrega()
        {
            return GetTextoEndereco(EnderecoEntrega);
        }

        public string GetTextoEnderecoFaturamento()
        {
            return GetTextoEndereco(EnderecoFaturamento);
        }

        public void SetEnderecoFaturamento(string logradouro, string numero, string complemento, string bairro, string cep, string municipio, string uf)
        {
            EnderecoFaturamento = new Endereco(logradouro, numero, complemento, bairro, cep, municipio, uf);
        }

        public void SetEnderecoEntrega(string logradouro, string numero, string complemento, string bairro, string cep, string municipio, string uf)
        {
            EnderecoEntrega = new Endereco(logradouro, numero, complemento, bairro, cep, municipio, uf);
        }

        public void SetEnderecoCobranca(string logradouro, string numero, string complemento, string bairro, string cep, string municipio, string uf)
        {
            EnderecoCobranca = new Endereco(logradouro, numero, complemento, bairro, cep, municipio, uf);
        }

        public override string ToString()
        {
            return "===Dados do Cliente===\n" +
                   $"CPF: {CPF}\n" +
                   $"Nome: {Nome}\n" +
                   $"{GetTextoEnderecoCobranca()}\n" +
                   $"{GetTextoEnderecoEntrega()}\n" +
                   $"{GetTextoEnderecoFaturamento()}";
        }
    }

    public class Endereco
    {
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public string Municipio { get; private set; }
        public string UF { get; private set; }

        public Endereco(string logradouro, string numero, string complemento, string bairro, string cep, string municipio, string uf)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            CEP = cep;
            Municipio = municipio;
            UF = uf;
        }
    }

    public class CNPJ
    {
        public string Codigo { get; private set; }

        public CNPJ(string codigo)
        {
            Codigo = codigo;
        }
    }

    public class RazaoSocial
    {
        public string Nome { get; private set; }

        public RazaoSocial(string nome)
        {
            Nome = nome;
        }
    }
}
