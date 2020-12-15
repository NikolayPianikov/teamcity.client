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
    /// BuildTypesDto
    /// </summary>
    [DataContract]
    public partial class BuildTypesDto :  IEquatable<BuildTypesDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildTypesDto" /> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="href">href.</param>
        /// <param name="nextHref">nextHref.</param>
        /// <param name="prevHref">prevHref.</param>
        /// <param name="buildType">buildType.</param>
        public BuildTypesDto(int? count = default(int?), string href = default(string), string nextHref = default(string), string prevHref = default(string), List<BuildTypeDto> buildType = default(List<BuildTypeDto>))
        {
            this.Count = count;
            this.Href = href;
            this.NextHref = nextHref;
            this.PrevHref = prevHref;
            this.BuildType = buildType;
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
        /// Gets or Sets NextHref
        /// </summary>
        [DataMember(Name="nextHref", EmitDefaultValue=false)]
        public string NextHref { get; set; }

        /// <summary>
        /// Gets or Sets PrevHref
        /// </summary>
        [DataMember(Name="prevHref", EmitDefaultValue=false)]
        public string PrevHref { get; set; }

        /// <summary>
        /// Gets or Sets BuildType
        /// </summary>
        [DataMember(Name="buildType", EmitDefaultValue=false)]
        public List<BuildTypeDto> BuildType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildTypesDto {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  NextHref: ").Append(NextHref).Append("\n");
            sb.Append("  PrevHref: ").Append(PrevHref).Append("\n");
            sb.Append("  BuildType: ").Append(BuildType).Append("\n");
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
            return this.Equals(input as BuildTypesDto);
        }

        /// <summary>
        /// Returns true if BuildTypesDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildTypesDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildTypesDto input)
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
                    this.NextHref == input.NextHref ||
                    (this.NextHref != null &&
                    this.NextHref.Equals(input.NextHref))
                ) && 
                (
                    this.PrevHref == input.PrevHref ||
                    (this.PrevHref != null &&
                    this.PrevHref.Equals(input.PrevHref))
                ) && 
                (
                    this.BuildType == input.BuildType ||
                    this.BuildType != null &&
                    this.BuildType.SequenceEqual(input.BuildType)
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
                if (this.NextHref != null)
                    hashCode = hashCode * 59 + this.NextHref.GetHashCode();
                if (this.PrevHref != null)
                    hashCode = hashCode * 59 + this.PrevHref.GetHashCode();
                if (this.BuildType != null)
                    hashCode = hashCode * 59 + this.BuildType.GetHashCode();
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
