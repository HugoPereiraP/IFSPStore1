﻿using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities;

public class City : BaseEntity<int>
{
    public string Name { get; set; }
    public string State { get; set; }

   

    public City(int id, string name, string state)
        : base(id)
    {
        Name = name;
        State = state;
    }
}