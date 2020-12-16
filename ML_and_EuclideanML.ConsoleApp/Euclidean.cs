using Machine_LearningML.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML_and_EuclideanML.ConsoleApp
{
    public static class Euclidean
    {
        public static int Calculate(string learningData, string dataToClasify)
        {

            var listOfLearning=GetData(learningData);
            var listToClasify=GetData(dataToClasify);

            List<bool> correct = new List<bool>();
            foreach (var toClasify in listToClasify)
            {
                List<double> ratios = new List<double>();
                foreach (var computer in listOfLearning)
                {
                    ratios.Add(Math.Sqrt(
                        ((toClasify.CPU-computer.CPU) * (toClasify.CPU - computer.CPU)) +
                        ((toClasify.Cores-computer.Cores) * (toClasify.Cores - computer.Cores)) +
                        ((toClasify.Diagonal-computer.Diagonal) * (toClasify.Diagonal - computer.Diagonal)) +
                        (((toClasify.Price-computer.Price)/150) * ((toClasify.Price - computer.Price)/150)) +
                        ((toClasify.RAM-computer.RAM) * (toClasify.RAM - computer.RAM)) +
                        (((toClasify.RefreshRate-computer.RefreshRate)/10) * ((toClasify.RefreshRate - computer.RefreshRate)/10)) +
                        ((toClasify.SSDorHDD-computer.SSDorHDD) * (toClasify.SSDorHDD - computer.SSDorHDD)) +
                        (((toClasify.StorageCapacity-computer.StorageCapacity)/100) * ((toClasify.StorageCapacity - computer.StorageCapacity)/100)) +
                        ((toClasify.VRAM-computer.VRAM) * (toClasify.VRAM - computer.VRAM)) +
                        ((toClasify.Weight-computer.Weight) * (toClasify.Weight - computer.Weight)) 
                        ));
                }
                var maxIndex = ratios.IndexOf(ratios.Min());
                if (listOfLearning[maxIndex].Category == toClasify.Category)
                    correct.Add(true);
                else correct.Add(false);
            }
            int correctCount = 0;
            foreach (var a in correct)
                if (a)
                    correctCount++;

            return correctCount;
        }

        public static List<ML_and_EuclideanML.Model.ModelInput> GetData(string path)
        {
            List<ML_and_EuclideanML.Model.ModelInput> data = new List<ML_and_EuclideanML.Model.ModelInput>();
            string line;
            bool x = false;
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                if (x)
                {
                    string[] arr = line.Split(',');
                    ML_and_EuclideanML.Model.ModelInput sampleData = new ML_and_EuclideanML.Model.ModelInput()
                    {
                        Price = Convert.ToSingle(arr[0]),
                        CPU = Convert.ToSingle(arr[2]),
                        Cores = Convert.ToSingle(arr[3]),
                        RAM = Convert.ToSingle(arr[4]),
                        SSDorHDD = Convert.ToSingle(arr[5]),
                        StorageCapacity = Convert.ToSingle(arr[6]),
                        VRAM = Convert.ToSingle(arr[7]),
                        Diagonal = Convert.ToSingle(arr[8]),
                        Weight = Convert.ToSingle(arr[9]),
                        BatteryCapacity = Convert.ToSingle(arr[10]),
                        RefreshRate = Convert.ToSingle(arr[11]),
                        Category=Convert.ToString(arr[12])
                    };
                    data.Add(sampleData);
                }
                x = true;
            }
            file.Close();
            return data;
        }
    }
}
