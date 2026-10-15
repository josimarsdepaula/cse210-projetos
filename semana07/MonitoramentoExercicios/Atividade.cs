using System;

public abstract class Atividade
{
    private DateTime _data;
    private int _duracaoMinutos;

    public Atividade(DateTime data, int duracaoMinutos)
    {
        _data = data;
        _duracaoMinutos = duracaoMinutos;
    }

    protected int ObterDuracao()
    {
        return _duracaoMinutos;
    }

    public abstract double ObterDistancia();

    public abstract double ObterVelocidade();

    public abstract double ObterRitmo();

    public string ObterResumo()
    {
        return $"{_data:dd MMM yyyy} {GetType().Name} " +
               $"({_duracaoMinutos} min) - " +
               $"Distância: {ObterDistancia():F2} km, " +
               $"Velocidade: {ObterVelocidade():F2} km/h, " +
               $"Ritmo: {ObterRitmo():F2} min por km";
    }
}