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
    /// IssueUsageDto
    /// </summary>
    [DataContract]
    public partial class IssueUsageDto :  IEquatable<IssueUsageDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueUsageDto" /> class.
        /// </summary>
        /// <param name="changes">changes.</param>
        /// <param name="issue">issue.</param>
        public IssueUsageDto(ChangesDto changes = default(ChangesDto), IssueDto issue = default(IssueDto))
        {
            this.Changes = changes;
            this.Issue = issue;
        }
        
        /// <summary>
        /// Gets or Sets Changes
        /// </summary>
        [DataMember(Name="changes", EmitDefaultValue=false)]
        public ChangesDto Changes { get; set; }

        /// <summary>
        /// Gets or Sets Issue
        /// </summary>
        [DataMember(Name="issue", EmitDefaultValue=false)]
        public IssueDto Issue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueUsageDto {\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
            sb.Append("  Issue: ").Append(Issue).Append("\n");
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
            return this.Equals(input as IssueUsageDto);
        }

        /// <summary>
        /// Returns true if IssueUsageDto instances are equal
        /// </summary>
        /// <param name="input">Instance of IssueUsageDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssueUsageDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Changes == input.Changes ||
                    (this.Changes != null &&
                    this.Changes.Equals(input.Changes))
                ) && 
                (
                    this.Issue == input.Issue ||
                    (this.Issue != null &&
                    this.Issue.Equals(input.Issue))
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
                if (this.Changes != null)
                    hashCode = hashCode * 59 + this.Changes.GetHashCode();
                if (this.Issue != null)
                    hashCode = hashCode * 59 + this.Issue.GetHashCode();
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
