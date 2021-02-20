using Game.cs.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.cs.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " +"kaydedildi.");
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" " + "silindi.");
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" " + "güncellendi.");
        }
    }
}
