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
    /// ProblemScopeDto
    /// </summary>
    [DataContract]
    public partial class ProblemScopeDto :  IEquatable<ProblemScopeDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProblemScopeDto" /> class.
        /// </summary>
        /// <param name="project">project.</param>
        /// <param name="buildTypes">buildTypes.</param>
        /// <param name="buildType">buildType.</param>
        public ProblemScopeDto(ProjectDto project = default(ProjectDto), BuildTypesDto buildTypes = default(BuildTypesDto), BuildTypeDto buildType = default(BuildTypeDto))
        {
            this.Project = project;
            this.BuildTypes = buildTypes;
            this.BuildType = buildType;
        }
        
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public ProjectDto Project { get; set; }

        /// <summary>
        /// Gets or Sets BuildTypes
        /// </summary>
        [DataMember(Name="buildTypes", EmitDefaultValue=false)]
        public BuildTypesDto BuildTypes { get; set; }

        /// <summary>
        /// Gets or Sets BuildType
        /// </summary>
        [DataMember(Name="buildType", EmitDefaultValue=false)]
        public BuildTypeDto BuildType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProblemScopeDto {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  BuildTypes: ").Append(BuildTypes).Append("\n");
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
            return this.Equals(input as ProblemScopeDto);
        }

        /// <summary>
        /// Returns true if ProblemScopeDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ProblemScopeDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProblemScopeDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.BuildTypes == input.BuildTypes ||
                    (this.BuildTypes != null &&
                    this.BuildTypes.Equals(input.BuildTypes))
                ) && 
                (
                    this.BuildType == input.BuildType ||
                    (this.BuildType != null &&
                    this.BuildType.Equals(input.BuildType))
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
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.BuildTypes != null)
                    hashCode = hashCode * 59 + this.BuildTypes.GetHashCode();
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
