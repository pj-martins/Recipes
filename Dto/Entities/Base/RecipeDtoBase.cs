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
    
    public abstract class RecipeDtoBase : EntityDtoBase
    {
        public virtual string RecipeName { get; set; }
        public virtual string Directions { get; set; }
        public virtual Nullable<int> NumberOfServings { get; set; }
        public virtual Nullable<float> Rating { get; set; }
        public virtual bool Inactive { get; set; }
        public virtual string RecipeURL { get; set; }
        public virtual PaJaMa.Recipes.Model.RecipeType RecipeType { get; set; }
    	public string RecipeTypeString { get { return EnumHelper.GetEnumDisplay<PaJaMa.Recipes.Model.RecipeType>(RecipeType); } }
    	
    	// must be overridden to be exposed
        // public virtual RecipeSourceDto RecipeSource { get; set; }
        // public virtual ICollection<RecipeImageDto> RecipeImages { get; set; }
        // public virtual ICollection<RecipeIngredientMeasurementDto> RecipeIngredientMeasurements { get; set; }
        // public virtual ICollection<UserRecipeDto> UserRecipes { get; set; }
    
    	public override string ToString()
    	{
    		return RecipeName;
    	}
    }
}