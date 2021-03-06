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
    /// BuildTypeLocatorDto
    /// </summary>
    [DataContract]
    public partial class BuildTypeLocatorDto :  IEquatable<BuildTypeLocatorDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildTypeLocatorDto" /> class.
        /// </summary>
        /// <param name="singleValue">singleValue.</param>
        /// <param name="affectedProject">affectedProject.</param>
        /// <param name="build">build.</param>
        /// <param name="count">count.</param>
        /// <param name="id">id.</param>
        /// <param name="internalId">internalId.</param>
        /// <param name="name">name.</param>
        /// <param name="paused">paused.</param>
        /// <param name="project">project.</param>
        /// <param name="start">start.</param>
        /// <param name="template">template.</param>
        /// <param name="templateFlag">templateFlag.</param>
        /// <param name="uuid">uuid.</param>
        /// <param name="vcsRoot">vcsRoot.</param>
        /// <param name="vcsRootInstance">vcsRootInstance.</param>
        public BuildTypeLocatorDto(string singleValue = default(string), string affectedProject = default(string), string build = default(string), string count = default(string), string id = default(string), string internalId = default(string), string name = default(string), string paused = default(string), string project = default(string), string start = default(string), string template = default(string), string templateFlag = default(string), string uuid = default(string), string vcsRoot = default(string), string vcsRootInstance = default(string))
        {
            this.SingleValue = singleValue;
            this.AffectedProject = affectedProject;
            this.Build = build;
            this.Count = count;
            this.Id = id;
            this.InternalId = internalId;
            this.Name = name;
            this.Paused = paused;
            this.Project = project;
            this.Start = start;
            this.Template = template;
            this.TemplateFlag = templateFlag;
            this.Uuid = uuid;
            this.VcsRoot = vcsRoot;
            this.VcsRootInstance = vcsRootInstance;
        }
        
        /// <summary>
        /// Gets or Sets SingleValue
        /// </summary>
        [DataMember(Name="$singleValue", EmitDefaultValue=false)]
        public string SingleValue { get; set; }

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
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets InternalId
        /// </summary>
        [DataMember(Name="internalId", EmitDefaultValue=false)]
        public string InternalId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Paused
        /// </summary>
        [DataMember(Name="paused", EmitDefaultValue=false)]
        public string Paused { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public string Start { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }

        /// <summary>
        /// Gets or Sets TemplateFlag
        /// </summary>
        [DataMember(Name="templateFlag", EmitDefaultValue=false)]
        public string TemplateFlag { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets VcsRoot
        /// </summary>
        [DataMember(Name="vcsRoot", EmitDefaultValue=false)]
        public string VcsRoot { get; set; }

        /// <summary>
        /// Gets or Sets VcsRootInstance
        /// </summary>
        [DataMember(Name="vcsRootInstance", EmitDefaultValue=false)]
        public string VcsRootInstance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildTypeLocatorDto {\n");
            sb.Append("  SingleValue: ").Append(SingleValue).Append("\n");
            sb.Append("  AffectedProject: ").Append(AffectedProject).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InternalId: ").Append(InternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Paused: ").Append(Paused).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  TemplateFlag: ").Append(TemplateFlag).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  VcsRoot: ").Append(VcsRoot).Append("\n");
            sb.Append("  VcsRootInstance: ").Append(VcsRootInstance).Append("\n");
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
            return this.Equals(input as BuildTypeLocatorDto);
        }

        /// <summary>
        /// Returns true if BuildTypeLocatorDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildTypeLocatorDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildTypeLocatorDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SingleValue == input.SingleValue ||
                    (this.SingleValue != null &&
                    this.SingleValue.Equals(input.SingleValue))
                ) && 
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InternalId == input.InternalId ||
                    (this.InternalId != null &&
                    this.InternalId.Equals(input.InternalId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Paused == input.Paused ||
                    (this.Paused != null &&
                    this.Paused.Equals(input.Paused))
                ) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.TemplateFlag == input.TemplateFlag ||
                    (this.TemplateFlag != null &&
                    this.TemplateFlag.Equals(input.TemplateFlag))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.VcsRoot == input.VcsRoot ||
                    (this.VcsRoot != null &&
                    this.VcsRoot.Equals(input.VcsRoot))
                ) && 
                (
                    this.VcsRootInstance == input.VcsRootInstance ||
                    (this.VcsRootInstance != null &&
                    this.VcsRootInstance.Equals(input.VcsRootInstance))
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
                if (this.SingleValue != null)
                    hashCode = hashCode * 59 + this.SingleValue.GetHashCode();
                if (this.AffectedProject != null)
                    hashCode = hashCode * 59 + this.AffectedProject.GetHashCode();
                if (this.Build != null)
                    hashCode = hashCode * 59 + this.Build.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InternalId != null)
                    hashCode = hashCode * 59 + this.InternalId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Paused != null)
                    hashCode = hashCode * 59 + this.Paused.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.TemplateFlag != null)
                    hashCode = hashCode * 59 + this.TemplateFlag.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.VcsRoot != null)
                    hashCode = hashCode * 59 + this.VcsRoot.GetHashCode();
                if (this.VcsRootInstance != null)
                    hashCode = hashCode * 59 + this.VcsRootInstance.GetHashCode();
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
