using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva {
    public class CEjecutora 
    {
        public static void Main()
        {
            float costo_hora;
            float descuento;
            Console.WriteLine("Ingresar costo por hora");
            costo_hora = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar descuento");
            descuento = float.Parse(Console.ReadLine());

            CReserva.SetCostoHora(costo_hora);
            CReserva.SetDescuento(descuento);


                
            int num_reserva = 1;
            float monto_total = 0;
            float euro;
            CReserva Res1, Res_Mayor_Monto;
            Console.WriteLine("Ingresar cotizacion del euro : ");
            euro = float.Parse(Console.ReadLine());
            Console.WriteLine("Numero de reserva : ");
            num_reserva = int.Parse(Console.ReadLine());
            Res_Mayor_Monto = new CReserva();


            if(num_reserva != 0) 
            {
                while(num_reserva != 0) 
                {
                    int duracion;
                    string nom_banda;
                    DateTime hoy;
                    Console.WriteLine("Ingresar duracion de la reserva : ");
                    duracion = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresar nombre de la banda : ");
                    nom_banda = Console.ReadLine();
                    hoy = DateTime.Now;
                    Res1 = new CReserva(hoy, duracion, nom_banda);
                    Res1.SetNumeroReserva((ulong)num_reserva); 
                    monto_total = monto_total + Res1.DarMontoTotal(euro);
                    Res_Mayor_Monto = Res1.MayorMonto(Res1, Res_Mayor_Monto);
                    Console.WriteLine("Numero de reserva : ");
                    num_reserva = int.Parse(Console.ReadLine());
                }




                Console.WriteLine(Res_Mayor_Monto.DarDatos());
                Console.WriteLine("El monto total es de : " + monto_total + " EUROS");
            }
            else 
            {
                Console.Write("No se ingresaron reservas validas.");
            }

            Console.WriteLine("Fin del programa.");
            Console.ReadLine();
        }
    }
}
