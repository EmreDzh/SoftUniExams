﻿using Gym.Models.Equipment.Contracts;

namespace Gym.Models.Equipment
{
    public abstract class Equipment : IEquipment
    {
        protected Equipment(double weight, decimal price)
        {
            this.Weight = weight;
            this.Price = price;
        }

        public double Weight { get;  } //TODO MIGHT BE PROTECTED CHECK IF PROBLEMS
        public decimal Price { get; }
    }
}