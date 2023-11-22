using System;

namespace ExerciciosRefatoracao.Dominio.Chat
{
    public class Cliente
    {
        public string RazaoSocial { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public Endereco EnderecoEntrega { get; private set; }
        public Endereco EnderecoCobranca { get; private set; }
        public Endereco EnderecoFaturamento { get; private set; }

        public Cliente(string cpf, string nome)
        {
            CPF = cpf;
            Nome = nome;
        }

        public string GetTextoEndereco(Endereco endereco)
        {
            return $"Endereço: {endereco.Logradouro} {endereco.Numero} {endereco.Complemento} - {endereco.Bairro} - CEP {endereco.CEP} - {endereco.Municipio} - {endereco.UF}";
        }

        public void SetEnderecoFaturamento(Endereco endereco)
        {
            EnderecoFaturamento = endereco;
        }

        public void SetEnderecoEntrega(Endereco endereco)
        {
            EnderecoEntrega = endereco;
        }

        public void SetEnderecoCobranca(Endereco endereco)
        {
            EnderecoCobranca = endereco;
        }

        public override string ToString()
        {
            return "===Dados do Cliente===\n" +
                   $"CPF: {CPF}\n" +
                   $"Nome: {Nome}\n" +
                   $"{GetTextoEndereco(EnderecoCobranca)}\n" +
                   $"{GetTextoEndereco(EnderecoEntrega)}\n" +
                   $"{GetTextoEndereco(EnderecoFaturamento)}";
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
}
