using System;

namespace igti_tcc_cadastro_conta_api.Models
{
    public class Conta
    {
        private int Id{get;set;}
        private string Nome{get;set;}
        private string Sobrenome{get;set;}
        private string CPF{get;set;}
        private DateTime DataNascimento{get;set;}
        private double Salario{get;set;}
    }
}