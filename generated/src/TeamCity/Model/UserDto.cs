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
    /// UserDto
    /// </summary>
    [DataContract]
    public partial class UserDto :  IEquatable<UserDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDto" /> class.
        /// </summary>
        /// <param name="username">username.</param>
        /// <param name="name">name.</param>
        /// <param name="id">id.</param>
        /// <param name="email">email.</param>
        /// <param name="lastLogin">lastLogin.</param>
        /// <param name="password">password.</param>
        /// <param name="hasPassword">hasPassword.</param>
        /// <param name="realm">realm.</param>
        /// <param name="href">href.</param>
        /// <param name="properties">properties.</param>
        /// <param name="roles">roles.</param>
        /// <param name="groups">groups.</param>
        /// <param name="locator">locator.</param>
        public UserDto(string username = default(string), string name = default(string), long? id = default(long?), string email = default(string), string lastLogin = default(string), string password = default(string), bool? hasPassword = default(bool?), string realm = default(string), string href = default(string), PropertiesDto properties = default(PropertiesDto), RolesDto roles = default(RolesDto), GroupsDto groups = default(GroupsDto), string locator = default(string))
        {
            this.Username = username;
            this.Name = name;
            this.Id = id;
            this.Email = email;
            this.LastLogin = lastLogin;
            this.Password = password;
            this.HasPassword = hasPassword;
            this.Realm = realm;
            this.Href = href;
            this.Properties = properties;
            this.Roles = roles;
            this.Groups = groups;
            this.Locator = locator;
        }
        
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets LastLogin
        /// </summary>
        [DataMember(Name="lastLogin", EmitDefaultValue=false)]
        public string LastLogin { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets HasPassword
        /// </summary>
        [DataMember(Name="hasPassword", EmitDefaultValue=false)]
        public bool? HasPassword { get; set; }

        /// <summary>
        /// Gets or Sets Realm
        /// </summary>
        [DataMember(Name="realm", EmitDefaultValue=false)]
        public string Realm { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public PropertiesDto Properties { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public RolesDto Roles { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public GroupsDto Groups { get; set; }

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
            sb.Append("class UserDto {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  HasPassword: ").Append(HasPassword).Append("\n");
            sb.Append("  Realm: ").Append(Realm).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            return this.Equals(input as UserDto);
        }

        /// <summary>
        /// Returns true if UserDto instances are equal
        /// </summary>
        /// <param name="input">Instance of UserDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.LastLogin == input.LastLogin ||
                    (this.LastLogin != null &&
                    this.LastLogin.Equals(input.LastLogin))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.HasPassword == input.HasPassword ||
                    (this.HasPassword != null &&
                    this.HasPassword.Equals(input.HasPassword))
                ) && 
                (
                    this.Realm == input.Realm ||
                    (this.Realm != null &&
                    this.Realm.Equals(input.Realm))
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.Roles == input.Roles ||
                    (this.Roles != null &&
                    this.Roles.Equals(input.Roles))
                ) && 
                (
                    this.Groups == input.Groups ||
                    (this.Groups != null &&
                    this.Groups.Equals(input.Groups))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.LastLogin != null)
                    hashCode = hashCode * 59 + this.LastLogin.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.HasPassword != null)
                    hashCode = hashCode * 59 + this.HasPassword.GetHashCode();
                if (this.Realm != null)
                    hashCode = hashCode * 59 + this.Realm.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
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
