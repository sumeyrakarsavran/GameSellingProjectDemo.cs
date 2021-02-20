using Game.cs.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.cs.Entities
{


    public class Gamer : IEntity
    {
            public int Id { get; set; }
            public string NationalityId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }

    }
    
}
