namespace EF.Core.Entities
{
    using System;
    using System.Collections.Generic;

    public class BuaAmbulance
    {
        public Guid Id { get; set; }

        public IEnumerable<Whiner> Whiners { get; set; }
    }
}
