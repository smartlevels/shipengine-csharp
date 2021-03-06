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
    /// MagentoAccountInformationRequest
    /// </summary>
    [DataContract]
    public partial class MagentoAccountInformationRequest :  IEquatable<MagentoAccountInformationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagentoAccountInformationRequest" /> class.
        /// </summary>
        /// <param name="storeName">storeName.</param>
        /// <param name="storeUrl">storeUrl.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="settings">settings.</param>
        public MagentoAccountInformationRequest(string storeName = default(string), string storeUrl = default(string), string username = default(string), string password = default(string), MagentoAccountSettingsRequest settings = default(MagentoAccountSettingsRequest))
        {
            this.StoreName = storeName;
            this.StoreUrl = storeUrl;
            this.Username = username;
            this.Password = password;
            this.Settings = settings;
        }
        
        /// <summary>
        /// Gets or Sets StoreName
        /// </summary>
        [DataMember(Name="store_name", EmitDefaultValue=false)]
        public string StoreName { get; set; }

        /// <summary>
        /// Gets or Sets StoreUrl
        /// </summary>
        [DataMember(Name="store_url", EmitDefaultValue=false)]
        public string StoreUrl { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public MagentoAccountSettingsRequest Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MagentoAccountInformationRequest {\n");
            sb.Append("  StoreName: ").Append(StoreName).Append("\n");
            sb.Append("  StoreUrl: ").Append(StoreUrl).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(input as MagentoAccountInformationRequest);
        }

        /// <summary>
        /// Returns true if MagentoAccountInformationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MagentoAccountInformationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MagentoAccountInformationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoreName == input.StoreName ||
                    (this.StoreName != null &&
                    this.StoreName.Equals(input.StoreName))
                ) && 
                (
                    this.StoreUrl == input.StoreUrl ||
                    (this.StoreUrl != null &&
                    this.StoreUrl.Equals(input.StoreUrl))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
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
                if (this.StoreName != null)
                    hashCode = hashCode * 59 + this.StoreName.GetHashCode();
                if (this.StoreUrl != null)
                    hashCode = hashCode * 59 + this.StoreUrl.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
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
