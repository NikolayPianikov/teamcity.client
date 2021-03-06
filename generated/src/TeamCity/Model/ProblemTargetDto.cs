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
    /// ProblemTargetDto
    /// </summary>
    [DataContract]
    public partial class ProblemTargetDto :  IEquatable<ProblemTargetDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProblemTargetDto" /> class.
        /// </summary>
        /// <param name="anyProblem">anyProblem.</param>
        /// <param name="tests">tests.</param>
        /// <param name="problems">problems.</param>
        public ProblemTargetDto(bool? anyProblem = default(bool?), TestsDto tests = default(TestsDto), ProblemsDto problems = default(ProblemsDto))
        {
            this.AnyProblem = anyProblem;
            this.Tests = tests;
            this.Problems = problems;
        }
        
        /// <summary>
        /// Gets or Sets AnyProblem
        /// </summary>
        [DataMember(Name="anyProblem", EmitDefaultValue=false)]
        public bool? AnyProblem { get; set; }

        /// <summary>
        /// Gets or Sets Tests
        /// </summary>
        [DataMember(Name="tests", EmitDefaultValue=false)]
        public TestsDto Tests { get; set; }

        /// <summary>
        /// Gets or Sets Problems
        /// </summary>
        [DataMember(Name="problems", EmitDefaultValue=false)]
        public ProblemsDto Problems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProblemTargetDto {\n");
            sb.Append("  AnyProblem: ").Append(AnyProblem).Append("\n");
            sb.Append("  Tests: ").Append(Tests).Append("\n");
            sb.Append("  Problems: ").Append(Problems).Append("\n");
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
            return this.Equals(input as ProblemTargetDto);
        }

        /// <summary>
        /// Returns true if ProblemTargetDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ProblemTargetDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProblemTargetDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AnyProblem == input.AnyProblem ||
                    (this.AnyProblem != null &&
                    this.AnyProblem.Equals(input.AnyProblem))
                ) && 
                (
                    this.Tests == input.Tests ||
                    (this.Tests != null &&
                    this.Tests.Equals(input.Tests))
                ) && 
                (
                    this.Problems == input.Problems ||
                    (this.Problems != null &&
                    this.Problems.Equals(input.Problems))
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
                if (this.AnyProblem != null)
                    hashCode = hashCode * 59 + this.AnyProblem.GetHashCode();
                if (this.Tests != null)
                    hashCode = hashCode * 59 + this.Tests.GetHashCode();
                if (this.Problems != null)
                    hashCode = hashCode * 59 + this.Problems.GetHashCode();
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
