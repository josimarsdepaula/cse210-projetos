using System;

public class Corrida : Atividade
{
    private double _distanciaKm;

    public Corrida(DateTime data, int duracaoMinutos, double distanciaKm)
        : base(data, duracaoMinutos)
    {
        _distanciaKm = distanciaKm;
    }

    public override double ObterDistancia()
    {
        return _distanciaKm;
    }

    public override double ObterVelocidade()
    {
        return (_distanciaKm / ObterDuracao()) * 60;
    }

    public override double ObterRitmo()
    {
        return ObterDuracao() / _distanciaKm;
    }
}
