using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIZ_X_CHEAT
{
    internal class APIZ_X_CHEAT
    {


        //xd aqui iba

        public static void MonitorearProcesos()
        {

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += VerificarProceso;
            timer.Start();
        }

        //gg xd

        //AHORA LLAMAREMOS A LA FUNSION DONDE NOSOTROS QUERAMOS ;)


        //aqui haremos un anti cmd super basico pero 100%.. . 

        private static void VerificarProceso(object sender, System.EventArgs e)
        {
            //aqui basicamente iria nombre de proceso/app/exe etc

            string nombreProceso = "cmd";

            Process[] procesos = Process.GetProcessesByName(nombreProceso);

            //aqui haremos para cerrar el cmd inmediatamente si se detecta que lo habren .. 
            //pueden hacer lo mismo que hare yo o ponerle in inyect es gusto de cada uno

            if (procesos.Length > 0)
            {

                foreach (Process proceso in procesos)
                {
                    proceso.Kill();

                }
            }
        }
    }
}

