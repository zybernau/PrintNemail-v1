/*
 * Created by SharpDevelop.
 * User: Raja
 * Date: 8/7/2012
 * Time: 6:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Reflection;

namespace PrintNSend
{
	/// <summary>
	/// Description of iSettings.
	/// </summary>
	public interface iSettings
	{
			
		string username 
		{ get ;
			set;
		}
		
		string password 
		{ get ;
			set;
		}
		
		string smtpclient 
		{ get ;
			set;
		}
		
		int smtpport 
		{ get ;
			set;
		}
		
		string mailsubject 
		{ get ;
			set;
		}
		
		string mailto 
		{ get ;
			set;
		}
		
		string filepath 
		{ get ;
			set;
		}
		
		string mailbody 
		{ get ;
			set;
		}
		
		void save();
		void load();
		
	}
}
