using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    // Casa de madera en el bosque (sin sótano, sin segundo piso, sí pinta)

    public class CasaMadera : Casa
    {
        private readonly bool pintarRequerido;
        private readonly bool sotanoRequerido;
        private readonly bool segundoPisoRequerido;

        public CasaMadera(bool pintarRequerido, bool sotanoRequerido, bool segundoPisoRequerido) 
        {
            this.pintarRequerido = pintarRequerido;
            this.sotanoRequerido = sotanoRequerido;
            this.segundoPisoRequerido = segundoPisoRequerido;
        }

        protected override void RealizarPlanos()
        {
            Console.WriteLine("Realizando los planos de una casa de madera\n");
        }

        protected override void ConstruirCimientos()
        {
            Console.WriteLine("Construyendo los cimientos de una casa de madera\n");
        }
        protected override void ConstruirSotano()
        {
            Console.WriteLine("Construyendo Sotano en casa de ladrillos\n");
        }
        protected override void ConstruirPrimerPiso()
        {
            Console.WriteLine("Construyendo primer piso de una casa de madera\n");
        }
        protected override void ConstruirSegundoPiso()
        {
            Console.WriteLine("Construyendo 2do Piso en casa de ladrillos\n");
        }

        protected override void ConstruirTecho()
        {
            Console.WriteLine("Construyendo techo de una casa de madera\n");
        }

        protected override void ColocarAcabados()
        {
            Console.WriteLine("Colocando acabados de una casa de madera\n");
        }

        protected override void Pintar()
        {
            Console.WriteLine("Pintando la casa de madera\n");
        }

        protected override bool PintarRequerido()
        {
            return pintarRequerido;
        }

        protected override bool ConstruirSegundoPisoRequerido()
        {
            return segundoPisoRequerido;
        }

        protected override bool ConstruirSotanoRequerido()
        {
            return sotanoRequerido;
        }

    }
}
