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
    /// ProblemOccurrenceLocatorDto
    /// </summary>
    [DataContract]
    public partial class ProblemOccurrenceLocatorDto :  IEquatable<ProblemOccurrenceLocatorDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProblemOccurrenceLocatorDto" /> class.
        /// </summary>
        /// <param name="affectedProject">affectedProject.</param>
        /// <param name="build">build.</param>
        /// <param name="count">count.</param>
        /// <param name="currentlyFailing">currentlyFailing.</param>
        /// <param name="currentlyInvestigated">currentlyInvestigated.</param>
        /// <param name="currentlyMuted">currentlyMuted.</param>
        /// <param name="identity">identity.</param>
        /// <param name="lookupLimit">lookupLimit.</param>
        /// <param name="muted">muted.</param>
        /// <param name="problem">problem.</param>
        /// <param name="start">start.</param>
        /// <param name="type">type.</param>
        public ProblemOccurrenceLocatorDto(string affectedProject = default(string), string build = default(string), string count = default(string), string currentlyFailing = default(string), string currentlyInvestigated = default(string), string currentlyMuted = default(string), string identity = default(string), string lookupLimit = default(string), string muted = default(string), string problem = default(string), string start = default(string), string type = default(string))
        {
            this.AffectedProject = affectedProject;
            this.Build = build;
            this.Count = count;
            this.CurrentlyFailing = currentlyFailing;
            this.CurrentlyInvestigated = currentlyInvestigated;
            this.CurrentlyMuted = currentlyMuted;
            this.Identity = identity;
            this.LookupLimit = lookupLimit;
            this.Muted = muted;
            this.Problem = problem;
            this.Start = start;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets AffectedProject
        /// </summary>
        [DataMember(Name="affectedProject", EmitDefaultValue=false)]
        public string AffectedProject { get; set; }

        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [DataMember(Name="build", EmitDefaultValue=false)]
        public string Build { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public string Count { get; set; }

        /// <summary>
        /// Gets or Sets CurrentlyFailing
        /// </summary>
        [DataMember(Name="currentlyFailing", EmitDefaultValue=false)]
        public string CurrentlyFailing { get; set; }

        /// <summary>
        /// Gets or Sets CurrentlyInvestigated
        /// </summary>
        [DataMember(Name="currentlyInvestigated", EmitDefaultValue=false)]
        public string CurrentlyInvestigated { get; set; }

        /// <summary>
        /// Gets or Sets CurrentlyMuted
        /// </summary>
        [DataMember(Name="currentlyMuted", EmitDefaultValue=false)]
        public string CurrentlyMuted { get; set; }

        /// <summary>
        /// Gets or Sets Identity
        /// </summary>
        [DataMember(Name="identity", EmitDefaultValue=false)]
        public string Identity { get; set; }

        /// <summary>
        /// Gets or Sets LookupLimit
        /// </summary>
        [DataMember(Name="lookupLimit", EmitDefaultValue=false)]
        public string LookupLimit { get; set; }

        /// <summary>
        /// Gets or Sets Muted
        /// </summary>
        [DataMember(Name="muted", EmitDefaultValue=false)]
        public string Muted { get; set; }

        /// <summary>
        /// Gets or Sets Problem
        /// </summary>
        [DataMember(Name="problem", EmitDefaultValue=false)]
        public string Problem { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public string Start { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProblemOccurrenceLocatorDto {\n");
            sb.Append("  AffectedProject: ").Append(AffectedProject).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  CurrentlyFailing: ").Append(CurrentlyFailing).Append("\n");
            sb.Append("  CurrentlyInvestigated: ").Append(CurrentlyInvestigated).Append("\n");
            sb.Append("  CurrentlyMuted: ").Append(CurrentlyMuted).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  LookupLimit: ").Append(LookupLimit).Append("\n");
            sb.Append("  Muted: ").Append(Muted).Append("\n");
            sb.Append("  Problem: ").Append(Problem).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ProblemOccurrenceLocatorDto);
        }

        /// <summary>
        /// Returns true if ProblemOccurrenceLocatorDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ProblemOccurrenceLocatorDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProblemOccurrenceLocatorDto input)
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
                    this.Build == input.Build ||
                    (this.Build != null &&
                    this.Build.Equals(input.Build))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.CurrentlyFailing == input.CurrentlyFailing ||
                    (this.CurrentlyFailing != null &&
                    this.CurrentlyFailing.Equals(input.CurrentlyFailing))
                ) && 
                (
                    this.CurrentlyInvestigated == input.CurrentlyInvestigated ||
                    (this.CurrentlyInvestigated != null &&
                    this.CurrentlyInvestigated.Equals(input.CurrentlyInvestigated))
                ) && 
                (
                    this.CurrentlyMuted == input.CurrentlyMuted ||
                    (this.CurrentlyMuted != null &&
                    this.CurrentlyMuted.Equals(input.CurrentlyMuted))
                ) && 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
                ) && 
                (
                    this.LookupLimit == input.LookupLimit ||
                    (this.LookupLimit != null &&
                    this.LookupLimit.Equals(input.LookupLimit))
                ) && 
                (
                    this.Muted == input.Muted ||
                    (this.Muted != null &&
                    this.Muted.Equals(input.Muted))
                ) && 
                (
                    this.Problem == input.Problem ||
                    (this.Problem != null &&
                    this.Problem.Equals(input.Problem))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Build != null)
                    hashCode = hashCode * 59 + this.Build.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.CurrentlyFailing != null)
                    hashCode = hashCode * 59 + this.CurrentlyFailing.GetHashCode();
                if (this.CurrentlyInvestigated != null)
                    hashCode = hashCode * 59 + this.CurrentlyInvestigated.GetHashCode();
                if (this.CurrentlyMuted != null)
                    hashCode = hashCode * 59 + this.CurrentlyMuted.GetHashCode();
                if (this.Identity != null)
                    hashCode = hashCode * 59 + this.Identity.GetHashCode();
                if (this.LookupLimit != null)
                    hashCode = hashCode * 59 + this.LookupLimit.GetHashCode();
                if (this.Muted != null)
                    hashCode = hashCode * 59 + this.Muted.GetHashCode();
                if (this.Problem != null)
                    hashCode = hashCode * 59 + this.Problem.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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