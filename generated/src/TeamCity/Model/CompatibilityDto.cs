/* 
 * TeamCity REST API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2018.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = TeamCity.Client.SwaggerDateConverter;

namespace TeamCity.Model
{
    /// <summary>
    /// CompatibilityDto
    /// </summary>
    [DataContract]
    public partial class CompatibilityDto :  IEquatable<CompatibilityDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompatibilityDto" /> class.
        /// </summary>
        /// <param name="compatible">compatible.</param>
        /// <param name="agent">agent.</param>
        /// <param name="buildType">buildType.</param>
        /// <param name="unmetRequirements">unmetRequirements.</param>
        public CompatibilityDto(bool? compatible = default(bool?), AgentDto agent = default(AgentDto), BuildTypeDto buildType = default(BuildTypeDto), RequirementsDto unmetRequirements = default(RequirementsDto))
        {
            this.Compatible = compatible;
            this.Agent = agent;
            this.BuildType = buildType;
            this.UnmetRequirements = unmetRequirements;
        }
        
        /// <summary>
        /// Gets or Sets Compatible
        /// </summary>
        [DataMember(Name="compatible", EmitDefaultValue=false)]
        public bool? Compatible { get; set; }

        /// <summary>
        /// Gets or Sets Agent
        /// </summary>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public AgentDto Agent { get; set; }

        /// <summary>
        /// Gets or Sets BuildType
        /// </summary>
        [DataMember(Name="buildType", EmitDefaultValue=false)]
        public BuildTypeDto BuildType { get; set; }

        /// <summary>
        /// Gets or Sets UnmetRequirements
        /// </summary>
        [DataMember(Name="unmetRequirements", EmitDefaultValue=false)]
        public RequirementsDto UnmetRequirements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompatibilityDto {\n");
            sb.Append("  Compatible: ").Append(Compatible).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  BuildType: ").Append(BuildType).Append("\n");
            sb.Append("  UnmetRequirements: ").Append(UnmetRequirements).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompatibilityDto);
        }

        /// <summary>
        /// Returns true if CompatibilityDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CompatibilityDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompatibilityDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Compatible == input.Compatible ||
                    (this.Compatible != null &&
                    this.Compatible.Equals(input.Compatible))
                ) && 
                (
                    this.Agent == input.Agent ||
                    (this.Agent != null &&
                    this.Agent.Equals(input.Agent))
                ) && 
                (
                    this.BuildType == input.BuildType ||
                    (this.BuildType != null &&
                    this.BuildType.Equals(input.BuildType))
                ) && 
                (
                    this.UnmetRequirements == input.UnmetRequirements ||
                    (this.UnmetRequirements != null &&
                    this.UnmetRequirements.Equals(input.UnmetRequirements))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Compatible != null)
                    hashCode = hashCode * 59 + this.Compatible.GetHashCode();
                if (this.Agent != null)
                    hashCode = hashCode * 59 + this.Agent.GetHashCode();
                if (this.BuildType != null)
                    hashCode = hashCode * 59 + this.BuildType.GetHashCode();
                if (this.UnmetRequirements != null)
                    hashCode = hashCode * 59 + this.UnmetRequirements.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}