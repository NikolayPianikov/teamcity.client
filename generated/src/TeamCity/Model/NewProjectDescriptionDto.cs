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
    /// NewProjectDescriptionDto
    /// </summary>
    [DataContract]
    public partial class NewProjectDescriptionDto :  IEquatable<NewProjectDescriptionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewProjectDescriptionDto" /> class.
        /// </summary>
        /// <param name="copyAllAssociatedSettings">copyAllAssociatedSettings.</param>
        /// <param name="projectsIdsMap">projectsIdsMap.</param>
        /// <param name="buildTypesIdsMap">buildTypesIdsMap.</param>
        /// <param name="vcsRootsIdsMap">vcsRootsIdsMap.</param>
        /// <param name="name">name.</param>
        /// <param name="id">id.</param>
        /// <param name="sourceProjectLocator">sourceProjectLocator.</param>
        /// <param name="sourceProject">sourceProject.</param>
        /// <param name="parentProject">parentProject.</param>
        public NewProjectDescriptionDto(bool? copyAllAssociatedSettings = default(bool?), PropertiesDto projectsIdsMap = default(PropertiesDto), PropertiesDto buildTypesIdsMap = default(PropertiesDto), PropertiesDto vcsRootsIdsMap = default(PropertiesDto), string name = default(string), string id = default(string), string sourceProjectLocator = default(string), ProjectDto sourceProject = default(ProjectDto), ProjectDto parentProject = default(ProjectDto))
        {
            this.CopyAllAssociatedSettings = copyAllAssociatedSettings;
            this.ProjectsIdsMap = projectsIdsMap;
            this.BuildTypesIdsMap = buildTypesIdsMap;
            this.VcsRootsIdsMap = vcsRootsIdsMap;
            this.Name = name;
            this.Id = id;
            this.SourceProjectLocator = sourceProjectLocator;
            this.SourceProject = sourceProject;
            this.ParentProject = parentProject;
        }
        
        /// <summary>
        /// Gets or Sets CopyAllAssociatedSettings
        /// </summary>
        [DataMember(Name="copyAllAssociatedSettings", EmitDefaultValue=false)]
        public bool? CopyAllAssociatedSettings { get; set; }

        /// <summary>
        /// Gets or Sets ProjectsIdsMap
        /// </summary>
        [DataMember(Name="projectsIdsMap", EmitDefaultValue=false)]
        public PropertiesDto ProjectsIdsMap { get; set; }

        /// <summary>
        /// Gets or Sets BuildTypesIdsMap
        /// </summary>
        [DataMember(Name="buildTypesIdsMap", EmitDefaultValue=false)]
        public PropertiesDto BuildTypesIdsMap { get; set; }

        /// <summary>
        /// Gets or Sets VcsRootsIdsMap
        /// </summary>
        [DataMember(Name="vcsRootsIdsMap", EmitDefaultValue=false)]
        public PropertiesDto VcsRootsIdsMap { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets SourceProjectLocator
        /// </summary>
        [DataMember(Name="sourceProjectLocator", EmitDefaultValue=false)]
        public string SourceProjectLocator { get; set; }

        /// <summary>
        /// Gets or Sets SourceProject
        /// </summary>
        [DataMember(Name="sourceProject", EmitDefaultValue=false)]
        public ProjectDto SourceProject { get; set; }

        /// <summary>
        /// Gets or Sets ParentProject
        /// </summary>
        [DataMember(Name="parentProject", EmitDefaultValue=false)]
        public ProjectDto ParentProject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewProjectDescriptionDto {\n");
            sb.Append("  CopyAllAssociatedSettings: ").Append(CopyAllAssociatedSettings).Append("\n");
            sb.Append("  ProjectsIdsMap: ").Append(ProjectsIdsMap).Append("\n");
            sb.Append("  BuildTypesIdsMap: ").Append(BuildTypesIdsMap).Append("\n");
            sb.Append("  VcsRootsIdsMap: ").Append(VcsRootsIdsMap).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SourceProjectLocator: ").Append(SourceProjectLocator).Append("\n");
            sb.Append("  SourceProject: ").Append(SourceProject).Append("\n");
            sb.Append("  ParentProject: ").Append(ParentProject).Append("\n");
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
            return this.Equals(input as NewProjectDescriptionDto);
        }

        /// <summary>
        /// Returns true if NewProjectDescriptionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of NewProjectDescriptionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewProjectDescriptionDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CopyAllAssociatedSettings == input.CopyAllAssociatedSettings ||
                    (this.CopyAllAssociatedSettings != null &&
                    this.CopyAllAssociatedSettings.Equals(input.CopyAllAssociatedSettings))
                ) && 
                (
                    this.ProjectsIdsMap == input.ProjectsIdsMap ||
                    (this.ProjectsIdsMap != null &&
                    this.ProjectsIdsMap.Equals(input.ProjectsIdsMap))
                ) && 
                (
                    this.BuildTypesIdsMap == input.BuildTypesIdsMap ||
                    (this.BuildTypesIdsMap != null &&
                    this.BuildTypesIdsMap.Equals(input.BuildTypesIdsMap))
                ) && 
                (
                    this.VcsRootsIdsMap == input.VcsRootsIdsMap ||
                    (this.VcsRootsIdsMap != null &&
                    this.VcsRootsIdsMap.Equals(input.VcsRootsIdsMap))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SourceProjectLocator == input.SourceProjectLocator ||
                    (this.SourceProjectLocator != null &&
                    this.SourceProjectLocator.Equals(input.SourceProjectLocator))
                ) && 
                (
                    this.SourceProject == input.SourceProject ||
                    (this.SourceProject != null &&
                    this.SourceProject.Equals(input.SourceProject))
                ) && 
                (
                    this.ParentProject == input.ParentProject ||
                    (this.ParentProject != null &&
                    this.ParentProject.Equals(input.ParentProject))
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
                if (this.CopyAllAssociatedSettings != null)
                    hashCode = hashCode * 59 + this.CopyAllAssociatedSettings.GetHashCode();
                if (this.ProjectsIdsMap != null)
                    hashCode = hashCode * 59 + this.ProjectsIdsMap.GetHashCode();
                if (this.BuildTypesIdsMap != null)
                    hashCode = hashCode * 59 + this.BuildTypesIdsMap.GetHashCode();
                if (this.VcsRootsIdsMap != null)
                    hashCode = hashCode * 59 + this.VcsRootsIdsMap.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SourceProjectLocator != null)
                    hashCode = hashCode * 59 + this.SourceProjectLocator.GetHashCode();
                if (this.SourceProject != null)
                    hashCode = hashCode * 59 + this.SourceProject.GetHashCode();
                if (this.ParentProject != null)
                    hashCode = hashCode * 59 + this.ParentProject.GetHashCode();
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
