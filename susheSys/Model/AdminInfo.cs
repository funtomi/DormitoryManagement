using System;

namespace susheSys.Models
{
	 public class AdminInfo
	{
		private int id;
		private string name;
		private string pass;


		public int Id{
			get{
				return id;
			}
			set{
				id=value;
			}
		}

		public string Name{
			get{
				return name;
			}
			set{
				name=value;
			}
		}

		public string Pass{
			get{
				return pass;
			}
			set{
				pass=value;
			}
		}

	}
}