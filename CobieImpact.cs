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
    /// Readonly interface for CobieImpact
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @ICobieImpact : ICobieReferencedObject
	{
		string @Name { get; }
		string @Description { get; }
		ICobieImpactType @ImpactType { get; }
		ICobieImpactStage @ImpactStage { get; }
		double? @Value { get; }
		ICobieImpactUnit @ImpactUnit { get; }
		double? @LeadInTime { get; }
		double? @Duration { get; }
		double? @LeadOutTime { get; }
		ICobieDurationUnit @DurationUnit { get; }
	
	}
}

namespace Xbim.CobieExpress
{
	[ExpressType("Impact", 29)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieImpact : CobieReferencedObject, IInstantiableEntity, ICobieImpact, IEquatable<@CobieImpact>
	{
		#region ICobieImpact explicit implementation
		string ICobieImpact.Name { get { return @Name; } }	
		string ICobieImpact.Description { get { return @Description; } }	
		ICobieImpactType ICobieImpact.ImpactType { get { return @ImpactType; } }	
		ICobieImpactStage ICobieImpact.ImpactStage { get { return @ImpactStage; } }	
		double? ICobieImpact.Value { get { return @Value; } }	
		ICobieImpactUnit ICobieImpact.ImpactUnit { get { return @ImpactUnit; } }	
		double? ICobieImpact.LeadInTime { get { return @LeadInTime; } }	
		double? ICobieImpact.Duration { get { return @Duration; } }	
		double? ICobieImpact.LeadOutTime { get { return @LeadOutTime; } }	
		ICobieDurationUnit ICobieImpact.DurationUnit { get { return @DurationUnit; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieImpact(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private string _name;
		private string _description;
		private CobieImpactType _impactType;
		private CobieImpactStage _impactStage;
		private double? _value;
		private CobieImpactUnit _impactUnit;
		private double? _leadInTime;
		private double? _duration;
		private double? _leadOutTime;
		private CobieDurationUnit _durationUnit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public string @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public string @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 8)]
		public CobieImpactType @ImpactType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _impactType;
				((IPersistEntity)this).Activate(false);
				return _impactType;
			} 
			set
			{
				SetValue( v =>  _impactType = v, _impactType, value,  "ImpactType");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 9)]
		public CobieImpactStage @ImpactStage 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _impactStage;
				((IPersistEntity)this).Activate(false);
				return _impactStage;
			} 
			set
			{
				SetValue( v =>  _impactStage = v, _impactStage, value,  "ImpactStage");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 10)]
		public double? @Value 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _value;
				((IPersistEntity)this).Activate(false);
				return _value;
			} 
			set
			{
				SetValue( v =>  _value = v, _value, value,  "Value");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 11)]
		public CobieImpactUnit @ImpactUnit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _impactUnit;
				((IPersistEntity)this).Activate(false);
				return _impactUnit;
			} 
			set
			{
				SetValue( v =>  _impactUnit = v, _impactUnit, value,  "ImpactUnit");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public double? @LeadInTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _leadInTime;
				((IPersistEntity)this).Activate(false);
				return _leadInTime;
			} 
			set
			{
				SetValue( v =>  _leadInTime = v, _leadInTime, value,  "LeadInTime");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 13)]
		public double? @Duration 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _duration;
				((IPersistEntity)this).Activate(false);
				return _duration;
			} 
			set
			{
				SetValue( v =>  _duration = v, _duration, value,  "Duration");
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 14)]
		public double? @LeadOutTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _leadOutTime;
				((IPersistEntity)this).Activate(false);
				return _leadOutTime;
			} 
			set
			{
				SetValue( v =>  _leadOutTime = v, _leadOutTime, value,  "LeadOutTime");
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 15)]
		public CobieDurationUnit @DurationUnit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _durationUnit;
				((IPersistEntity)this).Activate(false);
				return _durationUnit;
			} 
			set
			{
				SetValue( v =>  _durationUnit = v, _durationUnit, value,  "DurationUnit");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_name = value.StringVal;
					return;
				case 6: 
					_description = value.StringVal;
					return;
				case 7: 
					_impactType = (CobieImpactType)(value.EntityVal);
					return;
				case 8: 
					_impactStage = (CobieImpactStage)(value.EntityVal);
					return;
				case 9: 
					_value = value.RealVal;
					return;
				case 10: 
					_impactUnit = (CobieImpactUnit)(value.EntityVal);
					return;
				case 11: 
					_leadInTime = value.RealVal;
					return;
				case 12: 
					_duration = value.RealVal;
					return;
				case 13: 
					_leadOutTime = value.RealVal;
					return;
				case 14: 
					_durationUnit = (CobieDurationUnit)(value.EntityVal);
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
        public bool Equals(@CobieImpact other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @CobieImpact
            var root = (@CobieImpact)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@CobieImpact left, @CobieImpact right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@CobieImpact left, @CobieImpact right)
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