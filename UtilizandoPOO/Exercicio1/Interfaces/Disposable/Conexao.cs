using System;
using System.Collections.Generic;
using System.Text;

namespace DisposeExemplo
{
    class Conexao : IDisposable
    {
        private string Handle;

        public Conexao()
        {
            this.Handle = "Recurso alocado";
            Console.WriteLine("Recurso Alocado");
        }

        public void Conectar()
        {
            Console.WriteLine("Conectado");
        }

        public void Fechar()
        {
            Console.WriteLine("Conexão fechada");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        private void LiberarRecursos()
        {
            Handle = "";
            Console.WriteLine("Recurso liberado");
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Liberar recursos gerenciados
            }
            // Liberar recursos não gerenciados
            LiberarRecursos();
        }

    }
}
