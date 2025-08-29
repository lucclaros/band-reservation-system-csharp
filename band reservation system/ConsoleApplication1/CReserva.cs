using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva
{
    public class CReserva {
        private ulong num_reserva;
        private DateTime inicio_reserva; 
        private int duracion_reserva;
        private string nom_banda;

        private static float costo_por_hora;
        private static float descuento;


        // SETTERS
        public void SetNumeroReserva(ulong num) {
            this.num_reserva = num;
        }
        public static void SetCostoHora(float costo) {
            CReserva.costo_por_hora = costo;
        }
        public static void SetDescuento(float descuento) {
            CReserva.descuento = descuento;

        }
        public CReserva(DateTime inicio, int duracion, string banda)
        {
            this.inicio_reserva = inicio;
            this.duracion_reserva = duracion;
            this.nom_banda = banda;
        }   
        public CReserva() 
        {
            this.duracion_reserva = 0;
            this.nom_banda = "";
        }


        // GETTERS
        public ulong GetNumeroReserva()
        {
            return this.num_reserva;
        }
        public float DarMontoTotal() 
        {
            float monto_total;
            monto_total = ((float)this.duracion_reserva * CReserva.costo_por_hora);

            if(this.duracion_reserva >= 6)
            {
                monto_total = monto_total - (monto_total * (descuento / 100));
            }
            return monto_total;
        }
        public float DarMontoTotal(float cotizacion)
        {
            float monto_total;

            monto_total = ((float)this.duracion_reserva * CReserva.costo_por_hora);

            if(this.duracion_reserva >= 6) {
                monto_total = monto_total - (monto_total * (descuento / 100));
            }
            monto_total = monto_total / cotizacion;



            return monto_total;
        }


        public string DarDatos()
        {
            Console.WriteLine("Datos de la reserva : ");
            string datos = "Numero de reserva : " + this.num_reserva.ToString();
            datos += " - Inicio de la reserva : " + this.inicio_reserva;
            datos += " - Duracion :  " + this.duracion_reserva.ToString();
            datos += " - Costo por hora : " + CReserva.costo_por_hora.ToString();
            datos += " - Descuento : " + CReserva.descuento.ToString() + "%";
            datos += " - Nombre de la banda : " + this.nom_banda;
            datos += " - Monto total de : " + DarMontoTotal().ToString() + "PESOS.";

            return datos;
        }
        public CReserva MayorMonto(CReserva ResA, CReserva ResB)
        {
            CReserva mayor_monto;

            if(ResA.DarMontoTotal() > ResB.DarMontoTotal()) {
                mayor_monto = ResA;
            } 
            else 
            {
                mayor_monto = ResB;00
            }
            return mayor_monto;
        }

    }








}