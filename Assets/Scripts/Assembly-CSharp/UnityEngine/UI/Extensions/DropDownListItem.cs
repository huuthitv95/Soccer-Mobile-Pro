namespace UnityEngine.UI.Extensions
{
	[global::System.Serializable]
	public class DropDownListItem
	{
		[global::UnityEngine.SerializeField]
		private string _caption;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Sprite _image;

		[global::UnityEngine.SerializeField]
		private bool _isDisabled;

		[global::UnityEngine.SerializeField]
		private string _id;

		public global::System.Action OnSelect;

		internal global::System.Action OnUpdate;

		public string Caption
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.Sprite Image
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsDisabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string ID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DropDownListItem(string caption = "", string inId = "", global::UnityEngine.Sprite image = null, bool disabled = false, global::System.Action onSelect = null)
		{
		}
	}
}
