using System;


List<Pago> pagos = new List<Pago>();

int opcion;

do
{
    Console.WriteLine("Bienvenido a sistema de Procesamiento de pagos - Seleccione una opcion - 0 al 4 ");
    Console.WriteLine("1 - Registrar Pago con Cheque");
    Console.WriteLine("2 - Registrar Pago en Efectivo");
    Console.WriteLine("3 - Mostrar Pagos");
    Console.WriteLine("0 - Salir");

    Console.Write("Opción: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:

            Console.Write("Titular: ");
            string titularCheque = Console.ReadLine();

            Console.Write("Monto: ");
            double montoCheque = double.Parse(Console.ReadLine());

            pagos.Add(new PagoCheque(titularCheque, montoCheque));
            break;

        case 2:

            Console.Write("Titular: ");
            string titularEfectivo = Console.ReadLine();

            Console.Write("Monto: ");
            double montoEfectivo = double.Parse(Console.ReadLine());

            pagos.Add(new PagoEfectivo(titularEfectivo, montoEfectivo));
            break;

        case 3:

            foreach (Pago pago in pagos)
            {
                pago.MostrarInformacion();
            }

            break;

        case 0:
            Console.WriteLine("Saliendo.......");
            break;

        default:
            Console.WriteLine("No existe opcion indicada");
            break;
    }

} while (opcion != 0);