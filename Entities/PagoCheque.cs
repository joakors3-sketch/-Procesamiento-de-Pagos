using System;


public class PagoCheque : Pago
{
    public PagoCheque(string titular, double monto)
        : base(titular, monto)
    {
        
    }

    public override double Calcularcostoad()
    {
        return 2500;
    }
}