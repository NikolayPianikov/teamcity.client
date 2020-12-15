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
    /// CustomizationsDto
    /// </summary>
    [DataContract]
    public partial class CustomizationsDto :  IEquatable<CustomizationsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomizationsDto" /> class.
        /// </summary>
        /// <param name="parameters">parameters.</param>
        /// <param name="changes">changes.</param>
        /// <param name="artifactDependencies">artifactDependencies.</param>
        public CustomizationsDto(Dictionary<string, string> parameters = default(Dictionary<string, string>), Dictionary<string, string> changes = default(Dictionary<string, string>), Dictionary<string, string> artifactDependencies = default(Dictionary<string, string>))
        {
            this.Parameters = parameters;
            this.Changes = changes;
            this.ArtifactDependencies = artifactDependencies;
        }
        
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets Changes
        /// </summary>
        [DataMember(Name="changes", EmitDefaultValue=false)]
        public Dictionary<string, string> Changes { get; set; }

        /// <summary>
        /// Gets or Sets ArtifactDependencies
        /// </summary>
        [DataMember(Name="artifactDependencies", EmitDefaultValue=false)]
        public Dictionary<string, string> ArtifactDependencies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomizationsDto {\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
            sb.Append("  ArtifactDependencies: ").Append(ArtifactDependencies).Append("\n");
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
            return this.Equals(input as CustomizationsDto);
        }

        /// <summary>
        /// Returns true if CustomizationsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomizationsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomizationsDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.Changes == input.Changes ||
                    this.Changes != null &&
                    this.Changes.SequenceEqual(input.Changes)
                ) && 
                (
                    this.ArtifactDependencies == input.ArtifactDependencies ||
                    this.ArtifactDependencies != null &&
                    this.ArtifactDependencies.SequenceEqual(input.ArtifactDependencies)
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
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Changes != null)
                    hashCode = hashCode * 59 + this.Changes.GetHashCode();
                if (this.ArtifactDependencies != null)
                    hashCode = hashCode * 59 + this.ArtifactDependencies.GetHashCode();
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
