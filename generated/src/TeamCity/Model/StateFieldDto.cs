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
    /// StateFieldDto
    /// </summary>
    [DataContract]
    public partial class StateFieldDto :  IEquatable<StateFieldDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateFieldDto" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="inherited">inherited.</param>
        public StateFieldDto(bool? value = default(bool?), bool? inherited = default(bool?))
        {
            this.Value = value;
            this.Inherited = inherited;
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public bool? Value { get; set; }

        /// <summary>
        /// Gets or Sets Inherited
        /// </summary>
        [DataMember(Name="inherited", EmitDefaultValue=false)]
        public bool? Inherited { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StateFieldDto {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Inherited: ").Append(Inherited).Append("\n");
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
            return this.Equals(input as StateFieldDto);
        }

        /// <summary>
        /// Returns true if StateFieldDto instances are equal
        /// </summary>
        /// <param name="input">Instance of StateFieldDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateFieldDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Inherited == input.Inherited ||
                    (this.Inherited != null &&
                    this.Inherited.Equals(input.Inherited))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Inherited != null)
                    hashCode = hashCode * 59 + this.Inherited.GetHashCode();
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
