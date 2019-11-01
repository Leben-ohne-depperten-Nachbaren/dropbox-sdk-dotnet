// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Paper
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The add paper doc user result object</para>
    /// </summary>
    public class AddPaperDocUserResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AddPaperDocUserResult> Encoder = new AddPaperDocUserResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AddPaperDocUserResult> Decoder = new AddPaperDocUserResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AddPaperDocUserResult" />
        /// class.</para>
        /// </summary>
        public AddPaperDocUserResult()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Success</para>
        /// </summary>
        public bool IsSuccess
        {
            get
            {
                return this is Success;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Success, or <c>null</c>.</para>
        /// </summary>
        public Success AsSuccess
        {
            get
            {
                return this as Success;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UnknownError</para>
        /// </summary>
        public bool IsUnknownError
        {
            get
            {
                return this is UnknownError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UnknownError, or <c>null</c>.</para>
        /// </summary>
        public UnknownError AsUnknownError
        {
            get
            {
                return this as UnknownError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// SharingOutsideTeamDisabled</para>
        /// </summary>
        public bool IsSharingOutsideTeamDisabled
        {
            get
            {
                return this is SharingOutsideTeamDisabled;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a SharingOutsideTeamDisabled, or <c>null</c>.</para>
        /// </summary>
        public SharingOutsideTeamDisabled AsSharingOutsideTeamDisabled
        {
            get
            {
                return this as SharingOutsideTeamDisabled;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is DailyLimitReached</para>
        /// </summary>
        public bool IsDailyLimitReached
        {
            get
            {
                return this is DailyLimitReached;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a DailyLimitReached, or <c>null</c>.</para>
        /// </summary>
        public DailyLimitReached AsDailyLimitReached
        {
            get
            {
                return this as DailyLimitReached;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UserIsOwner</para>
        /// </summary>
        public bool IsUserIsOwner
        {
            get
            {
                return this is UserIsOwner;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UserIsOwner, or <c>null</c>.</para>
        /// </summary>
        public UserIsOwner AsUserIsOwner
        {
            get
            {
                return this as UserIsOwner;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// FailedUserDataRetrieval</para>
        /// </summary>
        public bool IsFailedUserDataRetrieval
        {
            get
            {
                return this is FailedUserDataRetrieval;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a FailedUserDataRetrieval, or <c>null</c>.</para>
        /// </summary>
        public FailedUserDataRetrieval AsFailedUserDataRetrieval
        {
            get
            {
                return this as FailedUserDataRetrieval;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// PermissionAlreadyGranted</para>
        /// </summary>
        public bool IsPermissionAlreadyGranted
        {
            get
            {
                return this is PermissionAlreadyGranted;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a PermissionAlreadyGranted, or <c>null</c>.</para>
        /// </summary>
        public PermissionAlreadyGranted AsPermissionAlreadyGranted
        {
            get
            {
                return this as PermissionAlreadyGranted;
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
        /// <para>Encoder for  <see cref="AddPaperDocUserResult" />.</para>
        /// </summary>
        private class AddPaperDocUserResultEncoder : enc.StructEncoder<AddPaperDocUserResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AddPaperDocUserResult value, enc.IJsonWriter writer)
            {
                if (value is Success)
                {
                    WriteProperty(".tag", "success", writer, enc.StringEncoder.Instance);
                    Success.Encoder.EncodeFields((Success)value, writer);
                    return;
                }
                if (value is UnknownError)
                {
                    WriteProperty(".tag", "unknown_error", writer, enc.StringEncoder.Instance);
                    UnknownError.Encoder.EncodeFields((UnknownError)value, writer);
                    return;
                }
                if (value is SharingOutsideTeamDisabled)
                {
                    WriteProperty(".tag", "sharing_outside_team_disabled", writer, enc.StringEncoder.Instance);
                    SharingOutsideTeamDisabled.Encoder.EncodeFields((SharingOutsideTeamDisabled)value, writer);
                    return;
                }
                if (value is DailyLimitReached)
                {
                    WriteProperty(".tag", "daily_limit_reached", writer, enc.StringEncoder.Instance);
                    DailyLimitReached.Encoder.EncodeFields((DailyLimitReached)value, writer);
                    return;
                }
                if (value is UserIsOwner)
                {
                    WriteProperty(".tag", "user_is_owner", writer, enc.StringEncoder.Instance);
                    UserIsOwner.Encoder.EncodeFields((UserIsOwner)value, writer);
                    return;
                }
                if (value is FailedUserDataRetrieval)
                {
                    WriteProperty(".tag", "failed_user_data_retrieval", writer, enc.StringEncoder.Instance);
                    FailedUserDataRetrieval.Encoder.EncodeFields((FailedUserDataRetrieval)value, writer);
                    return;
                }
                if (value is PermissionAlreadyGranted)
                {
                    WriteProperty(".tag", "permission_already_granted", writer, enc.StringEncoder.Instance);
                    PermissionAlreadyGranted.Encoder.EncodeFields((PermissionAlreadyGranted)value, writer);
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
        /// <para>Decoder for  <see cref="AddPaperDocUserResult" />.</para>
        /// </summary>
        private class AddPaperDocUserResultDecoder : enc.UnionDecoder<AddPaperDocUserResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AddPaperDocUserResult"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AddPaperDocUserResult Create()
            {
                return new AddPaperDocUserResult();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override AddPaperDocUserResult Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "success":
                        return Success.Decoder.DecodeFields(reader);
                    case "unknown_error":
                        return UnknownError.Decoder.DecodeFields(reader);
                    case "sharing_outside_team_disabled":
                        return SharingOutsideTeamDisabled.Decoder.DecodeFields(reader);
                    case "daily_limit_reached":
                        return DailyLimitReached.Decoder.DecodeFields(reader);
                    case "user_is_owner":
                        return UserIsOwner.Decoder.DecodeFields(reader);
                    case "failed_user_data_retrieval":
                        return FailedUserDataRetrieval.Decoder.DecodeFields(reader);
                    case "permission_already_granted":
                        return PermissionAlreadyGranted.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>User was successfully added to the Paper doc.</para>
        /// </summary>
        public sealed class Success : AddPaperDocUserResult
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Success> Encoder = new SuccessEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Success> Decoder = new SuccessDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Success" /> class.</para>
            /// </summary>
            private Success()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Success</para>
            /// </summary>
            public static readonly Success Instance = new Success();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Success" />.</para>
            /// </summary>
            private class SuccessEncoder : enc.StructEncoder<Success>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Success value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Success" />.</para>
            /// </summary>
            private class SuccessDecoder : enc.StructDecoder<Success>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Success" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Success Create()
                {
                    return Success.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Something unexpected happened when trying to add the user to the Paper
        /// doc.</para>
        /// </summary>
        public sealed class UnknownError : AddPaperDocUserResult
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UnknownError> Encoder = new UnknownErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UnknownError> Decoder = new UnknownErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UnknownError" />
            /// class.</para>
            /// </summary>
            private UnknownError()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UnknownError</para>
            /// </summary>
            public static readonly UnknownError Instance = new UnknownError();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UnknownError" />.</para>
            /// </summary>
            private class UnknownErrorEncoder : enc.StructEncoder<UnknownError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UnknownError value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UnknownError" />.</para>
            /// </summary>
            private class UnknownErrorDecoder : enc.StructDecoder<UnknownError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UnknownError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UnknownError Create()
                {
                    return UnknownError.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The Paper doc can be shared only with team members.</para>
        /// </summary>
        public sealed class SharingOutsideTeamDisabled : AddPaperDocUserResult
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<SharingOutsideTeamDisabled> Encoder = new SharingOutsideTeamDisabledEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<SharingOutsideTeamDisabled> Decoder = new SharingOutsideTeamDisabledDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="SharingOutsideTeamDisabled"
            /// /> class.</para>
            /// </summary>
            private SharingOutsideTeamDisabled()
            {
            }

            /// <summary>
            /// <para>A singleton instance of SharingOutsideTeamDisabled</para>
            /// </summary>
            public static readonly SharingOutsideTeamDisabled Instance = new SharingOutsideTeamDisabled();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="SharingOutsideTeamDisabled" />.</para>
            /// </summary>
            private class SharingOutsideTeamDisabledEncoder : enc.StructEncoder<SharingOutsideTeamDisabled>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(SharingOutsideTeamDisabled value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="SharingOutsideTeamDisabled" />.</para>
            /// </summary>
            private class SharingOutsideTeamDisabledDecoder : enc.StructDecoder<SharingOutsideTeamDisabled>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="SharingOutsideTeamDisabled"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override SharingOutsideTeamDisabled Create()
                {
                    return SharingOutsideTeamDisabled.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The daily limit of how many users can be added to the Paper doc was
        /// reached.</para>
        /// </summary>
        public sealed class DailyLimitReached : AddPaperDocUserResult
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<DailyLimitReached> Encoder = new DailyLimitReachedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<DailyLimitReached> Decoder = new DailyLimitReachedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DailyLimitReached" />
            /// class.</para>
            /// </summary>
            private DailyLimitReached()
            {
            }

            /// <summary>
            /// <para>A singleton instance of DailyLimitReached</para>
            /// </summary>
            public static readonly DailyLimitReached Instance = new DailyLimitReached();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="DailyLimitReached" />.</para>
            /// </summary>
            private class DailyLimitReachedEncoder : enc.StructEncoder<DailyLimitReached>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(DailyLimitReached value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="DailyLimitReached" />.</para>
            /// </summary>
            private class DailyLimitReachedDecoder : enc.StructDecoder<DailyLimitReached>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="DailyLimitReached"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override DailyLimitReached Create()
                {
                    return DailyLimitReached.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Owner's permissions cannot be changed.</para>
        /// </summary>
        public sealed class UserIsOwner : AddPaperDocUserResult
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UserIsOwner> Encoder = new UserIsOwnerEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UserIsOwner> Decoder = new UserIsOwnerDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UserIsOwner" />
            /// class.</para>
            /// </summary>
            private UserIsOwner()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UserIsOwner</para>
            /// </summary>
            public static readonly UserIsOwner Instance = new UserIsOwner();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UserIsOwner" />.</para>
            /// </summary>
            private class UserIsOwnerEncoder : enc.StructEncoder<UserIsOwner>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UserIsOwner value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UserIsOwner" />.</para>
            /// </summary>
            private class UserIsOwnerDecoder : enc.StructDecoder<UserIsOwner>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UserIsOwner" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UserIsOwner Create()
                {
                    return UserIsOwner.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>User data could not be retrieved. Clients should retry.</para>
        /// </summary>
        public sealed class FailedUserDataRetrieval : AddPaperDocUserResult
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<FailedUserDataRetrieval> Encoder = new FailedUserDataRetrievalEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<FailedUserDataRetrieval> Decoder = new FailedUserDataRetrievalDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="FailedUserDataRetrieval" />
            /// class.</para>
            /// </summary>
            private FailedUserDataRetrieval()
            {
            }

            /// <summary>
            /// <para>A singleton instance of FailedUserDataRetrieval</para>
            /// </summary>
            public static readonly FailedUserDataRetrieval Instance = new FailedUserDataRetrieval();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="FailedUserDataRetrieval" />.</para>
            /// </summary>
            private class FailedUserDataRetrievalEncoder : enc.StructEncoder<FailedUserDataRetrieval>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(FailedUserDataRetrieval value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="FailedUserDataRetrieval" />.</para>
            /// </summary>
            private class FailedUserDataRetrievalDecoder : enc.StructDecoder<FailedUserDataRetrieval>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="FailedUserDataRetrieval"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override FailedUserDataRetrieval Create()
                {
                    return FailedUserDataRetrieval.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>This user already has the correct permission to the Paper doc.</para>
        /// </summary>
        public sealed class PermissionAlreadyGranted : AddPaperDocUserResult
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<PermissionAlreadyGranted> Encoder = new PermissionAlreadyGrantedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<PermissionAlreadyGranted> Decoder = new PermissionAlreadyGrantedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PermissionAlreadyGranted" />
            /// class.</para>
            /// </summary>
            private PermissionAlreadyGranted()
            {
            }

            /// <summary>
            /// <para>A singleton instance of PermissionAlreadyGranted</para>
            /// </summary>
            public static readonly PermissionAlreadyGranted Instance = new PermissionAlreadyGranted();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="PermissionAlreadyGranted" />.</para>
            /// </summary>
            private class PermissionAlreadyGrantedEncoder : enc.StructEncoder<PermissionAlreadyGranted>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(PermissionAlreadyGranted value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="PermissionAlreadyGranted" />.</para>
            /// </summary>
            private class PermissionAlreadyGrantedDecoder : enc.StructDecoder<PermissionAlreadyGranted>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="PermissionAlreadyGranted"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override PermissionAlreadyGranted Create()
                {
                    return PermissionAlreadyGranted.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : AddPaperDocUserResult
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