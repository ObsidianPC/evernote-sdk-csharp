/**
 * Autogenerated by Thrift
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace Evernote.EDAM.NoteStore
{

  #if !SILVERLIGHT && !NETFX_CORE
  [Serializable]
  #endif
  public partial class RelatedResultSpec : TBase
  {
    private int _maxNotes;
    private int _maxNotebooks;
    private int _maxTags;
    private bool _writableNotebooksOnly;
    private bool _includeContainingNotebooks;
    private bool _includeDebugInfo;

    public int MaxNotes
    {
      get
      {
        return _maxNotes;
      }
      set
      {
        __isset.maxNotes = true;
        this._maxNotes = value;
      }
    }

    public int MaxNotebooks
    {
      get
      {
        return _maxNotebooks;
      }
      set
      {
        __isset.maxNotebooks = true;
        this._maxNotebooks = value;
      }
    }

    public int MaxTags
    {
      get
      {
        return _maxTags;
      }
      set
      {
        __isset.maxTags = true;
        this._maxTags = value;
      }
    }

    public bool WritableNotebooksOnly
    {
      get
      {
        return _writableNotebooksOnly;
      }
      set
      {
        __isset.writableNotebooksOnly = true;
        this._writableNotebooksOnly = value;
      }
    }

    public bool IncludeContainingNotebooks
    {
      get
      {
        return _includeContainingNotebooks;
      }
      set
      {
        __isset.includeContainingNotebooks = true;
        this._includeContainingNotebooks = value;
      }
    }

    public bool IncludeDebugInfo
    {
      get
      {
        return _includeDebugInfo;
      }
      set
      {
        __isset.includeDebugInfo = true;
        this._includeDebugInfo = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT && !NETFX_CORE
    [Serializable]
    #endif
    public struct Isset {
      public bool maxNotes;
      public bool maxNotebooks;
      public bool maxTags;
      public bool writableNotebooksOnly;
      public bool includeContainingNotebooks;
      public bool includeDebugInfo;
    }

    public RelatedResultSpec() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.I32) {
              MaxNotes = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              MaxNotebooks = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              MaxTags = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Bool) {
              WritableNotebooksOnly = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Bool) {
              IncludeContainingNotebooks = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Bool) {
              IncludeDebugInfo = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("RelatedResultSpec");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.maxNotes) {
        field.Name = "maxNotes";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MaxNotes);
        oprot.WriteFieldEnd();
      }
      if (__isset.maxNotebooks) {
        field.Name = "maxNotebooks";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MaxNotebooks);
        oprot.WriteFieldEnd();
      }
      if (__isset.maxTags) {
        field.Name = "maxTags";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MaxTags);
        oprot.WriteFieldEnd();
      }
      if (__isset.writableNotebooksOnly) {
        field.Name = "writableNotebooksOnly";
        field.Type = TType.Bool;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(WritableNotebooksOnly);
        oprot.WriteFieldEnd();
      }
      if (__isset.includeContainingNotebooks) {
        field.Name = "includeContainingNotebooks";
        field.Type = TType.Bool;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IncludeContainingNotebooks);
        oprot.WriteFieldEnd();
      }
      if (__isset.includeDebugInfo) {
        field.Name = "includeDebugInfo";
        field.Type = TType.Bool;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IncludeDebugInfo);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("RelatedResultSpec(");
      sb.Append("MaxNotes: ");
      sb.Append(MaxNotes);
      sb.Append(",MaxNotebooks: ");
      sb.Append(MaxNotebooks);
      sb.Append(",MaxTags: ");
      sb.Append(MaxTags);
      sb.Append(",WritableNotebooksOnly: ");
      sb.Append(WritableNotebooksOnly);
      sb.Append(",IncludeContainingNotebooks: ");
      sb.Append(IncludeContainingNotebooks);
      sb.Append(",IncludeDebugInfo: ");
      sb.Append(IncludeDebugInfo);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
