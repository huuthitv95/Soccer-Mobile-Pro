namespace Common
{
    public class Util
    {
        public sealed class CsvTable
        {
            public readonly global::System.Collections.Generic.List<string> Header;
            public readonly global::System.Collections.Generic.Dictionary<string, int> HeaderIndex;
            public readonly global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> Rows;
            public readonly bool TrimFieldName;
            public CsvTable(global::System.Collections.Generic.List<string> header, global::System.Collections.Generic.Dictionary<string, int> headerIndex, global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> rows, bool trimFieldName)
            {
            }

            public bool TryGet(global::System.Collections.Generic.List<string> row, string field, out string value)
            {
                value = null;
                return false;
            }

            public string Get(global::System.Collections.Generic.List<string> row, string field, string defaultValue = "")
            {
                return null;
            }

            public bool HasField(string field)
            {
                return false;
            }
        }

        public static string first_open_timestamp;
        public static uint[] homePlayerColors;
        public static float[] rimIntensitys;
        public static uint[] homePlayerUIColors;
        public static global::System.Collections.Generic.List<int> BallNeedRotateX;
        public static global::System.Collections.Generic.List<int> BallNeedRotateZ;
        public static string DataPath => null;

        public static void GetFirstOpenTimestamp()
        {
        }

        public static string AppContentPath()
        {
            return null;
        }

        public static global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> ReadCsv(string fileName, bool skipHeadline = true)
        {
            return null;
        }

        public static global::Common.Util.CsvTable ReadCsvTable(string fileName, bool ignoreCase = true, bool trimHeader = true, bool checkutf8 = true)
        {
            return null;
        }

        public static global::Common.Util.CsvTable ReadCsvTable(string path, string fileName, bool ignoreCase = true, bool trimHeader = true, bool checkutf8 = true)
        {
            return null;
        }

        public static float GetScreenDiagonal()
        {
            return 0f;
        }

        public static string GetCsvPath()
        {
            return null;
        }

        public static bool IsCsvExist(string filename)
        {
            return false;
        }

        public static global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> ReadCsv(string path, string fileName, bool checkutf8, bool skipHeadline)
        {
            return null;
        }

        public static string ReadText(string path, string fileName, bool checkutf8)
        {
            return null;
        }

        public static byte[] ReadBytes(string path)
        {
            return null;
        }

        public static global::System.Collections.Generic.List<string> ReadAllLines(string fileName)
        {
            return null;
        }

        public static global::System.Collections.Generic.List<string> ReadAllLines(string path, string fileName)
        {
            return null;
        }

        private static string GetOrCreateString(char[] buffer, int length, string[] asciiPool)
        {
            return null;
        }

        public static global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> ConvertStringToLLS(string data, bool skipHeadline)
        {
            return null;
        }

        public static string Md5file(string filePath)
        {
            return null;
        }

        public static string VersionNumToStr(uint v)
        {
            return null;
        }

        public static uint VersionStrToNum(string vstr)
        {
            return 0u;
        }

        public static void TryGetCity(global::System.Action<string[]> OnGetResult, bool getIso = false)
        {
        }

        private static void Client_DownloadStringCompleted_City(object sender, global::System.Net.DownloadStringCompletedEventArgs e)
        {
        }

        public static void CheckNetwork()
        {
        }

        public static void TryGetTime(global::System.Action<global::System.DateTime> OnGetResult)
        {
        }

        private static void Client_DownloadTimeCompleted(object sender, global::System.Net.DownloadStringCompletedEventArgs e)
        {
        }

        public static bool HttpsCertificateValidationCallback(object sender, global::System.Security.Cryptography.X509Certificates.X509Certificate certificate, global::System.Security.Cryptography.X509Certificates.X509Chain chain, global::System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return false;
        }

        public static global::System.Collections.IEnumerator AccessRedirectUrl(string url, global::System.Action<string> onSuccess)
        {
            return null;
        }

        public static global::System.Collections.IEnumerator AccessUrl(string url)
        {
            return null;
        }

        public static float DistanceOfRGB(global::UnityEngine.Color color1, global::UnityEngine.Color color2, float bN = 1f)
        {
            return 0f;
        }

        public static float PerceptualDistance(global::UnityEngine.Color a, global::UnityEngine.Color b)
        {
            return 0f;
        }

        public static float DvalueOfRGB(global::UnityEngine.Color color1, global::UnityEngine.Color color2)
        {
            return 0f;
        }

        public static bool ColorApproximate(global::UnityEngine.Color color1, global::UnityEngine.Color color2)
        {
            return false;
        }

        public static bool IsBrightColor(global::UnityEngine.Color color)
        {
            return false;
        }

        public static bool LineIntersection(global::UnityEngine.Vector2 p0, global::UnityEngine.Vector2 p1, global::UnityEngine.Vector2 p2, global::UnityEngine.Vector2 p3, out global::UnityEngine.Vector2 intersection)
        {
            intersection = default;
            return false;
        }

        public static global::UnityEngine.Transform getListItem(global::UnityEngine.Transform list, int idx, global::UnityEngine.GameObject template = null)
        {
            return null;
        }

        public static global::UnityEngine.Color HexToColor(uint hex)
        {
            return default;
        }

        public static global::UnityEngine.Vector2 CalculateRelativePosition(global::UnityEngine.Transform root, global::UnityEngine.Transform node)
        {
            return default;
        }

        public static global::System.Collections.IEnumerator LoadImageFromUrl(string url, global::System.Action<bool, byte[], global::UnityEngine.Texture2D> OnCompleted)
        {
            return null;
        }

        public static void LoadImageFromPersistentDataPath(string path, global::System.Action<bool, byte[], global::UnityEngine.Texture2D> OnCompleted)
        {
        }

        public static bool SaveImage(string path, byte[] imageBytes)
        {
            return false;
        }

        public static int RandomGet(int sceneId, int length)
        {
            return 0;
        }

        public static int RandomGetTwo(int num1, int num2)
        {
            return 0;
        }

        public static void Client_DownloadStringCompleted_AdUnit(object sender, global::System.Net.DownloadStringCompletedEventArgs e)
        {
        }

        public static int GetRandomElement(int[] array, int[] weights)
        {
            return 0;
        }

        public static void OpenGooglePlayUrl(string url, string backup)
        {
        }

        public static void OpenURL(string url)
        {
        }

        public static void LimitTextMesh(global::UnityEngine.TextMesh textMesh, global::UnityEngine.Renderer textRenderer, float maxWidth, int minFontSize)
        {
        }

        private static byte[] GenerateKeyFromDeviceID(string deviceID, int keySize = 32)
        {
            return null;
        }

        public static byte[] SimpleEncrypt(byte[] data)
        {
            return null;
        }

        public static byte[] SimpleDecrypt(byte[] encryptedData)
        {
            return null;
        }

        public static string GetAndroidPublicPath(string folder)
        {
            return null;
        }

        public static void WritePersistentFile(string folder, string fileName, byte[] data)
        {
        }

        public static bool HasOcclusion(global::UnityEngine.Vector3 startPos, global::UnityEngine.Vector3 endPos, global::UnityEngine.GameObject target)
        {
            return false;
        }

        public static bool IsAssetsReady(string name)
        {
            return false;
        }

        public static byte[] GZipCompress(byte[] data)
        {
            return null;
        }
    }
}