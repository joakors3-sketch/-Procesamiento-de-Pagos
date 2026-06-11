using System;

public class PagoEfectivo : Pago
{
    public PagoEfectivo(string titular, double monto)
        : base(titular, monto)
    {

    }


    public override double Calcularcostoad()
    {
        return 3500;
    }
}