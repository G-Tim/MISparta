using System;

namespace Gladiateur
{
	public class Team
	{
		private int id, playedMatchs, wonMatchs, lostMatchs;
		private double ratioWin;
		private string userAlias, name, description;

		public Team (string p_name, string p_desc)
			:base(id, userAlias, playedMatchs, wonMatchs, lostMatchs,ratioWin)
		{
			this.name = p_name;
			this.description = p_desc;

		}
	}
}

