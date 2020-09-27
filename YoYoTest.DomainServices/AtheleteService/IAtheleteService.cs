namespace YoYoTest.DomainServices.AtheleteService
{
    using System;
    using System.Collections.Generic;
    using Yo_Yo_Test.Models;

    /// <summary>
    /// Exposes members to manage Athletes data entities.
    /// </summary>
    public interface IAtheleteService : IDisposable
    {
        /// <summary>
        /// Gets list of Atheletes.
        /// </summary>
        /// <returns>List of Athletes</returns>
        List<Athelete> GetAtheletes();
    }
}
