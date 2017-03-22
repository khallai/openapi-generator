/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
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

namespace IO.Swagger.Model
{
    /// <summary>
    /// Model for testing model name starting with number
    /// </summary>
    [DataContract]
    public partial class Model200Response :  IEquatable<Model200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Model200Response" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="_Class">_Class.</param>
        public Model200Response(int? Name = default(int?), string _Class = default(string))
        {
            this.Name = Name;
            this._Class = _Class;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public int? Name { get; set; }
        /// <summary>
        /// Gets or Sets _Class
        /// </summary>
        [DataMember(Name="class", EmitDefaultValue=false)]
        public string _Class { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Model200Response {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _Class: ").Append(_Class).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Model200Response);
        }

        /// <summary>
        /// Returns true if Model200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of Model200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Model200Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this._Class == other._Class ||
                    this._Class != null &&
                    this._Class.Equals(other._Class)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this._Class != null)
                    hash = hash * 59 + this._Class.GetHashCode();
                return hash;
            }
        }

        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
