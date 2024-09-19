using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlumnosPagosApp.Models
{
    public class Pago
    {
        public int PagoID { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public string Concepto { get; set; }

        // Clave foránea
        public int AlumnoID { get; set; }
        public Alumno? Alumno { get; set; }

        // Propiedad calculada para mostrar el nombre completo
        public string NombreCompletoAl => $"{Alumno?.NombreCompleto ?? ""}";

    }
}
