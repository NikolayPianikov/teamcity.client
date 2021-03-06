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
    /// MetricDto
    /// </summary>
    [DataContract]
    public partial class MetricDto :  IEquatable<MetricDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricDto" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="prometheusName">prometheusName.</param>
        /// <param name="metricValues">metricValues.</param>
        /// <param name="metricTags">metricTags.</param>
        public MetricDto(string name = default(string), string description = default(string), string prometheusName = default(string), MetricValuesDto metricValues = default(MetricValuesDto), MetricTagsDto metricTags = default(MetricTagsDto))
        {
            this.Name = name;
            this.Description = description;
            this.PrometheusName = prometheusName;
            this.MetricValues = metricValues;
            this.MetricTags = metricTags;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets PrometheusName
        /// </summary>
        [DataMember(Name="prometheusName", EmitDefaultValue=false)]
        public string PrometheusName { get; set; }

        /// <summary>
        /// Gets or Sets MetricValues
        /// </summary>
        [DataMember(Name="metricValues", EmitDefaultValue=false)]
        public MetricValuesDto MetricValues { get; set; }

        /// <summary>
        /// Gets or Sets MetricTags
        /// </summary>
        [DataMember(Name="metricTags", EmitDefaultValue=false)]
        public MetricTagsDto MetricTags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PrometheusName: ").Append(PrometheusName).Append("\n");
            sb.Append("  MetricValues: ").Append(MetricValues).Append("\n");
            sb.Append("  MetricTags: ").Append(MetricTags).Append("\n");
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
            return this.Equals(input as MetricDto);
        }

        /// <summary>
        /// Returns true if MetricDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MetricDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PrometheusName == input.PrometheusName ||
                    (this.PrometheusName != null &&
                    this.PrometheusName.Equals(input.PrometheusName))
                ) && 
                (
                    this.MetricValues == input.MetricValues ||
                    (this.MetricValues != null &&
                    this.MetricValues.Equals(input.MetricValues))
                ) && 
                (
                    this.MetricTags == input.MetricTags ||
                    (this.MetricTags != null &&
                    this.MetricTags.Equals(input.MetricTags))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PrometheusName != null)
                    hashCode = hashCode * 59 + this.PrometheusName.GetHashCode();
                if (this.MetricValues != null)
                    hashCode = hashCode * 59 + this.MetricValues.GetHashCode();
                if (this.MetricTags != null)
                    hashCode = hashCode * 59 + this.MetricTags.GetHashCode();
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
