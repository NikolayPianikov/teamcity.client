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
    /// TestDto
    /// </summary>
    [DataContract]
    public partial class TestDto :  IEquatable<TestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="mutes">mutes.</param>
        /// <param name="investigations">investigations.</param>
        /// <param name="testOccurrences">testOccurrences.</param>
        /// <param name="parsedTestName">parsedTestName.</param>
        /// <param name="href">href.</param>
        /// <param name="locator">locator.</param>
        public TestDto(string id = default(string), string name = default(string), MutesDto mutes = default(MutesDto), InvestigationsDto investigations = default(InvestigationsDto), TestOccurrencesDto testOccurrences = default(TestOccurrencesDto), ParsedTestNameDto parsedTestName = default(ParsedTestNameDto), string href = default(string), string locator = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Mutes = mutes;
            this.Investigations = investigations;
            this.TestOccurrences = testOccurrences;
            this.ParsedTestName = parsedTestName;
            this.Href = href;
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
        /// Gets or Sets Mutes
        /// </summary>
        [DataMember(Name="mutes", EmitDefaultValue=false)]
        public MutesDto Mutes { get; set; }

        /// <summary>
        /// Gets or Sets Investigations
        /// </summary>
        [DataMember(Name="investigations", EmitDefaultValue=false)]
        public InvestigationsDto Investigations { get; set; }

        /// <summary>
        /// Gets or Sets TestOccurrences
        /// </summary>
        [DataMember(Name="testOccurrences", EmitDefaultValue=false)]
        public TestOccurrencesDto TestOccurrences { get; set; }

        /// <summary>
        /// Gets or Sets ParsedTestName
        /// </summary>
        [DataMember(Name="parsedTestName", EmitDefaultValue=false)]
        public ParsedTestNameDto ParsedTestName { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

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
            sb.Append("class TestDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Mutes: ").Append(Mutes).Append("\n");
            sb.Append("  Investigations: ").Append(Investigations).Append("\n");
            sb.Append("  TestOccurrences: ").Append(TestOccurrences).Append("\n");
            sb.Append("  ParsedTestName: ").Append(ParsedTestName).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
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
            return this.Equals(input as TestDto);
        }

        /// <summary>
        /// Returns true if TestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestDto input)
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
                    this.Mutes == input.Mutes ||
                    (this.Mutes != null &&
                    this.Mutes.Equals(input.Mutes))
                ) && 
                (
                    this.Investigations == input.Investigations ||
                    (this.Investigations != null &&
                    this.Investigations.Equals(input.Investigations))
                ) && 
                (
                    this.TestOccurrences == input.TestOccurrences ||
                    (this.TestOccurrences != null &&
                    this.TestOccurrences.Equals(input.TestOccurrences))
                ) && 
                (
                    this.ParsedTestName == input.ParsedTestName ||
                    (this.ParsedTestName != null &&
                    this.ParsedTestName.Equals(input.ParsedTestName))
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
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
                if (this.Mutes != null)
                    hashCode = hashCode * 59 + this.Mutes.GetHashCode();
                if (this.Investigations != null)
                    hashCode = hashCode * 59 + this.Investigations.GetHashCode();
                if (this.TestOccurrences != null)
                    hashCode = hashCode * 59 + this.TestOccurrences.GetHashCode();
                if (this.ParsedTestName != null)
                    hashCode = hashCode * 59 + this.ParsedTestName.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
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
