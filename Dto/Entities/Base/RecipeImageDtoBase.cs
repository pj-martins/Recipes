//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaJaMa.Recipes.Dto.Entities.Base
{
    using PaJaMa.Common;
    using PaJaMa.Dto;
    using System;
    using System.Collections.Generic;
    
    public abstract class RecipeImageDtoBase : EntityDtoBase
    {
        public virtual string ImageURL { get; set; }
        public virtual string LocalImagePath { get; set; }
        public virtual int Sequence { get; set; }
    	
    	// must be overridden to be exposed
        // public virtual RecipeDto Recipe { get; set; }
    
    	public override string ToString()
    	{
    		return ImageURL;
    	}
    }
}
