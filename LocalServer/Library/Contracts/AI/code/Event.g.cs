// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Event.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Microsoft.LocalForwarder.Library.Inputs.Contracts {

  /// <summary>Holder for reflection information generated from Event.proto</summary>
  public static partial class EventReflection {

    #region Descriptor
    /// <summary>File descriptor for Event.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtFdmVudC5wcm90bxIJY29udHJhY3RzIvoBCgVFdmVudBILCgN2ZXIYASAB",
            "KAUSDAoEbmFtZRgCIAEoCRI0Cgpwcm9wZXJ0aWVzGAMgAygLMiAuY29udHJh",
            "Y3RzLkV2ZW50LlByb3BlcnRpZXNFbnRyeRI4CgxtZWFzdXJlbWVudHMYBCAD",
            "KAsyIi5jb250cmFjdHMuRXZlbnQuTWVhc3VyZW1lbnRzRW50cnkaMQoPUHJv",
            "cGVydGllc0VudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToCOAEa",
            "MwoRTWVhc3VyZW1lbnRzRW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVlGAIg",
            "ASgBOgI4AUI0qgIxTWljcm9zb2Z0LkxvY2FsRm9yd2FyZGVyLkxpYnJhcnku",
            "SW5wdXRzLkNvbnRyYWN0c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Microsoft.LocalForwarder.Library.Inputs.Contracts.Event), global::Microsoft.LocalForwarder.Library.Inputs.Contracts.Event.Parser, new[]{ "Ver", "Name", "Properties", "Measurements" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Event : pb::IMessage<Event> {
    private static readonly pb::MessageParser<Event> _parser = new pb::MessageParser<Event>(() => new Event());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Event> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Microsoft.LocalForwarder.Library.Inputs.Contracts.EventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Event() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Event(Event other) : this() {
      ver_ = other.ver_;
      name_ = other.name_;
      properties_ = other.properties_.Clone();
      measurements_ = other.measurements_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Event Clone() {
      return new Event(this);
    }

    /// <summary>Field number for the "ver" field.</summary>
    public const int VerFieldNumber = 1;
    private int ver_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Ver {
      get { return ver_; }
      set {
        ver_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "properties" field.</summary>
    public const int PropertiesFieldNumber = 3;
    private static readonly pbc::MapField<string, string>.Codec _map_properties_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 26);
    private readonly pbc::MapField<string, string> properties_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Properties {
      get { return properties_; }
    }

    /// <summary>Field number for the "measurements" field.</summary>
    public const int MeasurementsFieldNumber = 4;
    private static readonly pbc::MapField<string, double>.Codec _map_measurements_codec
        = new pbc::MapField<string, double>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForDouble(17), 34);
    private readonly pbc::MapField<string, double> measurements_ = new pbc::MapField<string, double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, double> Measurements {
      get { return measurements_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Event);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Event other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ver != other.Ver) return false;
      if (Name != other.Name) return false;
      if (!Properties.Equals(other.Properties)) return false;
      if (!Measurements.Equals(other.Measurements)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ver != 0) hash ^= Ver.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= Properties.GetHashCode();
      hash ^= Measurements.GetHashCode();
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
      if (Ver != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Ver);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      properties_.WriteTo(output, _map_properties_codec);
      measurements_.WriteTo(output, _map_measurements_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ver != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Ver);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += properties_.CalculateSize(_map_properties_codec);
      size += measurements_.CalculateSize(_map_measurements_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Event other) {
      if (other == null) {
        return;
      }
      if (other.Ver != 0) {
        Ver = other.Ver;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      properties_.Add(other.properties_);
      measurements_.Add(other.measurements_);
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
            Ver = input.ReadInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            properties_.AddEntriesFrom(input, _map_properties_codec);
            break;
          }
          case 34: {
            measurements_.AddEntriesFrom(input, _map_measurements_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
