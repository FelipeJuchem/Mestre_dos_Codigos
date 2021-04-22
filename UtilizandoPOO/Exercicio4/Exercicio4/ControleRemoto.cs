using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4
{
    public class ControleRemoto
    {
        public void TrocarCanal(Televisao televisao)
        {
            int canal = int.Parse(Console.ReadLine());
            if ( canal > 9)
            {

            }
            else
            {
                televisao.Canal = canal;
            }
            
        }

        public void AumentarVolume(Televisao televisao)
        {
            if(televisao.Vomule == 9)
            {

            }
            else
            {
                televisao.Vomule++;
            }
        }

        public void DiminuirVolume(Televisao televisao)
        {
            if (televisao.Vomule == 0)
            {

            }
            else
            {
                televisao.Vomule--;
            }
        }

        public void SubirCanal(Televisao televisao)
        {
            if (televisao.Canal == 9)
            {

            }
            else
            {
                televisao.Canal += 1;
            }
        }
        public void DescerCanal(Televisao televisao)
        {
            if (televisao.Canal == 0)
            {

            }
            else
            {
                televisao.Canal -= 1;
            }
        }
    }
}
