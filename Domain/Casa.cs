using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    // Clase abstracta que define el template method
    public abstract class Casa
    {
        // Método plantilla (Template Method)
        public void ConstruirCasa()
        {
            RealizarPlanos();

            ConstruirCimientos();

            if (ConstruirSotanoRequerido()) 
            {
                ConstruirSotano();
            }

            ConstruirPrimerPiso();

            if (ConstruirSegundoPisoRequerido())
            {
                ConstruirSegundoPiso();
            }

            ConstruirTecho();

            ColocarAcabados();

            if (PintarRequerido()) 
            {
                Pintar();
            }

            Console.WriteLine("Casa terminada!\n");
        }

        // Pasos abstractos, cada subclase esta obligada a sobreescribirlos
        protected abstract void RealizarPlanos();
        protected abstract void ConstruirCimientos();
        protected abstract void ConstruirPrimerPiso();
        protected abstract void ConstruirTecho();
        protected abstract void ColocarAcabados();

        // Pasos virtuales, pueden o no ser sobreescritos por las subclases
        protected virtual void Pintar() {}
        protected virtual void ConstruirSotano() { }
        protected virtual void ConstruirSegundoPiso() { }



        // Métodos opcionales que pueden o no ser sobreescritos por las subclases
        protected virtual bool ConstruirSotanoRequerido() 
        {
            return true;
        } 
        protected virtual bool ConstruirSegundoPisoRequerido()
        {
            return true;
        }
        protected virtual bool PintarRequerido()
        {
            return true;
        }


    }
}

