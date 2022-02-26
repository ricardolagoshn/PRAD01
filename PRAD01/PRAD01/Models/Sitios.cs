using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PRAD01.Models
{
    public class Sitios
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(70)]
        public String descripcion { get; set; }

        public Byte[] foto { get; set; }

        public Double longitud { get; set; }
        public Double latitud { get; set; }
        public DateTime fecha { get; set; }
    }

   
}
