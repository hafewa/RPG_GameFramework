// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FBFight.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GameMessage {

  /// <summary>Holder for reflection information generated from FBFight.proto</summary>
  public static partial class FBFightReflection {

    #region Descriptor
    /// <summary>File descriptor for FBFight.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FBFightReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1GQkZpZ2h0LnByb3RvEgtHYW1lTWVzc2FnZSIaCgpSZXFGQkZpZ2h0EgwK",
            "BGZiaWQYASABKAUiKQoKUnNwRkJGaWdodBIMCgRmYmlkGAEgASgFEg0KBXBv",
            "d2VyGAIgASgFIkwKDVJlcUZCRmlnaHRFbmQSCwoDd2luGAEgASgIEgwKBGZi",
            "aWQYAiABKAUSDgoGcmVzdGhwGAMgASgFEhAKCGNvc3R0aW1lGAQgASgFIpMB",
            "Cg1Sc3BGQkZpZ2h0RW5kEgsKA3dpbhgBIAEoCBIMCgRmYmlkGAIgASgFEg4K",
            "BnJlc3RocBgDIAEoBRIQCghjb3N0dGltZRgEIAEoBRIMCgRjb2luGAUgASgF",
            "EgoKAmx2GAYgASgFEgsKA2V4cBgHIAEoBRIPCgdjcnlzdGFsGAggASgFEg0K",
            "BWZ1YmVuGAkgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GameMessage.ReqFBFight), global::GameMessage.ReqFBFight.Parser, new[]{ "Fbid" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GameMessage.RspFBFight), global::GameMessage.RspFBFight.Parser, new[]{ "Fbid", "Power" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GameMessage.ReqFBFightEnd), global::GameMessage.ReqFBFightEnd.Parser, new[]{ "Win", "Fbid", "Resthp", "Costtime" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GameMessage.RspFBFightEnd), global::GameMessage.RspFBFightEnd.Parser, new[]{ "Win", "Fbid", "Resthp", "Costtime", "Coin", "Lv", "Exp", "Crystal", "Fuben" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReqFBFight : pb::IMessage<ReqFBFight> {
    private static readonly pb::MessageParser<ReqFBFight> _parser = new pb::MessageParser<ReqFBFight>(() => new ReqFBFight());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReqFBFight> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GameMessage.FBFightReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqFBFight() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqFBFight(ReqFBFight other) : this() {
      fbid_ = other.fbid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqFBFight Clone() {
      return new ReqFBFight(this);
    }

    /// <summary>Field number for the "fbid" field.</summary>
    public const int FbidFieldNumber = 1;
    private int fbid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Fbid {
      get { return fbid_; }
      set {
        fbid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReqFBFight);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReqFBFight other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Fbid != other.Fbid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Fbid != 0) hash ^= Fbid.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Fbid != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Fbid);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Fbid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Fbid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReqFBFight other) {
      if (other == null) {
        return;
      }
      if (other.Fbid != 0) {
        Fbid = other.Fbid;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Fbid = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RspFBFight : pb::IMessage<RspFBFight> {
    private static readonly pb::MessageParser<RspFBFight> _parser = new pb::MessageParser<RspFBFight>(() => new RspFBFight());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RspFBFight> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GameMessage.FBFightReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspFBFight() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspFBFight(RspFBFight other) : this() {
      fbid_ = other.fbid_;
      power_ = other.power_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspFBFight Clone() {
      return new RspFBFight(this);
    }

    /// <summary>Field number for the "fbid" field.</summary>
    public const int FbidFieldNumber = 1;
    private int fbid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Fbid {
      get { return fbid_; }
      set {
        fbid_ = value;
      }
    }

    /// <summary>Field number for the "power" field.</summary>
    public const int PowerFieldNumber = 2;
    private int power_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Power {
      get { return power_; }
      set {
        power_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RspFBFight);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RspFBFight other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Fbid != other.Fbid) return false;
      if (Power != other.Power) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Fbid != 0) hash ^= Fbid.GetHashCode();
      if (Power != 0) hash ^= Power.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Fbid != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Fbid);
      }
      if (Power != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Power);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Fbid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Fbid);
      }
      if (Power != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Power);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RspFBFight other) {
      if (other == null) {
        return;
      }
      if (other.Fbid != 0) {
        Fbid = other.Fbid;
      }
      if (other.Power != 0) {
        Power = other.Power;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Fbid = input.ReadInt32();
            break;
          }
          case 16: {
            Power = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ReqFBFightEnd : pb::IMessage<ReqFBFightEnd> {
    private static readonly pb::MessageParser<ReqFBFightEnd> _parser = new pb::MessageParser<ReqFBFightEnd>(() => new ReqFBFightEnd());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReqFBFightEnd> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GameMessage.FBFightReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqFBFightEnd() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqFBFightEnd(ReqFBFightEnd other) : this() {
      win_ = other.win_;
      fbid_ = other.fbid_;
      resthp_ = other.resthp_;
      costtime_ = other.costtime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReqFBFightEnd Clone() {
      return new ReqFBFightEnd(this);
    }

    /// <summary>Field number for the "win" field.</summary>
    public const int WinFieldNumber = 1;
    private bool win_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Win {
      get { return win_; }
      set {
        win_ = value;
      }
    }

    /// <summary>Field number for the "fbid" field.</summary>
    public const int FbidFieldNumber = 2;
    private int fbid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Fbid {
      get { return fbid_; }
      set {
        fbid_ = value;
      }
    }

    /// <summary>Field number for the "resthp" field.</summary>
    public const int ResthpFieldNumber = 3;
    private int resthp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Resthp {
      get { return resthp_; }
      set {
        resthp_ = value;
      }
    }

    /// <summary>Field number for the "costtime" field.</summary>
    public const int CosttimeFieldNumber = 4;
    private int costtime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Costtime {
      get { return costtime_; }
      set {
        costtime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReqFBFightEnd);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReqFBFightEnd other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Win != other.Win) return false;
      if (Fbid != other.Fbid) return false;
      if (Resthp != other.Resthp) return false;
      if (Costtime != other.Costtime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Win != false) hash ^= Win.GetHashCode();
      if (Fbid != 0) hash ^= Fbid.GetHashCode();
      if (Resthp != 0) hash ^= Resthp.GetHashCode();
      if (Costtime != 0) hash ^= Costtime.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Win != false) {
        output.WriteRawTag(8);
        output.WriteBool(Win);
      }
      if (Fbid != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Fbid);
      }
      if (Resthp != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Resthp);
      }
      if (Costtime != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Costtime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Win != false) {
        size += 1 + 1;
      }
      if (Fbid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Fbid);
      }
      if (Resthp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Resthp);
      }
      if (Costtime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Costtime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReqFBFightEnd other) {
      if (other == null) {
        return;
      }
      if (other.Win != false) {
        Win = other.Win;
      }
      if (other.Fbid != 0) {
        Fbid = other.Fbid;
      }
      if (other.Resthp != 0) {
        Resthp = other.Resthp;
      }
      if (other.Costtime != 0) {
        Costtime = other.Costtime;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Win = input.ReadBool();
            break;
          }
          case 16: {
            Fbid = input.ReadInt32();
            break;
          }
          case 24: {
            Resthp = input.ReadInt32();
            break;
          }
          case 32: {
            Costtime = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RspFBFightEnd : pb::IMessage<RspFBFightEnd> {
    private static readonly pb::MessageParser<RspFBFightEnd> _parser = new pb::MessageParser<RspFBFightEnd>(() => new RspFBFightEnd());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RspFBFightEnd> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GameMessage.FBFightReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspFBFightEnd() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspFBFightEnd(RspFBFightEnd other) : this() {
      win_ = other.win_;
      fbid_ = other.fbid_;
      resthp_ = other.resthp_;
      costtime_ = other.costtime_;
      coin_ = other.coin_;
      lv_ = other.lv_;
      exp_ = other.exp_;
      crystal_ = other.crystal_;
      fuben_ = other.fuben_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspFBFightEnd Clone() {
      return new RspFBFightEnd(this);
    }

    /// <summary>Field number for the "win" field.</summary>
    public const int WinFieldNumber = 1;
    private bool win_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Win {
      get { return win_; }
      set {
        win_ = value;
      }
    }

    /// <summary>Field number for the "fbid" field.</summary>
    public const int FbidFieldNumber = 2;
    private int fbid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Fbid {
      get { return fbid_; }
      set {
        fbid_ = value;
      }
    }

    /// <summary>Field number for the "resthp" field.</summary>
    public const int ResthpFieldNumber = 3;
    private int resthp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Resthp {
      get { return resthp_; }
      set {
        resthp_ = value;
      }
    }

    /// <summary>Field number for the "costtime" field.</summary>
    public const int CosttimeFieldNumber = 4;
    private int costtime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Costtime {
      get { return costtime_; }
      set {
        costtime_ = value;
      }
    }

    /// <summary>Field number for the "coin" field.</summary>
    public const int CoinFieldNumber = 5;
    private int coin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Coin {
      get { return coin_; }
      set {
        coin_ = value;
      }
    }

    /// <summary>Field number for the "lv" field.</summary>
    public const int LvFieldNumber = 6;
    private int lv_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Lv {
      get { return lv_; }
      set {
        lv_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 7;
    private int exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "crystal" field.</summary>
    public const int CrystalFieldNumber = 8;
    private int crystal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Crystal {
      get { return crystal_; }
      set {
        crystal_ = value;
      }
    }

    /// <summary>Field number for the "fuben" field.</summary>
    public const int FubenFieldNumber = 9;
    private int fuben_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Fuben {
      get { return fuben_; }
      set {
        fuben_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RspFBFightEnd);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RspFBFightEnd other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Win != other.Win) return false;
      if (Fbid != other.Fbid) return false;
      if (Resthp != other.Resthp) return false;
      if (Costtime != other.Costtime) return false;
      if (Coin != other.Coin) return false;
      if (Lv != other.Lv) return false;
      if (Exp != other.Exp) return false;
      if (Crystal != other.Crystal) return false;
      if (Fuben != other.Fuben) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Win != false) hash ^= Win.GetHashCode();
      if (Fbid != 0) hash ^= Fbid.GetHashCode();
      if (Resthp != 0) hash ^= Resthp.GetHashCode();
      if (Costtime != 0) hash ^= Costtime.GetHashCode();
      if (Coin != 0) hash ^= Coin.GetHashCode();
      if (Lv != 0) hash ^= Lv.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (Crystal != 0) hash ^= Crystal.GetHashCode();
      if (Fuben != 0) hash ^= Fuben.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Win != false) {
        output.WriteRawTag(8);
        output.WriteBool(Win);
      }
      if (Fbid != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Fbid);
      }
      if (Resthp != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Resthp);
      }
      if (Costtime != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Costtime);
      }
      if (Coin != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Coin);
      }
      if (Lv != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Lv);
      }
      if (Exp != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Exp);
      }
      if (Crystal != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Crystal);
      }
      if (Fuben != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Fuben);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Win != false) {
        size += 1 + 1;
      }
      if (Fbid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Fbid);
      }
      if (Resthp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Resthp);
      }
      if (Costtime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Costtime);
      }
      if (Coin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Coin);
      }
      if (Lv != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Lv);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Exp);
      }
      if (Crystal != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Crystal);
      }
      if (Fuben != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Fuben);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RspFBFightEnd other) {
      if (other == null) {
        return;
      }
      if (other.Win != false) {
        Win = other.Win;
      }
      if (other.Fbid != 0) {
        Fbid = other.Fbid;
      }
      if (other.Resthp != 0) {
        Resthp = other.Resthp;
      }
      if (other.Costtime != 0) {
        Costtime = other.Costtime;
      }
      if (other.Coin != 0) {
        Coin = other.Coin;
      }
      if (other.Lv != 0) {
        Lv = other.Lv;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.Crystal != 0) {
        Crystal = other.Crystal;
      }
      if (other.Fuben != 0) {
        Fuben = other.Fuben;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Win = input.ReadBool();
            break;
          }
          case 16: {
            Fbid = input.ReadInt32();
            break;
          }
          case 24: {
            Resthp = input.ReadInt32();
            break;
          }
          case 32: {
            Costtime = input.ReadInt32();
            break;
          }
          case 40: {
            Coin = input.ReadInt32();
            break;
          }
          case 48: {
            Lv = input.ReadInt32();
            break;
          }
          case 56: {
            Exp = input.ReadInt32();
            break;
          }
          case 64: {
            Crystal = input.ReadInt32();
            break;
          }
          case 72: {
            Fuben = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code