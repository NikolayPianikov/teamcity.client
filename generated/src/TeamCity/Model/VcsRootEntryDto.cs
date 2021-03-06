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
    /// VcsRootEntryDto
    /// </summary>
    [DataContract]
    public partial class VcsRootEntryDto :  IEquatable<VcsRootEntryDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VcsRootEntryDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="inherited">inherited.</param>
        /// <param name="vcsRoot">vcsRoot.</param>
        /// <param name="checkoutRules">checkoutRules.</param>
        public VcsRootEntryDto(string id = default(string), bool? inherited = default(bool?), VcsRootDto vcsRoot = default(VcsRootDto), string checkoutRules = default(string))
        {
            this.Id = id;
            this.Inherited = inherited;
            this.VcsRoot = vcsRoot;
            this.CheckoutRules = checkoutRules;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Inherited
        /// </summary>
        [DataMember(Name="inherited", EmitDefaultValue=false)]
        public bool? Inherited { get; set; }

        /// <summary>
        /// Gets or Sets VcsRoot
        /// </summary>
        [DataMember(Name="vcs-root", EmitDefaultValue=false)]
        public VcsRootDto VcsRoot { get; set; }

        /// <summary>
        /// Gets or Sets CheckoutRules
        /// </summary>
        [DataMember(Name="checkout-rules", EmitDefaultValue=false)]
        public string CheckoutRules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VcsRootEntryDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Inherited: ").Append(Inherited).Append("\n");
            sb.Append("  VcsRoot: ").Append(VcsRoot).Append("\n");
            sb.Append("  CheckoutRules: ").Append(CheckoutRules).Append("\n");
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
            return this.Equals(input as VcsRootEntryDto);
        }

        /// <summary>
        /// Returns true if VcsRootEntryDto instances are equal
        /// </summary>
        /// <param name="input">Instance of VcsRootEntryDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VcsRootEntryDto input)
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
                    this.Inherited == input.Inherited ||
                    (this.Inherited != null &&
                    this.Inherited.Equals(input.Inherited))
                ) && 
                (
                    this.VcsRoot == input.VcsRoot ||
                    (this.VcsRoot != null &&
                    this.VcsRoot.Equals(input.VcsRoot))
                ) && 
                (
                    this.CheckoutRules == input.CheckoutRules ||
                    (this.CheckoutRules != null &&
                    this.CheckoutRules.Equals(input.CheckoutRules))
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
                if (this.Inherited != null)
                    hashCode = hashCode * 59 + this.Inherited.GetHashCode();
                if (this.VcsRoot != null)
                    hashCode = hashCode * 59 + this.VcsRoot.GetHashCode();
                if (this.CheckoutRules != null)
                    hashCode = hashCode * 59 + this.CheckoutRules.GetHashCode();
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
