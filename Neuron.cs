using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class Neuron
    {
        private List<double> inputs;
        private List<double> weights;
        private Func<List<double>, double> activationFunction;

        public Neuron(Func<List<double>, double> activationFunction)
        {
            inputs = new List<double>();
            weights = new List<double>();
            this.activationFunction = activationFunction;
        }

        public void AddInput(double input, double weight)
        {
            inputs.Add(input);
            weights.Add(weight);
        }

        public double ComputeOutput()
        {
            double weightedSum = 0;

            for (int i = 0; i < inputs.Count; i++)
            {
                weightedSum += inputs[i] * weights[i];
            }

            //return activationFunction(weightedSum);
            return weightedSum;
        }

    }
}
