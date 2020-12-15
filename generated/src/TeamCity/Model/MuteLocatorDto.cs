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
    /// MuteLocatorDto
    /// </summary>
    [DataContract]
    public partial class MuteLocatorDto :  IEquatable<MuteLocatorDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MuteLocatorDto" /> class.
        /// </summary>
        /// <param name="affectedProject">affectedProject.</param>
        /// <param name="creationDate">creationDate.</param>
        /// <param name="id">id.</param>
        /// <param name="problem">problem.</param>
        /// <param name="project">project.</param>
        /// <param name="reporter">reporter.</param>
        /// <param name="resolution">resolution.</param>
        /// <param name="test">test.</param>
        /// <param name="type">type.</param>
        /// <param name="unmuteDate">unmuteDate.</param>
        public MuteLocatorDto(string affectedProject = default(string), string creationDate = default(string), string id = default(string), string problem = default(string), string project = default(string), string reporter = default(string), string resolution = default(string), string test = default(string), string type = default(string), string unmuteDate = default(string))
        {
            this.AffectedProject = affectedProject;
            this.CreationDate = creationDate;
            this.Id = id;
            this.Problem = problem;
            this.Project = project;
            this.Reporter = reporter;
            this.Resolution = resolution;
            this.Test = test;
            this.Type = type;
            this.UnmuteDate = unmuteDate;
        }
        
        /// <summary>
        /// Gets or Sets AffectedProject
        /// </summary>
        [DataMember(Name="affectedProject", EmitDefaultValue=false)]
        public string AffectedProject { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public string CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Problem
        /// </summary>
        [DataMember(Name="problem", EmitDefaultValue=false)]
        public string Problem { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }

        /// <summary>
        /// Gets or Sets Reporter
        /// </summary>
        [DataMember(Name="reporter", EmitDefaultValue=false)]
        public string Reporter { get; set; }

        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// Gets or Sets Test
        /// </summary>
        [DataMember(Name="test", EmitDefaultValue=false)]
        public string Test { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets UnmuteDate
        /// </summary>
        [DataMember(Name="unmuteDate", EmitDefaultValue=false)]
        public string UnmuteDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MuteLocatorDto {\n");
            sb.Append("  AffectedProject: ").Append(AffectedProject).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Problem: ").Append(Problem).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Reporter: ").Append(Reporter).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  Test: ").Append(Test).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UnmuteDate: ").Append(UnmuteDate).Append("\n");
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
            return this.Equals(input as MuteLocatorDto);
        }

        /// <summary>
        /// Returns true if MuteLocatorDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MuteLocatorDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MuteLocatorDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AffectedProject == input.AffectedProject ||
                    (this.AffectedProject != null &&
                    this.AffectedProject.Equals(input.AffectedProject))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Problem == input.Problem ||
                    (this.Problem != null &&
                    this.Problem.Equals(input.Problem))
                ) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.Reporter == input.Reporter ||
                    (this.Reporter != null &&
                    this.Reporter.Equals(input.Reporter))
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    (this.Resolution != null &&
                    this.Resolution.Equals(input.Resolution))
                ) && 
                (
                    this.Test == input.Test ||
                    (this.Test != null &&
                    this.Test.Equals(input.Test))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UnmuteDate == input.UnmuteDate ||
                    (this.UnmuteDate != null &&
                    this.UnmuteDate.Equals(input.UnmuteDate))
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
                if (this.AffectedProject != null)
                    hashCode = hashCode * 59 + this.AffectedProject.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Problem != null)
                    hashCode = hashCode * 59 + this.Problem.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.Reporter != null)
                    hashCode = hashCode * 59 + this.Reporter.GetHashCode();
                if (this.Resolution != null)
                    hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.Test != null)
                    hashCode = hashCode * 59 + this.Test.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UnmuteDate != null)
                    hashCode = hashCode * 59 + this.UnmuteDate.GetHashCode();
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