using System;

namespace susheSys.Models
{
	 public class TbruzhuInfo
	{
		private int id;
		private int chuangid;
		private int userid;
		private string ruzhudate;
		private string tuchudate;
		private int state;


		public int Id{
			get{
				return id;
			}
			set{
				id=value;
			}
		}

		public int Chuangid{
			get{
				return chuangid;
			}
			set{
				chuangid=value;
			}
		}

		public int Userid{
			get{
				return userid;
			}
			set{
				userid=value;
			}
		}

		public string Ruzhudate{
			get{
				return ruzhudate;
			}
			set{
				ruzhudate=value;
			}
		}

		public string Tuchudate{
			get{
				return tuchudate;
			}
			set{
				tuchudate=value;
			}
		}

		public int State{
			get{
				return state;
			}
			set{
				state=value;
			}
		}

	}
}