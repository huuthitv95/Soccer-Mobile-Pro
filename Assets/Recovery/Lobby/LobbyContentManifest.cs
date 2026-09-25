using System;
using UnityEngine;

namespace Soccer.Recovery.Lobby
{
    [CreateAssetMenu(menuName = "Recovery/Lobby Content Manifest")]
    public sealed class LobbyContentManifest : ScriptableObject, ILobbyContentProvider
    {
        [Serializable] public sealed class Entry
        {
            public string NativeAssetPath;
            public GameObject LocalPrefab;
            public string Guid;
        }
        [SerializeField] private Entry[] entries = Array.Empty<Entry>();
        public GameObject Resolve(string path)
        {
            foreach (var entry in entries)
                if (entry.NativeAssetPath == path && entry.LocalPrefab != null) return entry.LocalPrefab;
            return null;
        }
        public Entry[] Entries => entries;
        public void SetEntries(Entry[] value) { entries = value ?? Array.Empty<Entry>(); }
    }
}
