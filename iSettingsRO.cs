/*
 * Created by SharpDevelop.
 * User: Raja
 * Date: 8/7/2012
 * Time: 6:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PrintNSend
{
	/// <summary>
	/// Description of iSettingsRO.
	/// </summary>
	public interface iSettingsRO
	{
		string username 
		{ get ;
			
		}
		
		string password 
		{ get ;
		}
		
		string smtpclient 
		{ get ;
		}
		
		int smtpport 
		{ get ;
		}
		
		string mailsubject 
		{ get ;
		}
		
		string mailto 
		{ get ;
		}
		
		string filepath 
		{ get ;
		}
		
		string mailbody 
		{ get ;
		}
		
		void load();
		
	}
}
