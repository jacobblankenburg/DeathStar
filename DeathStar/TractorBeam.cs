using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar;

namespace TopSecretPlans
{
    public class TractorBeam : Reactor, Iactivate
    {
        public int TractorBeamLevel
        {
             set
            {
                TractorBeamLevel = value;
            }
            get
            {
                return TractorBeamLevel;
            }
        }
        public TractorBeam(int PowerRate, int TractorBeamLevel)
            :base(PowerRate)
        {
            this.TractorBeamLevel = TractorBeamLevel;
        }
        public void Tractorbeamgeneratortower(int powerrate)
            
        {
            TractorBeamLevel = powerrate;
                       
        }

        public void GenerateTractorBeam()
        {
            TractorBeamLevel++;
        }

        public void CreateForce(int power, int direction)
        {
            Tractorbeamgeneratortower(power);
            //Console.WriteLine($"Your tractor bean starts pulling with {power} at {direction} degrees");
        }
        public void activate()
        {
            TractorBeamLevel();
            GenerateTractorBeam();
        }
        public void refresh()
        {

        }
    }
}
