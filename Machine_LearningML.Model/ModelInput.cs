// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace Machine_LearningML.Model
{
    public class ModelInput
    {
        [ColumnName("Price"), LoadColumn(0)]
        public float Price { get; set; }


        [ColumnName("Manufacturor"), LoadColumn(1)]
        public string Manufacturor { get; set; }


        [ColumnName("CPU"), LoadColumn(2)]
        public float CPU { get; set; }


        [ColumnName("Cores"), LoadColumn(3)]
        public float Cores { get; set; }


        [ColumnName("RAM"), LoadColumn(4)]
        public float RAM { get; set; }


        [ColumnName("SSDorHDD"), LoadColumn(5)]
        public float SSDorHDD { get; set; }


        [ColumnName("StorageCapacity"), LoadColumn(6)]
        public float StorageCapacity { get; set; }


        [ColumnName("VRAM"), LoadColumn(7)]
        public float VRAM { get; set; }


        [ColumnName("Diagonal"), LoadColumn(8)]
        public float Diagonal { get; set; }


        [ColumnName("Weight"), LoadColumn(9)]
        public float Weight { get; set; }


        [ColumnName("BatteryCapacity"), LoadColumn(10)]
        public float BatteryCapacity { get; set; }


        [ColumnName("RefreshRate"), LoadColumn(11)]
        public float RefreshRate { get; set; }


        [ColumnName("Category"), LoadColumn(12)]
        public string Category { get; set; }


    }
}
