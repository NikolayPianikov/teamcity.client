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
    /// BuildCancelRequestDto
    /// </summary>
    [DataContract]
    public partial class BuildCancelRequestDto :  IEquatable<BuildCancelRequestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildCancelRequestDto" /> class.
        /// </summary>
        /// <param name="comment">comment.</param>
        /// <param name="readdIntoQueue">readdIntoQueue.</param>
        public BuildCancelRequestDto(string comment = default(string), bool? readdIntoQueue = default(bool?))
        {
            this.Comment = comment;
            this.ReaddIntoQueue = readdIntoQueue;
        }
        
        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets ReaddIntoQueue
        /// </summary>
        [DataMember(Name="readdIntoQueue", EmitDefaultValue=false)]
        public bool? ReaddIntoQueue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildCancelRequestDto {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  ReaddIntoQueue: ").Append(ReaddIntoQueue).Append("\n");
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
            return this.Equals(input as BuildCancelRequestDto);
        }

        /// <summary>
        /// Returns true if BuildCancelRequestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildCancelRequestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildCancelRequestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.ReaddIntoQueue == input.ReaddIntoQueue ||
                    (this.ReaddIntoQueue != null &&
                    this.ReaddIntoQueue.Equals(input.ReaddIntoQueue))
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
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.ReaddIntoQueue != null)
                    hashCode = hashCode * 59 + this.ReaddIntoQueue.GetHashCode();
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