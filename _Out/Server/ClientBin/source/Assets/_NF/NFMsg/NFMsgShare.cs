//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: NFMsgShare.proto
// Note: requires additional types generated from: NFDefine.proto
// Note: requires additional types generated from: NFMsgBase.proto
// Note: requires additional types generated from: NFMsgBaseEx.proto
namespace NFMsg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqEnterGameServer")]
  public partial class ReqEnterGameServer : global::ProtoBuf.IExtensible
  {
    public ReqEnterGameServer() {}
    
    private NFMsg.Ident _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident id
    {
      get { return _id; }
      set { _id = value; }
    }
    private byte[] _account;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"account", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] account
    {
      get { return _account; }
      set { _account = value; }
    }
    private int _game_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"game_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int game_id
    {
      get { return _game_id; }
      set { _game_id = value; }
    }
    private byte[] _name;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] name
    {
      get { return _name; }
      set { _name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqHeartBeat")]
  public partial class ReqHeartBeat : global::ProtoBuf.IExtensible
  {
    public ReqHeartBeat() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqLeaveGameServer")]
  public partial class ReqLeaveGameServer : global::ProtoBuf.IExtensible
  {
    public ReqLeaveGameServer() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerEntryInfo")]
  public partial class PlayerEntryInfo : global::ProtoBuf.IExtensible
  {
    public PlayerEntryInfo() {}
    
    private NFMsg.Ident _object_guid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"object_guid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident object_guid
    {
      get { return _object_guid; }
      set { _object_guid = value; }
    }
    private float _x;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float x
    {
      get { return _x; }
      set { _x = value; }
    }
    private float _y;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float y
    {
      get { return _y; }
      set { _y = value; }
    }
    private float _z;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float z
    {
      get { return _z; }
      set { _z = value; }
    }
    private int _career_type;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"career_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int career_type
    {
      get { return _career_type; }
      set { _career_type = value; }
    }
    private int _player_state;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"player_state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int player_state
    {
      get { return _player_state; }
      set { _player_state = value; }
    }
    private byte[] _config_id;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"config_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] config_id
    {
      get { return _config_id; }
      set { _config_id = value; }
    }
    private int _scene_id;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"scene_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int scene_id
    {
      get { return _scene_id; }
      set { _scene_id = value; }
    }
    private byte[] _class_id;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"class_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] class_id
    {
      get { return _class_id; }
      set { _class_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AckPlayerEntryList")]
  public partial class AckPlayerEntryList : global::ProtoBuf.IExtensible
  {
    public AckPlayerEntryList() {}
    
    private readonly global::System.Collections.Generic.List<NFMsg.PlayerEntryInfo> _object_list = new global::System.Collections.Generic.List<NFMsg.PlayerEntryInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"object_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.PlayerEntryInfo> object_list
    {
      get { return _object_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AckPlayerLeaveList")]
  public partial class AckPlayerLeaveList : global::ProtoBuf.IExtensible
  {
    public AckPlayerLeaveList() {}
    
    private readonly global::System.Collections.Generic.List<NFMsg.Ident> _object_list = new global::System.Collections.Generic.List<NFMsg.Ident>();
    [global::ProtoBuf.ProtoMember(1, Name=@"object_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.Ident> object_list
    {
      get { return _object_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqAckPlayerMove")]
  public partial class ReqAckPlayerMove : global::ProtoBuf.IExtensible
  {
    public ReqAckPlayerMove() {}
    
    private NFMsg.Ident _mover;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"mover", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident mover
    {
      get { return _mover; }
      set { _mover = value; }
    }
    private int _moveType;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"moveType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int moveType
    {
      get { return _moveType; }
      set { _moveType = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.Position> _target_pos = new global::System.Collections.Generic.List<NFMsg.Position>();
    [global::ProtoBuf.ProtoMember(3, Name=@"target_pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.Position> target_pos
    {
      get { return _target_pos; }
    }
  
    private readonly global::System.Collections.Generic.List<NFMsg.Position> _source_pos = new global::System.Collections.Generic.List<NFMsg.Position>();
    [global::ProtoBuf.ProtoMember(4, Name=@"source_pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.Position> source_pos
    {
      get { return _source_pos; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqAckPlayerChat")]
  public partial class ReqAckPlayerChat : global::ProtoBuf.IExtensible
  {
    public ReqAckPlayerChat() {}
    
    private NFMsg.Ident _chat_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"chat_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident chat_id
    {
      get { return _chat_id; }
      set { _chat_id = value; }
    }
    private NFMsg.ReqAckPlayerChat.EGameChatType _chat_type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"chat_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public NFMsg.ReqAckPlayerChat.EGameChatType chat_type
    {
      get { return _chat_type; }
      set { _chat_type = value; }
    }
    private byte[] _chat_info;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"chat_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] chat_info
    {
      get { return _chat_info; }
      set { _chat_info = value; }
    }
    private byte[] _chat_name;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"chat_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] chat_name
    {
      get { return _chat_name; }
      set { _chat_name = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"EGameChatType")]
    public enum EGameChatType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGCT_GUILD", Value=0)]
      EGCT_GUILD = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGCT_PRIVATE", Value=1)]
      EGCT_PRIVATE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGCT_TEAM", Value=2)]
      EGCT_TEAM = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGCT_WORLD", Value=3)]
      EGCT_WORLD = 3
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EffectData")]
  public partial class EffectData : global::ProtoBuf.IExtensible
  {
    public EffectData() {}
    
    private NFMsg.Ident _effect_ident;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"effect_ident", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident effect_ident
    {
      get { return _effect_ident; }
      set { _effect_ident = value; }
    }
    private int _effect_value;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"effect_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int effect_value
    {
      get { return _effect_value; }
      set { _effect_value = value; }
    }
    private int _effect_rlt;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"effect_rlt", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int effect_rlt
    {
      get { return _effect_rlt; }
      set { _effect_rlt = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqAckUseSkill")]
  public partial class ReqAckUseSkill : global::ProtoBuf.IExtensible
  {
    public ReqAckUseSkill() {}
    
    private NFMsg.Ident _user;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"user", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident user
    {
      get { return _user; }
      set { _user = value; }
    }
    private byte[] _skill_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"skill_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] skill_id
    {
      get { return _skill_id; }
      set { _skill_id = value; }
    }
    private NFMsg.Position _now_pos;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"now_pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Position now_pos
    {
      get { return _now_pos; }
      set { _now_pos = value; }
    }
    private NFMsg.Position _tar_pos;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"tar_pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Position tar_pos
    {
      get { return _tar_pos; }
      set { _tar_pos = value; }
    }
    private int _use_index;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"use_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int use_index
    {
      get { return _use_index; }
      set { _use_index = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.EffectData> _effect_data = new global::System.Collections.Generic.List<NFMsg.EffectData>();
    [global::ProtoBuf.ProtoMember(6, Name=@"effect_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.EffectData> effect_data
    {
      get { return _effect_data; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqAckUseItem")]
  public partial class ReqAckUseItem : global::ProtoBuf.IExtensible
  {
    public ReqAckUseItem() {}
    
    private NFMsg.Ident _user;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"user", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident user
    {
      get { return _user; }
      set { _user = value; }
    }
    private NFMsg.Ident _item_guid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"item_guid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident item_guid
    {
      get { return _item_guid; }
      set { _item_guid = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.EffectData> _effect_data = new global::System.Collections.Generic.List<NFMsg.EffectData>();
    [global::ProtoBuf.ProtoMember(3, Name=@"effect_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.EffectData> effect_data
    {
      get { return _effect_data; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqAckSwapScene")]
  public partial class ReqAckSwapScene : global::ProtoBuf.IExtensible
  {
    public ReqAckSwapScene() {}
    
    private NFMsg.ReqAckSwapScene.EGameSwapType _transfer_type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"transfer_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public NFMsg.ReqAckSwapScene.EGameSwapType transfer_type
    {
      get { return _transfer_type; }
      set { _transfer_type = value; }
    }
    private int _scene_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"scene_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int scene_id
    {
      get { return _scene_id; }
      set { _scene_id = value; }
    }
    private int _line_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"line_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int line_id
    {
      get { return _line_id; }
      set { _line_id = value; }
    }
    private float _x = default(float);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float x
    {
      get { return _x; }
      set { _x = value; }
    }
    private float _y = default(float);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float y
    {
      get { return _y; }
      set { _y = value; }
    }
    private float _z = default(float);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float z
    {
      get { return _z; }
      set { _z = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"EGameSwapType")]
    public enum EGameSwapType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGST_NARMAL", Value=0)]
      EGST_NARMAL = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGST_CLONE", Value=1)]
      EGST_CLONE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGST_ARENA", Value=2)]
      EGST_ARENA = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGST_MIRROR", Value=3)]
      EGST_MIRROR = 3
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ItemStruct")]
  public partial class ItemStruct : global::ProtoBuf.IExtensible
  {
    public ItemStruct() {}
    
    private string _item_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"item_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string item_id
    {
      get { return _item_id; }
      set { _item_id = value; }
    }
    private int _item_count;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"item_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int item_count
    {
      get { return _item_count; }
      set { _item_count = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqAckEndBattle")]
  public partial class ReqAckEndBattle : global::ProtoBuf.IExtensible
  {
    public ReqAckEndBattle() {}
    
    private int _money;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"money", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int money
    {
      get { return _money; }
      set { _money = value; }
    }
    private int _exp;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    private int _diamond;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"diamond", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int diamond
    {
      get { return _diamond; }
      set { _diamond = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.ItemStruct> _item_list = new global::System.Collections.Generic.List<NFMsg.ItemStruct>();
    [global::ProtoBuf.ProtoMember(4, Name=@"item_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.ItemStruct> item_list
    {
      get { return _item_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqPickDropItem")]
  public partial class ReqPickDropItem : global::ProtoBuf.IExtensible
  {
    public ReqPickDropItem() {}
    
    private NFMsg.Ident _item_guid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"item_guid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident item_guid
    {
      get { return _item_guid; }
      set { _item_guid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqAcceptTask")]
  public partial class ReqAcceptTask : global::ProtoBuf.IExtensible
  {
    public ReqAcceptTask() {}
    
    private byte[] _task_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"task_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] task_id
    {
      get { return _task_id; }
      set { _task_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqCompeleteTask")]
  public partial class ReqCompeleteTask : global::ProtoBuf.IExtensible
  {
    public ReqCompeleteTask() {}
    
    private byte[] _task_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"task_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] task_id
    {
      get { return _task_id; }
      set { _task_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqAckJoinActivity")]
  public partial class ReqAckJoinActivity : global::ProtoBuf.IExtensible
  {
    public ReqAckJoinActivity() {}
    
    private NFMsg.ReqAckJoinActivity.EGameActivityType _activity_type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"activity_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public NFMsg.ReqAckJoinActivity.EGameActivityType activity_type
    {
      get { return _activity_type; }
      set { _activity_type = value; }
    }
    private NFMsg.ReqAckJoinActivity.EGameActivitySubType _sub_activity_type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"sub_activity_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public NFMsg.ReqAckJoinActivity.EGameActivitySubType sub_activity_type
    {
      get { return _sub_activity_type; }
      set { _sub_activity_type = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"EGameActivityType")]
    public enum EGameActivityType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGAT_PVP", Value=0)]
      EGAT_PVP = 0
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EGameActivitySubType")]
    public enum EGameActivitySubType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGAT_NORMAL", Value=0)]
      EGAT_NORMAL = 0
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqAckCreateGuild")]
  public partial class ReqAckCreateGuild : global::ProtoBuf.IExtensible
  {
    public ReqAckCreateGuild() {}
    
    private NFMsg.Ident _guild_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"guild_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident guild_id
    {
      get { return _guild_id; }
      set { _guild_id = value; }
    }
    private string _guild_name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"guild_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string guild_name
    {
      get { return _guild_name; }
      set { _guild_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqSearchGuild")]
  public partial class ReqSearchGuild : global::ProtoBuf.IExtensible
  {
    public ReqSearchGuild() {}
    
    private string _guild_name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"guild_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string guild_name
    {
      get { return _guild_name; }
      set { _guild_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AckSearchGuild")]
  public partial class AckSearchGuild : global::ProtoBuf.IExtensible
  {
    public AckSearchGuild() {}
    
    private readonly global::System.Collections.Generic.List<NFMsg.AckSearchGuild.SearchGuildObject> _guild_list = new global::System.Collections.Generic.List<NFMsg.AckSearchGuild.SearchGuildObject>();
    [global::ProtoBuf.ProtoMember(1, Name=@"guild_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.AckSearchGuild.SearchGuildObject> guild_list
    {
      get { return _guild_list; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchGuildObject")]
  public partial class SearchGuildObject : global::ProtoBuf.IExtensible
  {
    public SearchGuildObject() {}
    
    private NFMsg.Ident _guild_ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"guild_ID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident guild_ID
    {
      get { return _guild_ID; }
      set { _guild_ID = value; }
    }
    private string _guild_name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"guild_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string guild_name
    {
      get { return _guild_name; }
      set { _guild_name = value; }
    }
    private string _guild_icon;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"guild_icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string guild_icon
    {
      get { return _guild_icon; }
      set { _guild_icon = value; }
    }
    private int _guild_member_count;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"guild_member_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int guild_member_count
    {
      get { return _guild_member_count; }
      set { _guild_member_count = value; }
    }
    private int _guild_member_max_count;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"guild_member_max_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int guild_member_max_count
    {
      get { return _guild_member_max_count; }
      set { _guild_member_max_count = value; }
    }
    private int _guild_honor;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"guild_honor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int guild_honor
    {
      get { return _guild_honor; }
      set { _guild_honor = value; }
    }
    private int _guild_rank;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"guild_rank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int guild_rank
    {
      get { return _guild_rank; }
      set { _guild_rank = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqAckJoinGuild")]
  public partial class ReqAckJoinGuild : global::ProtoBuf.IExtensible
  {
    public ReqAckJoinGuild() {}
    
    private NFMsg.Ident _guild_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"guild_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident guild_id
    {
      get { return _guild_id; }
      set { _guild_id = value; }
    }
    private string _guild_name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"guild_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string guild_name
    {
      get { return _guild_name; }
      set { _guild_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqAckLeaveGuild")]
  public partial class ReqAckLeaveGuild : global::ProtoBuf.IExtensible
  {
    public ReqAckLeaveGuild() {}
    
    private NFMsg.Ident _guild_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"guild_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident guild_id
    {
      get { return _guild_id; }
      set { _guild_id = value; }
    }
    private string _guild_name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"guild_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string guild_name
    {
      get { return _guild_name; }
      set { _guild_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqAckOprGuildMember")]
  public partial class ReqAckOprGuildMember : global::ProtoBuf.IExtensible
  {
    public ReqAckOprGuildMember() {}
    
    private NFMsg.Ident _guild_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"guild_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident guild_id
    {
      get { return _guild_id; }
      set { _guild_id = value; }
    }
    private NFMsg.Ident _member_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"member_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident member_id
    {
      get { return _member_id; }
      set { _member_id = value; }
    }
    private NFMsg.ReqAckOprGuildMember.EGGuildMemberOprType _type;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public NFMsg.ReqAckOprGuildMember.EGGuildMemberOprType type
    {
      get { return _type; }
      set { _type = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"EGGuildMemberOprType")]
    public enum EGGuildMemberOprType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGAT_DOWN", Value=0)]
      EGAT_DOWN = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGAT_UP", Value=1)]
      EGAT_UP = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGAT_KICK", Value=2)]
      EGAT_KICK = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatInfo")]
  public partial class ChatInfo : global::ProtoBuf.IExtensible
  {
    public ChatInfo() {}
    
    private NFMsg.ChatInfo.EChatType _chat_type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"chat_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public NFMsg.ChatInfo.EChatType chat_type
    {
      get { return _chat_type; }
      set { _chat_type = value; }
    }
    private byte[] _chat_info;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"chat_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] chat_info
    {
      get { return _chat_info; }
      set { _chat_info = value; }
    }
    private long _chat_time;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"chat_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long chat_time
    {
      get { return _chat_time; }
      set { _chat_time = value; }
    }
    private byte[] _addtional_info = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"addtional_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] addtional_info
    {
      get { return _addtional_info; }
      set { _addtional_info = value; }
    }
    private NFMsg.Ident _send_id;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"send_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFMsg.Ident send_id
    {
      get { return _send_id; }
      set { _send_id = value; }
    }
    private byte[] _send_name;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"send_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] send_name
    {
      get { return _send_name; }
      set { _send_name = value; }
    }
    private int _send_level = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"send_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int send_level
    {
      get { return _send_level; }
      set { _send_level = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.Ident> _recvier_id = new global::System.Collections.Generic.List<NFMsg.Ident>();
    [global::ProtoBuf.ProtoMember(8, Name=@"recvier_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.Ident> recvier_id
    {
      get { return _recvier_id; }
    }
  
    private byte[] _guid_name = null;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"guid_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] guid_name
    {
      get { return _guid_name; }
      set { _guid_name = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"EChatType")]
    public enum EChatType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ECHATTYPE_NORMAL", Value=0)]
      ECHATTYPE_NORMAL = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ECHATTYPE_PRIVATE", Value=1)]
      ECHATTYPE_PRIVATE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ECHATTYPE_GUILD", Value=2)]
      ECHATTYPE_GUILD = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ECHATTYPE_WORLD", Value=3)]
      ECHATTYPE_WORLD = 3
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}