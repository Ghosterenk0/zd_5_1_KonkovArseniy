using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cables
{
    public class EnhancedCable : Cable
    {
        public bool HasBraiding { get; set; }

        public string Color { get; set; }

        public EnhancedCable(string type, int wireCount, double diameter, string manufacturer,
                            double pricePerMeter, bool hasBraiding, string color)
            : base(type, wireCount, diameter, manufacturer, pricePerMeter)
        {
            HasBraiding = hasBraiding;
            Color = color;
        }
        public double CalculateQuality()
        {
            double baseQuality = base.CalculateQuality();
            return HasBraiding ? 2 * baseQuality : 0.7 * baseQuality;
        }

        public string DisplayInfo()
        {
            string res = "";
            res += base.DisplayInfo();
            res += $"Наличие оплетки: {(HasBraiding)}\n";
            res += $"Цвет: {Color}\n";
            res += $"Улучшенное качество (Qp): {CalculateQuality()}\n";
            return res;
        }

        public static void AddEnhancedCable(List<EnhancedCable> list, string type, int wireCount, double diameter, string manufacturer, double price, bool hasbraiding, string color)
        {
            list.Add(new EnhancedCable(type, wireCount, diameter, manufacturer, price, hasbraiding, color));
        }

        public static bool RemoveEnhancedCable(List<EnhancedCable> list, EnhancedCable cable)
        {
            bool result = list.Remove(cable);
            return result;
        }
    }
}
