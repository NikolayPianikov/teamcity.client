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
    /// ParsedTestNameDto
    /// </summary>
    [DataContract]
    public partial class ParsedTestNameDto :  IEquatable<ParsedTestNameDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParsedTestNameDto" /> class.
        /// </summary>
        /// <param name="testPackage">testPackage.</param>
        /// <param name="testSuite">testSuite.</param>
        /// <param name="testClass">testClass.</param>
        /// <param name="testShortName">testShortName.</param>
        /// <param name="testNameWithoutPrefix">testNameWithoutPrefix.</param>
        /// <param name="testMethodName">testMethodName.</param>
        /// <param name="testNameWithParameters">testNameWithParameters.</param>
        public ParsedTestNameDto(string testPackage = default(string), string testSuite = default(string), string testClass = default(string), string testShortName = default(string), string testNameWithoutPrefix = default(string), string testMethodName = default(string), string testNameWithParameters = default(string))
        {
            this.TestPackage = testPackage;
            this.TestSuite = testSuite;
            this.TestClass = testClass;
            this.TestShortName = testShortName;
            this.TestNameWithoutPrefix = testNameWithoutPrefix;
            this.TestMethodName = testMethodName;
            this.TestNameWithParameters = testNameWithParameters;
        }
        
        /// <summary>
        /// Gets or Sets TestPackage
        /// </summary>
        [DataMember(Name="testPackage", EmitDefaultValue=false)]
        public string TestPackage { get; set; }

        /// <summary>
        /// Gets or Sets TestSuite
        /// </summary>
        [DataMember(Name="testSuite", EmitDefaultValue=false)]
        public string TestSuite { get; set; }

        /// <summary>
        /// Gets or Sets TestClass
        /// </summary>
        [DataMember(Name="testClass", EmitDefaultValue=false)]
        public string TestClass { get; set; }

        /// <summary>
        /// Gets or Sets TestShortName
        /// </summary>
        [DataMember(Name="testShortName", EmitDefaultValue=false)]
        public string TestShortName { get; set; }

        /// <summary>
        /// Gets or Sets TestNameWithoutPrefix
        /// </summary>
        [DataMember(Name="testNameWithoutPrefix", EmitDefaultValue=false)]
        public string TestNameWithoutPrefix { get; set; }

        /// <summary>
        /// Gets or Sets TestMethodName
        /// </summary>
        [DataMember(Name="testMethodName", EmitDefaultValue=false)]
        public string TestMethodName { get; set; }

        /// <summary>
        /// Gets or Sets TestNameWithParameters
        /// </summary>
        [DataMember(Name="testNameWithParameters", EmitDefaultValue=false)]
        public string TestNameWithParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParsedTestNameDto {\n");
            sb.Append("  TestPackage: ").Append(TestPackage).Append("\n");
            sb.Append("  TestSuite: ").Append(TestSuite).Append("\n");
            sb.Append("  TestClass: ").Append(TestClass).Append("\n");
            sb.Append("  TestShortName: ").Append(TestShortName).Append("\n");
            sb.Append("  TestNameWithoutPrefix: ").Append(TestNameWithoutPrefix).Append("\n");
            sb.Append("  TestMethodName: ").Append(TestMethodName).Append("\n");
            sb.Append("  TestNameWithParameters: ").Append(TestNameWithParameters).Append("\n");
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
            return this.Equals(input as ParsedTestNameDto);
        }

        /// <summary>
        /// Returns true if ParsedTestNameDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ParsedTestNameDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParsedTestNameDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TestPackage == input.TestPackage ||
                    (this.TestPackage != null &&
                    this.TestPackage.Equals(input.TestPackage))
                ) && 
                (
                    this.TestSuite == input.TestSuite ||
                    (this.TestSuite != null &&
                    this.TestSuite.Equals(input.TestSuite))
                ) && 
                (
                    this.TestClass == input.TestClass ||
                    (this.TestClass != null &&
                    this.TestClass.Equals(input.TestClass))
                ) && 
                (
                    this.TestShortName == input.TestShortName ||
                    (this.TestShortName != null &&
                    this.TestShortName.Equals(input.TestShortName))
                ) && 
                (
                    this.TestNameWithoutPrefix == input.TestNameWithoutPrefix ||
                    (this.TestNameWithoutPrefix != null &&
                    this.TestNameWithoutPrefix.Equals(input.TestNameWithoutPrefix))
                ) && 
                (
                    this.TestMethodName == input.TestMethodName ||
                    (this.TestMethodName != null &&
                    this.TestMethodName.Equals(input.TestMethodName))
                ) && 
                (
                    this.TestNameWithParameters == input.TestNameWithParameters ||
                    (this.TestNameWithParameters != null &&
                    this.TestNameWithParameters.Equals(input.TestNameWithParameters))
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
                if (this.TestPackage != null)
                    hashCode = hashCode * 59 + this.TestPackage.GetHashCode();
                if (this.TestSuite != null)
                    hashCode = hashCode * 59 + this.TestSuite.GetHashCode();
                if (this.TestClass != null)
                    hashCode = hashCode * 59 + this.TestClass.GetHashCode();
                if (this.TestShortName != null)
                    hashCode = hashCode * 59 + this.TestShortName.GetHashCode();
                if (this.TestNameWithoutPrefix != null)
                    hashCode = hashCode * 59 + this.TestNameWithoutPrefix.GetHashCode();
                if (this.TestMethodName != null)
                    hashCode = hashCode * 59 + this.TestMethodName.GetHashCode();
                if (this.TestNameWithParameters != null)
                    hashCode = hashCode * 59 + this.TestNameWithParameters.GetHashCode();
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
