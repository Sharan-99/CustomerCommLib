﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCommLib
{
    public class CustomerCommunication
    {
		IMailSender _mailSender;

		public CustomerCommunication(IMailSender mailSender)
		{
			_mailSender = mailSender;
		}

		public bool SendMailToCustomer()
		{
			//Actual logic goes here
			//define message and mail address

			_mailSender.SendMail("cust123@abc.com","Some Message");

			return true;
		}

	}
}
