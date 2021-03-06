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
    /// ChangeLocatorDto
    /// </summary>
    [DataContract]
    public partial class ChangeLocatorDto :  IEquatable<ChangeLocatorDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeLocatorDto" /> class.
        /// </summary>
        /// <param name="singleValue">singleValue.</param>
        /// <param name="build">build.</param>
        /// <param name="buildType">buildType.</param>
        /// <param name="comment">comment.</param>
        /// <param name="count">count.</param>
        /// <param name="_file">_file.</param>
        /// <param name="id">id.</param>
        /// <param name="internalVersion">internalVersion.</param>
        /// <param name="pending">pending.</param>
        /// <param name="project">project.</param>
        /// <param name="sinceChange">sinceChange.</param>
        /// <param name="start">start.</param>
        /// <param name="user">user.</param>
        /// <param name="username">username.</param>
        /// <param name="vcsRoot">vcsRoot.</param>
        /// <param name="vcsRootInstance">vcsRootInstance.</param>
        /// <param name="version">version.</param>
        public ChangeLocatorDto(string singleValue = default(string), string build = default(string), string buildType = default(string), string comment = default(string), string count = default(string), string _file = default(string), string id = default(string), string internalVersion = default(string), string pending = default(string), string project = default(string), string sinceChange = default(string), string start = default(string), string user = default(string), string username = default(string), string vcsRoot = default(string), string vcsRootInstance = default(string), string version = default(string))
        {
            this.SingleValue = singleValue;
            this.Build = build;
            this.BuildType = buildType;
            this.Comment = comment;
            this.Count = count;
            this._File = _file;
            this.Id = id;
            this.InternalVersion = internalVersion;
            this.Pending = pending;
            this.Project = project;
            this.SinceChange = sinceChange;
            this.Start = start;
            this.User = user;
            this.Username = username;
            this.VcsRoot = vcsRoot;
            this.VcsRootInstance = vcsRootInstance;
            this.Version = version;
        }
        
        /// <summary>
        /// Gets or Sets SingleValue
        /// </summary>
        [DataMember(Name="$singleValue", EmitDefaultValue=false)]
        public string SingleValue { get; set; }

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
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public string Count { get; set; }

        /// <summary>
        /// Gets or Sets _File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public string _File { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets InternalVersion
        /// </summary>
        [DataMember(Name="internalVersion", EmitDefaultValue=false)]
        public string InternalVersion { get; set; }

        /// <summary>
        /// Gets or Sets Pending
        /// </summary>
        [DataMember(Name="pending", EmitDefaultValue=false)]
        public string Pending { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }

        /// <summary>
        /// Gets or Sets SinceChange
        /// </summary>
        [DataMember(Name="sinceChange", EmitDefaultValue=false)]
        public string SinceChange { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public string Start { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

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
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeLocatorDto {\n");
            sb.Append("  SingleValue: ").Append(SingleValue).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
            sb.Append("  BuildType: ").Append(BuildType).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  _File: ").Append(_File).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InternalVersion: ").Append(InternalVersion).Append("\n");
            sb.Append("  Pending: ").Append(Pending).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  SinceChange: ").Append(SinceChange).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  VcsRoot: ").Append(VcsRoot).Append("\n");
            sb.Append("  VcsRootInstance: ").Append(VcsRootInstance).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as ChangeLocatorDto);
        }

        /// <summary>
        /// Returns true if ChangeLocatorDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeLocatorDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeLocatorDto input)
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
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this._File == input._File ||
                    (this._File != null &&
                    this._File.Equals(input._File))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InternalVersion == input.InternalVersion ||
                    (this.InternalVersion != null &&
                    this.InternalVersion.Equals(input.InternalVersion))
                ) && 
                (
                    this.Pending == input.Pending ||
                    (this.Pending != null &&
                    this.Pending.Equals(input.Pending))
                ) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.SinceChange == input.SinceChange ||
                    (this.SinceChange != null &&
                    this.SinceChange.Equals(input.SinceChange))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Build != null)
                    hashCode = hashCode * 59 + this.Build.GetHashCode();
                if (this.BuildType != null)
                    hashCode = hashCode * 59 + this.BuildType.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this._File != null)
                    hashCode = hashCode * 59 + this._File.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InternalVersion != null)
                    hashCode = hashCode * 59 + this.InternalVersion.GetHashCode();
                if (this.Pending != null)
                    hashCode = hashCode * 59 + this.Pending.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.SinceChange != null)
                    hashCode = hashCode * 59 + this.SinceChange.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.VcsRoot != null)
                    hashCode = hashCode * 59 + this.VcsRoot.GetHashCode();
                if (this.VcsRootInstance != null)
                    hashCode = hashCode * 59 + this.VcsRootInstance.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
