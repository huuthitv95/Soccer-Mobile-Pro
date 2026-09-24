namespace EngineMessages
{
    public sealed class PlayerData : global::Google.Protobuf.IMessage<global::EngineMessages.PlayerData>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.PlayerData>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.PlayerData>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.PlayerData> _parser;
        public const int PlayeridFieldNumber = 1;
        private int playerid_;
        public const int BaseStatFieldNumber = 2;
        private float baseStat_;
        public const int AgeFieldNumber = 4;
        private int age_;
        public const int HeightFieldNumber = 5;
        private float height_;
        public const int StartPositionFieldNumber = 6;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_startPosition_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> startPosition_;
        public const int AngleFieldNumber = 8;
        private float angle_;
        public const int RoleFieldNumber = 9;
        private int role_;
        public const int FormationPositionFieldNumber = 10;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_formationPosition_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> formationPosition_;
        public const int PropertiesFieldNumber = 11;
        private static readonly global::Google.Protobuf.Collections.MapField<int, float>.Codec _map_properties_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, float> properties_;
        public const int RunToListFieldNumber = 12;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_runToList_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> runToList_;
        public const int ForceShootListFieldNumber = 13;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_forceShootList_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> forceShootList_;
        public const int PassToListFieldNumber = 14;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_passToList_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> passToList_;
        public const int DribbleToListFieldNumber = 15;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_dribbleToList_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> dribbleToList_;
        public const int StartAnimListFieldNumber = 16;
        private static readonly global::Google.Protobuf.FieldCodec<string> _repeated_startAnimList_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<string> startAnimList_;
        public const int StartAnimFrameFieldNumber = 17;
        private int startAnimFrame_;
        public const int CineAnimListFieldNumber = 18;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.CineAnimData> _repeated_cineAnimList_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.CineAnimData> cineAnimList_;
        public const int FatigueFieldNumber = 19;
        private float fatigue_;
        public const int GenderFieldNumber = 20;
        private global::EngineMessages.Gender gender_;
        public const int AutoplayCountFieldNumber = 21;
        private int autoplayCount_;
        public const int NewRunToListFieldNumber = 22;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_newRunToList_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> newRunToList_;
        public const int SkillsFieldNumber = 23;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.PlayerSkill> _repeated_skills_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.PlayerSkill> skills_;
        public const int SnapToListFieldNumber = 24;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_snapToList_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> snapToList_;
        public const int PreferredFootFieldNumber = 25;
        private global::EngineMessages.Foot preferredFoot_;
        public const int PersonalizedAnimationsFieldNumber = 26;
        private static readonly global::Google.Protobuf.FieldCodec<string> _repeated_personalizedAnimations_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<string> personalizedAnimations_;
        public const int ConfigStringFieldNumber = 27;
        private string configString_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.PlayerData> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Playerid
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public float BaseStat
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Age
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public float Height
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> StartPosition => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public float Angle
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Role
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> FormationPosition => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, float> Properties => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> RunToList => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> ForceShootList => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> PassToList => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> DribbleToList => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<string> StartAnimList => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int StartAnimFrame
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.CineAnimData> CineAnimList => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public float Fatigue
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.Gender Gender
        {
            get
            {
                return global::EngineMessages.Gender.Male;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int AutoplayCount
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> NewRunToList => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.PlayerSkill> Skills => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> SnapToList => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.Foot PreferredFoot
        {
            get
            {
                return global::EngineMessages.Foot.Left;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<string> PersonalizedAnimations => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string ConfigString
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PlayerData()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PlayerData(global::EngineMessages.PlayerData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.PlayerData Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.PlayerData other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override int GetHashCode()
        {
            return 0;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override string ToString()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void WriteTo(global::Google.Protobuf.CodedOutputStream output)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int CalculateSize()
        {
            return 0;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::EngineMessages.PlayerData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}