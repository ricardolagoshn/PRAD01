using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using PRAD01.Models;
using PRAD01.Controllers;
using System.Threading.Tasks;

namespace PRAD01.Controllers
{
    public class SitiosController
    {
        // Constructor de clase
        public SitiosController()
        {
        }

        // Procedimientos

        // Retorna todas las filas de la tabla personas
        public Task<List<Sitios>> ObtenerListaSitios()
        {
            return DB.dbconexion.Table<Sitios>().ToListAsync();
        }

        // OPERACIONES CRUD - CREATE , READ , UPDATE , DELETE 
        // INSERT, SELECT, UPDATE, DELETE 

        // CREATE - UPDATE
        public Task<int> AddSitios(Sitios sitio)
        {
            if (sitio.ID != 0)
            {
                // Ejecutamos el procedimiento de Actualizacion UPDATE
                return DB.dbconexion.UpdateAsync(sitio);
            }
            else
            {
                // Ejectuamos el procedimiento de INSERCCION de UNA PERSONA
                return DB.dbconexion.InsertAsync(sitio);
            }
        }

        // Obtenemos por el ID un registro de una persona
        public Task<Sitios> ObtenerSitio(int pid)
        {
            return DB.dbconexion.Table<Sitios>()
                .Where(i => i.ID == pid)
                .FirstOrDefaultAsync();
        }

        // Eliminamos el registro de una persona
        public Task<int> DelPersona(Sitios persona)
        {
            return DB.dbconexion.DeleteAsync(persona);
        }
    }
}
