using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Core.Entities.Core
{

    public class Settings
    {
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    public class ConnectionStrings
    {
        public string BuaAmbulance { get; set; }
    }
}
