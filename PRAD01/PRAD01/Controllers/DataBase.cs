using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using PRAD01.Models;
using PRAD01.Controllers;

using System.Threading.Tasks;

namespace PRAD01.Controllers
{
    public static class DataBase
    {
        
        // Procedimientos

        // Retorna todas las filas de la tabla personas
        public static Task<List<Personas>> ObtenerListaPersonas()
        {
            return DB.dbconexion.Table<Personas>().ToListAsync();
        }

        // OPERACIONES CRUD - CREATE , READ , UPDATE , DELETE 
        // INSERT, SELECT, UPDATE, DELETE 

        // CREATE - UPDATE
        public static Task<int> AddPersona(Personas persona)
        {
            if (persona.ID != 0)
            {
                // Ejecutamos el procedimiento de Actualizacion UPDATE
                return DB.dbconexion.UpdateAsync(persona);
            }
            else
            {
                // Ejectuamos el procedimiento de INSERCCION de UNA PERSONA
                return DB.dbconexion.InsertAsync(persona);
            }
        }

        // Obtenemos por el ID un registro de una persona
        public static Task<Personas> ObtenerPersona(int pid)
        {
            return DB.dbconexion.Table<Personas>()
                .Where(i => i.ID == pid)
                .FirstOrDefaultAsync();
        }

        // Eliminamos el registro de una persona
        public static Task<int> DelPersona(Personas persona)
        {
            return DB.dbconexion.DeleteAsync(persona);
        }
    }
}
