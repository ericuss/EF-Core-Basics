namespace EF.Core.Contexts.contexts.Core
{
    using System;

    public interface IContextAttribute { }

    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class BuaAmbulanceContextAttribute : Attribute, IContextAttribute { }
}
