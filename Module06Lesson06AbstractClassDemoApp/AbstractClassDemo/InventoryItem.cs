﻿namespace AbstractClassDemo
{
    public abstract class InventoryItem
    {
        public string ProductName { get; set; }
        public int QuantityOnHand { get; set; }

    }
}


/*
 its a class that's a base class (foundational) but its not complete on its own, its abstract
for eg. book has author, page, title, and is a real thing where as inventory item is not a thing and is abstract
we cannot directly instantiate abstract class
 
 */
