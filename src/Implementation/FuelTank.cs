namespace src
{
    public class FuelTank
    {
        // fields / properties

        // the type of fuel in the fueltank
        private Fueltype fuelType;

        // the amount of fuel in the fueltank
        private int fuelAmount;

        // the percentage Level of the fueltank
        private float fillPercentage;

        // the top fill warn level of the fueltank ( e.g. do something above 70% fill)
        private int topFillWarn;

        // the bottom fill warn level of the fueltank ( e.g. do something below 30% fill)
        private int bottomFillWarnLevel;

        // the maximum capacity the tank can hold in fuel
        private int fuelCapacity;


        // functionality


        // these 2 functions are for adding and subtracting fuel from the tank.
        // They check if the action is valid and return a boolean if it has been executed or not.
        public bool addFuelToTank(int amount)
        {
            // check if the amount fits in the tank

            // add the amount to the tank

            // update Percentage
            calculateFillPercentage();

            // return a message if failed or successed
        }

        public bool drainFuelFromTank(int amount)
        {
            // check if there is enough fuel to get

            // drain fuel from tank

            // update the Percentage
            calculateFillPercentage();

            // return a message if failed or successfull
        }

        // update the percentage value for this tanks currently holded fuel
        public void calculateFillPercentage()
        {
            this.fuelAmount = this.fuelAmount / this.fuelCapacity * 100;
        }
    }
}
