using Game.cs.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.cs.Abstract
{
    public interface IPersonCheckService
    {
        bool Verify(Gamer gamer);
    }
}
