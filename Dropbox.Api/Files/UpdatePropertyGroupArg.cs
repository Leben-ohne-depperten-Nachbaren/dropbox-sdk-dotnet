// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The update property group arg object</para>
    /// </summary>
    public class UpdatePropertyGroupArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UpdatePropertyGroupArg> Encoder = new UpdatePropertyGroupArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UpdatePropertyGroupArg> Decoder = new UpdatePropertyGroupArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UpdatePropertyGroupArg" />
        /// class.</para>
        /// </summary>
        /// <param name="path">A unique identifier for the file.</param>
        /// <param name="updatePropertyGroups">Filled custom property templates associated with
        /// a file.</param>
        public UpdatePropertyGroupArg(string path,
                                      col.IEnumerable<PropertyGroupUpdate> updatePropertyGroups)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            if (!re.Regex.IsMatch(path, @"\A(?:/(.|[\r\n])*|id:.*|(ns:[0-9]+(/.*)?))\z"))
            {
                throw new sys.ArgumentOutOfRangeException("path", @"Value should match pattern '\A(?:/(.|[\r\n])*|id:.*|(ns:[0-9]+(/.*)?))\z'");
            }

            var updatePropertyGroupsList = enc.Util.ToList(updatePropertyGroups);

            if (updatePropertyGroups == null)
            {
                throw new sys.ArgumentNullException("updatePropertyGroups");
            }

            this.Path = path;
            this.UpdatePropertyGroups = updatePropertyGroupsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UpdatePropertyGroupArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public UpdatePropertyGroupArg()
        {
        }

        /// <summary>
        /// <para>A unique identifier for the file.</para>
        /// </summary>
        public string Path { get; protected set; }

        /// <summary>
        /// <para>Filled custom property templates associated with a file.</para>
        /// </summary>
        public col.IList<PropertyGroupUpdate> UpdatePropertyGroups { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UpdatePropertyGroupArg" />.</para>
        /// </summary>
        private class UpdatePropertyGroupArgEncoder : enc.StructEncoder<UpdatePropertyGroupArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UpdatePropertyGroupArg value, enc.IJsonWriter writer)
            {
                WriteProperty("path", value.Path, writer, enc.StringEncoder.Instance);
                WriteListProperty("update_property_groups", value.UpdatePropertyGroups, writer, Dropbox.Api.Files.PropertyGroupUpdate.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UpdatePropertyGroupArg" />.</para>
        /// </summary>
        private class UpdatePropertyGroupArgDecoder : enc.StructDecoder<UpdatePropertyGroupArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UpdatePropertyGroupArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UpdatePropertyGroupArg Create()
            {
                return new UpdatePropertyGroupArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UpdatePropertyGroupArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "path":
                        value.Path = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "update_property_groups":
                        value.UpdatePropertyGroups = ReadList<PropertyGroupUpdate>(reader, Dropbox.Api.Files.PropertyGroupUpdate.Decoder);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}