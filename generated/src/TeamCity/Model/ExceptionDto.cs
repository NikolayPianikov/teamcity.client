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
    /// ExceptionDto
    /// </summary>
    [DataContract]
    public partial class ExceptionDto :  IEquatable<ExceptionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionDto" /> class.
        /// </summary>
        /// <param name="cause">cause.</param>
        /// <param name="stackTrace">stackTrace.</param>
        /// <param name="message">message.</param>
        /// <param name="suppressed">suppressed.</param>
        /// <param name="localizedMessage">localizedMessage.</param>
        public ExceptionDto(ThrowableDto cause = default(ThrowableDto), List<StackTraceElementDto> stackTrace = default(List<StackTraceElementDto>), string message = default(string), List<ThrowableDto> suppressed = default(List<ThrowableDto>), string localizedMessage = default(string))
        {
            this.Cause = cause;
            this.StackTrace = stackTrace;
            this.Message = message;
            this.Suppressed = suppressed;
            this.LocalizedMessage = localizedMessage;
        }
        
        /// <summary>
        /// Gets or Sets Cause
        /// </summary>
        [DataMember(Name="cause", EmitDefaultValue=false)]
        public ThrowableDto Cause { get; set; }

        /// <summary>
        /// Gets or Sets StackTrace
        /// </summary>
        [DataMember(Name="stackTrace", EmitDefaultValue=false)]
        public List<StackTraceElementDto> StackTrace { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Suppressed
        /// </summary>
        [DataMember(Name="suppressed", EmitDefaultValue=false)]
        public List<ThrowableDto> Suppressed { get; set; }

        /// <summary>
        /// Gets or Sets LocalizedMessage
        /// </summary>
        [DataMember(Name="localizedMessage", EmitDefaultValue=false)]
        public string LocalizedMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExceptionDto {\n");
            sb.Append("  Cause: ").Append(Cause).Append("\n");
            sb.Append("  StackTrace: ").Append(StackTrace).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Suppressed: ").Append(Suppressed).Append("\n");
            sb.Append("  LocalizedMessage: ").Append(LocalizedMessage).Append("\n");
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
            return this.Equals(input as ExceptionDto);
        }

        /// <summary>
        /// Returns true if ExceptionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ExceptionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExceptionDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cause == input.Cause ||
                    (this.Cause != null &&
                    this.Cause.Equals(input.Cause))
                ) && 
                (
                    this.StackTrace == input.StackTrace ||
                    this.StackTrace != null &&
                    this.StackTrace.SequenceEqual(input.StackTrace)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Suppressed == input.Suppressed ||
                    this.Suppressed != null &&
                    this.Suppressed.SequenceEqual(input.Suppressed)
                ) && 
                (
                    this.LocalizedMessage == input.LocalizedMessage ||
                    (this.LocalizedMessage != null &&
                    this.LocalizedMessage.Equals(input.LocalizedMessage))
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
                if (this.Cause != null)
                    hashCode = hashCode * 59 + this.Cause.GetHashCode();
                if (this.StackTrace != null)
                    hashCode = hashCode * 59 + this.StackTrace.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Suppressed != null)
                    hashCode = hashCode * 59 + this.Suppressed.GetHashCode();
                if (this.LocalizedMessage != null)
                    hashCode = hashCode * 59 + this.LocalizedMessage.GetHashCode();
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
