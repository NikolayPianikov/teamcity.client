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
    /// IssuesDto
    /// </summary>
    [DataContract]
    public partial class IssuesDto :  IEquatable<IssuesDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesDto" /> class.
        /// </summary>
        /// <param name="issues">issues.</param>
        public IssuesDto(List<IssueDto> issues = default(List<IssueDto>))
        {
            this._Issues = issues;
        }
        
        /// <summary>
        /// Gets or Sets _Issues
        /// </summary>
        [DataMember(Name="issues", EmitDefaultValue=false)]
        public List<IssueDto> _Issues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssuesDto {\n");
            sb.Append("  _Issues: ").Append(_Issues).Append("\n");
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
            return this.Equals(input as IssuesDto);
        }

        /// <summary>
        /// Returns true if IssuesDto instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuesDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuesDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Issues == input._Issues ||
                    this._Issues != null &&
                    this._Issues.SequenceEqual(input._Issues)
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
                if (this._Issues != null)
                    hashCode = hashCode * 59 + this._Issues.GetHashCode();
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
