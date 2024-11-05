// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cm/messages/bodies/depot_patch_info.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TEKSteamClient.CM.Messages.Bodies {

  /// <summary>Holder for reflection information generated from cm/messages/bodies/depot_patch_info.proto</summary>
  internal static partial class DepotPatchInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for cm/messages/bodies/depot_patch_info.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DepotPatchInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiljbS9tZXNzYWdlcy9ib2RpZXMvZGVwb3RfcGF0Y2hfaW5mby5wcm90bxIh",
            "dGVrc3RlYW1jbGllbnQuY20ubWVzc2FnZXMuYm9kaWVzImoKDkRlcG90UGF0",
            "Y2hJbmZvEg4KBmFwcF9pZBgBIAEoDRIQCghkZXBvdF9pZBgCIAEoDRIaChJz",
            "b3VyY2VfbWFuaWZlc3RfaWQYAyABKAQSGgoSdGFyZ2V0X21hbmlmZXN0X2lk",
            "GAQgASgEIi4KFkRlcG90UGF0Y2hJbmZvUmVzcG9uc2USFAoMaXNfYXZhaWxh",
            "YmxlGAEgASgIQiSqAiFURUtTdGVhbUNsaWVudC5DTS5NZXNzYWdlcy5Cb2Rp",
            "ZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TEKSteamClient.CM.Messages.Bodies.DepotPatchInfo), global::TEKSteamClient.CM.Messages.Bodies.DepotPatchInfo.Parser, new[]{ "AppId", "DepotId", "SourceManifestId", "TargetManifestId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TEKSteamClient.CM.Messages.Bodies.DepotPatchInfoResponse), global::TEKSteamClient.CM.Messages.Bodies.DepotPatchInfoResponse.Parser, new[]{ "IsAvailable" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  internal sealed partial class DepotPatchInfo : pb::IMessage<DepotPatchInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DepotPatchInfo> _parser = new pb::MessageParser<DepotPatchInfo>(() => new DepotPatchInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DepotPatchInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TEKSteamClient.CM.Messages.Bodies.DepotPatchInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DepotPatchInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DepotPatchInfo(DepotPatchInfo other) : this() {
      appId_ = other.appId_;
      depotId_ = other.depotId_;
      sourceManifestId_ = other.sourceManifestId_;
      targetManifestId_ = other.targetManifestId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DepotPatchInfo Clone() {
      return new DepotPatchInfo(this);
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

    /// <summary>Field number for the "source_manifest_id" field.</summary>
    public const int SourceManifestIdFieldNumber = 3;
    private ulong sourceManifestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong SourceManifestId {
      get { return sourceManifestId_; }
      set {
        sourceManifestId_ = value;
      }
    }

    /// <summary>Field number for the "target_manifest_id" field.</summary>
    public const int TargetManifestIdFieldNumber = 4;
    private ulong targetManifestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TargetManifestId {
      get { return targetManifestId_; }
      set {
        targetManifestId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DepotPatchInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DepotPatchInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AppId != other.AppId) return false;
      if (DepotId != other.DepotId) return false;
      if (SourceManifestId != other.SourceManifestId) return false;
      if (TargetManifestId != other.TargetManifestId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AppId != 0) hash ^= AppId.GetHashCode();
      if (DepotId != 0) hash ^= DepotId.GetHashCode();
      if (SourceManifestId != 0UL) hash ^= SourceManifestId.GetHashCode();
      if (TargetManifestId != 0UL) hash ^= TargetManifestId.GetHashCode();
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
      if (SourceManifestId != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(SourceManifestId);
      }
      if (TargetManifestId != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(TargetManifestId);
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
      if (SourceManifestId != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(SourceManifestId);
      }
      if (TargetManifestId != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(TargetManifestId);
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
      if (SourceManifestId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(SourceManifestId);
      }
      if (TargetManifestId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TargetManifestId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DepotPatchInfo other) {
      if (other == null) {
        return;
      }
      if (other.AppId != 0) {
        AppId = other.AppId;
      }
      if (other.DepotId != 0) {
        DepotId = other.DepotId;
      }
      if (other.SourceManifestId != 0UL) {
        SourceManifestId = other.SourceManifestId;
      }
      if (other.TargetManifestId != 0UL) {
        TargetManifestId = other.TargetManifestId;
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
            SourceManifestId = input.ReadUInt64();
            break;
          }
          case 32: {
            TargetManifestId = input.ReadUInt64();
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
            SourceManifestId = input.ReadUInt64();
            break;
          }
          case 32: {
            TargetManifestId = input.ReadUInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  internal sealed partial class DepotPatchInfoResponse : pb::IMessage<DepotPatchInfoResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DepotPatchInfoResponse> _parser = new pb::MessageParser<DepotPatchInfoResponse>(() => new DepotPatchInfoResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DepotPatchInfoResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TEKSteamClient.CM.Messages.Bodies.DepotPatchInfoReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DepotPatchInfoResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DepotPatchInfoResponse(DepotPatchInfoResponse other) : this() {
      isAvailable_ = other.isAvailable_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DepotPatchInfoResponse Clone() {
      return new DepotPatchInfoResponse(this);
    }

    /// <summary>Field number for the "is_available" field.</summary>
    public const int IsAvailableFieldNumber = 1;
    private bool isAvailable_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAvailable {
      get { return isAvailable_; }
      set {
        isAvailable_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DepotPatchInfoResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DepotPatchInfoResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsAvailable != other.IsAvailable) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsAvailable != false) hash ^= IsAvailable.GetHashCode();
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
      if (IsAvailable != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsAvailable);
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
      if (IsAvailable != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsAvailable);
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
      if (IsAvailable != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DepotPatchInfoResponse other) {
      if (other == null) {
        return;
      }
      if (other.IsAvailable != false) {
        IsAvailable = other.IsAvailable;
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
            IsAvailable = input.ReadBool();
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
            IsAvailable = input.ReadBool();
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
