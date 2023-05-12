using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalCount
{
    class Locacion : Conexion
    {
        int id_loc;
        string loc;

        public int Id_loc { get => id_loc; set => id_loc = value; }
        public string Loc { get => loc; set => loc = value; }


        public bool ExisteLoc(string comando)
        {
            comando = "select count(*) from tb_Loc where loc = '" + comando + "'";
            Cerrar();

            using (SqlCommand cmd = new SqlCommand(comando, Con1))
            {
                Abrir();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                Cerrar();
                if (count == 0)
                    return false;
                else
                    return true;
            }
        }
    }
}
