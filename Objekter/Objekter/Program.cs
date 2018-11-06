using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekter
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class VacuumCleaner
    {
        double capacityInLiters;
        double filledCapacity;
        string brand;
        int[] color;
        bool isFunctional;
        bool isDirty;
        double longitude;
        double latitude;
        private bool hasPower;

        public VacuumCleaner(double capacityInLiters, string brand, int[] color, bool isFunctional, bool isDirty, double longitude = 0.0, double latitude = 0.0)
        {
            this.capacityInLiters = capacityInLiters;
            this.brand = brand;
            this.color = color;
            this.isFunctional = isFunctional;
            this.isDirty = isDirty;
            hasPower = false;
            this.longitude = longitude;
            this.latitude = latitude;
        }
        
        public void Vacuum()
        {
            if (filledCapacity >= capacityInLiters)
            {
                Console.WriteLine("<<angry vacuum sounds>>");
                return;
            }

            // We vacuum, we fill
            filledCapacity += 0.1;
            Console.WriteLine("<<happy vacuum sounds>>");
        }

        public void Move(double longitudeChange, double latitudeChange)
        {
            longitude += longitudeChange;
            latitude = latitudeChange;
        }

        public void Empty()
        {
            filledCapacity = 0;
        }

        public void InsertPlug()
        {
            hasPower = true;
        }

        public void PullPlug()
        {
            hasPower = false;
        }
    }
}
