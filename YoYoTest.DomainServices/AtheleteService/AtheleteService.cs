namespace YoYoTest.DomainServices.AtheleteService
{
    using System.Collections.Generic;
    using Yo_Yo_Test.Models;

    public class AtheleteService
    {
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
    }
}
