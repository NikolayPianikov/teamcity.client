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
    /// TriggersDto
    /// </summary>
    [DataContract]
    public partial class TriggersDto :  IEquatable<TriggersDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggersDto" /> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="trigger">trigger.</param>
        public TriggersDto(int? count = default(int?), List<TriggerDto> trigger = default(List<TriggerDto>))
        {
            this.Count = count;
            this.Trigger = trigger;
        }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets Trigger
        /// </summary>
        [DataMember(Name="trigger", EmitDefaultValue=false)]
        public List<TriggerDto> Trigger { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TriggersDto {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
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
            return this.Equals(input as TriggersDto);
        }

        /// <summary>
        /// Returns true if TriggersDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TriggersDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TriggersDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Trigger == input.Trigger ||
                    this.Trigger != null &&
                    this.Trigger.SequenceEqual(input.Trigger)
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Trigger != null)
                    hashCode = hashCode * 59 + this.Trigger.GetHashCode();
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