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
    /// VcsRootInstanceDto
    /// </summary>
    [DataContract]
    public partial class VcsRootInstanceDto :  IEquatable<VcsRootInstanceDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VcsRootInstanceDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="vcsRootId">vcsRootId.</param>
        /// <param name="vcsRootInternalId">vcsRootInternalId.</param>
        /// <param name="name">name.</param>
        /// <param name="vcsName">vcsName.</param>
        /// <param name="modificationCheckInterval">modificationCheckInterval.</param>
        /// <param name="commitHookMode">commitHookMode.</param>
        /// <param name="lastVersion">lastVersion.</param>
        /// <param name="lastVersionInternal">lastVersionInternal.</param>
        /// <param name="href">href.</param>
        /// <param name="vcsRoot">vcsRoot.</param>
        /// <param name="status">status.</param>
        /// <param name="repositoryState">repositoryState.</param>
        /// <param name="properties">properties.</param>
        /// <param name="repositoryIdStrings">repositoryIdStrings.</param>
        /// <param name="projectLocator">projectLocator.</param>
        public VcsRootInstanceDto(string id = default(string), string vcsRootId = default(string), string vcsRootInternalId = default(string), string name = default(string), string vcsName = default(string), int? modificationCheckInterval = default(int?), bool? commitHookMode = default(bool?), string lastVersion = default(string), string lastVersionInternal = default(string), string href = default(string), VcsRootDto vcsRoot = default(VcsRootDto), VcsStatusDto status = default(VcsStatusDto), RepositoryStateDto repositoryState = default(RepositoryStateDto), PropertiesDto properties = default(PropertiesDto), ItemsDto repositoryIdStrings = default(ItemsDto), string projectLocator = default(string))
        {
            this.Id = id;
            this.VcsRootId = vcsRootId;
            this.VcsRootInternalId = vcsRootInternalId;
            this.Name = name;
            this.VcsName = vcsName;
            this.ModificationCheckInterval = modificationCheckInterval;
            this.CommitHookMode = commitHookMode;
            this.LastVersion = lastVersion;
            this.LastVersionInternal = lastVersionInternal;
            this.Href = href;
            this.VcsRoot = vcsRoot;
            this.Status = status;
            this.RepositoryState = repositoryState;
            this.Properties = properties;
            this.RepositoryIdStrings = repositoryIdStrings;
            this.ProjectLocator = projectLocator;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets VcsRootId
        /// </summary>
        [DataMember(Name="vcs-root-id", EmitDefaultValue=false)]
        public string VcsRootId { get; set; }

        /// <summary>
        /// Gets or Sets VcsRootInternalId
        /// </summary>
        [DataMember(Name="vcsRootInternalId", EmitDefaultValue=false)]
        public string VcsRootInternalId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets VcsName
        /// </summary>
        [DataMember(Name="vcsName", EmitDefaultValue=false)]
        public string VcsName { get; set; }

        /// <summary>
        /// Gets or Sets ModificationCheckInterval
        /// </summary>
        [DataMember(Name="modificationCheckInterval", EmitDefaultValue=false)]
        public int? ModificationCheckInterval { get; set; }

        /// <summary>
        /// Gets or Sets CommitHookMode
        /// </summary>
        [DataMember(Name="commitHookMode", EmitDefaultValue=false)]
        public bool? CommitHookMode { get; set; }

        /// <summary>
        /// Gets or Sets LastVersion
        /// </summary>
        [DataMember(Name="lastVersion", EmitDefaultValue=false)]
        public string LastVersion { get; set; }

        /// <summary>
        /// Gets or Sets LastVersionInternal
        /// </summary>
        [DataMember(Name="lastVersionInternal", EmitDefaultValue=false)]
        public string LastVersionInternal { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets VcsRoot
        /// </summary>
        [DataMember(Name="vcs-root", EmitDefaultValue=false)]
        public VcsRootDto VcsRoot { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public VcsStatusDto Status { get; set; }

        /// <summary>
        /// Gets or Sets RepositoryState
        /// </summary>
        [DataMember(Name="repositoryState", EmitDefaultValue=false)]
        public RepositoryStateDto RepositoryState { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public PropertiesDto Properties { get; set; }

        /// <summary>
        /// Gets or Sets RepositoryIdStrings
        /// </summary>
        [DataMember(Name="repositoryIdStrings", EmitDefaultValue=false)]
        public ItemsDto RepositoryIdStrings { get; set; }

        /// <summary>
        /// Gets or Sets ProjectLocator
        /// </summary>
        [DataMember(Name="projectLocator", EmitDefaultValue=false)]
        public string ProjectLocator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VcsRootInstanceDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VcsRootId: ").Append(VcsRootId).Append("\n");
            sb.Append("  VcsRootInternalId: ").Append(VcsRootInternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VcsName: ").Append(VcsName).Append("\n");
            sb.Append("  ModificationCheckInterval: ").Append(ModificationCheckInterval).Append("\n");
            sb.Append("  CommitHookMode: ").Append(CommitHookMode).Append("\n");
            sb.Append("  LastVersion: ").Append(LastVersion).Append("\n");
            sb.Append("  LastVersionInternal: ").Append(LastVersionInternal).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  VcsRoot: ").Append(VcsRoot).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RepositoryState: ").Append(RepositoryState).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  RepositoryIdStrings: ").Append(RepositoryIdStrings).Append("\n");
            sb.Append("  ProjectLocator: ").Append(ProjectLocator).Append("\n");
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
            return this.Equals(input as VcsRootInstanceDto);
        }

        /// <summary>
        /// Returns true if VcsRootInstanceDto instances are equal
        /// </summary>
        /// <param name="input">Instance of VcsRootInstanceDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VcsRootInstanceDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.VcsRootId == input.VcsRootId ||
                    (this.VcsRootId != null &&
                    this.VcsRootId.Equals(input.VcsRootId))
                ) && 
                (
                    this.VcsRootInternalId == input.VcsRootInternalId ||
                    (this.VcsRootInternalId != null &&
                    this.VcsRootInternalId.Equals(input.VcsRootInternalId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.VcsName == input.VcsName ||
                    (this.VcsName != null &&
                    this.VcsName.Equals(input.VcsName))
                ) && 
                (
                    this.ModificationCheckInterval == input.ModificationCheckInterval ||
                    (this.ModificationCheckInterval != null &&
                    this.ModificationCheckInterval.Equals(input.ModificationCheckInterval))
                ) && 
                (
                    this.CommitHookMode == input.CommitHookMode ||
                    (this.CommitHookMode != null &&
                    this.CommitHookMode.Equals(input.CommitHookMode))
                ) && 
                (
                    this.LastVersion == input.LastVersion ||
                    (this.LastVersion != null &&
                    this.LastVersion.Equals(input.LastVersion))
                ) && 
                (
                    this.LastVersionInternal == input.LastVersionInternal ||
                    (this.LastVersionInternal != null &&
                    this.LastVersionInternal.Equals(input.LastVersionInternal))
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.VcsRoot == input.VcsRoot ||
                    (this.VcsRoot != null &&
                    this.VcsRoot.Equals(input.VcsRoot))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.RepositoryState == input.RepositoryState ||
                    (this.RepositoryState != null &&
                    this.RepositoryState.Equals(input.RepositoryState))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.RepositoryIdStrings == input.RepositoryIdStrings ||
                    (this.RepositoryIdStrings != null &&
                    this.RepositoryIdStrings.Equals(input.RepositoryIdStrings))
                ) && 
                (
                    this.ProjectLocator == input.ProjectLocator ||
                    (this.ProjectLocator != null &&
                    this.ProjectLocator.Equals(input.ProjectLocator))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.VcsRootId != null)
                    hashCode = hashCode * 59 + this.VcsRootId.GetHashCode();
                if (this.VcsRootInternalId != null)
                    hashCode = hashCode * 59 + this.VcsRootInternalId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.VcsName != null)
                    hashCode = hashCode * 59 + this.VcsName.GetHashCode();
                if (this.ModificationCheckInterval != null)
                    hashCode = hashCode * 59 + this.ModificationCheckInterval.GetHashCode();
                if (this.CommitHookMode != null)
                    hashCode = hashCode * 59 + this.CommitHookMode.GetHashCode();
                if (this.LastVersion != null)
                    hashCode = hashCode * 59 + this.LastVersion.GetHashCode();
                if (this.LastVersionInternal != null)
                    hashCode = hashCode * 59 + this.LastVersionInternal.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.VcsRoot != null)
                    hashCode = hashCode * 59 + this.VcsRoot.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RepositoryState != null)
                    hashCode = hashCode * 59 + this.RepositoryState.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.RepositoryIdStrings != null)
                    hashCode = hashCode * 59 + this.RepositoryIdStrings.GetHashCode();
                if (this.ProjectLocator != null)
                    hashCode = hashCode * 59 + this.ProjectLocator.GetHashCode();
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