using System;

#pragma warning disable CS0436 
public class Cliente : BaseEntity
{
    public string Razao_Social { get; set; }
    public string Cnpj { get; set; }
    public DateTime Data_Fundacao { get; set; }
    public decimal Capital { get; set; }
    public bool Quarentena { get; set; }
    public bool Status_Cliente { get; set; }
    public char Classificacao { get; set; }
}
