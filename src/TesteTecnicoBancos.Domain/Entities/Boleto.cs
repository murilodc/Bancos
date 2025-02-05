﻿using System.Reflection.Metadata.Ecma335;

namespace TesteTecnicoBancos.Domain.Entities;
public class Boleto
{
    public long Id { get; set; }
    public string PayeeName { get; set; } = string.Empty;
    public string CPFCNPJ { get; set; } = string.Empty;
    public float Value { get; set; }
    public DateOnly DueDate { get; set; }
    public string Obs { get; set; } = string.Empty;
    public long BankId { get; set; }
    public Bank Bank { get; set; } = default!;
}
