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
    /// BranchVersionDto
    /// </summary>
    [DataContract]
    public partial class BranchVersionDto :  IEquatable<BranchVersionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BranchVersionDto" /> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="unspecified">unspecified.</param>
        /// <param name="groupFlag">groupFlag.</param>
        /// <param name="lastActivity">lastActivity.</param>
        /// <param name="builds">builds.</param>
        /// <param name="internalName">internalName.</param>
        /// <param name="name">name.</param>
        /// <param name="_default">_default.</param>
        /// <param name="active">active.</param>
        public BranchVersionDto(string version = default(string), bool? unspecified = default(bool?), bool? groupFlag = default(bool?), string lastActivity = default(string), BuildsDto builds = default(BuildsDto), string internalName = default(string), string name = default(string), bool? _default = default(bool?), bool? active = default(bool?))
        {
            this.Version = version;
            this.Unspecified = unspecified;
            this.GroupFlag = groupFlag;
            this.LastActivity = lastActivity;
            this.Builds = builds;
            this.InternalName = internalName;
            this.Name = name;
            this.Default = _default;
            this.Active = active;
        }
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets Unspecified
        /// </summary>
        [DataMember(Name="unspecified", EmitDefaultValue=false)]
        public bool? Unspecified { get; set; }

        /// <summary>
        /// Gets or Sets GroupFlag
        /// </summary>
        [DataMember(Name="groupFlag", EmitDefaultValue=false)]
        public bool? GroupFlag { get; set; }

        /// <summary>
        /// Gets or Sets LastActivity
        /// </summary>
        [DataMember(Name="lastActivity", EmitDefaultValue=false)]
        public string LastActivity { get; set; }

        /// <summary>
        /// Gets or Sets Builds
        /// </summary>
        [DataMember(Name="builds", EmitDefaultValue=false)]
        public BuildsDto Builds { get; set; }

        /// <summary>
        /// Gets or Sets InternalName
        /// </summary>
        [DataMember(Name="internalName", EmitDefaultValue=false)]
        public string InternalName { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? Default { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BranchVersionDto {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Unspecified: ").Append(Unspecified).Append("\n");
            sb.Append("  GroupFlag: ").Append(GroupFlag).Append("\n");
            sb.Append("  LastActivity: ").Append(LastActivity).Append("\n");
            sb.Append("  Builds: ").Append(Builds).Append("\n");
            sb.Append("  InternalName: ").Append(InternalName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
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
            return this.Equals(input as BranchVersionDto);
        }

        /// <summary>
        /// Returns true if BranchVersionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BranchVersionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BranchVersionDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Unspecified == input.Unspecified ||
                    (this.Unspecified != null &&
                    this.Unspecified.Equals(input.Unspecified))
                ) && 
                (
                    this.GroupFlag == input.GroupFlag ||
                    (this.GroupFlag != null &&
                    this.GroupFlag.Equals(input.GroupFlag))
                ) && 
                (
                    this.LastActivity == input.LastActivity ||
                    (this.LastActivity != null &&
                    this.LastActivity.Equals(input.LastActivity))
                ) && 
                (
                    this.Builds == input.Builds ||
                    (this.Builds != null &&
                    this.Builds.Equals(input.Builds))
                ) && 
                (
                    this.InternalName == input.InternalName ||
                    (this.InternalName != null &&
                    this.InternalName.Equals(input.InternalName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Unspecified != null)
                    hashCode = hashCode * 59 + this.Unspecified.GetHashCode();
                if (this.GroupFlag != null)
                    hashCode = hashCode * 59 + this.GroupFlag.GetHashCode();
                if (this.LastActivity != null)
                    hashCode = hashCode * 59 + this.LastActivity.GetHashCode();
                if (this.Builds != null)
                    hashCode = hashCode * 59 + this.Builds.GetHashCode();
                if (this.InternalName != null)
                    hashCode = hashCode * 59 + this.InternalName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
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
