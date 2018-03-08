using System;

namespace susheSys.Models
{
	 public class TbuserInfo
	{
		private int id;
		private string name;
		private string pwd;
		private string sex;
		private string phone;
		private string address;
		private string email;
		private string remark;
		private string uname;


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

		public string Pwd{
			get{
				return pwd;
			}
			set{
				pwd=value;
			}
		}

		public string Sex{
			get{
				return sex;
			}
			set{
				sex=value;
			}
		}

		public string Phone{
			get{
				return phone;
			}
			set{
				phone=value;
			}
		}

		public string Address{
			get{
				return address;
			}
			set{
				address=value;
			}
		}

		public string Email{
			get{
				return email;
			}
			set{
				email=value;
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

		public string Uname{
			get{
				return uname;
			}
			set{
				uname=value;
			}
		}

	}
}