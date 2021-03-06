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
    /// <para>Deleted all files from unlinked device.</para>
    /// </summary>
    public class DeviceDeleteOnUnlinkSuccessDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DeviceDeleteOnUnlinkSuccessDetails> Encoder = new DeviceDeleteOnUnlinkSuccessDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DeviceDeleteOnUnlinkSuccessDetails> Decoder = new DeviceDeleteOnUnlinkSuccessDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DeviceDeleteOnUnlinkSuccessDetails" /> class.</para>
        /// </summary>
        /// <param name="sessionInfo">Session unique id. Might be missing due to historical
        /// data gap.</param>
        /// <param name="displayName">The device name. Might be missing due to historical data
        /// gap.</param>
        public DeviceDeleteOnUnlinkSuccessDetails(SessionLogInfo sessionInfo = null,
                                                  string displayName = null)
        {
            this.SessionInfo = sessionInfo;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DeviceDeleteOnUnlinkSuccessDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public DeviceDeleteOnUnlinkSuccessDetails()
        {
        }

        /// <summary>
        /// <para>Session unique id. Might be missing due to historical data gap.</para>
        /// </summary>
        public SessionLogInfo SessionInfo { get; protected set; }

        /// <summary>
        /// <para>The device name. Might be missing due to historical data gap.</para>
        /// </summary>
        public string DisplayName { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DeviceDeleteOnUnlinkSuccessDetails" />.</para>
        /// </summary>
        private class DeviceDeleteOnUnlinkSuccessDetailsEncoder : enc.StructEncoder<DeviceDeleteOnUnlinkSuccessDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DeviceDeleteOnUnlinkSuccessDetails value, enc.IJsonWriter writer)
            {
                if (value.SessionInfo != null)
                {
                    WriteProperty("session_info", value.SessionInfo, writer, global::Dropbox.Api.TeamLog.SessionLogInfo.Encoder);
                }
                if (value.DisplayName != null)
                {
                    WriteProperty("display_name", value.DisplayName, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DeviceDeleteOnUnlinkSuccessDetails" />.</para>
        /// </summary>
        private class DeviceDeleteOnUnlinkSuccessDetailsDecoder : enc.StructDecoder<DeviceDeleteOnUnlinkSuccessDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="DeviceDeleteOnUnlinkSuccessDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DeviceDeleteOnUnlinkSuccessDetails Create()
            {
                return new DeviceDeleteOnUnlinkSuccessDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DeviceDeleteOnUnlinkSuccessDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "session_info":
                        value.SessionInfo = global::Dropbox.Api.TeamLog.SessionLogInfo.Decoder.Decode(reader);
                        break;
                    case "display_name":
                        value.DisplayName = enc.StringDecoder.Instance.Decode(reader);
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
