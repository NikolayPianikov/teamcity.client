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
    /// TestOccurrenceLocatorDto
    /// </summary>
    [DataContract]
    public partial class TestOccurrenceLocatorDto :  IEquatable<TestOccurrenceLocatorDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestOccurrenceLocatorDto" /> class.
        /// </summary>
        /// <param name="affectedProject">affectedProject.</param>
        /// <param name="branch">branch.</param>
        /// <param name="build">build.</param>
        /// <param name="buildType">buildType.</param>
        /// <param name="count">count.</param>
        /// <param name="currentlyFailing">currentlyFailing.</param>
        /// <param name="currentlyInvestigated">currentlyInvestigated.</param>
        /// <param name="currentlyMuted">currentlyMuted.</param>
        /// <param name="id">id.</param>
        /// <param name="ignored">ignored.</param>
        /// <param name="includePersonal">includePersonal.</param>
        /// <param name="lookupLimit">lookupLimit.</param>
        /// <param name="muted">muted.</param>
        /// <param name="name">name.</param>
        /// <param name="newFailure">newFailure.</param>
        /// <param name="start">start.</param>
        /// <param name="status">status.</param>
        /// <param name="test">test.</param>
        public TestOccurrenceLocatorDto(string affectedProject = default(string), string branch = default(string), string build = default(string), string buildType = default(string), string count = default(string), string currentlyFailing = default(string), string currentlyInvestigated = default(string), string currentlyMuted = default(string), string id = default(string), string ignored = default(string), string includePersonal = default(string), string lookupLimit = default(string), string muted = default(string), string name = default(string), string newFailure = default(string), string start = default(string), string status = default(string), string test = default(string))
        {
            this.AffectedProject = affectedProject;
            this.Branch = branch;
            this.Build = build;
            this.BuildType = buildType;
            this.Count = count;
            this.CurrentlyFailing = currentlyFailing;
            this.CurrentlyInvestigated = currentlyInvestigated;
            this.CurrentlyMuted = currentlyMuted;
            this.Id = id;
            this.Ignored = ignored;
            this.IncludePersonal = includePersonal;
            this.LookupLimit = lookupLimit;
            this.Muted = muted;
            this.Name = name;
            this.NewFailure = newFailure;
            this.Start = start;
            this.Status = status;
            this.Test = test;
        }
        
        /// <summary>
        /// Gets or Sets AffectedProject
        /// </summary>
        [DataMember(Name="affectedProject", EmitDefaultValue=false)]
        public string AffectedProject { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="branch", EmitDefaultValue=false)]
        public string Branch { get; set; }

        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [DataMember(Name="build", EmitDefaultValue=false)]
        public string Build { get; set; }

        /// <summary>
        /// Gets or Sets BuildType
        /// </summary>
        [DataMember(Name="buildType", EmitDefaultValue=false)]
        public string BuildType { get; set; }

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
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Ignored
        /// </summary>
        [DataMember(Name="ignored", EmitDefaultValue=false)]
        public string Ignored { get; set; }

        /// <summary>
        /// Gets or Sets IncludePersonal
        /// </summary>
        [DataMember(Name="includePersonal", EmitDefaultValue=false)]
        public string IncludePersonal { get; set; }

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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NewFailure
        /// </summary>
        [DataMember(Name="newFailure", EmitDefaultValue=false)]
        public string NewFailure { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public string Start { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Test
        /// </summary>
        [DataMember(Name="test", EmitDefaultValue=false)]
        public string Test { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestOccurrenceLocatorDto {\n");
            sb.Append("  AffectedProject: ").Append(AffectedProject).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
            sb.Append("  BuildType: ").Append(BuildType).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  CurrentlyFailing: ").Append(CurrentlyFailing).Append("\n");
            sb.Append("  CurrentlyInvestigated: ").Append(CurrentlyInvestigated).Append("\n");
            sb.Append("  CurrentlyMuted: ").Append(CurrentlyMuted).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Ignored: ").Append(Ignored).Append("\n");
            sb.Append("  IncludePersonal: ").Append(IncludePersonal).Append("\n");
            sb.Append("  LookupLimit: ").Append(LookupLimit).Append("\n");
            sb.Append("  Muted: ").Append(Muted).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NewFailure: ").Append(NewFailure).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Test: ").Append(Test).Append("\n");
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
            return this.Equals(input as TestOccurrenceLocatorDto);
        }

        /// <summary>
        /// Returns true if TestOccurrenceLocatorDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TestOccurrenceLocatorDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestOccurrenceLocatorDto input)
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
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && 
                (
                    this.Build == input.Build ||
                    (this.Build != null &&
                    this.Build.Equals(input.Build))
                ) && 
                (
                    this.BuildType == input.BuildType ||
                    (this.BuildType != null &&
                    this.BuildType.Equals(input.BuildType))
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Ignored == input.Ignored ||
                    (this.Ignored != null &&
                    this.Ignored.Equals(input.Ignored))
                ) && 
                (
                    this.IncludePersonal == input.IncludePersonal ||
                    (this.IncludePersonal != null &&
                    this.IncludePersonal.Equals(input.IncludePersonal))
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NewFailure == input.NewFailure ||
                    (this.NewFailure != null &&
                    this.NewFailure.Equals(input.NewFailure))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Test == input.Test ||
                    (this.Test != null &&
                    this.Test.Equals(input.Test))
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
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.Build != null)
                    hashCode = hashCode * 59 + this.Build.GetHashCode();
                if (this.BuildType != null)
                    hashCode = hashCode * 59 + this.BuildType.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.CurrentlyFailing != null)
                    hashCode = hashCode * 59 + this.CurrentlyFailing.GetHashCode();
                if (this.CurrentlyInvestigated != null)
                    hashCode = hashCode * 59 + this.CurrentlyInvestigated.GetHashCode();
                if (this.CurrentlyMuted != null)
                    hashCode = hashCode * 59 + this.CurrentlyMuted.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Ignored != null)
                    hashCode = hashCode * 59 + this.Ignored.GetHashCode();
                if (this.IncludePersonal != null)
                    hashCode = hashCode * 59 + this.IncludePersonal.GetHashCode();
                if (this.LookupLimit != null)
                    hashCode = hashCode * 59 + this.LookupLimit.GetHashCode();
                if (this.Muted != null)
                    hashCode = hashCode * 59 + this.Muted.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NewFailure != null)
                    hashCode = hashCode * 59 + this.NewFailure.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Test != null)
                    hashCode = hashCode * 59 + this.Test.GetHashCode();
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
