using System;

namespace susheSys.Models
{
	 public class TbsusheInfo
	{
		private int id;
		private string ssname;
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

		public string Ssname{
			get{
				return ssname;
			}
			set{
				ssname=value;
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