using EF.Core.Entities.Helpers;
using System;

namespace EF.Core.Entities
{
    public class Whiner
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TokidokiFamily Family { get; set; }

        public BuaAmbulance Ambulance { get; set; }
    }
}
