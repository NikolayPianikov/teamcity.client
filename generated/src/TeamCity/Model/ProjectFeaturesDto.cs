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
    /// ProjectFeaturesDto
    /// </summary>
    [DataContract]
    public partial class ProjectFeaturesDto :  IEquatable<ProjectFeaturesDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectFeaturesDto" /> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="href">href.</param>
        /// <param name="projectFeature">projectFeature.</param>
        public ProjectFeaturesDto(int? count = default(int?), string href = default(string), List<ProjectFeatureDto> projectFeature = default(List<ProjectFeatureDto>))
        {
            this.Count = count;
            this.Href = href;
            this.ProjectFeature = projectFeature;
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
        /// Gets or Sets ProjectFeature
        /// </summary>
        [DataMember(Name="projectFeature", EmitDefaultValue=false)]
        public List<ProjectFeatureDto> ProjectFeature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectFeaturesDto {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  ProjectFeature: ").Append(ProjectFeature).Append("\n");
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
            return this.Equals(input as ProjectFeaturesDto);
        }

        /// <summary>
        /// Returns true if ProjectFeaturesDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectFeaturesDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectFeaturesDto input)
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
                    this.ProjectFeature == input.ProjectFeature ||
                    this.ProjectFeature != null &&
                    this.ProjectFeature.SequenceEqual(input.ProjectFeature)
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
                if (this.ProjectFeature != null)
                    hashCode = hashCode * 59 + this.ProjectFeature.GetHashCode();
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
