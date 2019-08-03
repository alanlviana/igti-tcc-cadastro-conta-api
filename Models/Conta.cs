using System;

namespace igti_tcc_cadastro_conta_api.Models
{
    public class Conta
    {
        public int Id{get;set;}
        public string Nome{get;set;}
        public string Sobrenome{get;set;}
        public string CPF{get;set;}
        public DateTime DataNascimento{get;set;}
        public double Salario{get;set;}
    }
}