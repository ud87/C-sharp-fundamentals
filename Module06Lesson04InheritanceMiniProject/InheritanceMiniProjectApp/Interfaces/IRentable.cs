﻿namespace InheritanceMiniProjectApp
{
    public interface IRentable: IInventoryItem
    {
        void Rent(); 
        void ReturnRental();
    }
}
