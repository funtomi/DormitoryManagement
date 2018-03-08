using System;

namespace susheSys.Models
{
	 public class TbchuangInfo
	{
		private int id;
		private string chuangnum;
		private int susheid;
		private string remark;
		private string pic;


		public int Id{
			get{
				return id;
			}
			set{
				id=value;
			}
		}

		public string Chuangnum{
			get{
				return chuangnum;
			}
			set{
				chuangnum=value;
			}
		}

		public int Susheid{
			get{
				return susheid;
			}
			set{
				susheid=value;
			}
		}

		public string Remark{
			get{
				return remark;
			}
			set{
				remark=value;
			}
		}

		public string Pic{
			get{
				return pic;
			}
			set{
				pic=value;
			}
		}

	}
}