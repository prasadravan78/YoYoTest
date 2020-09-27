namespace YoYoTest.DomainServices.AtheleteService
{
    using System;
    using System.Collections.Generic;
    using Yo_Yo_Test.Models;

    /// <summary>
    ///  Provides members to manage Athelete data entities.
    /// </summary>
    public class AtheleteService : IAtheleteService
    {
        #region Member Variables

        private bool isDisposed = false;

        #endregion Member Variables

        #region Constructors

        /// <summary>
        /// Initializes service with dependencies.
        /// </summary>
        public AtheleteService()
        {

        }

        #endregion Constructors

        #region Public Methods 

        /// <summary>
        /// Gets list of Atheletes.
        /// </summary>
        /// <returns>List of Athletes</returns>
        public List<Athelete> GetAtheletes()
        {
            List<Athelete> atheletes = new List<Athelete>();

            atheletes.AddRange
            (
                new List<Athelete>
                { 
                    new Athelete{ Id = 1, Name = "Ashton Eaton"},
                    new Athelete{ Id = 2, Name = "Bryan Clay"},
                    new Athelete{ Id = 3, Name = "Dean Karnazes"},
                    new Athelete{ Id = 4, Name = "Usain Bolt"},
                }
            );

            return atheletes;
        }

        #endregion Public Methods

        #region IDisposable Support

        /// <summary>
        /// Disposes the instance of UnitOfWork.
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    //dispose managed state (managed objects).
                    //if (unitOfWork != null)
                    //    unitOfWork.Dispose();
                }

                // free unmanaged resources (unmanaged objects) and override a finalizer below.
                // set large fields to null.

                isDisposed = true;
            }
        }

        /// <summary>
        /// Disposes current instance of the service.
        /// </summary>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }

        #endregion IDisposable Support
    }
}
