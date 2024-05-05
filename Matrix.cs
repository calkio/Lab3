using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Matrix
    {
        public double[,] GetMatrix(string pathFile)
        {
            string jsonX = File.ReadAllText(pathFile);
            double[,] matrix = JsonConvert.DeserializeObject<double[,]>(jsonX);
            return matrix;
        }
    }
}
