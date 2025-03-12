using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cercleEtPoints
{
    public class Cercle
    {
        public Pts Centre { get; set; }
        public double Rayon { get; set; }

        public double Permimetre { get { return 2 * Math.PI * Rayon; } }

        public double Surface { get { return Math.PI * Math.Pow(Rayon, 2); } }

        public Cercle() { }
        public Cercle(Pts centre, double rayon) 
        {
            Centre = centre;
            Rayon = rayon;
        }

        public override string ToString()
        {
            return "Cercle de centre "+Centre.ToString()+" et de rayon "+Rayon;
        }

        public bool Inclus(Pts point)
        {
            return Math.Pow((point.X - Centre.X), 2) + Math.Pow((point.Y - Centre.Y), 2) == Math.Pow(Rayon, 2);
        }
    }
}
