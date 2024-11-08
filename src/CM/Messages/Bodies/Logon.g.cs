// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cm/messages/bodies/logon.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TEKSteamClient.CM.Messages.Bodies {

  /// <summary>Holder for reflection information generated from cm/messages/bodies/logon.proto</summary>
  internal static partial class LogonReflection {

    #region Descriptor
    /// <summary>File descriptor for cm/messages/bodies/logon.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LogonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5jbS9tZXNzYWdlcy9ib2RpZXMvbG9nb24ucHJvdG8SIXRla3N0ZWFtY2xp",
            "ZW50LmNtLm1lc3NhZ2VzLmJvZGllcyL/AQoFTG9nT24SGAoQcHJvdG9jb2xf",
            "dmVyc2lvbhgBIAEoDRIPCgdjZWxsX2lkGAMgASgNEhcKD2NsaWVudF9sYW5n",
            "dWFnZRgGIAEoCRIWCg5jbGllbnRfb3NfdHlwZRgHIAEoBRIlChhzaG91bGRf",
            "cmVtZW1iZXJfcGFzc3dvcmQYCCABKAhIAIgBARIZCgxhY2NvdW50X25hbWUY",
            "MiABKAlIAYgBARIZCgxhY2Nlc3NfdG9rZW4YbCABKAlIAogBAUIbChlfc2hv",
            "dWxkX3JlbWVtYmVyX3Bhc3N3b3JkQg8KDV9hY2NvdW50X25hbWVCDwoNX2Fj",
            "Y2Vzc190b2tlbiKJAQoNTG9nT25SZXNwb25zZRITCgZyZXN1bHQYASABKAVI",
            "AIgBARIfChJoZWFydGJlYXRfaW50ZXJ2YWwYAiABKAVIAYgBARIUCgdjZWxs",
            "X2lkGAcgASgNSAKIAQFCCQoHX3Jlc3VsdEIVChNfaGVhcnRiZWF0X2ludGVy",
            "dmFsQgoKCF9jZWxsX2lkQiSqAiFURUtTdGVhbUNsaWVudC5DTS5NZXNzYWdl",
            "cy5Cb2RpZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TEKSteamClient.CM.Messages.Bodies.LogOn), global::TEKSteamClient.CM.Messages.Bodies.LogOn.Parser, new[]{ "ProtocolVersion", "CellId", "ClientLanguage", "ClientOsType", "ShouldRememberPassword", "AccountName", "AccessToken" }, new[]{ "ShouldRememberPassword", "AccountName", "AccessToken" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TEKSteamClient.CM.Messages.Bodies.LogOnResponse), global::TEKSteamClient.CM.Messages.Bodies.LogOnResponse.Parser, new[]{ "Result", "HeartbeatInterval", "CellId" }, new[]{ "Result", "HeartbeatInterval", "CellId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  internal sealed partial class LogOn : pb::IMessage<LogOn>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LogOn> _parser = new pb::MessageParser<LogOn>(() => new LogOn());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LogOn> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TEKSteamClient.CM.Messages.Bodies.LogonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogOn() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogOn(LogOn other) : this() {
      _hasBits0 = other._hasBits0;
      protocolVersion_ = other.protocolVersion_;
      cellId_ = other.cellId_;
      clientLanguage_ = other.clientLanguage_;
      clientOsType_ = other.clientOsType_;
      shouldRememberPassword_ = other.shouldRememberPassword_;
      accountName_ = other.accountName_;
      accessToken_ = other.accessToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogOn Clone() {
      return new LogOn(this);
    }

    /// <summary>Field number for the "protocol_version" field.</summary>
    public const int ProtocolVersionFieldNumber = 1;
    private uint protocolVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ProtocolVersion {
      get { return protocolVersion_; }
      set {
        protocolVersion_ = value;
      }
    }

    /// <summary>Field number for the "cell_id" field.</summary>
    public const int CellIdFieldNumber = 3;
    private uint cellId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CellId {
      get { return cellId_; }
      set {
        cellId_ = value;
      }
    }

    /// <summary>Field number for the "client_language" field.</summary>
    public const int ClientLanguageFieldNumber = 6;
    private string clientLanguage_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientLanguage {
      get { return clientLanguage_; }
      set {
        clientLanguage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_os_type" field.</summary>
    public const int ClientOsTypeFieldNumber = 7;
    private int clientOsType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ClientOsType {
      get { return clientOsType_; }
      set {
        clientOsType_ = value;
      }
    }

    /// <summary>Field number for the "should_remember_password" field.</summary>
    public const int ShouldRememberPasswordFieldNumber = 8;
    private readonly static bool ShouldRememberPasswordDefaultValue = false;

    private bool shouldRememberPassword_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ShouldRememberPassword {
      get { if ((_hasBits0 & 1) != 0) { return shouldRememberPassword_; } else { return ShouldRememberPasswordDefaultValue; } }
      set {
        _hasBits0 |= 1;
        shouldRememberPassword_ = value;
      }
    }
    /// <summary>Gets whether the "should_remember_password" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasShouldRememberPassword {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "should_remember_password" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearShouldRememberPassword() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "account_name" field.</summary>
    public const int AccountNameFieldNumber = 50;
    private readonly static string AccountNameDefaultValue = "";

    private string accountName_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AccountName {
      get { return accountName_ ?? AccountNameDefaultValue; }
      set {
        accountName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "account_name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAccountName {
      get { return accountName_ != null; }
    }
    /// <summary>Clears the value of the "account_name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAccountName() {
      accountName_ = null;
    }

    /// <summary>Field number for the "access_token" field.</summary>
    public const int AccessTokenFieldNumber = 108;
    private readonly static string AccessTokenDefaultValue = "";

    private string accessToken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AccessToken {
      get { return accessToken_ ?? AccessTokenDefaultValue; }
      set {
        accessToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "access_token" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAccessToken {
      get { return accessToken_ != null; }
    }
    /// <summary>Clears the value of the "access_token" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAccessToken() {
      accessToken_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LogOn);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LogOn other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProtocolVersion != other.ProtocolVersion) return false;
      if (CellId != other.CellId) return false;
      if (ClientLanguage != other.ClientLanguage) return false;
      if (ClientOsType != other.ClientOsType) return false;
      if (ShouldRememberPassword != other.ShouldRememberPassword) return false;
      if (AccountName != other.AccountName) return false;
      if (AccessToken != other.AccessToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ProtocolVersion != 0) hash ^= ProtocolVersion.GetHashCode();
      if (CellId != 0) hash ^= CellId.GetHashCode();
      if (ClientLanguage.Length != 0) hash ^= ClientLanguage.GetHashCode();
      if (ClientOsType != 0) hash ^= ClientOsType.GetHashCode();
      if (HasShouldRememberPassword) hash ^= ShouldRememberPassword.GetHashCode();
      if (HasAccountName) hash ^= AccountName.GetHashCode();
      if (HasAccessToken) hash ^= AccessToken.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ProtocolVersion != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ProtocolVersion);
      }
      if (CellId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CellId);
      }
      if (ClientLanguage.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ClientLanguage);
      }
      if (ClientOsType != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(ClientOsType);
      }
      if (HasShouldRememberPassword) {
        output.WriteRawTag(64);
        output.WriteBool(ShouldRememberPassword);
      }
      if (HasAccountName) {
        output.WriteRawTag(146, 3);
        output.WriteString(AccountName);
      }
      if (HasAccessToken) {
        output.WriteRawTag(226, 6);
        output.WriteString(AccessToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ProtocolVersion != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ProtocolVersion);
      }
      if (CellId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CellId);
      }
      if (ClientLanguage.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ClientLanguage);
      }
      if (ClientOsType != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(ClientOsType);
      }
      if (HasShouldRememberPassword) {
        output.WriteRawTag(64);
        output.WriteBool(ShouldRememberPassword);
      }
      if (HasAccountName) {
        output.WriteRawTag(146, 3);
        output.WriteString(AccountName);
      }
      if (HasAccessToken) {
        output.WriteRawTag(226, 6);
        output.WriteString(AccessToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ProtocolVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ProtocolVersion);
      }
      if (CellId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CellId);
      }
      if (ClientLanguage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientLanguage);
      }
      if (ClientOsType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ClientOsType);
      }
      if (HasShouldRememberPassword) {
        size += 1 + 1;
      }
      if (HasAccountName) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(AccountName);
      }
      if (HasAccessToken) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(AccessToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LogOn other) {
      if (other == null) {
        return;
      }
      if (other.ProtocolVersion != 0) {
        ProtocolVersion = other.ProtocolVersion;
      }
      if (other.CellId != 0) {
        CellId = other.CellId;
      }
      if (other.ClientLanguage.Length != 0) {
        ClientLanguage = other.ClientLanguage;
      }
      if (other.ClientOsType != 0) {
        ClientOsType = other.ClientOsType;
      }
      if (other.HasShouldRememberPassword) {
        ShouldRememberPassword = other.ShouldRememberPassword;
      }
      if (other.HasAccountName) {
        AccountName = other.AccountName;
      }
      if (other.HasAccessToken) {
        AccessToken = other.AccessToken;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ProtocolVersion = input.ReadUInt32();
            break;
          }
          case 24: {
            CellId = input.ReadUInt32();
            break;
          }
          case 50: {
            ClientLanguage = input.ReadString();
            break;
          }
          case 56: {
            ClientOsType = input.ReadInt32();
            break;
          }
          case 64: {
            ShouldRememberPassword = input.ReadBool();
            break;
          }
          case 402: {
            AccountName = input.ReadString();
            break;
          }
          case 866: {
            AccessToken = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ProtocolVersion = input.ReadUInt32();
            break;
          }
          case 24: {
            CellId = input.ReadUInt32();
            break;
          }
          case 50: {
            ClientLanguage = input.ReadString();
            break;
          }
          case 56: {
            ClientOsType = input.ReadInt32();
            break;
          }
          case 64: {
            ShouldRememberPassword = input.ReadBool();
            break;
          }
          case 402: {
            AccountName = input.ReadString();
            break;
          }
          case 866: {
            AccessToken = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  internal sealed partial class LogOnResponse : pb::IMessage<LogOnResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LogOnResponse> _parser = new pb::MessageParser<LogOnResponse>(() => new LogOnResponse());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LogOnResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TEKSteamClient.CM.Messages.Bodies.LogonReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogOnResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogOnResponse(LogOnResponse other) : this() {
      _hasBits0 = other._hasBits0;
      result_ = other.result_;
      heartbeatInterval_ = other.heartbeatInterval_;
      cellId_ = other.cellId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogOnResponse Clone() {
      return new LogOnResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private readonly static int ResultDefaultValue = 0;

    private int result_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Result {
      get { if ((_hasBits0 & 1) != 0) { return result_; } else { return ResultDefaultValue; } }
      set {
        _hasBits0 |= 1;
        result_ = value;
      }
    }
    /// <summary>Gets whether the "result" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasResult {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "result" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearResult() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "heartbeat_interval" field.</summary>
    public const int HeartbeatIntervalFieldNumber = 2;
    private readonly static int HeartbeatIntervalDefaultValue = 0;

    private int heartbeatInterval_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int HeartbeatInterval {
      get { if ((_hasBits0 & 2) != 0) { return heartbeatInterval_; } else { return HeartbeatIntervalDefaultValue; } }
      set {
        _hasBits0 |= 2;
        heartbeatInterval_ = value;
      }
    }
    /// <summary>Gets whether the "heartbeat_interval" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasHeartbeatInterval {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "heartbeat_interval" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearHeartbeatInterval() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "cell_id" field.</summary>
    public const int CellIdFieldNumber = 7;
    private readonly static uint CellIdDefaultValue = 0;

    private uint cellId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CellId {
      get { if ((_hasBits0 & 4) != 0) { return cellId_; } else { return CellIdDefaultValue; } }
      set {
        _hasBits0 |= 4;
        cellId_ = value;
      }
    }
    /// <summary>Gets whether the "cell_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCellId {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "cell_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCellId() {
      _hasBits0 &= ~4;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LogOnResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LogOnResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (HeartbeatInterval != other.HeartbeatInterval) return false;
      if (CellId != other.CellId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasResult) hash ^= Result.GetHashCode();
      if (HasHeartbeatInterval) hash ^= HeartbeatInterval.GetHashCode();
      if (HasCellId) hash ^= CellId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasResult) {
        output.WriteRawTag(8);
        output.WriteInt32(Result);
      }
      if (HasHeartbeatInterval) {
        output.WriteRawTag(16);
        output.WriteInt32(HeartbeatInterval);
      }
      if (HasCellId) {
        output.WriteRawTag(56);
        output.WriteUInt32(CellId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasResult) {
        output.WriteRawTag(8);
        output.WriteInt32(Result);
      }
      if (HasHeartbeatInterval) {
        output.WriteRawTag(16);
        output.WriteInt32(HeartbeatInterval);
      }
      if (HasCellId) {
        output.WriteRawTag(56);
        output.WriteUInt32(CellId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasResult) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Result);
      }
      if (HasHeartbeatInterval) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(HeartbeatInterval);
      }
      if (HasCellId) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CellId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LogOnResponse other) {
      if (other == null) {
        return;
      }
      if (other.HasResult) {
        Result = other.Result;
      }
      if (other.HasHeartbeatInterval) {
        HeartbeatInterval = other.HeartbeatInterval;
      }
      if (other.HasCellId) {
        CellId = other.CellId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Result = input.ReadInt32();
            break;
          }
          case 16: {
            HeartbeatInterval = input.ReadInt32();
            break;
          }
          case 56: {
            CellId = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Result = input.ReadInt32();
            break;
          }
          case 16: {
            HeartbeatInterval = input.ReadInt32();
            break;
          }
          case 56: {
            CellId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
