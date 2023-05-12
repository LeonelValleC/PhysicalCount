using System;
using System.Data.SqlClient;

namespace PhysicalCount
{
    class Scan : Conexion
    {
        int qty;
        string loc;
        string tagno;
        int emp;

        public int Qty { get => qty; set => qty = value; }
        public string Loc { get => loc; set => loc = value; }
        public string Tagno { get => tagno; set => tagno = value; }
        public int Emp { get => emp; set => emp = value; }


        public bool ExisteTag(string comando)
        {
            comando = "select count(*) from tb_Scan where tagno = '" + comando + "'";
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

        public bool ExisteCon(string comando)
        {
            comando = "select count(*) from tb_Tags where tag = '" + comando + "'";
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
