﻿namespace TesteTecnicoBancos.Infrastructure.Authentication;
public class JwtSettings
{
    public string Secret { get; set; } = string.Empty;
    public int ExpirationHours { get; set; }
}
