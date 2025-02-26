// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> A complete order discrepancy is shown when one or more body parts and/or measurements that should be in the document (because there is a complete order) are not present. </summary>
    public partial class CompleteOrderDiscrepancyInference : RadiologyInsightsInference
    {
        /// <summary> Initializes a new instance of <see cref="CompleteOrderDiscrepancyInference"/>. </summary>
        /// <param name="orderType"> Order type : CPT ultrasound complete code for abdomen, retroperitoneal, pelvis or breast. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="orderType"/> is null. </exception>
        internal CompleteOrderDiscrepancyInference(FhirR4CodeableConcept orderType)
        {
            Argument.AssertNotNull(orderType, nameof(orderType));

            Kind = RadiologyInsightsInferenceType.CompleteOrderDiscrepancy;
            OrderType = orderType;
            MissingBodyParts = new ChangeTrackingList<FhirR4CodeableConcept>();
            MissingBodyPartMeasurements = new ChangeTrackingList<FhirR4CodeableConcept>();
        }

        /// <summary> Initializes a new instance of <see cref="CompleteOrderDiscrepancyInference"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="orderType"> Order type : CPT ultrasound complete code for abdomen, retroperitoneal, pelvis or breast. </param>
        /// <param name="missingBodyParts"> List of missing body parts required by a complete order : SNOMED CT codes. </param>
        /// <param name="missingBodyPartMeasurements"> List of missing body parts that require measurement by a complete order : SNOMED CT codes. </param>
        internal CompleteOrderDiscrepancyInference(RadiologyInsightsInferenceType kind, IReadOnlyList<FhirR4Extension> extension, IDictionary<string, BinaryData> serializedAdditionalRawData, FhirR4CodeableConcept orderType, IReadOnlyList<FhirR4CodeableConcept> missingBodyParts, IReadOnlyList<FhirR4CodeableConcept> missingBodyPartMeasurements) : base(kind, extension, serializedAdditionalRawData)
        {
            OrderType = orderType;
            MissingBodyParts = missingBodyParts;
            MissingBodyPartMeasurements = missingBodyPartMeasurements;
        }

        /// <summary> Initializes a new instance of <see cref="CompleteOrderDiscrepancyInference"/> for deserialization. </summary>
        internal CompleteOrderDiscrepancyInference()
        {
        }

        /// <summary> Order type : CPT ultrasound complete code for abdomen, retroperitoneal, pelvis or breast. </summary>
        public FhirR4CodeableConcept OrderType { get; }
        /// <summary> List of missing body parts required by a complete order : SNOMED CT codes. </summary>
        public IReadOnlyList<FhirR4CodeableConcept> MissingBodyParts { get; }
        /// <summary> List of missing body parts that require measurement by a complete order : SNOMED CT codes. </summary>
        public IReadOnlyList<FhirR4CodeableConcept> MissingBodyPartMeasurements { get; }
    }
}
