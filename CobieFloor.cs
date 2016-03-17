// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.CobieExpress.Interfaces;
using Xbim.CobieExpress;
//## Custom using statements
//##

namespace Xbim.CobieExpress.Interfaces
{
	/// <summary>
    /// Readonly interface for CobieFloor
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @ICobieFloor : ICobieAsset, SpatialDivision
	{
		double? @Elevation { get; }
		double? @Height { get; }
		ICobieFacility @Facility { get; }
		IEnumerable<ICobieSpace> @Spaces {  get; }
	
	}
}

namespace Xbim.CobieExpress
{
	[ExpressType("Floor", 17)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieFloor : CobieAsset, IInstantiableEntity, ICobieFloor, IEquatable<@CobieFloor>
	{
		#region ICobieFloor explicit implementation
		double? ICobieFloor.Elevation { get { return @Elevation; } }	
		double? ICobieFloor.Height { get { return @Height; } }	
		ICobieFacility ICobieFloor.Facility { get { return @Facility; } }	
		 
		IEnumerable<ICobieSpace> ICobieFloor.Spaces {  get { return @Spaces; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieFloor(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private double? _elevation;
		private double? _height;
		private CobieFacility _facility;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 15)]
		public double? @Elevation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _elevation;
				((IPersistEntity)this).Activate(false);
				return _elevation;
			} 
			set
			{
				SetValue( v =>  _elevation = v, _elevation, value,  "Elevation");
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 16)]
		public double? @Height 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _height;
				((IPersistEntity)this).Activate(false);
				return _height;
			} 
			set
			{
				SetValue( v =>  _height = v, _height, value,  "Height");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(15, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 17)]
		public CobieFacility @Facility 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _facility;
				((IPersistEntity)this).Activate(false);
				return _facility;
			} 
			set
			{
				SetValue( v =>  _facility = v, _facility, value,  "Facility");
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("Floor")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1, 18)]
		public IEnumerable<CobieSpace> @Spaces 
		{ 
			get 
			{
				return Model.Instances.Where<CobieSpace>(e => (e.Floor as CobieFloor) == this, "Floor", this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
				case 10: 
				case 11: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 12: 
					_elevation = value.RealVal;
					return;
				case 13: 
					_height = value.RealVal;
					return;
				case 14: 
					_facility = (CobieFacility)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@CobieFloor other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @CobieFloor
            var root = (@CobieFloor)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@CobieFloor left, @CobieFloor right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@CobieFloor left, @CobieFloor right)
        {
            return !(left == right);
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}