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
    /// Readonly interface for CobieComponent
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @ICobieComponent : ICobieTypeOrComponent
	{
		string @SerialNumber { get;  set; }
		DateTimeValue? @InstallationDate { get;  set; }
		DateTimeValue? @WarrantyStartDate { get;  set; }
		string @TagNumber { get;  set; }
		string @BarCode { get;  set; }
		string @AssetIdentifier { get;  set; }
		ICobieType @Type { get;  set; }
		IItemSet<ICobieSpace> @Spaces { get; }
		IEnumerable<ICobieSystem> @InSystems {  get; }
	
	}
}

namespace Xbim.CobieExpress
{
	[ExpressType("Component", 23)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieComponent : CobieTypeOrComponent, IInstantiableEntity, ICobieComponent, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@CobieComponent>
	{
		#region ICobieComponent explicit implementation
		string ICobieComponent.SerialNumber { 
 
			get { return @SerialNumber; } 
			set { SerialNumber = value;}
		}	
		DateTimeValue? ICobieComponent.InstallationDate { 
 
			get { return @InstallationDate; } 
			set { InstallationDate = value;}
		}	
		DateTimeValue? ICobieComponent.WarrantyStartDate { 
 
			get { return @WarrantyStartDate; } 
			set { WarrantyStartDate = value;}
		}	
		string ICobieComponent.TagNumber { 
 
			get { return @TagNumber; } 
			set { TagNumber = value;}
		}	
		string ICobieComponent.BarCode { 
 
			get { return @BarCode; } 
			set { BarCode = value;}
		}	
		string ICobieComponent.AssetIdentifier { 
 
			get { return @AssetIdentifier; } 
			set { AssetIdentifier = value;}
		}	
		ICobieType ICobieComponent.Type { 
 
 
			get { return @Type; } 
			set { Type = value as CobieType;}
		}	
		IItemSet<ICobieSpace> ICobieComponent.Spaces { 
			get { return new Common.Collections.ProxyItemSet<CobieSpace, ICobieSpace>( @Spaces); } 
		}	
		 
		IEnumerable<ICobieSystem> ICobieComponent.InSystems {  get { return @InSystems; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieComponent(IModel model) : base(model) 		{ 
			_spaces = new ItemSet<CobieSpace>( this, 2,  21);
		}

		#region Explicit attribute fields
		private string _serialNumber;
		private DateTimeValue? _installationDate;
		private DateTimeValue? _warrantyStartDate;
		private string _tagNumber;
		private string _barCode;
		private string _assetIdentifier;
		private CobieType _type;
		private readonly ItemSet<CobieSpace> _spaces;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 19)]
		public string @SerialNumber 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _serialNumber;
				((IPersistEntity)this).Activate(false);
				return _serialNumber;
			} 
			set
			{
				SetValue( v =>  _serialNumber = v, _serialNumber, value,  "SerialNumber", 14);
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 20)]
		public DateTimeValue? @InstallationDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _installationDate;
				((IPersistEntity)this).Activate(false);
				return _installationDate;
			} 
			set
			{
				SetValue( v =>  _installationDate = v, _installationDate, value,  "InstallationDate", 15);
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 21)]
		public DateTimeValue? @WarrantyStartDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _warrantyStartDate;
				((IPersistEntity)this).Activate(false);
				return _warrantyStartDate;
			} 
			set
			{
				SetValue( v =>  _warrantyStartDate = v, _warrantyStartDate, value,  "WarrantyStartDate", 16);
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 22)]
		public string @TagNumber 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _tagNumber;
				((IPersistEntity)this).Activate(false);
				return _tagNumber;
			} 
			set
			{
				SetValue( v =>  _tagNumber = v, _tagNumber, value,  "TagNumber", 17);
			} 
		}	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 23)]
		public string @BarCode 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _barCode;
				((IPersistEntity)this).Activate(false);
				return _barCode;
			} 
			set
			{
				SetValue( v =>  _barCode = v, _barCode, value,  "BarCode", 18);
			} 
		}	
		[EntityAttribute(19, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 24)]
		public string @AssetIdentifier 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _assetIdentifier;
				((IPersistEntity)this).Activate(false);
				return _assetIdentifier;
			} 
			set
			{
				SetValue( v =>  _assetIdentifier = v, _assetIdentifier, value,  "AssetIdentifier", 19);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(20, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 25)]
		public CobieType @Type 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _type;
				((IPersistEntity)this).Activate(false);
				return _type;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _type = v, _type, value,  "Type", 20);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(21, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, 2, 26)]
		public IItemSet<CobieSpace> @Spaces 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _spaces;
				((IPersistEntity)this).Activate(false);
				return _spaces;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("Components")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1, 27)]
		public IEnumerable<CobieSystem> @InSystems 
		{ 
			get 
			{
				return Model.Instances.Where<CobieSystem>(e => e.Components != null &&  e.Components.Contains(this), "Components", this);
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
				case 12: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 13: 
					_serialNumber = value.StringVal;
					return;
				case 14: 
					_installationDate = value.StringVal;
					return;
				case 15: 
					_warrantyStartDate = value.StringVal;
					return;
				case 16: 
					_tagNumber = value.StringVal;
					return;
				case 17: 
					_barCode = value.StringVal;
					return;
				case 18: 
					_assetIdentifier = value.StringVal;
					return;
				case 19: 
					_type = (CobieType)(value.EntityVal);
					return;
				case 20: 
					_spaces.InternalAdd((CobieSpace)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@CobieComponent other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @CobieComponent
            var root = (@CobieComponent)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@CobieComponent left, @CobieComponent right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@CobieComponent left, @CobieComponent right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Created != null)
					yield return @Created;
				if (@ExternalSystem != null)
					yield return @ExternalSystem;
				if (@ExternalObject != null)
					yield return @ExternalObject;
				foreach(var entity in @Categories)
					yield return entity;
				foreach(var entity in @Impacts)
					yield return entity;
				foreach(var entity in @Documents)
					yield return entity;
				foreach(var entity in @Attributes)
					yield return entity;
				foreach(var entity in @Representations)
					yield return entity;
				foreach(var entity in @AssemblyOf)
					yield return entity;
				if (@Type != null)
					yield return @Type;
				foreach(var entity in @Spaces)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@Type != null)
					yield return @Type;
				foreach(var entity in @Spaces)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}