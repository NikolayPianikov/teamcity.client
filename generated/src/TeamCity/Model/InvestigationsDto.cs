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
    /// InvestigationsDto
    /// </summary>
    [DataContract]
    public partial class InvestigationsDto :  IEquatable<InvestigationsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvestigationsDto" /> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="nextHref">nextHref.</param>
        /// <param name="prevHref">prevHref.</param>
        /// <param name="href">href.</param>
        /// <param name="investigation">investigation.</param>
        public InvestigationsDto(int? count = default(int?), string nextHref = default(string), string prevHref = default(string), string href = default(string), List<InvestigationDto> investigation = default(List<InvestigationDto>))
        {
            this.Count = count;
            this.NextHref = nextHref;
            this.PrevHref = prevHref;
            this.Href = href;
            this.Investigation = investigation;
        }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

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
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Investigation
        /// </summary>
        [DataMember(Name="investigation", EmitDefaultValue=false)]
        public List<InvestigationDto> Investigation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvestigationsDto {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  NextHref: ").Append(NextHref).Append("\n");
            sb.Append("  PrevHref: ").Append(PrevHref).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Investigation: ").Append(Investigation).Append("\n");
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
            return this.Equals(input as InvestigationsDto);
        }

        /// <summary>
        /// Returns true if InvestigationsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of InvestigationsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvestigationsDto input)
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
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Investigation == input.Investigation ||
                    this.Investigation != null &&
                    this.Investigation.SequenceEqual(input.Investigation)
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
                if (this.NextHref != null)
                    hashCode = hashCode * 59 + this.NextHref.GetHashCode();
                if (this.PrevHref != null)
                    hashCode = hashCode * 59 + this.PrevHref.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Investigation != null)
                    hashCode = hashCode * 59 + this.Investigation.GetHashCode();
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
