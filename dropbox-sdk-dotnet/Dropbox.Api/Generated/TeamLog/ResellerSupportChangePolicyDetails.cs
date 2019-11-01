// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Enabled/disabled reseller support.</para>
    /// </summary>
    public class ResellerSupportChangePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ResellerSupportChangePolicyDetails> Encoder = new ResellerSupportChangePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ResellerSupportChangePolicyDetails> Decoder = new ResellerSupportChangePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="ResellerSupportChangePolicyDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">New Reseller support policy.</param>
        /// <param name="previousValue">Previous Reseller support policy.</param>
        public ResellerSupportChangePolicyDetails(ResellerSupportPolicy newValue,
                                                  ResellerSupportPolicy previousValue)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="ResellerSupportChangePolicyDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ResellerSupportChangePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New Reseller support policy.</para>
        /// </summary>
        public ResellerSupportPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous Reseller support policy.</para>
        /// </summary>
        public ResellerSupportPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ResellerSupportChangePolicyDetails" />.</para>
        /// </summary>
        private class ResellerSupportChangePolicyDetailsEncoder : enc.StructEncoder<ResellerSupportChangePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ResellerSupportChangePolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.ResellerSupportPolicy.Encoder);
                WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.ResellerSupportPolicy.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ResellerSupportChangePolicyDetails" />.</para>
        /// </summary>
        private class ResellerSupportChangePolicyDetailsDecoder : enc.StructDecoder<ResellerSupportChangePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="ResellerSupportChangePolicyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ResellerSupportChangePolicyDetails Create()
            {
                return new ResellerSupportChangePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ResellerSupportChangePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.ResellerSupportPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.ResellerSupportPolicy.Decoder.Decode(reader);
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