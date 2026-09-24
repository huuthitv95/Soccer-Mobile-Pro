namespace SL
{
	public struct FormationTemplate
	{
		public int NmaeCode;

		public string name { get; private set; }

		public FormationTool.UIRole[] data { get; private set; }

		public int code { get; private set; }

		public FormationTemplate(string name, FormationTool.UIRole[] formation, int code, int nameCode)
		{
			this.name = null;
			data = null;
			this.code = 0;
			NmaeCode = 0;
		}

		public FormationTemplate(string name, FormationTool.UIRole[] formation, int code)
		{
			this.name = null;
			data = null;
			this.code = 0;
			NmaeCode = 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
