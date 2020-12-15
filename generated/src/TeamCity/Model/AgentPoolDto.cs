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
    /// AgentPoolDto
    /// </summary>
    [DataContract]
    public partial class AgentPoolDto :  IEquatable<AgentPoolDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPoolDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="href">href.</param>
        /// <param name="maxAgents">maxAgents.</param>
        /// <param name="ownerProject">ownerProject.</param>
        /// <param name="projects">projects.</param>
        /// <param name="agents">agents.</param>
        /// <param name="locator">locator.</param>
        public AgentPoolDto(int? id = default(int?), string name = default(string), string href = default(string), int? maxAgents = default(int?), ProjectDto ownerProject = default(ProjectDto), ProjectsDto projects = default(ProjectsDto), AgentsDto agents = default(AgentsDto), string locator = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Href = href;
            this.MaxAgents = maxAgents;
            this.OwnerProject = ownerProject;
            this.Projects = projects;
            this.Agents = agents;
            this.Locator = locator;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

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
        /// Gets or Sets MaxAgents
        /// </summary>
        [DataMember(Name="maxAgents", EmitDefaultValue=false)]
        public int? MaxAgents { get; set; }

        /// <summary>
        /// Gets or Sets OwnerProject
        /// </summary>
        [DataMember(Name="ownerProject", EmitDefaultValue=false)]
        public ProjectDto OwnerProject { get; set; }

        /// <summary>
        /// Gets or Sets Projects
        /// </summary>
        [DataMember(Name="projects", EmitDefaultValue=false)]
        public ProjectsDto Projects { get; set; }

        /// <summary>
        /// Gets or Sets Agents
        /// </summary>
        [DataMember(Name="agents", EmitDefaultValue=false)]
        public AgentsDto Agents { get; set; }

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
            sb.Append("class AgentPoolDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  MaxAgents: ").Append(MaxAgents).Append("\n");
            sb.Append("  OwnerProject: ").Append(OwnerProject).Append("\n");
            sb.Append("  Projects: ").Append(Projects).Append("\n");
            sb.Append("  Agents: ").Append(Agents).Append("\n");
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
            return this.Equals(input as AgentPoolDto);
        }

        /// <summary>
        /// Returns true if AgentPoolDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AgentPoolDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentPoolDto input)
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
                    this.MaxAgents == input.MaxAgents ||
                    (this.MaxAgents != null &&
                    this.MaxAgents.Equals(input.MaxAgents))
                ) && 
                (
                    this.OwnerProject == input.OwnerProject ||
                    (this.OwnerProject != null &&
                    this.OwnerProject.Equals(input.OwnerProject))
                ) && 
                (
                    this.Projects == input.Projects ||
                    (this.Projects != null &&
                    this.Projects.Equals(input.Projects))
                ) && 
                (
                    this.Agents == input.Agents ||
                    (this.Agents != null &&
                    this.Agents.Equals(input.Agents))
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
                if (this.MaxAgents != null)
                    hashCode = hashCode * 59 + this.MaxAgents.GetHashCode();
                if (this.OwnerProject != null)
                    hashCode = hashCode * 59 + this.OwnerProject.GetHashCode();
                if (this.Projects != null)
                    hashCode = hashCode * 59 + this.Projects.GetHashCode();
                if (this.Agents != null)
                    hashCode = hashCode * 59 + this.Agents.GetHashCode();
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
