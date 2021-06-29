using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        // Declared and Initialised Variables
        readonly private double COST_PER_KILO_METER = 10.0;
        readonly private double COST_PER_MININUTES = 1.0;
        readonly private double MINIMUM_FARE = 5.0;

        /// <InvoiceGenerator>
        /// Default Constructor
        /// </InvoiceGenerator>
        /// <param name="runningDistance"></param>
        /// <param name="runningTime"></param>
        public InvoiceGenerator()
        {
        }

        /// <CalculateCabFare>
        /// Calculating Total Fare of a journey.
        /// </CalculateCabFare>
        /// <minimumFare></returns>
        /// <totalFare></returns>
        public double CalculateCabFare(double runningDistance, double runningTime)
        {
            double totalFare = (runningDistance * COST_PER_KILO_METER) + (runningTime * COST_PER_MININUTES);
            if (totalFare < MINIMUM_FARE)
            {
                return MINIMUM_FARE;
            }
            return totalFare;
        }

        /// <CalculateCabFare>
        /// MUltiple Rides
        /// Method to calculated fare of multiple rides
        /// initializing array
        /// </CalculateCabFare>
        /// <param name="rides"></param>
        /// <returns></returns>
        public double CalculateCabFare(Ride[] rides)
        {
            // totalFare bydeafult will be 0
            double totalFare = 0;
            foreach (Ride ride in rides)
            {
                totalFare += CalculateCabFare(ride.rideDistance, ride.rideTime);
            }
            if (totalFare < MINIMUM_FARE)
            {
                return MINIMUM_FARE;
            }
            return totalFare;
        }
    }
}