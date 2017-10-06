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
    
    public abstract class IngredientMeasurementDtoBase : EntityDtoBase
    {
        public virtual Nullable<float> CaloriesPer { get; set; }
        public virtual Nullable<float> CarbohydratesPer { get; set; }
        public virtual Nullable<float> FatPer { get; set; }
        public virtual Nullable<float> SaturatedFatPer { get; set; }
        public virtual Nullable<float> SugarsPer { get; set; }
        public virtual Nullable<float> ProteinPer { get; set; }
    	
    	// must be overridden to be exposed
        // public virtual IngredientDto Ingredient { get; set; }
        // public virtual MeasurementDto Measurement { get; set; }
        // public virtual ICollection<IngredientMeasurementAlternateDto> FromIngredientMeasurementAlternates { get; set; }
        // public virtual ICollection<IngredientMeasurementAlternateDto> ToIngredientMeasurementAlternates { get; set; }
        // public virtual ICollection<RecipeIngredientMeasurementDto> RecipeIngredientMeasurements { get; set; }
    }
}
