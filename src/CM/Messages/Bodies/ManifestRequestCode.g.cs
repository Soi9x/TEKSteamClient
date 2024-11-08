// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cm/messages/bodies/manifest_request_code.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TEKSteamClient.CM.Messages.Bodies {

  /// <summary>Holder for reflection information generated from cm/messages/bodies/manifest_request_code.proto</summary>
  internal static partial class ManifestRequestCodeReflection {

    #region Descriptor
    /// <summary>File descriptor for cm/messages/bodies/manifest_request_code.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ManifestRequestCodeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5jbS9tZXNzYWdlcy9ib2RpZXMvbWFuaWZlc3RfcmVxdWVzdF9jb2RlLnBy",
            "b3RvEiF0ZWtzdGVhbWNsaWVudC5jbS5tZXNzYWdlcy5ib2RpZXMiYAoTTWFu",
            "aWZlc3RSZXF1ZXN0Q29kZRIOCgZhcHBfaWQYASABKA0SEAoIZGVwb3RfaWQY",
            "AiABKA0SEwoLbWFuaWZlc3RfaWQYAyABKAQSEgoKYXBwX2JyYW5jaBgEIAEo",
            "CSJJChtNYW5pZmVzdFJlcXVlc3RDb2RlUmVzcG9uc2USGQoMcmVxdWVzdF9j",
            "b2RlGAEgASgESACIAQFCDwoNX3JlcXVlc3RfY29kZUIkqgIhVEVLU3RlYW1D",
            "bGllbnQuQ00uTWVzc2FnZXMuQm9kaWVzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TEKSteamClient.CM.Messages.Bodies.ManifestRequestCode), global::TEKSteamClient.CM.Messages.Bodies.ManifestRequestCode.Parser, new[]{ "AppId", "DepotId", "ManifestId", "AppBranch" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TEKSteamClient.CM.Messages.Bodies.ManifestRequestCodeResponse), global::TEKSteamClient.CM.Messages.Bodies.ManifestRequestCodeResponse.Parser, new[]{ "RequestCode" }, new[]{ "RequestCode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  internal sealed partial class ManifestRequestCode : pb::IMessage<ManifestRequestCode>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ManifestRequestCode> _parser = new pb::MessageParser<ManifestRequestCode>(() => new ManifestRequestCode());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ManifestRequestCode> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TEKSteamClient.CM.Messages.Bodies.ManifestRequestCodeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ManifestRequestCode() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ManifestRequestCode(ManifestRequestCode other) : this() {
      appId_ = other.appId_;
      depotId_ = other.depotId_;
      manifestId_ = other.manifestId_;
      appBranch_ = other.appBranch_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ManifestRequestCode Clone() {
      return new ManifestRequestCode(this);
    }

    /// <summary>Field number for the "app_id" field.</summary>
    public const int AppIdFieldNumber = 1;
    private uint appId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AppId {
      get { return appId_; }
      set {
        appId_ = value;
      }
    }

    /// <summary>Field number for the "depot_id" field.</summary>
    public const int DepotIdFieldNumber = 2;
    private uint depotId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DepotId {
      get { return depotId_; }
      set {
        depotId_ = value;
      }
    }

    /// <summary>Field number for the "manifest_id" field.</summary>
    public const int ManifestIdFieldNumber = 3;
    private ulong manifestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ManifestId {
      get { return manifestId_; }
      set {
        manifestId_ = value;
      }
    }

    /// <summary>Field number for the "app_branch" field.</summary>
    public const int AppBranchFieldNumber = 4;
    private string appBranch_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AppBranch {
      get { return appBranch_; }
      set {
        appBranch_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ManifestRequestCode);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ManifestRequestCode other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AppId != other.AppId) return false;
      if (DepotId != other.DepotId) return false;
      if (ManifestId != other.ManifestId) return false;
      if (AppBranch != other.AppBranch) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AppId != 0) hash ^= AppId.GetHashCode();
      if (DepotId != 0) hash ^= DepotId.GetHashCode();
      if (ManifestId != 0UL) hash ^= ManifestId.GetHashCode();
      if (AppBranch.Length != 0) hash ^= AppBranch.GetHashCode();
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
      if (AppId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AppId);
      }
      if (DepotId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DepotId);
      }
      if (ManifestId != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(ManifestId);
      }
      if (AppBranch.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AppBranch);
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
      if (AppId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AppId);
      }
      if (DepotId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DepotId);
      }
      if (ManifestId != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(ManifestId);
      }
      if (AppBranch.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AppBranch);
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
      if (AppId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AppId);
      }
      if (DepotId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DepotId);
      }
      if (ManifestId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ManifestId);
      }
      if (AppBranch.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AppBranch);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ManifestRequestCode other) {
      if (other == null) {
        return;
      }
      if (other.AppId != 0) {
        AppId = other.AppId;
      }
      if (other.DepotId != 0) {
        DepotId = other.DepotId;
      }
      if (other.ManifestId != 0UL) {
        ManifestId = other.ManifestId;
      }
      if (other.AppBranch.Length != 0) {
        AppBranch = other.AppBranch;
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
            AppId = input.ReadUInt32();
            break;
          }
          case 16: {
            DepotId = input.ReadUInt32();
            break;
          }
          case 24: {
            ManifestId = input.ReadUInt64();
            break;
          }
          case 34: {
            AppBranch = input.ReadString();
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
            AppId = input.ReadUInt32();
            break;
          }
          case 16: {
            DepotId = input.ReadUInt32();
            break;
          }
          case 24: {
            ManifestId = input.ReadUInt64();
            break;
          }
          case 34: {
            AppBranch = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  internal sealed partial class ManifestRequestCodeResponse : pb::IMessage<ManifestRequestCodeResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ManifestRequestCodeResponse> _parser = new pb::MessageParser<ManifestRequestCodeResponse>(() => new ManifestRequestCodeResponse());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ManifestRequestCodeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TEKSteamClient.CM.Messages.Bodies.ManifestRequestCodeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ManifestRequestCodeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ManifestRequestCodeResponse(ManifestRequestCodeResponse other) : this() {
      _hasBits0 = other._hasBits0;
      requestCode_ = other.requestCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ManifestRequestCodeResponse Clone() {
      return new ManifestRequestCodeResponse(this);
    }

    /// <summary>Field number for the "request_code" field.</summary>
    public const int RequestCodeFieldNumber = 1;
    private readonly static ulong RequestCodeDefaultValue = 0UL;

    private ulong requestCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong RequestCode {
      get { if ((_hasBits0 & 1) != 0) { return requestCode_; } else { return RequestCodeDefaultValue; } }
      set {
        _hasBits0 |= 1;
        requestCode_ = value;
      }
    }
    /// <summary>Gets whether the "request_code" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasRequestCode {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "request_code" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearRequestCode() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ManifestRequestCodeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ManifestRequestCodeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RequestCode != other.RequestCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasRequestCode) hash ^= RequestCode.GetHashCode();
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
      if (HasRequestCode) {
        output.WriteRawTag(8);
        output.WriteUInt64(RequestCode);
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
      if (HasRequestCode) {
        output.WriteRawTag(8);
        output.WriteUInt64(RequestCode);
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
      if (HasRequestCode) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(RequestCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ManifestRequestCodeResponse other) {
      if (other == null) {
        return;
      }
      if (other.HasRequestCode) {
        RequestCode = other.RequestCode;
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
            RequestCode = input.ReadUInt64();
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
            RequestCode = input.ReadUInt64();
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
