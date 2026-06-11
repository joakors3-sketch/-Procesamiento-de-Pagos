using System;


public abstract class Pago
{
    public string Titular { get; set; }public double Monto { get; set; }

    public Pago(string titular, double monto)
    {
        Titular = titular;
        Monto = monto;
    }

    public abstract double Calcularcostoad();

    public virtual void MostrarInformacion()
    {
        double comision = Calcularcostoad();

        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Monto original: ${Monto}");
        Console.WriteLine("Procesando pago ----");
        Console.WriteLine($"Monto con la comision: ${comision}");
        Console.WriteLine($"Monto final: ${Monto + comision}");
        Console.WriteLine("Pago exitoso , gracias.");
        
    }
}