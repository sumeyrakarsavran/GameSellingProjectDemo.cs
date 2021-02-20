using Game.cs.Abstract;
using Game.cs.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.cs.Concrate
{
    public class PersonCheckManager : IPersonCheckService
    {
        public bool Verify(Gamer gamer)
        {
            if (gamer.NationalityId == "2737123"& gamer.FirstName == "Sümeyra"& gamer.LastName == "Karsavran"&
                gamer.DateOfBirth.Year == 2002)
            {
                return true;
            }
            else
            {
                return false;
            }


           
        }
    }
}
