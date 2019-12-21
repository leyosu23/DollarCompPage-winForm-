using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// This class is used to store shared data
    /// </summary>
    class HardwareSpec
    {
        // Properties
        public int ProductId { get; set; }
        public float Cost { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Condition { get; set; }
        public string Platform { get; set; }
        public string OS { get; set; }
        public string RamSize { get; set; }
        public string ScreenSize { get; set; }
        public string Resolution { get; set; }
        public string CpuBrand { get; set; }
        public string CpuSpeed { get; set; }
        public string CpuType { get; set; }
        public string HddSize { get; set; }
        public string GpuType { get; set; }
        public string CpuNumber { get; set; }
    }
}
