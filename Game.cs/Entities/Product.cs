using Game.cs.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.cs.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

    }
}
