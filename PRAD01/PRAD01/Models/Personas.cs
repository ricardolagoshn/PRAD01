using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PRAD01.Models
{
    public class Personas
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        
        [MaxLength(70)]
        public String nombre { get; set; }
        
        [MaxLength(70)]
        public String apellido { get; set; }
        
        [MaxLength(70)]
        public String correo { get; set; }
        public DateTime fecha_nac { get; set; }
        public String sexo { get; set; }
    }
}
