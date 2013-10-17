using System;

namespace Gladiateur
{
	public class Team
	{
		private int id, playedMatchs, wonMatchs, lostMatchs;
		private double ratioWin;
		private string userAlias, name, description;

		public Team (string p_name, string p_desc)
		{
			this.name = p_name;
			this.description = p_desc;
			this.id = 1;
			this.userAlias = "Trollolo";
			this.playedMatchs = 5;
			this.wonMatchs = 3;
			this.lostMatchs = 2;
			this.ratioWin = this.wonMatchs / this.lostMatchs;
		}

	}
}

