namespace Problem_6._Traffic_Lights
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            TrafficLight[] trafficLights = new TrafficLight[input.Length];

            for (int i = 0; i < trafficLights.Length; i++)
            {
                trafficLights[i] = (TrafficLight)Activator
                    .CreateInstance(typeof(TrafficLight), new object[] { input[i] });
            }

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                List<string> result = new List<string>();

                foreach (var trafficLight in trafficLights)
                {
                    trafficLight.Update();
                    var field = typeof(TrafficLight)
                        .GetField("curentSignal", BindingFlags.Instance | BindingFlags.NonPublic);

                    result.Add(field.GetValue(trafficLight).ToString());
                }

                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
