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

namespace Xbim.CobieExpress
{
	[IndexedClass]
	[ExpressType("Space", 20)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieSpace : CobieAsset, SpatialDivision, IInstantiableEntity, IEqualityComparer<@CobieSpace>, IEquatable<@CobieSpace>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieSpace(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private string _roomTag;
		private double? _usableHeight;
		private double? _grossArea;
		private double? _netArea;
		private CobieFloor _floor;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @RoomTag 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _roomTag;
				((IPersistEntity)this).Activate(false);
				return _roomTag;
			} 
			set
			{
				SetValue( v =>  _roomTag = v, _roomTag, value,  "RoomTag");
			} 
		}
	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public double? @UsableHeight 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _usableHeight;
				((IPersistEntity)this).Activate(false);
				return _usableHeight;
			} 
			set
			{
				SetValue( v =>  _usableHeight = v, _usableHeight, value,  "UsableHeight");
			} 
		}
	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public double? @GrossArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _grossArea;
				((IPersistEntity)this).Activate(false);
				return _grossArea;
			} 
			set
			{
				SetValue( v =>  _grossArea = v, _grossArea, value,  "GrossArea");
			} 
		}
	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public double? @NetArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _netArea;
				((IPersistEntity)this).Activate(false);
				return _netArea;
			} 
			set
			{
				SetValue( v =>  _netArea = v, _netArea, value,  "NetArea");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(15, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobieFloor @Floor 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _floor;
				((IPersistEntity)this).Activate(false);
				return _floor;
			} 
			set
			{
				SetValue( v =>  _floor = v, _floor, value,  "Floor");
			} 
		}
	
		#endregion


		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<CobieComponent> @Components 
		{ 
			get 
			{
				return Model.Instances.Where<CobieComponent>(e => (e.Space as CobieSpace) == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<CobieZone> @Zones 
		{ 
			get 
			{
				return Model.Instances.Where<CobieZone>(e => e.Spaces != null &&  e.Spaces.Contains(this));
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 10: 
					_roomTag = value.StringVal;
					return;
				case 11: 
					_usableHeight = value.RealVal;
					return;
				case 12: 
					_grossArea = value.RealVal;
					return;
				case 13: 
					_netArea = value.RealVal;
					return;
				case 14: 
					_floor = (CobieFloor)(value.EntityVal);
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
        public bool Equals(@CobieSpace other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @CobieSpace
            var root = (@CobieSpace)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@CobieSpace left, @CobieSpace right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@CobieSpace left, @CobieSpace right)
        {
            return !(left == right);
        }


        public bool Equals(@CobieSpace x, @CobieSpace y)
        {
            return x == y;
        }

        public int GetHashCode(@CobieSpace obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}