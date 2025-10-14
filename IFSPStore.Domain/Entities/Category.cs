﻿using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities;

public class Category : BaseEntity<int>
{
    public string Name { get; set; }
    public string Description { get; set; }


    public Category()
    {
       
    }

    public Category(int id, string name,string descripition)
        : base(id)
    {
        Name = name;
        Description = descripition;
    }

    
}