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
    /// BackupProcessManagerDto
    /// </summary>
    [DataContract]
    public partial class BackupProcessManagerDto :  IEquatable<BackupProcessManagerDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupProcessManagerDto" /> class.
        /// </summary>
        /// <param name="currentBackupProcess">currentBackupProcess.</param>
        public BackupProcessManagerDto(BackupProcessDto currentBackupProcess = default(BackupProcessDto))
        {
            this.CurrentBackupProcess = currentBackupProcess;
        }
        
        /// <summary>
        /// Gets or Sets CurrentBackupProcess
        /// </summary>
        [DataMember(Name="currentBackupProcess", EmitDefaultValue=false)]
        public BackupProcessDto CurrentBackupProcess { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupProcessManagerDto {\n");
            sb.Append("  CurrentBackupProcess: ").Append(CurrentBackupProcess).Append("\n");
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
            return this.Equals(input as BackupProcessManagerDto);
        }

        /// <summary>
        /// Returns true if BackupProcessManagerDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupProcessManagerDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupProcessManagerDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentBackupProcess == input.CurrentBackupProcess ||
                    (this.CurrentBackupProcess != null &&
                    this.CurrentBackupProcess.Equals(input.CurrentBackupProcess))
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
                if (this.CurrentBackupProcess != null)
                    hashCode = hashCode * 59 + this.CurrentBackupProcess.GetHashCode();
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