namespace Problem_6._Traffic_Lights
{
    using System;

    public class TrafficLight
    {
        private Signal curentSignal;

        public TrafficLight(string signal)
        {
            this.curentSignal = (Signal)Enum.Parse(typeof(Signal), signal);
        }

        public void Update()
        {
            int previous = (int)this.curentSignal;

            this.curentSignal = (Signal)(++previous % Enum.GetNames(typeof(Signal)).Length);
        }


    }
}
