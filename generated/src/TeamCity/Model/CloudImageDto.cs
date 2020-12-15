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
    /// CloudImageDto
    /// </summary>
    [DataContract]
    public partial class CloudImageDto :  IEquatable<CloudImageDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudImageDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="href">href.</param>
        /// <param name="profile">profile.</param>
        /// <param name="instances">instances.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="agentTypeId">agentTypeId.</param>
        /// <param name="locator">locator.</param>
        public CloudImageDto(string id = default(string), string name = default(string), string href = default(string), CloudProfileDto profile = default(CloudProfileDto), CloudInstancesDto instances = default(CloudInstancesDto), string errorMessage = default(string), int? agentTypeId = default(int?), string locator = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Href = href;
            this.Profile = profile;
            this.Instances = instances;
            this.ErrorMessage = errorMessage;
            this.AgentTypeId = agentTypeId;
            this.Locator = locator;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public CloudProfileDto Profile { get; set; }

        /// <summary>
        /// Gets or Sets Instances
        /// </summary>
        [DataMember(Name="instances", EmitDefaultValue=false)]
        public CloudInstancesDto Instances { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets AgentTypeId
        /// </summary>
        [DataMember(Name="agentTypeId", EmitDefaultValue=false)]
        public int? AgentTypeId { get; set; }

        /// <summary>
        /// Gets or Sets Locator
        /// </summary>
        [DataMember(Name="locator", EmitDefaultValue=false)]
        public string Locator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudImageDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  Instances: ").Append(Instances).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  AgentTypeId: ").Append(AgentTypeId).Append("\n");
            sb.Append("  Locator: ").Append(Locator).Append("\n");
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
            return this.Equals(input as CloudImageDto);
        }

        /// <summary>
        /// Returns true if CloudImageDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudImageDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudImageDto input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) && 
                (
                    this.Instances == input.Instances ||
                    (this.Instances != null &&
                    this.Instances.Equals(input.Instances))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.AgentTypeId == input.AgentTypeId ||
                    (this.AgentTypeId != null &&
                    this.AgentTypeId.Equals(input.AgentTypeId))
                ) && 
                (
                    this.Locator == input.Locator ||
                    (this.Locator != null &&
                    this.Locator.Equals(input.Locator))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Profile != null)
                    hashCode = hashCode * 59 + this.Profile.GetHashCode();
                if (this.Instances != null)
                    hashCode = hashCode * 59 + this.Instances.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.AgentTypeId != null)
                    hashCode = hashCode * 59 + this.AgentTypeId.GetHashCode();
                if (this.Locator != null)
                    hashCode = hashCode * 59 + this.Locator.GetHashCode();
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
