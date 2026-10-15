using System;

public class Ciclismo : Atividade
{
    private double _velocidadeKmH;

    public Ciclismo(DateTime data, int duracaoMinutos, double velocidadeKmH)
        : base(data, duracaoMinutos)
    {
        _velocidadeKmH = velocidadeKmH;
    }

    public override double ObterDistancia()
    {
        return (_velocidadeKmH * ObterDuracao()) / 60;
    }

    public override double ObterVelocidade()
    {
        return _velocidadeKmH;
    }

    public override double ObterRitmo()
    {
        return 60 / _velocidadeKmH;
    }
}