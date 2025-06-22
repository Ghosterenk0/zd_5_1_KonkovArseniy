using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cables
{
    public class Cable
    {
        private string type;
        private int wirecount;
        private double diameter;

        public string Type { get => type; set => type = value; }
        public int WireCount { get => wirecount; set => wirecount = value; }
        public double Diameter { get => diameter; set => diameter = value; }

        private string manufacturer;
        private double pricePerMeter;
        public string Manufacturer { get=>manufacturer; set=> manufacturer = value; }
        public double PricePerMeter { get=>pricePerMeter; set=>pricePerMeter = value; }

        public Cable(string type, int wireCount, double diameter, string manufacturer, double pricePerMeter)
        {
            Type = type;
            WireCount = wireCount;
            Diameter = diameter;
            Manufacturer = manufacturer;
            PricePerMeter = pricePerMeter;
        }
        public double CalculateQuality()
        {
            return Diameter / WireCount;
        }
        public string DisplayInfo()
        {
            string res = "";

            res += $"Тип кабеля: {Type}\n";
            res += $"Количество жил: {WireCount}\n";
            res += $"Диаметр: {Diameter} мм\n";
            res += $"Производитель: {Manufacturer}\n";
            res += $"Качество (Q): {CalculateQuality()}\n";
            return res;
        }

        public static void AddCable(List<Cable> list, Cable cable)
        {
            list.Add(cable);
        }
        public static void AddCable(List<Cable> list, string type, int wireCount, double diameter, string manufacturer, double price)
        {
           list.Add(new Cable(type, wireCount, diameter, manufacturer, price));
        }

        public static bool RemoveCable(List<Cable> list, Cable cable)
        {
            bool result = list.Remove(cable);
            return result;
        }

        public static bool RemoveCable(List<Cable> list, string type)
        {
            var cable = list.FirstOrDefault(c => c.Type == type);
            if (cable != null)
            {
                list.Remove(cable);
                return true;
            }
            return false;
        }
    }
}
