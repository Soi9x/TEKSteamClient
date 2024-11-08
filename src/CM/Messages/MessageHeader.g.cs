// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cm/messages/message_header.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TEKSteamClient.CM.Messages {

  /// <summary>Holder for reflection information generated from cm/messages/message_header.proto</summary>
  internal static partial class MessageHeaderReflection {

    #region Descriptor
    /// <summary>File descriptor for cm/messages/message_header.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageHeaderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBjbS9tZXNzYWdlcy9tZXNzYWdlX2hlYWRlci5wcm90bxIadGVrc3RlYW1j",
            "bGllbnQuY20ubWVzc2FnZXMiiQIKDU1lc3NhZ2VIZWFkZXISFQoIc3RlYW1f",
            "aWQYASABKAZIAIgBARIXCgpzZXNzaW9uX2lkGAIgASgFSAGIAQESGgoNc291",
            "cmNlX2pvYl9pZBgKIAEoBkgCiAEBEhoKDXRhcmdldF9qb2JfaWQYCyABKAZI",
            "A4gBARIcCg90YXJnZXRfam9iX25hbWUYDCABKAlIBIgBARITCgZyZXN1bHQY",
            "DSABKAVIBYgBAUILCglfc3RlYW1faWRCDQoLX3Nlc3Npb25faWRCEAoOX3Nv",
            "dXJjZV9qb2JfaWRCEAoOX3RhcmdldF9qb2JfaWRCEgoQX3RhcmdldF9qb2Jf",
            "bmFtZUIJCgdfcmVzdWx0Qh2qAhpURUtTdGVhbUNsaWVudC5DTS5NZXNzYWdl",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TEKSteamClient.CM.Messages.MessageHeader), global::TEKSteamClient.CM.Messages.MessageHeader.Parser, new[]{ "SteamId", "SessionId", "SourceJobId", "TargetJobId", "TargetJobName", "Result" }, new[]{ "SteamId", "SessionId", "SourceJobId", "TargetJobId", "TargetJobName", "Result" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  internal sealed partial class MessageHeader : pb::IMessage<MessageHeader>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MessageHeader> _parser = new pb::MessageParser<MessageHeader>(() => new MessageHeader());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MessageHeader> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TEKSteamClient.CM.Messages.MessageHeaderReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageHeader() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageHeader(MessageHeader other) : this() {
      _hasBits0 = other._hasBits0;
      steamId_ = other.steamId_;
      sessionId_ = other.sessionId_;
      sourceJobId_ = other.sourceJobId_;
      targetJobId_ = other.targetJobId_;
      targetJobName_ = other.targetJobName_;
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageHeader Clone() {
      return new MessageHeader(this);
    }

    /// <summary>Field number for the "steam_id" field.</summary>
    public const int SteamIdFieldNumber = 1;
    private readonly static ulong SteamIdDefaultValue = 0UL;

    private ulong steamId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong SteamId {
      get { if ((_hasBits0 & 1) != 0) { return steamId_; } else { return SteamIdDefaultValue; } }
      set {
        _hasBits0 |= 1;
        steamId_ = value;
      }
    }
    /// <summary>Gets whether the "steam_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasSteamId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "steam_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSteamId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "session_id" field.</summary>
    public const int SessionIdFieldNumber = 2;
    private readonly static int SessionIdDefaultValue = 0;

    private int sessionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SessionId {
      get { if ((_hasBits0 & 2) != 0) { return sessionId_; } else { return SessionIdDefaultValue; } }
      set {
        _hasBits0 |= 2;
        sessionId_ = value;
      }
    }
    /// <summary>Gets whether the "session_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasSessionId {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "session_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSessionId() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "source_job_id" field.</summary>
    public const int SourceJobIdFieldNumber = 10;
    private readonly static ulong SourceJobIdDefaultValue = 0UL;

    private ulong sourceJobId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong SourceJobId {
      get { if ((_hasBits0 & 4) != 0) { return sourceJobId_; } else { return SourceJobIdDefaultValue; } }
      set {
        _hasBits0 |= 4;
        sourceJobId_ = value;
      }
    }
    /// <summary>Gets whether the "source_job_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasSourceJobId {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "source_job_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSourceJobId() {
      _hasBits0 &= ~4;
    }

    /// <summary>Field number for the "target_job_id" field.</summary>
    public const int TargetJobIdFieldNumber = 11;
    private readonly static ulong TargetJobIdDefaultValue = 0UL;

    private ulong targetJobId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TargetJobId {
      get { if ((_hasBits0 & 8) != 0) { return targetJobId_; } else { return TargetJobIdDefaultValue; } }
      set {
        _hasBits0 |= 8;
        targetJobId_ = value;
      }
    }
    /// <summary>Gets whether the "target_job_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTargetJobId {
      get { return (_hasBits0 & 8) != 0; }
    }
    /// <summary>Clears the value of the "target_job_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTargetJobId() {
      _hasBits0 &= ~8;
    }

    /// <summary>Field number for the "target_job_name" field.</summary>
    public const int TargetJobNameFieldNumber = 12;
    private readonly static string TargetJobNameDefaultValue = "";

    private string targetJobName_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TargetJobName {
      get { return targetJobName_ ?? TargetJobNameDefaultValue; }
      set {
        targetJobName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "target_job_name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTargetJobName {
      get { return targetJobName_ != null; }
    }
    /// <summary>Clears the value of the "target_job_name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTargetJobName() {
      targetJobName_ = null;
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 13;
    private readonly static int ResultDefaultValue = 0;

    private int result_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Result {
      get { if ((_hasBits0 & 16) != 0) { return result_; } else { return ResultDefaultValue; } }
      set {
        _hasBits0 |= 16;
        result_ = value;
      }
    }
    /// <summary>Gets whether the "result" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasResult {
      get { return (_hasBits0 & 16) != 0; }
    }
    /// <summary>Clears the value of the "result" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearResult() {
      _hasBits0 &= ~16;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MessageHeader);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MessageHeader other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SteamId != other.SteamId) return false;
      if (SessionId != other.SessionId) return false;
      if (SourceJobId != other.SourceJobId) return false;
      if (TargetJobId != other.TargetJobId) return false;
      if (TargetJobName != other.TargetJobName) return false;
      if (Result != other.Result) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasSteamId) hash ^= SteamId.GetHashCode();
      if (HasSessionId) hash ^= SessionId.GetHashCode();
      if (HasSourceJobId) hash ^= SourceJobId.GetHashCode();
      if (HasTargetJobId) hash ^= TargetJobId.GetHashCode();
      if (HasTargetJobName) hash ^= TargetJobName.GetHashCode();
      if (HasResult) hash ^= Result.GetHashCode();
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
      if (HasSteamId) {
        output.WriteRawTag(9);
        output.WriteFixed64(SteamId);
      }
      if (HasSessionId) {
        output.WriteRawTag(16);
        output.WriteInt32(SessionId);
      }
      if (HasSourceJobId) {
        output.WriteRawTag(81);
        output.WriteFixed64(SourceJobId);
      }
      if (HasTargetJobId) {
        output.WriteRawTag(89);
        output.WriteFixed64(TargetJobId);
      }
      if (HasTargetJobName) {
        output.WriteRawTag(98);
        output.WriteString(TargetJobName);
      }
      if (HasResult) {
        output.WriteRawTag(104);
        output.WriteInt32(Result);
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
      if (HasSteamId) {
        output.WriteRawTag(9);
        output.WriteFixed64(SteamId);
      }
      if (HasSessionId) {
        output.WriteRawTag(16);
        output.WriteInt32(SessionId);
      }
      if (HasSourceJobId) {
        output.WriteRawTag(81);
        output.WriteFixed64(SourceJobId);
      }
      if (HasTargetJobId) {
        output.WriteRawTag(89);
        output.WriteFixed64(TargetJobId);
      }
      if (HasTargetJobName) {
        output.WriteRawTag(98);
        output.WriteString(TargetJobName);
      }
      if (HasResult) {
        output.WriteRawTag(104);
        output.WriteInt32(Result);
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
      if (HasSteamId) {
        size += 1 + 8;
      }
      if (HasSessionId) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SessionId);
      }
      if (HasSourceJobId) {
        size += 1 + 8;
      }
      if (HasTargetJobId) {
        size += 1 + 8;
      }
      if (HasTargetJobName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetJobName);
      }
      if (HasResult) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Result);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MessageHeader other) {
      if (other == null) {
        return;
      }
      if (other.HasSteamId) {
        SteamId = other.SteamId;
      }
      if (other.HasSessionId) {
        SessionId = other.SessionId;
      }
      if (other.HasSourceJobId) {
        SourceJobId = other.SourceJobId;
      }
      if (other.HasTargetJobId) {
        TargetJobId = other.TargetJobId;
      }
      if (other.HasTargetJobName) {
        TargetJobName = other.TargetJobName;
      }
      if (other.HasResult) {
        Result = other.Result;
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
          case 9: {
            SteamId = input.ReadFixed64();
            break;
          }
          case 16: {
            SessionId = input.ReadInt32();
            break;
          }
          case 81: {
            SourceJobId = input.ReadFixed64();
            break;
          }
          case 89: {
            TargetJobId = input.ReadFixed64();
            break;
          }
          case 98: {
            TargetJobName = input.ReadString();
            break;
          }
          case 104: {
            Result = input.ReadInt32();
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
          case 9: {
            SteamId = input.ReadFixed64();
            break;
          }
          case 16: {
            SessionId = input.ReadInt32();
            break;
          }
          case 81: {
            SourceJobId = input.ReadFixed64();
            break;
          }
          case 89: {
            TargetJobId = input.ReadFixed64();
            break;
          }
          case 98: {
            TargetJobName = input.ReadString();
            break;
          }
          case 104: {
            Result = input.ReadInt32();
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
