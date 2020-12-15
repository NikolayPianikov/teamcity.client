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
    /// TestOccurrencesDto
    /// </summary>
    [DataContract]
    public partial class TestOccurrencesDto :  IEquatable<TestOccurrencesDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestOccurrencesDto" /> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="href">href.</param>
        /// <param name="nextHref">nextHref.</param>
        /// <param name="prevHref">prevHref.</param>
        /// <param name="testOccurrence">testOccurrence.</param>
        /// <param name="testCounters">testCounters.</param>
        /// <param name="passed">passed.</param>
        /// <param name="failed">failed.</param>
        /// <param name="newFailed">newFailed.</param>
        /// <param name="ignored">ignored.</param>
        /// <param name="muted">muted.</param>
        public TestOccurrencesDto(int? count = default(int?), string href = default(string), string nextHref = default(string), string prevHref = default(string), List<TestOccurrenceDto> testOccurrence = default(List<TestOccurrenceDto>), TestCountersDto testCounters = default(TestCountersDto), int? passed = default(int?), int? failed = default(int?), int? newFailed = default(int?), int? ignored = default(int?), int? muted = default(int?))
        {
            this.Count = count;
            this.Href = href;
            this.NextHref = nextHref;
            this.PrevHref = prevHref;
            this.TestOccurrence = testOccurrence;
            this.TestCounters = testCounters;
            this.Passed = passed;
            this.Failed = failed;
            this.NewFailed = newFailed;
            this.Ignored = ignored;
            this.Muted = muted;
        }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets NextHref
        /// </summary>
        [DataMember(Name="nextHref", EmitDefaultValue=false)]
        public string NextHref { get; set; }

        /// <summary>
        /// Gets or Sets PrevHref
        /// </summary>
        [DataMember(Name="prevHref", EmitDefaultValue=false)]
        public string PrevHref { get; set; }

        /// <summary>
        /// Gets or Sets TestOccurrence
        /// </summary>
        [DataMember(Name="testOccurrence", EmitDefaultValue=false)]
        public List<TestOccurrenceDto> TestOccurrence { get; set; }

        /// <summary>
        /// Gets or Sets TestCounters
        /// </summary>
        [DataMember(Name="testCounters", EmitDefaultValue=false)]
        public TestCountersDto TestCounters { get; set; }

        /// <summary>
        /// Gets or Sets Passed
        /// </summary>
        [DataMember(Name="passed", EmitDefaultValue=false)]
        public int? Passed { get; set; }

        /// <summary>
        /// Gets or Sets Failed
        /// </summary>
        [DataMember(Name="failed", EmitDefaultValue=false)]
        public int? Failed { get; set; }

        /// <summary>
        /// Gets or Sets NewFailed
        /// </summary>
        [DataMember(Name="newFailed", EmitDefaultValue=false)]
        public int? NewFailed { get; set; }

        /// <summary>
        /// Gets or Sets Ignored
        /// </summary>
        [DataMember(Name="ignored", EmitDefaultValue=false)]
        public int? Ignored { get; set; }

        /// <summary>
        /// Gets or Sets Muted
        /// </summary>
        [DataMember(Name="muted", EmitDefaultValue=false)]
        public int? Muted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestOccurrencesDto {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  NextHref: ").Append(NextHref).Append("\n");
            sb.Append("  PrevHref: ").Append(PrevHref).Append("\n");
            sb.Append("  TestOccurrence: ").Append(TestOccurrence).Append("\n");
            sb.Append("  TestCounters: ").Append(TestCounters).Append("\n");
            sb.Append("  Passed: ").Append(Passed).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  NewFailed: ").Append(NewFailed).Append("\n");
            sb.Append("  Ignored: ").Append(Ignored).Append("\n");
            sb.Append("  Muted: ").Append(Muted).Append("\n");
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
            return this.Equals(input as TestOccurrencesDto);
        }

        /// <summary>
        /// Returns true if TestOccurrencesDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TestOccurrencesDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestOccurrencesDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.NextHref == input.NextHref ||
                    (this.NextHref != null &&
                    this.NextHref.Equals(input.NextHref))
                ) && 
                (
                    this.PrevHref == input.PrevHref ||
                    (this.PrevHref != null &&
                    this.PrevHref.Equals(input.PrevHref))
                ) && 
                (
                    this.TestOccurrence == input.TestOccurrence ||
                    this.TestOccurrence != null &&
                    this.TestOccurrence.SequenceEqual(input.TestOccurrence)
                ) && 
                (
                    this.TestCounters == input.TestCounters ||
                    (this.TestCounters != null &&
                    this.TestCounters.Equals(input.TestCounters))
                ) && 
                (
                    this.Passed == input.Passed ||
                    (this.Passed != null &&
                    this.Passed.Equals(input.Passed))
                ) && 
                (
                    this.Failed == input.Failed ||
                    (this.Failed != null &&
                    this.Failed.Equals(input.Failed))
                ) && 
                (
                    this.NewFailed == input.NewFailed ||
                    (this.NewFailed != null &&
                    this.NewFailed.Equals(input.NewFailed))
                ) && 
                (
                    this.Ignored == input.Ignored ||
                    (this.Ignored != null &&
                    this.Ignored.Equals(input.Ignored))
                ) && 
                (
                    this.Muted == input.Muted ||
                    (this.Muted != null &&
                    this.Muted.Equals(input.Muted))
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.NextHref != null)
                    hashCode = hashCode * 59 + this.NextHref.GetHashCode();
                if (this.PrevHref != null)
                    hashCode = hashCode * 59 + this.PrevHref.GetHashCode();
                if (this.TestOccurrence != null)
                    hashCode = hashCode * 59 + this.TestOccurrence.GetHashCode();
                if (this.TestCounters != null)
                    hashCode = hashCode * 59 + this.TestCounters.GetHashCode();
                if (this.Passed != null)
                    hashCode = hashCode * 59 + this.Passed.GetHashCode();
                if (this.Failed != null)
                    hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.NewFailed != null)
                    hashCode = hashCode * 59 + this.NewFailed.GetHashCode();
                if (this.Ignored != null)
                    hashCode = hashCode * 59 + this.Ignored.GetHashCode();
                if (this.Muted != null)
                    hashCode = hashCode * 59 + this.Muted.GetHashCode();
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
