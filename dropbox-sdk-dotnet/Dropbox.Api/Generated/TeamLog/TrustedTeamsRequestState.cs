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
    /// <para>The trusted teams request state object</para>
    /// </summary>
    public class TrustedTeamsRequestState
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TrustedTeamsRequestState> Encoder = new TrustedTeamsRequestStateEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TrustedTeamsRequestState> Decoder = new TrustedTeamsRequestStateDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TrustedTeamsRequestState" />
        /// class.</para>
        /// </summary>
        public TrustedTeamsRequestState()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Invited</para>
        /// </summary>
        public bool IsInvited
        {
            get
            {
                return this is Invited;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Invited, or <c>null</c>.</para>
        /// </summary>
        public Invited AsInvited
        {
            get
            {
                return this as Invited;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Linked</para>
        /// </summary>
        public bool IsLinked
        {
            get
            {
                return this is Linked;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Linked, or <c>null</c>.</para>
        /// </summary>
        public Linked AsLinked
        {
            get
            {
                return this as Linked;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Unlinked</para>
        /// </summary>
        public bool IsUnlinked
        {
            get
            {
                return this is Unlinked;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Unlinked, or <c>null</c>.</para>
        /// </summary>
        public Unlinked AsUnlinked
        {
            get
            {
                return this as Unlinked;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TrustedTeamsRequestState" />.</para>
        /// </summary>
        private class TrustedTeamsRequestStateEncoder : enc.StructEncoder<TrustedTeamsRequestState>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TrustedTeamsRequestState value, enc.IJsonWriter writer)
            {
                if (value is Invited)
                {
                    WriteProperty(".tag", "invited", writer, enc.StringEncoder.Instance);
                    Invited.Encoder.EncodeFields((Invited)value, writer);
                    return;
                }
                if (value is Linked)
                {
                    WriteProperty(".tag", "linked", writer, enc.StringEncoder.Instance);
                    Linked.Encoder.EncodeFields((Linked)value, writer);
                    return;
                }
                if (value is Unlinked)
                {
                    WriteProperty(".tag", "unlinked", writer, enc.StringEncoder.Instance);
                    Unlinked.Encoder.EncodeFields((Unlinked)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TrustedTeamsRequestState" />.</para>
        /// </summary>
        private class TrustedTeamsRequestStateDecoder : enc.UnionDecoder<TrustedTeamsRequestState>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TrustedTeamsRequestState"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TrustedTeamsRequestState Create()
            {
                return new TrustedTeamsRequestState();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override TrustedTeamsRequestState Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "invited":
                        return Invited.Decoder.DecodeFields(reader);
                    case "linked":
                        return Linked.Decoder.DecodeFields(reader);
                    case "unlinked":
                        return Unlinked.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The invited object</para>
        /// </summary>
        public sealed class Invited : TrustedTeamsRequestState
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Invited> Encoder = new InvitedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Invited> Decoder = new InvitedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Invited" /> class.</para>
            /// </summary>
            private Invited()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Invited</para>
            /// </summary>
            public static readonly Invited Instance = new Invited();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Invited" />.</para>
            /// </summary>
            private class InvitedEncoder : enc.StructEncoder<Invited>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Invited value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Invited" />.</para>
            /// </summary>
            private class InvitedDecoder : enc.StructDecoder<Invited>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Invited" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Invited Create()
                {
                    return Invited.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The linked object</para>
        /// </summary>
        public sealed class Linked : TrustedTeamsRequestState
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Linked> Encoder = new LinkedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Linked> Decoder = new LinkedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Linked" /> class.</para>
            /// </summary>
            private Linked()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Linked</para>
            /// </summary>
            public static readonly Linked Instance = new Linked();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Linked" />.</para>
            /// </summary>
            private class LinkedEncoder : enc.StructEncoder<Linked>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Linked value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Linked" />.</para>
            /// </summary>
            private class LinkedDecoder : enc.StructDecoder<Linked>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Linked" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Linked Create()
                {
                    return Linked.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The unlinked object</para>
        /// </summary>
        public sealed class Unlinked : TrustedTeamsRequestState
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Unlinked> Encoder = new UnlinkedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Unlinked> Decoder = new UnlinkedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Unlinked" /> class.</para>
            /// </summary>
            private Unlinked()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Unlinked</para>
            /// </summary>
            public static readonly Unlinked Instance = new Unlinked();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Unlinked" />.</para>
            /// </summary>
            private class UnlinkedEncoder : enc.StructEncoder<Unlinked>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Unlinked value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Unlinked" />.</para>
            /// </summary>
            private class UnlinkedDecoder : enc.StructDecoder<Unlinked>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Unlinked" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Unlinked Create()
                {
                    return Unlinked.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : TrustedTeamsRequestState
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
