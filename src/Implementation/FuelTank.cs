namespace src
{
    public class FuelTank
    {
        // constructor
        public FuelTank(string fuelType)
        {
            this.fuelType = fuelType;
        }

        // fields

        // the type of fuel in the fueltank
        private Fueltype fuelType;

        // the amount of fuel in the fueltank
        private int fuelAmount;

        // the top fill warn level of the fueltank ( e.g. do something above 70% fill)
        private int topFillWarn;

        // the bottom fill warn level of the fueltank ( e.g. do something below 30% fill)
        private int bottomFillWarnLevel;

        // the maximum capacity the tank can hold in fuel
        private int fuelCapacity;

  

        // Adds an amount to the fuel tank, if the fuel doesnt fit its filled to capacity and the added value is returned
        public int AddFuelToTank(int amount)
        {
            if (this.fuelAmount + amount < this.fuelCapacity )
            {
                this.fuelAmount += amount;
                return amount;
            }
           
            int fillableAmount = this.fuelCapacity - this.fuelAmount;
            this.fuelAmount += fillableAmount;
            return fillableAmount;
                
            
           
        }

        // Takes an amount from the fuel tank, if the amount is too big it takes the remainder and the drained value is returned
        public int DrainFuelFromTank(int amount)
        {
            if(this.fuelAmount - amount >= 0)
            {
                this.fuelAmount -= amount;
                return amount;
            }
     
            int drainableAmount = amount - this.fuelAmount;
            this.fuelAmount -= drainableAmount;
            return drainableAmount;
      

        }

        // returns the fill percentage of the fueltank
        public float getFillPercentage()
        {
            return this.fuelAmount / this.fuelCapacity * 100;
        }


    }
}
