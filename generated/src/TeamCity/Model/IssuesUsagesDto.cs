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
    /// IssuesUsagesDto
    /// </summary>
    [DataContract]
    public partial class IssuesUsagesDto :  IEquatable<IssuesUsagesDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUsagesDto" /> class.
        /// </summary>
        /// <param name="issueUsage">issueUsage.</param>
        /// <param name="href">href.</param>
        /// <param name="count">count.</param>
        public IssuesUsagesDto(List<IssueUsageDto> issueUsage = default(List<IssueUsageDto>), string href = default(string), int? count = default(int?))
        {
            this.IssueUsage = issueUsage;
            this.Href = href;
            this.Count = count;
        }
        
        /// <summary>
        /// Gets or Sets IssueUsage
        /// </summary>
        [DataMember(Name="issueUsage", EmitDefaultValue=false)]
        public List<IssueUsageDto> IssueUsage { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssuesUsagesDto {\n");
            sb.Append("  IssueUsage: ").Append(IssueUsage).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as IssuesUsagesDto);
        }

        /// <summary>
        /// Returns true if IssuesUsagesDto instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuesUsagesDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuesUsagesDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IssueUsage == input.IssueUsage ||
                    this.IssueUsage != null &&
                    this.IssueUsage.SequenceEqual(input.IssueUsage)
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.IssueUsage != null)
                    hashCode = hashCode * 59 + this.IssueUsage.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
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