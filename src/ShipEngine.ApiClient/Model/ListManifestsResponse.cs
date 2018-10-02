/* 
 * ShipEngine
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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
using SwaggerDateConverter = ShipEngine.ApiClient.Client.SwaggerDateConverter;

namespace ShipEngine.ApiClient.Model
{
    /// <summary>
    /// ListManifestsResponse
    /// </summary>
    [DataContract]
    public partial class ListManifestsResponse :  IEquatable<ListManifestsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListManifestsResponse" /> class.
        /// </summary>
        /// <param name="manifests">manifests.</param>
        /// <param name="total">total.</param>
        /// <param name="page">page.</param>
        /// <param name="pages">pages.</param>
        /// <param name="links">links.</param>
        public ListManifestsResponse(List<ManifestResponse> manifests = default(List<ManifestResponse>), long? total = default(long?), int? page = default(int?), int? pages = default(int?), PaginationLinkDTO links = default(PaginationLinkDTO))
        {
            this.Manifests = manifests;
            this.Total = total;
            this.Page = page;
            this.Pages = pages;
            this.Links = links;
        }
        
        /// <summary>
        /// Gets or Sets Manifests
        /// </summary>
        [DataMember(Name="manifests", EmitDefaultValue=false)]
        public List<ManifestResponse> Manifests { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }

        /// <summary>
        /// Gets or Sets Pages
        /// </summary>
        [DataMember(Name="pages", EmitDefaultValue=false)]
        public int? Pages { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public PaginationLinkDTO Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListManifestsResponse {\n");
            sb.Append("  Manifests: ").Append(Manifests).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as ListManifestsResponse);
        }

        /// <summary>
        /// Returns true if ListManifestsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListManifestsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListManifestsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Manifests == input.Manifests ||
                    this.Manifests != null &&
                    this.Manifests.SequenceEqual(input.Manifests)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.Pages == input.Pages ||
                    (this.Pages != null &&
                    this.Pages.Equals(input.Pages))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Manifests != null)
                    hashCode = hashCode * 59 + this.Manifests.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Pages != null)
                    hashCode = hashCode * 59 + this.Pages.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
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