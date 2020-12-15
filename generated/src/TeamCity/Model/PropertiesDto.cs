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
    /// PropertiesDto
    /// </summary>
    [DataContract]
    public partial class PropertiesDto :  IEquatable<PropertiesDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDto" /> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="href">href.</param>
        /// <param name="property">property.</param>
        public PropertiesDto(int? count = default(int?), string href = default(string), List<PropertyDto> property = default(List<PropertyDto>))
        {
            this.Count = count;
            this.Href = href;
            this.Property = property;
        }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public List<PropertyDto> Property { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertiesDto {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
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
            return this.Equals(input as PropertiesDto);
        }

        /// <summary>
        /// Returns true if PropertiesDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertiesDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertiesDto input)
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
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Property == input.Property ||
                    this.Property != null &&
                    this.Property.SequenceEqual(input.Property)
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Property != null)
                    hashCode = hashCode * 59 + this.Property.GetHashCode();
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
