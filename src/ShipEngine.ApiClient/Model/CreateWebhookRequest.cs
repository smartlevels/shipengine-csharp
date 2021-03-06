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
    /// CreateWebhookRequest
    /// </summary>
    [DataContract]
    public partial class CreateWebhookRequest :  IEquatable<CreateWebhookRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines Event
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventEnum
        {
            
            /// <summary>
            /// Enum Rate for value: rate
            /// </summary>
            [EnumMember(Value = "rate")]
            Rate = 1,
            
            /// <summary>
            /// Enum Track for value: track
            /// </summary>
            [EnumMember(Value = "track")]
            Track = 2,
            
            /// <summary>
            /// Enum Batch for value: batch
            /// </summary>
            [EnumMember(Value = "batch")]
            Batch = 3,
            
            /// <summary>
            /// Enum StoreRefreshComplete for value: storeRefreshComplete
            /// </summary>
            [EnumMember(Value = "storeRefreshComplete")]
            StoreRefreshComplete = 4,
            
            /// <summary>
            /// Enum SalesOrdersImported for value: salesOrdersImported
            /// </summary>
            [EnumMember(Value = "salesOrdersImported")]
            SalesOrdersImported = 5,
            
            /// <summary>
            /// Enum CarrierConnected for value: carrierConnected
            /// </summary>
            [EnumMember(Value = "carrierConnected")]
            CarrierConnected = 6
        }

        /// <summary>
        /// Gets or Sets Event
        /// </summary>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public EventEnum? Event { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookRequest" /> class.
        /// </summary>
        /// <param name="_event">_event.</param>
        /// <param name="url">url.</param>
        public CreateWebhookRequest(EventEnum? _event = default(EventEnum?), string url = default(string))
        {
            this.Event = _event;
            this.Url = url;
        }
        

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWebhookRequest {\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as CreateWebhookRequest);
        }

        /// <summary>
        /// Returns true if CreateWebhookRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWebhookRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWebhookRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
