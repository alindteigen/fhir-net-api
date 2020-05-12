﻿using Hl7.Fhir.Model;
using Hl7.Fhir.Validation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Fhir.Specification.Validation.Model
{
    internal class StructureDefMappingMapper : ITransferMapper<StructureDefinition.MappingComponent, UniStructureDefMapping>
    {
        public static readonly StructureDefMappingMapper Current = new StructureDefMappingMapper();

        public void Transfer(MappingContext context, StructureDefinition.MappingComponent source, UniStructureDefMapping target)
        {
            throw new NotImplementedException();
        }

        public void Transfer(MappingContext context, UniStructureDefMapping source, StructureDefinition.MappingComponent target)
        {
            throw new NotImplementedException();
        }
    }
}