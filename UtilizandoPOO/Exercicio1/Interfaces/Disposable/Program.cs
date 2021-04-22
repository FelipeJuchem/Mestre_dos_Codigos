using System;
using System.Data.SqlClient;


//O que faz a interface IDisposable?
//      Ela descarta os objetos não gerenciados antes que o Garbage collector passe.



namespace DisposeExemplo
{
    class Program
    {
        static void Main(string[] args)
        {   
            var conection = new SqlConnection();
            try
            {
                //Comandos
            }
            finally
            {
                if (conection != null)
                {
                    conection.Dispose();
                }
            }

            using (var con = new SqlConnection())
            {
                //Implementa o Dispose() automaticamente.
            }
            
            var conexao = new Conexao();
            
                conexao.Conectar();
                conexao.Fechar();
                conexao.Dispose();
        }
    }
}
