﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Specification;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated for FHIR v4.0.1
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A definition of a set of people that apply to some clinically related context, for example people contraindicated for a certain medication
    /// </summary>
    [FhirType("Population")]
    [DataContract]
    public partial class Population : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override string TypeName { get { return "Population"; } }
        
        /// <summary>
        /// The age of the specific population
        /// </summary>
        [FhirElement("age", InSummary=true, Order=90, Choice=ChoiceType.DatatypeChoice)]
        [CLSCompliant(false)]
		[AllowedTypes(typeof(Hl7.Fhir.Model.Range),typeof(Hl7.Fhir.Model.CodeableConcept))]
        [DataMember]
        public Hl7.Fhir.Model.Element Age
        {
            get { return _Age; }
            set { _Age = value; OnPropertyChanged("Age"); }
        }
        
        private Hl7.Fhir.Model.Element _Age;
        
        /// <summary>
        /// The gender of the specific population
        /// </summary>
        [FhirElement("gender", InSummary=true, Order=100)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Gender
        {
            get { return _Gender; }
            set { _Gender = value; OnPropertyChanged("Gender"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Gender;
        
        /// <summary>
        /// Race of the specific population
        /// </summary>
        [FhirElement("race", InSummary=true, Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Race
        {
            get { return _Race; }
            set { _Race = value; OnPropertyChanged("Race"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Race;
        
        /// <summary>
        /// The existing physiological conditions of the specific population to which this applies
        /// </summary>
        [FhirElement("physiologicalCondition", InSummary=true, Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept PhysiologicalCondition
        {
            get { return _PhysiologicalCondition; }
            set { _PhysiologicalCondition = value; OnPropertyChanged("PhysiologicalCondition"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _PhysiologicalCondition;
        

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Population;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Age != null) dest.Age = (Hl7.Fhir.Model.Element)Age.DeepCopy();
                if(Gender != null) dest.Gender = (Hl7.Fhir.Model.CodeableConcept)Gender.DeepCopy();
                if(Race != null) dest.Race = (Hl7.Fhir.Model.CodeableConcept)Race.DeepCopy();
                if(PhysiologicalCondition != null) dest.PhysiologicalCondition = (Hl7.Fhir.Model.CodeableConcept)PhysiologicalCondition.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Population());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Population;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Age, otherT.Age)) return false;
            if( !DeepComparable.Matches(Gender, otherT.Gender)) return false;
            if( !DeepComparable.Matches(Race, otherT.Race)) return false;
            if( !DeepComparable.Matches(PhysiologicalCondition, otherT.PhysiologicalCondition)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Population;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Age, otherT.Age)) return false;
            if( !DeepComparable.IsExactly(Gender, otherT.Gender)) return false;
            if( !DeepComparable.IsExactly(Race, otherT.Race)) return false;
            if( !DeepComparable.IsExactly(PhysiologicalCondition, otherT.PhysiologicalCondition)) return false;
            
            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Age != null) yield return Age;
                if (Gender != null) yield return Gender;
                if (Race != null) yield return Race;
                if (PhysiologicalCondition != null) yield return PhysiologicalCondition;
            }
        }

        [NotMapped]
        public override IEnumerable<ElementValue> NamedChildren 
        { 
            get 
            { 
                foreach (var item in base.NamedChildren) yield return item; 
                if (Age != null) yield return new ElementValue("age", Age);
                if (Gender != null) yield return new ElementValue("gender", Gender);
                if (Race != null) yield return new ElementValue("race", Race);
                if (PhysiologicalCondition != null) yield return new ElementValue("physiologicalCondition", PhysiologicalCondition);
 
            } 
        } 
    
    
    }
    
}
