using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AlumnosPagosApp.Models
{
    public class Alumno
    {
        public int AlumnoID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        // Propiedad de navegación
        public ICollection<Pago>? Pagos { get; set; }

        // Propiedad calculada para mostrar el nombre completo
        public string ? NombreCompleto => $"{Nombre} {Apellido}";
    }
}
