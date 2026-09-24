namespace SL
{
    public class Player
    {
        public struct Hexagram
        {
            public float _speed;
            public float _shootOrDefensivesPositioning;
            public float _passingOrBallControl;
            public float _dribblingOrReaction;
            public float _defanceOrKickOff;
            public float _physicalOrVision;
            public bool isWithExp;
            public int Speed => 0;
            public int ShootOrDefensivesPositioning => 0;
            public int PassingOrBallControl => 0;
            public int dribblingOrReaction => 0;
            public int defanceOrKickOff => 0;
            public int physicalOrVision => 0;

            // C# has no syntax for parameterized property 'Item'.
            public int this[global::FL.HexagramAttribute attribute]
            {
                get
                {
                    return 0;
                }
            }

            public int GetValue()
            {
                return 0;
            }

            public float GetFloatValue(global::FL.HexagramAttribute attribute)
            {
                return 0f;
            }

            public global::System.Collections.Generic.IEnumerable<int> GetAllAttributes(bool forUI = true)
            {
                return null;
            }
        }

        public class PlayerApperance
        {
            private global::FLDataTable.PlayerAppearanceTable config;
            public sbyte[] somatotype;
            public string face_decoration;
            public bool useArmSleeve;
            public bool wristband;
            public string skin => null;
            public short skinID => 0;
            public string face => null;
            public string hair => null;

            public sbyte hairColor
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public sbyte beardColor
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public string eye => null;
            public string eyebrow => null;

            public sbyte[] headData
            {
                get
                {
                    return null;
                }

                set
                {
                }
            }

            public string Beard => null;

            public short hairMeshNameID
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public short BeardID
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public sbyte eyeID
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public sbyte eyebrowID
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public string HeadMeshName => null;

            public short headMeshId
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public global::SL.Player.PlayerApperance Clone()
            {
                return null;
            }

            private PlayerApperance()
            {
            }

            public PlayerApperance(global::FLDataTable.PlayerAppearanceTable table)
            {
            }
        }

        public enum PlayerState : sbyte
        {
            OPTIMUM = 0,
            GOOD = 1,
            NORMAL = 2,
            POOR = 3,
            VERY_POOR = 4
        }

        public struct ReadBuff
        {
            public unsafe byte* _data_ptr;
            public int _length;
            public int _cur_pos;
            public int ReadInt32()
            {
                return 0;
            }

            public int ReadInt16()
            {
                return 0;
            }

            public int ReadInt8()
            {
                return 0;
            }

            public string ReadString(global::System.Text.StringBuilder sbBuff)
            {
                return null;
            }
        }

        public sbyte targetRating;
        private static readonly string _playerDataTag;
        private static readonly string _playerPath;
        private static readonly string _playerCsv;
        private static readonly string _apperancePath;
        private static byte[] rw_buf;
        private static int tmpSeed;
        public virtual int id { get; protected set; }
        public virtual int age { get; protected set; }
        private int birthday { get; set; }
        public virtual short height { get; protected set; }
        public virtual short weight { get; protected set; }
        public virtual short balance { get; protected set; }
        public virtual short reaction { get; protected set; }
        public virtual short acceleration { get; protected set; }
        public virtual short velocity { get; protected set; }
        public virtual short stamina { get; protected set; }
        public virtual short agility { get; protected set; }
        public virtual short shotpower { get; protected set; }
        public virtual short standingtackle { get; protected set; }
        public virtual short slidingtackle { get; protected set; }
        public virtual short ballcontrol { get; protected set; }
        public virtual short dribble { get; protected set; }
        public virtual short shortpass { get; protected set; }
        public virtual short highpass { get; protected set; }
        public virtual short shot { get; protected set; }
        public virtual short volley { get; protected set; }
        public virtual short mental_defensivepositioning { get; protected set; }
        public virtual short mental_vision { get; protected set; }
        public virtual string nationality { get; protected set; }
        public virtual FormationTool.UIPosition[] position { get; protected set; }
        public float influence { get; protected set; }
        public int YOB { get; set; }
        public virtual sbyte preferredFoot { get; protected set; }
        public virtual sbyte weakfootability { get; protected set; }
        public bool IsFemale => false;
        public virtual EditableName name { get; protected set; }
        protected EditablePlayerIcon editablePlayerIconInClub { get; set; }
        protected EditablePlayerIcon editablePlayerIconInNational { get; private set; }

        public int Rating(FormationTool.UIRole role)
        {
            return 0;
        }

        public virtual sbyte Rating(FormationTool.UIPosition role)
        {
            return 0;
        }

        public static FormationTool.UIPosition ParseUIPosition(string str, int id)
        {
            return FormationTool.UIPosition.GK;
        }

        private static void WriteString(ref global::System.IO.FileStream file, string value)
        {
        }

        private static void WriteStringList(ref global::System.IO.FileStream stream, global::System.Collections.Generic.List<string> stringlist)
        {
        }

        private static void WriteInt(ref global::System.IO.FileStream file, int value, int length)
        {
        }

        private static void WriteInt32(ref global::System.IO.FileStream file, int v)
        {
        }

        private static void WriteInt16(ref global::System.IO.FileStream file, int v)
        {
        }

        private static void WriteInt8(ref global::System.IO.FileStream file, int v)
        {
        }

        public void ScaleAttributesByRating(int targetValue, global::SL.Player referencePlayer)
        {
        }

        public static bool IsFemalePlayer(int id)
        {
            return false;
        }

        public bool IsLegendaryPlayer()
        {
            return false;
        }

        public static bool IsLegendaryPlayer(int id)
        {
            return false;
        }

        public static bool IsIAPPlayer(int id)
        {
            return false;
        }

        public bool IsIAPPlayer()
        {
            return false;
        }

        public static int GetUIAbilityValue(int orgValue)
        {
            return 0;
        }

        public bool IsSkilledRole(FormationTool.UIPosition role)
        {
            return false;
        }

        public virtual global::SL.Player.Hexagram GetHexagram(bool isGK)
        {
            return default;
        }

        public global::SL.Player.Hexagram ConvertExp2Hexagram(in global::FL.PlayerExpStruct playerExp)
        {
            return default;
        }

        public global::SL.Player.Hexagram ConvertExp2Hexagram(in global::FL.PlayerExpStruct playerExp, bool isGK)
        {
            return default;
        }

        private int RandomValue(int baseValue, float minRate = 0.02f, float maxRate = 0.1f)
        {
            return 0;
        }

        public global::FL.PlayerExpStruct ConvertRatingValue2Exp(float rating, float minInvalidAttrScale = 0.02f, float maxInvalidAttrScale = 0.1f)
        {
            return default;
        }

        private static global::System.Collections.Generic.List<global::SL.Player> ReadBinary()
        {
            return null;
        }

        private unsafe static global::System.Collections.Generic.List<global::SL.Player> LoadPlayers(byte* ptr, int total_length)
        {
            return null;
        }

        private static global::SL.Player ReadPlayer(ref global::SL.Player.ReadBuff ptr_buff, global::System.Collections.Generic.List<string> nations, global::System.Text.StringBuilder sb_buffer)
        {
            return null;
        }

        private static global::System.Collections.Generic.List<string> ReadStringList(ref global::SL.Player.ReadBuff buff, global::System.Text.StringBuilder sb)
        {
            return null;
        }

        public static global::System.Collections.Generic.List<global::SL.Player> LoadFromFile()
        {
            return null;
        }

        private static void LoadApperance()
        {
        }

        public void CopyForm(global::SL.Player player, bool copyID = true)
        {
        }

        public virtual void FillDetailDataArchive(global::Srv.PlayerDetailData detailData)
        {
        }

        public virtual void LoadDetailDataArchive(global::Srv.PlayerDetailData detailData, bool loadName)
        {
        }

        public static void GeneratePlayer(ref global::SL.Player player, global::SL.Player template, string name = null)
        {
        }

        public static void LoadProtoFromArchives(ref global::SL.Player player, global::Srv.PlayerProtoReducedData archive)
        {
        }

        public static void SaveProtoToArchives(global::SL.Player player, ref global::Srv.PlayerProtoReducedData archive, int templateId)
        {
        }

        public static void LoadFakePlayerFromArchives(ref global::SL.Player player, global::Srv.FakePlayer archive)
        {
        }

        public static global::SL.Player GetTempPlayerByTemplate(int templateId, int id)
        {
            return null;
        }

        public static global::SL.Player CreateEmptyPlayer(int id, string name)
        {
            return null;
        }
    }
}